using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
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
        DataTable dtWorker;
        DataTable dtCmbBoxSubunit;
        public static string status;
        string date_start;
        string date_end;
        
        public formUser()
        {
            InitializeComponent();
            get_time_dtEdit(cmb_season.Text);
            if (status == "s")
            {
                load_dtTotal();
                load_dtWorker();
                cmb_ReportPrint_AddItems();
            }
            else if (status == "r")
            {
                load_dtCmbBoxSubunit();
                btn_tabel.Visible = true;
                btn_prices.Visible = true;
                btn_report.Visible = true;
                cmb_subunit.Visible = true;
            }
            selectGridView();
            groupButton.CustomHeaderButtons[0].Properties.Checked =Convert.ToBoolean(xlsx_.read_xlsx("groupExpand"));
            groupColumnData(true);
        }

        public void groupColumnData(bool IsLoad)
        {
            GridView view = (GridView)grid_total.FocusedView;
            if (view != null)
            {
                if (IsLoad)
                {
                    int groupIndex = Convert.ToInt32(xlsx_.read_xlsx("group_params"));
                    view.Columns["date"].GroupIndex = groupIndex;
                }
                else
                {
                    xlsx_.write_xml("group_params", view.Columns["date"].GroupIndex.ToString());
                }
            }
        }

        public void cmb_ReportPrint_AddItems()
        {
            var rg = new ReportGenerating();
            cmb_ReportPrint.Properties.Items.AddRange(rg.getReportList(Properties.Settings_WD.Default.subunit));
        }

        public void load_dtWorker()
        {
            dtWorker = _sql.sql_dt(@"select worker.*, concat(Last_name,' ',First_name,' ',Second_name)fio,subunit, position
                                        from worker join subunit on worker.id_Subunit=subunit.id_subunit join position on position.id_position=worker.id_Position where id_tn=" +
                                   formLogin.id_tn, "t1");
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
                case "0":
                    grid_total.Select();
                    load_dtTotal();
                    break;
                case "1":
                    formLogin FormLogin = new formLogin();
                    Hide();
                    FormLogin.Show();
                    break;
            }
        }

        public void load_dtTotal()
        {
            if (status == "s")
            {
                string comand = @"SELECT* FROM[total] join work on work.id_work = total.id_work
                     WHERE[id_tn] = '" + formLogin.id_tn + "'"
                          + "AND [date]>='" + date_start + "'"
                          + "AND [date]<='" + date_end + "'";
                dtTotal = _sql.sql_dt(comand, "t1");
                grid_total.DataSource = dtTotal;
            }
            else if (status == "r")
            {
                dtTotal = _sql.sql_dt(comandSelectBOSS(), "t1");
                grid_total.DataSource = dtTotal;
            }
        }

        public string comandSelectBOSS()
        {
            string comand = comand = @"SELECT* FROM[total] join work on work.id_work = total.id_work
                             WHERE [date]>='" + date_start + "'"
                               + "AND [date]<='" + date_end + "'"; ;
            if (cmb_subunit.Text == "Мои записи")
            {
                comand += " AND id_tn=" + formLogin.id_tn;
            }
            else if (cmb_subunit.Text == "Все")
            {
                for (int i = 0; i < dtCmbBoxSubunit.Rows.Count; i++)
                {
                    string idSubunitWorker = dtCmbBoxSubunit.Rows[i]["id_subunit"].ToString();
                    if (!string.IsNullOrEmpty(idSubunitWorker) && idSubunitWorker != "")
                    {
                        if (i == 0)
                        {
                            comand += " AND( [id_subunit_worker]=" + idSubunitWorker;
                        }
                        else
                        {
                            comand += " OR [id_subunit_worker]=" + idSubunitWorker;
                        }
                    }
                }
                comand += ")";
            }
            else
            {
                string idSubunitWorker = _sql.linkToDt(dtCmbBoxSubunit, cmb_subunit.Text, "subunit", "id_subunit");
                comand += " AND [id_subunit_worker]=" + idSubunitWorker;
            }
            return comand;
        }

        public void load_dtCmbBoxSubunit()
        {
            string comand = "select cp.subunit,sb.id_subunit from catalog_position cp left join subunit sb on sb.subunit = cp.subunit where id_tn =" + formLogin.id_tn;
            dtCmbBoxSubunit = _sql.sql_dt(comand, "t1");
            dtCmbBoxSubunit.Rows.Add(new object[] {"Мои записи"});
            foreach (DataRow row in dtCmbBoxSubunit.Rows)
            {
                cmb_subunit.Properties.Items.Add(row["subunit"].ToString());
            }
            cmb_subunit.Text = Properties.Settings_WD.Default.subunit;
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
            if (e.Button.Tag.ToString() == "1")
            {
                if (cmb_ReportPrint.SelectedIndex == -1)
                    return;
                var w = new Class_sql();
                var rg = new ReportGenerating();
                ReportGenerating.startDate = date_start;
                ReportGenerating.endDate = date_end;
                ReportGenerating.fio_for_report = dtWorker.Rows[0]["fio"].ToString();
                ReportGenerating.subunit_for_report = dtWorker.Rows[0]["subunit"].ToString();
                ReportGenerating.position = dtWorker.Rows[0]["position"].ToString().ToLower();
                if (cmb_ReportPrint.Text.Equals("Текущая таблица"))
                {
                    rg.Createreport(Convert.ToInt32(dtWorker.Rows[0]["id_subunit"].ToString()), dtTotal, cmb_ReportPrint.Text, formLogin.id_tn, ReportGenerating.fio_for_report);
                    return;
                }
                rg.Createreport(Convert.ToInt32(dtWorker.Rows[0]["id_subunit"].ToString()), dtTotal, cmb_ReportPrint.Text, formLogin.id_tn, ReportGenerating.fio_for_report);
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
            GridView view = (GridView)grid_total.FocusedView;
            try {
                string totalId = view.GetFocusedRowCellValue("id").ToString();
                newAdd.total_id = totalId;
                newAdd.caption_f = "Изменить";
                newAdd formAdd = new newAdd();
                formAdd.ShowDialog();
            }
            catch { XtraMessageBox.Show("Ошибка, запись не выделена.", "Ошибка"); }
        }

        public void selectGridView()
        {
            string nameView = xlsx_.read_xlsx("gridName");
            var typeGridView = from GridView grd in grid_total.ViewCollection
                     where grd.Name.ToString() == nameView
                     select grd;
            GridView grid = typeGridView.ElementAt(0);
            grid_total.MainView = grid;
            if (nameView == "gridView_konstr")
            {            
                windowsUIButtonPanel1.Buttons[0].Properties.Checked = true;
                Properties.Settings_WD.Default.isForm = true;
            }
            else
            {
                windowsUIButtonPanel1.Buttons[0].Properties.Checked = false;
                Properties.Settings_WD.Default.isForm = false;
            }
            if (status == "s")
            {
                grid.Columns["FIO"].Visible = false;
                grid.Columns["position"].Visible = false;
                grid.Columns["subunit"].Visible = false;
            }
        }

        private void windowsUIButtonPanel1_ButtonChecked(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            if (e.Button.Properties.Tag.ToString()=="2" )
            {
                grid_total.MainView = gridView_konstr;
                xlsx_.write_xml( "gridName", grid_total.MainView.Name);
                Properties.Settings_WD.Default.isForm = true;
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
                xlsx_.write_xml("gridName", grid_total.MainView.Name);
                Properties.Settings_WD.Default.isForm = false;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            GridView view = (GridView)grid_total.FocusedView;
            try
            {
                string totalId = view.GetFocusedRowCellValue("id").ToString();
                string comand = "delete total where id=" + totalId;
                if (_sql.UpdateComand(comand))
                {
                    XtraMessageBox.Show("Запись успешно удалена.", "Внимание");
                }
            }
            catch { XtraMessageBox.Show("Ошибка, запись не выделена.", "Ошибка"); }
        }

        private void btn_Calendar_Click(object sender, EventArgs e)
        {
            form_calendar _Calendar = new form_calendar();
            _Calendar.ShowDialog();
        }

        private void groupButton_CustomButtonChecked(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            groupButton.Size = new Size(44, 613);
            groupButton.CustomHeaderButtons[0].Properties.Image = Properties.Resources.forward_16x16;
            groupButton.CustomHeaderButtons[0].Properties.Checked = true;
            groupButton.Text = "      ";
            xlsx_.write_xml("groupExpand","True");
        }

        private void groupButton_CustomButtonUnchecked(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            groupButton.Size = new Size(230, 613);
            groupButton.CustomHeaderButtons[0].Properties.Image = Properties.Resources.backward_16x16;
            groupButton.CustomHeaderButtons[0].Properties.Checked = false;
            groupButton.Text = "Управление";
            xlsx_.write_xml("groupExpand", "False");
        }

        private void gridView1_StartGrouping(object sender, EventArgs e)
        {
            groupColumnData(false);
        }

        private void cmb_subunit_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_dtTotal();
        }

        private void btn_tabel_Click(object sender, EventArgs e)
        {
            tabel tb = new tabel(cmb_subunit.Text, dEdit_start.DateTime);
            tb.ShowDialog();
        }

        private void btn_prices_Click(object sender, EventArgs e)
        {
            sale formSale = new sale();
            formSale.Show();
        }
    }
}
