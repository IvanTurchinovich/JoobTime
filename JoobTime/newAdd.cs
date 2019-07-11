﻿using System;
using System.Data;
using System.Windows.Forms;
using System.Threading;
using DevExpress.XtraEditors;
using System.Linq;

namespace JoobTime
{
    public partial class newAdd : DevExpress.XtraEditors.XtraForm
    {
        class_date _Date = new class_date();
        Class_sql _Sql = new Class_sql();
        public static string total_id;
        public static string caption_f;
        public DataTable dtWork;
        private DataTable dtSubunit;
        private DataTable dtOtherDistinkt;
        private DataTable dtWorker;
        private DataTable dtTotal;

        public void timeToLabel()
        {
            DateTime selectDate = date_AddRecord.DateTime.Date;
            string query = @"SELECT [time_span] FROM [total] 
                              WHERE [id_tn]='" +formLogin.id_tn + "'"
                             + "AND [date]='" + _Date.convert(date_AddRecord.DateTime) + "'";
            DataTable dtHours = _Sql.sql_dt(query, "t1");

            if (dtHours.Rows.Count != 0)
            {
                TimeSpan ts1 = new TimeSpan(0, 0, 0);
                for (int i = 0; i < dtHours.Rows.Count; i++)
                {
                    ts1 += TimeSpan.Parse(dtHours.Rows[i]["time_span"].ToString());
                }
                lblTime.Text = ts1.ToString().Substring(0,5);
            }
            else
            {
                lblTime.Text = "00:00";
            }
        }

        public void max_time()
        {
            string query = @"select max(total.time_end) from total where date='" +
                           date_AddRecord.DateTime.ToShortDateString() + "' and id_tn=" + formLogin.id_tn;
            DataTable dtMaxDate = _Sql.sql_dt(query, "t1");
            if (dtMaxDate.Rows[0][0].ToString()!="" || !string.IsNullOrEmpty(dtMaxDate.Rows[0][0].ToString()))
            {
                TimeSpan ts = TimeSpan.Parse(dtMaxDate.Rows[0][0].ToString());

                if (ts == TimeSpan.Parse("12:00"))
                {
                    tmEdt_start.TimeSpan = TimeSpan.Parse("12:30");
                }
                else
                {
                    tmEdt_start.TimeSpan = ts;
                }
            }
        }

        public void write_saveWork(bool check)
        {
            switch (check)
            {
                case true:
                    xlsx_.write_xml("save_work", "1");
                    if (lUp_work.Text == "")
                    {
                        lUp_work.Text = xlsx_.read_xlsx("save_work_name");
                    }
                    else
                    {
                        xlsx_.write_xml("save_work_name", lUp_work.Text);
                    }
                    break;
                case false:
                    xlsx_.write_xml("save_work", "2");
                    break;
            }
        }

        public void load_dtWorker(string id_tn)
        {
            string comand = @" select 
                                      wr.id_tn,(wr.Last_name+' '+SUBSTRING(wr.First_name,0,2)+'. '+SUBSTRING(wr.Second_name,0,2)+'.') fio,wr.id_Position, ps.position,wr.id_Subunit,sb.subunit,wr.category,wr.software,wr.photo
	                             from 
                                      worker wr
                            left join 
                                      position ps on ps.id_position=wr.id_Position
                            left join 
                                      subunit sb on sb.id_subunit=wr.id_Subunit 
                                where
                                      id_tn="+ id_tn;
            dtWorker = _Sql.sql_dt(comand, "t1");
        }

        public void load_dtWork(string id_position)
        {
            string comand = "select id_work, work from work where id_position=" + id_position;
            dtWork = _Sql.sql_dt(comand,"t1");
        }

        public void load_dtSubunit()
        {
            string comand = "select*from subunit";
            dtSubunit = _Sql.sql_dt(comand,"t1");
        }

        public void load_dtOtherDistinkt()
        {
            string comand= @"select distinct other, work  from total where id_tn=" + formLogin.id_tn
                            + " AND [date]>='" + extremeDay(date_AddRecord.DateTime,true) + "'"
                            + " AND [date]<='" + extremeDay(date_AddRecord.DateTime, false) + "'";
            dtOtherDistinkt = _Sql.sql_dt(comand,"t1");
        }

        public void load_dtTotal(string id_record)
        {
            string comand = @"select tl.id, tl.subunit,tl.work,tl.date,tl.time_begin,tl.time_end,tl.other from total tl where id=" + id_record;
            dtTotal = _Sql.sql_dt(comand, "t1");
        }

        public string extremeDay(DateTime selectDate, bool firstOrLast)
        {
            if (firstOrLast)
            {
                string firstDay = selectDate.Year.ToString() + "-" + selectDate.Month.ToString() + "-01";
                return firstDay;
            }
            else
            {
                string day = DateTime.DaysInMonth(selectDate.Year, selectDate.Month).ToString();
                string lastDay = selectDate.Year.ToString() + "-" + selectDate.Month.ToString() + "-" + day;
                return lastDay;
            }
        }

        public void form_size()
        {
            int h=int.Parse(xlsx_.read_xlsx("add_size_h"));
            int w = int.Parse(xlsx_.read_xlsx("add_size_w"));
            Height = h;
            Width = w;
        }

        public newAdd()
        {
            InitializeComponent();
            load_dtWorker(formLogin.id_tn);
            load_dtWork(dtWorker.Rows[0]["id_Subunit"].ToString());
            load_dtSubunit();
            form_size();
            if (caption_f == "Добавить")
            {
                date_AddRecord.DateTime = DateTime.Now;
                max_time();
            }
            else if (caption_f == "Изменить")
            {
                load_dtTotal(total_id);
                if (dtTotal.Rows.Count != 0)
                {
                    dataEditInComponent();
                }
            }
            load_dtOtherDistinkt();
            timeToLabel();
        }

        public void dataEditInComponent()
        {
            date_AddRecord.DateTime = Convert.ToDateTime(dtTotal.Rows[0]["date"].ToString());
            tmEdt_start.TimeSpan = TimeSpan.Parse(dtTotal.Rows[0]["time_begin"].ToString());
            tmEdt_end.TimeSpan = TimeSpan.Parse(dtTotal.Rows[0]["time_end"].ToString());
            lUp_subunit.Text = dtTotal.Rows[0]["subunit"].ToString();
            lUp_work.Text= dtTotal.Rows[0]["work"].ToString();
            lUp_other.Text=dtTotal.Rows[0]["other"].ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (lUp_subunit.Text != "" && lUp_work.Text != "" && tmEdt_end.Text != "" && tmEdt_start.Text != "" && tmEdt_start.TimeSpan < tmEdt_end.TimeSpan && date_AddRecord.Text != "")
            {
                if (caption_f == "Добавить")
                {
                
                        addNewRecord();
                        saveTextControl();
                        editStartTime();               
                }
                else if (caption_f == "Изменить")
                {
                    changeRecord();
                }
            }
            else
            {
                //msgbox.msg = "Не все поля заполнены!";
                XtraMessageBox.Show("Не все поля заполнены!","Ошибка добавления/изменения записи");
            }
        }

        public void editStartTime()
        {
            tmEdt_start.TimeSpan = tmEdt_end.TimeSpan;
            tmEdt_end.Text = null;
        }

        public void loadTextControl()
        {
            string work=xlsx_.read_xlsx("save_work_name");
            var rowWorks = from DataRow row in dtWork.Rows
                           where row["work"].ToString() == work
                           select row;
            if (rowWorks.Count() != 0)
            {
                DataRow row1 = rowWorks.ElementAt(0);
                lUp_work.EditValue = Convert.ToInt32(row1["id_work"].ToString());
            }
            string other = xlsx_.read_xlsx("save_other");
            lUp_other.EditValue = other;
           
        }

        public void saveTextControl()
        {
            xlsx_.write_xml("save_work_name", lUp_work.Text);
            xlsx_.write_xml("save_other", lUp_other.Text);
        }

        public void addNewRecord()
        {
            string fio = dtWorker.Rows[0]["fio"].ToString();
            string date = _Date.convert(date_AddRecord.DateTime);
            string time_start = tmEdt_start.TimeSpan.ToString();
            string time_end = tmEdt_end.TimeSpan.ToString();
            string time_span = (TimeSpan.Parse(time_end) - TimeSpan.Parse(time_start)).ToString();
            string time_add = DateTime.Now.ToShortTimeString().ToString();
            string id_tn = dtWorker.Rows[0]["id_tn"].ToString();
            string subunit = lUp_subunit.Text;
            string work = lUp_work.Text;
            string id_work = lUp_work.GetColumnValue("id_work").ToString();
            string id_subunit_worker = dtWorker.Rows[0]["id_subunit"].ToString();
            string position = dtWorker.Rows[0]["position"].ToString();
            string other = memoOther.Text;

            string comand = string.Format(@"INSERT INTO [dbo].[total]
                                                   ([FIO]
                                                   ,[position]
                                                   ,[subunit]
                                                   ,[id_work]
                                                   ,[work]
                                                   ,[date]
                                                   ,[time_begin]
                                                   ,[time_end]
                                                   ,[other]
                                                   ,[add_time]
                                                   ,[id_tn]
                                                   ,[time_span]
		                                           ,[id_subunit_worker])
          
                                             VALUES
                                                   ('{0}',
                                                    '{1}',
                                                    '{2}',
                                                     {3}, 
                                                    '{4}',
                                                    '{5}',
                                                    '{6}', 
                                                    '{7}', 
                                                    '{8}',  
                                                    '{9}', 
                                                     {10}, 
                                                    '{11}',  
                                                     {12}
                                                   )", fio, position, subunit, id_work, work, date, time_start, time_end, other, time_add, id_tn, time_span, id_subunit_worker);
            if (_Sql.UpdateComand(comand))
            {
                //msgbox.msg = "Запись добавлена успешно.";
                XtraMessageBox.Show("Запись добавлена успешно.", "Добавление записи");
            }
        }

        public void changeRecord()
        {
            string date = _Date.convert(date_AddRecord.DateTime);
            string time_start = tmEdt_start.TimeSpan.ToString();
            string time_end = tmEdt_end.TimeSpan.ToString();
            string time_span = (TimeSpan.Parse(time_end) - TimeSpan.Parse(time_start)).ToString();
            string time_add = DateTime.Now.ToShortTimeString().ToString();
            string subunit = lUp_subunit.Text;
            string work = lUp_work.Text;
            string id_work = lUp_work.GetColumnValue("id_work").ToString();
            string other = memoOther.Text;

            string comand = string .Format( @"UPDATE [dbo].[total]
                                 SET  [subunit] =    '{0}'
                                     ,[id_work] =     {1}
                                     ,[work] =       '{2}'
                                     ,[date] =       '{3}'
                                     ,[time_begin] = '{4}'
                                     ,[time_end] =   '{5}'
                                     ,[other] =      '{6}'
                                     ,[add_time] =   '{7}'
                                     ,[time_span] =  '{8}'
                               WHERE id=              {9}",subunit,id_work,work,date,time_start,time_end,other,time_add, time_span,total_id);
            if (_Sql.UpdateComand(comand))
            {
                //msgbox.msg = "Запись успешно изменена.";
                XtraMessageBox.Show("Запись успешно изменена.", "Изменение записи");
            }
        }

        public void lUpSubunit_loadData()
        {
            lUp_subunit.Properties.DataSource = dtSubunit;
        }

        public void lUpWork_loadData()
        {
            lUp_work.Properties.DataSource = dtWork;
        }

        public void lUpOthers_loadData()
        {
            lUp_other.Properties.DataSource = dtOtherDistinkt;
        }

        private void add_Load(object sender, EventArgs e)
        {
            lUpSubunit_loadData();
            lUpWork_loadData();
            lUpOthers_loadData();
            lUp_subunit.Text = dtWorker.Rows[0]["subunit"].ToString();
            Text = caption_f;
            btn_add.Text = caption_f;
            tmEdt_start.Select();
            if (caption_f == "Добавить")
            {
                loadTextControl();
            }
        }

        private void dateEdit1_EditValueChanged_1(object sender, EventArgs e)
        {
            timeToLabel();
            if (caption_f == "Добавить")
            {
                Thread dd = new Thread(this.max_time);
                dd.Start();
            }
        }

        private void add_ResizeEnd(object sender, EventArgs e)
        {
            lUp_work.SelectionLength = 0;
            lUp_subunit.SelectionLength = 0;
            lUp_other.SelectionLength = 0;
            memoOther.SelectionLength = 0;
            date_AddRecord.SelectionLength = 0;
            tmEdt_start.SelectionLength = 0;
            tmEdt_end.SelectionLength = 0;
            xlsx_.write_xml("add_size_h",Height.ToString());
            xlsx_.write_xml("add_size_w",Width.ToString());
        }

        private void date_AddRecord_EditValueChanged(object sender, EventArgs e)
        {
            timeToLabel();
            if (caption_f == "Добавить")
            {
                Thread dd = new Thread(this.max_time);
                dd.Start();
            }
        }

        private void memoOther_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                simpleButton1_Click(this, EventArgs.Empty);
            }
        }

        private void lUp_other_Leave(object sender, EventArgs e)
        {
            memoOther.Text = lUp_other.Text;
        }

        private void lUp_work_EditValueChanged(object sender, EventArgs e)
        {
            dtOtherDistinkt.DefaultView.RowFilter = "[work] ='" + lUp_work.Text + "'";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }
    }
}