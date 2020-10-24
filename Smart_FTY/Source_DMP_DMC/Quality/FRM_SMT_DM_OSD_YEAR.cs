﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
//using JPlatform.Client.Controls;


namespace Smart_FTY
{
    public partial class FRM_SMT_DM_OSD_YEAR : Form
    {
        public FRM_SMT_DM_OSD_YEAR()
        {
            InitializeComponent();
        }

        int cnt = 0;
        string str_op = "";
        public delegate void MenuHandler();
        public MenuHandler OnClick = null;

        #region db
        //Addons.Database db = new Addons.Database();
        #endregion
        #region UC
        //UC.UC_DWMY uc = new UC.UC_DWMY(4);
        #endregion

        private void FRM_ROLL_SLABTEST_MON_Load(object sender, EventArgs e)
        {            
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 1000;
            //pnYMD.Controls.Add(uc);
            //uc.OnDWMYClick += DWMYClick;
        }

        void DWMYClick(string ButtonCap, string ButtonCD)
        {
            //MessageBox.Show(ButtonCap + "    " + ButtonCD);
            switch (ButtonCD)
            {
                case "C":
                    this.Close();
                    break;
                case "M":
                    this.Close();
                    Form fc = Application.OpenForms["FRM_SMT_DM_OSD_MONTH"];
                    if (fc != null)
                        fc.Show();
                    else
                    {
                        FRM_SMT_DM_OSD_MONTH f = new FRM_SMT_DM_OSD_MONTH();
                        f.Show();
                    }
                    break;
                case "Y":
                    this.Close();
                    Form fc1 = Application.OpenForms["FRM_SMT_DM_OSD_YEAR"];
                    if (fc1 != null)
                        fc1.Show();
                    else
                    {
                        FRM_SMT_DM_OSD_YEAR f1 = new FRM_SMT_DM_OSD_YEAR();
                        f1.Show();
                    }
                    break;
            }
        }

        public DataTable SEL_OS_OSD_YEAR_V2(string ARG_QTYPE, string ARG_YMD, string ARG_OP)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;

            try
            {
                string process_name = "MES.PKG_SMT_B1.SP_PH_OSD_YEAR_V3";

                MyOraDB.ReDim_Parameter(4);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "V_P_TYPE";
                MyOraDB.Parameter_Name[1] = "V_P_YMD";
                MyOraDB.Parameter_Name[2] = "V_P_OP";
                MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = ARG_QTYPE;
                MyOraDB.Parameter_Values[1] = ARG_YMD;
                MyOraDB.Parameter_Values[2] = ARG_OP;
                MyOraDB.Parameter_Values[3] = "";

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


        private void formatband()
        {
            try
            {
                int n;
                DataTable dtsource = null;
                dtsource = SEL_OS_OSD_YEAR_V2("H", uc_year.GetValue().ToString(), "");
                if (dtsource != null && dtsource.Rows.Count > 0)
                {
                    string name;
                    //bandYear.Caption = dtsource.Rows[0]["MON"].ToString();
                    if (dtsource.Rows.Count > 0)
                    {
                        foreach (DevExpress.XtraGrid.Views.BandedGrid.GridBand band in gvwView.Bands[1].Children)
                        {
                            double num;
                            if (double.TryParse(band.Caption, out num))
                            {
                                for (int i = 0; i < dtsource.Rows.Count; i++)
                                {
                                    if (band.Name.Contains(dtsource.Rows[i][0].ToString().Substring(dtsource.Rows[i][0].ToString().Length - 2)))
                                    {
                                        band.Visible = true;
                                        break;
                                    }
                                    if (i == dtsource.Rows.Count - 1)
                                    {
                                        band.Visible = false;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void BindingData(string arg_op)
        {
            grdView.Refresh();
            DataTable dtsource = null;
            dtsource = SEL_OS_OSD_YEAR_V2("Q", uc_year.GetValue().ToString(), arg_op);
            //formatband();
            grdView.DataSource = dtsource;
            if (dtsource != null && dtsource.Rows.Count > 0)
            {

                bandYear.Caption = dtsource.Rows[0]["YYYY"].ToString();
                for (int i = 0; i < gvwView.Columns.Count; i++)
                {
                    gvwView.Columns[i].OptionsColumn.ReadOnly = true;
                    gvwView.Columns[i].OptionsColumn.AllowEdit = false;
                    gvwView.Columns[i].OptionsFilter.AllowFilter = false;
                    gvwView.Columns[i].OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
                    gvwView.Columns[i].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    gvwView.Columns[i].AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                   
                    gvwView.Columns[i].AppearanceCell.Font = new System.Drawing.Font("Calibri", 16, FontStyle.Bold);
                   
                }
            }
        }

        private void bindingdatachart(string arg_op)
        {
            try
            {
                DataTable dt = null;
                dt = SEL_OS_OSD_YEAR_V2("C", uc_year.GetValue().ToString(), arg_op);
                chartSlabtest.DataSource = dt;
                chartSlabtest.Series[0].ArgumentDataMember = "MON";
                chartSlabtest.Series[0].ValueDataMembers.AddRange(new string[] { "OSD1" });
                chartSlabtest.Series[1].ArgumentDataMember = "MON";
                chartSlabtest.Series[1].ValueDataMembers.AddRange(new string[] { "OSD2" });
                chartSlabtest.Series[2].ArgumentDataMember = "MON";
                chartSlabtest.Series[2].ValueDataMembers.AddRange(new string[] { "RATE" });

                //chartSlabtest.
            }
            catch
            {

            }

        }

        private void gvwView_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.Column.ColumnHandle == 2)
            {
                e.Appearance.BackColor = Color.LightGray;//Color.FromArgb(80, 209, 244);
                e.Appearance.ForeColor = Color.Black;
                e.Appearance.Font = new System.Drawing.Font("Calibri", 16, FontStyle.Bold);
            }
            else
            {
                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            if (cnt < 40)
            {
                cnt++;                
            }
            else
            {
                cnt = 0;
                BindingData("DMP");
                bindingdatachart("DMP");                
            }
        }

        private void FRM_ROLL_SLABTEST_MON_VisibleChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.Visible)
                {                             
                   
                    timer1.Start();
                    cnt = 40;
                }
                else
                    timer1.Stop();
            }
            catch
            {

            }
        }

        private void uc_year_ValueChangeEvent(object sender, EventArgs e)
        {
            try
            {
                BindingData("DMP");
                bindingdatachart("DMP");  
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Smart_FTY.ComVar._frm_home_dmp_dmc.Show();
            this.Hide();
        }

        private void cmdMonth_Click(object sender, EventArgs e)
        {
            
            Form fc = Application.OpenForms["FRM_SMT_DM_OSD_MONTH"];
            if (fc != null)
                fc.Show();
            else
            {
                FRM_SMT_DM_OSD_MONTH f = new FRM_SMT_DM_OSD_MONTH();
                f.Show();
            }
            this.Close();
        }       
    }
}
