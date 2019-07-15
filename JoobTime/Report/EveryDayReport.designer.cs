namespace JoobTime
{
    partial class EveryDayReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code
        public System.TimeSpan ts;
        public System.TimeSpan ts1;

        private DevExpress.XtraReports.UI.DetailBand detailBand1;
        private DevExpress.XtraReports.UI.XRControlStyle ReportGroupFooterBandStyle;
        private DevExpress.XtraReports.UI.XRControlStyle ReportEvenStyle;
        private DevExpress.XtraReports.UI.XRControlStyle ReportHeaderBandStyle;
        private DevExpress.XtraReports.UI.XRControlStyle ReportOddStyle;
        private DevExpress.XtraReports.UI.XRControlStyle ReportGroupHeaderBandStyle;
        private DevExpress.XtraReports.UI.XRControlStyle ReportDetailBandStyle;
        private DevExpress.XtraReports.UI.ReportFooterBand reportFooterBand1;
        private DevExpress.XtraReports.UI.PageHeaderBand pageHeaderBand1;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private DevExpress.XtraReports.UI.XRControlStyle ReportFooterBandStyle;
        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        //private _1.DB1DataSetTableAdapters.totalTableAdapter totalTableAdapter;
        private System.Windows.Forms.BindingSource totalBindingSource;
        private DevExpress.XtraReports.UI.XRLabel sumtimeCell;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel TitleLabel;
        private DevExpress.XtraReports.UI.XRLabel dateCell;
        private DevExpress.XtraReports.UI.XRLabel timeStartCell;
        private DevExpress.XtraReports.UI.XRLabel timeEndCell;
        private DevExpress.XtraReports.UI.XRLabel timeCell;
        private DevExpress.XtraReports.UI.XRLabel otherCell;
        private DevExpress.XtraReports.UI.XRLabel xrLabel21;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLabel nameformCell;
        private DevExpress.XtraReports.UI.XRLabel formCell;
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery2 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery3 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column5 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table3 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery4 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column7 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression7 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table4 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column8 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression8 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery5 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column9 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression9 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table5 = new DevExpress.DataAccess.Sql.Table();
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
            DevExpress.DataAccess.Sql.Table table6 = new DevExpress.DataAccess.Sql.Table();
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
            DevExpress.DataAccess.Sql.Table table7 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column31 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression31 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column32 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression32 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery8 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column33 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression33 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table8 = new DevExpress.DataAccess.Sql.Table();
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
            this.detailBand1 = new DevExpress.XtraReports.UI.DetailBand();
            this.nameformCell = new DevExpress.XtraReports.UI.XRLabel();
            this.workCell = new DevExpress.XtraReports.UI.XRLabel();
            this.otherCell = new DevExpress.XtraReports.UI.XRLabel();
            this.formCell = new DevExpress.XtraReports.UI.XRLabel();
            this.dateCell = new DevExpress.XtraReports.UI.XRLabel();
            this.timeStartCell = new DevExpress.XtraReports.UI.XRLabel();
            this.timeEndCell = new DevExpress.XtraReports.UI.XRLabel();
            this.timeCell = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportGroupFooterBandStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.ReportEvenStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.ReportHeaderBandStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.ReportOddStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.ReportGroupHeaderBandStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.ReportDetailBandStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.reportFooterBand1 = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.sumtimeCell = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.CreatedFIO = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
            this.GetFIO = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel25 = new DevExpress.XtraReports.UI.XRLabel();
            this.pageHeaderBand1 = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportFooterBandStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.TitleLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.totalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.xrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
            ((System.ComponentModel.ISupportInitialize)(this.totalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // detailBand1
            // 
            this.detailBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.nameformCell,
            this.workCell,
            this.otherCell,
            this.formCell,
            this.dateCell,
            this.timeStartCell,
            this.timeEndCell,
            this.timeCell});
            this.detailBand1.Dpi = 254F;
            this.detailBand1.EvenStyleName = "ReportEvenStyle";
            this.detailBand1.HeightF = 90.00002F;
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
            // nameformCell
            // 
            this.nameformCell.AnchorHorizontal = DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left;
            this.nameformCell.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.nameformCell.BackColor = System.Drawing.Color.White;
            this.nameformCell.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.nameformCell.CanGrow = false;
            this.nameformCell.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "name_form")});
            this.nameformCell.Dpi = 254F;
            this.nameformCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameformCell.LocationFloat = new DevExpress.Utils.PointFloat(495.644F, 0F);
            this.nameformCell.Multiline = true;
            this.nameformCell.Name = "nameformCell";
            this.nameformCell.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.nameformCell.SizeF = new System.Drawing.SizeF(617.1564F, 90.00002F);
            this.nameformCell.StylePriority.UseBackColor = false;
            this.nameformCell.StylePriority.UseBorders = false;
            this.nameformCell.StylePriority.UseFont = false;
            this.nameformCell.StylePriority.UsePadding = false;
            this.nameformCell.StylePriority.UseTextAlignment = false;
            this.nameformCell.Text = "xrLabel4";
            this.nameformCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // workCell
            // 
            this.workCell.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.workCell.BackColor = System.Drawing.Color.White;
            this.workCell.BorderColor = System.Drawing.Color.Black;
            this.workCell.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.workCell.CanGrow = false;
            this.workCell.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "work")});
            this.workCell.Dpi = 254F;
            this.workCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workCell.LocationFloat = new DevExpress.Utils.PointFloat(1112.8F, 0F);
            this.workCell.Multiline = true;
            this.workCell.Name = "workCell";
            this.workCell.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.workCell.SizeF = new System.Drawing.SizeF(487.22F, 90.00002F);
            this.workCell.StylePriority.UseBackColor = false;
            this.workCell.StylePriority.UseBorderColor = false;
            this.workCell.StylePriority.UseBorders = false;
            this.workCell.StylePriority.UseFont = false;
            this.workCell.StylePriority.UsePadding = false;
            this.workCell.StylePriority.UseTextAlignment = false;
            this.workCell.Text = "xrLabel4";
            this.workCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // otherCell
            // 
            this.otherCell.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top;
            this.otherCell.BackColor = System.Drawing.Color.Transparent;
            this.otherCell.BorderColor = System.Drawing.Color.Black;
            this.otherCell.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.otherCell.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "other")});
            this.otherCell.Dpi = 254F;
            this.otherCell.LocationFloat = new DevExpress.Utils.PointFloat(1600.02F, 0F);
            this.otherCell.Multiline = true;
            this.otherCell.Name = "otherCell";
            this.otherCell.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.otherCell.SizeF = new System.Drawing.SizeF(478.41F, 90F);
            this.otherCell.StylePriority.UseBackColor = false;
            this.otherCell.StylePriority.UseBorderColor = false;
            this.otherCell.StylePriority.UseBorders = false;
            this.otherCell.StylePriority.UsePadding = false;
            this.otherCell.StylePriority.UseTextAlignment = false;
            this.otherCell.Text = "other";
            this.otherCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // formCell
            // 
            this.formCell.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.formCell.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.formCell.BackColor = System.Drawing.Color.Transparent;
            this.formCell.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.formCell.CanGrow = false;
            this.formCell.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "form_id")});
            this.formCell.Dpi = 254F;
            this.formCell.LocationFloat = new DevExpress.Utils.PointFloat(260.92F, 0F);
            this.formCell.Multiline = true;
            this.formCell.Name = "formCell";
            this.formCell.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.formCell.SizeF = new System.Drawing.SizeF(234.724F, 90.00002F);
            this.formCell.StylePriority.UseBackColor = false;
            this.formCell.StylePriority.UseBorders = false;
            this.formCell.StylePriority.UsePadding = false;
            this.formCell.StylePriority.UseTextAlignment = false;
            this.formCell.Text = "xrLabel3";
            this.formCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.formCell.WordWrap = false;
            // 
            // dateCell
            // 
            this.dateCell.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.dateCell.BackColor = System.Drawing.Color.Transparent;
            this.dateCell.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.dateCell.CanGrow = false;
            this.dateCell.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "date", "{0:d}")});
            this.dateCell.Dpi = 254F;
            this.dateCell.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.dateCell.Multiline = true;
            this.dateCell.Name = "dateCell";
            this.dateCell.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.dateCell.SizeF = new System.Drawing.SizeF(260.92F, 90.00002F);
            this.dateCell.StylePriority.UseBackColor = false;
            this.dateCell.StylePriority.UseBorders = false;
            this.dateCell.StylePriority.UsePadding = false;
            this.dateCell.StylePriority.UseTextAlignment = false;
            this.dateCell.Text = "dateCell";
            this.dateCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.dateCell.WordWrap = false;
            // 
            // timeStartCell
            // 
            this.timeStartCell.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.timeStartCell.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.timeStartCell.BackColor = System.Drawing.Color.Transparent;
            this.timeStartCell.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.timeStartCell.CanGrow = false;
            this.timeStartCell.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "time_begin", "{0:t}")});
            this.timeStartCell.Dpi = 254F;
            this.timeStartCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.timeStartCell.LocationFloat = new DevExpress.Utils.PointFloat(2078.43F, 0F);
            this.timeStartCell.Multiline = true;
            this.timeStartCell.Name = "timeStartCell";
            this.timeStartCell.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.timeStartCell.SizeF = new System.Drawing.SizeF(240.72F, 90.00002F);
            this.timeStartCell.StylePriority.UseBackColor = false;
            this.timeStartCell.StylePriority.UseBorders = false;
            this.timeStartCell.StylePriority.UseForeColor = false;
            this.timeStartCell.StylePriority.UsePadding = false;
            this.timeStartCell.StylePriority.UseTextAlignment = false;
            this.timeStartCell.Text = "timeStartCell";
            this.timeStartCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.timeStartCell.WordWrap = false;
            // 
            // timeEndCell
            // 
            this.timeEndCell.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.timeEndCell.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.timeEndCell.AutoWidth = true;
            this.timeEndCell.BackColor = System.Drawing.Color.Transparent;
            this.timeEndCell.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.timeEndCell.CanGrow = false;
            this.timeEndCell.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "time_end", "{0:t}")});
            this.timeEndCell.Dpi = 254F;
            this.timeEndCell.LocationFloat = new DevExpress.Utils.PointFloat(2319.15F, 0F);
            this.timeEndCell.Multiline = true;
            this.timeEndCell.Name = "timeEndCell";
            this.timeEndCell.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.timeEndCell.SizeF = new System.Drawing.SizeF(238.08F, 90.00002F);
            this.timeEndCell.StylePriority.UseBackColor = false;
            this.timeEndCell.StylePriority.UseBorders = false;
            this.timeEndCell.StylePriority.UsePadding = false;
            this.timeEndCell.StylePriority.UseTextAlignment = false;
            this.timeEndCell.Text = "timeEndCell";
            this.timeEndCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.timeEndCell.WordWrap = false;
            // 
            // timeCell
            // 
            this.timeCell.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.timeCell.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.timeCell.BackColor = System.Drawing.Color.Transparent;
            this.timeCell.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.timeCell.CanGrow = false;
            this.timeCell.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "time_span")});
            this.timeCell.Dpi = 254F;
            this.timeCell.LocationFloat = new DevExpress.Utils.PointFloat(2557.23F, 0F);
            this.timeCell.Multiline = true;
            this.timeCell.Name = "timeCell";
            this.timeCell.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.timeCell.SizeF = new System.Drawing.SizeF(232.7703F, 90.00002F);
            this.timeCell.StylePriority.UseBackColor = false;
            this.timeCell.StylePriority.UseBorders = false;
            this.timeCell.StylePriority.UsePadding = false;
            this.timeCell.StylePriority.UseTextAlignment = false;
            this.timeCell.Text = "timeCell";
            this.timeCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.timeCell.WordWrap = false;
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
            this.xrPanel1,
            this.xrLabel10,
            this.sumtimeCell});
            this.reportFooterBand1.Dpi = 254F;
            this.reportFooterBand1.HeightF = 264.4675F;
            this.reportFooterBand1.Name = "reportFooterBand1";
            this.reportFooterBand1.StyleName = "ReportFooterBandStyle";
            // 
            // xrLabel10
            // 
            this.xrLabel10.BackColor = System.Drawing.Color.White;
            this.xrLabel10.BorderColor = System.Drawing.Color.Red;
            this.xrLabel10.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.xrLabel10.Dpi = 254F;
            this.xrLabel10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(1779.341F, 0F);
            this.xrLabel10.Multiline = true;
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(777.8753F, 63.99997F);
            this.xrLabel10.StylePriority.UseBackColor = false;
            this.xrLabel10.StylePriority.UseBorderColor = false;
            this.xrLabel10.StylePriority.UseBorders = false;
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.StylePriority.UseTextAlignment = false;
            this.xrLabel10.Text = "Итого:\r\n";
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // sumtimeCell
            // 
            this.sumtimeCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.sumtimeCell.BorderColor = System.Drawing.Color.Red;
            this.sumtimeCell.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.sumtimeCell.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.sumtimeCell.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "time_span")});
            this.sumtimeCell.Dpi = 254F;
            this.sumtimeCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.sumtimeCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sumtimeCell.LocationFloat = new DevExpress.Utils.PointFloat(2557.217F, 0F);
            this.sumtimeCell.Name = "sumtimeCell";
            this.sumtimeCell.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.sumtimeCell.SizeF = new System.Drawing.SizeF(232.7834F, 64F);
            this.sumtimeCell.StylePriority.UseBackColor = false;
            this.sumtimeCell.StylePriority.UseBorderColor = false;
            this.sumtimeCell.StylePriority.UseBorderDashStyle = false;
            this.sumtimeCell.StylePriority.UseBorders = false;
            this.sumtimeCell.StylePriority.UseFont = false;
            this.sumtimeCell.StylePriority.UseForeColor = false;
            this.sumtimeCell.StylePriority.UsePadding = false;
            this.sumtimeCell.StylePriority.UseTextAlignment = false;
            xrSummary1.FormatString = "{0:HHHH:mm}";
            xrSummary1.IgnoreNullValues = true;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.sumtimeCell.Summary = xrSummary1;
            this.sumtimeCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.sumtimeCell.WordWrap = false;
            this.sumtimeCell.SummaryGetResult += new DevExpress.XtraReports.UI.SummaryGetResultHandler(this.sumtimeCell_SummaryGetResult);
            this.sumtimeCell.SummaryRowChanged += new System.EventHandler(this.sumtimeCell_SummaryRowChanged);
            // 
            // xrLabel12
            // 
            this.xrLabel12.BackColor = System.Drawing.Color.White;
            this.xrLabel12.Dpi = 254F;
            this.xrLabel12.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(10.58397F, 55.00003F);
            this.xrLabel12.Multiline = true;
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(317.5736F, 63.99996F);
            this.xrLabel12.StylePriority.UseBackColor = false;
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.StylePriority.UseTextAlignment = false;
            this.xrLabel12.Text = "Отчет составил";
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // CreatedFIO
            // 
            this.CreatedFIO.BackColor = System.Drawing.Color.White;
            this.CreatedFIO.Dpi = 254F;
            this.CreatedFIO.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.CreatedFIO.LocationFloat = new DevExpress.Utils.PointFloat(847.4677F, 55.00003F);
            this.CreatedFIO.Multiline = true;
            this.CreatedFIO.Name = "CreatedFIO";
            this.CreatedFIO.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.CreatedFIO.SizeF = new System.Drawing.SizeF(517.1986F, 63.99998F);
            this.CreatedFIO.StylePriority.UseBackColor = false;
            this.CreatedFIO.StylePriority.UseFont = false;
            this.CreatedFIO.StylePriority.UseTextAlignment = false;
            this.CreatedFIO.Text = "ФИО";
            this.CreatedFIO.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel16
            // 
            this.xrLabel16.BackColor = System.Drawing.Color.White;
            this.xrLabel16.BorderColor = System.Drawing.Color.Black;
            this.xrLabel16.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.xrLabel16.Dpi = 254F;
            this.xrLabel16.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(328.1577F, 99.00002F);
            this.xrLabel16.Multiline = true;
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(478.2389F, 29.67563F);
            this.xrLabel16.StylePriority.UseBackColor = false;
            this.xrLabel16.StylePriority.UseBorderColor = false;
            this.xrLabel16.StylePriority.UseBorders = false;
            this.xrLabel16.StylePriority.UseFont = false;
            this.xrLabel16.StylePriority.UseTextAlignment = false;
            this.xrLabel16.Text = "(подпись)";
            this.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel23
            // 
            this.xrLabel23.BackColor = System.Drawing.Color.White;
            this.xrLabel23.BorderColor = System.Drawing.Color.Black;
            this.xrLabel23.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.xrLabel23.Dpi = 254F;
            this.xrLabel23.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(328.1577F, 204F);
            this.xrLabel23.Multiline = true;
            this.xrLabel23.Name = "xrLabel23";
            this.xrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel23.SizeF = new System.Drawing.SizeF(478.239F, 29.67563F);
            this.xrLabel23.StylePriority.UseBackColor = false;
            this.xrLabel23.StylePriority.UseBorderColor = false;
            this.xrLabel23.StylePriority.UseBorders = false;
            this.xrLabel23.StylePriority.UseFont = false;
            this.xrLabel23.StylePriority.UseTextAlignment = false;
            this.xrLabel23.Text = "(подпись)";
            this.xrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // GetFIO
            // 
            this.GetFIO.BackColor = System.Drawing.Color.White;
            this.GetFIO.Dpi = 254F;
            this.GetFIO.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.GetFIO.LocationFloat = new DevExpress.Utils.PointFloat(847.4677F, 160F);
            this.GetFIO.Multiline = true;
            this.GetFIO.Name = "GetFIO";
            this.GetFIO.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.GetFIO.SizeF = new System.Drawing.SizeF(517.1986F, 63.99998F);
            this.GetFIO.StylePriority.UseBackColor = false;
            this.GetFIO.StylePriority.UseFont = false;
            this.GetFIO.StylePriority.UseTextAlignment = false;
            this.GetFIO.Text = "ФИО";
            this.GetFIO.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel25
            // 
            this.xrLabel25.BackColor = System.Drawing.Color.White;
            this.xrLabel25.Dpi = 254F;
            this.xrLabel25.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel25.LocationFloat = new DevExpress.Utils.PointFloat(10.58397F, 160F);
            this.xrLabel25.Multiline = true;
            this.xrLabel25.Name = "xrLabel25";
            this.xrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel25.SizeF = new System.Drawing.SizeF(317.5736F, 63.99998F);
            this.xrLabel25.StylePriority.UseBackColor = false;
            this.xrLabel25.StylePriority.UseFont = false;
            this.xrLabel25.StylePriority.UseTextAlignment = false;
            this.xrLabel25.Text = " Отчет принял";
            this.xrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // pageHeaderBand1
            // 
            this.pageHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel8,
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
            // xrLabel8
            // 
            this.xrLabel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(218)))), ((int)(((byte)(251)))));
            this.xrLabel8.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel8.Dpi = 254F;
            this.xrLabel8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(1112.791F, 0F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(487.2245F, 114.2708F);
            this.xrLabel8.StylePriority.UseBackColor = false;
            this.xrLabel8.StylePriority.UseBorders = false;
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UsePadding = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "Вид выполняемой работы";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel9
            // 
            this.xrLabel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(218)))), ((int)(((byte)(251)))));
            this.xrLabel9.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel9.Dpi = 254F;
            this.xrLabel9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(495.644F, 0F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(617.1471F, 114.2708F);
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
            this.xrLabel1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
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
            this.xrLabel3.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
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
            this.xrLabel4.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
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
            this.xrLabel5.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
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
            this.xrLabel6.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel6.Dpi = 254F;
            this.xrLabel6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(1600.016F, 0F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(478.4054F, 114.2708F);
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
            this.xrLabel21.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel21.Dpi = 254F;
            this.xrLabel21.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(260.9166F, 0F);
            this.xrLabel21.Name = "xrLabel21";
            this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel21.SizeF = new System.Drawing.SizeF(234.7274F, 114.2708F);
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
            this.bottomMarginBand1.HeightF = 150F;
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
            // topMarginBand1
            // 
            this.topMarginBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.TitleLabel});
            this.topMarginBand1.Dpi = 254F;
            this.topMarginBand1.HeightF = 318.0834F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // TitleLabel
            // 
            this.TitleLabel.Dpi = 254F;
            this.TitleLabel.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.TitleLabel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 152.9375F);
            this.TitleLabel.Multiline = true;
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.TitleLabel.SizeF = new System.Drawing.SizeF(2790F, 165.1459F);
            this.TitleLabel.StylePriority.UseFont = false;
            this.TitleLabel.StylePriority.UseTextAlignment = false;
            this.TitleLabel.Text = "Отчет о проделанной работе инженером-конструктором Шафранская Е.П.\r\nза 04.06.2018" +
    "\r\n";
            this.TitleLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
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
            table2.Name = "Position";
            columnExpression3.Table = table2;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "position";
            columnExpression4.Table = table2;
            column4.Expression = columnExpression4;
            selectQuery2.Columns.Add(column3);
            selectQuery2.Columns.Add(column4);
            selectQuery2.Name = "Position";
            selectQuery2.Tables.Add(table2);
            columnExpression5.ColumnName = "id";
            table3.Name = "pres_form";
            columnExpression5.Table = table3;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "name_form";
            columnExpression6.Table = table3;
            column6.Expression = columnExpression6;
            selectQuery3.Columns.Add(column5);
            selectQuery3.Columns.Add(column6);
            selectQuery3.Name = "pres_form";
            selectQuery3.Tables.Add(table3);
            columnExpression7.ColumnName = "id_subunit";
            table4.Name = "subunit";
            columnExpression7.Table = table4;
            column7.Expression = columnExpression7;
            columnExpression8.ColumnName = "subunit";
            columnExpression8.Table = table4;
            column8.Expression = columnExpression8;
            selectQuery4.Columns.Add(column7);
            selectQuery4.Columns.Add(column8);
            selectQuery4.Name = "subunit";
            selectQuery4.Tables.Add(table4);
            columnExpression9.ColumnName = "name";
            table5.Name = "sysdiagrams";
            columnExpression9.Table = table5;
            column9.Expression = columnExpression9;
            columnExpression10.ColumnName = "principal_id";
            columnExpression10.Table = table5;
            column10.Expression = columnExpression10;
            columnExpression11.ColumnName = "diagram_id";
            columnExpression11.Table = table5;
            column11.Expression = columnExpression11;
            columnExpression12.ColumnName = "version";
            columnExpression12.Table = table5;
            column12.Expression = columnExpression12;
            columnExpression13.ColumnName = "definition";
            columnExpression13.Table = table5;
            column13.Expression = columnExpression13;
            selectQuery5.Columns.Add(column9);
            selectQuery5.Columns.Add(column10);
            selectQuery5.Columns.Add(column11);
            selectQuery5.Columns.Add(column12);
            selectQuery5.Columns.Add(column13);
            selectQuery5.Name = "sysdiagrams";
            selectQuery5.Tables.Add(table5);
            columnExpression14.ColumnName = "id";
            table6.Name = "total";
            columnExpression14.Table = table6;
            column14.Expression = columnExpression14;
            columnExpression15.ColumnName = "FIO";
            columnExpression15.Table = table6;
            column15.Expression = columnExpression15;
            columnExpression16.ColumnName = "position";
            columnExpression16.Table = table6;
            column16.Expression = columnExpression16;
            columnExpression17.ColumnName = "subunit";
            columnExpression17.Table = table6;
            column17.Expression = columnExpression17;
            columnExpression18.ColumnName = "id_work";
            columnExpression18.Table = table6;
            column18.Expression = columnExpression18;
            columnExpression19.ColumnName = "work";
            columnExpression19.Table = table6;
            column19.Expression = columnExpression19;
            columnExpression20.ColumnName = "date";
            columnExpression20.Table = table6;
            column20.Expression = columnExpression20;
            columnExpression21.ColumnName = "time_begin";
            columnExpression21.Table = table6;
            column21.Expression = columnExpression21;
            columnExpression22.ColumnName = "time_end";
            columnExpression22.Table = table6;
            column22.Expression = columnExpression22;
            columnExpression23.ColumnName = "other";
            columnExpression23.Table = table6;
            column23.Expression = columnExpression23;
            columnExpression24.ColumnName = "add_time";
            columnExpression24.Table = table6;
            column24.Expression = columnExpression24;
            columnExpression25.ColumnName = "id_tn";
            columnExpression25.Table = table6;
            column25.Expression = columnExpression25;
            columnExpression26.ColumnName = "time_span";
            columnExpression26.Table = table6;
            column26.Expression = columnExpression26;
            columnExpression27.ColumnName = "form_id";
            columnExpression27.Table = table6;
            column27.Expression = columnExpression27;
            columnExpression28.ColumnName = "name_form";
            columnExpression28.Table = table6;
            column28.Expression = columnExpression28;
            columnExpression29.ColumnName = "id_subunit_worker";
            columnExpression29.Table = table6;
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
            selectQuery6.Tables.Add(table6);
            columnExpression30.ColumnName = "id_work";
            table7.Name = "work";
            columnExpression30.Table = table7;
            column30.Expression = columnExpression30;
            columnExpression31.ColumnName = "work";
            columnExpression31.Table = table7;
            column31.Expression = columnExpression31;
            columnExpression32.ColumnName = "id_position";
            columnExpression32.Table = table7;
            column32.Expression = columnExpression32;
            selectQuery7.Columns.Add(column30);
            selectQuery7.Columns.Add(column31);
            selectQuery7.Columns.Add(column32);
            selectQuery7.Name = "work";
            selectQuery7.Tables.Add(table7);
            columnExpression33.ColumnName = "id_tn";
            table8.Name = "worker";
            columnExpression33.Table = table8;
            column33.Expression = columnExpression33;
            columnExpression34.ColumnName = "Last_name";
            columnExpression34.Table = table8;
            column34.Expression = columnExpression34;
            columnExpression35.ColumnName = "First_name";
            columnExpression35.Table = table8;
            column35.Expression = columnExpression35;
            columnExpression36.ColumnName = "Second_name";
            columnExpression36.Table = table8;
            column36.Expression = columnExpression36;
            columnExpression37.ColumnName = "id_Position";
            columnExpression37.Table = table8;
            column37.Expression = columnExpression37;
            columnExpression38.ColumnName = "id_Subunit";
            columnExpression38.Table = table8;
            column38.Expression = columnExpression38;
            columnExpression39.ColumnName = "password";
            columnExpression39.Table = table8;
            column39.Expression = columnExpression39;
            columnExpression40.ColumnName = "status";
            columnExpression40.Table = table8;
            column40.Expression = columnExpression40;
            columnExpression41.ColumnName = "tab_nomer";
            columnExpression41.Table = table8;
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
            selectQuery8.Tables.Add(table8);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1,
            selectQuery2,
            selectQuery3,
            selectQuery4,
            selectQuery5,
            selectQuery6,
            selectQuery7,
            selectQuery8});
            // 
            // xrPanel1
            // 
            this.xrPanel1.BackColor = System.Drawing.Color.Transparent;
            this.xrPanel1.BorderColor = System.Drawing.Color.Black;
            this.xrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel25,
            this.CreatedFIO,
            this.xrLabel16,
            this.xrLabel23,
            this.GetFIO,
            this.xrLabel12});
            this.xrPanel1.Dpi = 254F;
            this.xrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(201.0068F, 0F);
            this.xrPanel1.Name = "xrPanel1";
            this.xrPanel1.SizeF = new System.Drawing.SizeF(1399.013F, 264.4675F);
            this.xrPanel1.StylePriority.UseBackColor = false;
            this.xrPanel1.StylePriority.UseBorderColor = false;
            // 
            // EveryDayReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.pageHeaderBand1,
            this.detailBand1,
            this.reportFooterBand1,
            this.bottomMarginBand1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.Dpi = 254F;
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(98, 82, 318, 150);
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
            ((System.ComponentModel.ISupportInitialize)(this.totalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        //private DevExpress.XtraReports.UI.DetailBand Detail;
        //private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        //private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRLabel workCell;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        private DevExpress.XtraReports.UI.XRLabel xrLabel12;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRLabel CreatedFIO;
        private DevExpress.XtraReports.UI.XRLabel xrLabel16;
        private DevExpress.XtraReports.UI.XRLabel xrLabel23;
        private DevExpress.XtraReports.UI.XRLabel GetFIO;
        private DevExpress.XtraReports.UI.XRLabel xrLabel25;
        private DevExpress.XtraReports.UI.XRPanel xrPanel1;
    }
}
