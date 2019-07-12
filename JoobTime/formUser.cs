using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoobTime
{
    public partial class formUser : DevExpress.XtraEditors.XtraForm
    {
        Class_sql _sql = new Class_sql();
        class_date _date = new class_date();
        total_sum_time_span _totalTimeSummary = new total_sum_time_span();
        DataTable dtTotal;
        string date_start;
        string date_end;
        
        public formUser()
        {
            InitializeComponent();
            get_time_dtEdit(cmb_season.Text);
            load_dtTotal();
            selectGridView();
        }

        public void get_time_dtEdit(string season)
        {
            switch (season)
            {
                case "За месяц":
                    int countday = DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month);
                    dEdit_start.DateTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                    dEdit_end.DateTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, countday);
                    break;
                case "За день":
                    dEdit_start.DateTime = DateTime.Now;
                    dEdit_end.DateTime = DateTime.Now;
                    break;
            }
            date_start = dEdit_start.DateTime.ToShortDateString();
            date_end = dEdit_end.DateTime.ToShortDateString();
        }

        private void windowsUIButtonPanel1_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            switch (e.Button.Properties.Tag)
            {
                case 0:
                    grid_total.Select();
                    load_dtTotal();
                    break;
                case 1:
                    formLogin FormLogin = new formLogin();
                    Hide();
                    FormLogin.Show();
                    break;
            }
        }

        public void load_dtTotal()
        {
            string comand = @"SELECT* FROM[total] join work on work.id_work = total.id_work
                     WHERE[id_tn] = '" + formLogin.id_tn + "'"
                      + "AND [date]>='" + date_start + "'"
                      + "AND [date]<='" + date_end + "'";
            dtTotal = _sql.sql_dt(comand,"t1");
            grid_total.DataSource = dtTotal;
        }

        private void formUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dEdit_start_EditValueChanged(object sender, EventArgs e)
        {
            date_start = _date.convert(dEdit_start.DateTime);
        }

        private void dEdit_end_EditValueChanged(object sender, EventArgs e)
        {
            date_end = _date.convert(dEdit_end.DateTime);
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            get_time_dtEdit(cmb_season.Text);
        }

        private void gridView1_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            _totalTimeSummary.to_time_span(sender,e);
        }

        private void comboBoxEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)
            {
                switch (cmb_ReportPrint.Text)
                {
                    case "report1":
                        MessageBox.Show("report1");
                        break;
                    case "report2":
                        MessageBox.Show("report2");
                        break;
                    case "report3":
                        MessageBox.Show("report3");
                        break;
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            newAdd.caption_f = "Добавить";
            newAdd formAdd = new newAdd();
            formAdd.ShowDialog();
        }

        private void formUser_Activated(object sender, EventArgs e)
        {
            load_dtTotal();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string totalId = gridView1.GetFocusedRowCellValue("id").ToString();
            newAdd.total_id= totalId;
            newAdd.caption_f = "Изменить";
            newAdd formAdd = new newAdd();
            formAdd.ShowDialog();
        }

        public void selectGridView()
        {
            string nameView = xlsx_.read_xlsx("gridName");
            grid_total.MainView.Name = nameView;
        }

        private void windowsUIButtonPanel1_ButtonChecked(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            if (e.Button.Properties.Tag.ToString()=="2" )
            {
                grid_total.MainView = gridView_konstr;
                xlsx_.write_xml(grid_total.MainView.Name, "gridName");
            }
        }

        private void windowsUIButtonPanel1_ButtonUnchecked(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            if (e.Button.Properties.Tag.ToString() == "2")
            {
                if (formLogin.subunit == "1015" || formLogin.subunit == "1022")
                {
                    grid_total.MainView = PBView;
                }
                else
                {
                    grid_total.MainView = gridView1;
                }
                xlsx_.write_xml(grid_total.MainView.Name, "gridName");
            }
        }
    }
}
