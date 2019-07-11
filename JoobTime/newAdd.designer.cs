namespace JoobTime
{
    partial class newAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newAdd));
            this.tmEdt_end = new DevExpress.XtraEditors.TimeSpanEdit();
            this.date_AddRecord = new DevExpress.XtraEditors.DateEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.tmEdt_start = new DevExpress.XtraEditors.TimeSpanEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.lUp_other = new DevExpress.XtraEditors.LookUpEdit();
            this.lUp_work = new DevExpress.XtraEditors.LookUpEdit();
            this.lUp_subunit = new DevExpress.XtraEditors.LookUpEdit();
            this.memoOther = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.tmEdt_end.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_AddRecord.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_AddRecord.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tmEdt_start.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lUp_other.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUp_work.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUp_subunit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoOther.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tmEdt_end
            // 
            this.tmEdt_end.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tmEdt_end.EditValue = null;
            this.tmEdt_end.Location = new System.Drawing.Point(172, 111);
            this.tmEdt_end.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tmEdt_end.Name = "tmEdt_end";
            this.tmEdt_end.Properties.AllowEditDays = false;
            this.tmEdt_end.Properties.AllowEditSeconds = false;
            this.tmEdt_end.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tmEdt_end.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.tmEdt_end.Properties.Appearance.Options.UseFont = true;
            this.tmEdt_end.Properties.Appearance.Options.UseForeColor = true;
            this.tmEdt_end.Properties.Appearance.Options.UseTextOptions = true;
            this.tmEdt_end.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tmEdt_end.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tmEdt_end.Properties.DisplayFormat.FormatString = "HH:mm";
            this.tmEdt_end.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.tmEdt_end.Properties.EditFormat.FormatString = "HH:mm";
            this.tmEdt_end.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.tmEdt_end.Properties.Mask.EditMask = "HH:mm";
            this.tmEdt_end.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.tmEdt_end.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.SpinButtons;
            this.tmEdt_end.Size = new System.Drawing.Size(198, 28);
            this.tmEdt_end.TabIndex = 3;
            // 
            // date_AddRecord
            // 
            this.date_AddRecord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.date_AddRecord.EditValue = null;
            this.date_AddRecord.Location = new System.Drawing.Point(172, 31);
            this.date_AddRecord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.date_AddRecord.Name = "date_AddRecord";
            this.date_AddRecord.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date_AddRecord.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.date_AddRecord.Properties.Appearance.Options.UseFont = true;
            this.date_AddRecord.Properties.Appearance.Options.UseForeColor = true;
            this.date_AddRecord.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_AddRecord.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_AddRecord.Size = new System.Drawing.Size(198, 28);
            this.date_AddRecord.TabIndex = 1;
            this.date_AddRecord.EditValueChanged += new System.EventHandler(this.date_AddRecord_EditValueChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(13, 115);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(127, 22);
            this.labelControl5.TabIndex = 14;
            this.labelControl5.Text = "Время окончания";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(13, 75);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(101, 22);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "Время начала";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(13, 35);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(34, 22);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Дата";
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupControl2.Appearance.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Controls.Add(this.lblTime);
            this.groupControl2.Controls.Add(this.tmEdt_start);
            this.groupControl2.Controls.Add(this.date_AddRecord);
            this.groupControl2.Controls.Add(this.tmEdt_end);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(618, 173);
            this.groupControl2.TabIndex = 29;
            this.groupControl2.Text = "Выберите дату и время";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(456, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 21);
            this.label3.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(73)))), ((int)(((byte)(88)))));
            this.label2.Location = new System.Drawing.Point(430, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 22);
            this.label2.TabIndex = 29;
            this.label2.Text = "Всего за день";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Trebuchet MS", 54.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(73)))), ((int)(((byte)(88)))));
            this.lblTime.Location = new System.Drawing.Point(372, 49);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(240, 92);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "00:00";
            // 
            // tmEdt_start
            // 
            this.tmEdt_start.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tmEdt_start.EditValue = null;
            this.tmEdt_start.Location = new System.Drawing.Point(172, 71);
            this.tmEdt_start.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tmEdt_start.Name = "tmEdt_start";
            this.tmEdt_start.Properties.AllowEditDays = false;
            this.tmEdt_start.Properties.AllowEditSeconds = false;
            this.tmEdt_start.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tmEdt_start.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.tmEdt_start.Properties.Appearance.Options.UseFont = true;
            this.tmEdt_start.Properties.Appearance.Options.UseForeColor = true;
            this.tmEdt_start.Properties.Appearance.Options.UseTextOptions = true;
            this.tmEdt_start.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tmEdt_start.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tmEdt_start.Properties.DisplayFormat.FormatString = "HH:mm";
            this.tmEdt_start.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.tmEdt_start.Properties.EditFormat.FormatString = "HH:mm";
            this.tmEdt_start.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.tmEdt_start.Properties.Mask.BeepOnError = true;
            this.tmEdt_start.Properties.Mask.EditMask = "t";
            this.tmEdt_start.Properties.Mask.IgnoreMaskBlank = false;
            this.tmEdt_start.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.tmEdt_start.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.SpinButtons;
            this.tmEdt_start.Size = new System.Drawing.Size(198, 28);
            this.tmEdt_start.TabIndex = 2;
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.btn_add);
            this.groupControl1.Controls.Add(this.lUp_other);
            this.groupControl1.Controls.Add(this.lUp_work);
            this.groupControl1.Controls.Add(this.lUp_subunit);
            this.groupControl1.Controls.Add(this.memoOther);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 173);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(618, 313);
            this.groupControl1.TabIndex = 30;
            this.groupControl1.Text = "Введите информацию о проделанной работе";
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.ImageOptions.Image")));
            this.btn_add.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_add.Location = new System.Drawing.Point(172, 249);
            this.btn_add.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(240, 55);
            this.btn_add.TabIndex = 23;
            this.btn_add.Text = "Добавить";
            // 
            // lUp_other
            // 
            this.lUp_other.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lUp_other.Location = new System.Drawing.Point(172, 105);
            this.lUp_other.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lUp_other.Name = "lUp_other";
            this.lUp_other.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lUp_other.Properties.Appearance.Options.UseFont = true;
            this.lUp_other.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lUp_other.Properties.AppearanceDisabled.Options.UseFont = true;
            this.lUp_other.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lUp_other.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lUp_other.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lUp_other.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.lUp_other.Properties.AppearanceFocused.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lUp_other.Properties.AppearanceFocused.Options.UseFont = true;
            this.lUp_other.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lUp_other.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.lUp_other.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lUp_other.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("other", "Примечания")});
            this.lUp_other.Properties.DisplayMember = "other";
            this.lUp_other.Properties.DropDownRows = 10;
            this.lUp_other.Properties.NullText = "";
            this.lUp_other.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.lUp_other.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lUp_other.Properties.ValueMember = "other";
            this.lUp_other.Size = new System.Drawing.Size(432, 28);
            this.lUp_other.TabIndex = 6;
            // 
            // lUp_work
            // 
            this.lUp_work.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lUp_work.Location = new System.Drawing.Point(172, 70);
            this.lUp_work.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lUp_work.Name = "lUp_work";
            this.lUp_work.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lUp_work.Properties.Appearance.Options.UseFont = true;
            this.lUp_work.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lUp_work.Properties.AppearanceDisabled.Options.UseFont = true;
            this.lUp_work.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lUp_work.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lUp_work.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lUp_work.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.lUp_work.Properties.AppearanceFocused.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lUp_work.Properties.AppearanceFocused.Options.UseFont = true;
            this.lUp_work.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lUp_work.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.lUp_work.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lUp_work.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("work", "Вид работы")});
            this.lUp_work.Properties.DisplayMember = "work";
            this.lUp_work.Properties.NullText = "";
            this.lUp_work.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.lUp_work.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lUp_work.Properties.ValueMember = "id_work";
            this.lUp_work.Size = new System.Drawing.Size(432, 28);
            this.lUp_work.TabIndex = 5;
            this.lUp_work.EditValueChanged += new System.EventHandler(this.lUp_work_EditValueChanged);
            // 
            // lUp_subunit
            // 
            this.lUp_subunit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lUp_subunit.Location = new System.Drawing.Point(172, 32);
            this.lUp_subunit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lUp_subunit.Name = "lUp_subunit";
            this.lUp_subunit.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lUp_subunit.Properties.Appearance.Options.UseFont = true;
            this.lUp_subunit.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lUp_subunit.Properties.AppearanceDisabled.Options.UseFont = true;
            this.lUp_subunit.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lUp_subunit.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lUp_subunit.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lUp_subunit.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.lUp_subunit.Properties.AppearanceFocused.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lUp_subunit.Properties.AppearanceFocused.Options.UseFont = true;
            this.lUp_subunit.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lUp_subunit.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.lUp_subunit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lUp_subunit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("subunit", "Подразделение")});
            this.lUp_subunit.Properties.DisplayMember = "subunit";
            this.lUp_subunit.Properties.NullText = "";
            this.lUp_subunit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.lUp_subunit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lUp_subunit.Properties.ValueMember = "id_subunit";
            this.lUp_subunit.Size = new System.Drawing.Size(432, 28);
            this.lUp_subunit.TabIndex = 4;
            // 
            // memoOther
            // 
            this.memoOther.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memoOther.Location = new System.Drawing.Point(172, 135);
            this.memoOther.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.memoOther.Name = "memoOther";
            this.memoOther.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.memoOther.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.memoOther.Properties.Appearance.Options.UseFont = true;
            this.memoOther.Properties.Appearance.Options.UseForeColor = true;
            this.memoOther.Size = new System.Drawing.Size(432, 102);
            this.memoOther.TabIndex = 7;
            this.memoOther.ToolTip = "Это поле должно быть заполнено обязательно. Если в поле с выбором примечаний нет " +
    "нужного вам варианта, запишите текст в это поле. ";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(6, 111);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(90, 22);
            this.labelControl6.TabIndex = 22;
            this.labelControl6.Text = "Примечания";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(6, 73);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(85, 22);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Вид работы";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(6, 35);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(114, 22);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Подразделение";
            // 
            // newAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 486);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 550);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(634, 492);
            this.Name = "newAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить";
            this.Load += new System.EventHandler(this.add_Load);
            this.ResizeEnd += new System.EventHandler(this.add_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.tmEdt_end.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_AddRecord.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_AddRecord.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tmEdt_start.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lUp_other.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUp_work.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUp_subunit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoOther.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.DateEdit date_AddRecord;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TimeSpanEdit tmEdt_end;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Label lblTime;
        private DevExpress.XtraEditors.TimeSpanEdit tmEdt_start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LookUpEdit lUp_other;
        private DevExpress.XtraEditors.LookUpEdit lUp_work;
        private DevExpress.XtraEditors.LookUpEdit lUp_subunit;
        private DevExpress.XtraEditors.MemoEdit memoOther;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        //    private db1DataSet db1DataSet;
        // private db1DataSetTableAdapters.totalTableAdapter totalTableAdapter;
        //  private db1DataSetTableAdapters.workerTableAdapter workerTableAdapter;
        //  private db1DataSetTableAdapters.workTableAdapter workTableAdapter;
        // private db1DataSetTableAdapters.subunitTableAdapter subunitTableAdapter;
        //private System.Windows.Forms.DataGridViewTextBoxColumn tabmomerDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn secondnameDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn subunitDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}