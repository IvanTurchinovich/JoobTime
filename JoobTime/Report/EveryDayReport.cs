using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using DevExpress.XtraReports.UI;

namespace JoobTime
{
    public partial class EveryDayReport : DevExpress.XtraReports.UI.XtraReport
    {
        public EveryDayReport(DateTime date)
        {
            InitializeComponent();
            string[] fio = formLogin.FIO.Split(' ');
            string result = Fionerf(DeclensionBLL.GetSNPDeclensionAS((string)fio[0], (string)fio[1], (string)fio[2],
                DeclensionCase.Tvorit));
            TitleLabel.Text = "Отчет о проделанной работе " +
                              DeclensionBLL.GetAppointmentDeclension(ReportGenerating.position,
                                  DeclensionCase.Tvorit) + " " + result + "\n за " + date.ToString("dd.MM.yyyy");
            if (DeclensionBLL.GetGender(formLogin.FIO) == Gender.FeminineGender)
            {
                xrLabel12.Text = "Отчет составила";
            }
            CreatedFIO.Text = Fionerf(formLogin.FIO);
            GetFIO.Text = GetTheBoss();
        }
        private string Fionerf(string full)
        {
            string[] array = full.Split(' ');
            
            return array[0] + " " + array[1].Substring(0, 1) + ". " + array[2].Substring(0, 1) + ".";
        }

        private string GetTheBoss()
        {
            if (new string[]{"2322","4451","4199"}.Contains(formLogin.id_tn))
                return "Степанчук А.М.";
            switch (formLogin.subunit)
            {
                case "5": return "Рожков В.А.";
                case "6": return "Макаров К.В.";
                case "1017":
                case "1018":
                case "7": return "Езапенко С.В.";
                    default:
                        return "Степанчук А.М.";
            }
        }
        private void sumtimeCell_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            string strin_f = ts1.TotalHours.ToString();//(0,2) + ":" + ts.Minutes.ToString();
            string itog;
            // e.TotalValue = strin_f;
            if (strin_f.Contains(",") == true)
            {
                int len = strin_f.IndexOf(',', 0);
                if (ts1.Minutes.ToString().Length > 1)
                {
                    itog = strin_f.Substring(0, len) + ":" + ts1.Minutes.ToString();
                    e.Result = itog;
                }
                else
                {
                    itog = strin_f.Substring(0, len) + ":0" + ts1.Minutes.ToString();
                    e.Result = itog;
                }
            }
            else
            {
                if (ts1.Minutes.ToString().Length > 1)
                {
                    itog = strin_f + ":" + ts1.Minutes.ToString();
                    e.Result = itog;
                }
                else
                {
                    itog = strin_f + ":0" + ts1.Minutes.ToString();
                    e.Result = itog;
                }
            }
            e.Handled = true;
        }

        private void sumtimeCell_SummaryRowChanged(object sender, EventArgs e)
        {
            string w = System.Convert.ToString(GetCurrentColumnValue("time_span"));
            ts1 += System.TimeSpan.Parse(w);
        }
    }
}
