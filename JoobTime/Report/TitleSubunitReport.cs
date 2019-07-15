using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;


namespace JoobTime
{
    public partial class TitleSubinitReport : DevExpress.XtraReports.UI.XtraReport
    {
        public TitleSubinitReport()
        {
            try
            {
                InitializeComponent();
                string subunit;

                switch (ReportGenerating.subunit_for_report)
                {
                    case "3D дизайн":
                        subunit = Properties.Resources.design3d;
                        break;
                    case "2D формы":
                        subunit = Properties.Resources.form2d;
                        break;
                    case "3D формы":
                        subunit = Properties.Resources.form3d;
                        break;
                    case "УП-формообразующие и электроды":
                    case "УП-плиты":
                        subunit = Properties.Resources.up;
                        break;
                    default:
                        subunit = "";
                        break;
                }
                xrLabel4.Text = "Отчет о проделанной работе отделом по разработке " +subunit+ " с " +
                                Convert.ToDateTime(ReportGenerating.startDate).ToShortDateString() + " по " +
                                Convert.ToDateTime(ReportGenerating.endDate).ToShortDateString();
                if (DeclensionBLL.GetGender(ReportGenerating.fio_for_report) == Gender.FeminineGender)
                {
                    xrLabel1.Text = "Подготовила:";
                }xrLabel2.Text = Fionerf(ReportGenerating.fio_for_report);
                xrLabel3.Text = DateTime.Now.Year + " г.";
                Formcorrect();
            }
            catch (Exception e){
                MessageBox.Show(e.Message);
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
            for (int i = 84;; i += 28)
            {
                if (xrLabel4.Text.Length <= (i+28))
                    return;
                xrLabel4.Height = xrLabel4.Height + 40;
                xrPictureBox2.Height = xrPictureBox2.Height + 40;
            }

         
        }

    }
}
