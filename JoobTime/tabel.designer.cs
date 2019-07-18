namespace JoobTime
{
    partial class tabel
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startLabel = new DevExpress.XtraEditors.LabelControl();
            this.startTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TitleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.startTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // startLabel
            // 
            this.startLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.startLabel.Location = new System.Drawing.Point(13, 38);
            this.startLabel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(176, 32);
            this.startLabel.TabIndex = 1;
            this.startLabel.Click += new System.EventHandler(this.startLabel_Click);
            // 
            // startTextEdit
            // 
            this.startTextEdit.Location = new System.Drawing.Point(197, 40);
            this.startTextEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startTextEdit.Name = "startTextEdit";
            this.startTextEdit.Properties.Mask.EditMask = "\\d{0,5}:[0-5]\\d";
            this.startTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.startTextEdit.Size = new System.Drawing.Size(138, 28);
            this.startTextEdit.TabIndex = 2;
            // 
            // TitleLabel
            // 
            this.TitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.TitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(344, 33);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "Табель сотрудников отдела 2D формы за июнь 2018";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TitleLabel.DoubleClick += new System.EventHandler(this.TitleLabel_Click_1);
            // 
            // tabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(344, 96);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.startTextEdit);
            this.Controls.Add(this.startLabel);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(360, 1920);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(340, 0);
            this.Name = "tabel";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Табель";
            this.Load += new System.EventHandler(this.tabel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.startTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl startLabel;
        private DevExpress.XtraEditors.TextEdit startTextEdit;
        private System.Windows.Forms.Label TitleLabel;
    }
}