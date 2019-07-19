using System;
using System.Windows.Forms;
using System.Data;
using System.Linq;
using DevExpress.XtraEditors;

namespace JoobTime
{
    public partial class sale : DevExpress.XtraEditors.XtraForm
    {
        public string id_sale;
        public string id_work_select;
        public string id_pres_form;
        public string id_date_now;
        public string id_value;
        public string pres_form_name;
        public string work_name;
        
        public string select_subunit;
        public string select_IdSubunit;
        public string selected_worker_fio;
        public string selected_worker_id;
        public string pay_type;

        public DataTable table_sale_difficult;
        public DataTable dt_pricesForPayment; 
        public DataTable dt_update_total_price;
        public DataTable dt_subunit_cmbBox;
        public DataTable dt_total_rep;
        public DateTime de_start;
        public DateTime de_end;

        Class_sql sql = new Class_sql();
        class_date date_edit_for_SQL = new class_date();
       
        public void get_time_dtEdit()
        {
            int countday = DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month);
            de_start = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            de_end = new DateTime(DateTime.Today.Year, DateTime.Today.Month, countday);
            dEdit_start.DateTime = de_start;
            dEdit_end.DateTime = de_end;
        }

        public void update_totalPrice()
        {
            for (int i = 0; i < dt_update_total_price.Rows.Count; i++)
            {
                //dt_update_total_price;
                string difficult = dt_update_total_price.Rows[i]["difficult"].ToString();
                string price = dt_update_total_price.Rows[i]["price"].ToString();
                string id = dt_update_total_price.Rows[i]["id_total"].ToString();
                var comand = "update total set difficult=" + difficult + ", payment=" + price.Replace(',', '.') + " where id=" + id;
                sql.update_comand(comand);
            }
        }

        private void init_dt_update_total_price()
        {
            dt_update_total_price = new DataTable();
            dt_update_total_price.Columns.Add("id_total");
            dt_update_total_price.Columns.Add("difficult");
            dt_update_total_price.Columns.Add("price");
        }

        public void add_row_in_dt_update_total_price(string id, string difficult, string price)
        {
            DataRow new_row = dt_update_total_price.NewRow();
            new_row["id_total"] = id;
            new_row["difficult"] = difficult;
            new_row["price"] = price;
            if (string.IsNullOrEmpty(price) || price.Equals("0"))
                return;
            dt_update_total_price.Rows.Add(new_row);
        }

        public sale()
        {
            InitializeComponent();                            
            init_dt_update_total_price();
            load_dtPricesForPayment();
        }

        public void grid_control_prices()
        {
            if (select_subunit != "")
            {
                string command = @"select DISTINCT work,
                                  (select DISTINCT price from prices pr where difficulty=1 and pr.id_work=prices.id_work) pr1,
                                  (select DISTINCT price from prices pr where difficulty=2 and pr.id_work=prices.id_work) pr2,
                                  (select DISTINCT price from prices pr where difficulty=3 and pr.id_work=prices.id_work) pr3,
                                  (select DISTINCT price from prices pr where difficulty=4 and pr.id_work=prices.id_work) pr4,
                                  (select DISTINCT price from prices pr where difficulty=5 and pr.id_work=prices.id_work) pr5,
                                  (select DISTINCT price from prices pr where difficulty=6 and pr.id_work=prices.id_work) pr6,
                                  (select DISTINCT price from prices pr where difficulty=7 and pr.id_work=prices.id_work) pr7,
                                  (select DISTINCT price from prices pr where difficulty=8 and pr.id_work=prices.id_work) pr8,
                                  (select DISTINCT price from prices pr where difficulty=9 and pr.id_work=prices.id_work) pr9,
                                  (select DISTINCT price from prices pr where difficulty=10 and pr.id_work=prices.id_work) pr10, work.id_work,
                                  case when pay_type=0 then 'Почасовая' when pay_type=1 then 'По расценке' when pay_type=2 then 'Форма' end pay_type_for_user,pay_type
                                  from work left join prices on prices.id_work=work.id_work join subunit on 
			                      subunit.id_subunit=work.id_position where subunit='" + select_subunit + "' order by pay_type DESC, work asc";
                gridControl1.DataSource = sql.bs_query(command, "t1");
            }
        }
        
        public void grid_control_total()
        {
            if (string.IsNullOrEmpty(select_subunit))
            {
                return;
            }
            else 
            {
                dt_total_rep = sql.sql_dt(comandSelectBOSS(), "t1");
                gridControl3.DataSource = dt_total_rep;
            }
        }

        public string comandSelectBOSS()
        {
            string comand = comand = @"SELECT* FROM[total] join work on work.id_work = total.id_work
                             WHERE [date]>='" + de_start + "'"
                               + "AND [date]<='" + de_end + "'"; ;
            if (select_subunit == "Все")
            {
                for (int i = 0; i < dt_subunit_cmbBox.Rows.Count; i++)
                {
                    string idSubunitWorker = dt_subunit_cmbBox.Rows[i]["id_subunit"].ToString();
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
                comand += " AND [id_subunit_worker]=" + select_IdSubunit;
            }
            return comand;
        }

        private void sale_Load(object sender, EventArgs e)
        {
            cmbSubunit_load();
            get_time_dtEdit();
            grid_control_total();
            grid_control_prices();
            enable_button(xtraTabControl1.SelectedTabPageIndex);
        }

        public void enable_button(int active_tab_page)
        {
            switch (active_tab_page)
            {
                case 0:
                    btn_update.Enabled = true;
                    btn_renull.Enabled = true;
                    btn_prices.Enabled = true;
                    btn_print.Enabled = true;
                    btn_update_prices.Enabled = false;
                    dEdit_start.Enabled = true;
                    dEdit_end.Enabled = true;
                    type_reports_cmbBox.Enabled = true;
                    worker_cmbBox.Enabled = true;
                    lUp_subunit.Enabled = true;
                    break;
                case 1:
                    btn_update.Enabled = false;
                    btn_renull.Enabled = false;
                    btn_prices.Enabled = false;
                    btn_print.Enabled = false;
                    btn_update_prices.Enabled = true;
                    dEdit_start.Enabled = false;
                    dEdit_end.Enabled = false;
                    type_reports_cmbBox.Enabled = false;
                    worker_cmbBox.Enabled = false;
                    lUp_subunit.Enabled = false;
                    break;
            }
        }

        public string load_WorkSale(string difficulty_select)
        {
            if (difficulty_select != string.Empty && difficulty_select != "0" && difficulty_select != "")
            {
                //var comand = "select [price],[pay_type] from prices where id_work =" + id_work_select + " and difficulty=" + difficulty_select;
                //table_sale_difficult = sql.sql_dt(comand, "t1");
                var type = dt_pricesForPayment.Rows[0]["id_work"].GetType();
                var price = dt_pricesForPayment.AsEnumerable()
                    .Where(row => row["id_work"].ToString().Equals(id_work_select) && row["difficulty"].ToString().Equals(difficulty_select))
                    .FirstOrDefault();
                //var price = from DataRow row in dt_pricesForPayment.Rows
                //            where row["id_work"].ToString().Equals(id_work_select)  && row["difficulty"].ToString().Equals(difficulty_select)
                //            select row ;
                
                if (price==null)
                    return "";
                pay_type = price["pay_type"].ToString();
                return price["price"].ToString(); ;
            }
            else
            {
                return "";
            }
        }

        public void load_dtPricesForPayment()
        {
            dt_pricesForPayment = sql.sql_dt("select*from prices", "t1");
        }

        public string sale_to_gridView(string sale)
        {
            if (sale != "" && sale != "0" && pay_type == "0")
            {
                string time = gridView3.GetFocusedRowCellValue("time_span").ToString();
                double time_h = TimeSpan.Parse(time).TotalHours;
                sale = (time_h * double.Parse(sale)).ToString();
                sale = Math.Round(double.Parse(sale), 2, MidpointRounding.AwayFromZero).ToString();
                gridView3.SetFocusedRowCellValue("payment", sale);
                return sale;
            }
            else
            {
                gridView3.SetFocusedRowCellValue("payment", sale);
                return null;
            }
        }

        private void gridView3_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName != "difficult")
                return;
            id_work_select = gridView3.GetFocusedRowCellValue("id_work").ToString();
            string difficulty_select = gridView3.GetFocusedRowCellValue("difficult").ToString();
            string sale = load_WorkSale(difficulty_select);

            string work_sale = sale_to_gridView(sale);
            add_row_in_dt_update_total_price(gridView3.GetFocusedRowCellValue("id").ToString(), difficulty_select, work_sale );
            return;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            switch (select_IdSubunit)
            {
                case"5": //3DMODELS
                    set_price(5);
                    break;
                case "3"://OPRP   
                    set_price(3);
                    break;
            }
            
            update_totalPrice();
        }

        public void set_priceOPRP()
        {

        }

        public void set_price(int idSubunit)
        {
            DataTable dtUserSubunit = sql.sql_dt("select id_tn, category from worker where id_subunit="+idSubunit, "t1");
            for (int i = 0; i < gridView3.RowCount; i++)
            {
                string id_tn = gridView3.GetRowCellValue(i, "id_tn").ToString();
                var category = from  DataRow row in dtUserSubunit.Rows
                             where row["id_tn"].ToString()==id_tn
                             select row["category"];
                string difficult = category.ElementAt(0).ToString();
                gridView3.SetRowCellValue(i,"difficult", difficult);
                gridView3.FocusedRowHandle = i;
                //string work_sale = load_WorkSale(difficult);
                //sale_to_gridView(work_sale);
                //add_row_in_dt_update_total_price(gridView3.GetFocusedRowCellValue("id").ToString(), difficult, work_sale);
            }
        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {
            de_start = dEdit_start.DateTime;
            set_worker();
        }

        private void dateEdit2_EditValueChanged(object sender, EventArgs e)
        {
            de_end = dEdit_end.DateTime;
            set_worker();
        }
        
        public void cmbSubunit_load()
        {
            string comand = "select cp.subunit,sb.id_subunit from catalog_position cp left join subunit sb on sb.subunit = cp.subunit where id_tn =" + formLogin.id_tn;
            dt_subunit_cmbBox = sql.sql_dt(comand, "t1");
            foreach (DataRow row in dt_subunit_cmbBox.Rows)
            {
                lUp_subunit.Properties.DataSource = dt_subunit_cmbBox;
            }
            lUp_subunit.Text = Properties.Settings_WD.Default.subunit;
        }
        
        //public void cmb_subunit()
        //{
        //    string comand = string.Format("select [subunit] from catalog_position where id_tn={0}", Convert.ToInt32(formLogin.id_tn));
        //    dt_subunit_cmbBox = sql.sql_dt(comand, "cp");           
        //    if (formLogin.id_tn == "1047" || formLogin.id_tn == "0002")
        //    {
        //        //add_row_in_Subunit("Все");
        //        lUp_subunit.Properties.DisplayMember = "subunit";
        //        lUp_subunit.Properties.DataSource = dt_subunit_cmbBox;              
        //    }
        //    else
        //    {
        //        lUp_subunit.Properties.DisplayMember = "subunit";
        //        lUp_subunit.Properties.DataSource = dt_subunit_cmbBox;
        //    }            
        //    select_idSubunit();
        //}

        //public void add_row_in_Subunit(string subunit)
        //{
        //    DataRow tt = dt_subunit_cmbBox.NewRow();
        //    tt["subunit"] = subunit;
        //    dt_subunit_cmbBox.Rows.Add(tt);
        //}

        //public void select_idSubunit()
        //{
        //    if (string.IsNullOrEmpty(select_subunit))
        //    {
        //        return;
        //    }
        //    else if (select_subunit == "Все")
        //    {
        //        select_IdSubunit = "0";                
        //    }
        //    else 
        //    {
        //        var comand = "select [id_subunit] from subunit where subunit='" + select_subunit + "'";
        //        select_IdSubunit = sql.sql_dt(comand, "t1").Rows[0][0].ToString();
        //    }

        //}

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            switch (xtraTabControl1.SelectedTabPage.Name)
            {
                case "xtraTabPage1":
                    {
                        grid_control_total();
                        set_worker();
                        break;
                    }
                case "xtraTabPage2":
                    {
                        grid_control_prices();
                        break;
                    }
            }
        }
            
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            select_subunit = lUp_subunit.Text; 
            if(select_subunit!="Все")
            select_IdSubunit = lUp_subunit.GetColumnValue("id_subunit").ToString();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            set_price_zero();
            grid_control_total();
        }

        public void set_price_zero()
        {
            string id_total=gridView3.GetFocusedRowCellValue("id").ToString();
            string payment = "null";
            string difficult = "null";
            var comand = @"update total set payment=" + payment + " ,difficult=" + difficult + " where id=" + id_total;
            sql.update_comand(comand);
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            if (type_reports_cmbBox.Text == "" || string.IsNullOrEmpty(type_reports_cmbBox.Text))
            { XtraMessageBox.Show("Выберите тип отчета", "Внимание"); }
            else
            {
                ReportGenerating.startDate = date_edit_for_SQL.convert(de_start);
                ReportGenerating.endDate = date_edit_for_SQL.convert(de_end);

                set_worker();
                string type_report = type_reports_cmbBox.Text;
                ReportGenerating rg = new ReportGenerating();
                rg.Createreport(Convert.ToInt32(select_IdSubunit), dt_total_rep, type_report, selected_worker_id, selected_worker_fio);
            }
        }

        public void set_worker()
        {
           worker_cmbBox.Items.Clear();
           worker_cmbBox.Items.AddRange(load_worker_tocmb_box().AsEnumerable().Select(r => r.Field<string>("FIO")).ToArray());
        }

        public DataTable load_worker_tocmb_box()
        {
            Class_sql sql = new Class_sql();
            var comand = @"select tabel.id_tn, ttime,concat(Last_name,' ',First_name,' ',Second_name) FIO,position from tabel join worker on tabel.id_tn=worker.id_tn join Position on worker.id_Position=Position.id_position where (select id_Subunit from subunit where subunit='" +
                lUp_subunit.Text + "') =id_Subunit and" + " tdate between '" + dEdit_start.DateTime.ToString("yyyy-MM-01") +
                "' and '" + dEdit_start.DateTime.ToString("yyyy-MM-" + DateTime.DaysInMonth(dEdit_start.DateTime.Year, dEdit_start.DateTime.Month)) + "'";            
           return sql.sql_dt(comand, "table");
        }

        private void worker_cmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected_worker_fio = worker_cmbBox.Text;
            selected_worker_id = sql.sql_dt("select [id_tn] from worker where concat(Last_name,' ',First_name,' ',Second_name)='" + selected_worker_fio+"'", "t1").Rows[0][0].ToString();

        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            enable_button(xtraTabControl1.SelectedTabPageIndex);
        }

        private void prices_update_btn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                string id_work = gridView1.GetRowCellValue(i, "id_work").ToString();
                for (int j = 1; j <= 10; j++)
                {
                    string price = gridView1.GetRowCellValue(i, "pr" + j.ToString()).ToString();
                    if (price == "" || string.IsNullOrEmpty(price))
                    {
                        break;
                    }
                    else
                    {
                        string comand = "update prices set price=" + price + " where id_work=" + id_work + " and difficulty=" + j;
                        sql.update_comand(comand);
                    }
                }
            }
        }

        private void btn_update_prices_Click(object sender, EventArgs e)
        {
            updatePrice();
        }

        public void updatePrice()
        {
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                string id_work = gridView1.GetRowCellValue(i, "id_work").ToString();
                for (int j = 1; j <= 10; j++)
                {
                    string price = gridView1.GetRowCellValue(i, "pr" + j.ToString()).ToString();
                    if (price == "" || string.IsNullOrEmpty(price))
                    {
                        break;
                    }
                    else
                    {
                        string comand;
                        if (checkPrice(j, id_work))
                        {
                            comand = "update prices set price=" + price.Replace(',', '.') + " where id_work=" + id_work + " and difficulty=" + j;
                        }
                        else
                        {
                            int payType = checkPayType(i);
                            comand = string.Format(@"INSERT INTO [dbo].[prices]
                                                                ([id_work]
                                                                ,[difficulty]
                                                                ,[price]
                                                                ,[pay_type])
                                                          VALUES
                                                                ({0}
                                                                ,{1}
                                                                ,'{2}'
                                                                ,{3})", id_work, j, price.Replace(',', '.'), payType);
                        }
                        sql.update_comand(comand);
                    }
                }
            }
        }

        public int checkPayType(int rowIndex)
        {
            string PayType = gridView1.GetRowCellValue(rowIndex, "pay_type_for_user").ToString();
            int PayTypeForTable;
            switch (PayType)
            {
                case "Почасовая":
                    PayTypeForTable = 0;
                    break;
                case "По расценке":
                    PayTypeForTable = 1;
                    break;
                case "Форма":
                    PayTypeForTable = 2;
                    break;
                default:
                    PayTypeForTable = 0;
                    break;
            }
            return PayTypeForTable;
        }

        public bool checkPrice(int difficulty, string id_work)
        {
            bool check = true;
            string comand = "select*from prices where id_work=" + id_work + " and difficulty=" + difficulty;
            DataTable dt_result = sql.sql_dt(comand,"result");
            if (dt_result.Rows.Count == 0)
            {
                check = false;
            }
            return check;
        }

        public void priceOPRPWithOvertime()
        {
            //DataTable dtOPRP = dt_total_rep;
            //for (int = 0; i < dtOPRP.Rows.Count; i++)
            //{

            //}
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            //form_saleOPRP fs = new form_saleOPRP();
            //fs.Show();
            string comand = @"select ttl.id_tn, ttl.FIO, sum(DATEPART(HH,ttl.time_span))+(sum(DATEPART(MINUTE,ttl.time_span))/60.00) TOTALTIME, tb.ttime,tb.tdate
                               from total ttl
                               join tabel tb on ttl.id_tn = tb.id_tn and YEAR(tb.tdate) = YEAR(ttl.date) and MONTH(tb.tdate)= MONTH(ttl.date)
                              where ttl.id_tn = 9999
                           group by ttl.[id_tn],ttl.[fio],tb.ttime,tb.tdate";
            DataTable dt_totalOPRP = sql.sql_dt(comand,"t1");
            dt_totalOPRP.Columns.Add("overtime");
            dt_totalOPRP.Columns.Add("sale");
            for (int i = 0; i < dt_totalOPRP.Rows.Count; i++)
            {
                string TimeFact = dt_totalOPRP.Rows[i]["TOTALTIME"].ToString();
                string hour = TimeFact.Substring(0, TimeFact.IndexOf(','));               
                string minut = (double.Parse(TimeFact.Remove(0, TimeFact.IndexOf(',')+1).Substring(0, 2))*60).ToString();



                string timeTabel = dt_totalOPRP.Rows[i]["ttime"].ToString();
                string hourT= TimeFact.Substring(0, TimeFact.IndexOf(':'));
                string minutT = (double.Parse(TimeFact.Remove(0, TimeFact.IndexOf(':') + 1).Substring(0, 2)) * 60).ToString();

                TimeSpan tsFact =  new TimeSpan (Convert.ToInt32(hour),Convert.ToInt32(minut),00 );
                TimeSpan tsTabel =  new TimeSpan(Convert.ToInt32(hourT), Convert.ToInt32(minutT), 00);
                TimeSpan OverTime = tsFact - tsTabel;

            }
            gridControl3.DataSource = dt_totalOPRP;
        }

        private void gridView2_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "TOTALTIME")
            {
                //string TimeStr = e.Value.ToString();
                //int hour =Convert.ToInt32( TimeStr.Substring(TimeStr.IndexOf('.')));
                //int minut = Convert.ToInt32(TimeStr.Remove(0, TimeStr.IndexOf('.'))) * 6;
            }
        }
    }
}
