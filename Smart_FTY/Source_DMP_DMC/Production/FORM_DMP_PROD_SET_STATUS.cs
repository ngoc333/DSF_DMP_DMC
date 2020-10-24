using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Drawing.Drawing2D;
using Microsoft.VisualBasic.PowerPacks;
using FPUSpreadADO;
//using C1.Win.C1FlexGrid;

namespace Smart_FTY
{
    public partial class FORM_DMP_PROD_SET_STATUS : Form
    {
        bool _load = true;
        DataTable _dt = null;
        int icount = 0;
        int _rowTotal = 3;
        public string[] judul_plan;

        public FORM_DMP_PROD_SET_STATUS()
        {
            InitializeComponent();           
        }
        #region Variable
        DataTable dt = null;
        #endregion
       
        #region Func

        private void GoFullscreen(bool fullscreen)
        {
            if (fullscreen)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }
        }

        private void CreateGridSpan()
        {
            try
            {
                int startMline = 3;
                int startStyle = 3;


                for (int i = 2; i <= axGrid.MaxRows + 1; i++)
                {
                    if (GetText(axGrid, 1, i - 1) + GetText(axGrid, 0, i) != " ")
                    {
                        if (GetText(axGrid, 1, i)  != GetText(axGrid, 1, startMline))
                        {
                            axGrid.AddCellSpan(1, startMline, 1, i - startMline);
                            startMline = i;
                        }
                    }
                }
                
            }
            catch (Exception ex)
            { }
        }

        private string GetText(AxFPUSpreadADO.AxfpSpread spread, int col, int row)
        {
            try
            {
                object data = null;
                spread.GetText(col, row, ref data);
                return data.ToString();
            }
            catch (Exception ex)
            {
               
                return null;
            }

        }

        int rownum = 0;

        private void load_data()
        {
            try
            {

                panel2.Visible = false;
                
                DataTable dtG = null;
                DataSet ds = LOAD_DATA_v3();
                if (ds.Tables.Count == 2)
                {
                    dt = ds.Tables[1];
                    dtG = ds.Tables[0];
                }

                lblTitle.Text = dtG.Rows[0]["title"].ToString();

                if (dt != null && dt.Rows.Count > 0)
                {

                    //  int icol = 1;
                   // bool bTotal = true;
                    //int irow = 3;
                   // _dt = dt;
                   
                   // axGrid.ClearRange(1, 3, axGrid.MaxCols, axGrid.MaxRows, true);

                   //SetTextGrid(0, irow, dt);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        axGrid.set_RowHeight(i+3, 27.42);
                        axGrid.SetText(1, i + 3, dt.Rows[i ]["STYLE_NAME"].ToString());
                        axGrid.SetText(2, i + 3, dt.Rows[i]["STYLE_CD"].ToString());
                        if(dt.Rows[i]["PLAN"].ToString() == "0")
                        {
                            axGrid.SetText(3, i + 3, "");
                        } else
                        {
                            axGrid.SetText(3, i + 3, dt.Rows[i]["PLAN"].ToString());
                        }
                        if (dt.Rows[i]["TOTAL"].ToString() == "0")
                        {
                            axGrid.SetText(4, i + 3, "");
                        }
                        else
                        {
                            axGrid.SetText(4, i + 3, dt.Rows[i]["TOTAL"].ToString());
                        }
                        if (dt.Rows[i]["COL06"].ToString() == "0")
                        {
                            axGrid.SetText(5, i + 3, "");
                        }
                        else
                        {
                            axGrid.SetText(5, i + 3, dt.Rows[i]["COL06"].ToString());
                        }
                        if (dt.Rows[i]["COL08"].ToString() == "0")
                        {
                            axGrid.SetText(6, i + 3, "");
                        }
                        else
                        {
                            axGrid.SetText(6, i + 3, dt.Rows[i]["COL08"].ToString());
                        }
                        if (dt.Rows[i]["COL10"].ToString() == "0")
                        {
                            axGrid.SetText(7, i + 3, "");
                        }
                        else
                        {
                            axGrid.SetText(7, i + 3, dt.Rows[i]["COL10"].ToString());
                        }
                        if (dt.Rows[i]["COL12"].ToString() == "0")
                        {
                            axGrid.SetText(8, i + 3, "");
                        }
                        else
                        {
                            axGrid.SetText(8, i + 3, dt.Rows[i]["COL12"].ToString());
                        }


                        if (dt.Rows[i]["PLAN1"].ToString() == "0")
                        {
                            axGrid.SetText(9, i + 3, "");
                        }
                        else
                        {
                            axGrid.SetText(9, i + 3, dt.Rows[i]["PLAN1"].ToString());
                        }
                        if (dt.Rows[i]["TOTAL1"].ToString() == "0")
                        {
                            axGrid.SetText(10, i + 3, "");
                        }
                        else
                        {
                            axGrid.SetText(10, i + 3, dt.Rows[i]["TOTAL1"].ToString());
                        }
                        if (dt.Rows[i]["COL14"].ToString() == "0")
                        {
                            axGrid.SetText(11, i + 3, "");
                        }
                        else
                        {
                            axGrid.SetText(11, i + 3, dt.Rows[i]["COL14"].ToString());
                        }
                        if (dt.Rows[i]["COL16"].ToString() == "0")
                        {
                            axGrid.SetText(12, i + 3, "");
                        }
                        else
                        {
                            axGrid.SetText(12, i + 3, dt.Rows[i]["COL16"].ToString());
                        }
                        if (dt.Rows[i]["COL18"].ToString() == "0")
                        {
                            axGrid.SetText(13, i + 3, "");
                        }
                        else
                        {
                            axGrid.SetText(13, i + 3, dt.Rows[i]["COL18"].ToString());
                        }
                        if (dt.Rows[i]["COL20"].ToString() == "0")
                        {
                            axGrid.SetText(14, i + 3, "");
                        }
                        else
                        {
                            axGrid.SetText(14, i + 3, dt.Rows[i]["COL20"].ToString());
                        }
                        if (dt.Rows[i]["PLAN2"].ToString() == "0")
                        {
                            axGrid.SetText(15, i + 3, "");
                        }
                        else
                        {
                            axGrid.SetText(15, i + 3, dt.Rows[i]["PLAN2"].ToString());
                        }
                        if (dt.Rows[i]["TOTAL2"].ToString() == "0")
                        {
                            axGrid.SetText(16, i + 3, "");
                        }
                        else
                        {
                            axGrid.SetText(16, i + 3, dt.Rows[i]["TOTAL2"].ToString());
                        }


                        if (dt.Rows[i]["COL22"].ToString() == "0")
                        {
                            axGrid.SetText(17, i + 3, "");
                        }
                        else
                        {
                            axGrid.SetText(17, i + 3, dt.Rows[i]["COL22"].ToString());
                        }
                        if (dt.Rows[i]["COL00"].ToString() == "0")
                        {
                            axGrid.SetText(18, i + 3, "");
                        }
                        else
                        {
                            axGrid.SetText(18, i + 3, dt.Rows[i]["COL00"].ToString());
                        }
                        if (dt.Rows[i]["COL02"].ToString() == "0")
                        {
                            axGrid.SetText(19, i + 3, "");
                        }
                        else
                        {
                            axGrid.SetText(19, i + 3, dt.Rows[i]["COL02"].ToString());
                        }
                        if (dt.Rows[i]["COL04"].ToString() == "0")
                        {
                            axGrid.SetText(20, i + 3, "");
                        }
                        else
                        {
                            axGrid.SetText(20, i + 3, dt.Rows[i]["COL04"].ToString());
                        }
                        if (dt.Rows[i]["PLAN3"].ToString() == "0")
                        {
                            axGrid.SetText(21, i + 3, "");
                        }
                        else
                        {
                            axGrid.SetText(21, i + 3, dt.Rows[i]["PLAN3"].ToString());
                        }
                        if (dt.Rows[i]["TOTAL3"].ToString() == "0")
                        {
                            axGrid.SetText(22, i + 3, "");
                        }
                        else
                        {
                            axGrid.SetText(22, i + 3, dt.Rows[i]["TOTAL3"].ToString());
                        }
                   
                    }
                    for (int i = dt.Rows.Count + 3; i <= axGrid.MaxRows; i++)
                    {
                        axGrid.set_RowHeight(i, 0);
                    }

                   
                    axGrid.RowsFrozen = 2;
                    CreateGridSpan();
                   // axGrid.SetCellBorder(1, irow, axGrid.MaxCols, axGrid.MaxRows, FPUSpreadADO.CellBorderIndexConstants.CellBorderIndexLeft, 0, FPUSpreadADO.CellBorderStyleConstants.CellBorderStyleBlank);
                   // axGrid.SetCellBorder(1, irow, axGrid.MaxCols, axGrid.MaxRows, FPUSpreadADO.CellBorderIndexConstants.CellBorderIndexTop, 0, FPUSpreadADO.CellBorderStyleConstants.CellBorderStyleBlank);

                   // axGrid.SetCellBorder(1, 3, axGrid.MaxCols, irow, FPUSpreadADO.CellBorderIndexConstants.CellBorderIndexLeft, 0, FPUSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
                   // axGrid.SetCellBorder(1, 3, axGrid.MaxCols, irow, FPUSpreadADO.CellBorderIndexConstants.CellBorderIndexTop, 0, FPUSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
                   // axGrid.SetCellBorder(1, irow + 1, axGrid.MaxCols, irow + 1, FPUSpreadADO.CellBorderIndexConstants.CellBorderIndexTop, 0, FPUSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);

                    rownum = dt.Rows.Count;
                   this.panel2.Location = new System.Drawing.Point(Convert.ToInt32(dt.Rows[0]["COL"]), 45); //Convert.ToInt32(dt.Rows[0]["COL"])
                    //this.panel2.Location = new System.Drawing.Point(Convert.ToInt32(dt.Rows[0]["COL"]), 110);
                    //this.panel2.Location = new System.Drawing.Point(242, 45);

                   panel2.Visible = true;
                   panel2.Size = new Size(100, 980);//Size(100, (axGrid.MaxRows + 1) * 50); //980
                    panel2.Refresh();
                    panel2.BringToFront();
                   // axGrid.RowsFrozen = irow;
                  
                }


            }
            catch (Exception)
            {
            }
           
        }

        private void setColor(int arg_col, int arg_row, Color arg_color)
        {
            axGrid.Row = arg_row;
            axGrid.Col = arg_col;
            axGrid.BackColor = arg_color;
        }

        private void SetTextGrid(int arg_i, int arg_row, DataTable arg_dt)
        {
            int icol=3;
            switch (arg_dt.Rows[arg_i]["ti"].ToString().ToUpper())
            {
                case "PLAN":
                    icol = 3;
                    break; 
                case "TOTAL":
                    icol = 4;                
                    break;               
                case "06":
                    icol = 5;
                    break;
                case "08":
                    icol = 6;
                    break;
                case "10":
                    icol = 7;
                    break;
                case "12":
                    icol = 8;
                    break;
                case "PLAN1":
                    icol = 9;
                    break;
                case "TOTAL1":
                    icol = 10;
                    break;
                case "14":
                    icol = 11;
                    break;
                case "16":
                    icol = 12;
                    break;
                case "18":
                    icol = 13;
                    break;
                case "20":
                    icol = 14;
                    break;
                case "PLAN2":
                    icol = 15;
                    break;
                case "TOTAL2":
                    icol = 16;
                    break;
                case "22":
                    icol = 17;
                    break;
                case "00":
                    icol = 18;
                    break;
                case "02":
                    icol = 19;
                    break;
                case "04":
                    icol = 20;
                    break;
                case "PLAN3":
                    icol = 21;
                    break;
                case "TOTAL3":
                    icol = 22;
                    break;

            }

            

            axGrid.SetText(1, arg_row, arg_dt.Rows[arg_i]["style_name"].ToString());
            axGrid.SetText(2, arg_row, arg_dt.Rows[arg_i]["style_cd"].ToString());

            axGrid.Col = icol;
            axGrid.Row = arg_row;
            axGrid.TypeHAlign = TypeHAlignConstants.TypeHAlignRight;


            axGrid.SetText(icol, arg_row, arg_dt.Rows[arg_i]["qty"].ToString());
            

            


        }





        #endregion Func

        #region DB
        private DataTable LOAD_DATA()
        {           
            try
            {
                COM.OraDB MyOraDB = new COM.OraDB();
                System.Data.DataSet ds_ret;

                string process_name = "SEPHIROTH.PKG_DMC.SEL_PROD_SET_STATUS";
                //ARGMODE
                MyOraDB.ReDim_Parameter(1);
                MyOraDB.Process_Name = process_name;
                MyOraDB.Parameter_Name[0] = "OUT_CURSOR";
                MyOraDB.Parameter_Type[0] = (char)OracleType.Cursor;
                MyOraDB.Parameter_Values[0] = "";
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


        public DataSet LOAD_DATA_v3()
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            System.Data.DataSet ds_ret;

            try
            {
                string process_name = "SEPHIROTH.PKG_DMC.SEL_PROD_SET_STATUS_DMP_V3";

                MyOraDB.ReDim_Parameter(2);
                MyOraDB.Process_Name = process_name;


                MyOraDB.Parameter_Name[0] = "OUT_CURSOR1";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = "";
                MyOraDB.Parameter_Values[1] = "";

                MyOraDB.Add_Select_Parameter(true);
                ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret;
            }
            catch
            {
                return null;
            }
        }

        #endregion DB

        #region event
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                icount++;
                lblDate.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd\nHH:mm:ss"));
                if (icount >= 20)
                {
                    load_data();
                    icount = 0;
                }
                //else if (_load && icount ==1)
                //{
                //    load_data();
                //    _load = false;
                //}
            }
            catch (Exception)
            {} 
        }

      


        private void FORM_IPEX3_LOGISTIC_VisibleChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.Visible)
                {
                    icount = 19;
                    //_load = true;
                    timer1.Start();
                    panel2.BringToFront();

                   // load_data();
                }
                //else
                //{
                    //timer1.Stop();
                //}
            }
            catch (Exception)
            {}
                
        }

       

        private void FORM_IPEX3_LOGISTIC_Load(object sender, EventArgs e)
        {
            try
            {
                lblDate.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd\nHH:mm:ss"));
                GoFullscreen(true);
                panel2.Visible = false;

              //  load_data();
            }
            catch (Exception)
            {}
            
        }

        private void lblDate_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception)
            {}

        }

        #endregion event


        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            try
            {

                Size size = new Size(68, ((rownum) * 41)+45);

                // Size size = new Size(58, 5 * 57 + 49);
                System.Drawing.Point location = new System.Drawing.Point(10, 20);

                Pen pen = new Pen(Color.Blue, 5);
                e.Graphics.DrawRectangle(pen, new System.Drawing.Rectangle(location, size));
            }
            catch (Exception ex)
            { 
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Smart_FTY.ComVar._frm_home_dmp_dmc.Show();   
            this.Hide();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            load_data();
        }




    }
}
