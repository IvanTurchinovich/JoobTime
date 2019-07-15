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
    public partial class formLogin : DevExpress.XtraEditors.XtraForm
    {
        Class_sql _sql = new Class_sql();
        DataTable dtWorker;
        public static string id_tn;
        public static string subunit;
        public static string info;
        public static string FIO;
        public static string version;

        public formLogin()
        {
            InitializeComponent();
            load_dtWorker();
            txt_login.Text = xlsx_.read_xlsx("login_save");
        }

        public void load_dtWorker()
        {
            string comand = "select id_tn, password, status, id_Subunit from worker";
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
                subunit = rowWorkerInfo["id_Subunit"].ToString();
                if (ParolInfo == parol)
                {
                    id_tn = login;
                    showNextForm(status);
                }
                else
                {
                   XtraMessageBox.Show("Вы ввели неверный пароль, попробуйте еще раз.", "Ошибка авторизации");
                }
                xlsx_.write_xml("login_save",login);
            }
            else
            {
                XtraMessageBox.Show("Вы ввели неверный логин, попробуйте еще раз.", "Ошибка авторизации");
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
                XtraMessageBox.Show("Вы ввели верный пароль \\" + status+" Но форма руководителя еще не готова");
            }
            else if (status == "admin")
            {
                XtraMessageBox.Show("Вы ввели верный пароль " + status);
            }
        }

        private void check_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            switch (check_showPassword.Checked)
            {
                case true:
                    txt_password.Properties.UseSystemPasswordChar = false;
                    break;
                case false:
                    txt_password.Properties.UseSystemPasswordChar = true;
                    break;
            }
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login_Click(sender, e);
            }
        }

        private void formLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void formLogin_Load(object sender, EventArgs e)
        {
            txt_password.Select();
        }
    }
}
