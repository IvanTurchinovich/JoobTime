using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using DevExpress.Xpf.Core;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using JoobTime.Properties;

namespace JoobTime
{
    class ReportGenerating
    {
        private DB db = new DB();
        public static string startDate;
        public static string endDate;
        public static string fio_for_report;
        public static string subunit_for_report;
        public static string position;
        private readonly bool isForm = Settings_WD.Default.isForm;
        private int _subunit;

        public string[] getReportList(string subunit)
        {
            string[] value;
            switch (subunit)
            {
                case "Отдел по развитию предприятия": 
                    value = new[]
                    {
                        "Ежедневный на текущую дату", "Ежедневный за период", "Полный"
                    };
                    break;
                case "Инструментальный цех": 
                case "Сертификация": 
                case "Проектное бюро": 
                case "Ремонт и нестандартная оснастка": 
                case "Транспортный Участок": 
                    value = new[]
                    {
                        "Ежедневный на текущую дату", "Ежедневный за период", "Полный"

                    };
                    break;
                case "3D дизайн":
                    value = new[]
                    {
                        "Ежедневный на текущую дату", "Ежедневный за период"
                    };
                    break;
                case "2D формы": 
                case "3D формы": 
                case "УП-формообразующие и электроды":
                case "УП-плиты":
                    value = new[]
                    {
                        "Ежедневный на текущую дату", "Ежедневный за период"
                    };
                    break;
                default:
                    value = new[] { "Ежедневный на текущую дату", "Ежедневный за период" };
                    break;
            }
            return value;
        }

        public void Createreport(int subunit, DataTable bs, string type,object idWorker,object worker)
        {
            _subunit = subunit;
            XtraReport report;
            switch (type)
            {
                case "Сделка по формам":
                    report = PaymentWithForms(idWorker, worker);
                    break;
                case "Сделка по датам":
                    report = PaymentWithForms(idWorker, worker);
                    break;
                case "Ежедневный на текущую дату":
                    report = EveryDay(DateTime.Today);
                    break;
                case "Ежедневный за период":
                    report=EveryDayPeriod();
                    break;
                case "Работа отдела":
                    report = CreateSubunitMonthReport();
                    break;
                case "Работа сотрудника":
                    var date = DateTime.Parse(startDate);
                    var row = db.ReportTabelUnitRow(idWorker, subunit_for_report, date);
                    if (row == null)
                    {
                        MessageBox.Show("Для сотрудника " + worker + " не указано табельное время.");
                        return;
                    }
                    report = CreateSubunitUnitMonthReport(row);
                    break;
                case "Титульный лист":
                    report = TitleList();
                    break;
                case "По виду работ":
                    report = JobReport(bs);
                    break;
                case "По дате":
                    report = DateReport(bs);
                    break;
                case "Сумма работ за месяц":
                    report = JobSumReport(bs);
                    break;
                case "Сумма по форме за месяц":
                    report = FormSumReport(bs);
                    break;
                case "Виды работ по форме":
                    report = FormReport(bs);
                    break;
                case "По разработке дизайна":
                    report = ModelDevelopReport(Settings_WD.Default.id_tn);
                    break;
                case "Основные виды работ":
                    report = MainJobList(Settings_WD.Default.subunit_id);
                    break;
                case "По 3D принтеру":
                    report = Printer3DReport(Settings_WD.Default.id_tn);
                    break;
                case "Переработка":
                    report = OverWorkTime(subunit);
                    break;
                case "Полный":
                    if (isForm)
                        report = FormClassicReport(bs);
                    else
                        report = NoFormClassicReport(bs);
                    break;
                default:
                    report = new XtraReport();
                    break;
            }
            ReportPrintTool print = new ReportPrintTool(report);
            print.ShowRibbonPreviewDialog();
        }

        private XtraReport PaymentWithForms(object idWorker,object worker)
        {
            XtraReport report;
            if (idWorker.Equals(0))
                report = GenerateSubunitFormReport();
            else
            {
                report = new ReportFormPayment(worker);
                report.DataSource = db.ReportPayFormTable(startDate, endDate, idWorker);
                report.CreateDocument();
            }
            return report;
        }

        private XtraReport GenerateSubunitFormReport()
        {
            DataTable workerList = db.GetWorkerList(startDate, endDate, subunit_for_report);
            XtraReport report = new XtraReport();
            foreach (DataRow row in workerList.Rows)
            {
                report.Pages.AddRange(PaymentWithForms(row["id_tn"], row["FIO"]).Pages);
                if (report.Pages.Count % 2 == 1)
                    report.Pages.Add(EmptyPage());
            }
            return report;
        }

        private XtraReport PaymentsWithDate(object idWorker, object worker)
        {
            XtraReport report;
            if (idWorker.Equals(0))
                report = GenerateSubunitDateReport();
            else
            {
                report = new ReportDatePayment(worker);
                report.DataSource = db.GetWorkerTable(startDate, endDate, idWorker);
                report.CreateDocument();
            }
            return report;
        }

        private XtraReport GenerateSubunitDateReport()
        {
            DataTable workerList = db.GetWorkerList(startDate, endDate, subunit_for_report);
            XtraReport report = new XtraReport();
            foreach (DataRow row in workerList.Rows)
            {
                report.Pages.AddRange(PaymentsWithDate(row["id_tn"],row["FIO"]).Pages);
                if (report.Pages.Count % 2 == 1)
                    report.Pages.Add(EmptyPage());
            }
            return report;
        }

        public XtraReport CreateSubunitMonthReport()
        {

            XtraReport report = new XtraReport();
            report.Pages.AddRange(TitlePageSubunit().Pages);
            report.Pages.AddRange(MainJobList(_subunit).Pages);
            if (report.Pages.Count % 2 == 1)
                report.Pages.Add(EmptyPage());
            report.Pages.AddRange(OverWorkTime(_subunit).Pages);
            var date = DateTime.Parse(startDate);
            var tabel = db.ReportTabelTable(subunit_for_report, date);
            if (tabel == null || tabel.Rows.Count==0)
            {
                MessageBox.Show("На указаный месяц отсутствуют записи в табеле");
                return new XtraReport();
            }
            foreach (DataRow row in tabel.Rows)
            {
                if (report.Pages.Count % 2 == 1)
                    report.Pages.Add(EmptyPage());
                report.Pages.AddRange(CreateSubunitUnitMonthReport(row).Pages);
            }
            if (report.Pages.Count % 2 == 0)
                report.Pages.Add(EmptyPage());
            return report;
        }

        public XtraReport CreateSubunitUnitMonthReport(DataRow unit)
        {
            XtraReport report = new XtraReport();
            int idTn = (int) unit["id_tn"];
            var dt = db.ReportUnitTable(startDate, endDate, idTn);
            if (dt == null)
            {
                MessageBox.Show("Для сотрудника " + unit["FIO"] + " не указано табельное время.");
                return report;
            }

            fio_for_report = unit["FIO"].ToString();
            position = unit["position"].ToString().ToLower();
            report.Pages.AddRange(TitleList().Pages);
            report.Pages.AddRange(SubunitJobReport(dt, unit["ttime"].ToString()).Pages);
            if (report.Pages.Count % 2 == 1)
                report.Pages.Add(EmptyPage());
            report.Pages.AddRange(JobSumReport(dt).Pages);
            switch (_subunit)
            {
                case 5:
                    report = HeartOf3DDesignSubunitReport(report, idTn);
                    break;
                case 6:
                case 7:
                case 1017:
                case 1018:
                    report = HeartOfFormSubunitReport(report, dt);
                    break;
                default: break;
            }
            if (report.Pages.Count % 2 == 0)
                report.Pages.Add(EmptyPage());
            return report;
        }

        public XtraReport HeartOf3DDesignSubunitReport(XtraReport report, int idTn)
        {
            if (report.Pages.Count % 2 == 1)
                report.Pages.Add(EmptyPage());
            report.Pages.AddRange(Printer3DReport(idTn).Pages);
            if (report.Pages.Count % 2 == 1)
                report.Pages.Add(EmptyPage());
            report.Pages.AddRange(ModelDevelopReport(idTn).Pages);
            return report;
        }

        public XtraReport HeartOfFormSubunitReport(XtraReport report,DataTable dt)
        {
            if (report.Pages.Count % 2 == 1)
                report.Pages.Add(EmptyPage());
            report.Pages.AddRange(FormReport(dt).Pages);
            if (report.Pages.Count % 2 == 1)
                report.Pages.Add(EmptyPage());
            report.Pages.AddRange(FormSumReport(dt).Pages);
            return report;
        }

        private XtraReport NoFormClassicReport(DataTable dt)
        {
            XtraReport report = new XtraReport();
            report.Pages.AddRange(TitleList().Pages);
            report.Pages.AddRange(MainJobList(Settings_WD.Default.subunit_id).Pages);
            if (report.Pages.Count % 2 == 1)
                report.Pages.Add(EmptyPage());
            report.Pages.AddRange(JobSumReport(dt).Pages);
            if (report.Pages.Count % 2 == 1)
                report.Pages.Add(EmptyPage());
            if (_subunit == 5)
            {
                report.Pages.AddRange(Printer3DReport(Settings_WD.Default.id_tn).Pages);
                if (report.Pages.Count % 2 == 1)
                    report.Pages.Add(EmptyPage());
                report.Pages.AddRange(ModelDevelopReport(Settings_WD.Default.id_tn).Pages);
                if (report.Pages.Count % 2 == 1)
                    report.Pages.Add(EmptyPage());
            }
            report.Pages.AddRange(DateReport(dt).Pages);
            if (report.Pages.Count % 2 == 0)
                report.Pages.Add(EmptyPage());
            return report;
        }

        private XtraReport FormClassicReport(DataTable dt)
        {
            XtraReport report = new XtraReport();
            report.Pages.AddRange(TitleList().Pages);
            report.Pages.AddRange(MainJobList(Settings_WD.Default.subunit_id).Pages);
            if (report.Pages.Count % 2 == 1)
                report.Pages.Add(EmptyPage());
            report.Pages.AddRange(JobSumReport(dt).Pages);
            if (report.Pages.Count % 2 == 1)
                report.Pages.Add(EmptyPage());
            report.Pages.AddRange(FormSumReport(dt).Pages);
            if (report.Pages.Count % 2 == 1)
                report.Pages.Add(EmptyPage());
            report.Pages.AddRange(FormReport(dt).Pages);
            if (report.Pages.Count % 2 == 1)
                report.Pages.Add(EmptyPage());
            report.Pages.AddRange(WorkNoForm().Pages);
            if (report.Pages.Count % 2 == 1)
                report.Pages.Add(EmptyPage());
            report.Pages.AddRange(DateReport(dt).Pages);
            if (report.Pages.Count % 2 == 0)
                report.Pages.Add(EmptyPage());
            return report;
        }

        private XtraReport JobSumReport(DataTable dt)
        {
            month_work_report rep_work_month = new month_work_report();
            rep_work_month.DataSource = dt;
            rep_work_month.CreateDocument();
            return rep_work_month;
        }

        private XtraReport TitleList()
        {
            TitleReport title = new TitleReport();
            title.CreateDocument();
            title.Pages.Add(EmptyPage());
            return title;
        }

        private Page EmptyPage()
        {
            XtraReport empty = new XtraReport();
            empty.Landscape = true;
            empty.PaperKind = PaperKind.A4;
            empty.Bands.Add(new DetailBand());
            empty.Bands[BandKind.Detail].Controls.Add(new XRLabel());
            empty.CreateDocument();
            return empty.Pages[0];
        }

        private XtraReport FormSumReport(DataTable bs)
        {
            press_form_report pres_form = new press_form_report();
            pres_form.DataSource = bs;
            pres_form.CreateDocument();
            return pres_form;
        }

        private XtraReport MainJobList(object subunit)
        {
            var dt = db.ReportMainJobListTable(subunit);
            MainJobsReport mjr = new MainJobsReport();
            mjr.DataSource = dt;
            mjr.CreateDocument();
            return mjr;
        }

        private XtraReport DateReport(DataTable bs)
        {
            XtraReport report;
            if (isForm)
                report = new report_date();
            else if (_subunit == 1015)
                report = new pb_report_date();
            else
                report = new no_forms_report_date();
            report.DataSource = bs;
            report.CreateDocument();
            return report;
        }

        private XtraReport FormReport(DataTable bs)
        {
            pres_form_rep2 prs = new pres_form_rep2();
            prs.DataSource = bs;
            prs.CreateDocument();
            return prs;
        }

        private XtraReport JobReport(DataTable bs)
        {
            XtraReport report;
            if (isForm)
                report = new report_work();
            else
                report = new no_forms_report_work();
            report.DataSource = bs;
            report.CreateDocument();
            return report;
        }

        private XtraReport SubunitJobReport(DataTable bs, string workTime)
        {
            XtraReport report;
            if (isForm)
                report = new report_work_subunit(workTime);
            else
                report = new no_forms_report_work_subunit(workTime);
            report.DataSource = bs;
            report.CreateDocument();
            return report;
        }

        private XtraReport WorkNoForm()
        {
            var dt = db.ReportWorkNoFormTable(startDate, endDate);
            work_noform_rep wnrep = new work_noform_rep();
            wnrep.DataSource = dt;
            wnrep.CreateDocument();
            return wnrep;
        }

        private XtraReport ModelDevelopReport(int idTn)
        {
            var dt = db.ReportModelDevelopTable(startDate, endDate, idTn);
            XtraReport report = new ReportdesingDev(dt);
            report.DataSource = dt;
            report.CreateDocument();
            return report;
        }

        private XtraReport Printer3DReport(int idTn)
        {
            var dt = db.ReportPrinter3DTable(startDate, endDate, idTn);
            var print = new ReportPrint(dt.DataSet);
            print.DataSource = dt;
            print.CreateDocument();
            return print;
        }

        private XtraReport OverWorkTime(object subunit)
        {
            OverWork_report ov = new OverWork_report();
            var dt = db.ReportOverWorkTable(startDate,endDate,subunit);
            ov.DataSource = dt;
            ov.FillChart(dt);
            ov.CreateDocument();
            return ov;
        }

        private XtraReport TitlePageSubunit()
        {
            TitleSubinitReport title = new TitleSubinitReport();
            title.CreateDocument();
            title.Pages.Add(EmptyPage());
            return title;
        }

        private XtraReport EveryDay(DateTime date)
        {
            XtraReport report = isForm ? (XtraReport) new EveryDayReport(date) : new EveryDayReportNoForm(date);
            DataTable dt = db.ReportDayReportTable(date);
            if (dt.Rows.Count == 0)
            {
                return new XtraReport();
            }
            report.DataSource = dt;
            report.CreateDocument();
            return report;
        }

        private XtraReport EveryDayPeriod()
        {
            var report = new XtraReport();
            DateTime startDate = DateTime.Parse(ReportGenerating.startDate);
            DateTime endDate = DateTime.Parse(ReportGenerating.endDate);
            var days = endDate - startDate;
            for (int i = 0; i <= days.TotalDays; i++)
            {
                DateTime day = startDate.AddDays(i);
                report.Pages.AddRange(EveryDay(day).Pages);
                if(report.Pages.Count%2==1)
                report.Pages.Add(EmptyPage());
            }
            return report;
        }
    }
}
