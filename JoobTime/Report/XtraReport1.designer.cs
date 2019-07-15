namespace JoobTime
{
    partial class XtraReport1
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraCharts.SimpleDiagram3D simpleDiagram3D1 = new DevExpress.XtraCharts.SimpleDiagram3D();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Pie3DSeriesLabel pie3DSeriesLabel1 = new DevExpress.XtraCharts.Pie3DSeriesLabel();
            DevExpress.XtraCharts.Pie3DSeriesView pie3DSeriesView1 = new DevExpress.XtraCharts.Pie3DSeriesView();
            DevExpress.XtraCharts.KeyColorColorizer keyColorColorizer1 = new DevExpress.XtraCharts.KeyColorColorizer();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrChart1 = new DevExpress.XtraReports.UI.XRChart();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            ((System.ComponentModel.ISupportInitialize)(this.xrChart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrChart1});
            this.Detail.Dpi = 100F;
            this.Detail.HeightF = 777.1668F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrChart1
            // 
            this.xrChart1.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.xrChart1.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top;
            this.xrChart1.AppearanceNameSerializable = "Nature Colors";
            this.xrChart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xrChart1.BorderColor = System.Drawing.Color.Black;
            this.xrChart1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            simpleDiagram3D1.HorizontalScrollPercent = 0.56829206406065769D;
            simpleDiagram3D1.LabelsResolveOverlappingMinIndent = 5;
            simpleDiagram3D1.RotationMatrixSerializable = "1;0;0;0;0;0.5;-0.866025403784439;0;0;0.866025403784439;0.5;0;0;0;0;1";
            simpleDiagram3D1.VerticalScrollPercent = 4.2709818207415982D;
            simpleDiagram3D1.ZoomPercent = 150;
            this.xrChart1.Diagram = simpleDiagram3D1;
            this.xrChart1.Dpi = 100F;
            this.xrChart1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center;
            this.xrChart1.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside;
            this.xrChart1.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            this.xrChart1.Legend.Name = "Default Legend";
            this.xrChart1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 87.08334F);
            this.xrChart1.Name = "xrChart1";
            this.xrChart1.PaletteName = "Pastel Kit";
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
            pie3DSeriesLabel1.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True;
            pie3DSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default;
            series2.Label = pie3DSeriesLabel1;
            series2.Name = "Ряд 2";
            pie3DSeriesView1.Depth = 20;
            pie3DSeriesView1.PieFillStyle.FillMode = DevExpress.XtraCharts.FillMode3D.Solid;
            series2.View = pie3DSeriesView1;
            this.xrChart1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            this.xrChart1.SeriesTemplate.Colorizer = keyColorColorizer1;
            this.xrChart1.SizeF = new System.Drawing.SizeF(969F, 680.0834F);
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1});
            this.TopMargin.Dpi = 100F;
            this.TopMargin.HeightF = 82.29166F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Dpi = 100F;
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(256.875F, 49.29168F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(466.6667F, 23F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.Text = "Диаграмма к отчету о выполненных работах";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Dpi = 100F;
            this.BottomMargin.HeightF = 24.83304F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // XtraReport1
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(100, 100, 82, 25);
            this.PageHeight = 827;
            this.PageWidth = 1169;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Version = "16.2";
            this.DesignerLoaded += new DevExpress.XtraReports.UserDesigner.DesignerLoadedEventHandler(this.XtraReport1_DesignerLoaded);
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrChart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRChart xrChart1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
    }
}
