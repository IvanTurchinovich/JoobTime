using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Xpf.Core;


namespace JoobTime
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        Class_sql _sql = new Class_sql();
        DataTable dtWorker;
        public static string id_tn;

        public Form1()
        {
            InitializeComponent();
            load_dtWorker();
        }

        public void load_dtWorker()
        {
            string comand = "select id_tn, password from worker";
            dtWorker = _sql.sql_dt(comand,"t1");
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string login = txt_login.Text;
            string parol = txt_password.Text;
            var LoginInfo = from DataRow row in dtWorker.Rows
                               where row["id_tn"].ToString() == login
                               select row["password"];
            string ParolInfo = LoginInfo.ElementAt(0).ToString();
            if (ParolInfo == parol)
            {

            }
            else
            {
                
            }
        }
    }
}
