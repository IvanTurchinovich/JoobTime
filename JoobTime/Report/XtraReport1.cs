using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace JoobTime
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport1()
        {
            InitializeComponent();
            //DataTable dt_chart = month_work_report.dt_chart;
            //for (int i = 0; i < dt_chart.Rows.Count; i++)
            //{
            //    double[] d = new double[1];
            //    DevExpress.XtraCharts.SeriesPoint w = new DevExpress.XtraCharts.SeriesPoint();
            //    w.Argument = dt_chart.Rows[i][0].ToString();
            //    double dd = double.Parse(dt_chart.Rows[i][1].ToString());
            //    d[0] = dd;

            //    w.Values = d;
            //    xrChart1.Series["Ряд 1"].Points.Add(w);
            //    //chartControl1.Series["Ряд 2"].Points.Add(w);
            //    //chartControl1.Series["Ряд 3"].Points.Add(w);
            //    //chartControl1.Series["Ряд 6"].Points.Add(w);
            //}
        }

        private void XtraReport1_DesignerLoaded(object sender, DevExpress.XtraReports.UserDesigner.DesignerLoadedEventArgs e)
        {
           
        }

    }
}
