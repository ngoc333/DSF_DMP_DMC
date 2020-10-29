namespace Smart_FTY
{
    partial class FORM_MOLD_ACTUAL_PLAN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_MOLD_ACTUAL_PLAN));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tmr_blind = new System.Windows.Forms.Timer(this.components);
            this.lblDmp = new System.Windows.Forms.Label();
            this.lblDmc = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_actual = new System.Windows.Forms.Label();
            this.lbl_plan = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_Shift = new System.Windows.Forms.Label();
            this.pn2 = new Smart_FTY.A1Panel();
            this.lblButton2 = new System.Windows.Forms.Label();
            this.pn1 = new Smart_FTY.A1Panel();
            this.lblButton1 = new System.Windows.Forms.Label();
            this.axGrid = new AxFPSpreadADO.AxfpSpread();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPlan = new System.Windows.Forms.Label();
            this.lblNoPlan = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblNoUse = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grdviewMachine = new DevExpress.XtraGrid.GridControl();
            this.gvwviewMachine = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand10 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand16 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandedGridColumn1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand11 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand17 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandedGridColumn2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn3 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand12 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand18 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandedGridColumn4 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand14 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand19 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandedGridColumn5 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand15 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand20 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandedGridColumn6 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridModel = new DevExpress.XtraGrid.GridControl();
            this.bandedGridModel = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand29 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.SHORT_NAME = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.NO = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.MOLD_INPUT = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand33 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandedGridColumn12 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.MCS = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.COLOR = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn11 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.pn2.SuspendLayout();
            this.pn1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdviewMachine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwviewMachine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridModel)).BeginInit();
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
            this.lblDmp.Location = new System.Drawing.Point(1023, 39);
            this.lblDmp.Name = "lblDmp";
            this.lblDmp.Size = new System.Drawing.Size(120, 50);
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
            this.lblDmc.Location = new System.Drawing.Point(897, 39);
            this.lblDmc.Name = "lblDmc";
            this.lblDmc.Size = new System.Drawing.Size(120, 50);
            this.lblDmc.TabIndex = 684;
            this.lblDmc.Text = "DMC";
            this.lblDmc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDmc.Visible = false;
            this.lblDmc.Click += new System.EventHandler(this.lblDmc_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.DarkTurquoise;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 45.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1920, 109);
            this.lblTitle.TabIndex = 686;
            this.lblTitle.Text = "DMC Mold Layout";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.BackColor = System.Drawing.Color.DarkTurquoise;
            this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDate.Font = new System.Drawing.Font("Calibri", 32.25F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblDate.Location = new System.Drawing.Point(1666, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(253, 109);
            this.lblDate.TabIndex = 687;
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Yellow;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(877, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 31);
            this.label6.TabIndex = 690;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(609, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 31);
            this.label1.TabIndex = 693;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_actual
            // 
            this.lbl_actual.BackColor = System.Drawing.Color.DarkOrange;
            this.lbl_actual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_actual.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_actual.ForeColor = System.Drawing.Color.White;
            this.lbl_actual.Location = new System.Drawing.Point(1494, 3);
            this.lbl_actual.Name = "lbl_actual";
            this.lbl_actual.Size = new System.Drawing.Size(172, 104);
            this.lbl_actual.TabIndex = 695;
            this.lbl_actual.Text = "Total Actual 450";
            this.lbl_actual.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_actual.Visible = false;
            this.lbl_actual.Click += new System.EventHandler(this.lbl_actual_Click);
            // 
            // lbl_plan
            // 
            this.lbl_plan.BackColor = System.Drawing.Color.Green;
            this.lbl_plan.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_plan.ForeColor = System.Drawing.Color.White;
            this.lbl_plan.Location = new System.Drawing.Point(1315, 3);
            this.lbl_plan.Name = "lbl_plan";
            this.lbl_plan.Size = new System.Drawing.Size(178, 104);
            this.lbl_plan.TabIndex = 694;
            this.lbl_plan.Text = "Total Plan  458";
            this.lbl_plan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_plan.Visible = false;
            this.lbl_plan.Click += new System.EventHandler(this.lbl_plan_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button1.BackgroundImage = global::Smart_FTY.Properties.Resources.Back_Icon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1202, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 101);
            this.button1.TabIndex = 696;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_Shift
            // 
            this.lbl_Shift.BackColor = System.Drawing.Color.Blue;
            this.lbl_Shift.Font = new System.Drawing.Font("Calibri", 20.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Shift.ForeColor = System.Drawing.Color.White;
            this.lbl_Shift.Location = new System.Drawing.Point(958, 115);
            this.lbl_Shift.Name = "lbl_Shift";
            this.lbl_Shift.Size = new System.Drawing.Size(154, 38);
            this.lbl_Shift.TabIndex = 697;
            this.lbl_Shift.Text = "SHIFT 1";
            this.lbl_Shift.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_Shift.Visible = false;
            // 
            // pn2
            // 
            this.pn2.AccessibleDescription = "";
            this.pn2.AccessibleName = "";
            this.pn2.BorderColor = System.Drawing.Color.Empty;
            this.pn2.BorderWidth = 2;
            this.pn2.Controls.Add(this.lblButton2);
            this.pn2.GradientEndColor = System.Drawing.Color.Gray;
            this.pn2.GradientStartColor = System.Drawing.Color.White;
            this.pn2.Image = null;
            this.pn2.ImageLocation = new System.Drawing.Point(4, 4);
            this.pn2.Location = new System.Drawing.Point(165, 112);
            this.pn2.Name = "pn2";
            this.pn2.RoundCornerRadius = 20;
            this.pn2.ShadowOffSet = 3;
            this.pn2.Size = new System.Drawing.Size(153, 49);
            this.pn2.TabIndex = 699;
            // 
            // lblButton2
            // 
            this.lblButton2.BackColor = System.Drawing.Color.Transparent;
            this.lblButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblButton2.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblButton2.ForeColor = System.Drawing.Color.Black;
            this.lblButton2.Location = new System.Drawing.Point(0, 0);
            this.lblButton2.Name = "lblButton2";
            this.lblButton2.Size = new System.Drawing.Size(153, 49);
            this.lblButton2.TabIndex = 1;
            this.lblButton2.Text = "DMP";
            this.lblButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblButton2.Click += new System.EventHandler(this.lblButton2_Click);
            // 
            // pn1
            // 
            this.pn1.AccessibleDescription = "";
            this.pn1.AccessibleName = "";
            this.pn1.BorderColor = System.Drawing.Color.Empty;
            this.pn1.BorderWidth = 2;
            this.pn1.Controls.Add(this.lblButton1);
            this.pn1.GradientEndColor = System.Drawing.Color.Gray;
            this.pn1.GradientStartColor = System.Drawing.Color.White;
            this.pn1.Image = null;
            this.pn1.ImageLocation = new System.Drawing.Point(4, 4);
            this.pn1.Location = new System.Drawing.Point(10, 112);
            this.pn1.Name = "pn1";
            this.pn1.RoundCornerRadius = 20;
            this.pn1.ShadowOffSet = 3;
            this.pn1.Size = new System.Drawing.Size(153, 49);
            this.pn1.TabIndex = 698;
            // 
            // lblButton1
            // 
            this.lblButton1.BackColor = System.Drawing.Color.Transparent;
            this.lblButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblButton1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblButton1.ForeColor = System.Drawing.Color.Black;
            this.lblButton1.Location = new System.Drawing.Point(0, 0);
            this.lblButton1.Name = "lblButton1";
            this.lblButton1.Size = new System.Drawing.Size(153, 49);
            this.lblButton1.TabIndex = 0;
            this.lblButton1.Text = "DMC";
            this.lblButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblButton1.Click += new System.EventHandler(this.lblButton1_Click);
            // 
            // axGrid
            // 
            this.axGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.axGrid.DataSource = null;
            this.axGrid.Location = new System.Drawing.Point(12, 160);
            this.axGrid.Name = "axGrid";
            this.axGrid.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGrid.OcxState")));
            this.axGrid.Size = new System.Drawing.Size(1893, 640);
            this.axGrid.TabIndex = 660;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Lime;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(609, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 31);
            this.label2.TabIndex = 700;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlan
            // 
            this.lblPlan.BackColor = System.Drawing.Color.DarkTurquoise;
            this.lblPlan.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.lblPlan.ForeColor = System.Drawing.Color.White;
            this.lblPlan.Location = new System.Drawing.Point(673, 22);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(198, 30);
            this.lblPlan.TabIndex = 701;
            this.lblPlan.Text = "Plan";
            this.lblPlan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPlan.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblNoPlan
            // 
            this.lblNoPlan.BackColor = System.Drawing.Color.DarkTurquoise;
            this.lblNoPlan.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.lblNoPlan.ForeColor = System.Drawing.Color.White;
            this.lblNoPlan.Location = new System.Drawing.Point(673, 65);
            this.lblNoPlan.Name = "lblNoPlan";
            this.lblNoPlan.Size = new System.Drawing.Size(198, 30);
            this.lblNoPlan.TabIndex = 702;
            this.lblNoPlan.Text = "No Plan";
            this.lblNoPlan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNoPlan.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblChange
            // 
            this.lblChange.BackColor = System.Drawing.Color.DarkTurquoise;
            this.lblChange.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.ForeColor = System.Drawing.Color.White;
            this.lblChange.Location = new System.Drawing.Point(947, 25);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(257, 30);
            this.lblChange.TabIndex = 703;
            this.lblChange.Text = "Mold Change";
            this.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNoUse
            // 
            this.lblNoUse.BackColor = System.Drawing.Color.DarkTurquoise;
            this.lblNoUse.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoUse.ForeColor = System.Drawing.Color.White;
            this.lblNoUse.Location = new System.Drawing.Point(947, 65);
            this.lblNoUse.Name = "lblNoUse";
            this.lblNoUse.Size = new System.Drawing.Size(257, 30);
            this.lblNoUse.TabIndex = 705;
            this.lblNoUse.Text = "No Use";
            this.lblNoUse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.LightGray;
            this.label8.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(877, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 31);
            this.label8.TabIndex = 704;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grdviewMachine
            // 
            this.grdviewMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdviewMachine.Location = new System.Drawing.Point(-2, 815);
            this.grdviewMachine.LookAndFeel.SkinName = "Office 2010 Blue";
            this.grdviewMachine.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdviewMachine.MainView = this.gvwviewMachine;
            this.grdviewMachine.Name = "grdviewMachine";
            this.grdviewMachine.Size = new System.Drawing.Size(824, 244);
            this.grdviewMachine.TabIndex = 706;
            this.grdviewMachine.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwviewMachine});
            // 
            // gvwviewMachine
            // 
            this.gvwviewMachine.Appearance.BandPanel.BackColor = System.Drawing.Color.Gray;
            this.gvwviewMachine.Appearance.BandPanel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvwviewMachine.Appearance.BandPanel.ForeColor = System.Drawing.Color.White;
            this.gvwviewMachine.Appearance.BandPanel.Options.UseBackColor = true;
            this.gvwviewMachine.Appearance.BandPanel.Options.UseFont = true;
            this.gvwviewMachine.Appearance.BandPanel.Options.UseForeColor = true;
            this.gvwviewMachine.Appearance.BandPanel.Options.UseTextOptions = true;
            this.gvwviewMachine.Appearance.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvwviewMachine.Appearance.BandPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gvwviewMachine.Appearance.Row.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvwviewMachine.Appearance.Row.Options.UseFont = true;
            this.gvwviewMachine.Appearance.Row.Options.UseTextOptions = true;
            this.gvwviewMachine.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvwviewMachine.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gvwviewMachine.BandPanelRowHeight = 40;
            this.gvwviewMachine.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand10,
            this.gridBand11,
            this.gridBand12,
            this.gridBand14,
            this.gridBand15});
            this.gvwviewMachine.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.bandedGridColumn1,
            this.bandedGridColumn3,
            this.bandedGridColumn2,
            this.bandedGridColumn4,
            this.bandedGridColumn5,
            this.bandedGridColumn6});
            this.gvwviewMachine.GridControl = this.grdviewMachine;
            this.gvwviewMachine.Name = "gvwviewMachine";
            this.gvwviewMachine.OptionsCustomization.AllowBandMoving = false;
            this.gvwviewMachine.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvwviewMachine.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gvwviewMachine.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gvwviewMachine.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gvwviewMachine.OptionsView.ShowColumnHeaders = false;
            this.gvwviewMachine.OptionsView.ShowGroupPanel = false;
            this.gvwviewMachine.OptionsView.ShowIndicator = false;
            this.gvwviewMachine.PaintStyleName = "Flat";
            this.gvwviewMachine.RowHeight = 28;
            // 
            // gridBand10
            // 
            this.gridBand10.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.gridBand10.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridBand10.AppearanceHeader.Options.UseBackColor = true;
            this.gridBand10.AppearanceHeader.Options.UseFont = true;
            this.gridBand10.Caption = "MACHINE NAME";
            this.gridBand10.Children.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand16});
            this.gridBand10.Name = "gridBand10";
            this.gridBand10.VisibleIndex = 0;
            this.gridBand10.Width = 273;
            // 
            // gridBand16
            // 
            this.gridBand16.AppearanceHeader.BackColor = System.Drawing.Color.Lime;
            this.gridBand16.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridBand16.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridBand16.AppearanceHeader.Options.UseBackColor = true;
            this.gridBand16.AppearanceHeader.Options.UseFont = true;
            this.gridBand16.AppearanceHeader.Options.UseForeColor = true;
            this.gridBand16.Caption = "TOTAL";
            this.gridBand16.Columns.Add(this.bandedGridColumn1);
            this.gridBand16.Name = "gridBand16";
            this.gridBand16.VisibleIndex = 0;
            this.gridBand16.Width = 273;
            // 
            // bandedGridColumn1
            // 
            this.bandedGridColumn1.Caption = "MACHINE_NAME";
            this.bandedGridColumn1.FieldName = "MACHINE_NAME";
            this.bandedGridColumn1.Name = "bandedGridColumn1";
            this.bandedGridColumn1.Visible = true;
            this.bandedGridColumn1.Width = 273;
            // 
            // gridBand11
            // 
            this.gridBand11.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.gridBand11.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridBand11.AppearanceHeader.Options.UseBackColor = true;
            this.gridBand11.AppearanceHeader.Options.UseFont = true;
            this.gridBand11.Caption = "MOLD CAPACITY";
            this.gridBand11.Children.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand17});
            this.gridBand11.Name = "gridBand11";
            this.gridBand11.VisibleIndex = 1;
            this.gridBand11.Width = 174;
            // 
            // gridBand17
            // 
            this.gridBand17.AppearanceHeader.BackColor = System.Drawing.Color.Lime;
            this.gridBand17.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridBand17.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridBand17.AppearanceHeader.Options.UseBackColor = true;
            this.gridBand17.AppearanceHeader.Options.UseFont = true;
            this.gridBand17.AppearanceHeader.Options.UseForeColor = true;
            this.gridBand17.Columns.Add(this.bandedGridColumn2);
            this.gridBand17.Columns.Add(this.bandedGridColumn3);
            this.gridBand17.Name = "gridBand17";
            this.gridBand17.VisibleIndex = 0;
            this.gridBand17.Width = 174;
            // 
            // bandedGridColumn2
            // 
            this.bandedGridColumn2.Caption = "MOLD";
            this.bandedGridColumn2.FieldName = "MOLD";
            this.bandedGridColumn2.Name = "bandedGridColumn2";
            this.bandedGridColumn2.Visible = true;
            this.bandedGridColumn2.Width = 174;
            // 
            // bandedGridColumn3
            // 
            this.bandedGridColumn3.Caption = "MACHINE_TYPE";
            this.bandedGridColumn3.FieldName = "MACHINE_TYPE";
            this.bandedGridColumn3.Name = "bandedGridColumn3";
            this.bandedGridColumn3.Width = 106;
            // 
            // gridBand12
            // 
            this.gridBand12.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.gridBand12.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridBand12.AppearanceHeader.Options.UseBackColor = true;
            this.gridBand12.AppearanceHeader.Options.UseFont = true;
            this.gridBand12.Caption = "MOLD INPUT";
            this.gridBand12.Children.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand18});
            this.gridBand12.Name = "gridBand12";
            this.gridBand12.VisibleIndex = 2;
            this.gridBand12.Width = 136;
            // 
            // gridBand18
            // 
            this.gridBand18.AppearanceHeader.BackColor = System.Drawing.Color.Lime;
            this.gridBand18.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.gridBand18.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridBand18.AppearanceHeader.Options.UseBackColor = true;
            this.gridBand18.AppearanceHeader.Options.UseFont = true;
            this.gridBand18.AppearanceHeader.Options.UseForeColor = true;
            this.gridBand18.Columns.Add(this.bandedGridColumn4);
            this.gridBand18.Name = "gridBand18";
            this.gridBand18.VisibleIndex = 0;
            this.gridBand18.Width = 136;
            // 
            // bandedGridColumn4
            // 
            this.bandedGridColumn4.Caption = "INPUT";
            this.bandedGridColumn4.FieldName = "INPUT";
            this.bandedGridColumn4.Name = "bandedGridColumn4";
            this.bandedGridColumn4.Visible = true;
            this.bandedGridColumn4.Width = 136;
            // 
            // gridBand14
            // 
            this.gridBand14.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.gridBand14.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridBand14.AppearanceHeader.Options.UseBackColor = true;
            this.gridBand14.AppearanceHeader.Options.UseFont = true;
            this.gridBand14.Caption = "BALANCE";
            this.gridBand14.Children.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand19});
            this.gridBand14.Name = "gridBand14";
            this.gridBand14.VisibleIndex = 3;
            this.gridBand14.Width = 115;
            // 
            // gridBand19
            // 
            this.gridBand19.AppearanceHeader.BackColor = System.Drawing.Color.Lime;
            this.gridBand19.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.gridBand19.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridBand19.AppearanceHeader.Options.UseBackColor = true;
            this.gridBand19.AppearanceHeader.Options.UseFont = true;
            this.gridBand19.AppearanceHeader.Options.UseForeColor = true;
            this.gridBand19.Columns.Add(this.bandedGridColumn5);
            this.gridBand19.Name = "gridBand19";
            this.gridBand19.VisibleIndex = 0;
            this.gridBand19.Width = 115;
            // 
            // bandedGridColumn5
            // 
            this.bandedGridColumn5.Caption = "BALANCE";
            this.bandedGridColumn5.FieldName = "BALANCE";
            this.bandedGridColumn5.Name = "bandedGridColumn5";
            this.bandedGridColumn5.Visible = true;
            this.bandedGridColumn5.Width = 115;
            // 
            // gridBand15
            // 
            this.gridBand15.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.gridBand15.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridBand15.AppearanceHeader.Options.UseBackColor = true;
            this.gridBand15.AppearanceHeader.Options.UseFont = true;
            this.gridBand15.Caption = "QTY";
            this.gridBand15.Children.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand20});
            this.gridBand15.Name = "gridBand15";
            this.gridBand15.VisibleIndex = 4;
            this.gridBand15.Width = 122;
            // 
            // gridBand20
            // 
            this.gridBand20.AppearanceHeader.BackColor = System.Drawing.Color.Lime;
            this.gridBand20.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.gridBand20.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridBand20.AppearanceHeader.Options.UseBackColor = true;
            this.gridBand20.AppearanceHeader.Options.UseFont = true;
            this.gridBand20.AppearanceHeader.Options.UseForeColor = true;
            this.gridBand20.Columns.Add(this.bandedGridColumn6);
            this.gridBand20.Name = "gridBand20";
            this.gridBand20.VisibleIndex = 0;
            this.gridBand20.Width = 122;
            // 
            // bandedGridColumn6
            // 
            this.bandedGridColumn6.Caption = "QTY";
            this.bandedGridColumn6.FieldName = "QTY";
            this.bandedGridColumn6.Name = "bandedGridColumn6";
            this.bandedGridColumn6.Visible = true;
            this.bandedGridColumn6.Width = 122;
            // 
            // gridModel
            // 
            this.gridModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridModel.Location = new System.Drawing.Point(974, 815);
            this.gridModel.LookAndFeel.SkinName = "Office 2010 Blue";
            this.gridModel.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridModel.MainView = this.bandedGridModel;
            this.gridModel.Name = "gridModel";
            this.gridModel.Size = new System.Drawing.Size(931, 244);
            this.gridModel.TabIndex = 707;
            this.gridModel.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridModel});
            // 
            // bandedGridModel
            // 
            this.bandedGridModel.Appearance.BandPanel.BackColor = System.Drawing.Color.Gray;
            this.bandedGridModel.Appearance.BandPanel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bandedGridModel.Appearance.BandPanel.ForeColor = System.Drawing.Color.White;
            this.bandedGridModel.Appearance.BandPanel.Options.UseBackColor = true;
            this.bandedGridModel.Appearance.BandPanel.Options.UseFont = true;
            this.bandedGridModel.Appearance.BandPanel.Options.UseForeColor = true;
            this.bandedGridModel.Appearance.BandPanel.Options.UseTextOptions = true;
            this.bandedGridModel.Appearance.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridModel.Appearance.BandPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridModel.Appearance.Row.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bandedGridModel.Appearance.Row.Options.UseFont = true;
            this.bandedGridModel.Appearance.Row.Options.UseTextOptions = true;
            this.bandedGridModel.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridModel.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridModel.BandPanelRowHeight = 40;
            this.bandedGridModel.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand29,
            this.gridBand2,
            this.gridBand33});
            this.bandedGridModel.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.NO,
            this.SHORT_NAME,
            this.MCS,
            this.COLOR,
            this.bandedGridColumn11,
            this.bandedGridColumn12,
            this.MOLD_INPUT});
            this.bandedGridModel.GridControl = this.gridModel;
            this.bandedGridModel.Name = "bandedGridModel";
            this.bandedGridModel.OptionsCustomization.AllowBandMoving = false;
            this.bandedGridModel.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.bandedGridModel.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.bandedGridModel.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.bandedGridModel.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.bandedGridModel.OptionsView.ShowColumnHeaders = false;
            this.bandedGridModel.OptionsView.ShowGroupPanel = false;
            this.bandedGridModel.OptionsView.ShowIndicator = false;
            this.bandedGridModel.PaintStyleName = "Flat";
            this.bandedGridModel.RowHeight = 28;
            // 
            // gridBand29
            // 
            this.gridBand29.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.gridBand29.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridBand29.AppearanceHeader.Options.UseBackColor = true;
            this.gridBand29.AppearanceHeader.Options.UseFont = true;
            this.gridBand29.Caption = "MODEL NAME";
            this.gridBand29.Children.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand3});
            this.gridBand29.Name = "gridBand29";
            this.gridBand29.VisibleIndex = 0;
            this.gridBand29.Width = 131;
            // 
            // gridBand3
            // 
            this.gridBand3.AppearanceHeader.BackColor = System.Drawing.Color.Lime;
            this.gridBand3.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.gridBand3.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridBand3.AppearanceHeader.Options.UseBackColor = true;
            this.gridBand3.AppearanceHeader.Options.UseFont = true;
            this.gridBand3.AppearanceHeader.Options.UseForeColor = true;
            this.gridBand3.Caption = "TOTAL";
            this.gridBand3.Columns.Add(this.SHORT_NAME);
            this.gridBand3.Columns.Add(this.NO);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 0;
            this.gridBand3.Width = 131;
            // 
            // SHORT_NAME
            // 
            this.SHORT_NAME.Caption = "SHORT_NAME";
            this.SHORT_NAME.FieldName = "SHORT_NAME";
            this.SHORT_NAME.Name = "SHORT_NAME";
            this.SHORT_NAME.Visible = true;
            this.SHORT_NAME.Width = 131;
            // 
            // NO
            // 
            this.NO.Caption = "NO";
            this.NO.FieldName = "NO";
            this.NO.Name = "NO";
            this.NO.Width = 159;
            // 
            // gridBand2
            // 
            this.gridBand2.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.gridBand2.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridBand2.AppearanceHeader.Options.UseBackColor = true;
            this.gridBand2.AppearanceHeader.Options.UseFont = true;
            this.gridBand2.Caption = "MOLD INPUT";
            this.gridBand2.Children.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand4});
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 75;
            // 
            // gridBand4
            // 
            this.gridBand4.AppearanceHeader.BackColor = System.Drawing.Color.Lime;
            this.gridBand4.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.gridBand4.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridBand4.AppearanceHeader.Options.UseBackColor = true;
            this.gridBand4.AppearanceHeader.Options.UseFont = true;
            this.gridBand4.AppearanceHeader.Options.UseForeColor = true;
            this.gridBand4.Columns.Add(this.MOLD_INPUT);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 0;
            this.gridBand4.Width = 75;
            // 
            // MOLD_INPUT
            // 
            this.MOLD_INPUT.Caption = "MOLD_INPUT";
            this.MOLD_INPUT.FieldName = "MOLD_INPUT";
            this.MOLD_INPUT.Name = "MOLD_INPUT";
            this.MOLD_INPUT.Visible = true;
            // 
            // gridBand33
            // 
            this.gridBand33.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.gridBand33.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridBand33.AppearanceHeader.Options.UseBackColor = true;
            this.gridBand33.AppearanceHeader.Options.UseFont = true;
            this.gridBand33.Caption = "PLAN";
            this.gridBand33.Children.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand5});
            this.gridBand33.Name = "gridBand33";
            this.gridBand33.VisibleIndex = 2;
            this.gridBand33.Width = 80;
            // 
            // gridBand5
            // 
            this.gridBand5.AppearanceHeader.BackColor = System.Drawing.Color.Lime;
            this.gridBand5.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.gridBand5.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridBand5.AppearanceHeader.Options.UseBackColor = true;
            this.gridBand5.AppearanceHeader.Options.UseFont = true;
            this.gridBand5.AppearanceHeader.Options.UseForeColor = true;
            this.gridBand5.Columns.Add(this.bandedGridColumn12);
            this.gridBand5.Name = "gridBand5";
            this.gridBand5.VisibleIndex = 0;
            this.gridBand5.Width = 80;
            // 
            // bandedGridColumn12
            // 
            this.bandedGridColumn12.Caption = "QTY";
            this.bandedGridColumn12.FieldName = "QTY";
            this.bandedGridColumn12.Name = "bandedGridColumn12";
            this.bandedGridColumn12.Visible = true;
            this.bandedGridColumn12.Width = 80;
            // 
            // MCS
            // 
            this.MCS.Caption = "MCS";
            this.MCS.FieldName = "MCS";
            this.MCS.Name = "MCS";
            this.MCS.Visible = true;
            this.MCS.Width = 104;
            // 
            // COLOR
            // 
            this.COLOR.Caption = "COLOR";
            this.COLOR.FieldName = "COLOR";
            this.COLOR.Name = "COLOR";
            this.COLOR.Visible = true;
            this.COLOR.Width = 79;
            // 
            // bandedGridColumn11
            // 
            this.bandedGridColumn11.Caption = "MOLD";
            this.bandedGridColumn11.FieldName = "MOLD";
            this.bandedGridColumn11.Name = "bandedGridColumn11";
            this.bandedGridColumn11.Visible = true;
            this.bandedGridColumn11.Width = 80;
            // 
            // FORM_MOLD_ACTUAL_PLAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1920, 1062);
            this.Controls.Add(this.gridModel);
            this.Controls.Add(this.grdviewMachine);
            this.Controls.Add(this.lblNoUse);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.lblNoPlan);
            this.Controls.Add(this.lblPlan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pn2);
            this.Controls.Add(this.pn1);
            this.Controls.Add(this.lbl_Shift);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_actual);
            this.Controls.Add(this.lbl_plan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDmp);
            this.Controls.Add(this.lblDmc);
            this.Controls.Add(this.axGrid);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FORM_MOLD_ACTUAL_PLAN";
            this.Text = "Production Status";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Mold_WS_Change_By_Shift_FormClosed);
            this.Load += new System.EventHandler(this.Frm_Mold_WS_Change_By_Shift_Load);
            this.Shown += new System.EventHandler(this.FORM_MOLD_ACTUAL_PLAN_Shown);
            this.VisibleChanged += new System.EventHandler(this.Frm_Mold_WS_Change_By_Shift_VisibleChanged);
            this.pn2.ResumeLayout(false);
            this.pn1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdviewMachine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwviewMachine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridModel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxFPSpreadADO.AxfpSpread axGrid;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer tmr_blind;
        private System.Windows.Forms.Label lblDmp;
        private System.Windows.Forms.Label lblDmc;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_actual;
        private System.Windows.Forms.Label lbl_plan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_Shift;
        protected A1Panel pn1;
        protected System.Windows.Forms.Label lblButton1;
        protected A1Panel pn2;
        protected System.Windows.Forms.Label lblButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.Label lblNoPlan;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblNoUse;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraGrid.GridControl grdviewMachine;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView gvwviewMachine;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand10;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand16;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand11;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand17;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand12;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand18;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn4;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand14;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand19;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn5;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand15;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand20;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn6;
        private DevExpress.XtraGrid.GridControl gridModel;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridModel;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand29;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn SHORT_NAME;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn NO;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn MOLD_INPUT;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand33;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn12;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn MCS;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn COLOR;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn11;
    }
}