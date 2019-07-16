using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Xpf.Printing;

namespace JoobTime
{
    public partial class form_calendar : DevExpress.XtraEditors.XtraForm
    {
        public form_calendar()
        {
            InitializeComponent();
            grid_Calendar.MainView = view_calendar;
            date_picker_load(true);
            load_togridCalendar();
            load_togridModels(rButton_allModel.Name);
            selectTabIndex(0);
        }

        Class_sql class_Sql = new Class_sql();

        private DataTable dt_gridCalendar;
        private DataTable dt_viewallModels;
        private DataTable dt_viewactivModels;
        private DataTable dt_viewpreStopModels;
        private DataTable dt_viewStopModels;
        public string year;
        public string month;
        public string column_name;
        public string result;
        public bool is_sov = false;

        public void date_picker_load(bool now)
        {
            if (now)
            {
                dateEdit1.DateTime = System.DateTime.Now;
            }
            month = dateEdit1.DateTime.Month.ToString();
            year = dateEdit1.DateTime.Year.ToString();
        }

        public void load_togridCalendar()
        {
            var command = string.Format(@"select distinct id_models,md.fName_model,md.sName_model,md.id_creator,(worker.Last_name+' '+worker.First_name+' '+worker.Second_name) fio,worker.photo, position.position,md.start_date,
                            (select distinct status from calendar cal where date='{1}-{0}-01' and cal.id_tn=calendar.id_tn and cal.id_models=calendar.id_models) d1,
                            (select distinct status from calendar cal where date='{1}-{0}-02' and cal.id_tn=calendar.id_tn and cal.id_models=calendar.id_models) d2,
                            (select distinct status from calendar cal where date='{1}-{0}-03' and cal.id_tn=calendar.id_tn and cal.id_models=calendar.id_models) d3,
                            (select distinct status from calendar cal where date='{1}-{0}-04' and cal.id_tn=calendar.id_tn and cal.id_models=calendar.id_models) d4,
                            (select distinct status from calendar cal where date='{1}-{0}-05' and cal.id_tn=calendar.id_tn and cal.id_models=calendar.id_models) d5,
                            (select distinct status from calendar cal where date='{1}-{0}-06' and cal.id_tn=calendar.id_tn and cal.id_models=calendar.id_models) d6,
                            (select distinct status from calendar cal where date='{1}-{0}-07' and cal.id_tn=calendar.id_tn and cal.id_models=calendar.id_models) d7,
                            (select distinct status from calendar cal where date='{1}-{0}-08' and cal.id_tn=calendar.id_tn and cal.id_models=calendar.id_models) d8,
                            (select distinct status from calendar cal where date='{1}-{0}-09' and cal.id_tn=calendar.id_tn and cal.id_models=calendar.id_models) d9,
                            (select distinct status from calendar cal where date='{1}-{0}-10' and cal.id_tn=calendar.id_tn and cal.id_models=calendar.id_models) d10,
                            (select distinct status from calendar cal where date='{1}-{0}-11' and cal.id_tn=calendar.id_tn and cal.id_models=calendar.id_models) d11,
                            (select distinct status from calendar cal where date='{1}-{0}-12' and cal.id_tn=calendar.id_tn and cal.id_models=calendar.id_models) d12,
                            (select distinct status from calendar cal where date='{1}-{0}-13' and cal.id_tn=calendar.id_tn and cal.id_models=calendar.id_models) d13,
                            (select distinct status from calendar cal where date='{1}-{0}-14' and cal.id_tn=calendar.id_tn and cal.id_models=calendar.id_models) d14,
                            (select distinct status from calendar cal where date='{1}-{0}-15' and cal.id_tn=calendar.id_tn and cal.id_models=calendar.id_models) d15,
                            (select distinct status from calendar cal where date='{1}-{0}-16' and cal.id_tn=calendar.id_tn and cal.id_models=calendar.id_models) d16,
                            (select distinct status from calendar cal where date='{1}-{0}-17' and cal.id_tn=calendar.id_tn and cal.id_models=calendar.id_models) d17,
                            (select distinct status from calendar cal where date='{1}-{0}-18' and cal.id_tn=calendar.id_tn and cal.id_models=calendar.id_models) d18,
                            (select distinct status from calendar cal where date='{1}-{0}-19' and cal.id_tn=calendar.id_tn and cal.id_models=calendar.id_models) d19,
                            (select distinct status from calendar cal where date='{1}-{0}-20' and cal.id_tn=calendar.id_tn and cal.id_models=calendar.id_models) d20,
                            (select distinct status from calendar cal where date='{1}-{0}-21' and cal.id_tn=calendar.id_tn and cal.id_models=calendar.id_models) d21,
                            (select distinct status from calendar cal where date='{1}-{0}-22' and cal.id_tn=calendar.id_tn and cal.id_models=calendar.id_models) d22,
                            (select distinct status from calendar cal where date='{1}-{0}-23' and cal.id_tn=calendar.id_tn and cal.id_models=calendar.id_models) d23,
                            (select distinct status from calendar cal where date='{1}-{0}-24' and cal.id_tn=calendar.id_tn and cal.id_models=calendar.id_models) d24,
                            (select distinct status from calendar cal where date='{1}-{0}-25' and cal.id_tn=calendar.id_tn and cal.id_models=calendar.id_models) d25,
                            (select distinct status from calendar cal where date='{1}-{0}-26' and cal.id_tn=calendar.id_tn and cal.id_models=calendar.id_models) d26,
                            (select distinct status from calendar cal where date='{1}-{0}-27' and cal.id_tn=calendar.id_tn and cal.id_models=calendar.id_models) d27,
                            (select distinct status from calendar cal where date='{1}-{0}-28' and cal.id_tn=calendar.id_tn and cal.id_models=calendar.id_models) d28,
                            (select distinct status from calendar cal where date='{1}-{0}-29' and cal.id_tn=calendar.id_tn and cal.id_models=calendar.id_models) d29,
                            (select distinct status from calendar cal where date='{1}-{0}-30' and cal.id_tn=calendar.id_tn and cal.id_models=calendar.id_models) d30,
                            (select distinct status from calendar cal where date=(select max(date) from calendar where cal.id_tn=calendar.id_tn and cal.id_models=calendar.id_models) and cal.id_tn=calendar.id_tn and cal.id_models=calendar.id_models and  status!='') status_now
                            from calendar 
                            left join models md on calendar.id_models=md.id 
                            left join worker on md.id_creator=worker.id_tn
                            left join Position on worker.id_Position=Position.id_position", month, year);

            dt_gridCalendar = class_Sql.sql_dt(command, "1");
            dt_gridCalendar.Columns.Add("image", typeof(Image));
            ImageLoadToDT(dt_gridCalendar);
            grid_Calendar.DataSource = dt_gridCalendar;
        }

        public void ImageLoadToDT(DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (!System.IO.File.Exists(dt.Rows[i]["photo"].ToString()))
                {
                    Image img = Image.FromFile(@"C:\Users\tig\Desktop\_icons_creator\no_image.jpg");
                    img.Tag = dt.Rows[i]["id_creator"].ToString();
                    dt.Rows[i]["image"] = img;
                }
                else
                {
                    Image img = Image.FromFile(dt.Rows[i]["photo"].ToString());
                    img.Tag = dt.Rows[i]["id_creator"].ToString();
                    dt.Rows[i]["image"] = img;
                }
            }
        }

        public void load_togridModels(string name_radiobutton)
        {

            //В работе
            //Ожидание проверки
            //Построение разъемов
            //Разработка приостановлена
            //Разработка остановлена
            //Модель нуждается в доработке
            //Разработка модели приостановлена
            //Разработка модели остановлена
            //Разработка модели завершена

            var comand = @"select models.*,(worker.Last_name+' '+worker.First_name+' '+worker.Second_name) fio,worker.photo 
                             from models 
                        left join worker on models.id_creator=worker.id_tn";
            dt_viewallModels = class_Sql.sql_dt(comand, "t1");
            comand = @"select models.*,(worker.Last_name+' '+worker.First_name+' '+worker.Second_name) fio,worker.photo 
                        from models
                   left join worker on models.id_creator = worker.id_tn 
                       where now_status='В работе' or 
                             now_status='Ожидание проверки' or 
                             now_status='Построение разъемов' or 
                             now_status='Модель нуждается в доработке'";
            dt_viewactivModels = class_Sql.sql_dt(comand, "t1");
            comand = @"select models.*,(worker.Last_name+' '+worker.First_name+' '+worker.Second_name) fio,worker.photo 
                        from models
                   left join worker on models.id_creator = worker.id_tn
                       where now_status='Разработка приостановлена' or 
                             now_status='Разработка модели приостановлена'";
            dt_viewpreStopModels = class_Sql.sql_dt(comand, "t1");
            comand = @"select models.*,(worker.Last_name+' '+worker.First_name+' '+worker.Second_name) fio,worker.photo 
                        from models
                   left join worker on models.id_creator = worker.id_tn
                       where now_status='Разработка остановлена' or 
                             now_status='Разработка модели остановлена'";
            dt_viewStopModels = class_Sql.sql_dt(comand, "t1");
            switch (name_radiobutton)
            {
                case "rButton_allModel":
                    grid_Models.DataSource = dt_viewallModels;
                    break;
                case "rButton_activModel":
                    grid_Models.DataSource = dt_viewactivModels;
                    break;
                case "rButton_pStopModel":
                    grid_Models.DataSource = dt_viewpreStopModels;
                    break;
                case "rButton_stopModel":
                    grid_Models.DataSource = dt_viewStopModels;
                    break;
            }
        }

        private void repositoryItemComboBox1_EditValueChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.ComboBoxEdit comboBox = sender as DevExpress.XtraEditors.ComboBoxEdit;
            string date = year + "-" + month + "-" + column_name.Substring(1);
            string status = comboBox.SelectedItem.ToString();
            string id_creator = view_calendar.GetFocusedRowCellValue("id_creator").ToString();
            string id_models = view_calendar.GetFocusedRowCellValue("id_models").ToString();
            string comand;
            string id = check_record(date, id_models, id_creator);
            string N_protocol = isSov(status);
            if (string.IsNullOrEmpty(id))
            {
                comand = "insert into calendar ([id_tn],[date],[id_models],[status],[N_protocol])VALUES(" + id_creator + ",'" + date + "'," + id_models + ",'" + status + "',"+N_protocol+")";
            }
            else
            {
                comand = "update calendar set [status]='" + status + "',[N_protocol]=" + N_protocol+" where id=" + id;
            }
            class_Sql.update_comand(comand);
            updateStatusModels(id_models, id_creator);
        }
        
        //В работе
        //Ожидание проверки
        //Построение разъемов
        //Разработка приостановлена
        //Разработка остановлена
        //Модель нуждается в доработке
        //Разработка модели приостановлена
        //Разработка модели остановлена
        //Разработка модели завершена
       
        public string isSov(string status)
        {
            if (status == "Модель нуждается в доработке" || status == "Разработка модели приостановлена" || status == "Разработка модели остановлена" || status == "Разработка модели завершена")
            {
                var res = DevExpress.XtraEditors.XtraInputBox.Show("Введите номер протокола совещания", "Номер протокола", "");
                if(res!="" || !string.IsNullOrEmpty(res))
                return res.ToString();
                return "null";
            }
            else return "null";           
        }

        public void updateStatusModels(string id_models, string id_creator)
        {
            string comand = "select status from calendar where date = (select max(date)from calendar where id_tn ="+ id_creator + " and id_models ="+id_models+") and id_tn ="+id_creator+" and id_models = "+id_models;
            string statusMaxDate = class_Sql.sql_dt(comand, "t1").Rows[0][0].ToString();
            string statusNow = class_Sql.sql_dt("select now_status from models where id=" + id_models,"t1").Rows[0][0].ToString();
            if (statusMaxDate != statusNow)
            {
                comand = "update models set now_status='"+ statusMaxDate + "' where id=" + id_models;
                class_Sql.update_comand(comand);
            }
        }

        public string check_record(string date,string models,string creator)
        {
            string comand= @"select [id] from calendar where id_tn=" + creator + " and id_models=" + models + "and date='" + date + "'";
            DataTable dt_id_record = class_Sql.sql_dt(comand,"t1");
            if (dt_id_record.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                return dt_id_record.Rows[0][0].ToString();
            }
        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {
            date_picker_load(false);
        }

        private void rButton_allModel_CheckedChanged(object sender, EventArgs e)
        {
            if (rButton_allModel.Checked)
            {
                load_togridModels(rButton_allModel.Name);
            }
        }

        private void rButton_activModel_CheckedChanged(object sender, EventArgs e)
        {
            if (rButton_activModel.Checked)
            {
                load_togridModels(rButton_activModel.Name);
            }
        }

        private void rButton_pStopModel_CheckedChanged(object sender, EventArgs e)
        {
            if (rButton_pStopModel.Checked)
            {
                load_togridModels(rButton_pStopModel.Name);
            }
        }

        private void rButton_stopModel_CheckedChanged(object sender, EventArgs e)
        {
            if (rButton_stopModel.Checked)
            {
                load_togridModels(rButton_stopModel.Name);
            }
        }

        private void view_calendar_CellMerge(object sender, DevExpress.XtraGrid.Views.Grid.CellMergeEventArgs e)
        {
            if (e.Column.FieldName == "fio" || e.Column.FieldName == "image")
            {
                cell_merge(sender, e);
            }
        }

        private void view_calendar_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            column_name = e.FocusedColumn.FieldName.ToString();
        }

        private void view_calendar_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            display_text(e);
        }

        private void view_calendar_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            appearance_cell(e);
        }
        
        public void cell_merge(object sender, DevExpress.XtraGrid.Views.Grid.CellMergeEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            object val1 = gridView.GetRowCellValue(e.RowHandle1, e.Column);
            object val2 = gridView.GetRowCellValue(e.RowHandle2, e.Column);
            if (e.Column.FieldName == "image")
            {
                Image img1 = (Image)val1;
                Image img2 = (Image)val2;
                e.Merge = img1.Tag.Equals(img2.Tag);
            }
            else
            {
                e.Merge = val1.Equals(val2);
            }
            e.Handled = true;
        }
        
        public void display_text(DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Value == null)
            {
                return;
            }
            
            switch (e.Value.ToString())
            {
                case "В работе":
                    e.DisplayText = "";
                    break;
                case "Построение разъемов":
                    e.DisplayText = "Р";
                    break;
                case "Разработка приостановлена":
                    e.DisplayText = "";
                    break;
                case "Ожидание проверки":
                    e.DisplayText = "";
                    break;
                case "Разработка остановлена":
                    e.DisplayText = "";
                    break;
                case "Разработка модели приостановлена":
                    e.DisplayText = set_nProtocol(e) ;
                    break;
                case "Разработка модели остановлена":
                    e.DisplayText = set_nProtocol(e);
                    break;
                case "Разработка модели завершена":
                    e.DisplayText = set_nProtocol(e);
                    break;
                case "Модель нуждается в доработке":
                    e.DisplayText = set_nProtocol(e);
                    break;
            }
        }

        public string set_nProtocol(DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName != "status_now")
            {
                string nProtocol;
                int row_index = e.ListSourceRowIndex;
                string id_models = view_calendar.GetRowCellValue(row_index, "id_models").ToString();
                string date = year + "-" + month + "-" + e.Column.FieldName.Substring(1, e.Column.FieldName.Length - 1).ToString();
                string id_creator = view_calendar.GetRowCellValue(row_index, "id_creator").ToString();
                string comand = string.Format("select [N_protocol] from calendar where id_tn={0} and date='{1}' and id_models='{2}'", id_creator, date, id_models);
                DataTable dt_nProtocol = class_Sql.sql_dt(comand, "t1");
                if (dt_nProtocol.Rows.Count != 0)
                {
                    nProtocol = dt_nProtocol.Rows[0][0].ToString();
                    return nProtocol;
                }
                else return "";
            }
            else return "";
        }

        public void appearance_cell(DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.CellValue == null)
            {
                return;
            }
            switch (e.CellValue.ToString())
            {
                case "В работе":
                    e.Appearance.BackColor = Color.FromArgb(255, 153, 0);
                   break;
                case "Построение разъемов":
                    e.Appearance.BackColor = Color.FromArgb(255, 153, 0);
                    break;
                case "Разработка приостановлена":
                    e.Appearance.BackColor = Color.FromArgb(102, 0, 204);
                    break;
                case "Ожидание проверки":
                    e.Appearance.BackColor = Color.FromArgb(255, 255, 0);
                    break;
                case "Разработка остановлена":
                    e.Appearance.BackColor = Color.FromArgb(255, 0, 0);
                    break;
                case "Разработка модели приостановлена":
                    e.Appearance.BackColor = Color.FromArgb(102, 0, 204);
                    break;
                case "Разработка модели остановлена":
                    e.Appearance.BackColor = Color.FromArgb(255, 0, 0);
                    break;
                case "Разработка модели завершена":
                    e.Appearance.BackColor = Color.FromArgb(0, 255, 0);
                    break;
                case "Модель нуждается в доработке":
                    e.Appearance.BackColor = Color.FromArgb(0, 0, 255);
                    break;
                case null:
                    break;
            }
        }

        private void test_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
        {
            selectTabIndex(test.SelectedPageIndex);
        }

        public void selectTabIndex(int index)
        {
            switch (index)
            {
                case 0:
                    dateEdit1.Enabled = true;
                    btn_print.Enabled = true;
                    btn_addModels.Enabled = false;
                    break;
                case 1:
                    dateEdit1.Enabled = false;
                    btn_print.Enabled = false;                    
                    btn_addModels.Enabled = true;
                    break;
            }
        }

        private void button_addModels_Click(object sender, EventArgs e)
        {
            //add_models add_Models = new add_models();
            //add_Models.Show();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            switch (test.SelectedPageIndex)
            {
                case 0:
                    load_togridCalendar();
                    break;
                case 1:
                    load_togridModels(rButton_allModel.Name);
                    rButton_allModel.Checked = true;
                    break;
            }
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printPreview = new PrintPreviewDialog();
            grid_Calendar.ShowPrintPreview();
        }

        public DataTable dtRaport(string id_tn, string date)
        {
            string comand = "select*from total where id_tn=" + id_tn + " and date='" + date + "'";
            DataTable dtRaport=class_Sql.sql_dt(comand, "t1");
            if (dtRaport.Rows.Count != 0)
            {
                return dtRaport;
            }
            else
            {
                class_date class_Date = new class_date();
                if (date == class_Date.convert(DateTime.Now))
                     MessageBox.Show("Рапорт на сегодня еще не заполнен.");
                else MessageBox.Show("Рапорт на "+DateTime.Parse(date).ToLongDateString()+" еще не заполнен.");
                return null;
            }
        }

        private void view_calendar_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Row)
            {
                DevExpress.Utils.Menu.DXMenuItem item= new DevExpress.Utils.Menu.DXMenuItem("Показать рапорт за день");
                item.Click += Item_Click;
                e.Menu.Items.Add(item);
            }
        }

        private void Item_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            string id_tn = view_calendar.GetFocusedRowCellValue("id_creator").ToString();
            string date;
            if (column_name == "fio" || column_name == "position" || column_name == "id_models" || column_name == "fName_model" || column_name == "id_creator" || column_name == "image" || column_name == "photo_models" || column_name == "start_date" || column_name == "status_now")
            {
                class_date class_Date = new class_date();
                date =  class_Date.convert(DateTime.Now);
            }
            else
            {
                date = year + "-" + month + "-" + column_name.Substring(1, column_name.Length - 1);
            }
            gridControl2.DataSource = dtRaport(id_tn, date);
        }

        private void view_calendar_PrintInitialize(object sender, DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs e)
        {
            DevExpress.XtraPrinting.PrintingSystemBase printingSystem = e.PrintingSystem as DevExpress.XtraPrinting.PrintingSystemBase;
            printingSystem.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
            printingSystem.PageSettings.Landscape = true;
            printingSystem.PageSettings.LeftMargin = 5;
            printingSystem.PageSettings.RightMargin = 5;
        }
    }
}
