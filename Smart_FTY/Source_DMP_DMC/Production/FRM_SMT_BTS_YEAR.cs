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
using System.Runtime.InteropServices;

namespace Smart_FTY
{
    public partial class FRM_SMT_BTS_YEAR : Form
    {
        public FRM_SMT_BTS_YEAR()
        {
            InitializeComponent();
            opcd = "DMP";
        }
        [DllImport("user32")]
        static extern bool AnimateWindow(IntPtr hwnd, int time, int flags);
        const int AW_SLIDE = 0X40000;
        const int AW_HOR_POSITIVE = 0X4;
        const int AW_HOR_NEGATIVE = 0X2;
        const int AW_BLEND = 0X80000;
        const int AW_HIDE = 0x00010000;
        int indexScreen;
        string line, mline, Lang, opcd;
        public FRM_SMT_BTS_YEAR(string title, int _indexScreen, string _line, string _mline,string _Lang)
        {
            InitializeComponent();
            indexScreen = _indexScreen;
            line = _line;
            mline = _mline;
            Lang = _Lang;
           lbltitle.Text = title;
        }
        int int_count = 0;
        Color BackColor1 = Color.FromArgb(232, 246, 247);
        Color BackColor2 = Color.White;
        private void FRM_SMT_BTS_YEAR_Load(object sender, EventArgs e)
        {
            //ClassLib.ComCtl.Form_Maximized(this, indexScreen); //2 man hinh tro len
            switch (Lang)
            {
                case "Vn":
                    simpleButton4.Text = "Ngày";
                    simpleButton1.Text = "Tuần";
                    simpleButton2.Text = "Tháng";
                    simpleButton3.Text = "Năm";
                    break;
                case "En":
                    simpleButton4.Text = "Day";
                    simpleButton1.Text = "Week";
                    simpleButton2.Text = "Month";
                    simpleButton3.Text = "Year";
                    break;
            }
         //   load_data();
         //   CreateChart();
        }
        private void showAnimation(Control flg)
        {
            flg.Hide();
            this.Cursor = Cursors.WaitCursor;
            load_data();
            AnimateWindow(flg.Handle, 300, AW_SLIDE | 0X4); //IPEX_Monitor.ClassLib.WinAPI.getSlidType("2")
            flg.Show();
            this.Cursor = Cursors.Default;
        }
      
        private void CreateChart()
        {
            try
            {
                //chartBTS.AppearanceNameSerializable = "Chameleon";
                Series series1 = new Series("BTS", ViewType.Bar);
                chartBTS.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged;
                DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
                DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();

                Series series2 = new Series("Target", ViewType.Line);
                DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();

                lineSeriesView1.MarkerVisibility = DevExpress.Utils.DefaultBoolean.False;
                sideBySideBarSeriesView1.ColorEach = false;
                sideBySideBarSeriesView1.Color = System.Drawing.Color.LimeGreen;
                sideBySideBarSeriesView1.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Solid;
                series1.Label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                series1.Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                series1.Label.TextPattern = "{V:#,#.0}" + "%";
                series1.View = sideBySideBarSeriesView1;                
                series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;

                series2.Label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
                series2.Label.TextPattern = "{V:#,#.0}" + "%";
                lineSeriesView1.Color = System.Drawing.Color.LimeGreen;
                lineSeriesView1.LineMarkerOptions.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(208)))), ((int)(((byte)(80)))));
                lineSeriesView1.LineStyle.Thickness = 4;
                series2.View = lineSeriesView1;

                DataTable dt = SEL_SMT_BTS_YEAR("C", line, mline,opcd, UC_YEAR.GetValue().ToString());

                if (dt != null && dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        series1.Points.Add(new SeriesPoint(dt.Rows[i]["DAY"].ToString(), dt.Rows[i]["BTS"]));
                        series2.Points.Add(new SeriesPoint(dt.Rows[i]["DAY"].ToString(), dt.Rows[i]["TARGET"]));

                        if (Convert.ToDouble(dt.Rows[i]["BTS"]) < Convert.ToDouble(dt.Rows[i]["TARGET"]) && Convert.ToDouble(dt.Rows[i]["BTS"]) >= Convert.ToDouble(dt.Rows[i]["TARGET"]) - 5)
                            series1.Points[i].Color = Color.Yellow;
                        else if (Convert.ToDouble(dt.Rows[i]["BTS"]) < Convert.ToDouble(dt.Rows[i]["TARGET"]) - 5)
                            series1.Points[i].Color = Color.Red;
                        else
                            series1.Points[i].Color = System.Drawing.Color.LimeGreen;

                    }

                    chartBTS.SeriesSerializable = new DevExpress.XtraCharts.Series[] { series1, series2 };

                    ((XYDiagram)chartBTS.Diagram).AxisX.Label.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    ((XYDiagram)chartBTS.Diagram).AxisX.Title.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
                    ((XYDiagram)chartBTS.Diagram).AxisY.Label.TextPattern = "{V:#,#}";
                    ((XYDiagram)chartBTS.Diagram).AxisY.Label.Font = new System.Drawing.Font("Tahoma", 13F);
                    ((XYDiagram)chartBTS.Diagram).AxisY.Title.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    ((XYDiagram)chartBTS.Diagram).AxisY.Title.Text = "BTS (%)";
                    ((XYDiagram)chartBTS.Diagram).AxisY.Title.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));

                }       
            }
            catch (Exception EX)
            {
            }
        }

        public DataTable SEL_SMT_BTS_YEAR(string ARG_QTYPE, string ARG_LINE, string ARG_MLINE,string ARG_OPCD, string ARG_DATE)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;
            try
            {
                string process_name = "MES.PKG_SMT_PROD.SP_SMT_BTS_B_YEAR";

                MyOraDB.ReDim_Parameter(6);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "V_P_TYPE";
                MyOraDB.Parameter_Name[1] = "V_P_LINE";
                MyOraDB.Parameter_Name[2] = "V_P_MLINE";
                MyOraDB.Parameter_Name[3] = "V_P_OPCD";
                MyOraDB.Parameter_Name[4] = "V_P_DATE";

                MyOraDB.Parameter_Name[5] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = ARG_QTYPE;
                MyOraDB.Parameter_Values[1] = ARG_LINE;
                MyOraDB.Parameter_Values[2] = ARG_MLINE;
                MyOraDB.Parameter_Values[3] = ARG_OPCD;
                MyOraDB.Parameter_Values[4] = ARG_DATE;
                MyOraDB.Parameter_Values[5] = "";

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

        private void ClearGrid(AxFPSpreadADO.AxfpSpread Grid)
        {
            for (int irow = 3; irow <= Grid.MaxRows; irow++)
            {
                Grid.Row = irow;
                for (int icol = 1; icol <= Grid.MaxCols; icol++)
                {
                    Grid.Col = icol;
                    if (icol > 1)
                    {
                        Grid.SetText(icol, irow, "");
                    }
                    if (irow < Grid.MaxRows)
                    {
                        switch (irow % 2)
                        {
                            case 0:
                                Grid.BackColor = BackColor1;
                                Grid.ForeColor = Color.Black;
                                break;
                            case 1:
                                Grid.BackColor = BackColor2;
                                Grid.ForeColor = Color.Black;
                                break;
                        }
                        Grid.Font = new Font("Calibri", 14, FontStyle.Regular);
                    }
                    else
                    {
                        Grid.BackColor = Color.Orange ;
                        Grid.ForeColor = Color.White;
                        Grid.Font = new Font("Calibri", 14, FontStyle.Bold);
                    }
                    
                }

                axfpSpread.set_RowHeight(irow, 30);
            }
            axfpSpread.RowsFrozen = 2;
        }

        private void load_data()
        {
            try
            {                
                load_head();
                ClearGrid(axfpSpread);
                DataTable dt = SEL_SMT_BTS_YEAR("Q", line, mline,opcd, UC_YEAR.GetValue().ToString());
                if (dt != null && dt.Rows.Count > 0)
                {
                    axfpSpread.MaxRows = dt.Rows.Count + 2;                    
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 1; j < dt.Columns.Count; j++)
                        {
                            axfpSpread.SetText(j + 1, i + 3, dt.Rows[i][j].ToString() == "" ? "" : dt.Rows[i][j].ToString());
                            //axfpSpread.SetText(j, i + 3, "2,999");
                        }
                    }
                }               
                CreateChart();
            }
            catch
            {
               
            }
        }
        private void load_head()
        {
            try
            {
                DataTable dt = SEL_SMT_BTS_YEAR("H", line, mline,opcd, UC_YEAR.GetValue().ToString());
                int i;
                if (dt != null && dt.Rows.Count > 0)
                {
                    //axfpSpread.SetText(1, 1, dt.Rows[0]["MON"].ToString());
                    //axfpSpread.set_ColWidth(1, 16.7);
                    for (i = 0; i < dt.Rows.Count; i++)
                    {
                        if (dt.Rows[i]["CUR"].ToString() == "1")
                        {
                            axfpSpread.Row = 1;
                            axfpSpread.Col = i + 2;
                            axfpSpread.BackColor = Color.Salmon;
                            axfpSpread.Row = 2;
                            axfpSpread.Col = i + 2;
                            axfpSpread.BackColor = Color.Salmon;
                        }
                        axfpSpread.SetText(i + 2, 1, dt.Rows[i]["YEAR"].ToString());
                        axfpSpread.SetText(i + 2, 2, dt.Rows[i]["MON"].ToString());
                        //axfpSpread.set_ColWidth(i + 2, (double)221 / (double)(dt.Rows.Count));
                    }
                    //axfpSpread.set_ColWidth(1, 16.6 + 220 - axfpSpread.get_ColWidth(i + 1) * dt.Rows.Count);
                    //for (int j = i + 2; j <= axfpSpread.MaxCols; j++)
                    //{
                    //    axfpSpread.set_ColWidth(j, 0);
                    //}
                }

            }
            catch
            {
            }
        }

        private void chartBTS_CustomDrawAxisLabel(object sender, CustomDrawAxisLabelEventArgs e)
        {
            try
            {
                if (e.Item.Axis is AxisX)
                {
                    e.Item.Text = e.Item.Text.Replace("_", "-");
                }
            }
            catch
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }
        
        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                if (int_count < 20)
                    int_count++;
                else
                {
                    int_count = 0;
                    showAnimation(axfpSpread);
                }
            }
            catch
            {
            }
        }

        private void lbltitle_Click(object sender, EventArgs e)
        {
            load_data();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FRM_SMT_BTS_YEAR_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                int_count = 20;
                timer2.Start();
            }
            else
                timer2.Stop();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
           


            string Caption = "BTS by Month";
            switch (Lang)
            {
                case "Vn":
                    Caption = "BTS theo tháng";
                    break;
                default:
                    Caption = "BTS by Month";
                    break;
            }
            Form fc = Application.OpenForms["FRM_SMT_BTS"];
            if (fc != null)
            {
                //fc.Close();
                fc.Show();
                ////f.TopMost = true;
            }
            else
            {
                FRM_SMT_BTS f = new FRM_SMT_BTS(Caption, 1, line, mline, Lang);
                f.Show();
                //f.TopMost = true;
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {

        }

        private void UC_YEAR_ValueChangeEvent(object sender, EventArgs e)
        {
            load_data();
        }

        private void lblDMC_Click(object sender, EventArgs e)
        {
            pnDMC.GradientEndColor = Color.White;//Color.FromArgb(255, 128, 128);
            pnDMP.GradientEndColor = Color.Gray;
            opcd = "DMC";
            showAnimation(axfpSpread);
        }

        private void lblDMP_Click(object sender, EventArgs e)
        {
            pnDMC.GradientEndColor = Color.Gray;//Color.FromArgb(255, 128, 128);
            pnDMP.GradientEndColor = Color.White;
            opcd = "DMP";
            showAnimation(axfpSpread);
        }
    }
}
