
using System;


namespace JoobTime
{
    public class report_work_subunit : DevExpress.XtraReports.UI.XtraReport
    {

        public System.TimeSpan ts;
        public System.TimeSpan ts1;

        private DevExpress.XtraReports.UI.DetailBand detailBand1;
        private DevExpress.XtraReports.UI.XRTable table2;
        private DevExpress.XtraReports.UI.XRTableRow tableRow2;
        private DevExpress.XtraReports.UI.XRTableCell tableCell7;
        private DevExpress.XtraReports.UI.XRTableCell tableCell8;
        private DevExpress.XtraReports.UI.XRControlStyle ReportGroupFooterBandStyle;
        private DevExpress.XtraReports.UI.GroupHeaderBand groupHeaderBand1;
        private DevExpress.XtraReports.UI.XRControlStyle ReportEvenStyle;
        private DevExpress.XtraReports.UI.XRControlStyle ReportHeaderBandStyle;
        private DevExpress.XtraReports.UI.XRControlStyle ReportOddStyle;
        private DevExpress.XtraReports.UI.XRControlStyle ReportGroupHeaderBandStyle;
        private DevExpress.XtraReports.UI.XRControlStyle ReportDetailBandStyle;
        private DevExpress.XtraReports.UI.ReportFooterBand reportFooterBand1;
        private DevExpress.XtraReports.UI.PageHeaderBand pageHeaderBand1;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private DevExpress.XtraReports.UI.XRControlStyle ReportFooterBandStyle;
        private DevExpress.XtraReports.UI.GroupFooterBand groupFooterBand1;
        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        //private _1.DB1DataSetTableAdapters.totalTableAdapter totalTableAdapter;
        private System.Windows.Forms.BindingSource totalBindingSource;
        private System.ComponentModel.IContainer components;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRLabel xrLabel14;
        private DevExpress.XtraReports.UI.XRLabel xrLabel15;
        private DevExpress.XtraReports.UI.XRLabel xrLabel17;
        private DevExpress.XtraReports.UI.XRLabel xrLabel18;
        private DevExpress.XtraReports.UI.XRLabel xrLabel19;
        private DevExpress.XtraReports.UI.XRLabel xrLabel20;
        private DevExpress.XtraReports.UI.XRLabel xrLabel21;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLabel xrLabel22;
        private DevExpress.XtraReports.UI.XRLabel xrLabel13;
        private DevExpress.XtraReports.UI.XRLabel OverWorkTime;
        private DevExpress.XtraReports.UI.XRLabel xrLabel11;
        private DevExpress.XtraReports.UI.XRLabel WorkTime;
        private DevExpress.XtraReports.UI.XRPanel xrPanel1;
        private DevExpress.XtraReports.UI.XRPanel xrPanel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        //private _1.DB1DataSet dB1DataSet;

       // [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public report_work_subunit(string workTiming)
        {
            
            InitializeComponent();

            xrLabel14.Text = "Отчет по виду работ за период с " +
                             Convert.ToDateTime(ReportGenerating.startDate).ToShortDateString() + " по " +
                             Convert.ToDateTime(ReportGenerating.endDate).ToShortDateString() + "\n" +
                             ReportGenerating.subunit_for_report + " " +
                             ReportGenerating.fio_for_report;
            WorkTime.Text = workTiming;

        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary4 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery2 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table3 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery3 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column5 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table4 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery4 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column7 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression7 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table5 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column8 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression8 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery5 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column9 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression9 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table6 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column10 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression10 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column11 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression11 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column12 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression12 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column13 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression13 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery6 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column14 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression14 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table7 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column15 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression15 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column16 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression16 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column17 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression17 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column18 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression18 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column19 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression19 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column20 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression20 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column21 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression21 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column22 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression22 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column23 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression23 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column24 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression24 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column25 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression25 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column26 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression26 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column27 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression27 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column28 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression28 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column29 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression29 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery7 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column30 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression30 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table8 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column31 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression31 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column32 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression32 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery8 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column33 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression33 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table9 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column34 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression34 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column35 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression35 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column36 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression36 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column37 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression37 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column38 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression38 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column39 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression39 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column40 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression40 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column41 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression41 = new DevExpress.DataAccess.Sql.ColumnExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(report_work_subunit));
            this.detailBand1 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
            this.table2 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.ReportGroupFooterBandStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.groupHeaderBand1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportEvenStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.ReportHeaderBandStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.ReportOddStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.ReportGroupHeaderBandStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.ReportDetailBandStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.reportFooterBand1 = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.OverWorkTime = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.WorkTime = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.pageHeaderBand1 = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportFooterBandStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.groupFooterBand1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.totalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.xrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrPanel2 = new DevExpress.XtraReports.UI.XRPanel();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // detailBand1
            // 
            this.detailBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel1,
            this.xrLabel2,
            this.xrLabel15,
            this.xrLabel17,
            this.xrLabel18,
            this.xrLabel19,
            this.xrPanel2});
            this.detailBand1.Dpi = 254F;
            this.detailBand1.EvenStyleName = "ReportEvenStyle";
            this.detailBand1.HeightF = 82F;
            this.detailBand1.KeepTogether = true;
            this.detailBand1.MultiColumn.ColumnCount = 5;
            this.detailBand1.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnWidth;
            this.detailBand1.Name = "detailBand1";
            this.detailBand1.OddStyleName = "ReportOddStyle";
            this.detailBand1.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("date", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending),
            new DevExpress.XtraReports.UI.GroupField("time_begin", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.detailBand1.StyleName = "ReportDetailBandStyle";
            // 
            // xrLabel22
            // 
            this.xrLabel22.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top;
            this.xrLabel22.BackColor = System.Drawing.Color.White;
            this.xrLabel22.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel22.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "name_form")});
            this.xrLabel22.Dpi = 254F;
            this.xrLabel22.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(0F, 3F);
            this.xrLabel22.Multiline = true;
            this.xrLabel22.Name = "xrLabel22";
            this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel22.SizeF = new System.Drawing.SizeF(566.1F, 78.69F);
            this.xrLabel22.StylePriority.UseBackColor = false;
            this.xrLabel22.StylePriority.UseBorders = false;
            this.xrLabel22.StylePriority.UseFont = false;
            this.xrLabel22.StylePriority.UsePadding = false;
            this.xrLabel22.StylePriority.UseTextAlignment = false;
            this.xrLabel22.Text = "xrLabel4";
            this.xrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel2
            // 
            this.xrLabel2.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.xrLabel2.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.xrLabel2.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel2.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel2.CanGrow = false;
            this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "form_id")});
            this.xrLabel2.Dpi = 254F;
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(260.9169F, 0F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(298.9794F, 81.99994F);
            this.xrLabel2.StylePriority.UseBackColor = false;
            this.xrLabel2.StylePriority.UseBorders = false;
            this.xrLabel2.StylePriority.UsePadding = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "xrLabel3";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrLabel2.WordWrap = false;
            // 
            // xrLabel15
            // 
            this.xrLabel15.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.xrLabel15.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.xrLabel15.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel15.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel15.CanGrow = false;
            this.xrLabel15.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "date", "{0:d}")});
            this.xrLabel15.Dpi = 254F;
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel15.Multiline = true;
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(260.9169F, 82F);
            this.xrLabel15.StylePriority.UseBackColor = false;
            this.xrLabel15.StylePriority.UseBorders = false;
            this.xrLabel15.StylePriority.UsePadding = false;
            this.xrLabel15.StylePriority.UseTextAlignment = false;
            this.xrLabel15.Text = "xrLabel15";
            this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrLabel15.WordWrap = false;
            // 
            // xrLabel17
            // 
            this.xrLabel17.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.xrLabel17.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.xrLabel17.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel17.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel17.CanGrow = false;
            this.xrLabel17.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "time_begin", "{0:t}")});
            this.xrLabel17.Dpi = 254F;
            this.xrLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(2078.421F, 0F);
            this.xrLabel17.Multiline = true;
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(240.72F, 82F);
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
            this.xrLabel18.AutoWidth = true;
            this.xrLabel18.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel18.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel18.CanGrow = false;
            this.xrLabel18.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "time_end", "{0:t}")});
            this.xrLabel18.Dpi = 254F;
            this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(2319.141F, 0F);
            this.xrLabel18.Multiline = true;
            this.xrLabel18.Name = "xrLabel18";
            this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel18.SizeF = new System.Drawing.SizeF(238.0753F, 82F);
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
            this.xrLabel19.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel19.CanGrow = false;
            this.xrLabel19.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "time_span")});
            this.xrLabel19.Dpi = 254F;
            this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(2557.217F, 0F);
            this.xrLabel19.Multiline = true;
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel19.SizeF = new System.Drawing.SizeF(232.7834F, 82F);
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
            this.xrLabel20.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top;
            this.xrLabel20.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel20.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel20.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "other")});
            this.xrLabel20.Dpi = 254F;
            this.xrLabel20.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(0F, 3F);
            this.xrLabel20.Multiline = true;
            this.xrLabel20.Name = "xrLabel20";
            this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel20.SizeF = new System.Drawing.SizeF(947.1F, 78.69F);
            this.xrLabel20.StylePriority.UseBackColor = false;
            this.xrLabel20.StylePriority.UseBorders = false;
            this.xrLabel20.StylePriority.UseFont = false;
            this.xrLabel20.StylePriority.UsePadding = false;
            this.xrLabel20.StylePriority.UseTextAlignment = false;
            this.xrLabel20.Text = "xrLabel20";
            this.xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // table2
            // 
            this.table2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.table2.BorderColor = System.Drawing.Color.Black;
            this.table2.Dpi = 254F;
            this.table2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.table2.Name = "table2";
            this.table2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow2});
            this.table2.SizeF = new System.Drawing.SizeF(2094.196F, 64F);
            this.table2.StylePriority.UseBackColor = false;
            this.table2.StylePriority.UseBorderColor = false;
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
            this.tableCell7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tableCell7.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tableCell7.Dpi = 254F;
            this.tableCell7.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.tableCell7.Name = "tableCell7";
            this.tableCell7.StylePriority.UseBackColor = false;
            this.tableCell7.StylePriority.UseBorders = false;
            this.tableCell7.StylePriority.UseFont = false;
            this.tableCell7.Text = "Вид работ:";
            this.tableCell7.Weight = 0.26918297654468004D;
            this.tableCell7.WordWrap = false;
            // 
            // tableCell8
            // 
            this.tableCell8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tableCell8.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tableCell8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "work")});
            this.tableCell8.Dpi = 254F;
            this.tableCell8.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Italic);
            this.tableCell8.Name = "tableCell8";
            this.tableCell8.StylePriority.UseBackColor = false;
            this.tableCell8.StylePriority.UseBorders = false;
            this.tableCell8.StylePriority.UseFont = false;
            this.tableCell8.Weight = 1.891359656263963D;
            this.tableCell8.Multiline = true;
            this.tableCell8.WordWrap = true;
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
            // groupHeaderBand1
            // 
            this.groupHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table2,
            this.xrLabel8});
            this.groupHeaderBand1.Dpi = 254F;
            this.groupHeaderBand1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("work", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.groupHeaderBand1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.groupHeaderBand1.HeightF = 64F;
            this.groupHeaderBand1.Name = "groupHeaderBand1";
            this.groupHeaderBand1.StyleName = "ReportGroupHeaderBandStyle";
            // 
            // xrLabel8
            // 
            this.xrLabel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.xrLabel8.BorderColor = System.Drawing.Color.Black;
            this.xrLabel8.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel8.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "time_span")});
            this.xrLabel8.Dpi = 254F;
            this.xrLabel8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(2094.196F, 0F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(695.8044F, 64F);
            this.xrLabel8.StylePriority.UseBackColor = false;
            this.xrLabel8.StylePriority.UseBorderColor = false;
            this.xrLabel8.StylePriority.UseBorderDashStyle = false;
            this.xrLabel8.StylePriority.UseBorders = false;
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseForeColor = false;
            this.xrLabel8.StylePriority.UsePadding = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            xrSummary1.FormatString = "Всего: {0}";
            xrSummary1.IgnoreNullValues = true;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel8.Summary = xrSummary1;
            this.xrLabel8.Text = "xrLabel8";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrLabel8.WordWrap = false;
            this.xrLabel8.SummaryGetResult += new DevExpress.XtraReports.UI.SummaryGetResultHandler(this.xrLabel8_SummaryGetResult);
            this.xrLabel8.SummaryReset += new System.EventHandler(this.xrLabel8_SummaryReset);
            this.xrLabel8.SummaryRowChanged += new System.EventHandler(this.xrLabel8_SummaryRowChanged);
            // 
            // ReportEvenStyle
            // 
            this.ReportEvenStyle.BackColor = System.Drawing.Color.Transparent;
            this.ReportEvenStyle.Name = "ReportEvenStyle";
            this.ReportEvenStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 254F);
            this.ReportEvenStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // ReportHeaderBandStyle
            // 
            this.ReportHeaderBandStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.ReportHeaderBandStyle.Name = "ReportHeaderBandStyle";
            this.ReportHeaderBandStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 254F);
            this.ReportHeaderBandStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // ReportOddStyle
            // 
            this.ReportOddStyle.BackColor = System.Drawing.Color.Transparent;
            this.ReportOddStyle.Name = "ReportOddStyle";
            this.ReportOddStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 254F);
            this.ReportOddStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // ReportGroupHeaderBandStyle
            // 
            this.ReportGroupHeaderBandStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.ReportGroupHeaderBandStyle.Name = "ReportGroupHeaderBandStyle";
            this.ReportGroupHeaderBandStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 0, 0, 0, 254F);
            this.ReportGroupHeaderBandStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // ReportDetailBandStyle
            // 
            this.ReportDetailBandStyle.BackColor = System.Drawing.Color.Transparent;
            this.ReportDetailBandStyle.Name = "ReportDetailBandStyle";
            this.ReportDetailBandStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 254F);
            this.ReportDetailBandStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // reportFooterBand1
            // 
            this.reportFooterBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel13,
            this.OverWorkTime,
            this.xrLabel11,
            this.WorkTime,
            this.xrLabel10,
            this.xrLabel7});
            this.reportFooterBand1.Dpi = 254F;
            this.reportFooterBand1.HeightF = 193.6458F;
            this.reportFooterBand1.Name = "reportFooterBand1";
            this.reportFooterBand1.StyleName = "ReportFooterBandStyle";
            // 
            // xrLabel13
            // 
            this.xrLabel13.BackColor = System.Drawing.Color.White;
            this.xrLabel13.Dpi = 254F;
            this.xrLabel13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(1779.341F, 127.9999F);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(777.8753F, 63.99997F);
            this.xrLabel13.StylePriority.UseBackColor = false;
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.StylePriority.UseTextAlignment = false;
            this.xrLabel13.Text = "Переработка, часов:";
            this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // OverWorkTime
            // 
            this.OverWorkTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.OverWorkTime.BorderColor = System.Drawing.Color.Red;
            this.OverWorkTime.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.OverWorkTime.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.OverWorkTime.Dpi = 254F;
            this.OverWorkTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.OverWorkTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.OverWorkTime.LocationFloat = new DevExpress.Utils.PointFloat(2557.217F, 129.6458F);
            this.OverWorkTime.Name = "OverWorkTime";
            this.OverWorkTime.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.OverWorkTime.SizeF = new System.Drawing.SizeF(232.7834F, 64F);
            this.OverWorkTime.StylePriority.UseBackColor = false;
            this.OverWorkTime.StylePriority.UseBorderColor = false;
            this.OverWorkTime.StylePriority.UseBorderDashStyle = false;
            this.OverWorkTime.StylePriority.UseBorders = false;
            this.OverWorkTime.StylePriority.UseFont = false;
            this.OverWorkTime.StylePriority.UseForeColor = false;
            this.OverWorkTime.StylePriority.UsePadding = false;
            this.OverWorkTime.StylePriority.UseTextAlignment = false;
            xrSummary2.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom;
            this.OverWorkTime.Summary = xrSummary2;
            this.OverWorkTime.Text = "15:30";
            this.OverWorkTime.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.OverWorkTime.WordWrap = false;
            this.OverWorkTime.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.OverWorkTime_BeforePrint);
            this.OverWorkTime.AfterPrint += new System.EventHandler(this.OverWorkTime_AfterPrint);
            this.OverWorkTime.PrintOnPage += new DevExpress.XtraReports.UI.PrintOnPageEventHandler(this.OverWorkTime_PrintOnPage);
            this.OverWorkTime.Draw += new DevExpress.XtraReports.UI.DrawEventHandler(this.OverWorkTime_Draw);
            // 
            // xrLabel11
            // 
            this.xrLabel11.BackColor = System.Drawing.Color.White;
            this.xrLabel11.Dpi = 254F;
            this.xrLabel11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(1779.341F, 63.99997F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(777.8753F, 63.99997F);
            this.xrLabel11.StylePriority.UseBackColor = false;
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.StylePriority.UseTextAlignment = false;
            this.xrLabel11.Text = "Количество рабочих часов по табелю:";
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // WorkTime
            // 
            this.WorkTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.WorkTime.BorderColor = System.Drawing.Color.Red;
            this.WorkTime.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.WorkTime.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.WorkTime.Dpi = 254F;
            this.WorkTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.WorkTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WorkTime.LocationFloat = new DevExpress.Utils.PointFloat(2557.217F, 63.99997F);
            this.WorkTime.Name = "WorkTime";
            this.WorkTime.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.WorkTime.SizeF = new System.Drawing.SizeF(232.7834F, 64F);
            this.WorkTime.StylePriority.UseBackColor = false;
            this.WorkTime.StylePriority.UseBorderColor = false;
            this.WorkTime.StylePriority.UseBorderDashStyle = false;
            this.WorkTime.StylePriority.UseBorders = false;
            this.WorkTime.StylePriority.UseFont = false;
            this.WorkTime.StylePriority.UseForeColor = false;
            this.WorkTime.StylePriority.UsePadding = false;
            this.WorkTime.StylePriority.UseTextAlignment = false;
            xrSummary3.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom;
            this.WorkTime.Summary = xrSummary3;
            this.WorkTime.Text = "12:30";
            this.WorkTime.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.WorkTime.WordWrap = false;
            this.WorkTime.PrintOnPage += new DevExpress.XtraReports.UI.PrintOnPageEventHandler(this.WorkTime_PrintOnPage);
            // 
            // xrLabel10
            // 
            this.xrLabel10.BackColor = System.Drawing.Color.White;
            this.xrLabel10.Dpi = 254F;
            this.xrLabel10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(1779.341F, 0F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(777.8753F, 63.99997F);
            this.xrLabel10.StylePriority.UseBackColor = false;
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.StylePriority.UseTextAlignment = false;
            this.xrLabel10.Text = "Итого отработано за месяц:";
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel7
            // 
            this.xrLabel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.xrLabel7.BorderColor = System.Drawing.Color.Red;
            this.xrLabel7.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel7.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "time_span")});
            this.xrLabel7.Dpi = 254F;
            this.xrLabel7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(2557.217F, 0F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(232.7834F, 64F);
            this.xrLabel7.StylePriority.UseBackColor = false;
            this.xrLabel7.StylePriority.UseBorderColor = false;
            this.xrLabel7.StylePriority.UseBorderDashStyle = false;
            this.xrLabel7.StylePriority.UseBorders = false;
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseForeColor = false;
            this.xrLabel7.StylePriority.UsePadding = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            xrSummary4.FormatString = "{0:HHHH:mm}";
            xrSummary4.IgnoreNullValues = true;
            xrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrLabel7.Summary = xrSummary4;
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrLabel7.WordWrap = false;
            this.xrLabel7.SummaryGetResult += new DevExpress.XtraReports.UI.SummaryGetResultHandler(this.xrLabel7_SummaryGetResult);
            this.xrLabel7.SummaryRowChanged += new System.EventHandler(this.xrLabel7_SummaryRowChanged);
            // 
            // pageHeaderBand1
            // 
            this.pageHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel9,
            this.xrLabel1,
            this.xrLabel3,
            this.xrLabel4,
            this.xrLabel5,
            this.xrLabel6,
            this.xrLabel21});
            this.pageHeaderBand1.Dpi = 254F;
            this.pageHeaderBand1.HeightF = 114.2708F;
            this.pageHeaderBand1.Name = "pageHeaderBand1";
            this.pageHeaderBand1.StyleName = "ReportHeaderBandStyle";
            // 
            // xrLabel9
            // 
            this.xrLabel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(218)))), ((int)(((byte)(251)))));
            this.xrLabel9.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel9.Dpi = 254F;
            this.xrLabel9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(559.8961F, 0F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(568.7707F, 114.2708F);
            this.xrLabel9.StylePriority.UseBackColor = false;
            this.xrLabel9.StylePriority.UseBorders = false;
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UsePadding = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.Text = "Наименование технологической оснастки";
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
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
            this.xrLabel1.SizeF = new System.Drawing.SizeF(260.9167F, 114.2708F);
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
            this.xrLabel3.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel3.Dpi = 254F;
            this.xrLabel3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(2078.421F, 0F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(240.7203F, 114.2708F);
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
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(2319.141F, 0F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(238.0754F, 114.2708F);
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
            this.xrLabel5.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel5.Dpi = 254F;
            this.xrLabel5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(2557.217F, 0F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(232.7833F, 114.2708F);
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
            this.xrLabel6.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel6.Dpi = 254F;
            this.xrLabel6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(1128.667F, 0F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(949.754F, 114.2708F);
            this.xrLabel6.StylePriority.UseBackColor = false;
            this.xrLabel6.StylePriority.UseBorders = false;
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UsePadding = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "Дополнительная информация";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel21
            // 
            this.xrLabel21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(218)))), ((int)(((byte)(251)))));
            this.xrLabel21.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel21.Dpi = 254F;
            this.xrLabel21.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(260.9167F, 0F);
            this.xrLabel21.Name = "xrLabel21";
            this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel21.SizeF = new System.Drawing.SizeF(298.9793F, 114.2708F);
            this.xrLabel21.StylePriority.UseBackColor = false;
            this.xrLabel21.StylePriority.UseBorders = false;
            this.xrLabel21.StylePriority.UseFont = false;
            this.xrLabel21.StylePriority.UsePadding = false;
            this.xrLabel21.StylePriority.UseTextAlignment = false;
            this.xrLabel21.Text = "Пресс-форма";
            this.xrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.Dpi = 254F;
            this.bottomMarginBand1.HeightF = 220.5834F;
            this.bottomMarginBand1.Name = "bottomMarginBand1";
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
            // groupFooterBand1
            // 
            this.groupFooterBand1.Dpi = 254F;
            this.groupFooterBand1.HeightF = 0F;
            this.groupFooterBand1.Name = "groupFooterBand1";
            this.groupFooterBand1.StyleName = "ReportGroupFooterBandStyle";
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel14});
            this.topMarginBand1.Dpi = 254F;
            this.topMarginBand1.HeightF = 318.0834F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // xrLabel14
            // 
            this.xrLabel14.Dpi = 254F;
            this.xrLabel14.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(0F, 152.9375F);
            this.xrLabel14.Multiline = true;
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(2790F, 165.1459F);
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.StylePriority.UseTextAlignment = false;
            this.xrLabel14.Text = "Отчет по виду работ за период с";
            this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // totalBindingSource
            // 
            this.totalBindingSource.DataMember = "total";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "kbpolesie401\\tig_srv.DB1.dbo";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "id_tn";
            table1.Name = "catalog_position";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "subunit";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Name = "catalog_position";
            selectQuery1.Tables.Add(table1);
            columnExpression3.ColumnName = "id_position";
            table3.Name = "Position";
            columnExpression3.Table = table3;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "position";
            columnExpression4.Table = table3;
            column4.Expression = columnExpression4;
            selectQuery2.Columns.Add(column3);
            selectQuery2.Columns.Add(column4);
            selectQuery2.Name = "Position";
            selectQuery2.Tables.Add(table3);
            columnExpression5.ColumnName = "id";
            table4.Name = "pres_form";
            columnExpression5.Table = table4;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "name_form";
            columnExpression6.Table = table4;
            column6.Expression = columnExpression6;
            selectQuery3.Columns.Add(column5);
            selectQuery3.Columns.Add(column6);
            selectQuery3.Name = "pres_form";
            selectQuery3.Tables.Add(table4);
            columnExpression7.ColumnName = "id_subunit";
            table5.Name = "subunit";
            columnExpression7.Table = table5;
            column7.Expression = columnExpression7;
            columnExpression8.ColumnName = "subunit";
            columnExpression8.Table = table5;
            column8.Expression = columnExpression8;
            selectQuery4.Columns.Add(column7);
            selectQuery4.Columns.Add(column8);
            selectQuery4.Name = "subunit";
            selectQuery4.Tables.Add(table5);
            columnExpression9.ColumnName = "name";
            table6.Name = "sysdiagrams";
            columnExpression9.Table = table6;
            column9.Expression = columnExpression9;
            columnExpression10.ColumnName = "principal_id";
            columnExpression10.Table = table6;
            column10.Expression = columnExpression10;
            columnExpression11.ColumnName = "diagram_id";
            columnExpression11.Table = table6;
            column11.Expression = columnExpression11;
            columnExpression12.ColumnName = "version";
            columnExpression12.Table = table6;
            column12.Expression = columnExpression12;
            columnExpression13.ColumnName = "definition";
            columnExpression13.Table = table6;
            column13.Expression = columnExpression13;
            selectQuery5.Columns.Add(column9);
            selectQuery5.Columns.Add(column10);
            selectQuery5.Columns.Add(column11);
            selectQuery5.Columns.Add(column12);
            selectQuery5.Columns.Add(column13);
            selectQuery5.Name = "sysdiagrams";
            selectQuery5.Tables.Add(table6);
            columnExpression14.ColumnName = "id";
            table7.Name = "total";
            columnExpression14.Table = table7;
            column14.Expression = columnExpression14;
            columnExpression15.ColumnName = "FIO";
            columnExpression15.Table = table7;
            column15.Expression = columnExpression15;
            columnExpression16.ColumnName = "position";
            columnExpression16.Table = table7;
            column16.Expression = columnExpression16;
            columnExpression17.ColumnName = "subunit";
            columnExpression17.Table = table7;
            column17.Expression = columnExpression17;
            columnExpression18.ColumnName = "id_work";
            columnExpression18.Table = table7;
            column18.Expression = columnExpression18;
            columnExpression19.ColumnName = "work";
            columnExpression19.Table = table7;
            column19.Expression = columnExpression19;
            columnExpression20.ColumnName = "date";
            columnExpression20.Table = table7;
            column20.Expression = columnExpression20;
            columnExpression21.ColumnName = "time_begin";
            columnExpression21.Table = table7;
            column21.Expression = columnExpression21;
            columnExpression22.ColumnName = "time_end";
            columnExpression22.Table = table7;
            column22.Expression = columnExpression22;
            columnExpression23.ColumnName = "other";
            columnExpression23.Table = table7;
            column23.Expression = columnExpression23;
            columnExpression24.ColumnName = "add_time";
            columnExpression24.Table = table7;
            column24.Expression = columnExpression24;
            columnExpression25.ColumnName = "id_tn";
            columnExpression25.Table = table7;
            column25.Expression = columnExpression25;
            columnExpression26.ColumnName = "time_span";
            columnExpression26.Table = table7;
            column26.Expression = columnExpression26;
            columnExpression27.ColumnName = "form_id";
            columnExpression27.Table = table7;
            column27.Expression = columnExpression27;
            columnExpression28.ColumnName = "name_form";
            columnExpression28.Table = table7;
            column28.Expression = columnExpression28;
            columnExpression29.ColumnName = "id_subunit_worker";
            columnExpression29.Table = table7;
            column29.Expression = columnExpression29;
            selectQuery6.Columns.Add(column14);
            selectQuery6.Columns.Add(column15);
            selectQuery6.Columns.Add(column16);
            selectQuery6.Columns.Add(column17);
            selectQuery6.Columns.Add(column18);
            selectQuery6.Columns.Add(column19);
            selectQuery6.Columns.Add(column20);
            selectQuery6.Columns.Add(column21);
            selectQuery6.Columns.Add(column22);
            selectQuery6.Columns.Add(column23);
            selectQuery6.Columns.Add(column24);
            selectQuery6.Columns.Add(column25);
            selectQuery6.Columns.Add(column26);
            selectQuery6.Columns.Add(column27);
            selectQuery6.Columns.Add(column28);
            selectQuery6.Columns.Add(column29);
            selectQuery6.Name = "total";
            selectQuery6.Tables.Add(table7);
            columnExpression30.ColumnName = "id_work";
            table8.Name = "work";
            columnExpression30.Table = table8;
            column30.Expression = columnExpression30;
            columnExpression31.ColumnName = "work";
            columnExpression31.Table = table8;
            column31.Expression = columnExpression31;
            columnExpression32.ColumnName = "id_position";
            columnExpression32.Table = table8;
            column32.Expression = columnExpression32;
            selectQuery7.Columns.Add(column30);
            selectQuery7.Columns.Add(column31);
            selectQuery7.Columns.Add(column32);
            selectQuery7.Name = "work";
            selectQuery7.Tables.Add(table8);
            columnExpression33.ColumnName = "id_tn";
            table9.Name = "worker";
            columnExpression33.Table = table9;
            column33.Expression = columnExpression33;
            columnExpression34.ColumnName = "Last_name";
            columnExpression34.Table = table9;
            column34.Expression = columnExpression34;
            columnExpression35.ColumnName = "First_name";
            columnExpression35.Table = table9;
            column35.Expression = columnExpression35;
            columnExpression36.ColumnName = "Second_name";
            columnExpression36.Table = table9;
            column36.Expression = columnExpression36;
            columnExpression37.ColumnName = "id_Position";
            columnExpression37.Table = table9;
            column37.Expression = columnExpression37;
            columnExpression38.ColumnName = "id_Subunit";
            columnExpression38.Table = table9;
            column38.Expression = columnExpression38;
            columnExpression39.ColumnName = "password";
            columnExpression39.Table = table9;
            column39.Expression = columnExpression39;
            columnExpression40.ColumnName = "status";
            columnExpression40.Table = table9;
            column40.Expression = columnExpression40;
            columnExpression41.ColumnName = "tab_nomer";
            columnExpression41.Table = table9;
            column41.Expression = columnExpression41;
            selectQuery8.Columns.Add(column33);
            selectQuery8.Columns.Add(column34);
            selectQuery8.Columns.Add(column35);
            selectQuery8.Columns.Add(column36);
            selectQuery8.Columns.Add(column37);
            selectQuery8.Columns.Add(column38);
            selectQuery8.Columns.Add(column39);
            selectQuery8.Columns.Add(column40);
            selectQuery8.Columns.Add(column41);
            selectQuery8.Name = "worker";
            selectQuery8.Tables.Add(table9);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1,
            selectQuery2,
            selectQuery3,
            selectQuery4,
            selectQuery5,
            selectQuery6,
            selectQuery7,
            selectQuery8});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // xrPanel1
            // 
            this.xrPanel1.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.xrPanel1.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrPanel1.CanGrow = false;
            this.xrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel22});
            this.xrPanel1.Dpi = 254F;
            this.xrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(559.8962F, 0F);
            this.xrPanel1.Name = "xrPanel1";
            this.xrPanel1.SizeF = new System.Drawing.SizeF(568.7704F, 82F);
            this.xrPanel1.StylePriority.UseBorders = false;
            // 
            // xrPanel2
            // 
            this.xrPanel2.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.xrPanel2.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrPanel2.CanGrow = false;
            this.xrPanel2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel20});
            this.xrPanel2.Dpi = 254F;
            this.xrPanel2.LocationFloat = new DevExpress.Utils.PointFloat(1128.667F, 0F);
            this.xrPanel2.Name = "xrPanel2";
            this.xrPanel2.SizeF = new System.Drawing.SizeF(949.7537F, 82F);
            this.xrPanel2.StylePriority.UseBorders = false;
            // 
            // report_work_subunit
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.pageHeaderBand1,
            this.groupHeaderBand1,
            this.detailBand1,
            this.groupFooterBand1,
            this.reportFooterBand1,
            this.bottomMarginBand1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.Dpi = 254F;
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(98, 82, 318, 221);
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
            ((System.ComponentModel.ISupportInitialize)(this.table2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        private void xrLabel8_SummaryRowChanged(object sender, System.EventArgs e)
        {
            string w = System.Convert.ToString(GetCurrentColumnValue("time_span"));
            ts += System.TimeSpan.Parse(w);
        }

        private void xrLabel8_SummaryGetResult(object sender, DevExpress.XtraReports.UI.SummaryGetResultEventArgs e)
        {
            string strin_f = ts.TotalHours.ToString();//(0,2) + ":" + ts.Minutes.ToString();
            string itog;
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

        private void xrLabel8_SummaryReset(object sender, System.EventArgs e)
        {
            ts = new System.TimeSpan(00, 00, 00);
        }

        private void xrLabel7_SummaryRowChanged(object sender, System.EventArgs e)
        {
            string w = System.Convert.ToString(GetCurrentColumnValue("time_span"));
            if (GetCurrentColumnValue("work").Equals("Отпуск"))
                return;
            ts1 += System.TimeSpan.Parse(w);
        }

        private void xrLabel7_SummaryGetResult(object sender, DevExpress.XtraReports.UI.SummaryGetResultEventArgs e)
        {
            string strin_f = ts1.TotalHours.ToString();//(0,2) + ":" + ts.Minutes.ToString();
            string itog;
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

        private void WorkTime_PrintOnPage(object sender, DevExpress.XtraReports.UI.PrintOnPageEventArgs e)
        {
        }

        private void OverWorkTime_PrintOnPage(object sender, DevExpress.XtraReports.UI.PrintOnPageEventArgs e)
        {
            var allTime = new TimeSpan(0, 0, 0, 0);
            var workTime = new TimeSpan(0, 0, 0, 0);
            var hours = Convert.ToInt32(Math.Floor(ts1.TotalHours));
            var minutes = Convert.ToInt32(ts1.Minutes);
            allTime=allTime.Add(TimeSpan.FromHours(hours))
                .Add(TimeSpan.FromMinutes(minutes));
            hours = Convert.ToInt32(WorkTime.Text.Split(':')[0]);
            minutes = Convert.ToInt32(WorkTime.Text.Split(':')[1]);
            workTime=workTime.Add(TimeSpan.FromHours(hours))
                .Add(TimeSpan.FromMinutes(minutes));
            var result = allTime - workTime;
            
            OverWorkTime.Text = Math.Floor(result.TotalHours) + ":" + (result.Minutes <= 9
                                    ? "0" + result.Minutes
                                    : result.Minutes.ToString());
        }

        private void OverWorkTime_AfterPrint(object sender, EventArgs e)
        {
        }

        private void OverWorkTime_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
        }

        private void OverWorkTime_Draw(object sender, DevExpress.XtraReports.UI.DrawEventArgs e)
        {

        }
    }
}
