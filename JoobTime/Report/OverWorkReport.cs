using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using System.Data;

namespace JoobTime
{
    public class OverWork_report : DevExpress.XtraReports.UI.XtraReport
    {

        public System.TimeSpan ts;
        public System.TimeSpan ts1;

        private DevExpress.XtraReports.UI.GroupFooterBand groupFooterBand1;
        private DevExpress.XtraReports.UI.XRControlStyle ReportDetailBandStyle;
        private DevExpress.XtraReports.UI.XRControlStyle ReportOddStyle;
        private DevExpress.XtraReports.UI.XRControlStyle ReportFooterBandStyle;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.PageHeaderBand pageHeaderBand1;
        private DevExpress.XtraReports.UI.DetailBand detailBand1;
        private DevExpress.XtraReports.UI.XRControlStyle ReportGroupHeaderBandStyle;
        private DevExpress.XtraReports.UI.XRControlStyle ReportHeaderBandStyle;
        private DevExpress.XtraReports.UI.GroupHeaderBand groupHeaderBand1;
        private DevExpress.XtraReports.UI.XRControlStyle ReportGroupFooterBandStyle;
        private DevExpress.XtraReports.UI.XRControlStyle ReportEvenStyle;
        //private _1.DB1DataSetTableAdapters.totalTableAdapter totalTableAdapter;
        private System.Windows.Forms.BindingSource totalBindingSource;
        private System.ComponentModel.IContainer components;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.ReportFooterBand reportFooterBand1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRChart xrChart1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel12;
        private DevExpress.XtraReports.UI.XRLabel FIOLabel;
        private DevExpress.XtraReports.UI.XRLabel TotalTime;
        private DevExpress.XtraReports.UI.XRLabel NeedTime;
        private DevExpress.XtraReports.UI.XRLabel SubTime;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        //private _1.DB1DataSet dB1DataSet;

        public OverWork_report()
        {
            InitializeComponent();
            //xrLabel5.Text = "Отчет о работе с формами c " + Convert.ToDateTime(JoobTime.forma_polzovatelya.de1_2).ToShortDateString() + " по " + Convert.ToDateTime(JoobTime.forma_polzovatelya.de2_2).ToShortDateString();
            xrLabel5.Text = "Сводная таблица по времени затраченному на выполнение работ";
            //Palette p;
            //string colors = Application.StartupPath + @"\colors.xcp";
            //using (StreamReader stream = new StreamReader(colors))
            //{
            //    string name = Path.GetFileNameWithoutExtension(colors);
            //    p = new Palette(name);
            //    p.LoadFromXml(stream.BaseStream);
            //}
            //xrChart1.PaletteRepository.Add(p.Name, p);
            //xrChart1.PaletteName = p.Name;
           // xrLabel13.Text = System.DateTime.Now.ToShortDateString();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel2 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel3 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.KeyColorColorizer keyColorColorizer1 = new DevExpress.XtraCharts.KeyColorColorizer();
            this.groupFooterBand1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.ReportDetailBandStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.ReportOddStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.ReportFooterBandStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.pageHeaderBand1 = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.detailBand1 = new DevExpress.XtraReports.UI.DetailBand();
            this.FIOLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.TotalTime = new DevExpress.XtraReports.UI.XRLabel();
            this.NeedTime = new DevExpress.XtraReports.UI.XRLabel();
            this.SubTime = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportGroupHeaderBandStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.ReportHeaderBandStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.groupHeaderBand1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.ReportGroupFooterBandStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.ReportEvenStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.totalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportFooterBand1 = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrChart1 = new DevExpress.XtraReports.UI.XRChart();
            ((System.ComponentModel.ISupportInitialize)(this.totalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrChart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // groupFooterBand1
            // 
            this.groupFooterBand1.Dpi = 254F;
            this.groupFooterBand1.HeightF = 0F;
            this.groupFooterBand1.Name = "groupFooterBand1";
            this.groupFooterBand1.StyleName = "ReportGroupFooterBandStyle";
            // 
            // ReportDetailBandStyle
            // 
            this.ReportDetailBandStyle.BackColor = System.Drawing.Color.Transparent;
            this.ReportDetailBandStyle.Name = "ReportDetailBandStyle";
            this.ReportDetailBandStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 254F);
            this.ReportDetailBandStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // ReportOddStyle
            // 
            this.ReportOddStyle.BackColor = System.Drawing.Color.Transparent;
            this.ReportOddStyle.Name = "ReportOddStyle";
            this.ReportOddStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 254F);
            this.ReportOddStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // ReportFooterBandStyle
            // 
            this.ReportFooterBandStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ReportFooterBandStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.ReportFooterBandStyle.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.ReportFooterBandStyle.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold);
            this.ReportFooterBandStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ReportFooterBandStyle.Name = "ReportFooterBandStyle";
            this.ReportFooterBandStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 254F);
            this.ReportFooterBandStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.Dpi = 254F;
            this.bottomMarginBand1.HeightF = 254F;
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            this.bottomMarginBand1.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.bottomMarginBand1_BeforePrint);
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel5});
            this.topMarginBand1.Dpi = 254F;
            this.topMarginBand1.HeightF = 326.4375F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // xrLabel5
            // 
            this.xrLabel5.CanGrow = false;
            this.xrLabel5.Dpi = 254F;
            this.xrLabel5.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 190.2292F);
            this.xrLabel5.Multiline = true;
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(1812F, 136.2083F);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "Отчет о работе с формами c ";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // pageHeaderBand1
            // 
            this.pageHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel12,
            this.xrLabel7,
            this.xrLabel1,
            this.xrLabel3});
            this.pageHeaderBand1.Dpi = 254F;
            this.pageHeaderBand1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.pageHeaderBand1.HeightF = 160.7083F;
            this.pageHeaderBand1.Name = "pageHeaderBand1";
            this.pageHeaderBand1.StyleName = "ReportHeaderBandStyle";
            this.pageHeaderBand1.StylePriority.UseFont = false;
            // 
            // xrLabel12
            // 
            this.xrLabel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(218)))), ((int)(((byte)(251)))));
            this.xrLabel12.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel12.Dpi = 254F;
            this.xrLabel12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(878.7346F, 0F);
            this.xrLabel12.Multiline = true;
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(356.861F, 160.7083F);
            this.xrLabel12.StylePriority.UseBackColor = false;
            this.xrLabel12.StylePriority.UseBorders = false;
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.StylePriority.UsePadding = false;
            this.xrLabel12.StylePriority.UseTextAlignment = false;
            this.xrLabel12.Text = "Количество\r\nрабочих часов по\r\nтабелю, ч.";
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrLabel12.WordWrap = false;
            // 
            // xrLabel7
            // 
            this.xrLabel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(218)))), ((int)(((byte)(251)))));
            this.xrLabel7.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel7.Dpi = 254F;
            this.xrLabel7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(516.5819F, 0F);
            this.xrLabel7.Multiline = true;
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(362.1527F, 160.7083F);
            this.xrLabel7.StylePriority.UseBackColor = false;
            this.xrLabel7.StylePriority.UseBorders = false;
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UsePadding = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "Фактически \r\nотработано за\r\n месяц, ч.";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrLabel7.WordWrap = false;
            // 
            // xrLabel1
            // 
            this.xrLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(218)))), ((int)(((byte)(251)))));
            this.xrLabel1.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel1.Dpi = 254F;
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(154.429F, 0F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(362.153F, 160.7083F);
            this.xrLabel1.StylePriority.UseBackColor = false;
            this.xrLabel1.StylePriority.UseBorders = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UsePadding = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "Ф.И.О \r\nсотрудника";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrLabel1.WordWrap = false;
            // 
            // xrLabel3
            // 
            this.xrLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(218)))), ((int)(((byte)(251)))));
            this.xrLabel3.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel3.Dpi = 254F;
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(1235.596F, 0F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(402.0969F, 160.7083F);
            this.xrLabel3.StylePriority.UseBackColor = false;
            this.xrLabel3.StylePriority.UseBorders = false;
            this.xrLabel3.StylePriority.UsePadding = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "Разница, ч.";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // detailBand1
            // 
            this.detailBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.FIOLabel,
            this.TotalTime,
            this.NeedTime,
            this.SubTime});
            this.detailBand1.Dpi = 254F;
            this.detailBand1.EvenStyleName = "ReportEvenStyle";
            this.detailBand1.HeightF = 64.27082F;
            this.detailBand1.Name = "detailBand1";
            this.detailBand1.OddStyleName = "ReportOddStyle";
            this.detailBand1.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("time_span", DevExpress.XtraReports.UI.XRColumnSortOrder.None)});
            this.detailBand1.StyleName = "ReportDetailBandStyle";
            // 
            // FIOLabel
            // 
            this.FIOLabel.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.FIOLabel.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.FIOLabel.BackColor = System.Drawing.Color.White;
            this.FIOLabel.BorderColor = System.Drawing.Color.Black;
            this.FIOLabel.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.FIOLabel.CanGrow = false;
            this.FIOLabel.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "FIO")});
            this.FIOLabel.Dpi = 254F;
            this.FIOLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIOLabel.LocationFloat = new DevExpress.Utils.PointFloat(154.429F, 0F);
            this.FIOLabel.Name = "FIOLabel";
            this.FIOLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.FIOLabel.SizeF = new System.Drawing.SizeF(362.1527F, 64.27082F);
            this.FIOLabel.StylePriority.UseBackColor = false;
            this.FIOLabel.StylePriority.UseBorderColor = false;
            this.FIOLabel.StylePriority.UseBorders = false;
            this.FIOLabel.StylePriority.UseFont = false;
            this.FIOLabel.StylePriority.UsePadding = false;
            this.FIOLabel.StylePriority.UseTextAlignment = false;
            this.FIOLabel.Text = "FIOLabel";
            this.FIOLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.FIOLabel.WordWrap = false;
            // 
            // TotalTime
            // 
            this.TotalTime.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.TotalTime.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.TotalTime.BackColor = System.Drawing.Color.White;
            this.TotalTime.BorderColor = System.Drawing.Color.Black;
            this.TotalTime.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.TotalTime.CanGrow = false;
            this.TotalTime.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "TotalTime")});
            this.TotalTime.Dpi = 254F;
            this.TotalTime.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalTime.LocationFloat = new DevExpress.Utils.PointFloat(516.5821F, 0F);
            this.TotalTime.Name = "TotalTime";
            this.TotalTime.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.TotalTime.SizeF = new System.Drawing.SizeF(362.1527F, 64.27082F);
            this.TotalTime.StylePriority.UseBackColor = false;
            this.TotalTime.StylePriority.UseBorderColor = false;
            this.TotalTime.StylePriority.UseBorders = false;
            this.TotalTime.StylePriority.UseFont = false;
            this.TotalTime.StylePriority.UsePadding = false;
            this.TotalTime.StylePriority.UseTextAlignment = false;
            this.TotalTime.Text = "xrLabel2";
            this.TotalTime.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.TotalTime.WordWrap = false;
            // 
            // NeedTime
            // 
            this.NeedTime.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.NeedTime.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.NeedTime.BackColor = System.Drawing.Color.White;
            this.NeedTime.BorderColor = System.Drawing.Color.Black;
            this.NeedTime.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.NeedTime.CanGrow = false;
            this.NeedTime.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "ttime")});
            this.NeedTime.Dpi = 254F;
            this.NeedTime.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NeedTime.LocationFloat = new DevExpress.Utils.PointFloat(878.7352F, 0F);
            this.NeedTime.Name = "NeedTime";
            this.NeedTime.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.NeedTime.SizeF = new System.Drawing.SizeF(356.8608F, 64.27082F);
            this.NeedTime.StylePriority.UseBackColor = false;
            this.NeedTime.StylePriority.UseBorderColor = false;
            this.NeedTime.StylePriority.UseBorders = false;
            this.NeedTime.StylePriority.UseFont = false;
            this.NeedTime.StylePriority.UsePadding = false;
            this.NeedTime.StylePriority.UseTextAlignment = false;
            this.NeedTime.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.NeedTime.WordWrap = false;
            // 
            // SubTime
            // 
            this.SubTime.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.SubTime.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.SubTime.BackColor = System.Drawing.Color.White;
            this.SubTime.BorderColor = System.Drawing.Color.Black;
            this.SubTime.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.SubTime.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.SubTime.CanGrow = false;
            this.SubTime.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SubTime")});
            this.SubTime.Dpi = 254F;
            this.SubTime.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SubTime.LocationFloat = new DevExpress.Utils.PointFloat(1235.596F, 0F);
            this.SubTime.Name = "SubTime";
            this.SubTime.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.SubTime.SizeF = new System.Drawing.SizeF(402.0969F, 64.27082F);
            this.SubTime.StylePriority.UseBackColor = false;
            this.SubTime.StylePriority.UseBorderColor = false;
            this.SubTime.StylePriority.UseBorderDashStyle = false;
            this.SubTime.StylePriority.UseBorders = false;
            this.SubTime.StylePriority.UseFont = false;
            this.SubTime.StylePriority.UseForeColor = false;
            this.SubTime.StylePriority.UsePadding = false;
            this.SubTime.StylePriority.UseTextAlignment = false;
            this.SubTime.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.SubTime.WordWrap = false;
            // 
            // ReportGroupHeaderBandStyle
            // 
            this.ReportGroupHeaderBandStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.ReportGroupHeaderBandStyle.Name = "ReportGroupHeaderBandStyle";
            this.ReportGroupHeaderBandStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 0, 0, 0, 254F);
            this.ReportGroupHeaderBandStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // ReportHeaderBandStyle
            // 
            this.ReportHeaderBandStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.ReportHeaderBandStyle.Name = "ReportHeaderBandStyle";
            this.ReportHeaderBandStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 254F);
            this.ReportHeaderBandStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // groupHeaderBand1
            // 
            this.groupHeaderBand1.Dpi = 254F;
            this.groupHeaderBand1.Expanded = false;
            this.groupHeaderBand1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("form_id", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.groupHeaderBand1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.groupHeaderBand1.HeightF = 0F;
            this.groupHeaderBand1.Name = "groupHeaderBand1";
            this.groupHeaderBand1.StyleName = "ReportGroupHeaderBandStyle";
            // 
            // ReportGroupFooterBandStyle
            // 
            this.ReportGroupFooterBandStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ReportGroupFooterBandStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.ReportGroupFooterBandStyle.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.ReportGroupFooterBandStyle.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold);
            this.ReportGroupFooterBandStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ReportGroupFooterBandStyle.Name = "ReportGroupFooterBandStyle";
            this.ReportGroupFooterBandStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 254F);
            this.ReportGroupFooterBandStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // ReportEvenStyle
            // 
            this.ReportEvenStyle.BackColor = System.Drawing.Color.Transparent;
            this.ReportEvenStyle.Name = "ReportEvenStyle";
            this.ReportEvenStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 254F);
            this.ReportEvenStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // totalBindingSource
            // 
            this.totalBindingSource.DataMember = "total";
            // 
            // reportFooterBand1
            // 
            this.reportFooterBand1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.reportFooterBand1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.reportFooterBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrChart1});
            this.reportFooterBand1.Dpi = 254F;
            this.reportFooterBand1.HeightF = 1106.17F;
            this.reportFooterBand1.Name = "reportFooterBand1";
            this.reportFooterBand1.StyleName = "ReportFooterBandStyle";
            this.reportFooterBand1.StylePriority.UseBackColor = false;
            this.reportFooterBand1.StylePriority.UseBorderColor = false;
            // 
            // xrChart1
            // 
            this.xrChart1.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.xrChart1.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom;
            this.xrChart1.AppearanceNameSerializable = "Chameleon";
            this.xrChart1.AutoLayout = true;
            this.xrChart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xrChart1.BorderColor = System.Drawing.Color.Black;
            this.xrChart1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            xyDiagram1.AxisX.MinorCount = 2;
            xyDiagram1.AxisX.Title.MaxLineCount = 1;
            xyDiagram1.AxisX.Title.Text = "ФИО";
            xyDiagram1.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisX.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Title.Text = "Часы";
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.DefaultPane.EnableAxisXScrolling = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram1.DefaultPane.EnableAxisXZooming = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram1.DefaultPane.EnableAxisYScrolling = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram1.DefaultPane.EnableAxisYZooming = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram1.LabelsResolveOverlappingMinIndent = 5;
            this.xrChart1.Diagram = xyDiagram1;
            this.xrChart1.Dpi = 254F;
            this.xrChart1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center;
            this.xrChart1.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside;
            this.xrChart1.Legend.Name = "Default Legend";
            this.xrChart1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.xrChart1.LocationFloat = new DevExpress.Utils.PointFloat(3.00014F, 0F);
            this.xrChart1.Name = "xrChart1";
            this.xrChart1.PaletteName = "Chameleon";
            sideBySideBarSeriesLabel1.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True;
            sideBySideBarSeriesLabel1.Position = DevExpress.XtraCharts.BarSeriesLabelPosition.BottomInside;
            series1.Label = sideBySideBarSeriesLabel1;
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            series1.LegendTextPattern = "{A}";
            series1.Name = "Ряд 1";
            sideBySideBarSeriesView1.BarWidth = 0.5D;
            sideBySideBarSeriesView1.Border.Visibility = DevExpress.Utils.DefaultBoolean.True;
            sideBySideBarSeriesView1.ColorEach = true;
            sideBySideBarSeriesView1.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Hatch;
            series1.View = sideBySideBarSeriesView1;
            series1.Visible = false;
            sideBySideBarSeriesLabel2.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True;
            sideBySideBarSeriesLabel2.LineVisibility = DevExpress.Utils.DefaultBoolean.False;
            sideBySideBarSeriesLabel2.Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top;
            sideBySideBarSeriesLabel2.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default;
            sideBySideBarSeriesLabel2.TextPattern = "{HINT}";
            series2.Label = sideBySideBarSeriesLabel2;
            series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series2.LegendTextPattern = "{A}";
            series2.Name = "Фактически отработано за месяц, ч";
            sideBySideBarSeriesLabel3.Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top;
            sideBySideBarSeriesLabel3.TextPattern = "{HINT}";
            series3.Label = sideBySideBarSeriesLabel3;
            series3.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series3.Name = "Количество рабочих часов по табелю, ч.";
            this.xrChart1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2,
        series3};
            this.xrChart1.SeriesTemplate.Colorizer = keyColorColorizer1;
            this.xrChart1.SizeF = new System.Drawing.SizeF(1809F, 1092.941F);
            // 
            // OverWork_report
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.pageHeaderBand1,
            this.groupHeaderBand1,
            this.detailBand1,
            this.groupFooterBand1,
            this.reportFooterBand1,
            this.bottomMarginBand1});
            this.Dpi = 254F;
            this.Margins = new System.Drawing.Printing.Margins(201, 87, 326, 254);
            this.PageHeight = 2970;
            this.PageWidth = 2100;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter;
            this.SnapGridSize = 25F;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.ReportHeaderBandStyle,
            this.ReportGroupHeaderBandStyle,
            this.ReportDetailBandStyle,
            this.ReportGroupFooterBandStyle,
            this.ReportFooterBandStyle,
            this.ReportOddStyle,
            this.ReportEvenStyle});
            this.Version = "18.1";
            this.DataSourceRowChanged += new DevExpress.XtraReports.UI.DataSourceRowEventHandler(this.press_form_report_DataSourceRowChanged);
            ((System.ComponentModel.ISupportInitialize)(this.totalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrChart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        private void bottomMarginBand1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void press_form_report_DataSourceRowChanged(object sender, DevExpress.XtraReports.UI.DataSourceRowEventArgs e)
        {

        }

        public void FillChart(DataTable dTable)
        {
            foreach (DataRow row in dTable.Rows)
            {
                string argument = row["FIO"].ToString();
                double need = Convert.ToDouble(row["NeedTimeMinute"]);
                double total = Convert.ToDouble(row["Total_Time"]);
                double[] value1= new double[1];
                double[] value2= new double[1];
                SeriesPoint w1 = new SeriesPoint();
                w1.Argument = argument;
                value1[0] = Math.Round(total/60,2);
                w1.Values = value1;
                w1.ToolTipHint = row["TotalTime"].ToString();
                //xrChart1.Series[1].Points.Add(new SeriesPoint(argument,value1));
                xrChart1.Series[1].Points.Add(w1);
                SeriesPoint w2 = new SeriesPoint();
                w2.Argument = argument;
                value2[0] =  Math.Round(need / 60,2);
                w2.Values = value2;
                w2.ToolTipHint = row["ttime"].ToString();
                //xrChart1.Series[2].Points.Add(new SeriesPoint(argument, value2));
                xrChart1.Series[2].Points.Add(w2);
            }
        }
        private void xrLabel4_SummaryGetResult(object sender, DevExpress.XtraReports.UI.SummaryGetResultEventArgs e)
        {
            string strin_f = ts1.TotalHours.ToString();//(0,2) + ":" + ts.Minutes.ToString();
            string itog;
            if (strin_f.Contains(",") == true)
            {
                int len = strin_f.IndexOf(',', 0);
                if (ts1.Minutes.ToString().Length > 1)
                {
                    itog = strin_f.Substring(0, len) + ":" + ts1.Minutes.ToString();
                }
                else
                {
                    itog = strin_f.Substring(0, len) + ":0" + ts1.Minutes.ToString();
                }
            }
            else
            {
                if (ts1.Minutes.ToString().Length > 1)
                {
                    itog = strin_f + ":" + ts1.Minutes.ToString();
                }
                else
                {
                    itog = strin_f + ":0" + ts1.Minutes.ToString();
                }
            }

            double[] d = new double[1];
            SeriesPoint w = new SeriesPoint();
            w.Argument = FIOLabel.Text;
            double dd = double.Parse(strin_f);
            d[0] = dd;

            w.Values = d;
            xrChart1.Series["Ряд 2"].Points.Add(new SeriesPoint());


            e.Handled = true;
        }

        private void xrLabel4_SummaryRowChanged(object sender, EventArgs e)
        {
            int minutes = System.Convert.ToInt32(GetCurrentColumnValue("Total_Time"));
            ts1 += System.TimeSpan.FromMinutes(minutes);
        }

        private void xrLabel4_SummaryReset(object sender, EventArgs e)
        {
            ts1 = new System.TimeSpan(00, 00, 00);
        }

        private TimeSpan ts2;
        private void NeedTime_SummaryRowChanged(object sender, EventArgs e)
        {
            int minutes = System.Convert.ToInt32(GetCurrentColumnValue("NeedTimeMinute"));
            ts2 += System.TimeSpan.FromMinutes(minutes);
        }

        private void NeedTime_SummaryGetResult(object sender, DevExpress.XtraReports.UI.SummaryGetResultEventArgs e)
        {
            string strin_f = ts2.TotalHours.ToString();//(0,2) + ":" + ts.Minutes.ToString();
            string itog;
            if (strin_f.Contains(",") == true)
            {
                int len = strin_f.IndexOf(',', 0);
                if (ts2.Minutes.ToString().Length > 1)
                {
                    itog = strin_f.Substring(0, len) + ":" + ts2.Minutes.ToString();
                }
                else
                {
                    itog = strin_f.Substring(0, len) + ":0" + ts2.Minutes.ToString();
                }
            }
            else
            {
                if (ts2.Minutes.ToString().Length > 1)
                {
                    itog = strin_f + ":" + ts2.Minutes.ToString();
                }
                else
                {
                    itog = strin_f + ":0" + ts2.Minutes.ToString();
                }
            }

            double[] d = new double[1];
            SeriesPoint w = new SeriesPoint();
            w.Argument = FIOLabel.Text;
            double dd = double.Parse(strin_f);
            d[0] = dd;
            w.Values = d;
            w.ToolTipHint = ts.ToString("HH:mm");
            xrChart1.Series["Ряд 3"].Points.Add(w);


            e.Handled = true;
        }

        private void NeedTime_SummaryReset(object sender, EventArgs e)
        {
            ts2 = new System.TimeSpan(00, 00, 00);
        }

    }
}
