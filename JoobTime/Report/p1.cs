namespace JoobTime
{
    public class p1: DevExpress.XtraReports.UI.XtraReport
    {
        public System.TimeSpan ts;
        public System.TimeSpan ts1;
        public System.TimeSpan ts2;
        public System.TimeSpan ts3;
        private DevExpress.XtraReports.UI.XRControlStyle ReportDetailBandStyle;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private DevExpress.XtraReports.UI.XRControlStyle ReportGroupFooterBandStyle;
        private DevExpress.XtraReports.UI.XRControlStyle ReportOddStyle;
        private DevExpress.XtraReports.UI.DetailBand detailBand1;
        private DevExpress.XtraReports.UI.ReportFooterBand reportFooterBand1;
        private DevExpress.XtraReports.UI.GroupHeaderBand groupHeaderBand3;
        private DevExpress.XtraReports.UI.GroupHeaderBand groupHeaderBand1;
        private DevExpress.XtraReports.UI.XRControlStyle ReportFooterBandStyle;
        private DevExpress.XtraReports.UI.GroupHeaderBand groupHeaderBand2;
        private DevExpress.XtraReports.UI.XRControlStyle ReportHeaderBandStyle;
        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.XRControlStyle ReportEvenStyle;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRLabel xrLabel11;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLabel xrLabel12;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        private DevExpress.XtraReports.UI.XRControlStyle ReportGroupHeaderBandStyle;
    
        public p1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary4 = new DevExpress.XtraReports.UI.XRSummary();
            this.ReportDetailBandStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportGroupFooterBandStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.ReportOddStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.detailBand1 = new DevExpress.XtraReports.UI.DetailBand();
            this.reportFooterBand1 = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.groupHeaderBand3 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.groupHeaderBand1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.ReportFooterBandStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.groupHeaderBand2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.ReportHeaderBandStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportEvenStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.ReportGroupHeaderBandStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // ReportDetailBandStyle
            // 
            this.ReportDetailBandStyle.BackColor = System.Drawing.Color.Transparent;
            this.ReportDetailBandStyle.Name = "ReportDetailBandStyle";
            this.ReportDetailBandStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 254F);
            this.ReportDetailBandStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.Dpi = 254F;
            this.bottomMarginBand1.HeightF = 71.95838F;
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            // 
            // ReportGroupFooterBandStyle
            // 
            this.ReportGroupFooterBandStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.ReportGroupFooterBandStyle.Name = "ReportGroupFooterBandStyle";
            this.ReportGroupFooterBandStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 254F);
            this.ReportGroupFooterBandStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // ReportOddStyle
            // 
            this.ReportOddStyle.BackColor = System.Drawing.Color.Transparent;
            this.ReportOddStyle.Name = "ReportOddStyle";
            this.ReportOddStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 254F);
            this.ReportOddStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // detailBand1
            // 
            this.detailBand1.Dpi = 254F;
            this.detailBand1.EvenStyleName = "ReportEvenStyle";
            this.detailBand1.HeightF = 0F;
            this.detailBand1.Name = "detailBand1";
            this.detailBand1.OddStyleName = "ReportOddStyle";
            this.detailBand1.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("date", DevExpress.XtraReports.UI.XRColumnSortOrder.Descending),
            new DevExpress.XtraReports.UI.GroupField("time_begin", DevExpress.XtraReports.UI.XRColumnSortOrder.Descending)});
            this.detailBand1.StyleName = "ReportDetailBandStyle";
            // 
            // reportFooterBand1
            // 
            this.reportFooterBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel2,
            this.xrLabel3});
            this.reportFooterBand1.Dpi = 254F;
            this.reportFooterBand1.HeightF = 143.375F;
            this.reportFooterBand1.Name = "reportFooterBand1";
            this.reportFooterBand1.StyleName = "ReportFooterBandStyle";
            // 
            // xrLabel2
            // 
            this.xrLabel2.AnchorHorizontal = DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left;
            this.xrLabel2.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top;
            this.xrLabel2.BackColor = System.Drawing.Color.White;
            this.xrLabel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.xrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "time_span")});
            this.xrLabel2.Dpi = 254F;
            this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(1157.459F, 0F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(434.5413F, 64F);
            this.xrLabel2.StylePriority.UseBackColor = false;
            this.xrLabel2.StylePriority.UseBorderColor = false;
            this.xrLabel2.StylePriority.UseBorders = false;
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UsePadding = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            xrSummary1.FormatString = "{0}";
            xrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom;
            xrSummary1.IgnoreNullValues = true;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrLabel2.Summary = xrSummary1;
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrLabel2.WordWrap = false;
            this.xrLabel2.SummaryGetResult += new DevExpress.XtraReports.UI.SummaryGetResultHandler(this.xrLabel2_SummaryGetResult);
            this.xrLabel2.SummaryRowChanged += new System.EventHandler(this.xrLabel2_SummaryRowChanged);
            // 
            // xrLabel3
            // 
            this.xrLabel3.BackColor = System.Drawing.Color.White;
            this.xrLabel3.Dpi = 254F;
            this.xrLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(1038.396F, 0F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(119.0625F, 58.42F);
            this.xrLabel3.StylePriority.UseBackColor = false;
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "Всего:";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // groupHeaderBand3
            // 
            this.groupHeaderBand3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel5,
            this.xrLabel6,
            this.xrLabel8,
            this.xrLabel11,
            this.xrLabel9,
            this.xrLabel12});
            this.groupHeaderBand3.Dpi = 254F;
            this.groupHeaderBand3.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("form_id", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.groupHeaderBand3.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.groupHeaderBand3.HeightF = 156.6041F;
            this.groupHeaderBand3.Level = 2;
            this.groupHeaderBand3.Name = "groupHeaderBand3";
            this.groupHeaderBand3.StyleName = "ReportGroupHeaderBandStyle";
            // 
            // groupHeaderBand1
            // 
            this.groupHeaderBand1.Dpi = 254F;
            this.groupHeaderBand1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("FIO", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.groupHeaderBand1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.groupHeaderBand1.HeightF = 64F;
            this.groupHeaderBand1.Name = "groupHeaderBand1";
            this.groupHeaderBand1.StyleName = "ReportGroupHeaderBandStyle";
            // 
            // ReportFooterBandStyle
            // 
            this.ReportFooterBandStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.ReportFooterBandStyle.Name = "ReportFooterBandStyle";
            this.ReportFooterBandStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 254F);
            this.ReportFooterBandStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // groupHeaderBand2
            // 
            this.groupHeaderBand2.Dpi = 254F;
            this.groupHeaderBand2.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("subunit", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.groupHeaderBand2.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.groupHeaderBand2.HeightF = 64F;
            this.groupHeaderBand2.Level = 1;
            this.groupHeaderBand2.Name = "groupHeaderBand2";
            this.groupHeaderBand2.StyleName = "ReportGroupHeaderBandStyle";
            // 
            // ReportHeaderBandStyle
            // 
            this.ReportHeaderBandStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ReportHeaderBandStyle.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold);
            this.ReportHeaderBandStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ReportHeaderBandStyle.Name = "ReportHeaderBandStyle";
            this.ReportHeaderBandStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 254F);
            this.ReportHeaderBandStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1,
            this.xrLabel4,
            this.xrLabel7,
            this.xrLabel10});
            this.topMarginBand1.Dpi = 254F;
            this.topMarginBand1.HeightF = 344.1701F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // xrLabel1
            // 
            this.xrLabel1.Dpi = 254F;
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 84.66666F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(1592F, 106.045F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "Отчет по времени, затраченному на проектирование пресс-форм сданых в производство" +
    "";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // ReportEvenStyle
            // 
            this.ReportEvenStyle.BackColor = System.Drawing.Color.Transparent;
            this.ReportEvenStyle.Name = "ReportEvenStyle";
            this.ReportEvenStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 254F);
            this.ReportEvenStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // ReportGroupHeaderBandStyle
            // 
            this.ReportGroupHeaderBandStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.ReportGroupHeaderBandStyle.Name = "ReportGroupHeaderBandStyle";
            this.ReportGroupHeaderBandStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 0, 0, 0, 254F);
            this.ReportGroupHeaderBandStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel4
            // 
            this.xrLabel4.BackColor = System.Drawing.Color.SkyBlue;
            this.xrLabel4.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel4.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel4.Dpi = 254F;
            this.xrLabel4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 280.1701F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(359.7156F, 64F);
            this.xrLabel4.StylePriority.UseBackColor = false;
            this.xrLabel4.StylePriority.UseBorderDashStyle = false;
            this.xrLabel4.StylePriority.UseBorders = false;
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UsePadding = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "Форма:";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrLabel4.WordWrap = false;
            // 
            // xrLabel5
            // 
            this.xrLabel5.BackColor = System.Drawing.Color.SkyBlue;
            this.xrLabel5.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "form_id")});
            this.xrLabel5.Dpi = 254F;
            this.xrLabel5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(359.7156F, 64F);
            this.xrLabel5.StylePriority.UseBackColor = false;
            this.xrLabel5.StylePriority.UseBorders = false;
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UsePadding = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "xrLabel5";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrLabel5.WordWrap = false;
            // 
            // xrLabel6
            // 
            this.xrLabel6.BackColor = System.Drawing.Color.SkyBlue;
            this.xrLabel6.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "time_span")});
            this.xrLabel6.Dpi = 254F;
            this.xrLabel6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(1363.834F, 0F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(228.1659F, 131.6041F);
            this.xrLabel6.StylePriority.UseBackColor = false;
            this.xrLabel6.StylePriority.UseBorders = false;
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UsePadding = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            xrSummary2.FormatString = "{0}";
            xrSummary2.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom;
            xrSummary2.IgnoreNullValues = true;
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel6.Summary = xrSummary2;
            this.xrLabel6.Text = "xrLabel6";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrLabel6.WordWrap = false;
            // 
            // xrLabel7
            // 
            this.xrLabel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.xrLabel7.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel7.Dpi = 254F;
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(359.7156F, 280.1701F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(797.7428F, 64F);
            this.xrLabel7.StylePriority.UseBackColor = false;
            this.xrLabel7.StylePriority.UseBorders = false;
            this.xrLabel7.StylePriority.UsePadding = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "Подразделение:";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrLabel7.WordWrap = false;
            // 
            // xrLabel8
            // 
            this.xrLabel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.xrLabel8.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "subunit")});
            this.xrLabel8.Dpi = 254F;
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(359.7162F, 0F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(797.7428F, 64F);
            this.xrLabel8.StylePriority.UseBackColor = false;
            this.xrLabel8.StylePriority.UseBorders = false;
            this.xrLabel8.StylePriority.UsePadding = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "xrLabel8";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrLabel8.WordWrap = false;
            // 
            // xrLabel9
            // 
            this.xrLabel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.xrLabel9.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel9.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "time_span")});
            this.xrLabel9.Dpi = 254F;
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(1157.459F, 0F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(206.375F, 131.6041F);
            this.xrLabel9.StylePriority.UseBackColor = false;
            this.xrLabel9.StylePriority.UseBorders = false;
            this.xrLabel9.StylePriority.UsePadding = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            xrSummary3.FormatString = "{0}";
            xrSummary3.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom;
            xrSummary3.IgnoreNullValues = true;
            xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel9.Summary = xrSummary3;
            this.xrLabel9.Text = "xrLabel9";
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrLabel9.WordWrap = false;
            // 
            // xrLabel10
            // 
            this.xrLabel10.BackColor = System.Drawing.Color.White;
            this.xrLabel10.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel10.Dpi = 254F;
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(1132.299F, 190.7116F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(161.3448F, 64F);
            this.xrLabel10.StylePriority.UseBackColor = false;
            this.xrLabel10.StylePriority.UseBorders = false;
            this.xrLabel10.StylePriority.UsePadding = false;
            this.xrLabel10.StylePriority.UseTextAlignment = false;
            this.xrLabel10.Text = "Инженер:";
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrLabel10.WordWrap = false;
            // 
            // xrLabel11
            // 
            this.xrLabel11.BackColor = System.Drawing.Color.White;
            this.xrLabel11.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel11.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "FIO")});
            this.xrLabel11.Dpi = 254F;
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(359.7156F, 67.60416F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(797.7428F, 64F);
            this.xrLabel11.StylePriority.UseBackColor = false;
            this.xrLabel11.StylePriority.UseBorders = false;
            this.xrLabel11.StylePriority.UsePadding = false;
            this.xrLabel11.StylePriority.UseTextAlignment = false;
            this.xrLabel11.Text = "xrLabel11";
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrLabel11.WordWrap = false;
            // 
            // xrLabel12
            // 
            this.xrLabel12.BackColor = System.Drawing.Color.White;
            this.xrLabel12.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel12.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "time_span")});
            this.xrLabel12.Dpi = 254F;
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(155.3623F, 63.99997F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(204.3539F, 64F);
            this.xrLabel12.StylePriority.UseBackColor = false;
            this.xrLabel12.StylePriority.UseBorders = false;
            this.xrLabel12.StylePriority.UsePadding = false;
            this.xrLabel12.StylePriority.UseTextAlignment = false;
            xrSummary4.FormatString = "{0}";
            xrSummary4.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom;
            xrSummary4.IgnoreNullValues = true;
            xrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel12.Summary = xrSummary4;
            this.xrLabel12.Text = "xrLabel12";
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrLabel12.WordWrap = false;
            // 
            // subunit_pressform_report
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.groupHeaderBand1,
            this.groupHeaderBand2,
            this.groupHeaderBand3,
            this.detailBand1,
            this.reportFooterBand1,
            this.bottomMarginBand1});
            this.Dpi = 254F;
            this.Margins = new System.Drawing.Printing.Margins(254, 254, 344, 72);
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
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        private void tableCell9_SummaryGetResult(object sender, DevExpress.XtraReports.UI.SummaryGetResultEventArgs e)
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

        private void tableCell9_SummaryReset(object sender, System.EventArgs e)
        {
            ts = new System.TimeSpan(00, 00, 00);
        }

        private void tableCell9_SummaryRowChanged(object sender, System.EventArgs e)
        {
            string w = System.Convert.ToString(GetCurrentColumnValue("time_span"));
            ts += System.TimeSpan.Parse(w);
        }

        private void tableCell6_SummaryGetResult(object sender, DevExpress.XtraReports.UI.SummaryGetResultEventArgs e)
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

        private void tableCell6_SummaryReset(object sender, System.EventArgs e)
        {
            ts1 = new System.TimeSpan(00, 00, 00);
        }

        private void tableCell6_SummaryRowChanged(object sender, System.EventArgs e)
        {
            string w = System.Convert.ToString(GetCurrentColumnValue("time_span"));
            ts1 += System.TimeSpan.Parse(w);
        }

        private void tableCell3_SummaryGetResult(object sender, DevExpress.XtraReports.UI.SummaryGetResultEventArgs e)
        {
            string strin_f = ts2.TotalHours.ToString();//(0,2) + ":" + ts.Minutes.ToString();
            string itog;
            // e.TotalValue = strin_f;
            if (strin_f.Contains(",") == true)
            {
                int len = strin_f.IndexOf(',', 0);
                if (ts2.Minutes.ToString().Length > 1)
                {
                    itog = strin_f.Substring(0, len) + ":" + ts2.Minutes.ToString();
                    e.Result = itog;
                }
                else
                {
                    itog = strin_f.Substring(0, len) + ":0" + ts2.Minutes.ToString();
                    e.Result = itog;
                }
            }
            else
            {
                if (ts2.Minutes.ToString().Length > 1)
                {
                    itog = strin_f + ":" + ts2.Minutes.ToString();
                    e.Result = itog;
                }
                else
                {
                    itog = strin_f + ":0" + ts2.Minutes.ToString();
                    e.Result = itog;
                }
            }
            e.Handled = true;
        }

        private void tableCell3_SummaryRowChanged(object sender, System.EventArgs e)
        {
            string w = System.Convert.ToString(GetCurrentColumnValue("time_span"));
            ts2 += System.TimeSpan.Parse(w);
        }

        private void tableCell3_SummaryReset(object sender, System.EventArgs e)
        {
            ts2 = new System.TimeSpan(00, 00, 00);
        }

        private void xrLabel2_SummaryGetResult(object sender, DevExpress.XtraReports.UI.SummaryGetResultEventArgs e)
        {
            string strin_f = ts3.TotalHours.ToString();//(0,2) + ":" + ts.Minutes.ToString();
            string itog;
            // e.TotalValue = strin_f;
            if (strin_f.Contains(",") == true)
            {
                int len = strin_f.IndexOf(',', 0);
                if (ts3.Minutes.ToString().Length > 1)
                {
                    itog = strin_f.Substring(0, len) + ":" + ts3.Minutes.ToString();
                    e.Result = itog;
                }
                else
                {
                    itog = strin_f.Substring(0, len) + ":0" + ts3.Minutes.ToString();
                    e.Result = itog;
                }
            }
            else
            {
                if (ts3.Minutes.ToString().Length > 1)
                {
                    itog = strin_f + ":" + ts3.Minutes.ToString();
                    e.Result = itog;
                }
                else
                {
                    itog = strin_f + ":0" + ts3.Minutes.ToString();
                    e.Result = itog;
                }
            }
            e.Handled = true;
        }

        private void xrLabel2_SummaryRowChanged(object sender, System.EventArgs e)
        {
            string w = System.Convert.ToString(GetCurrentColumnValue("time_span"));
            ts3 += System.TimeSpan.Parse(w);
        }
    }
}
