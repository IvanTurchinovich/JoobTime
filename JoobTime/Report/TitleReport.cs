using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.Xpf.Core;
using DevExpress.XtraReports.UI;
using JoobTime.Properties;

namespace JoobTime
{
    public partial class TitleReport : DevExpress.XtraReports.UI.XtraReport
    {
        public TitleReport()
        {
            try
            {
                InitializeComponent();
                string[] fio = ReportGenerating.fio_for_report.Split(' ');
                var result = Fionerf(DeclensionBLL.GetSNPDeclensionAS((string)fio[0], (string)fio[1], (string)fio[2],
                    DeclensionCase.Tvorit));
                xrLabel4.Text = "Отчет о проделанной работе " +
                                DeclensionBLL.GetAppointmentDeclension(ReportGenerating.position,
                                    DeclensionCase.Tvorit) + " " + result + " с " +
                                Convert.ToDateTime(ReportGenerating.startDate).ToShortDateString() + " по " +
                                Convert.ToDateTime(ReportGenerating.endDate).ToShortDateString();
                if (DeclensionBLL.GetGender(ReportGenerating.fio_for_report) == Gender.FeminineGender)
                {
                    xrLabel1.Text = "Подготовила:";
                }
                xrLabel2.Text = Settings_WD.Default.FIO;
                xrLabel3.Text = DateTime.Now.Year + " г.";
                Formcorrect();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                throw;
            }
        }

        private string Fionerf(string full)
        {
            string[] array = full.Split(' ');
            return array[0] + " " + array[1].Substring(0, 1) + ". " + array[2].Substring(0, 1) + ".";
        }

        private void Formcorrect()
        {
            for (int i = 84; ; i += 28)
            {
                if (xrLabel4.Text.Length <= (i + 28))
                    return;
                xrLabel4.Height = xrLabel4.Height + 40;
                xrPictureBox2.Height = xrPictureBox2.Height + 40;
            }


        }
    }
}
