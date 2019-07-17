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
using JoobTime.Properties;

namespace JoobTime
{
    public partial class formLogin : DevExpress.XtraEditors.XtraForm
    {
        Class_sql _sql = new Class_sql();
        DataTable dtWorker;
        DataRow rowWorkerInfo;
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
            string comand = @"Select worker.*,concat(Last_name,' ',First_name,' ',Second_name)fio,subunit,position  from worker join subunit on subunit.id_subunit = worker.id_Subunit join Position on Position.id_position = worker.id_Position";
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
                rowWorkerInfo = LoginInfo.ElementAt(0);
                
                string ParolInfo = rowWorkerInfo["password"].ToString();
                string status = rowWorkerInfo["status"].ToString();
                subunit = rowWorkerInfo["id_Subunit"].ToString();
                FIO = rowWorkerInfo["fio"].ToString();
                if (ParolInfo == parol)
                {
                    id_tn = login;
                    PropertiesSet(rowWorkerInfo);
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
            if (status == "s"|| status == "r")
            {
                formUser.status = status;
                formUser user = new formUser();
                user.Show();
                Hide();
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
        
        private void PropertiesSet(DataRow rowWorker)
        {
            Settings_WD.Default.id_tn = Convert.ToInt32(id_tn);
            Settings_WD.Default.Save();
            
            Settings_WD.Default.subunit_id = Convert.ToInt32(rowWorker["id_Subunit"]);
            Settings_WD.Default.position = rowWorker["position"].ToString();
            Settings_WD.Default.FullFIO = rowWorker["Last_name"] + " " +
                                      rowWorker["First_name"] + " " +
                                     rowWorker["Second_name"];
            Settings_WD.Default.FIO = rowWorker["Last_name"] + " " +
                                  rowWorker["First_name"].ToString().Substring(0, 1) + ". " +
                                   rowWorker["Second_name"].ToString().Substring(0, 1) + ".";
            Settings_WD.Default.isBoss = rowWorker["status"].Equals("r");
            Settings_WD.Default.subunit = rowWorker["subunit"].ToString();
        }
    }
}
