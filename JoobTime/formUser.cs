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
            if (e.Button.Properties.Tag.ToString() == "0")
            {
                grid_total.Select();
                load_dtTotal();
            }
            else if (e.Button.Properties.Tag.ToString() == "1")
            {
                formLogin FormLogin = new formLogin();
                Hide();
                FormLogin.Show();
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
            
        }
    }
}
