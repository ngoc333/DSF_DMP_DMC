﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
using DevExpress.XtraCharts;
using System.Globalization;

namespace Smart_FTY
{
    public partial class FORM_SMT_DMP_DMC_PROD_YEAR : SampleFrm2
    {
        public FORM_SMT_DMP_DMC_PROD_YEAR()
        {
            InitializeComponent();
            lblTitle.Text = "DMC Production Status by Year";         
            this.Name = "FORM_SMT_DMP_DMC_PROD_YEAR";
            this.Text = "FORM_SMT_DMP_DMC_PROD_YEAR";
        }

        public static string _sProcess = "DMC";
        public int iCount = 0;

        private void FORM_SMT_DMP_DMC_PROD_YEAR_Load(object sender, EventArgs e)
        {
            //lblRubber_Click(null, null);
            //Search_Data();
            pnRubber.GradientEndColor = Color.White;//Color.FromArgb(255, 128, 128);
            pnEVA.GradientEndColor = Color.Gray;
            lblTitle.Text = "DMC Production Status by Year";
            _sProcess = "DMC";  
            tmr_Load.Interval = 1000;
            //tmr_Load.Start();
        }

        public DataTable SEL_OS_PROD_YEAR(string ARG_QTYPE, string ARG_OP)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;

            try
            {
                string process_name = "MES.PKG_SMT_DMP_DMC.SP_DMP_DMC_PROD_YEAR";

                MyOraDB.ReDim_Parameter(3);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "V_P_TYPE";
                MyOraDB.Parameter_Name[1] = "V_P_OP";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = ARG_QTYPE;
                MyOraDB.Parameter_Values[1] = ARG_OP;
                MyOraDB.Parameter_Values[2] = "";

                MyOraDB.Add_Select_Parameter(true);
                ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[process_name];
            }
            catch
            {
                return null;
            }
        }

        private void BindingData(string arg_op)
        {
            grdView.Refresh();
            DataTable dtsource = null;
            dtsource = SEL_OS_PROD_YEAR("Q", arg_op);
            grdView.DataSource = dtsource;
            if (dtsource != null && dtsource.Rows.Count > 0)
            {

                for (int i = 0; i < gvwView.Columns.Count; i++)
                {
                    gvwView.Columns[i].OptionsColumn.ReadOnly = true;
                    gvwView.Columns[i].OptionsColumn.AllowEdit = false;
                    gvwView.Columns[i].OptionsFilter.AllowFilter = false;
                    gvwView.Columns[i].OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
                    gvwView.Columns[i].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    gvwView.Columns[i].AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                    if (i > 0)
                    {
                        gvwView.Columns[i].AppearanceCell.Font = new System.Drawing.Font("Calibri", 12, FontStyle.Bold);
                    }

                }

            }
        }

        private void bindingdatachart(string arg_op)
        {
            DataTable dt = null;
            dt = SEL_OS_PROD_YEAR("C", arg_op);
            chartSlabtest.DataSource = dt;
            chartSlabtest.Series[0].ArgumentDataMember = "YMD";
            chartSlabtest.Series[0].ValueDataMembers.AddRange(new string[] { "PLAN_QTY" });
            chartSlabtest.Series[1].ArgumentDataMember = "YMD";
            chartSlabtest.Series[1].ValueDataMembers.AddRange(new string[] { "PROD_QTY" });
            chartSlabtest.Series[2].ArgumentDataMember = "YMD";
            chartSlabtest.Series[2].ValueDataMembers.AddRange(new string[] { "POD" });
            //chartControl1.Series[1].ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical;
        }

        private void tmr_Load_Tick(object sender, EventArgs e)
        {
            iCount++;
            if (iCount >= 40)
            {
                if (_sProcess == "DMC")
                    lblRubber_Click(null, null);
                else
                    lblEVA_Click(null, null);
                iCount = 0;
            }
        }

        private void lblEVA_Click(object sender, EventArgs e)
        {
            pnEVA.GradientEndColor = Color.White; //Color.FromArgb(255, 128, 128);
            pnRubber.GradientEndColor = Color.Gray;
            lblTitle.Text = "DMP Production Status by Year";
            _sProcess = "DMP";
          
            BindingData(_sProcess);
            bindingdatachart(_sProcess);
            iCount = 0;
        }

        private void lblRubber_Click(object sender, EventArgs e)
        {
            pnRubber.GradientEndColor = Color.White;//Color.FromArgb(255, 128, 128);
            pnEVA.GradientEndColor = Color.Gray;
            lblTitle.Text = "DMC Production Status by Year";
            _sProcess = "DMC";    
            BindingData(_sProcess);
            bindingdatachart(_sProcess);
            iCount = 0;
        }

        private void FORM_SMT_DMP_DMC_PROD_YEAR_VisibleChanged(object sender, EventArgs e)
        {

            if (this.Visible)
            {
                iCount = 39;
                tmr_Load.Start();
                tmrTime.Start();
            }
            else
            {
                tmr_Load.Stop();
                tmrTime.Stop();
            }
        }

        private void chartSlabtest_CustomDrawAxisLabel(object sender, CustomDrawAxisLabelEventArgs e)
        {
            try
            {
                if (e.Item.Axis is AxisX)
                {
                    e.Item.Text = e.Item.Text.Replace("_", "\n");
                }
            }
            catch
            {

            }
        }

        private void gvwView_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.Column.ColumnHandle == 1)
            {
                e.Appearance.BackColor = Color.LightGray;//Color.FromArgb(80, 209, 244);
                e.Appearance.ForeColor = Color.Black;
                e.Appearance.Font = new System.Drawing.Font("Calibri", 16, FontStyle.Bold);
            }
            else
            {

            }
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            Smart_FTY.ComVar._frm_home_dmp_dmc.Show();
            this.Hide();
        }

        private void cmdDay_Click(object sender, EventArgs e)
        {
            this.Hide();
           // Form fc = Application.OpenForms["FORM_SMT_DMP_DMC_PROD_DAILY"];
            Form fc = Application.OpenForms["FRM_DMP_DMC_PROD_DAIYSHIFT"];
            if (fc != null)
                fc.Show();
            else
            {
                FRM_DMP_DMC_PROD_DAIYSHIFT f = new FRM_DMP_DMC_PROD_DAIYSHIFT();
               // FRM_DMP_DMC_PROD_DAILY f = new FRM_DMP_DMC_PROD_DAILY();
                f.Show();
            }
        }

        private void cmdYear_Click(object sender, EventArgs e)
        {

        }

        private void cmdMonth_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form fc = Application.OpenForms["FORM_SMT_DMP_DMC_PROD_MONTH"];
            if (fc != null)
                fc.Show();
            else
            {
                FORM_SMT_DMP_DMC_PROD_MONTH f = new FORM_SMT_DMP_DMC_PROD_MONTH();
                f.Show();
            }
        }
    }
}
