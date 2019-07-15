using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using DevExpress.Xpf.Core;
using System.Text;
using System.Windows.Forms;
using JoobTime.Properties;

namespace JoobTime
{
    public class DB
    {
        private sql sql = new sql();

        public DataTable GetMyTable(DateTime startDate, DateTime endDate)
        {
            string command = "select * from total where id_tn=" + Settings_WD.Default.id_tn + " and date between '" +
                             startDate.ToString("dd-MM-yyyy") + "' and '" + endDate.ToString("dd-MM-yyyy") + "'";

            DataSet tableSet = sql.GetSQLTable(command);
            if (tableSet.Tables.Count == 0)
                return new DataTable();
            return tableSet.Tables[0];
        }

        public Boolean DeleteRow(object id, object idWork, object formId,object other, object idTn, object difficult, object payment )
        {
            if(!difficult.Equals(DBNull.Value))
                SaveDiff(id,idWork, formId, other, idTn,difficult,payment);
            return sql.SetSQLTable("delete total where id=" + id);


        }

        public void SaveDiff(object id, object idWork, object formId, object other, object idTn, object difficult, object payment)
        {
            var SameRows = GetIdOfSameRows(idWork, formId, other, idTn);
            if (SameRows.Rows.Count == 1)
                return;
            var newId = FindNewDiffId(id,SameRows);
            SetPayment(newId, difficult, payment);
        }

        private DataTable GetIdOfSameRows(object idWork, object formId, object other, object idTn)
        {
            return sql.GetSQLTable("select id from total where id_work=" + idWork + " and form_id='" + formId +
                                   "' and other='" +
                                   other + "' and id_tn=" + idTn).Tables[0];
        }

        private object FindNewDiffId(object id, DataTable rows)
        {
            var newId =  id;
            foreach (DataRow row in rows.Rows)
            {
                if (!id.Equals(row["id"]))
                    newId = (int)row["id"];
            }
            return newId;
        }

        public DataTable GetSubunitTable(DateTime startDate, DateTime endDate, string subUnit)
        {
            if (subUnit.Equals("Все"))
                subUnit = GetSubunitsForCommand();
            string command = "select * from total where (subunit='" + subUnit + "') and date between '" +
                             startDate.ToString("dd-MM-yyyy") + "' and '" + endDate.ToString("dd-MM-yyyy") + "'";
            DataSet tableSet = sql.GetSQLTable(command);
            if (tableSet.Tables.Count == 0)
                return new DataTable();
            return tableSet.Tables[0];
        }

        public DataTable GetWaitingPayTable(DateTime startDate, DateTime endDate, string subUnit)
        {
            if (subUnit.Equals("Все"))
                subUnit = GetSubunitsForCommand();
            string command = "select * from total where (subunit='" + subUnit +
                             "') and difficult=0 and date between '" +
                             startDate.ToString("dd-MM-yyyy") + "' and '" + endDate.ToString("dd-MM-yyyy") + "'";

            DataSet tableSet = sql.GetSQLTable(command);
            tableSet.Tables[0].Columns.Add("difficulty_add");
            if (tableSet.Tables.Count == 0)
                return new DataTable();
            return tableSet.Tables[0];
        }

        public Boolean SetPayment(object id, object difficult, object workId)
        {
            double price = GetPrice(workId, difficult);
            string command = "update total set payment=" + price.ToString().Replace(',', '.') + ", difficult=" +
                             difficult + " where id=" + id;
            return sql.SetSQLTable(command);
        }

        public Boolean SetPayment(object id, object difficult, double price)
        {
            string command = "update total set payment=" + (String.IsNullOrEmpty(price.ToString()) ? "NULL" : price.ToString().Replace(',', '.')) + ", difficult=" +
                             difficult + " where id=" + id;
            return sql.SetSQLTable(command);
        }

        public double GetPrice(object workId, object difficult)
        {
            DataSet pay =
                sql.GetSQLTable("select price from prices where id_work=" + workId + " and difficulty=" + difficult);
            if (pay.Tables.Count == 0 || pay.Tables[0].Rows.Count == 0)
            {
                return 0;
            }
            return (double) pay.Tables[0].Rows[0][0];
        }

        public Boolean IsTimePaying(object workId)
        {
            DataSet type = sql.GetSQLTable("select DISTINCT pay_type from prices where id_work=" + workId);
            if (type.Tables.Count == 0 || type.Tables[0].Rows.Count == 0 || type.Tables[0].Rows[0][0].Equals(1))
            {
                return false;
            }
            return true;
        }

        public DataTable GetWorkerList(string startDate, string endDate, string subUnit)
        {
            if (subUnit.Equals("Все"))
                subUnit = GetSubunitsForCommand();
            return sql.GetSQLTable(@"select DISTINCT id_tn,FIO from total where (subunit='" +
                                   subUnit + "') and date between '" +
                                   startDate + "' and '" + endDate + "'")
                .Tables[0];
        }

        public DataTable GetFullWorkList()
        {
            string command = "select * from work";
            return sql.GetSQLTable(command).Tables[0];

        }

        public DataTable GetWorkerTable(string startDate, string endDate, object idTn)
        {
            string command = @"select [id]
                ,[FIO]
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
                ,[form_id]
                ,[name_form]
                ,[id_subunit_worker]
                ,[software]
                ,[id_object]
                ,[name_object]
                ,[difficult]
                ,(case when payment is NULL then 0 else payment END) payment from total where id_tn=" + idTn +
                             " and date between '" +
                             startDate + "' and '" + endDate + "'";

            DataSet tableSet = sql.GetSQLTable(command);
            if (tableSet.Tables.Count == 0)
                return new DataTable();
            return tableSet.Tables[0];
        }

        public DataRow GetTotalRow(object id)
        {
            string command = "select * from total join work on total.id_work=work.id_work where id=" + id;
            return sql.GetSQLTable(command)
                .Tables[0].Rows[0];
        }

        public DataTable GetFormTable()
        {
            string command = "select * from pres_form";
            return sql.GetSQLTable(command).Tables[0];
        }

        public DataTable GetSubunitList()
        {
            string command = "select * from subunit";
            return sql.GetSQLTable(command).Tables[0];
        }

        public DataTable GetOtherList()
        {
            string command = "select DISTINCT other from total where id_tn=" + Settings_WD.Default.id_tn +
                             " and date between '" + StartMonthDate(DateTime.Today) + "' and '"+ EndMonthDate(DateTime.Today) + "'";
            return sql.GetSQLTable(command).Tables[0];
        }

        public DataTable GetDayTime(DateTime day)
        {
            string command = "select time_span from total where id_tn=" + Settings_WD.Default.id_tn + " and date='" +
                             day.ToString("dd-MM-yyyy") + "'";
            return sql.GetSQLTable(command).Tables[0];
        }

        public DataTable GetWorkList(int subunitId = 0)
        {
            subunitId = subunitId == 0 ? Settings_WD.Default.subunit_id : subunitId;
            string command = "select * from work where id_position=" + subunitId+" order by work";
            return sql.GetSQLTable(command).Tables[0];
        }

        public List<string> GetControllingSubunitList()
        {
            var list = sql.GetSQLTable("select subunit from catalog_position where id_tn=" + Settings_WD.Default.id_tn)
                .Tables[0].Rows.OfType<DataRow>().Select(x => x.Field<string>("subunit")).ToList();
            if (list.Count > 1)
                list.Add("Все");
            return list;
        }

        private string GetSubunitsForCommand()
        {
            string command = "";
            var subunitList = GetControllingSubunitList();
            foreach (var row in subunitList)
            {
                if (row.Equals("Все"))
                    continue;
                command += "or subunit='" + row + "'";
            }
            command = command.Substring(12);
            command = command.Remove(command.Length - 1, 1);
            return command;
        }

        public bool IsWorkHasAPrice(object id_work)
        {
            return sql.GetSQLTable("select * from prices where id_work=" + id_work).Tables[0].Rows.Count == 0;
        }

        public int CountOfRowsWithSelectedParameters(object id_work, object id_form, object other)
        {
            return sql.GetSQLTable(
                "select * from total where (select DISTINCT pay_type from prices where id_work=" + id_work +
                ")=1 and id_tn=" + Settings_WD.Default.id_tn + " and id_work=" + id_work + " and form_id='" + id_form +
                "' and other='" + other + "'").Tables[0].Rows.Count;
        }

        public string GetLastDayAddTime(DateTime day)
        {
            var time = sql.GetSQLTable("select max(time_end) from total where id_tn=" + Settings_WD.Default.id_tn +
                                       " and date='" +
                                       day.ToString("yyyy-MM-dd") + "'").Tables[0];
            return String.IsNullOrEmpty(time.Rows[0][0].ToString()) ? "" : time.Rows[0][0].ToString().Substring(0, 5);
        }

        public DataTable PriceDataTable(string subunit)
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
			subunit.id_subunit=work.id_position where subunit='" + subunit +
                             "' order by pay_type DESC, work asc";
            return sql.GetSQLTable(command).Tables[0];
        }

        public bool SavePriceTable(List<WorkWithPrice> insert, List<WorkWithPrice> update, List<WorkWithPrice> delete)
        {
            string command = CreatePriceSaveCommand(insert, update, delete);
            return sql.SetSQLTable(command);
        }

        private string CreatePriceSaveCommand(List<WorkWithPrice> insert, List<WorkWithPrice> update, List<WorkWithPrice> delete)
        {

            string command = CreatePriceInsertCommand(insert);
            command += "\n";
            command += CreatePriceDeleteCommand(delete);
            command += "\n";
            command += CreatePriceUpdateCommand(update);
            return command;
        }

        private string CreatePriceInsertCommand(List<WorkWithPrice> insert)
        {
            if (insert.Count == 0)
                return "";
            string command = "insert into prices values ";
            foreach (var work in insert)
            {
                command += "(" + work.id_work + "," + work.difficult + "," + work.price + "," + work.type + "),";
            }
            command = command.Remove(command.Length - 1) + ";";
            return command;
        }

        private string CreatePriceDeleteCommand(List<WorkWithPrice> delete)
        {
            if (delete.Count == 0)
                return "";
            string command = "delete prices where ";
            foreach (var work in delete)
            {
                command += "(id_work=" + work.id_work + " and difficulty=" + work.difficult + ") or";
            }
            command = command.Remove(command.Length - 2) + ";";
            return command;
        }

        private string CreatePriceUpdateCommand(List<WorkWithPrice> update)
        {
            if (update.Count == 0)
                return "";
            string command = "update prices set price= case difficulty";
            object id_work = null;
            foreach (var work in update)
            {
                if (id_work == null)
                    id_work = work.id_work;
                if (id_work == work.id_work)
                {
                    command += " when " + work.difficult + " then " + work.price;
                    continue;
                }
                command += " else price END, pay_type=" + work.type + " where id_work=" + id_work + ";\n";
                id_work = work.id_work;
                command += "update prices set price= case difficulty when " + work.difficult + " then " + work.price;
            }
            command += " else price END, pay_type = " + update[update.Count - 1].type + " where id_work = " + id_work +
                       ";";
            return command;
        }

        public DataTable GetSubunitWorkerTable(string subunit)
        {
            return sql.GetSQLTable(
                "select * from worker join subunit on worker.id_Subunit=subunit.id_subunit join Position on Position.id_position=worker.id_Position where subunit='" +
                subunit + "' and status<>'f';").Tables[0];
        }

        public DataTable GetPositionTable()
        {
            return sql.GetSQLTable("select * from Position order by position").Tables[0];
        }

        public DataTable GetSubunitInfoFromName(string subunit)
        {
            return sql.GetSQLTable("select * from subunit where subunit='" + subunit + "'").Tables[0];
        }

        public DataTable GetWorkerInfo(object idTn)
        {
            return sql.GetSQLTable(
                "select * from worker join subunit on worker.id_Subunit=subunit.id_subunit join Position on Position.id_position=worker.id_Position where id_tn=" +
                idTn).Tables[0];
        } 

        public bool HideWorker(object idTn)
        {
            return sql.SetSQLTable("update worker set status='f' where id_tn=" + idTn);
        }

        public bool AddWorker(object idTn, object lastName, object firstName, object secondName, object idPosition,
            object subunit, object password, object software, object category)
        {
            if (IsWorkerExist(idTn))
                return EditWorker(idTn, idTn, lastName, firstName, secondName, idPosition, subunit, password, software,category);
            return CreateNewWorker(idTn, lastName, firstName, secondName, idPosition, subunit, password, software,category);
        }

        public bool EditWorker(object oldidTn, object idTn, object lastName, object firstName, object secondName,
            object idPosition,
            object subunit, object password, object software,object category)
        {
            return sql.SetSQLTable("UPDATE worker SET id_tn = " + idTn + ", Last_name = '" + lastName + "', First_name = '" +
                                   firstName + "', Second_name = '" + secondName + "', id_Position = " + idPosition + ", id_Subunit = (select id_subunit from subunit where subunit='" +
                                   subunit + "'), password = " + password + ", tab_nomer = " + idTn +
                                   ", software = '" + software + "', category="+category+" WHERE id_tn = " + oldidTn);
        }

        private bool IsWorkerExist(object idTn)
        {
            var check=sql.GetSQLTable("select * from worker where id_tn=" + idTn);
            if (check.Tables[0].Rows.Count == 0)
                return false;
            return true;
        }

        private bool CreateNewWorker(object idTn, object lastName, object firstName, object secondName,
            object idPosition,
            object subunit, object password, object software, object category)
        {
            return sql.SetSQLTable("insert into worker values(" + idTn + ",'" + lastName + "','" + firstName + "','" +
                                   secondName + "'," + idPosition + ",(select id_subunit from subunit where subunit='" +
                                   subunit + "')," + password + ",'s',"+idTn+",'" + software + "',"+category+")");
        }

        public DataTable GetSubunitWorkTable(object subunit)
        {
            return sql.GetSQLTable("select * from work join subunit on work.id_position=subunit.id_subunit where subunit='"+subunit+"'").Tables[0];
        }

        public DataTable GetWorkCategoryTable(object subunit)
        {
            return sql.GetSQLTable("select DISTINCT job_type from work join subunit on work.id_position=subunit.id_subunit where subunit='" + subunit + "'").Tables[0];
        }

        public bool AddWork(object work, object category, object priority, object subunit)
        {
            return sql.SetSQLTable("insert into work values('" + work + "',(select id_subunit from subunit where subunit='" +
                                   subunit + "'),NULL,'" + category + "',"+priority+")"); 
        }

        public bool EditWork(object idWork, object work, object priority, object category)
        {
            return sql.SetSQLTable("update work set work='" + work + "', job_type='" + category + "', work_rank="+priority+" where id_work=" +
                                   idWork + ";\n " +
                                   "update total set work='" + work + "' where id_work=" + idWork+";");
        }

        public bool ChangeWork(object oldIdWork, object newIdWork, object newWork)
        {
            return sql.SetSQLTable("update total set id_work=" + newIdWork + ", work='" + newWork + "' where id_work=" +
                                   oldIdWork + ";\n " +
                                   "delete work where id_work=" + oldIdWork+";");
        }

        public DataTable GetTabelTable(string subunit,DateTime date)
        {
            string query =
                @"select id,tab_nomer,CONCAT(Last_name,' ', First_name,' ',Second_name)FIO,ttime from worker 
                left join (select * from tabel where tdate='"+StartMonthDate(date)+ @"') tabel on worker.id_tn=tabel.id_tn 
                join subunit on worker.id_Subunit=subunit.id_subunit 
                where subunit='" + subunit+ "' and status!='f' order by FIO;";
            return sql.GetSQLTable(query).Tables[0];
        }
        
        public bool SaveTabelTable(List<WorkWithTabel> insert, List<WorkWithTabel> change, List<WorkWithTabel> delete)
        {
            string command = CreateTabelSaveCommand(insert, change, delete);
            return sql.SetSQLTable(command);
        }

        private string CreateTabelSaveCommand(List<WorkWithTabel> insert, List<WorkWithTabel> update, List<WorkWithTabel> delete)
        {

            string command = CreateTabelInsertCommand(insert);
            command += "\n";
            command += CreateTabelDeleteCommand(delete);
            command += "\n";
            command += CreateTabelUpdateCommand(update);
            return command;
        }

        private string CreateTabelInsertCommand(List<WorkWithTabel> insert)
        {
            if (insert.Count == 0)
                return "";
            string command = "insert into tabel values ";
            foreach (var row in insert)
            {
                command += "(" + row.IdTn + ",'" + row.Date + "','" + row.Ttime + "'),";
            }
            command = command.Remove(command.Length - 1) + ";";
            return command;
        }

        private string CreateTabelDeleteCommand(List<WorkWithTabel> delete)
        {
            if (delete.Count == 0)
                return "";
            string command = "delete tabel where ";
            foreach (var row in delete)
            {
                command += "(id="+row.Id+") or";
            }
            command = command.Remove(command.Length - 2) + ";";
            return command;
        }

        private string CreateTabelUpdateCommand(List<WorkWithTabel> update)
        {
            if (update.Count == 0)
                return "";
            string command = "update tabel set ttime= case id";
            foreach (var row in update)
            {
                command += " when " + row.Id + " then '" + row.Ttime + "'";
                continue;
            }
            command += " else ttime END;\n";

            return command;
        }

        public DataTable GetActualFormTable(string subunit, DateTime date)
        {
            var startDate = StartMonthDate(date);
            var endDate = EndMonthDate(date);
            string query =
                @"select *, endDate as endDateEdit from formUsing join total on id_creator=id where subunit='"+subunit+"' and (endDate is NULL or endDate between '"+startDate+"' and '"+endDate+ "') order by FIO";
            return sql.GetSQLTable(query).Tables[0];
        }

        public bool ActualFormInsert(ActualFormObject insert)
        {

            string command = "insert into formUsing values('" + insert.IdForm + "'," + insert.IdTn + ",'" + insert.StartDate + "'," + insert.EndDate + "," + insert.Difficulty + "," + insert.IdCreator + ");";
            return sql.SetSQLTable(command);
        }

        public bool ActualFormDelete(ActualFormObject delete)
        {
            string command = "delete formUsing where id_form='" + delete.IdForm + "' and id_tn=" + delete.IdTn + ";";
            return sql.SetSQLTable(command);
        }

        public bool SaveActualFormTable( List<ActualFormObject> change)
        {
            if (change.Count == 0)
                return true;
            var result = CorrectIdCreator(change);
            if (!result)
                return false;
            change = newChangeList;
            string command = CreateActualFormUpdateCommand(change);
            result = sql.SetSQLTable(command);
            result= change.Select(record => SetPayment(record.IdCreator, record.Difficulty, (double)record.Price))
                .Aggregate(result, (current, tempresult) => tempresult && current);
            return CloseOtherFormPayment(change);
        }

        List<ActualFormObject> newChangeList;

        private bool CorrectIdCreator(List<ActualFormObject> change)
        {
            var command = "update formUsing set id_creator= case id_creator";
            for (int i=0 ;i<change.Count;i++)
            {
                var totalData = DateTime.Parse(change[i].Date.ToString());
                var editData = DateTime.Parse(change[i].EndDateEdit.ToString());
                if(totalData.Month==editData.Month && totalData.Year == editData.Year)
                    continue;
                var id = FindNewIdFromTotal(change[i].IdTn, change[i].IdWork, change[i].IdForm, editData);
                if (id == null)
                {
                    MessageBox.Show("Форма "+change[i].IdForm+" не может быть оплачена в указаный месяц");
                    return false;
                }
                command += " when " + change[i].IdCreator + " then " + id;
                change[i].IdCreator = id;

            }
            command += " else id_creator END;\n";
            newChangeList = change;
            return command.Equals("update formUsing set id_creator= case id_creator else id_creator END;\n") || sql.SetSQLTable(command);
        }

        public object FindNewIdFromTotal(object idTn, object idWork, object formId, DateTime month)
        {
            var command = "select TOP 1 id from total where id_tn=" + idTn + " and id_work=" + idWork +
                          " and form_id='" + formId + "' and date between '" + StartMonthDate(month) + "' and '" +
                          EndMonthDate(month) + "'";
            var result = sql.GetSQLTable(command).Tables[0];
            return result.Rows.Count == 0 ? null : result.Rows[0]["id"];

        }

        private string CreateActualFormUpdateCommand(List<ActualFormObject> update)
        {
            if (update.Count == 0)
                return "";
            string command = "update formUsing set difficulty= case id_creator";
            foreach (var row in update)
            {
                command += " when " + row.IdCreator + " then " + row.Difficulty;
                continue;
            }
            command += " else difficulty END;\n";
            command += " update formUsing set endDate='" + DateTime.Today.ToString("dd-MM-yyyy") + "' where endDate is NULL and difficulty<>0";
            return command;
        }

        private bool CloseOtherFormPayment(List<ActualFormObject> change)
        {
            string command="";
            foreach (var record in change)
            {
                command += "update total set difficult=NULL where (id_work=88 or id_work=87) and form_id='" +
                           record.IdForm + "' and id<>" + record.IdCreator+";";
            }
            return sql.SetSQLTable(command);
        }

        private string StartMonthDate(DateTime month)
        {
            return month.ToString("01-MM-yyyy");
        }

        private string EndMonthDate(DateTime month)
        {
            return DateTime.DaysInMonth(month.Year, month.Month) + month.ToString("-MM-yyyy");
        }

        public DataTable ReportDayReportTable(DateTime date)
        {
            var command = "select * from total where id_tn=" + Settings_WD.Default.id_tn + " and date='" + date.ToString("dd.MM.yyyy") +
                          "' order by time_begin";
            var result = sql.GetSQLTable(command).Tables[0];
            return result;
        }

        public DataTable ReportOverWorkTable(string startDate, string endDate, object subunit)
        {
            var command = @"select DISTINCT CONCAT(Last_name,' ',SUBSTRING(First_name,1,1),'. ',SUBSTRING(Second_name,1,1),'.') FIO , 
                (select sum(DATEDIFF(minute,0,cast(time_span as datetime))) from total where tl.id_tn=total.id_tn and date between '" +//id_Subunit=0 тут где то хуйня выходит!!!! перепроверитьёё!!!
                          startDate + "' and '" + endDate +
                          "') Total_Time, ttime from tabel tl join worker on tl.id_tn=worker.id_tn where id_Subunit=" + subunit +
                          " and tdate between '" + startDate +
                          "' and '" + endDate + "'";
            var result = sql.GetSQLTable(command).Tables[0];
            result.Columns.Add("SubTime");
            result.Columns.Add("TotalTime");
            result.Columns.Add("NeedTimeMinute");
            for (int i = 0; i < result.Rows.Count; i++)
            {
                int needTime = Convert.ToInt32(result.Rows[i]["ttime"].ToString().Split(':')[0]) * 60 +
                               Convert.ToInt32(result.Rows[i]["ttime"].ToString().Split(':')[1]);
                double sub = (int)result.Rows[i]["Total_Time"] - needTime;
                result.Rows[i]["SubTime"] =
                    Math.Floor(sub / 60) + ":" + (((sub % 60) < 10) ? ("0" + sub % 60) : ("" + sub % 60));
                result.Rows[i]["TotalTime"] = Math.Floor(Convert.ToDouble(result.Rows[i]["Total_Time"]) / 60) + ":" +
                                          (Convert.ToDouble(result.Rows[i]["Total_Time"]) % 60 < 10
                                              ? "0" + (Convert.ToDouble(result.Rows[i]["Total_Time"]) % 60)
                                              : "" + (Convert.ToDouble(result.Rows[i]["Total_Time"]) % 60));
                result.Rows[i]["NeedTimeMinute"] = needTime;
            }
            return result;
        }

        public DataTable ReportPrinter3DTable(string startDate, string endDate, object idTn)
        {
            var command = @"select DISTINCT substring(work,13,LEN(work)-13) work,
                other,FIO,subunit,
            (select sum(datediff(minute,0,cast(time_span as datetime))) from total tl where tl.work=total.work and tl.other=total.other and tl.id_tn=total.id_tn and tl.date between '" +
                          startDate + "' and '" + endDate +
                          @"') time_minutes,
            (select sum(datediff(minute,0,cast(time_span as datetime))) from total tl where tl.work=total.work and tl.id_tn=total.id_tn and tl.date between '" +
                          startDate + "' and '" + endDate +
                          @"') work_minutes
                from total where work like '3D принтер%' and date between '" +
                          startDate + "' and '" + endDate +
                          "' and id_tn=" + idTn;
            var result = sql.GetSQLTable(command).Tables[0];
            result= ConvertTimeFromMinute(result, "time_minutes", "time_span").Copy();
            result= ConvertTimeFromMinute(result, "work_minutes", "work_time_span").Copy();
            return result;
        }
        
        private DataTable ConvertTimeFromMinute(DataTable dt, string minuteColumn, string addable)
        {
            dt.Columns.Add(addable);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TimeSpan tp = TimeSpan.FromMinutes(Convert.ToDouble(dt.Rows[i][minuteColumn]));
                dt.Rows[i][addable] = Math.Floor(tp.TotalHours) + ":" +
                                                (tp.Minutes < 10 ? "0" + tp.Minutes : tp.Minutes + "");
            }
            return dt;
        }

        public DataTable ReportModelDevelopTable(string startDate, string endDate, object idTn)
        {
            var command = @"select DISTINCT other,FIO,subunit,
                (select sum(datediff(minute,0,cast(time_span as datetime))) from total tl where tl.work=total.work and tl.other=total.other and tl.id_tn=total.id_tn and date between '" +
                          startDate + "' and '" + endDate +
                          @"') minutes from total where work='Разработка модели' and date between '" + startDate +
                          "' and '" + endDate + "' and id_tn=" + idTn;
            var result = sql.GetSQLTable(command).Tables[0];
            result = ConvertTimeFromMinute(result, "minutes", "time_span").Copy();
            return result;
        }

        public DataTable ReportWorkNoFormTable(string startDate, string endDate)
        {
            var command = @"select * from total where date between '" + startDate + "' and '" +
                          endDate + "' and id_tn=" + Settings_WD.Default.id_tn + " and form_id IS NULL";
            var result = sql.GetSQLTable(command).Tables[0];
            return result;
        }

        public DataTable ReportMainJobListTable(object subunit)
        {
            var command = "select DISTINCT job_type from work where id_position=" + subunit;
            var result = sql.GetSQLTable(command).Tables[0];
            return result;
        }

        public DataTable ReportUnitTable(object startDate, string endDate, object idTn)
        {
            var command = @"select * from total join work on work.id_work=total.id_work
                     where id_tn=" + idTn
                          + "and date between '" + startDate + "' and '" + endDate + "'";
            var result = sql.GetSQLTable(command).Tables[0];
            return result;
        }

        public DataTable ReportTabelTable(object subunit, DateTime date)
        {
            var command =
                @"select tabel.id_tn, ttime,concat(Last_name,' ',First_name,' ',Second_name) FIO,position from tabel join worker on tabel.id_tn=worker.id_tn join Position on worker.id_Position=Position.id_position where (select id_Subunit from subunit where subunit='" +
                subunit + "') =id_Subunit and" + " tdate between '" + StartMonthDate(date) +
                "' and '" + EndMonthDate(date) + "'";
            var result = sql.GetSQLTable(command);
            return result.Tables[0];
        }

        public DataRow ReportTabelUnitRow(object idTn, string subunit, DateTime date)
        {
            var fulltabel = ReportTabelTable(subunit, date);
            var result = fulltabel?.Select("id_tn=" + idTn);
            return result.Length == 0 ? null : result[0];
        }

        public DataTable ReportPayFormTable(object startDate,object endDate,object idTn)
        {
            string command = @"select DISTINCT form_id, name_form, subunit, 
                                (select SUM(DATEDIFF(MINUTE,'00:00:00.000',time_span)) from total tl 
                                where tl.subunit=tl2.subunit and tl.id_tn=tl2.id_tn and form_id is NULL and date between '" +
                             startDate + "' and '" + endDate + @"') TimeInMinutes,
                                (select sum(payment) as payment from total as tl1 where tl1.subunit=tl2.subunit and tl1.id_tn=tl2.id_tn and form_id is NULL and date between '" +
                             startDate + "' and '" + endDate + @"') as payment
                                from total tl2 where form_id is NULL and id_tn=" + idTn + "  and date between '" +
                             startDate + "' and '" + endDate + @"'
                                union
                                select DISTINCT form_id, name_form, subunit,
                                (select SUM(DATEDIFF(MINUTE,'00:00:00.000',time_span)) as time_span from total tl 
                                where tl.form_id=total.form_id and tl.subunit=total.subunit and tl.id_tn=total.id_tn and date between '" +
                             startDate + "' and '" + endDate + @"') TimeInMinutes,
                                (select sum(payment) as time_span from total tl where tl.form_id=total.form_id and tl.subunit=total.subunit and tl.id_tn=total.id_tn and date between '" +
                             startDate + "' and '" + endDate + @"') payment
                                from total where id_tn=" + idTn + " and date between '" + startDate + "' and '" +
                             endDate + @"' and form_id is not null;";
       
            DataTable tableSet = sql.GetSQLTable(command).Tables[0];
            if (tableSet == null)
                return new DataTable();
            tableSet = FixReportTable(tableSet).Copy();
            return tableSet;
        }

        private DataTable FixReportTable(DataTable table)
        {
            table.Columns.Add("time_span");
            for (int i = 0; i < table.Rows.Count; i++)
            {
                var timeInMinutes = table.Rows[i]["TimeInMinutes"];
                table.Rows[i]["time_span"] = FromMinutesToTime(timeInMinutes);
                table.Rows[i]["payment"] = table.Rows[i]["payment"] == DBNull.Value ? 0: table.Rows[i]["payment"];
                table.Rows[i]["subunit"] =
                    table.Rows[i]["form_id"] == DBNull.Value ? "Прочее("+table.Rows[i]["subunit"]+")" : table.Rows[i]["subunit"];
            }
            return table;
        }

        private string FromMinutesToTime(object timeinMinutes)
        {
            if (String.IsNullOrEmpty(timeinMinutes.ToString()))
            {
                return "0";
            }
            TimeSpan time = TimeSpan.FromMinutes(Convert.ToDouble(timeinMinutes));
            var hours = Math.Floor(time.TotalHours);
            var minutes = time.Minutes >= 10 ? time.Minutes.ToString() : "0" + time.Minutes;
            return hours + ":" + minutes;
        }

        public DataTable GetWorkPercentReport(object startDate, object endDate, object subunitId, object[] users)
        {
            var command = $@"DECLARE @startDate date, @endDate date, @subunitId int
            SET @startDate = '{startDate}';
            SET @endDate = '{endDate}';
            SET @subunitId = {subunitId};";
            command += CreatePercentReportCommandBody(users);
            var table = sql.GetSQLTable(command).Tables[0];
            return FixWorkPercentReport(table,users.Length);
        }

        private string CreatePercentReportCommandBody(object[] users)
        {
            var usersSearch = "(";
            usersSearch = users.Aggregate(usersSearch, (current, user) => current + $" id_tn={user} or");
            usersSearch = usersSearch.Remove(usersSearch.Length - 2) + ")";
            var command = $"\n SELECT DISTINCT ROW_NUMBER() OVER(ORDER BY work asc) as id, id_work ,work,";
            int count = 0;
            foreach (var user in users)
            {
                command +=
                    $"\n(select SUM(DATEDIFF(MI,0,time_span)) from total where work.id_work=total.id_work and id_tn={user} and date between @startDate and @endDate) as user{count},";
                count++;
            }
            command += $@"(select SUM(DATEDIFF(MI,0,time_span)) from total where work.id_work=total.id_work and {
                    usersSearch
                } and date between @startDate and @endDate) as workSummary,
                (select SUM(DATEDIFF(MI,0,time_span)) from total where {
                    usersSearch
                } and date between @startDate and @endDate) as summary
                FROM work where id_position=@subunitId order by id;";
            return command;

        }

        private DataTable FixWorkPercentReport(DataTable table, int usersCount)
        {
            table.Columns.Add("percent");
            table.Columns.Add("timeWorkSum");
            for (int id = 0; id < usersCount; id++)
            {
                table.Columns.Add($"user{id}Time");
            }
            for (int rowIndex = 0; rowIndex < table.Rows.Count; rowIndex++)
            {

                var workSum = table.Rows[rowIndex]["workSummary"].Equals(DBNull.Value)
                    ? 0
                    : Convert.ToDouble(table.Rows[rowIndex]["workSummary"]);
                var sum = table.Rows[rowIndex]["summary"].Equals(DBNull.Value)
                    ? 0
                    : Convert.ToDouble(table.Rows[rowIndex]["summary"]);
                var percent = workSum * 100 / sum;
                var roundedPercent = Math.Round(percent, 2);
                table.Rows[rowIndex]["percent"] = roundedPercent + "%";
                table.Rows[rowIndex]["timeWorkSum"] = FromMinutesToTime(workSum);
                for (int userid = 0; userid < usersCount; userid++)
                {
                    var userMinutes = table.Rows[rowIndex]["user" + userid].Equals(DBNull.Value)
                        ? 0
                        : Convert.ToDouble(table.Rows[rowIndex]["user" + userid]);
                    table.Rows[rowIndex][$"user{userid}Time"] = FromMinutesToTime(userMinutes);
                }
                
            }
            return table;
        }
    }
}

