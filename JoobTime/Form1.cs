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
using DevExpress.XtraEditors;

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
            string comand = "select id_tn, password, status from worker";
            dtWorker = _sql.sql_dt(comand,"t1");
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string login = txt_login.Text;
            string parol = txt_password.Text;
            var LoginInfo = from DataRow row in dtWorker.Rows
                            where row["id_tn"].ToString() == login
                            select row;
            if (LoginInfo.Count() != 0)
            {
                DataRow rowWorkerInfo = LoginInfo.ElementAt(0);
                string ParolInfo = rowWorkerInfo["password"].ToString();
                string status = rowWorkerInfo["status"].ToString();
                if (ParolInfo == parol)
                {
                    XtraMessageBox.Show("Вы ввели верный пароль "+  login +"\\"+parol+"\\"+status);
                    id_tn = login;
                    showNextForm(status);
                }
                else
                {
                   XtraMessageBox.Show("Вы ввели неверный логин или пароль, попробуйте еще раз.", "Ошибка авторизации");
                }
            }
            else
            {
                XtraMessageBox.Show("Вы ввели неверный логин или пароль, попробуйте еще раз.", "Ошибка авторизации");
            }
        }

        public void showNextForm(string status)
        {
            if (status == "s")
            {
                formUser user = new formUser();
                user.Show();
                Hide();
            }
            else if (status == "r")
            {

            }
            else if (status == "admin")
            {

            }
        }
    }
}
