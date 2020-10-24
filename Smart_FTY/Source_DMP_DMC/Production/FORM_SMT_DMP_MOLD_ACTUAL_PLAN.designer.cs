namespace Smart_FTY
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tmr_blind = new System.Windows.Forms.Timer(this.components);
            this.lblDmp = new System.Windows.Forms.Label();
            this.lblDmc = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblMold_change = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_actual = new System.Windows.Forms.Label();
            this.lbl_plan = new System.Windows.Forms.Label();
            this.lbl_Shift = new System.Windows.Forms.Label();
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
            this.pn1 = new Smart_FTY.A1Panel();
            this.lblCMP = new System.Windows.Forms.Label();
            this.pn2 = new Smart_FTY.A1Panel();
            this.lblPhylon = new System.Windows.Forms.Label();
            this.axGrid = new AxFPSpreadADO.AxfpSpread();
            this.pnButton.SuspendLayout();
            this.pnHeader.SuspendLayout();
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
            this.lblDmp.Location = new System.Drawing.Point(1776, 114);
            this.lblDmp.Name = "lblDmp";
            this.lblDmp.Size = new System.Drawing.Size(142, 61);
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
            this.lblDmc.Location = new System.Drawing.Point(1626, 114);
            this.lblDmc.Name = "lblDmc";
            this.lblDmc.Size = new System.Drawing.Size(148, 61);
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
            this.lblMold_change.Location = new System.Drawing.Point(1136, 109);
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
            this.label1.Location = new System.Drawing.Point(1196, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 30);
            this.label1.TabIndex = 693;
            this.label1.Text = "Plan/Acual";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Visible = false;
            // 
            // lbl_actual
            // 
            this.lbl_actual.BackColor = System.Drawing.Color.DarkOrange;
            this.lbl_actual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_actual.Font = new System.Drawing.Font("Calibri", 18.75F, System.Drawing.FontStyle.Bold);
            this.lbl_actual.ForeColor = System.Drawing.Color.White;
            this.lbl_actual.Location = new System.Drawing.Point(1379, 141);
            this.lbl_actual.Name = "lbl_actual";
            this.lbl_actual.Size = new System.Drawing.Size(225, 32);
            this.lbl_actual.TabIndex = 695;
            this.lbl_actual.Text = "Total Actual: 450";
            this.lbl_actual.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_actual.Click += new System.EventHandler(this.lbl_actual_Click);
            // 
            // lbl_plan
            // 
            this.lbl_plan.BackColor = System.Drawing.Color.Green;
            this.lbl_plan.Font = new System.Drawing.Font("Calibri", 18.75F, System.Drawing.FontStyle.Bold);
            this.lbl_plan.ForeColor = System.Drawing.Color.White;
            this.lbl_plan.Location = new System.Drawing.Point(1379, 110);
            this.lbl_plan.Name = "lbl_plan";
            this.lbl_plan.Size = new System.Drawing.Size(225, 30);
            this.lbl_plan.TabIndex = 694;
            this.lbl_plan.Text = "Total Plan:  458";
            this.lbl_plan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_plan.Click += new System.EventHandler(this.lbl_plan_Click);
            // 
            // lbl_Shift
            // 
            this.lbl_Shift.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Shift.Font = new System.Drawing.Font("Calibri", 30.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Shift.ForeColor = System.Drawing.Color.White;
            this.lbl_Shift.Location = new System.Drawing.Point(686, 121);
            this.lbl_Shift.Name = "lbl_Shift";
            this.lbl_Shift.Size = new System.Drawing.Size(204, 52);
            this.lbl_Shift.TabIndex = 696;
            this.lbl_Shift.Text = "Shift 1";
            this.lbl_Shift.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.pn1.Location = new System.Drawing.Point(16, 118);
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
            this.pn2.Location = new System.Drawing.Point(175, 118);
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
            this.axGrid.Location = new System.Drawing.Point(16, 181);
            this.axGrid.Name = "axGrid";
            this.axGrid.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGrid.OcxState")));
            this.axGrid.Size = new System.Drawing.Size(1893, 993);
            this.axGrid.TabIndex = 660;
            //this.axGrid.BeforeEditMode += new AxFPSpreadADO._DSpreadEvents_BeforeEditModeEventHandler(this.axGrid_BeforeEditMode);
            // 
            // FORM_SMT_DMP_MOLD_ACTUAL_PLAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1920, 1064);
            this.Controls.Add(this.pn1);
            this.Controls.Add(this.pn2);
            this.Controls.Add(this.pnHeader);
            this.Controls.Add(this.lbl_Shift);
            this.Controls.Add(this.lbl_actual);
            this.Controls.Add(this.lbl_plan);
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
        private System.Windows.Forms.Label lbl_actual;
        private System.Windows.Forms.Label lbl_plan;
        private System.Windows.Forms.Label lbl_Shift;
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
    }
}