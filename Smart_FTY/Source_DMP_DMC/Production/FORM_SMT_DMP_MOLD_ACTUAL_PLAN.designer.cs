﻿namespace Smart_FTY
{
    partial class FORM_SMT_DMP_MOLD_ACTUAL_PLAN
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_SMT_DMP_MOLD_ACTUAL_PLAN));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tmr_blind = new System.Windows.Forms.Timer(this.components);
            this.lblDmp = new System.Windows.Forms.Label();
            this.lblDmc = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblMold_change = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Actual = new System.Windows.Forms.Label();
            this.lbl_Plan = new System.Windows.Forms.Label();
            this.pnButton = new System.Windows.Forms.Panel();
            this.cmdMonth = new DevExpress.XtraEditors.SimpleButton();
            this.cmdYear = new DevExpress.XtraEditors.SimpleButton();
            this.cmdDay = new DevExpress.XtraEditors.SimpleButton();
            this.lblDate = new System.Windows.Forms.Label();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.cmdBack = new System.Windows.Forms.Button();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.dtpDate = new DevExpress.XtraEditors.DateEdit();
            this.pnShift = new System.Windows.Forms.Panel();
            this.lbl_dif3 = new System.Windows.Forms.Label();
            this.lbl_dif2 = new System.Windows.Forms.Label();
            this.lbl_dif1 = new System.Windows.Forms.Label();
            this.lbl_Shift2 = new System.Windows.Forms.Label();
            this.lbl_Shift1 = new System.Windows.Forms.Label();
            this.lbl_Shift3 = new System.Windows.Forms.Label();
            this.pn1 = new Smart_FTY.A1Panel();
            this.lblCMP = new System.Windows.Forms.Label();
            this.pn2 = new Smart_FTY.A1Panel();
            this.lblPhylon = new System.Windows.Forms.Label();
            this.axGrid = new AxFPSpreadADO.AxfpSpread();
            this.pnButton.SuspendLayout();
            this.pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate.Properties)).BeginInit();
            this.pnShift.SuspendLayout();
            this.pn1.SuspendLayout();
            this.pn2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tmr_blind
            // 
            this.tmr_blind.Tick += new System.EventHandler(this.tmr_blind_Tick);
            // 
            // lblDmp
            // 
            this.lblDmp.BackColor = System.Drawing.Color.IndianRed;
            this.lblDmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDmp.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDmp.ForeColor = System.Drawing.Color.Black;
            this.lblDmp.Location = new System.Drawing.Point(1776, 143);
            this.lblDmp.Name = "lblDmp";
            this.lblDmp.Size = new System.Drawing.Size(142, 35);
            this.lblDmp.TabIndex = 685;
            this.lblDmp.Text = "DMP";
            this.lblDmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDmp.Visible = false;
            this.lblDmp.Click += new System.EventHandler(this.lblDmp_Click);
            // 
            // lblDmc
            // 
            this.lblDmc.BackColor = System.Drawing.Color.Gray;
            this.lblDmc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDmc.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDmc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDmc.Location = new System.Drawing.Point(1626, 143);
            this.lblDmc.Name = "lblDmc";
            this.lblDmc.Size = new System.Drawing.Size(148, 35);
            this.lblDmc.TabIndex = 684;
            this.lblDmc.Text = "DMC";
            this.lblDmc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDmc.Visible = false;
            this.lblDmc.Click += new System.EventHandler(this.lblDmc_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            // 
            // lblMold_change
            // 
            this.lblMold_change.BackColor = System.Drawing.Color.Yellow;
            this.lblMold_change.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMold_change.ForeColor = System.Drawing.Color.Black;
            this.lblMold_change.Location = new System.Drawing.Point(934, 108);
            this.lblMold_change.Name = "lblMold_change";
            this.lblMold_change.Size = new System.Drawing.Size(225, 31);
            this.lblMold_change.TabIndex = 690;
            this.lblMold_change.Text = "Mold Change";
            this.lblMold_change.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Font = new System.Drawing.Font("Calibri", 18.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(983, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 30);
            this.label1.TabIndex = 693;
            this.label1.Text = "Plan/Acual";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Visible = false;
            // 
            // lbl_Actual
            // 
            this.lbl_Actual.BackColor = System.Drawing.Color.DarkOrange;
            this.lbl_Actual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Actual.Font = new System.Drawing.Font("Calibri", 18.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Actual.ForeColor = System.Drawing.Color.White;
            this.lbl_Actual.Location = new System.Drawing.Point(1177, 138);
            this.lbl_Actual.Name = "lbl_Actual";
            this.lbl_Actual.Size = new System.Drawing.Size(225, 32);
            this.lbl_Actual.TabIndex = 695;
            this.lbl_Actual.Text = "Total Actual: 450";
            this.lbl_Actual.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_Actual.Click += new System.EventHandler(this.lbl_actual_Click);
            // 
            // lbl_Plan
            // 
            this.lbl_Plan.BackColor = System.Drawing.Color.Green;
            this.lbl_Plan.Font = new System.Drawing.Font("Calibri", 18.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Plan.ForeColor = System.Drawing.Color.White;
            this.lbl_Plan.Location = new System.Drawing.Point(1177, 107);
            this.lbl_Plan.Name = "lbl_Plan";
            this.lbl_Plan.Size = new System.Drawing.Size(225, 30);
            this.lbl_Plan.TabIndex = 694;
            this.lbl_Plan.Text = "Total Plan:  458";
            this.lbl_Plan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_Plan.Click += new System.EventHandler(this.lbl_plan_Click);
            // 
            // pnButton
            // 
            this.pnButton.Controls.Add(this.cmdMonth);
            this.pnButton.Controls.Add(this.cmdYear);
            this.pnButton.Controls.Add(this.cmdDay);
            this.pnButton.Location = new System.Drawing.Point(1306, -2);
            this.pnButton.Name = "pnButton";
            this.pnButton.Size = new System.Drawing.Size(373, 103);
            this.pnButton.TabIndex = 689;
            this.pnButton.Visible = false;
            // 
            // cmdMonth
            // 
            this.cmdMonth.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdMonth.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdMonth.Appearance.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold);
            this.cmdMonth.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.cmdMonth.Appearance.Options.UseBackColor = true;
            this.cmdMonth.Appearance.Options.UseFont = true;
            this.cmdMonth.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cmdMonth.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdMonth.ImageOptions.Image")));
            this.cmdMonth.Location = new System.Drawing.Point(186, 3);
            this.cmdMonth.Name = "cmdMonth";
            this.cmdMonth.Size = new System.Drawing.Size(175, 48);
            this.cmdMonth.TabIndex = 62;
            this.cmdMonth.Text = "Month";
            // 
            // cmdYear
            // 
            this.cmdYear.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdYear.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdYear.Appearance.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdYear.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.cmdYear.Appearance.Options.UseBackColor = true;
            this.cmdYear.Appearance.Options.UseFont = true;
            this.cmdYear.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cmdYear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdYear.ImageOptions.Image")));
            this.cmdYear.Location = new System.Drawing.Point(187, 55);
            this.cmdYear.Name = "cmdYear";
            this.cmdYear.Size = new System.Drawing.Size(175, 48);
            this.cmdYear.TabIndex = 63;
            this.cmdYear.Text = "Year";
            // 
            // cmdDay
            // 
            this.cmdDay.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdDay.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdDay.Appearance.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold);
            this.cmdDay.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.cmdDay.Appearance.Options.UseBackColor = true;
            this.cmdDay.Appearance.Options.UseFont = true;
            this.cmdDay.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cmdDay.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdDay.ImageOptions.Image")));
            this.cmdDay.Location = new System.Drawing.Point(5, 3);
            this.cmdDay.Name = "cmdDay";
            this.cmdDay.Size = new System.Drawing.Size(175, 48);
            this.cmdDay.TabIndex = 61;
            this.cmdDay.Text = "Day";
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDate.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(1689, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(231, 103);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "20-10-2018\r\n00:00:00";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.DarkTurquoise;
            this.pnHeader.Controls.Add(this.cmdBack);
            this.pnHeader.Controls.Add(this.pnButton);
            this.pnHeader.Controls.Add(this.lblDate);
            this.pnHeader.Controls.Add(this.lblTitle2);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1920, 103);
            this.pnHeader.TabIndex = 699;
            // 
            // cmdBack
            // 
            this.cmdBack.BackColor = System.Drawing.Color.Transparent;
            this.cmdBack.BackgroundImage = global::Smart_FTY.Properties.Resources.Back_Icon;
            this.cmdBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdBack.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.cmdBack.FlatAppearance.BorderSize = 0;
            this.cmdBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBack.Location = new System.Drawing.Point(1177, -1);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(108, 101);
            this.cmdBack.TabIndex = 690;
            this.cmdBack.UseVisualStyleBackColor = false;
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // lblTitle2
            // 
            this.lblTitle2.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle2.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle2.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle2.ForeColor = System.Drawing.Color.White;
            this.lblTitle2.Location = new System.Drawing.Point(0, 0);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(1171, 103);
            this.lblTitle2.TabIndex = 0;
            this.lblTitle2.Text = "DMC APS Plan && Actual";
            this.lblTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpDate
            // 
            this.dtpDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpDate.EditValue = new System.DateTime(2021, 1, 5, 16, 0, 56, 0);
            this.dtpDate.Location = new System.Drawing.Point(23, 107);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dtpDate.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 24.25F, System.Drawing.FontStyle.Bold);
            this.dtpDate.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.dtpDate.Properties.Appearance.Options.UseFont = true;
            this.dtpDate.Properties.Appearance.Options.UseForeColor = true;
            this.dtpDate.Properties.AppearanceCalendar.CalendarHeader.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Properties.AppearanceCalendar.CalendarHeader.Options.UseFont = true;
            this.dtpDate.Properties.AppearanceCalendar.DayCell.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Properties.AppearanceCalendar.DayCell.Options.UseFont = true;
            this.dtpDate.Properties.AppearanceCalendar.DayCellHighlighted.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Properties.AppearanceCalendar.DayCellHighlighted.Options.UseFont = true;
            this.dtpDate.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Calibri", 24.25F, System.Drawing.FontStyle.Bold);
            this.dtpDate.Properties.AppearanceDisabled.Options.UseFont = true;
            this.dtpDate.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Properties.AppearanceDropDown.Options.UseFont = true;
            this.dtpDate.Properties.AppearanceFocused.Font = new System.Drawing.Font("Calibri", 24.25F, System.Drawing.FontStyle.Bold);
            this.dtpDate.Properties.AppearanceFocused.Options.UseFont = true;
            this.dtpDate.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Calibri", 24.25F, System.Drawing.FontStyle.Bold);
            this.dtpDate.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.dtpDate.Properties.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            serializableAppearanceObject1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            serializableAppearanceObject1.Options.UseFont = true;
            serializableAppearanceObject2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            serializableAppearanceObject2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            serializableAppearanceObject2.Options.UseFont = true;
            serializableAppearanceObject3.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            serializableAppearanceObject3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            serializableAppearanceObject3.Options.UseFont = true;
            serializableAppearanceObject4.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            serializableAppearanceObject4.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            serializableAppearanceObject4.Options.UseFont = true;
            this.dtpDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 50, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null)});
            this.dtpDate.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            editorButtonImageOptions2.Location = DevExpress.XtraEditors.ImageLocation.Default;
            serializableAppearanceObject5.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            serializableAppearanceObject5.Options.UseFont = true;
            serializableAppearanceObject6.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            serializableAppearanceObject6.Options.UseFont = true;
            serializableAppearanceObject7.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            serializableAppearanceObject7.Options.UseFont = true;
            serializableAppearanceObject8.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            serializableAppearanceObject8.Options.UseFont = true;
            this.dtpDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Close, "", 50, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null)});
            this.dtpDate.Properties.CalendarTimeProperties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.dtpDate.Properties.CalendarTimeProperties.ReadOnly = true;
            this.dtpDate.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.dtpDate.Properties.ContextImageOptions.SvgImageSize = new System.Drawing.Size(1, 10);
            this.dtpDate.Properties.DisplayFormat.FormatString = "yyyy/MM/dd";
            this.dtpDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dtpDate.Properties.EditFormat.FormatString = "yyyy/MM/dd";
            this.dtpDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpDate.Properties.Mask.EditMask = "yyyy/MM/dd";
            this.dtpDate.Properties.ShowNullValuePromptWhenFocused = true;
            this.dtpDate.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.MonthView;
            this.dtpDate.Size = new System.Drawing.Size(237, 47);
            this.dtpDate.TabIndex = 711;
            this.dtpDate.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.dtpDate.ToolTipTitle = "Click vào để chọn ngày";
            this.dtpDate.EditValueChanged += new System.EventHandler(this.dtpDate_EditValueChanged);
            // 
            // pnShift
            // 
            this.pnShift.Controls.Add(this.lbl_dif3);
            this.pnShift.Controls.Add(this.lbl_dif2);
            this.pnShift.Controls.Add(this.lbl_dif1);
            this.pnShift.Controls.Add(this.lbl_Shift2);
            this.pnShift.Controls.Add(this.lbl_Shift1);
            this.pnShift.Controls.Add(this.lbl_Shift3);
            this.pnShift.Location = new System.Drawing.Point(265, 107);
            this.pnShift.Name = "pnShift";
            this.pnShift.Size = new System.Drawing.Size(628, 96);
            this.pnShift.TabIndex = 712;
            // 
            // lbl_dif3
            // 
            this.lbl_dif3.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dif3.Font = new System.Drawing.Font("Calibri", 20.75F, System.Drawing.FontStyle.Bold);
            this.lbl_dif3.ForeColor = System.Drawing.Color.Blue;
            this.lbl_dif3.Location = new System.Drawing.Point(413, 48);
            this.lbl_dif3.Name = "lbl_dif3";
            this.lbl_dif3.Size = new System.Drawing.Size(205, 31);
            this.lbl_dif3.TabIndex = 711;
            this.lbl_dif3.Text = "Difference Plan";
            this.lbl_dif3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_dif2
            // 
            this.lbl_dif2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dif2.Font = new System.Drawing.Font("Calibri", 20.75F, System.Drawing.FontStyle.Bold);
            this.lbl_dif2.ForeColor = System.Drawing.Color.Blue;
            this.lbl_dif2.Location = new System.Drawing.Point(208, 48);
            this.lbl_dif2.Name = "lbl_dif2";
            this.lbl_dif2.Size = new System.Drawing.Size(205, 31);
            this.lbl_dif2.TabIndex = 710;
            this.lbl_dif2.Text = "Difference Plan";
            this.lbl_dif2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_dif1
            // 
            this.lbl_dif1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dif1.Font = new System.Drawing.Font("Calibri", 20.75F, System.Drawing.FontStyle.Bold);
            this.lbl_dif1.ForeColor = System.Drawing.Color.Blue;
            this.lbl_dif1.Location = new System.Drawing.Point(3, 48);
            this.lbl_dif1.Name = "lbl_dif1";
            this.lbl_dif1.Size = new System.Drawing.Size(205, 31);
            this.lbl_dif1.TabIndex = 709;
            this.lbl_dif1.Text = "Difference Plan";
            this.lbl_dif1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Shift2
            // 
            this.lbl_Shift2.BackColor = System.Drawing.Color.Gray;
            this.lbl_Shift2.Font = new System.Drawing.Font("Calibri", 28.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Shift2.ForeColor = System.Drawing.Color.White;
            this.lbl_Shift2.Location = new System.Drawing.Point(209, 1);
            this.lbl_Shift2.Name = "lbl_Shift2";
            this.lbl_Shift2.Size = new System.Drawing.Size(204, 45);
            this.lbl_Shift2.TabIndex = 705;
            this.lbl_Shift2.Tag = "2";
            this.lbl_Shift2.Text = "Shift 2";
            this.lbl_Shift2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Shift2.Click += new System.EventHandler(this.lbl_Shift_Click);
            // 
            // lbl_Shift1
            // 
            this.lbl_Shift1.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Shift1.Font = new System.Drawing.Font("Calibri", 28.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Shift1.ForeColor = System.Drawing.Color.White;
            this.lbl_Shift1.Location = new System.Drawing.Point(4, 1);
            this.lbl_Shift1.Name = "lbl_Shift1";
            this.lbl_Shift1.Size = new System.Drawing.Size(204, 45);
            this.lbl_Shift1.TabIndex = 696;
            this.lbl_Shift1.Tag = "1";
            this.lbl_Shift1.Text = "Shift 1";
            this.lbl_Shift1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Shift1.Click += new System.EventHandler(this.lbl_Shift_Click);
            // 
            // lbl_Shift3
            // 
            this.lbl_Shift3.BackColor = System.Drawing.Color.Gray;
            this.lbl_Shift3.Font = new System.Drawing.Font("Calibri", 28.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Shift3.ForeColor = System.Drawing.Color.White;
            this.lbl_Shift3.Location = new System.Drawing.Point(414, 1);
            this.lbl_Shift3.Name = "lbl_Shift3";
            this.lbl_Shift3.Size = new System.Drawing.Size(204, 45);
            this.lbl_Shift3.TabIndex = 704;
            this.lbl_Shift3.Tag = "3";
            this.lbl_Shift3.Text = "Shift 3";
            this.lbl_Shift3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Shift3.Click += new System.EventHandler(this.lbl_Shift_Click);
            // 
            // pn1
            // 
            this.pn1.AccessibleDescription = "";
            this.pn1.AccessibleName = "";
            this.pn1.BorderColor = System.Drawing.Color.Empty;
            this.pn1.BorderWidth = 2;
            this.pn1.Controls.Add(this.lblCMP);
            this.pn1.GradientEndColor = System.Drawing.Color.White;
            this.pn1.GradientStartColor = System.Drawing.Color.White;
            this.pn1.Image = null;
            this.pn1.ImageLocation = new System.Drawing.Point(4, 4);
            this.pn1.Location = new System.Drawing.Point(1604, 108);
            this.pn1.Name = "pn1";
            this.pn1.RoundCornerRadius = 20;
            this.pn1.ShadowOffSet = 3;
            this.pn1.Size = new System.Drawing.Size(153, 49);
            this.pn1.TabIndex = 701;
            // 
            // lblCMP
            // 
            this.lblCMP.BackColor = System.Drawing.Color.Transparent;
            this.lblCMP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCMP.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMP.ForeColor = System.Drawing.Color.Black;
            this.lblCMP.Location = new System.Drawing.Point(0, 0);
            this.lblCMP.Name = "lblCMP";
            this.lblCMP.Size = new System.Drawing.Size(153, 49);
            this.lblCMP.TabIndex = 0;
            this.lblCMP.Text = "DMC";
            this.lblCMP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCMP.Click += new System.EventHandler(this.lblCMP_Click);
            // 
            // pn2
            // 
            this.pn2.AccessibleDescription = "";
            this.pn2.AccessibleName = "";
            this.pn2.BorderColor = System.Drawing.Color.Empty;
            this.pn2.BorderWidth = 2;
            this.pn2.Controls.Add(this.lblPhylon);
            this.pn2.GradientEndColor = System.Drawing.Color.Gray;
            this.pn2.GradientStartColor = System.Drawing.Color.White;
            this.pn2.Image = null;
            this.pn2.ImageLocation = new System.Drawing.Point(4, 4);
            this.pn2.Location = new System.Drawing.Point(1763, 108);
            this.pn2.Name = "pn2";
            this.pn2.RoundCornerRadius = 20;
            this.pn2.ShadowOffSet = 3;
            this.pn2.Size = new System.Drawing.Size(153, 49);
            this.pn2.TabIndex = 700;
            // 
            // lblPhylon
            // 
            this.lblPhylon.BackColor = System.Drawing.Color.Transparent;
            this.lblPhylon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPhylon.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhylon.ForeColor = System.Drawing.Color.Black;
            this.lblPhylon.Location = new System.Drawing.Point(0, 0);
            this.lblPhylon.Name = "lblPhylon";
            this.lblPhylon.Size = new System.Drawing.Size(153, 49);
            this.lblPhylon.TabIndex = 1;
            this.lblPhylon.Text = "DMP";
            this.lblPhylon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPhylon.Click += new System.EventHandler(this.lblPhylon_Click);
            // 
            // axGrid
            // 
            this.axGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.axGrid.DataSource = null;
            this.axGrid.Location = new System.Drawing.Point(16, 209);
            this.axGrid.Name = "axGrid";
            this.axGrid.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGrid.OcxState")));
            this.axGrid.Size = new System.Drawing.Size(1893, 962);
            this.axGrid.TabIndex = 660;
            // 
            // FORM_SMT_DMP_MOLD_ACTUAL_PLAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1920, 1061);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.pnShift);
            this.Controls.Add(this.pn1);
            this.Controls.Add(this.pn2);
            this.Controls.Add(this.pnHeader);
            this.Controls.Add(this.lbl_Actual);
            this.Controls.Add(this.lbl_Plan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMold_change);
            this.Controls.Add(this.lblDmp);
            this.Controls.Add(this.axGrid);
            this.Controls.Add(this.lblDmc);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FORM_SMT_DMP_MOLD_ACTUAL_PLAN";
            this.Text = "APS Plan && Actual";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Mold_WS_Change_By_Shift_FormClosed);
            this.Load += new System.EventHandler(this.Frm_Mold_WS_Change_By_Shift_Load);
            this.VisibleChanged += new System.EventHandler(this.Frm_Mold_WS_Change_By_Shift_VisibleChanged);
            this.pnButton.ResumeLayout(false);
            this.pnHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate.Properties)).EndInit();
            this.pnShift.ResumeLayout(false);
            this.pn1.ResumeLayout(false);
            this.pn2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxFPSpreadADO.AxfpSpread axGrid;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer tmr_blind;
        private System.Windows.Forms.Label lblDmp;
        private System.Windows.Forms.Label lblDmc;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblMold_change;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Actual;
        private System.Windows.Forms.Label lbl_Plan;
        protected System.Windows.Forms.Panel pnButton;
        protected DevExpress.XtraEditors.SimpleButton cmdMonth;
        protected DevExpress.XtraEditors.SimpleButton cmdYear;
        protected DevExpress.XtraEditors.SimpleButton cmdDay;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel pnHeader;
        protected System.Windows.Forms.Button cmdBack;
        private System.Windows.Forms.Label lblTitle2;
        protected A1Panel pn2;
        protected System.Windows.Forms.Label lblPhylon;
        protected A1Panel pn1;
        protected System.Windows.Forms.Label lblCMP;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private DevExpress.XtraEditors.DateEdit dtpDate;
        private System.Windows.Forms.Panel pnShift;
        private System.Windows.Forms.Label lbl_Shift2;
        private System.Windows.Forms.Label lbl_Shift1;
        private System.Windows.Forms.Label lbl_Shift3;
        private System.Windows.Forms.Label lbl_dif3;
        private System.Windows.Forms.Label lbl_dif2;
        private System.Windows.Forms.Label lbl_dif1;
    }
}