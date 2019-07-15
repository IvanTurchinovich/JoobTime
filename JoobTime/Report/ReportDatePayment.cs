using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace JoobTime
{
    public partial class ReportDatePayment : DevExpress.XtraReports.UI.XtraReport
    {
        public System.TimeSpan ts;
        public System.TimeSpan ts1;

        private DevExpress.XtraReports.UI.XRTableCell tableCell19;
        private DevExpress.XtraReports.UI.XRTable table5;
        private DevExpress.XtraReports.UI.XRTableRow tableRow5;
        private DevExpress.XtraReports.UI.XRTableCell tableCell25;
        private DevExpress.XtraReports.UI.XRTable table4;
        private DevExpress.XtraReports.UI.XRTableRow tableRow4;
        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.ReportFooterBand reportFooterBand1;
        private DevExpress.XtraReports.UI.XRControlStyle ReportEvenStyle;
        private DevExpress.XtraReports.UI.XRControlStyle ReportFooterBandStyle;
        private DevExpress.XtraReports.UI.XRControlStyle ReportGroupFooterBandStyle;
        private DevExpress.XtraReports.UI.XRControlStyle ReportHeaderBandStyle;
        private DevExpress.XtraReports.UI.DetailBand detailBand1;
        private DevExpress.XtraReports.UI.GroupHeaderBand groupHeaderBand1;
        private DevExpress.XtraReports.UI.XRTable table2;
        private DevExpress.XtraReports.UI.XRTableRow tableRow2;
        private DevExpress.XtraReports.UI.XRTableCell tableCell7;
        private DevExpress.XtraReports.UI.XRTableCell tableCell8;
        private DevExpress.XtraReports.UI.XRControlStyle ReportDetailBandStyle;
        private DevExpress.XtraReports.UI.XRControlStyle ReportOddStyle;
        private DevExpress.XtraReports.UI.PageHeaderBand pageHeaderBand1;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private DevExpress.XtraReports.UI.XRControlStyle ReportGroupHeaderBandStyle;
        //private _1.DB1DataSetTableAdapters.totalTableAdapter totalTableAdapter;
        private System.Windows.Forms.BindingSource totalBindingSource;
        private System.ComponentModel.IContainer components;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel FormIdCell;
        private DevExpress.XtraReports.UI.XRLabel WorkCell;
        private DevExpress.XtraReports.UI.XRLabel TimeBeginCell;
        private DevExpress.XtraReports.UI.XRLabel TimeEndCell;
        private DevExpress.XtraReports.UI.XRLabel TimeSpanCell;
        private DevExpress.XtraReports.UI.XRLabel OtherCell;
        private DevExpress.XtraReports.UI.XRLabel xrLabel21;
        //private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private XRLabel PaymentCell;
        private XRLabel xrLabel1;
        private XRTable xrTable1;
        private XRTableRow xrTableRow1;
        private XRTableCell xrTableCell1;
        private XRTable xrTable2;
        private XRTableRow xrTableRow2;
        private XRTableCell xrTableCell2;
        private XRTable xrTable3;
        private XRTableRow xrTableRow3;
        private XRTableCell xrTableCell3;
        private XRLabel xrLabel17;
        private XRLabel xrLabel18;
        private XRLabel xrLabel19;
        private XRLabel xrLabel20;
        private XRLabel xrLabel15;
        private XRLabel xrLabel16;
        private XRLabel xrLabel14;
        private XRLabel xrLabel13;
        private XRLabel xrLabel12;
        private XRLabel xrLabel11;
        private XRLabel xrLabel10;
        private XRLabel xrLabel9;
        private ReportHeaderBand ReportHeader;
        private XRLabel TitleLabel;
        private XRLabel xrLabel23;
        private XRLabel xrLabel22;
        private DevExpress.XtraReports.UI.XRLabel NameFormCell;

        public ReportDatePayment(object FIO)
        {
            InitializeComponent();
            TitleLabel.Text = "Расценки стоимости выполненых работ \n" + FIO + "\n за период с " +
                              ReportGenerating.startDate + " по " + ReportGenerating.endDate;
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary4 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary5 = new DevExpress.XtraReports.UI.XRSummary();
            this.tableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table5 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table4 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.reportFooterBand1 = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportEvenStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.ReportFooterBandStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.ReportGroupFooterBandStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.ReportHeaderBandStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.detailBand1 = new DevExpress.XtraReports.UI.DetailBand();
            this.PaymentCell = new DevExpress.XtraReports.UI.XRLabel();
            this.NameFormCell = new DevExpress.XtraReports.UI.XRLabel();
            this.FormIdCell = new DevExpress.XtraReports.UI.XRLabel();
            this.WorkCell = new DevExpress.XtraReports.UI.XRLabel();
            this.TimeBeginCell = new DevExpress.XtraReports.UI.XRLabel();
            this.TimeEndCell = new DevExpress.XtraReports.UI.XRLabel();
            this.TimeSpanCell = new DevExpress.XtraReports.UI.XRLabel();
            this.OtherCell = new DevExpress.XtraReports.UI.XRLabel();
            this.groupHeaderBand1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table2 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.ReportDetailBandStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.ReportOddStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.pageHeaderBand1 = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportGroupHeaderBandStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.totalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.TitleLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.table5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // tableCell19
            // 
            this.tableCell19.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.tableCell19.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "time_span")});
            this.tableCell19.Dpi = 254F;
            this.tableCell19.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.tableCell19.Name = "tableCell19";
            this.tableCell19.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96F);
            this.tableCell19.StylePriority.UseBorders = false;
            this.tableCell19.StylePriority.UseFont = false;
            this.tableCell19.StylePriority.UseTextAlignment = false;
            xrSummary1.FormatString = "Всего: {0}";
            xrSummary1.IgnoreNullValues = true;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.tableCell19.Summary = xrSummary1;
            this.tableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.tableCell19.Weight = 0.36640484449111682D;
            this.tableCell19.WordWrap = false;
            this.tableCell19.SummaryGetResult += new DevExpress.XtraReports.UI.SummaryGetResultHandler(this.tableCell19_SummaryGetResult);
            this.tableCell19.SummaryReset += new System.EventHandler(this.tableCell19_SummaryReset);
            this.tableCell19.SummaryRowChanged += new System.EventHandler(this.tableCell19_SummaryRowChanged);
            // 
            // table5
            // 
            this.table5.Dpi = 254F;
            this.table5.LocationFloat = new DevExpress.Utils.PointFloat(1806.227F, 0F);
            this.table5.Name = "table5";
            this.table5.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow5});
            this.table5.SizeF = new System.Drawing.SizeF(246.01F, 64F);
            // 
            // tableRow5
            // 
            this.tableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell25});
            this.tableRow5.Dpi = 254F;
            this.tableRow5.Name = "tableRow5";
            this.tableRow5.Weight = 10.46953028649871D;
            // 
            // tableCell25
            // 
            this.tableCell25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tableCell25.BorderColor = System.Drawing.Color.Red;
            this.tableCell25.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tableCell25.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "time_span")});
            this.tableCell25.Dpi = 254F;
            this.tableCell25.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.tableCell25.Name = "tableCell25";
            this.tableCell25.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96F);
            this.tableCell25.StylePriority.UseBackColor = false;
            this.tableCell25.StylePriority.UseBorderColor = false;
            this.tableCell25.StylePriority.UseBorders = false;
            this.tableCell25.StylePriority.UseFont = false;
            xrSummary2.IgnoreNullValues = true;
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.tableCell25.Summary = xrSummary2;
            this.tableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell25.Weight = 0.34782243285035996D;
            this.tableCell25.WordWrap = false;
            this.tableCell25.SummaryGetResult += new DevExpress.XtraReports.UI.SummaryGetResultHandler(this.tableCell25_SummaryGetResult);
            this.tableCell25.SummaryRowChanged += new System.EventHandler(this.tableCell25_SummaryRowChanged);
            // 
            // table4
            // 
            this.table4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.table4.Dpi = 254F;
            this.table4.LocationFloat = new DevExpress.Utils.PointFloat(1806.227F, 0F);
            this.table4.Name = "table4";
            this.table4.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow4});
            this.table4.SizeF = new System.Drawing.SizeF(558.2177F, 64F);
            this.table4.StylePriority.UseBackColor = false;
            // 
            // tableRow4
            // 
            this.tableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell19});
            this.tableRow4.Dpi = 254F;
            this.tableRow4.Name = "tableRow4";
            this.tableRow4.Weight = 10.46953028649871D;
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.Dpi = 254F;
            this.topMarginBand1.HeightF = 188.8542F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // reportFooterBand1
            // 
            this.reportFooterBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel17,
            this.xrLabel18,
            this.xrLabel19,
            this.xrLabel20,
            this.xrLabel15,
            this.xrLabel16,
            this.xrLabel14,
            this.xrLabel13,
            this.xrLabel12,
            this.xrLabel11,
            this.xrLabel10,
            this.xrLabel9,
            this.xrTable3,
            this.xrTable2,
            this.xrLabel7,
            this.table5});
            this.reportFooterBand1.Dpi = 254F;
            this.reportFooterBand1.HeightF = 390.4552F;
            this.reportFooterBand1.Name = "reportFooterBand1";
            this.reportFooterBand1.StyleName = "ReportFooterBandStyle";
            // 
            // xrLabel17
            // 
            this.xrLabel17.BackColor = System.Drawing.Color.White;
            this.xrLabel17.Dpi = 254F;
            this.xrLabel17.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic);
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(875.6329F, 289.0001F);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(273.4427F, 58.42001F);
            this.xrLabel17.StylePriority.UseBackColor = false;
            this.xrLabel17.StylePriority.UseFont = false;
            this.xrLabel17.StylePriority.UseTextAlignment = false;
            this.xrLabel17.Text = "Макаров К.В.";
            this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel18
            // 
            this.xrLabel18.BackColor = System.Drawing.Color.White;
            this.xrLabel18.Dpi = 254F;
            this.xrLabel18.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic);
            this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(875.6329F, 220.0001F);
            this.xrLabel18.Name = "xrLabel18";
            this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel18.SizeF = new System.Drawing.SizeF(273.4427F, 58.42001F);
            this.xrLabel18.StylePriority.UseBackColor = false;
            this.xrLabel18.StylePriority.UseFont = false;
            this.xrLabel18.StylePriority.UseTextAlignment = false;
            this.xrLabel18.Text = "Степанчук А.М.";
            this.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel19
            // 
            this.xrLabel19.BackColor = System.Drawing.Color.White;
            this.xrLabel19.Dpi = 254F;
            this.xrLabel19.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic);
            this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(875.6329F, 151.0001F);
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel19.SizeF = new System.Drawing.SizeF(273.4427F, 58.41998F);
            this.xrLabel19.StylePriority.UseBackColor = false;
            this.xrLabel19.StylePriority.UseFont = false;
            this.xrLabel19.StylePriority.UseTextAlignment = false;
            this.xrLabel19.Text = "Рыбачук Е.В.";
            this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel20
            // 
            this.xrLabel20.BackColor = System.Drawing.Color.White;
            this.xrLabel20.Dpi = 254F;
            this.xrLabel20.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic);
            this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(875.6279F, 81.91499F);
            this.xrLabel20.Name = "xrLabel20";
            this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel20.SizeF = new System.Drawing.SizeF(273.4477F, 58.42F);
            this.xrLabel20.StylePriority.UseBackColor = false;
            this.xrLabel20.StylePriority.UseFont = false;
            this.xrLabel20.StylePriority.UseTextAlignment = false;
            this.xrLabel20.Text = "Орешкин С.В.";
            this.xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel15
            // 
            this.xrLabel15.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel15.Dpi = 254F;
            this.xrLabel15.Font = new System.Drawing.Font("Times New Roman", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(503.4952F, 329.1511F);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(146.6104F, 28.84883F);
            this.xrLabel15.StylePriority.UseBackColor = false;
            this.xrLabel15.StylePriority.UseFont = false;
            this.xrLabel15.Text = "(Дата, Подпись)";
            // 
            // xrLabel16
            // 
            this.xrLabel16.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel16.Dpi = 254F;
            this.xrLabel16.Font = new System.Drawing.Font("Times New Roman", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(503.4952F, 260.1512F);
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(146.6104F, 28.84883F);
            this.xrLabel16.StylePriority.UseBackColor = false;
            this.xrLabel16.StylePriority.UseFont = false;
            this.xrLabel16.Text = "(Дата, Подпись)";
            // 
            // xrLabel14
            // 
            this.xrLabel14.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel14.Dpi = 254F;
            this.xrLabel14.Font = new System.Drawing.Font("Times New Roman", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(503.4952F, 191.1511F);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(146.6104F, 28.84883F);
            this.xrLabel14.StylePriority.UseBackColor = false;
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.Text = "(Дата, Подпись)";
            // 
            // xrLabel13
            // 
            this.xrLabel13.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel13.Dpi = 254F;
            this.xrLabel13.Font = new System.Drawing.Font("Times New Roman", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(503.4952F, 122.1512F);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(146.6104F, 28.84883F);
            this.xrLabel13.StylePriority.UseBackColor = false;
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.Text = "(Дата, Подпись)";
            // 
            // xrLabel12
            // 
            this.xrLabel12.BackColor = System.Drawing.Color.White;
            this.xrLabel12.Dpi = 254F;
            this.xrLabel12.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(40.88F, 289F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(824.2621F, 58.42F);
            this.xrLabel12.StylePriority.UseBackColor = false;
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.StylePriority.UseTextAlignment = false;
            this.xrLabel12.Text = "_________________________________";
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel11
            // 
            this.xrLabel11.BackColor = System.Drawing.Color.White;
            this.xrLabel11.Dpi = 254F;
            this.xrLabel11.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(40.88002F, 220F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(824.2621F, 58.42F);
            this.xrLabel11.StylePriority.UseBackColor = false;
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.StylePriority.UseTextAlignment = false;
            this.xrLabel11.Text = "_________________________________";
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel10
            // 
            this.xrLabel10.BackColor = System.Drawing.Color.White;
            this.xrLabel10.Dpi = 254F;
            this.xrLabel10.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(40.88F, 151F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(824.2621F, 58.42F);
            this.xrLabel10.StylePriority.UseBackColor = false;
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.StylePriority.UseTextAlignment = false;
            this.xrLabel10.Text = "Члены комиссии:_________________________________";
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel9
            // 
            this.xrLabel9.BackColor = System.Drawing.Color.White;
            this.xrLabel9.Dpi = 254F;
            this.xrLabel9.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(40.87509F, 81.91498F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(824.2621F, 58.42F);
            this.xrLabel9.StylePriority.UseBackColor = false;
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.Text = "Председатель комиссии:_________________________________";
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrTable3
            // 
            this.xrTable3.Dpi = 254F;
            this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(2052.237F, 0F);
            this.xrTable3.Name = "xrTable3";
            this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
            this.xrTable3.SizeF = new System.Drawing.SizeF(513.8508F, 64F);
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell3});
            this.xrTableRow3.Dpi = 254F;
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 10.46953028649871D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.BackColor = System.Drawing.Color.White;
            this.xrTableCell3.BorderColor = System.Drawing.Color.Red;
            this.xrTableCell3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableCell3.Dpi = 254F;
            this.xrTableCell3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96F);
            this.xrTableCell3.StylePriority.UseBackColor = false;
            this.xrTableCell3.StylePriority.UseBorderColor = false;
            this.xrTableCell3.StylePriority.UseBorders = false;
            this.xrTableCell3.StylePriority.UseFont = false;
            xrSummary3.IgnoreNullValues = true;
            this.xrTableCell3.Summary = xrSummary3;
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell3.Weight = 0.34782243285035996D;
            this.xrTableCell3.WordWrap = false;
            // 
            // xrTable2
            // 
            this.xrTable2.Dpi = 254F;
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(2566.088F, 0F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.SizeF = new System.Drawing.SizeF(225.9111F, 64F);
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell2});
            this.xrTableRow2.Dpi = 254F;
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 10.46953028649871D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.xrTableCell2.BorderColor = System.Drawing.Color.Red;
            this.xrTableCell2.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "payment")});
            this.xrTableCell2.Dpi = 254F;
            this.xrTableCell2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96F);
            this.xrTableCell2.StylePriority.UseBackColor = false;
            this.xrTableCell2.StylePriority.UseBorderColor = false;
            this.xrTableCell2.StylePriority.UseBorders = false;
            this.xrTableCell2.StylePriority.UseFont = false;
            xrSummary4.IgnoreNullValues = true;
            xrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrTableCell2.Summary = xrSummary4;
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell2.Weight = 0.34782243285035996D;
            this.xrTableCell2.WordWrap = false;
            // 
            // xrLabel7
            // 
            this.xrLabel7.BackColor = System.Drawing.Color.White;
            this.xrLabel7.Dpi = 254F;
            this.xrLabel7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(1417.287F, 0F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(388.9376F, 63.99997F);
            this.xrLabel7.StylePriority.UseBackColor = false;
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "Итого:";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ReportEvenStyle
            // 
            this.ReportEvenStyle.BackColor = System.Drawing.Color.Transparent;
            this.ReportEvenStyle.Name = "ReportEvenStyle";
            this.ReportEvenStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 254F);
            this.ReportEvenStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
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
            // ReportHeaderBandStyle
            // 
            this.ReportHeaderBandStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.ReportHeaderBandStyle.Name = "ReportHeaderBandStyle";
            this.ReportHeaderBandStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 254F);
            this.ReportHeaderBandStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // detailBand1
            // 
            this.detailBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.PaymentCell,
            this.NameFormCell,
            this.FormIdCell,
            this.WorkCell,
            this.TimeBeginCell,
            this.TimeEndCell,
            this.TimeSpanCell,
            this.OtherCell});
            this.detailBand1.Dpi = 254F;
            this.detailBand1.EvenStyleName = "ReportEvenStyle";
            this.detailBand1.HeightF = 58.29158F;
            this.detailBand1.KeepTogether = true;
            this.detailBand1.LockedInUserDesigner = true;
            this.detailBand1.Name = "detailBand1";
            this.detailBand1.OddStyleName = "ReportOddStyle";
            this.detailBand1.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("time_begin", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.detailBand1.StyleName = "ReportDetailBandStyle";
            // 
            // PaymentCell
            // 
            this.PaymentCell.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.PaymentCell.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.PaymentCell.BackColor = System.Drawing.Color.Transparent;
            this.PaymentCell.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.PaymentCell.CanGrow = false;
            this.PaymentCell.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "payment")});
            this.PaymentCell.Dpi = 254F;
            this.PaymentCell.LocationFloat = new DevExpress.Utils.PointFloat(2566.088F, 0F);
            this.PaymentCell.Name = "PaymentCell";
            this.PaymentCell.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.PaymentCell.SizeF = new System.Drawing.SizeF(225.9116F, 58.29158F);
            this.PaymentCell.StylePriority.UseBackColor = false;
            this.PaymentCell.StylePriority.UseBorders = false;
            this.PaymentCell.StylePriority.UsePadding = false;
            this.PaymentCell.StylePriority.UseTextAlignment = false;
            this.PaymentCell.Text = "TimeSpanCell";
            this.PaymentCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.PaymentCell.WordWrap = false;
            // 
            // NameFormCell
            // 
            this.NameFormCell.BackColor = System.Drawing.Color.White;
            this.NameFormCell.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.NameFormCell.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "name_form")});
            this.NameFormCell.Dpi = 254F;
            this.NameFormCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameFormCell.LocationFloat = new DevExpress.Utils.PointFloat(817.5123F, 0F);
            this.NameFormCell.Multiline = true;
            this.NameFormCell.Name = "NameFormCell";
            this.NameFormCell.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.NameFormCell.SizeF = new System.Drawing.SizeF(554.8959F, 58.29158F);
            this.NameFormCell.StylePriority.UseBackColor = false;
            this.NameFormCell.StylePriority.UseBorders = false;
            this.NameFormCell.StylePriority.UseFont = false;
            this.NameFormCell.StylePriority.UsePadding = false;
            this.NameFormCell.StylePriority.UseTextAlignment = false;
            this.NameFormCell.Text = "xrLabel4";
            this.NameFormCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // FormIdCell
            // 
            this.FormIdCell.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.FormIdCell.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.FormIdCell.BackColor = System.Drawing.Color.Transparent;
            this.FormIdCell.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.FormIdCell.CanGrow = false;
            this.FormIdCell.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "form_id")});
            this.FormIdCell.Dpi = 254F;
            this.FormIdCell.LocationFloat = new DevExpress.Utils.PointFloat(576.7413F, 0F);
            this.FormIdCell.Name = "FormIdCell";
            this.FormIdCell.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.FormIdCell.SizeF = new System.Drawing.SizeF(240.771F, 58.29158F);
            this.FormIdCell.StylePriority.UseBackColor = false;
            this.FormIdCell.StylePriority.UseBorders = false;
            this.FormIdCell.StylePriority.UsePadding = false;
            this.FormIdCell.StylePriority.UseTextAlignment = false;
            this.FormIdCell.Text = "xrLabel3";
            this.FormIdCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.FormIdCell.WordWrap = false;
            // 
            // WorkCell
            // 
            this.WorkCell.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.WorkCell.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.WorkCell.BackColor = System.Drawing.Color.Transparent;
            this.WorkCell.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.WorkCell.CanGrow = false;
            this.WorkCell.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "work")});
            this.WorkCell.Dpi = 254F;
            this.WorkCell.LocationFloat = new DevExpress.Utils.PointFloat(0F, 8.074442E-05F);
            this.WorkCell.Multiline = true;
            this.WorkCell.Name = "WorkCell";
            this.WorkCell.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.WorkCell.SizeF = new System.Drawing.SizeF(576.7413F, 58.2915F);
            this.WorkCell.StylePriority.UseBackColor = false;
            this.WorkCell.StylePriority.UseBorders = false;
            this.WorkCell.StylePriority.UsePadding = false;
            this.WorkCell.StylePriority.UseTextAlignment = false;
            this.WorkCell.Text = "WorkCell";
            this.WorkCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // TimeBeginCell
            // 
            this.TimeBeginCell.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.TimeBeginCell.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.TimeBeginCell.BackColor = System.Drawing.Color.Transparent;
            this.TimeBeginCell.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.TimeBeginCell.CanGrow = false;
            this.TimeBeginCell.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "time_begin", "{0:t}")});
            this.TimeBeginCell.Dpi = 254F;
            this.TimeBeginCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TimeBeginCell.LocationFloat = new DevExpress.Utils.PointFloat(1372.408F, 0F);
            this.TimeBeginCell.Name = "TimeBeginCell";
            this.TimeBeginCell.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.TimeBeginCell.SizeF = new System.Drawing.SizeF(208.9705F, 58.29158F);
            this.TimeBeginCell.StylePriority.UseBackColor = false;
            this.TimeBeginCell.StylePriority.UseBorders = false;
            this.TimeBeginCell.StylePriority.UseForeColor = false;
            this.TimeBeginCell.StylePriority.UsePadding = false;
            this.TimeBeginCell.StylePriority.UseTextAlignment = false;
            this.TimeBeginCell.Text = "TimeBeginCell";
            this.TimeBeginCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.TimeBeginCell.WordWrap = false;
            // 
            // TimeEndCell
            // 
            this.TimeEndCell.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.TimeEndCell.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.TimeEndCell.BackColor = System.Drawing.Color.Transparent;
            this.TimeEndCell.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.TimeEndCell.CanGrow = false;
            this.TimeEndCell.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "time_end", "{0:t}")});
            this.TimeEndCell.Dpi = 254F;
            this.TimeEndCell.LocationFloat = new DevExpress.Utils.PointFloat(1581.379F, 0F);
            this.TimeEndCell.Name = "TimeEndCell";
            this.TimeEndCell.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.TimeEndCell.SizeF = new System.Drawing.SizeF(224.8457F, 58.29158F);
            this.TimeEndCell.StylePriority.UseBackColor = false;
            this.TimeEndCell.StylePriority.UseBorders = false;
            this.TimeEndCell.StylePriority.UsePadding = false;
            this.TimeEndCell.StylePriority.UseTextAlignment = false;
            this.TimeEndCell.Text = "TimeEndCell";
            this.TimeEndCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.TimeEndCell.WordWrap = false;
            // 
            // TimeSpanCell
            // 
            this.TimeSpanCell.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.TimeSpanCell.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.TimeSpanCell.BackColor = System.Drawing.Color.Transparent;
            this.TimeSpanCell.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.TimeSpanCell.CanGrow = false;
            this.TimeSpanCell.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "time_span")});
            this.TimeSpanCell.Dpi = 254F;
            this.TimeSpanCell.LocationFloat = new DevExpress.Utils.PointFloat(1806.227F, 0F);
            this.TimeSpanCell.Name = "TimeSpanCell";
            this.TimeSpanCell.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.TimeSpanCell.SizeF = new System.Drawing.SizeF(246.0092F, 58.29158F);
            this.TimeSpanCell.StylePriority.UseBackColor = false;
            this.TimeSpanCell.StylePriority.UseBorders = false;
            this.TimeSpanCell.StylePriority.UsePadding = false;
            this.TimeSpanCell.StylePriority.UseTextAlignment = false;
            this.TimeSpanCell.Text = "TimeSpanCell";
            this.TimeSpanCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.TimeSpanCell.WordWrap = false;
            // 
            // OtherCell
            // 
            this.OtherCell.AnchorHorizontal = DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left;
            this.OtherCell.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.OtherCell.BackColor = System.Drawing.Color.Transparent;
            this.OtherCell.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.OtherCell.CanGrow = false;
            this.OtherCell.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "other")});
            this.OtherCell.Dpi = 254F;
            this.OtherCell.LocationFloat = new DevExpress.Utils.PointFloat(2052.237F, 0F);
            this.OtherCell.Name = "OtherCell";
            this.OtherCell.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.OtherCell.SizeF = new System.Drawing.SizeF(513.8506F, 58.29158F);
            this.OtherCell.StylePriority.UseBackColor = false;
            this.OtherCell.StylePriority.UseBorders = false;
            this.OtherCell.StylePriority.UsePadding = false;
            this.OtherCell.StylePriority.UseTextAlignment = false;
            this.OtherCell.Text = "OtherCell";
            this.OtherCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // groupHeaderBand1
            // 
            this.groupHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table2,
            this.xrTable1,
            this.table4});
            this.groupHeaderBand1.Dpi = 254F;
            this.groupHeaderBand1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("date", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.groupHeaderBand1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.groupHeaderBand1.HeightF = 64F;
            this.groupHeaderBand1.Name = "groupHeaderBand1";
            this.groupHeaderBand1.StyleName = "ReportGroupHeaderBandStyle";
            // 
            // table2
            // 
            this.table2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.table2.Dpi = 254F;
            this.table2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.table2.Name = "table2";
            this.table2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow2});
            this.table2.SizeF = new System.Drawing.SizeF(1806.224F, 64F);
            this.table2.StylePriority.UseBackColor = false;
            // 
            // tableRow2
            // 
            this.tableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell7,
            this.tableCell8});
            this.tableRow2.Dpi = 254F;
            this.tableRow2.Name = "tableRow2";
            this.tableRow2.Weight = 10.46953028649871D;
            // 
            // tableCell7
            // 
            this.tableCell7.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tableCell7.Dpi = 254F;
            this.tableCell7.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.tableCell7.Name = "tableCell7";
            this.tableCell7.StylePriority.UseFont = false;
            this.tableCell7.Text = "Дата:";
            this.tableCell7.Weight = 0.14312824765458646D;
            this.tableCell7.WordWrap = false;
            // 
            // tableCell8
            // 
            this.tableCell8.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tableCell8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "date", "{0:d}")});
            this.tableCell8.Dpi = 254F;
            this.tableCell8.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Italic);
            this.tableCell8.Name = "tableCell8";
            this.tableCell8.StylePriority.UseBorders = false;
            this.tableCell8.StylePriority.UseFont = false;
            this.tableCell8.Weight = 1.8675891516370871D;
            this.tableCell8.WordWrap = false;
            // 
            // xrTable1
            // 
            this.xrTable1.Dpi = 254F;
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(2364.445F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(427.5547F, 64F);
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1});
            this.xrTableRow1.Dpi = 254F;
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 10.46953028649871D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.xrTableCell1.BorderColor = System.Drawing.Color.Black;
            this.xrTableCell1.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "payment")});
            this.xrTableCell1.Dpi = 254F;
            this.xrTableCell1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96F);
            this.xrTableCell1.StylePriority.UseBackColor = false;
            this.xrTableCell1.StylePriority.UseBorderColor = false;
            this.xrTableCell1.StylePriority.UseBorders = false;
            this.xrTableCell1.StylePriority.UseFont = false;
            xrSummary5.FormatString = "К оплате: {0}";
            xrSummary5.IgnoreNullValues = true;
            xrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrTableCell1.Summary = xrSummary5;
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell1.Weight = 0.34782243285035996D;
            this.xrTableCell1.WordWrap = false;
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
            // pageHeaderBand1
            // 
            this.pageHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1,
            this.xrLabel8,
            this.xrLabel21,
            this.xrLabel2,
            this.xrLabel3,
            this.xrLabel4,
            this.xrLabel5,
            this.xrLabel6});
            this.pageHeaderBand1.Dpi = 254F;
            this.pageHeaderBand1.HeightF = 121.7293F;
            this.pageHeaderBand1.Name = "pageHeaderBand1";
            this.pageHeaderBand1.StyleName = "ReportHeaderBandStyle";
            // 
            // xrLabel1
            // 
            this.xrLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(218)))), ((int)(((byte)(251)))));
            this.xrLabel1.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel1.Dpi = 254F;
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(2566.088F, 0.0001441864F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(225.9114F, 121.7292F);
            this.xrLabel1.StylePriority.UseBackColor = false;
            this.xrLabel1.StylePriority.UseBorders = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UsePadding = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "Оплата";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel8
            // 
            this.xrLabel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(218)))), ((int)(((byte)(251)))));
            this.xrLabel8.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel8.CanGrow = false;
            this.xrLabel8.Dpi = 254F;
            this.xrLabel8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(817.5123F, 0F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(554.8959F, 121.7293F);
            this.xrLabel8.StylePriority.UseBackColor = false;
            this.xrLabel8.StylePriority.UseBorders = false;
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UsePadding = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "Наименование технологической оснастки";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel21
            // 
            this.xrLabel21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(218)))), ((int)(((byte)(251)))));
            this.xrLabel21.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel21.Dpi = 254F;
            this.xrLabel21.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(576.7413F, 0F);
            this.xrLabel21.Name = "xrLabel21";
            this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel21.SizeF = new System.Drawing.SizeF(240.771F, 121.7292F);
            this.xrLabel21.StylePriority.UseBackColor = false;
            this.xrLabel21.StylePriority.UseBorders = false;
            this.xrLabel21.StylePriority.UseFont = false;
            this.xrLabel21.StylePriority.UsePadding = false;
            this.xrLabel21.StylePriority.UseTextAlignment = false;
            this.xrLabel21.Text = "№ тех. оснастки";
            this.xrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel2
            // 
            this.xrLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(218)))), ((int)(((byte)(251)))));
            this.xrLabel2.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel2.Dpi = 254F;
            this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(576.7413F, 121.7292F);
            this.xrLabel2.StylePriority.UseBackColor = false;
            this.xrLabel2.StylePriority.UseBorders = false;
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UsePadding = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "Вид работ";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel3
            // 
            this.xrLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(218)))), ((int)(((byte)(251)))));
            this.xrLabel3.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel3.Dpi = 254F;
            this.xrLabel3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(1372.408F, 0F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(208.9707F, 121.7292F);
            this.xrLabel3.StylePriority.UseBackColor = false;
            this.xrLabel3.StylePriority.UseBorders = false;
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UsePadding = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "Время начала";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel4
            // 
            this.xrLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(218)))), ((int)(((byte)(251)))));
            this.xrLabel4.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel4.Dpi = 254F;
            this.xrLabel4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(1581.379F, 0F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(224.8458F, 121.7292F);
            this.xrLabel4.StylePriority.UseBackColor = false;
            this.xrLabel4.StylePriority.UseBorders = false;
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UsePadding = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "Время окончания";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel5
            // 
            this.xrLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(218)))), ((int)(((byte)(251)))));
            this.xrLabel5.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel5.Dpi = 254F;
            this.xrLabel5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(1806.227F, 0F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(246.0093F, 121.7292F);
            this.xrLabel5.StylePriority.UseBackColor = false;
            this.xrLabel5.StylePriority.UseBorders = false;
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UsePadding = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "Времени всего";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel6
            // 
            this.xrLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(218)))), ((int)(((byte)(251)))));
            this.xrLabel6.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel6.Dpi = 254F;
            this.xrLabel6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(2052.237F, 0F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(513.8506F, 121.7292F);
            this.xrLabel6.StylePriority.UseBackColor = false;
            this.xrLabel6.StylePriority.UseBorders = false;
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UsePadding = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "Примечание";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.Dpi = 254F;
            this.bottomMarginBand1.HeightF = 172.5896F;
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            // 
            // ReportGroupHeaderBandStyle
            // 
            this.ReportGroupHeaderBandStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.ReportGroupHeaderBandStyle.Name = "ReportGroupHeaderBandStyle";
            this.ReportGroupHeaderBandStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 0, 0, 0, 254F);
            this.ReportGroupHeaderBandStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // totalBindingSource
            // 
            this.totalBindingSource.DataMember = "total";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.TitleLabel,
            this.xrLabel23,
            this.xrLabel22});
            this.ReportHeader.Dpi = 254F;
            this.ReportHeader.HeightF = 329.0834F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // TitleLabel
            // 
            this.TitleLabel.Dpi = 254F;
            this.TitleLabel.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.TitleLabel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 139.8792F);
            this.TitleLabel.Multiline = true;
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.TitleLabel.SizeF = new System.Drawing.SizeF(2792F, 189.2042F);
            this.TitleLabel.StylePriority.UseFont = false;
            this.TitleLabel.StylePriority.UseTextAlignment = false;
            this.TitleLabel.Text = "Расценки стоимости выполненых работ";
            this.TitleLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel23
            // 
            this.xrLabel23.CanGrow = false;
            this.xrLabel23.Dpi = 254F;
            this.xrLabel23.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(2078.021F, 80.64592F);
            this.xrLabel23.Multiline = true;
            this.xrLabel23.Name = "xrLabel23";
            this.xrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel23.SizeF = new System.Drawing.SizeF(713.9792F, 59.23326F);
            this.xrLabel23.StylePriority.UseFont = false;
            this.xrLabel23.StylePriority.UseTextAlignment = false;
            this.xrLabel23.Text = "Кивака П.П. ________________\r\n";
            this.xrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // xrLabel22
            // 
            this.xrLabel22.CanGrow = false;
            this.xrLabel22.Dpi = 254F;
            this.xrLabel22.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(2078.021F, 0F);
            this.xrLabel22.Multiline = true;
            this.xrLabel22.Name = "xrLabel22";
            this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel22.SizeF = new System.Drawing.SizeF(713.9792F, 80.64592F);
            this.xrLabel22.StylePriority.UseFont = false;
            this.xrLabel22.StylePriority.UseTextAlignment = false;
            this.xrLabel22.Text = "Утверждаю:\r\nЗам. директора по производству";
            this.xrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ReportDatePayment
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.pageHeaderBand1,
            this.groupHeaderBand1,
            this.detailBand1,
            this.reportFooterBand1,
            this.bottomMarginBand1,
            this.ReportHeader});
            this.Dpi = 254F;
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(101, 77, 189, 173);
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
            this.Version = "18.1";
            ((System.ComponentModel.ISupportInitialize)(this.table5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        private void tableCell19_SummaryRowChanged(object sender, EventArgs e)
        {
            string w = System.Convert.ToString(GetCurrentColumnValue("time_span"));
            ts += System.TimeSpan.Parse(w);
        }

        private void tableCell19_SummaryReset(object sender, EventArgs e)
        {
            ts = new System.TimeSpan(00, 00, 00);
        }

        private void tableCell25_SummaryRowChanged(object sender, EventArgs e)
        {
            string w = System.Convert.ToString(GetCurrentColumnValue("time_span"));
            ts1 += System.TimeSpan.Parse(w);
        }

        private void tableCell25_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
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

        private void tableCell19_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
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
