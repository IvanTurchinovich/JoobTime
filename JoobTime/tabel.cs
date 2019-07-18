using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraPrinting.Native;

namespace JoobTime
{
    public partial class tabel : DevExpress.XtraEditors.XtraForm
    {
        private Class_sql sql = new Class_sql();
        private string subunit;
        private DateTime searchdate;
        private List<LabelControl> labelList=new List<LabelControl>();
        private List<TextEdit> textList = new List<TextEdit>();
        private List<int> idList = new List<int>();
        private List<int> insertList = new List<int>();
        private List<int> updateList = new List<int>();
        private int LabelPositionX;
        private int TextEditPositionX;

        public tabel(string subunit, DateTime date)
        {
            this.subunit = subunit;
            searchdate = date;
            InitializeComponent();
            GenerateForm();
        }

        private void GenerateForm()
        {
            Size = new Size(360, 130);
            labelList.Add(startLabel);
            textList.Add(startTextEdit);
            LabelPositionX = startLabel.Location.X;
            TextEditPositionX = startTextEdit.Location.X;
            TitleLabel.Text = "Табель сотрудников " + (subunit == "Все" ? "" : subunit + " ") + "за " +
                              searchdate.ToString("MMMM ") + searchdate.Year;
            idList =sql.sql_dt(
                    @"select distinct id_tn from total where"+(subunit == "Все" ? "" :" (select id_Subunit from subunit where subunit='"+subunit+"')=id_subunit_worker and" )+" date between '"+searchdate.ToString("yyyy-MM-01")+"' and '"+searchdate.ToString("yyyy-MM-"+DateTime.DaysInMonth(searchdate.Year,searchdate.Month))+"' order by id_tn", "t1").Select().Select(input => Convert.ToInt32(input[0])).ToList();
            int addHeight = 0;
            foreach (var tabel in idList)
            {
                if (addHeight == 0 && LabelPositionX==startLabel.Location.X)
                {
                    addHeight += 30;
                    continue;
                }
                LabelControl label = new LabelControl();
                label.Name = "label" + addHeight;
                label.AutoSizeMode = LabelAutoSizeMode.None;
                label.Width = startLabel.Width;
                label.Height = startLabel.Height;
                label.Location = new Point(LabelPositionX, startLabel.Location.Y + addHeight);

                TextEdit textEdit = new TextEdit();
                textEdit.Name = "text" + addHeight;
                textEdit.Width = startTextEdit.Width;
                textEdit.Height = startLabel.Height;
                textEdit.Properties.Mask.EditMask = @"\d{0,5}:[0-5]\d";
                textEdit.Properties.Mask.MaskType = MaskType.RegEx;
                textEdit.Location=new Point(TextEditPositionX,startTextEdit.Location.Y+addHeight);
                this.Controls.Add(label);
                this.Controls.Add(textEdit);
                labelList.Add(label);
                textList.Add(textEdit);
                addHeight += 33;
                if (labelList.Count%20==0 && idList.Count!=labelList.Count)
                {
                    addHeight = 0;
                    LabelPositionX += 360;
                    TextEditPositionX += 360;
                    MaximumSize = new Size(Size.Width + 360, Size.Height);
                    Size = new Size(Size.Width + 360, Size.Height);
                }
            }
            SimpleButton button = new SimpleButton();
            button.Name = "button1";
            button.Width = 115;
            button.Height = 30;
            button.Text = "Подтвердить";
            button.Click+=button_Click;
            int buttonLocationX = this.Size.Width / 2 - 57;
            int buttonLocationY = (labelList.Count >= 20) ? labelList[19].Location.Y + 30:startLabel.Location.Y+addHeight;
            MaximumSize = new Size(Size.Width, buttonLocationY + 70);
            Size = new Size(Size.Width, buttonLocationY + 70);
            button.Location = new Point(buttonLocationX,buttonLocationY);
            this.Controls.Add(button);
            FillLabels();
            FillEdits();
            
        }

        private void FillLabels()
        {
            DataTable table = sql.sql_dt(@"select distinct id_tn,FIO from total where"+(subunit == "Все" ? "" :" (select id_Subunit from subunit where subunit='"+subunit+"')=id_subunit_worker and" )+" date between '"+searchdate.ToString("yyyy-MM-01")+"' and '"+searchdate.ToString("yyyy-MM-"+DateTime.DaysInMonth(searchdate.Year,searchdate.Month))+"'", "t1");
            int count = 0;
            foreach (DataRow row in table.Rows)
            {
                labelList[count].Text = row["id_tn"] + " "+ row["FIO"] ;
                count++;
            }
        }
        private void FillEdits()
        {
            string query = @"select * from tabel join worker on tabel.id_tn=worker.id_tn where" +
                           (subunit == "Все"
                               ? ""
                               : " (select id_Subunit from subunit where subunit='" + subunit + "')=id_Subunit and") +
                           " tdate between '" + searchdate.ToString("yyyy-MM-01") + "' and '" +
                           searchdate.ToString("yyyy-MM-" + DateTime.DaysInMonth(searchdate.Year, searchdate.Month)) +
                           "'";
            DataTable table = sql.sql_dt(query, "t1");
            foreach (DataRow row in table.Rows)
            {
                if (!idList.Contains(Convert.ToInt32(row["id_tn"])))
                continue;
                int id=idList.IndexOf(Convert.ToInt32(row["id_tn"]));
                updateList.Add(id);
                textList[id].Text = row["ttime"].ToString();
            }
                for(int i=0; i<idList.Count;i++)
            {
                if(updateList.Contains(i))
                    continue;
                insertList.Add(i);
            }
            }
        private void button_Click(object sender, EventArgs e)
        {
            insertValues();
            updateValues();
            Close();
        }

        private void insertValues()
        {
            if (insertList.Count == 0)
                return;
            string query = @"insert into tabel values";
            foreach (var val in insertList)
            {
                if (textList[val].Text == "") continue;
                query = query + ",(" + labelList[val].Text.Split(' ')[0] + ", '" + searchdate.ToString("yyyy-MM-01") + "','" + textList[val].Text + "')";
            }
            query = query.Replace("s,(", "s(");
            sql.update_comand(query);
        }

        private void updateValues()
        {
            if(updateList.Count==0)
                return;
            string query = @"update tabel set ttime= CASE id_tn";
            foreach (var val in updateList)
            {
                if(textList[val].Text=="") continue;
                query = query + " when " + labelList[val].Text.Split(' ')[0] + " then '" + textList[val].Text + "'";
            }
            query = query + " else ttime END where tdate between '" + searchdate.ToString("yyyy-MM-01") + "' and '" +
                    searchdate.ToString("yyyy-MM-" + DateTime.DaysInMonth(searchdate.Year, searchdate.Month)) +
                    "'";
            sql.update_comand(query);
        }
        private void tabel_Load(object sender, EventArgs e)
        {
            
        }

        private void Args_Showing(object sender, XtraMessageShowingArgs e)
        {
            
        }

        private void TitleLabel_Click_1(object sender, EventArgs e)
        {
            XtraInputBoxArgs args = new XtraInputBoxArgs();
            args.Caption = "Месяц табеля";
            args.Prompt = "Табель за месяц";
            args.DefaultButtonIndex = 0;
            args.Showing += Args_Showing;
            DateEdit editor = new DateEdit();
            editor.Properties.MaxValue=DateTime.Now;
            editor.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            editor.Properties.Mask.EditMask = "MMMM yyyy";
            args.Editor = editor;
            args.DefaultResponse = DateTime.Now.Date;
            var result = XtraInputBox.Show(args);
            if(result == null)
                return;
            searchdate = DateTime.Parse(result.ToString());
            ClearForm();
            GenerateForm();
        }

        private void ClearForm()
        {
            for (int i = 1; i < labelList.Count; i++)
            {
                Controls.Remove(labelList[i]);
                Controls.Remove(textList[i]);
            }
            Controls.RemoveByKey("button1");
            labelList.Clear();
            textList.Clear();
            insertList.Clear();
            updateList.Clear();
        }

        private void startLabel_Click(object sender, EventArgs e)
        {

        }

    }
}