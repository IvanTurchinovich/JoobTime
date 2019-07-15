using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using DevExpress.XtraReports.UI;
using JoobTime;


namespace JoobTime
{
    public partial class ReportFormPayment : DevExpress.XtraReports.UI.XtraReport
    {
        public System.TimeSpan ts;
        public System.TimeSpan ts1;
        private DataTable WorkList;
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
        private DevExpress.XtraReports.UI.XRLabel TitleLabel;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private XRLabel xrLabel9;
        private XRLabel xrLabel8;
        private XRLabel xrLabel11;
        private XRLabel xrLabel12;
        private XRLabel xrLabel13;
        private XRLabel xrLabel14;
        private XRLabel xrLabel16;
        private XRLabel xrLabel15;
        private XRLabel xrLabel20;
        private XRLabel xrLabel19;
        private XRLabel xrLabel18;
        private XRLabel xrLabel17;
        private XRLabel xrLabel5;
        private XRLabel xrLabel22;
        private XRLabel xrLabel21;
        private XRLabel xrLabel4;
        private XRLabel xrLabel2;
        private XRLabel xrLabel24;
        private XRLabel xrLabel7;
        private XRLabel xrLabel23;

        public ReportFormPayment(object FIO)
        {
            InitializeComponent();
            TitleLabel.Text = "выполненных работ инженера-конструктора инструментального цеха " + FIO + "\n за период с " +
                              ReportGenerating.startDate + " по " + ReportGenerating.endDate;
            WorkList = new DB().GetFullWorkList();

        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            this.groupFooterBand1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.ReportDetailBandStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.ReportOddStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.ReportFooterBandStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            this.TitleLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.pageHeaderBand1 = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
            this.detailBand1 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportGroupHeaderBandStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.ReportHeaderBandStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.groupHeaderBand1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.ReportGroupFooterBandStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.ReportEvenStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.totalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportFooterBand1 = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.totalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // groupFooterBand1
            // 
            this.groupFooterBand1.Dpi = 254F;
            this.groupFooterBand1.Expanded = false;
            this.groupFooterBand1.HeightF = 0F;
            this.groupFooterBand1.KeepTogether = true;
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
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel22,
            this.xrLabel21,
            this.TitleLabel,
            this.xrLabel5});
            this.topMarginBand1.Dpi = 254F;
            this.topMarginBand1.HeightF = 495.7709F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // xrLabel22
            // 
            this.xrLabel22.CanGrow = false;
            this.xrLabel22.Dpi = 254F;
            this.xrLabel22.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(0F, 281.4584F);
            this.xrLabel22.Multiline = true;
            this.xrLabel22.Name = "xrLabel22";
            this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel22.SizeF = new System.Drawing.SizeF(1812F, 87.3125F);
            this.xrLabel22.StylePriority.UseFont = false;
            this.xrLabel22.StylePriority.UseTextAlignment = false;
            this.xrLabel22.Text = "Стоимость";
            this.xrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel21
            // 
            this.xrLabel21.CanGrow = false;
            this.xrLabel21.Dpi = 254F;
            this.xrLabel21.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(1098.021F, 192.875F);
            this.xrLabel21.Multiline = true;
            this.xrLabel21.Name = "xrLabel21";
            this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel21.SizeF = new System.Drawing.SizeF(713.9792F, 88.58344F);
            this.xrLabel21.StylePriority.UseFont = false;
            this.xrLabel21.StylePriority.UseTextAlignment = false;
            this.xrLabel21.Text = "Кивака П.П. ________________\r\n";
            this.xrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // TitleLabel
            // 
            this.TitleLabel.CanGrow = false;
            this.TitleLabel.Dpi = 254F;
            this.TitleLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel.LocationFloat = new DevExpress.Utils.PointFloat(0.0002826055F, 368.7709F);
            this.TitleLabel.Multiline = true;
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.TitleLabel.SizeF = new System.Drawing.SizeF(1812F, 127F);
            this.TitleLabel.StylePriority.UseFont = false;
            this.TitleLabel.StylePriority.UseTextAlignment = false;
            this.TitleLabel.Text = "выполненых работ инженера конструктора инструментального цеха Лицкевича М.Э.\r\nза " +
    "период от 01.06.2018 по 30.06.2018";
            this.TitleLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel5
            // 
            this.xrLabel5.CanGrow = false;
            this.xrLabel5.Dpi = 254F;
            this.xrLabel5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(1098.021F, 93.70827F);
            this.xrLabel5.Multiline = true;
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(713.9792F, 99.16675F);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "Утверждаю:\r\nЗам. директора по производству";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // pageHeaderBand1
            // 
            this.pageHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1,
            this.xrLabel3,
            this.xrLabel23});
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
            this.xrLabel1.SizeF = new System.Drawing.SizeF(802.8615F, 74.58331F);
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
            this.xrLabel3.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel3.Dpi = 254F;
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(802.8615F, 0F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(607.0414F, 74.58331F);
            this.xrLabel3.StylePriority.UseBackColor = false;
            this.xrLabel3.StylePriority.UseBorders = false;
            this.xrLabel3.StylePriority.UsePadding = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "Вид работы";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel23
            // 
            this.xrLabel23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(218)))), ((int)(((byte)(251)))));
            this.xrLabel23.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel23.Dpi = 254F;
            this.xrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(1409.903F, 0F);
            this.xrLabel23.Multiline = true;
            this.xrLabel23.Name = "xrLabel23";
            this.xrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel23.SizeF = new System.Drawing.SizeF(402.097F, 74.58331F);
            this.xrLabel23.StylePriority.UseBackColor = false;
            this.xrLabel23.StylePriority.UseBorders = false;
            this.xrLabel23.StylePriority.UsePadding = false;
            this.xrLabel23.StylePriority.UseTextAlignment = false;
            this.xrLabel23.Text = "Оплата";
            this.xrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // detailBand1
            // 
            this.detailBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel4,
            this.xrLabel2,
            this.xrLabel24,
            this.xrLabel7});
            this.detailBand1.Dpi = 254F;
            this.detailBand1.EvenStyleName = "ReportEvenStyle";
            this.detailBand1.HeightF = 64.27079F;
            this.detailBand1.KeepTogether = true;
            this.detailBand1.KeepTogetherWithDetailReports = true;
            this.detailBand1.LockedInUserDesigner = true;
            this.detailBand1.Name = "detailBand1";
            this.detailBand1.OddStyleName = "ReportOddStyle";
            this.detailBand1.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("time_span", DevExpress.XtraReports.UI.XRColumnSortOrder.None)});
            this.detailBand1.StyleName = "ReportDetailBandStyle";
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
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "payment")});
            this.xrLabel4.Dpi = 254F;
            this.xrLabel4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(1409.903F, 0F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(402.0969F, 64.27078F);
            this.xrLabel4.StylePriority.UseBackColor = false;
            this.xrLabel4.StylePriority.UseBorderColor = false;
            this.xrLabel4.StylePriority.UseBorderDashStyle = false;
            this.xrLabel4.StylePriority.UseBorders = false;
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseForeColor = false;
            this.xrLabel4.StylePriority.UsePadding = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            xrSummary1.IgnoreNullValues = true;
            this.xrLabel4.Summary = xrSummary1;
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrLabel4.WordWrap = false;
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
            this.xrLabel2.ProcessDuplicatesMode = DevExpress.XtraReports.UI.ProcessDuplicatesMode.Merge;
            this.xrLabel2.SizeF = new System.Drawing.SizeF(221.9236F, 64.27079F);
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
            // xrLabel24
            // 
            this.xrLabel24.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.xrLabel24.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top;
            this.xrLabel24.BackColor = System.Drawing.Color.Empty;
            this.xrLabel24.BorderColor = System.Drawing.Color.Black;
            this.xrLabel24.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel24.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "name_form")});
            this.xrLabel24.Dpi = 254F;
            this.xrLabel24.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabel24.LocationFloat = new DevExpress.Utils.PointFloat(221.9238F, 0F);
            this.xrLabel24.Name = "xrLabel24";
            this.xrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel24.ProcessDuplicatesMode = DevExpress.XtraReports.UI.ProcessDuplicatesMode.Merge;
            this.xrLabel24.SizeF = new System.Drawing.SizeF(580.9377F, 64.27078F);
            this.xrLabel24.StylePriority.UseBackColor = false;
            this.xrLabel24.StylePriority.UseBorderColor = false;
            this.xrLabel24.StylePriority.UseBorders = false;
            this.xrLabel24.StylePriority.UseFont = false;
            this.xrLabel24.StylePriority.UsePadding = false;
            this.xrLabel24.StylePriority.UseTextAlignment = false;
            this.xrLabel24.Text = "xrLabel4";
            this.xrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel7
            // 
            this.xrLabel7.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.xrLabel7.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.xrLabel7.BackColor = System.Drawing.Color.Empty;
            this.xrLabel7.BorderColor = System.Drawing.Color.Black;
            this.xrLabel7.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel7.CanGrow = false;
            this.xrLabel7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "subunit")});
            this.xrLabel7.Dpi = 254F;
            this.xrLabel7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(802.8615F, 0F);
            this.xrLabel7.Multiline = true;
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(607.0418F, 64.27078F);
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
            this.groupHeaderBand1.HeightF = 0F;
            this.groupHeaderBand1.Name = "groupHeaderBand1";
            // 
            // ReportGroupFooterBandStyle
            // 
            this.ReportGroupFooterBandStyle.Name = "ReportGroupFooterBandStyle";
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
            this.xrLabel13,
            this.xrLabel14,
            this.xrLabel16,
            this.xrLabel15,
            this.xrLabel9,
            this.xrLabel8,
            this.xrLabel11,
            this.xrLabel12,
            this.xrLabel20,
            this.xrLabel19,
            this.xrLabel18,
            this.xrLabel17,
            this.xrLabel10,
            this.xrLabel6});
            this.reportFooterBand1.Dpi = 254F;
            this.reportFooterBand1.HeightF = 1042.67F;
            this.reportFooterBand1.Name = "reportFooterBand1";
            this.reportFooterBand1.StyleName = "ReportFooterBandStyle";
            this.reportFooterBand1.StylePriority.UseBackColor = false;
            this.reportFooterBand1.StylePriority.UseBorderColor = false;
            // 
            // xrLabel13
            // 
            this.xrLabel13.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel13.Dpi = 254F;
            this.xrLabel13.Font = new System.Drawing.Font("Times New Roman", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(487.62F, 209.5696F);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(146.6104F, 28.84883F);
            this.xrLabel13.StylePriority.UseBackColor = false;
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.Text = "(Дата, Подпись)";
            // 
            // xrLabel14
            // 
            this.xrLabel14.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel14.Dpi = 254F;
            this.xrLabel14.Font = new System.Drawing.Font("Times New Roman", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(487.62F, 278.5694F);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(146.6104F, 28.84883F);
            this.xrLabel14.StylePriority.UseBackColor = false;
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.Text = "(Дата, Подпись)";
            // 
            // xrLabel16
            // 
            this.xrLabel16.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel16.Dpi = 254F;
            this.xrLabel16.Font = new System.Drawing.Font("Times New Roman", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(487.62F, 347.5695F);
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(146.6104F, 28.84883F);
            this.xrLabel16.StylePriority.UseBackColor = false;
            this.xrLabel16.StylePriority.UseFont = false;
            this.xrLabel16.Text = "(Дата, Подпись)";
            // 
            // xrLabel15
            // 
            this.xrLabel15.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel15.Dpi = 254F;
            this.xrLabel15.Font = new System.Drawing.Font("Times New Roman", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(487.62F, 416.5695F);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(146.6104F, 28.84883F);
            this.xrLabel15.StylePriority.UseBackColor = false;
            this.xrLabel15.StylePriority.UseFont = false;
            this.xrLabel15.Text = "(Дата, Подпись)";
            // 
            // xrLabel9
            // 
            this.xrLabel9.BackColor = System.Drawing.Color.White;
            this.xrLabel9.Dpi = 254F;
            this.xrLabel9.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(25.00001F, 169.3333F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(824.2621F, 58.42F);
            this.xrLabel9.StylePriority.UseBackColor = false;
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.Text = "Председатель комиссии _________________________________";
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel8
            // 
            this.xrLabel8.BackColor = System.Drawing.Color.White;
            this.xrLabel8.Dpi = 254F;
            this.xrLabel8.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(25.00493F, 238.4184F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(824.2621F, 58.42F);
            this.xrLabel8.StylePriority.UseBackColor = false;
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "Члены комиссии _________________________________";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel11
            // 
            this.xrLabel11.BackColor = System.Drawing.Color.White;
            this.xrLabel11.Dpi = 254F;
            this.xrLabel11.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(25.00493F, 307.4183F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(824.2621F, 58.42F);
            this.xrLabel11.StylePriority.UseBackColor = false;
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.StylePriority.UseTextAlignment = false;
            this.xrLabel11.Text = "_________________________________";
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel12
            // 
            this.xrLabel12.BackColor = System.Drawing.Color.White;
            this.xrLabel12.Dpi = 254F;
            this.xrLabel12.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(25.00493F, 376.4184F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(824.2621F, 58.42F);
            this.xrLabel12.StylePriority.UseBackColor = false;
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.StylePriority.UseTextAlignment = false;
            this.xrLabel12.Text = "_________________________________";
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel20
            // 
            this.xrLabel20.BackColor = System.Drawing.Color.White;
            this.xrLabel20.Dpi = 254F;
            this.xrLabel20.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic);
            this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(859.7528F, 169.3333F);
            this.xrLabel20.Name = "xrLabel20";
            this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel20.SizeF = new System.Drawing.SizeF(273.4477F, 58.42F);
            this.xrLabel20.StylePriority.UseBackColor = false;
            this.xrLabel20.StylePriority.UseFont = false;
            this.xrLabel20.StylePriority.UseTextAlignment = false;
            this.xrLabel20.Text = "Орешкин С.В.";
            this.xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel19
            // 
            this.xrLabel19.BackColor = System.Drawing.Color.White;
            this.xrLabel19.Dpi = 254F;
            this.xrLabel19.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic);
            this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(859.7578F, 238.4184F);
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel19.SizeF = new System.Drawing.SizeF(273.4427F, 58.41998F);
            this.xrLabel19.StylePriority.UseBackColor = false;
            this.xrLabel19.StylePriority.UseFont = false;
            this.xrLabel19.StylePriority.UseTextAlignment = false;
            this.xrLabel19.Text = "Рыбачук Е.В.";
            this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel18
            // 
            this.xrLabel18.BackColor = System.Drawing.Color.White;
            this.xrLabel18.Dpi = 254F;
            this.xrLabel18.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic);
            this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(859.7578F, 307.4184F);
            this.xrLabel18.Name = "xrLabel18";
            this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel18.SizeF = new System.Drawing.SizeF(273.4427F, 58.42001F);
            this.xrLabel18.StylePriority.UseBackColor = false;
            this.xrLabel18.StylePriority.UseFont = false;
            this.xrLabel18.StylePriority.UseTextAlignment = false;
            this.xrLabel18.Text = "Степанчук А.М.";
            this.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel17
            // 
            this.xrLabel17.BackColor = System.Drawing.Color.White;
            this.xrLabel17.Dpi = 254F;
            this.xrLabel17.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic);
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(859.7578F, 376.4184F);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(273.4427F, 58.42001F);
            this.xrLabel17.StylePriority.UseBackColor = false;
            this.xrLabel17.StylePriority.UseFont = false;
            this.xrLabel17.StylePriority.UseTextAlignment = false;
            this.xrLabel17.Text = "Макаров К.В.";
            this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel10
            // 
            this.xrLabel10.BackColor = System.Drawing.Color.White;
            this.xrLabel10.BorderColor = System.Drawing.Color.Black;
            this.xrLabel10.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel10.Dpi = 254F;
            this.xrLabel10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(59.35523F, 0F);
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
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "payment")});
            this.xrLabel6.Dpi = 254F;
            this.xrLabel6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(1409.903F, 0F);
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
            xrSummary2.IgnoreNullValues = true;
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrLabel6.Summary = xrSummary2;
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrLabel6.WordWrap = false;
            // 
            // ReportFormPayment
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
            this.Margins = new System.Drawing.Printing.Margins(201, 87, 496, 254);
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
            ((System.ComponentModel.ISupportInitialize)(this.totalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        private void xrLabel7_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            if (xrLabel7.Text == "Прочее")
                return;
            var subunit = xrLabel7.Text;
            var work=SetWork(subunit);
            xrLabel7.Text = work;
        }

        private string SetWork(string subunit)
        {
            string result;
            switch (subunit)
            {
                case "2D формы":
                    result = "Разработка КД";
                    break;
                case "3D формы":
                    result = "Разработка формы";
                    break;
                case "3D дизайн":
                    result = "Разработка дизайна";
                    break;
                case "Отдел по развитию предприятия":
                    result = "Разработка ПО";
                    break;
                case "УП-формообразующие и электроды":
                    result = "Разработка УП на формообразующие";
                    break;
                case "УП-плиты":
                    result = "Разработка УП на плиты";
                    break;
                    default: result = subunit;
                    break;
            }
            return result;
        }
    }
}