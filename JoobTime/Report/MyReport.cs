using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoobTime
{
    public class MyReport : DevExpress.XtraReports.UI.XtraReport
    {
        public System.TimeSpan ts;

        private DevExpress.XtraReports.UI.XRControlStyle ReportDetailBandStyle;
        private DevExpress.XtraReports.UI.XRTableRow tableRow3;
        private DevExpress.XtraReports.UI.XRTableCell tableCell20;
        private DevExpress.XtraReports.UI.DetailBand detailBand1;
        private DevExpress.XtraReports.UI.XRControlStyle ReportEvenStyle;
        private DevExpress.XtraReports.UI.XRControlStyle ReportGroupFooterBandStyle;
        private DevExpress.XtraReports.UI.XRControlStyle ReportGroupHeaderBandStyle;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private DevExpress.XtraReports.UI.XRControlStyle ReportFooterBandStyle;
        private DevExpress.XtraReports.UI.XRTable table3;
        private DevExpress.XtraReports.UI.ReportFooterBand reportFooterBand1;
        private DevExpress.XtraReports.UI.XRControlStyle ReportHeaderBandStyle;
        private DevExpress.XtraReports.UI.PageHeaderBand pageHeaderBand1;
        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.XRControlStyle ReportOddStyle;
        //private _1.DB1DataSetTableAdapters.totalTableAdapter totalTableAdapter;
        private System.Windows.Forms.BindingSource totalBindingSource;
        //private _1.DB1DataSet dB1DataSet;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel11;
        private DevExpress.XtraReports.UI.XRLabel xrLabel12;
        private DevExpress.XtraReports.UI.XRLabel xrLabel13;
        private DevExpress.XtraReports.UI.XRLabel xrLabel15;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        private DevExpress.XtraReports.UI.FormattingRule formattingRule1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel17;
        private DevExpress.XtraReports.UI.XRLabel xrLabel18;
        private DevExpress.XtraReports.UI.XRLabel xrLabel19;
        private DevExpress.XtraReports.UI.XRLabel xrLabel20;
        private DevExpress.XtraReports.UI.XRLabel xrLabel14;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel21;
        private DevExpress.XtraReports.UI.XRLabel xrLabel16;
        private DevExpress.XtraReports.UI.XRLabel xrLabel22;
        private System.ComponentModel.IContainer components;
    
        public MyReport()
        {
            InitializeComponent();
            xrLabel11.Text = "Отчет о проделанной работе c " + Convert.ToDateTime(ReportGenerating.startDate).ToShortDateString() + " по " + Convert.ToDateTime(ReportGenerating.endDate).ToShortDateString() + "\n" + ReportGenerating.startDate + " " + ReportGenerating.fio_for_report; ;
           
            //xrLabel22.Text = Convert.ToDateTime(JoobTime.forma_polzovatelya.de1_2).ToShortDateString();
            //xrLabel24.Text = Convert.ToDateTime(JoobTime.forma_polzovatelya.de2_2).ToShortDateString();
            xrLabel8.Text = System.DateTime.Now.ToShortDateString();

        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            this.ReportDetailBandStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.tableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
            this.detailBand1 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportEvenStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.ReportGroupFooterBandStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.ReportGroupHeaderBandStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportFooterBandStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.table3 = new DevExpress.XtraReports.UI.XRTable();
            this.reportFooterBand1 = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportHeaderBandStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.pageHeaderBand1 = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportOddStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.totalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formattingRule1 = new DevExpress.XtraReports.UI.FormattingRule();
            ((System.ComponentModel.ISupportInitialize)(this.table3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // ReportDetailBandStyle
            // 
            this.ReportDetailBandStyle.BackColor = System.Drawing.Color.Transparent;
            this.ReportDetailBandStyle.Name = "ReportDetailBandStyle";
            this.ReportDetailBandStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 0, 254F);
            this.ReportDetailBandStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // tableRow3
            // 
            this.tableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell20});
            this.tableRow3.Dpi = 254F;
            this.tableRow3.Name = "tableRow3";
            this.tableRow3.Weight = 10.46953028649871D;
            // 
            // tableCell20
            // 
            this.tableCell20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tableCell20.BorderColor = System.Drawing.Color.Red;
            this.tableCell20.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tableCell20.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "time_span")});
            this.tableCell20.Dpi = 254F;
            this.tableCell20.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.tableCell20.Name = "tableCell20";
            this.tableCell20.Padding = new DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 0, 254F);
            this.tableCell20.StylePriority.UseBackColor = false;
            this.tableCell20.StylePriority.UseBorderColor = false;
            this.tableCell20.StylePriority.UseBorders = false;
            this.tableCell20.StylePriority.UseFont = false;
            this.tableCell20.StylePriority.UseTextAlignment = false;
            xrSummary1.FormatString = "{0:HH:mm}";
            xrSummary1.IgnoreNullValues = true;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.tableCell20.Summary = xrSummary1;
            this.tableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.tableCell20.Weight = 0.15360041950618522D;
            this.tableCell20.WordWrap = false;
            this.tableCell20.SummaryGetResult += new DevExpress.XtraReports.UI.SummaryGetResultHandler(this.tableCell20_SummaryGetResult);
            this.tableCell20.SummaryRowChanged += new System.EventHandler(this.tableCell20_SummaryRowChanged);
            this.tableCell20.TextChanged += new System.EventHandler(this.tableCell20_TextChanged);
            // 
            // detailBand1
            // 
            this.detailBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel22,
            this.xrLabel17,
            this.xrLabel18,
            this.xrLabel19,
            this.xrLabel20,
            this.xrLabel13,
            this.xrLabel15,
            this.xrLabel14});
            this.detailBand1.Dpi = 254F;
            this.detailBand1.EvenStyleName = "ReportEvenStyle";
            this.detailBand1.HeightF = 97.2083F;
            this.detailBand1.KeepTogether = true;
            this.detailBand1.Name = "detailBand1";
            this.detailBand1.OddStyleName = "ReportOddStyle";
            this.detailBand1.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.detailBand1.StyleName = "ReportDetailBandStyle";
            // 
            // xrLabel22
            // 
            this.xrLabel22.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top;
            this.xrLabel22.BackColor = System.Drawing.Color.White;
            this.xrLabel22.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel22.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "name_form")});
            this.xrLabel22.Dpi = 254F;
            this.xrLabel22.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(484.0061F, 0F);
            this.xrLabel22.Multiline = true;
            this.xrLabel22.Name = "xrLabel22";
            this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel22.SizeF = new System.Drawing.SizeF(537.791F, 97.2083F);
            this.xrLabel22.StylePriority.UseBackColor = false;
            this.xrLabel22.StylePriority.UseBorders = false;
            this.xrLabel22.StylePriority.UseFont = false;
            this.xrLabel22.StylePriority.UsePadding = false;
            this.xrLabel22.StylePriority.UseTextAlignment = false;
            this.xrLabel22.Text = "xrLabel4";
            this.xrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel17
            // 
            this.xrLabel17.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.xrLabel17.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.xrLabel17.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel17.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel17.CanGrow = false;
            this.xrLabel17.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "time_begin", "{0:t}")});
            this.xrLabel17.Dpi = 254F;
            this.xrLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(1489.27F, 0F);
            this.xrLabel17.Multiline = true;
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(206.325F, 97.2083F);
            this.xrLabel17.StylePriority.UseBackColor = false;
            this.xrLabel17.StylePriority.UseBorders = false;
            this.xrLabel17.StylePriority.UseForeColor = false;
            this.xrLabel17.StylePriority.UsePadding = false;
            this.xrLabel17.StylePriority.UseTextAlignment = false;
            this.xrLabel17.Text = "xrLabel17";
            this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrLabel17.WordWrap = false;
            // 
            // xrLabel18
            // 
            this.xrLabel18.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.xrLabel18.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.xrLabel18.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel18.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel18.CanGrow = false;
            this.xrLabel18.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "time_end", "{0:t}")});
            this.xrLabel18.Dpi = 254F;
            this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(1695.595F, 0F);
            this.xrLabel18.Name = "xrLabel18";
            this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel18.SizeF = new System.Drawing.SizeF(227.4923F, 97.2083F);
            this.xrLabel18.StylePriority.UseBackColor = false;
            this.xrLabel18.StylePriority.UseBorders = false;
            this.xrLabel18.StylePriority.UsePadding = false;
            this.xrLabel18.StylePriority.UseTextAlignment = false;
            this.xrLabel18.Text = "xrLabel18";
            this.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrLabel18.WordWrap = false;
            // 
            // xrLabel19
            // 
            this.xrLabel19.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.xrLabel19.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.xrLabel19.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel19.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel19.CanGrow = false;
            this.xrLabel19.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "time_span")});
            this.xrLabel19.Dpi = 254F;
            this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(1923.088F, 0F);
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel19.SizeF = new System.Drawing.SizeF(214.2623F, 97.2083F);
            this.xrLabel19.StylePriority.UseBackColor = false;
            this.xrLabel19.StylePriority.UseBorders = false;
            this.xrLabel19.StylePriority.UsePadding = false;
            this.xrLabel19.StylePriority.UseTextAlignment = false;
            this.xrLabel19.Text = "xrLabel19";
            this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrLabel19.WordWrap = false;
            // 
            // xrLabel20
            // 
            this.xrLabel20.AnchorHorizontal = DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left;
            this.xrLabel20.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.xrLabel20.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel20.BorderColor = System.Drawing.Color.Black;
            this.xrLabel20.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel20.CanGrow = false;
            this.xrLabel20.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "other")});
            this.xrLabel20.Dpi = 254F;
            this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(2137.35F, 0F);
            this.xrLabel20.Name = "xrLabel20";
            this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel20.SizeF = new System.Drawing.SizeF(666.6499F, 97.2083F);
            this.xrLabel20.StylePriority.UseBackColor = false;
            this.xrLabel20.StylePriority.UseBorderColor = false;
            this.xrLabel20.StylePriority.UseBorders = false;
            this.xrLabel20.StylePriority.UsePadding = false;
            this.xrLabel20.StylePriority.UseTextAlignment = false;
            this.xrLabel20.Text = "xrLabel20";
            this.xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel13
            // 
            this.xrLabel13.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.xrLabel13.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.xrLabel13.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel13.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel13.CanGrow = false;
            this.xrLabel13.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "date", "{0:d}")});
            this.xrLabel13.Dpi = 254F;
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(190.3185F, 97.2083F);
            this.xrLabel13.StylePriority.UseBackColor = false;
            this.xrLabel13.StylePriority.UseBorders = false;
            this.xrLabel13.StylePriority.UsePadding = false;
            this.xrLabel13.StylePriority.UseTextAlignment = false;
            this.xrLabel13.Text = "xrLabel13";
            this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrLabel13.WordWrap = false;
            // 
            // xrLabel15
            // 
            this.xrLabel15.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.xrLabel15.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.xrLabel15.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel15.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel15.CanGrow = false;
            this.xrLabel15.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "work")});
            this.xrLabel15.Dpi = 254F;
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(1021.797F, 0F);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(467.4733F, 97.2083F);
            this.xrLabel15.StylePriority.UseBackColor = false;
            this.xrLabel15.StylePriority.UseBorders = false;
            this.xrLabel15.StylePriority.UsePadding = false;
            this.xrLabel15.StylePriority.UseTextAlignment = false;
            this.xrLabel15.Text = "xrLabel15";
            this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel14
            // 
            this.xrLabel14.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.xrLabel14.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.xrLabel14.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel14.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel14.CanGrow = false;
            this.xrLabel14.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "form_id")});
            this.xrLabel14.Dpi = 254F;
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(190.3185F, 0F);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(293.6876F, 97.20822F);
            this.xrLabel14.StylePriority.UseBackColor = false;
            this.xrLabel14.StylePriority.UseBorders = false;
            this.xrLabel14.StylePriority.UsePadding = false;
            this.xrLabel14.StylePriority.UseTextAlignment = false;
            this.xrLabel14.Text = "xrLabel3";
            this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrLabel14.WordWrap = false;
            // 
            // ReportEvenStyle
            // 
            this.ReportEvenStyle.BackColor = System.Drawing.Color.Transparent;
            this.ReportEvenStyle.Name = "ReportEvenStyle";
            this.ReportEvenStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 0, 254F);
            this.ReportEvenStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // ReportGroupFooterBandStyle
            // 
            this.ReportGroupFooterBandStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ReportGroupFooterBandStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.ReportGroupFooterBandStyle.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.ReportGroupFooterBandStyle.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold);
            this.ReportGroupFooterBandStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ReportGroupFooterBandStyle.Name = "ReportGroupFooterBandStyle";
            this.ReportGroupFooterBandStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 0, 254F);
            this.ReportGroupFooterBandStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // ReportGroupHeaderBandStyle
            // 
            this.ReportGroupHeaderBandStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.ReportGroupHeaderBandStyle.Name = "ReportGroupHeaderBandStyle";
            this.ReportGroupHeaderBandStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(11, 0, 0, 0, 254F);
            this.ReportGroupHeaderBandStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel8,
            this.xrLabel9,
            this.xrLabel10,
            this.xrLabel2});
            this.bottomMarginBand1.Dpi = 254F;
            this.bottomMarginBand1.HeightF = 234F;
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            // 
            // xrLabel8
            // 
            this.xrLabel8.Dpi = 254F;
            this.xrLabel8.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(2550F, 29.99995F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(254F, 58.42F);
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel9
            // 
            this.xrLabel9.Dpi = 254F;
            this.xrLabel9.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(2261.604F, 29.99995F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(288.3958F, 58.41998F);
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.Text = "______________";
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            // 
            // xrLabel10
            // 
            this.xrLabel10.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "FIO")});
            this.xrLabel10.Dpi = 254F;
            this.xrLabel10.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(1688.002F, 29.99995F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(573.6023F, 58.42F);
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.StylePriority.UseTextAlignment = false;
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel2
            // 
            this.xrLabel2.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.xrLabel2.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel2.CanGrow = false;
            this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "subunit")});
            this.xrLabel2.Dpi = 254F;
            this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(25.00001F, 6.899162F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(523.8251F, 81.5208F);
            this.xrLabel2.StylePriority.UseBackColor = false;
            this.xrLabel2.StylePriority.UseBorders = false;
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UsePadding = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "xrLabel16";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrLabel2.WordWrap = false;
            // 
            // ReportFooterBandStyle
            // 
            this.ReportFooterBandStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ReportFooterBandStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.ReportFooterBandStyle.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.ReportFooterBandStyle.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold);
            this.ReportFooterBandStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ReportFooterBandStyle.Name = "ReportFooterBandStyle";
            this.ReportFooterBandStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 0, 254F);
            this.ReportFooterBandStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // table3
            // 
            this.table3.Dpi = 254F;
            this.table3.LocationFloat = new DevExpress.Utils.PointFloat(1923.09F, 0F);
            this.table3.Name = "table3";
            this.table3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow3});
            this.table3.SizeF = new System.Drawing.SizeF(214.26F, 64F);
            // 
            // reportFooterBand1
            // 
            this.reportFooterBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel12,
            this.table3});
            this.reportFooterBand1.Dpi = 254F;
            this.reportFooterBand1.HeightF = 64F;
            this.reportFooterBand1.Name = "reportFooterBand1";
            this.reportFooterBand1.StyleName = "ReportFooterBandStyle";
            // 
            // xrLabel12
            // 
            this.xrLabel12.BackColor = System.Drawing.Color.White;
            this.xrLabel12.Dpi = 254F;
            this.xrLabel12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(1510.34F, 0F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(412.7501F, 63.99997F);
            this.xrLabel12.StylePriority.UseBackColor = false;
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.StylePriority.UseTextAlignment = false;
            this.xrLabel12.Text = "Итого:";
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ReportHeaderBandStyle
            // 
            this.ReportHeaderBandStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.ReportHeaderBandStyle.Name = "ReportHeaderBandStyle";
            this.ReportHeaderBandStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 0, 254F);
            this.ReportHeaderBandStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // pageHeaderBand1
            // 
            this.pageHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel16,
            this.xrLabel1,
            this.xrLabel3,
            this.xrLabel7,
            this.xrLabel6,
            this.xrLabel5,
            this.xrLabel4,
            this.xrLabel21});
            this.pageHeaderBand1.Dpi = 254F;
            this.pageHeaderBand1.HeightF = 114.2708F;
            this.pageHeaderBand1.Name = "pageHeaderBand1";
            this.pageHeaderBand1.StyleName = "ReportHeaderBandStyle";
            // 
            // xrLabel16
            // 
            this.xrLabel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(218)))), ((int)(((byte)(251)))));
            this.xrLabel16.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel16.Dpi = 254F;
            this.xrLabel16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(484.0061F, 0F);
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(537.791F, 114.2708F);
            this.xrLabel16.StylePriority.UseBackColor = false;
            this.xrLabel16.StylePriority.UseBorders = false;
            this.xrLabel16.StylePriority.UseFont = false;
            this.xrLabel16.StylePriority.UsePadding = false;
            this.xrLabel16.StylePriority.UseTextAlignment = false;
            this.xrLabel16.Text = "Наименование техноолгической оснастки";
            this.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel1
            // 
            this.xrLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(218)))), ((int)(((byte)(251)))));
            this.xrLabel1.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel1.Dpi = 254F;
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(190.3185F, 114.2708F);
            this.xrLabel1.StylePriority.UseBackColor = false;
            this.xrLabel1.StylePriority.UseBorders = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UsePadding = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "Дата";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel3
            // 
            this.xrLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(218)))), ((int)(((byte)(251)))));
            this.xrLabel3.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel3.Dpi = 254F;
            this.xrLabel3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(1021.797F, 0F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(467.4729F, 114.2708F);
            this.xrLabel3.StylePriority.UseBackColor = false;
            this.xrLabel3.StylePriority.UseBorders = false;
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UsePadding = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "Вид работ";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel7
            // 
            this.xrLabel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(218)))), ((int)(((byte)(251)))));
            this.xrLabel7.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel7.Dpi = 254F;
            this.xrLabel7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(2137.35F, 0F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(666.6499F, 114.2708F);
            this.xrLabel7.StylePriority.UseBackColor = false;
            this.xrLabel7.StylePriority.UseBorders = false;
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UsePadding = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "Примечания";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel6
            // 
            this.xrLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(218)))), ((int)(((byte)(251)))));
            this.xrLabel6.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel6.Dpi = 254F;
            this.xrLabel6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(1923.087F, 0F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(214.2625F, 114.2708F);
            this.xrLabel6.StylePriority.UseBackColor = false;
            this.xrLabel6.StylePriority.UseBorders = false;
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UsePadding = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "Времени всего";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel5
            // 
            this.xrLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(218)))), ((int)(((byte)(251)))));
            this.xrLabel5.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel5.Dpi = 254F;
            this.xrLabel5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(1695.595F, 0F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(227.4921F, 114.2708F);
            this.xrLabel5.StylePriority.UseBackColor = false;
            this.xrLabel5.StylePriority.UseBorders = false;
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UsePadding = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "Время окончания";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel4
            // 
            this.xrLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(218)))), ((int)(((byte)(251)))));
            this.xrLabel4.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel4.Dpi = 254F;
            this.xrLabel4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(1489.27F, 0F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(206.325F, 114.2708F);
            this.xrLabel4.StylePriority.UseBackColor = false;
            this.xrLabel4.StylePriority.UseBorders = false;
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UsePadding = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "Время начала";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel21
            // 
            this.xrLabel21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(218)))), ((int)(((byte)(251)))));
            this.xrLabel21.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel21.Dpi = 254F;
            this.xrLabel21.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(190.3185F, 0F);
            this.xrLabel21.Name = "xrLabel21";
            this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel21.SizeF = new System.Drawing.SizeF(293.6876F, 114.2708F);
            this.xrLabel21.StylePriority.UseBackColor = false;
            this.xrLabel21.StylePriority.UseBorders = false;
            this.xrLabel21.StylePriority.UseFont = false;
            this.xrLabel21.StylePriority.UsePadding = false;
            this.xrLabel21.StylePriority.UseTextAlignment = false;
            this.xrLabel21.Text = "№ тех. оснастки";
            this.xrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel11});
            this.topMarginBand1.Dpi = 254F;
            this.topMarginBand1.HeightF = 290.9792F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // xrLabel11
            // 
            this.xrLabel11.Dpi = 254F;
            this.xrLabel11.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(0F, 139.0625F);
            this.xrLabel11.Multiline = true;
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(2804F, 151.9167F);
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.StylePriority.UseTextAlignment = false;
            this.xrLabel11.Text = "Отчет о проделанной работе c";
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // ReportOddStyle
            // 
            this.ReportOddStyle.BackColor = System.Drawing.Color.Transparent;
            this.ReportOddStyle.Name = "ReportOddStyle";
            this.ReportOddStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 0, 254F);
            this.ReportOddStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // totalBindingSource
            // 
            this.totalBindingSource.DataMember = "total";
            // 
            // formattingRule1
            // 
            this.formattingRule1.Name = "formattingRule1";
            // 
            // MyReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.pageHeaderBand1,
            this.detailBand1,
            this.reportFooterBand1,
            this.bottomMarginBand1});
            this.Dpi = 254F;
            this.FormattingRuleSheet.AddRange(new DevExpress.XtraReports.UI.FormattingRule[] {
            this.formattingRule1});
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(87, 79, 291, 234);
            this.PageHeight = 2100;
            this.PageWidth = 2970;
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
            ((System.ComponentModel.ISupportInitialize)(this.table3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        private void tableCell20_TextChanged(object sender, System.EventArgs e)
        {
            
        }

        private void tableCell20_SummaryRowChanged(object sender, System.EventArgs e)
        {
            string w = System.Convert.ToString(GetCurrentColumnValue("time_span"));
            ts += System.TimeSpan.Parse(w);
        }

        private void tableCell20_SummaryGetResult(object sender, DevExpress.XtraReports.UI.SummaryGetResultEventArgs e)
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
    }
}
