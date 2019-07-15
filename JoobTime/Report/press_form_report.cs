using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace JoobTime
{
    public class press_form_report : DevExpress.XtraReports.UI.XtraReport
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
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.ReportFooterBand reportFooterBand1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        private DevExpress.XtraReports.UI.XRChart xrChart1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        //private _1.DB1DataSet dB1DataSet;
    
        public press_form_report()
        {
            InitializeComponent();
            //xrLabel5.Text = "Отчет о работе с формами c " + Convert.ToDateTime(JoobTime.forma_polzovatelya.de1_2).ToShortDateString() + " по " + Convert.ToDateTime(JoobTime.forma_polzovatelya.de2_2).ToShortDateString();
            xrLabel5.Text = "Отчет о проделанной работе с формами c " + Convert.ToDateTime(ReportGenerating.startDate).ToShortDateString() + " по " + Convert.ToDateTime(ReportGenerating.endDate).ToShortDateString() + "\n" + ReportGenerating.subunit_for_report + " " + ReportGenerating.fio_for_report; ;
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
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraCharts.SimpleDiagram simpleDiagram1 = new DevExpress.XtraCharts.SimpleDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesLabel pieSeriesLabel1 = new DevExpress.XtraCharts.PieSeriesLabel();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraCharts.KeyColorColorizer keyColorColorizer1 = new DevExpress.XtraCharts.KeyColorColorizer();
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            this.groupFooterBand1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportDetailBandStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.ReportOddStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.ReportFooterBandStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.pageHeaderBand1 = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.detailBand1 = new DevExpress.XtraReports.UI.DetailBand();
            this.ReportGroupHeaderBandStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.ReportHeaderBandStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.groupHeaderBand1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.ReportGroupFooterBandStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.ReportEvenStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.totalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportFooterBand1 = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrChart1 = new DevExpress.XtraReports.UI.XRChart();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.totalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrChart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // groupFooterBand1
            // 
            this.groupFooterBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel7,
            this.xrLabel2,
            this.xrLabel4});
            this.groupFooterBand1.Dpi = 254F;
            this.groupFooterBand1.HeightF = 62.81247F;
            this.groupFooterBand1.Name = "groupFooterBand1";
            this.groupFooterBand1.StyleName = "ReportGroupFooterBandStyle";
            // 
            // xrLabel7
            // 
            this.xrLabel7.AnchorHorizontal = DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left;
            this.xrLabel7.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top;
            this.xrLabel7.BackColor = System.Drawing.Color.Empty;
            this.xrLabel7.BorderColor = System.Drawing.Color.Black;
            this.xrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "name_form")});
            this.xrLabel7.Dpi = 254F;
            this.xrLabel7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(221.9238F, 0F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(1128.625F, 62.81246F);
            this.xrLabel7.StylePriority.UseBackColor = false;
            this.xrLabel7.StylePriority.UseBorderColor = false;
            this.xrLabel7.StylePriority.UseBorders = false;
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UsePadding = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "xrLabel4";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrLabel7.PrintOnPage += new DevExpress.XtraReports.UI.PrintOnPageEventHandler(this.xrLabel7_PrintOnPage);
            // 
            // xrLabel2
            // 
            this.xrLabel2.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.xrLabel2.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.xrLabel2.BackColor = System.Drawing.Color.White;
            this.xrLabel2.BorderColor = System.Drawing.Color.Black;
            this.xrLabel2.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel2.CanGrow = false;
            this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "form_id")});
            this.xrLabel2.Dpi = 254F;
            this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(0.0002018611F, 0F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(221.9236F, 62.81247F);
            this.xrLabel2.StylePriority.UseBackColor = false;
            this.xrLabel2.StylePriority.UseBorderColor = false;
            this.xrLabel2.StylePriority.UseBorders = false;
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UsePadding = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "xrLabel2";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrLabel2.WordWrap = false;
            // 
            // xrLabel4
            // 
            this.xrLabel4.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.xrLabel4.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.xrLabel4.BackColor = System.Drawing.Color.White;
            this.xrLabel4.BorderColor = System.Drawing.Color.Black;
            this.xrLabel4.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel4.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel4.CanGrow = false;
            this.xrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "time_span")});
            this.xrLabel4.Dpi = 254F;
            this.xrLabel4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(1350.549F, 1.458325F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(402.0969F, 61.35414F);
            this.xrLabel4.StylePriority.UseBackColor = false;
            this.xrLabel4.StylePriority.UseBorderColor = false;
            this.xrLabel4.StylePriority.UseBorderDashStyle = false;
            this.xrLabel4.StylePriority.UseBorders = false;
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseForeColor = false;
            this.xrLabel4.StylePriority.UsePadding = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            xrSummary1.FormatString = "{0:HH:mm}";
            xrSummary1.IgnoreNullValues = true;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel4.Summary = xrSummary1;
            this.xrLabel4.Text = "xrLabel4";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrLabel4.WordWrap = false;
            this.xrLabel4.SummaryGetResult += new DevExpress.XtraReports.UI.SummaryGetResultHandler(this.xrLabel4_SummaryGetResult);
            this.xrLabel4.SummaryReset += new System.EventHandler(this.xrLabel4_SummaryReset);
            this.xrLabel4.SummaryRowChanged += new System.EventHandler(this.xrLabel4_SummaryRowChanged);
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
            this.xrLabel1,
            this.xrLabel3});
            this.pageHeaderBand1.Dpi = 254F;
            this.pageHeaderBand1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.pageHeaderBand1.HeightF = 74.58331F;
            this.pageHeaderBand1.Name = "pageHeaderBand1";
            this.pageHeaderBand1.StyleName = "ReportHeaderBandStyle";
            this.pageHeaderBand1.StylePriority.UseFont = false;
            // 
            // xrLabel1
            // 
            this.xrLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(218)))), ((int)(((byte)(251)))));
            this.xrLabel1.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel1.Dpi = 254F;
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(1350.549F, 74.58331F);
            this.xrLabel1.StylePriority.UseBackColor = false;
            this.xrLabel1.StylePriority.UseBorders = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UsePadding = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "Технологическая оснастка";
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
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(1350.549F, 0F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(402.097F, 74.58331F);
            this.xrLabel3.StylePriority.UseBackColor = false;
            this.xrLabel3.StylePriority.UseBorders = false;
            this.xrLabel3.StylePriority.UsePadding = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "Время";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // detailBand1
            // 
            this.detailBand1.Dpi = 254F;
            this.detailBand1.EvenStyleName = "ReportEvenStyle";
            this.detailBand1.HeightF = 0F;
            this.detailBand1.Name = "detailBand1";
            this.detailBand1.OddStyleName = "ReportOddStyle";
            this.detailBand1.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("time_span", DevExpress.XtraReports.UI.XRColumnSortOrder.None)});
            this.detailBand1.StyleName = "ReportDetailBandStyle";
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
            this.xrChart1,
            this.xrLabel10,
            this.xrLabel6});
            this.reportFooterBand1.Dpi = 254F;
            this.reportFooterBand1.HeightF = 1730.587F;
            this.reportFooterBand1.Name = "reportFooterBand1";
            this.reportFooterBand1.StyleName = "ReportFooterBandStyle";
            this.reportFooterBand1.StylePriority.UseBackColor = false;
            this.reportFooterBand1.StylePriority.UseBorderColor = false;
            // 
            // xrChart1
            // 
            this.xrChart1.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.xrChart1.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom;
            this.xrChart1.AppearanceNameSerializable = "Nature Colors";
            this.xrChart1.AutoLayout = true;
            this.xrChart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xrChart1.BorderColor = System.Drawing.Color.Black;
            this.xrChart1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            simpleDiagram1.LabelsResolveOverlappingMinIndent = 5;
            this.xrChart1.Diagram = simpleDiagram1;
            this.xrChart1.Dpi = 254F;
            this.xrChart1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center;
            this.xrChart1.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside;
            this.xrChart1.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            this.xrChart1.Legend.Name = "Default Legend";
            this.xrChart1.LocationFloat = new DevExpress.Utils.PointFloat(3.00018F, 95.25003F);
            this.xrChart1.Name = "xrChart1";
            this.xrChart1.PaletteName = "Mixed";
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
            pieSeriesLabel1.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True;
            pieSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default;
            pieSeriesLabel1.TextPattern = "{A} {VP:0.00%}";
            series2.Label = pieSeriesLabel1;
            series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series2.LegendTextPattern = "{A}";
            series2.Name = "Ряд 2";
            pieSeriesView1.Border.Visibility = DevExpress.Utils.DefaultBoolean.False;
            pieSeriesView1.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Solid;
            pieSeriesView1.Rotation = 270;
            pieSeriesView1.SweepDirection = DevExpress.XtraCharts.PieSweepDirection.Clockwise;
            series2.View = pieSeriesView1;
            this.xrChart1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            this.xrChart1.SeriesTemplate.Colorizer = keyColorColorizer1;
            this.xrChart1.SizeF = new System.Drawing.SizeF(1809F, 1635.337F);
            // 
            // xrLabel10
            // 
            this.xrLabel10.BackColor = System.Drawing.Color.White;
            this.xrLabel10.BorderColor = System.Drawing.Color.Black;
            this.xrLabel10.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel10.Dpi = 254F;
            this.xrLabel10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(0.0002018611F, 0F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(1350.548F, 63.99998F);
            this.xrLabel10.StylePriority.UseBackColor = false;
            this.xrLabel10.StylePriority.UseBorderColor = false;
            this.xrLabel10.StylePriority.UseBorders = false;
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.StylePriority.UseTextAlignment = false;
            this.xrLabel10.Text = "Итого:";
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel6
            // 
            this.xrLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.xrLabel6.BorderColor = System.Drawing.Color.Red;
            this.xrLabel6.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel6.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "time_span")});
            this.xrLabel6.Dpi = 254F;
            this.xrLabel6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(1350.549F, 0F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(400.597F, 64F);
            this.xrLabel6.StylePriority.UseBackColor = false;
            this.xrLabel6.StylePriority.UseBorderColor = false;
            this.xrLabel6.StylePriority.UseBorderDashStyle = false;
            this.xrLabel6.StylePriority.UseBorders = false;
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseForeColor = false;
            this.xrLabel6.StylePriority.UsePadding = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            xrSummary2.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom;
            xrSummary2.IgnoreNullValues = true;
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrLabel6.Summary = xrSummary2;
            this.xrLabel6.Text = "xrLabel6";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrLabel6.WordWrap = false;
            this.xrLabel6.SummaryGetResult += new DevExpress.XtraReports.UI.SummaryGetResultHandler(this.xrLabel6_SummaryGetResult);
            this.xrLabel6.SummaryRowChanged += new System.EventHandler(this.xrLabel6_SummaryRowChanged);
            // 
            // press_form_report
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
            this.Version = "16.2";
            this.DataSourceRowChanged += new DevExpress.XtraReports.UI.DataSourceRowEventHandler(this.press_form_report_DataSourceRowChanged);
            ((System.ComponentModel.ISupportInitialize)(this.totalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrChart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        private void bottomMarginBand1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void press_form_report_DataSourceRowChanged(object sender, DevExpress.XtraReports.UI.DataSourceRowEventArgs e)
        {

        }

        private void xrLabel4_SummaryGetResult(object sender, DevExpress.XtraReports.UI.SummaryGetResultEventArgs e)
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

            double[] d = new double[1];
            DevExpress.XtraCharts.SeriesPoint w = new DevExpress.XtraCharts.SeriesPoint();
            w.Argument = String.IsNullOrEmpty(xrLabel2.Text)?"Прочее":xrLabel2.Text;
            double dd = double.Parse(strin_f);
            d[0] = dd;

            w.Values = d;
            xrChart1.Series["Ряд 2"].Points.Add(w);


            e.Handled = true;
        }

        private void xrLabel4_SummaryRowChanged(object sender, EventArgs e)
        {
            string w = System.Convert.ToString(GetCurrentColumnValue("time_span"));
            ts1 += System.TimeSpan.Parse(w);
        }

        private void xrLabel4_SummaryReset(object sender, EventArgs e)
        {
            ts1 = new System.TimeSpan(00, 00, 00);
        }

        private void xrLabel6_SummaryRowChanged(object sender, EventArgs e)
        {
            string w = System.Convert.ToString(GetCurrentColumnValue("time_span"));
            ts += System.TimeSpan.Parse(w);
        }

        private void xrLabel6_SummaryGetResult(object sender, DevExpress.XtraReports.UI.SummaryGetResultEventArgs e)
        {
            string strin_f = ts.TotalHours.ToString();//(0,2) + ":" + ts.Minutes.ToString();
            string itog;
            // e.TotalValue = strin_f;
            if (strin_f.Contains(",") == true)
            {
                int len = strin_f.IndexOf(',', 0);
                if (ts.Minutes.ToString().Length > 1)
                {
                    itog = strin_f.Substring(0, len) + ":" + ts.Minutes.ToString();
                    e.Result = itog;
                }
                else
                {
                    itog = strin_f.Substring(0, len) + ":0" + ts.Minutes.ToString();
                    e.Result = itog;
                }
            }
            else
            {
                if (ts.Minutes.ToString().Length > 1)
                {
                    itog = strin_f + ":" + ts.Minutes.ToString();
                    e.Result = itog;
                }
                else
                {
                    itog = strin_f + ":0" + ts.Minutes.ToString();
                    e.Result = itog;
                }
            }
            e.Handled = true;
        }

        private void xrLabel7_PrintOnPage(object sender, DevExpress.XtraReports.UI.PrintOnPageEventArgs e)
        {
            if (xrLabel7.Text == "" || xrLabel7.Text == null)
            {
                xrLabel7.Text = "Прочее";
            }
        }
    }
}
