using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Data.OracleClient;
//using MaterialSetRate;
using System.Data.SqlClient;
//using ChartDirector;
using System.Threading;
using FPSpreadADO;
using AxFPSpreadADO;
//using Smart_FTY.ClassLib;


namespace Smart_FTY
{

    

    public partial class FORM_MOLD_ACTUAL_PLAN : Form
    {
        public FORM_MOLD_ACTUAL_PLAN()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        public FORM_MOLD_ACTUAL_PLAN(string _process)
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            _status = _process;
            if (_process == "DMC")
            {
                lblTitle.Text = "DMC Mold Layout";
                //lblButton1.Enabled = false;
                //lblButton2.Enabled = true;
                //lblButton1.BackColor = Color.White;
                //lblButton1.SendToBack();
                //pn1.BringToFront();
                pn1.GradientEndColor = Color.White;
                pn2.GradientEndColor = Color.Gray;
                pn1.Enabled = false;
                pn2.Enabled = true;
            }
            if (_process == "DMP")
            {
                lblTitle.Text = "DMP Mold Layout";
                pn2.GradientEndColor = Color.White;
                pn1.GradientEndColor = Color.Gray;
                pn2.Enabled = false;
                pn1.Enabled = true;
                //lblButton1.Enabled = true;
                //lblButton2.Enabled = false;
                //lblButton2.BackColor = Color.White;
                //lblButton2.SendToBack();
                //pn2.BringToFront();
            }
        }



        #region Init

        string _status ;
        public int _Izone = 1;
       // string _lbl1, _lbl2, _lbl3;
        public int _time = 0;
        int _time_load = 20;
        int _time_auto = 0;
        int _countP = 0, _countN = 0, _countR = 0 , _countNU = 0;
        DataTable _dt_layout_DMC = null;
        DataTable _dt_layout_DMP = null;
      //  string[] str_yellow;
        int _iColor = 0;
        bool _load_form = true;
        int _iCount = 0;
        bool _bLoad = true;
        //int _bf_clickRow=0, _bf_clickCol=0;
    

        
        //FORM_MOLD_PRODUCTION_POP _pop_change = new FORM_MOLD_PRODUCTION_POP();
        //FORM_MOLD_PRODUCTION_POP_PRE _pop_change_pre = new FORM_MOLD_PRODUCTION_POP_PRE();
      //  Thread th;
         
        List<string> _Loc_change_DMC = new List<string>();
        List<string> _Loc_plan_DMC = new List<string>();
        List<string> _Loc_change_DMP = new List<string>();
        List<string> _Loc_plan_DMP = new List<string>();

        ArrayList a = new ArrayList();

        #endregion Init

        #region Function


        private void set_qty()
        {
            lblPlan.Text = "Plan: " + _countP + " set";
            lblNoPlan.Text = "No Plan: " + _countN + " set";
            lblChange.Text = "Mold Change: " + _countR + " set";
            lblNoUse.Text = "No Use: " + _countNU + " set";
        }
        private void GoFullscreen()
        {
           
            //if (fullscreen)
            //{
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
            //}
            //else
            //{
            //    this.WindowState = FormWindowState.Maximized;
            //    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            //}
        }

        private void create_default(AxfpSpread arg_grid)
        {
            try
            {
                int iRowHeight, iFontSize;
                double iColWidth;

                if (_status == "DMC")
                {
                    iRowHeight = 18;
                    iColWidth = 6.5;
                    iFontSize = 12;
                }
                else
                {
                    iRowHeight = 20;
                    iColWidth = 9.8;
                    iFontSize = 12;
                }

                axGrid.Reset();
                axGrid.DisplayColHeaders = false;
                axGrid.DisplayRowHeaders = false;
                axGrid.ActiveCellHighlightStyle = ActiveCellHighlightStyleConstants.ActiveCellHighlightStyleOff;
                axGrid.ColHeaderRows = 0;
                axGrid.ScrollBars = ScrollBarsConstants.ScrollBarsNone;
                axGrid.Font = new System.Drawing.Font("Calibri", iFontSize);
                axGrid.BorderStyle = BorderStyleConstants.BorderStyleNone;

                // axGrid.BorderStyle = BorderStyleConstants.BorderStyleNone;
                axGrid.set_RowHeight(1, 0.5);
                //axGrid.set_RowHeight(20, 9);
                //axGrid.set_ColWidth((int)G.S1_Blank, 5.37);
                axGrid.set_ColWidth(1, 0.5);
                //axGrid.set_ColWidth((int)G.S3_Blank, 5.37);
                //axGrid.set_ColWidth((int)G.Blank1, 13.62);
                //axGrid.set_ColWidth((int)G.Blank2, 13.62);
                axGrid.TypeHAlign = TypeHAlignConstants.TypeHAlignCenter;
                axGrid.TypeVAlign = TypeVAlignConstants.TypeVAlignCenter;
                axGrid.SetCellBorder(1, 1, 150, axGrid.MaxRows, CellBorderIndexConstants.CellBorderIndexLeft, 0, CellBorderStyleConstants.CellBorderStyleBlank);
                axGrid.SetCellBorder(1, 1, 150, axGrid.MaxRows, CellBorderIndexConstants.CellBorderIndexBottom, 0, CellBorderStyleConstants.CellBorderStyleBlank);
                //  axGrid.SetCellBorder((int)G.S1_M1_L_Plan, 1, (int)G.S3_M2_R_Act, axGrid.MaxRows, CellBorderIndexConstants.CellBorderIndexTop, 0, CellBorderStyleConstants.CellBorderStyleBlank);


                //  axGrid.SetCellBorder((int)G.S1_M1_L_Tar, 1, (int)G.S3_M2_R_Cur, axGrid.MaxRows, CellBorderIndexConstants.CellBorderIndexOutline, 0, CellBorderStyleConstants.CellBorderStyleBlank);
                

                for (int irow = 2; irow <= 50; irow++)
                    axGrid.set_RowHeight(irow, iRowHeight);

                for (int icol = 2; icol <= 150; icol++)
                    axGrid.set_ColWidth(icol, iColWidth);
            }
            catch (Exception)
            {}            
        }

        #region DMC

        private void MachineCenterText(int arg_col, int arg_row, int arg_idt, DataTable arg_dt, AxfpSpread arg_grid)
        {
            int iColPlus = Convert.ToInt32(arg_dt.Rows[arg_idt]["col_cen"]);
            int iRowPlus = Convert.ToInt32(arg_dt.Rows[arg_idt]["row_cen"]);
            //arg_grid.AddCellSpan(arg_col + (iColPlus - 1), arg_row + (iRowPlus - 1), iColPlus, iRowPlus);
            arg_grid.AddCellSpan(arg_col + 1, arg_row - (iRowPlus -1), iColPlus, iRowPlus);
            arg_grid.Col = arg_col + 1;
            arg_grid.Row = arg_row - (iRowPlus - 1);
            arg_grid.TypeEditMultiLine = true;
            arg_grid.FontBold = true;
            arg_grid.FontSize = 18f;
            arg_grid.BackColor = Color.FromArgb(242, 226, 213);
            
            arg_grid.SetText(arg_col + 1, arg_row - (iRowPlus -1),
                             arg_dt.Rows[arg_idt]["text_cen"].ToString().Replace("-","\n"));


            //int c = Convert.ToInt32(arg_dt.Rows[arg_idt]["line"].ToString());

            //for (int i = 1; i <= c; i++)
            //{

            //    arg_grid.Row = arg_row;
            //    arg_grid.Col = arg_col + i;
            //    arg_grid.BackColor = Color.FromArgb(244, 140, 65);
            //}
                
            //arg_grid.SetCellBorder(arg_col + 1, arg_row, arg_col + c, arg_row
            //                          , CellBorderIndexConstants.CellBorderIndexLeft, 0x418cf4
            //                          , CellBorderStyleConstants.CellBorderStyleSolid);
            //arg_grid.SetCellBorder(arg_col + 1, arg_row, arg_col + c, arg_row
            //                      , CellBorderIndexConstants.CellBorderIndexBottom, 0x418cf4
            //                      , CellBorderStyleConstants.CellBorderStyleSolid);
           
        }

        //private void MachineCenterBG(int arg_col, int arg_row, int arg_idt, DataTable arg_dt, AxfpSpread arg_grid)
        //{
        //    int c = Convert.ToInt32(arg_dt.Rows[arg_idt]["line"].ToString());

        //    for (int i = 1; i <= c; i++)
        //    {

        //        arg_grid.Row = arg_row;
        //        arg_grid.Col = arg_col + i;
        //        arg_grid.BackColor = Color.FromArgb(242, 226, 213);
        //    }

        //    arg_grid.SetCellBorder(arg_col + 1, arg_row, arg_col + c, arg_row
        //                              , CellBorderIndexConstants.CellBorderIndexLeft, 0xd5e2f2
        //                              , CellBorderStyleConstants.CellBorderStyleSolid);
        //    arg_grid.SetCellBorder(arg_col + 1, arg_row, arg_col + c, arg_row
        //                          , CellBorderIndexConstants.CellBorderIndexBottom, 0xd5e2f2
        //                          , CellBorderStyleConstants.CellBorderStyleSolid);

        //}


        private void MachineHeadDMC(int arg_col, int arg_row, int arg_idt, DataTable arg_dt, AxfpSpread arg_grid)
        {
            try
            {
                //axGrid.AddCellSpan(icol, irow
                //                    , Convert.ToInt32(_dt_layout.Rows[idt]["line"].ToString()) * 2
                //                    , 1);
                arg_grid.Col = arg_col;
                arg_grid.Row = arg_row;
                arg_grid.set_RowHeight(arg_row, 20);
                arg_grid.Text = arg_dt.Rows[arg_idt]["MACHINE_NAME"].ToString();
                arg_grid.Font = new System.Drawing.Font("Calibri", 15, FontStyle.Bold);
                arg_grid.BackColor = Color.DodgerBlue;
                arg_grid.ForeColor = Color.White;
                arg_grid.TypeVAlign = TypeVAlignConstants.TypeVAlignCenter;

                arg_grid.AddCellSpan(arg_col, arg_row
                                    , Convert.ToInt32(arg_dt.Rows[arg_idt]["line"].ToString())
                                    , 1);
            }
            catch
            {
            }
        }

        public void MachineBodyDMC(int arg_col, int arg_row, int arg_idt, DataTable arg_dt, AxfpSpread arg_grid)
        {
            try
            {

                arg_grid.SetCellBorder(arg_col, arg_row, arg_col, arg_row, CellBorderIndexConstants.CellBorderIndexLeft, 0, CellBorderStyleConstants.CellBorderStyleSolid);
                arg_grid.SetCellBorder(arg_col + 1, arg_row, arg_col + 1, arg_row, CellBorderIndexConstants.CellBorderIndexLeft, 0, CellBorderStyleConstants.CellBorderStyleSolid);
                arg_grid.SetCellBorder(arg_col, arg_row, arg_col, arg_row, CellBorderIndexConstants.CellBorderIndexBottom, 0, CellBorderStyleConstants.CellBorderStyleSolid);
                arg_grid.SetCellBorder(arg_col, arg_row, arg_col, arg_row, CellBorderIndexConstants.CellBorderIndexTop, 0, CellBorderStyleConstants.CellBorderStyleSolid);

                arg_grid.Row = arg_row;
                arg_grid.Col = arg_col;
                arg_grid.Text = _dt_layout_DMC.Rows[arg_idt]["size_plan"].ToString();
                if (arg_dt.Rows[arg_idt]["USE_YN"].ToString() == "Y")
                {
                    if (arg_dt.Rows[arg_idt]["color_B_value"].ToString() == "LIME")
                    {
                        arg_grid.BackColor = Color.Lime;
                        _countP++;
                    }
                    else if (arg_dt.Rows[arg_idt]["color_B_value"].ToString() == "RED")
                    {
                        arg_grid.BackColor = Color.Red;
                        _countN++;

                    }
                    else
                    {
                        arg_grid.BackColor = Color.Yellow;
                        _countR++;
                    }

                    // arg_grid.BackColor = Color.FromName(arg_dt.Rows[arg_idt]["L_color_B_value"].ToString());

                }
                else
                {
                    arg_grid.BackColor = Color.LightGray;
                    _countNU++;

                }
              //  arg_grid.BackColor = Color.FromName(arg_dt.Rows[arg_idt]["color_B_value"].ToString());
                arg_grid.ForeColor = Color.FromName(arg_dt.Rows[arg_idt]["color_F_value"].ToString());
          

                //if (arg_dt.Rows[arg_idt]["Status"].ToString() == "1")
                //    _Loc_plan_DMC.Add(arg_col + " " + arg_row + " " + arg_dt.Rows[arg_idt]["machine_id"].ToString());
                //if (arg_dt.Rows[arg_idt]["Status"].ToString() == "2")
                //    _Loc_change_DMC.Add(arg_col  + " " + arg_row + " " + arg_dt.Rows[arg_idt]["machine_id"].ToString());

                //if (arg_dt.Rows[arg_idt]["direction"].ToString() == "1")
                //{
                //    arg_col++;
                //}
                //else if (arg_dt.Rows[arg_idt]["direction"].ToString() == "2")
                //{
                //    arg_row++;
                //}
                //else if (arg_dt.Rows[arg_idt]["direction"].ToString() == "3")
                //{
                //    arg_col--;
                //}
                //else if (arg_dt.Rows[arg_idt]["direction"].ToString() == "4")
                //{
                //    arg_row--;
                //}

                //arg_grid.Row = arg_row;
                //arg_grid.Col = arg_col;

                //switch (_dt_layout_DMC.Rows[arg_idt]["STATION_CD"].ToString())
                //{
                //    case "05":
                //    case "09":
                //    case "13":
                //    case "16":
                //        arg_grid.Text += "/" + _dt_layout_DMC.Rows[arg_idt]["STATION_CD"].ToString();
                //        break;
                //    default:
                //        arg_grid.Text = _dt_layout_DMC.Rows[arg_idt]["STATION_CD"].ToString();
                //        break;
                //}
            }
            catch (Exception)
            {}
            
        }

        private void DisplayGridDMC(DataTable arg_dt, AxfpSpread arg_grid)
        {
           try
            {
                _countP = 0;
                _countN = 0;
                _countNU = 0;
                _countR = 0;

                if (arg_dt == null || arg_dt.Rows.Count == 0) return;
                axGrid.ClearRange(0, 0, 50, 50, true);
                create_default(arg_grid);
                _Loc_change_DMC.Clear();
                int row_s2 = 15;
                int row_s1 = 7;
                int row_s3 = 23;
                int col_s3 = 6;
                int irow = row_s2;
                int icol = 2;

                MachineBodyDMC(icol, irow, 0, arg_dt, arg_grid);
                MachineCenterText(icol, irow, 0, arg_dt, arg_grid);
                //MachineCenterBG(icol, irow, 0, arg_dt, arg_grid);
                lbl_plan.Text = arg_dt.Rows[0]["TOT_PLAN"].ToString();
                lbl_actual.Text = arg_dt.Rows[0]["TOT_ACT"].ToString();
                for (int i = 1; i < arg_dt.Rows.Count; i++)
                {

                    if (arg_dt.Rows[i]["machine_cd"].ToString() == arg_dt.Rows[i - 1]["machine_cd"].ToString())
                    {
                        if (arg_dt.Rows[i]["direction"].ToString() == arg_dt.Rows[i - 1]["direction"].ToString())
                        {
                            if (arg_dt.Rows[i]["direction"].ToString() == "1")
                            {
                                irow--;
                             //   MachineCenterBG(icol, irow, i, arg_dt, arg_grid); 
                            }
                            else if (arg_dt.Rows[i]["direction"].ToString() == "2") icol++;
                            else if (arg_dt.Rows[i]["direction"].ToString() == "3") irow++;
                            else icol--;
                            MachineBodyDMC(icol, irow, i, arg_dt, arg_grid);
                                                     
                        }
                        else
                        {
                            if (arg_dt.Rows[i]["direction"].ToString() == "2")
                            {
                                irow--;
                                icol++;
                                MachineHeadDMC(icol, irow - 1, i, arg_dt, arg_grid);
                            }
                            else if (arg_dt.Rows[i]["direction"].ToString() == "3")
                            {
                                icol++;
                                irow++;
                            }
                            else if (arg_dt.Rows[i]["direction"].ToString() == "4")
                            {
                                irow++;
                                icol--;
                            }
                            MachineBodyDMC(icol, irow, i, arg_dt, arg_grid);
                        }
                    }
                    else
                    {
                        if (arg_dt.Rows[i]["line_id"].ToString() == "2")
                        {
                            irow = row_s2;
                            icol = icol + 6;
                          //  axGrid.SetText(icol, irow, "2");
                        }
                        else if (arg_dt.Rows[i]["line_id"].ToString() == "1")
                        {
                            irow = row_s1;
                            icol--;
                            //   axGrid.SetText(icol, irow,"1");
                        }
                        else 
                        {
                            irow = row_s3;
                            col_s3 += 8;
                            icol= col_s3 ;
                        }
                        MachineBodyDMC(icol, irow, i, arg_dt, arg_grid);
                        MachineCenterText(icol, irow, i, arg_dt, arg_grid);
                      //  MachineCenterBG(icol, irow, i, arg_dt, arg_grid); 
                    }
                }
                set_qty();

               // if (_Loc_change.Count > 0) tmr_blind.Start();
               // else tmr_blind.Stop();
            }
           catch
           {}
        }


        #endregion DMC


        #region DMP
        private void DisplayGridDMP(DataTable arg_dt, AxfpSpread arg_grid)
        {
            try
            {

                _countN = 0;
                _countNU = 0;
                _countP = 0;
                _countR = 0;
                if (arg_dt == null || arg_dt.Rows.Count == 0) return;
                // axGrid.ClearRange(0, 0, 50, 50, true);
                create_default(arg_grid);
                _Loc_plan_DMP.Clear();
                //_row1 = Convert.ToInt32(arg_dt.Rows[0]["Row1"]);
                //_row2 = Convert.ToInt32(arg_dt.Rows[0]["Row2"]);
                //_row3 = Convert.ToInt32(arg_dt.Rows[0]["Row3"]);
                int row_s = 3;
                int irow = row_s;
                int icol = 2;
                lbl_plan.Text = arg_dt.Rows[0]["TOT_PLAN"].ToString();
                lbl_actual.Text = arg_dt.Rows[0]["TOT_ACT"].ToString();

                arg_grid.set_ColWidth(icol, 5);
                MachineHeadDMP(icol, irow, 0, arg_dt, arg_grid);
                irow += 2;               
                MachineBodyDMP(icol, irow, 0, arg_dt, arg_grid);
                irow++;

                for (int i = 1; i < arg_dt.Rows.Count; i++)
                {
                    if (arg_dt.Rows[i]["MACHINE_NAME"].ToString() == arg_dt.Rows[i - 1]["MACHINE_NAME"].ToString())
                    {
                        MachineBodyDMP(icol, irow, i, arg_dt, arg_grid);
                        irow++;
                    }
                    else
                    {

                        icol += 4;
                        arg_grid.set_ColWidth(icol, 5);
                        irow = row_s;
                        MachineHeadDMP(icol, irow, i, arg_dt, arg_grid);
                        irow += 2;
                        MachineBodyDMP(icol, irow, i, arg_dt, arg_grid);
                        irow++; 
                    }
                }
                set_qty();
               // if (_Loc_yellow.Count > 0) tmr_blind.Start();
               // else tmr_blind.Stop();
            }
            catch
            {
            }
        }

        private void MachineHeadDMP(int arg_icol, int arg_irow, int arg_idt, DataTable arg_dt, AxfpSpread arg_grid)
        {
            try
            {
                arg_grid.Col = arg_icol;
                arg_grid.Row = arg_irow;
                arg_grid.Text = arg_dt.Rows[arg_idt]["MACHINE_NAME"].ToString();
                arg_grid.Font = new System.Drawing.Font("Calibri", 20, FontStyle.Bold);
                arg_grid.BackColor = Color.DodgerBlue;
                arg_grid.ForeColor = Color.White;
                arg_grid.TypeVAlign = TypeVAlignConstants.TypeVAlignCenter;
                arg_grid.AddCellSpan(arg_icol, arg_irow, 3, 1);

                //arg_grid.SetCellBorder(icol, irow, icol + 2, irow + 1, CellBorderIndexConstants.CellBorderIndexOutline, 0, CellBorderStyleConstants.CellBorderStyleSolid);
                // arg_grid.SetCellBorder(icol, irow, icol + 3, irow + 1, CellBorderIndexConstants.CellBorderIndexLeft, 0, CellBorderStyleConstants.CellBorderStyleSolid);
                //arg_grid.SetCellBorder(icol, irow, icol + 2, irow +1, CellBorderIndexConstants.CellBorderIndexBottom, 0, CellBorderStyleConstants.CellBorderStyleSolid);
                //arg_grid.SetCellBorder(icol, irow, icol + 2, irow, CellBorderIndexConstants.CellBorderIndexTop, 0, CellBorderStyleConstants.CellBorderStyleSolid);


                arg_irow++;
                arg_grid.Row = arg_irow;
                arg_grid.Col = arg_icol;
                arg_grid.Text = "STA";
                arg_grid.BackColor = Color.LightSkyBlue;
                //  arg_grid.ForeColor = Color.White;
                arg_grid.Font = new System.Drawing.Font("Calibri", 15, FontStyle.Bold);

                arg_grid.Col = arg_icol + 1;
                arg_grid.Text = "L";
                arg_grid.BackColor = Color.LightSkyBlue;
                //  arg_grid.ForeColor = Color.White;
                arg_grid.Font = new System.Drawing.Font("Calibri", 15, FontStyle.Bold);

                arg_grid.Col = arg_icol + 2;
                arg_grid.Text = "R";
                arg_grid.BackColor = Color.LightSkyBlue;
                //  arg_grid.ForeColor = Color.White;
                arg_grid.Font = new System.Drawing.Font("Calibri", 15, FontStyle.Bold);


            }
            catch
            {}
        }

        public void MachineBodyDMP(int arg_icol, int arg_irow, int arg_idt, DataTable arg_dt, AxfpSpread arg_grid)
        {
            try
            {
                arg_grid.SetCellBorder(arg_icol, arg_irow, arg_icol + 2, arg_irow, CellBorderIndexConstants.CellBorderIndexLeft, 0, CellBorderStyleConstants.CellBorderStyleSolid);
                arg_grid.SetCellBorder(arg_icol, arg_irow, arg_icol + 3, arg_irow, CellBorderIndexConstants.CellBorderIndexLeft, 0, CellBorderStyleConstants.CellBorderStyleSolid);
                arg_grid.SetCellBorder(arg_icol, arg_irow, arg_icol + 2, arg_irow, CellBorderIndexConstants.CellBorderIndexBottom, 0, CellBorderStyleConstants.CellBorderStyleSolid);

                arg_grid.set_RowHeight(arg_irow, 30);


                arg_grid.Col = arg_icol;
                arg_grid.Row = arg_irow;
                arg_grid.Text = arg_dt.Rows[arg_idt]["STA"].ToString();

                arg_grid.Col = arg_icol + 1;
                arg_grid.Text =  arg_dt.Rows[arg_idt]["PLAN_L"].ToString();
                if (arg_dt.Rows[arg_idt]["USE_L"].ToString() == "Y")
                {
                    if (arg_dt.Rows[arg_idt]["L_color_B_value"].ToString() == "LIME")
                    {
                        arg_grid.BackColor = Color.Lime;
                        _countP++;
                    }
                    else if (arg_dt.Rows[arg_idt]["L_color_B_value"].ToString() == "RED")
                    {
                        arg_grid.BackColor = Color.Red;
                        _countN++;

                    }
                    else
                    {
                        arg_grid.BackColor = Color.Yellow;
                        _countR++;
                    }

                    // arg_grid.BackColor = Color.FromName(arg_dt.Rows[arg_idt]["L_color_B_value"].ToString());

                }
                else
                {
                    arg_grid.BackColor = Color.LightGray;
                    _countNU++;

                }
                arg_grid.ForeColor = Color.FromName(arg_dt.Rows[arg_idt]["L_color_F_value"].ToString());

                arg_grid.Col = arg_icol + 2;
                arg_grid.Text = arg_dt.Rows[arg_idt]["PLAN_R"].ToString();
                if (arg_dt.Rows[arg_idt]["USE_R"].ToString() == "Y")
                {
                    if (arg_dt.Rows[arg_idt]["R_color_B_value"].ToString() == "LIME")
                    {
                        arg_grid.BackColor = Color.Lime;
                        _countP++;
                    }
                    else if (arg_dt.Rows[arg_idt]["R_color_B_value"].ToString() == "RED")
                    {
                        arg_grid.BackColor = Color.Red;
                        _countN++;

                    }
                    else
                    {
                        arg_grid.BackColor = Color.Yellow;
                        _countR++;
                    }

                    // arg_grid.BackColor = Color.FromName(arg_dt.Rows[arg_idt]["L_color_B_value"].ToString());

                }
                else
                {
                    arg_grid.BackColor = Color.LightGray;
                    _countNU++;

                }
               // arg_grid.BackColor = Color.FromName(arg_dt.Rows[arg_idt]["R_color_B_value"].ToString());
                arg_grid.ForeColor = Color.FromName(arg_dt.Rows[arg_idt]["R_color_F_value"].ToString());

                              
                if (arg_dt.Rows[arg_idt]["L_Status"].ToString() == "1")
                    _Loc_plan_DMP.Add((arg_icol + 1) + " " + arg_irow + " " + arg_dt.Rows[arg_idt]["machine_cd"].ToString());
                if (arg_dt.Rows[arg_idt]["R_Status"].ToString() == "1")
                    _Loc_plan_DMP.Add((arg_icol + 2) + " " + arg_irow + " " + arg_dt.Rows[arg_idt]["machine_cd"].ToString());

                if (arg_dt.Rows[arg_idt]["L_Status"].ToString() == "2")
                    _Loc_change_DMP.Add((arg_icol + 1) + " " + arg_irow + " " + arg_dt.Rows[arg_idt]["machine_cd"].ToString());
                if (arg_dt.Rows[arg_idt]["R_Status"].ToString() == "2")
                    _Loc_change_DMP.Add((arg_icol + 2) + " " + arg_irow + " " + arg_dt.Rows[arg_idt]["machine_cd"].ToString());

            }
            catch (Exception)
            {}

        }

       


        #endregion DMP

        private void blind(List<string> arg_list, AxfpSpread arg_grid)
        {
            try
            {
                if (arg_list.Count <= 0) return;
                string[] str;

                for (int i = _iColor; i < arg_list.Count; i += 3)
                {
                    str = arg_list[i].Split(' ');
                    axGrid.Col = Convert.ToInt32(str[0].ToString());
                    axGrid.Row = Convert.ToInt32(str[1].ToString());
                    if (axGrid.BackColor == Color.Yellow)
                    {
                        if (axGrid.Text == "")
                        {
                            axGrid.BackColor = Color.Red;
                        }
                        else
                        {
                            axGrid.BackColor = Color.Green;
                        }

                        axGrid.ForeColor = Color.White;
                    }
                    else
                    {
                        axGrid.BackColor = Color.Yellow;
                        axGrid.ForeColor = Color.Black;
                    }
                }
                if (_iColor == 3) _iColor = 0;
                else _iColor++;
            }
            catch (Exception)
            {}          
        }


        public void loaddata( bool arg_status)
        {
            try
            {
                
               // if (arg_status)
                  //  this.axGrid.Hide();
                DataTable dt = null;
                if (_status == "DMC")
                {
                    dt = SEL_APS_PLAN_ACTUAL("90_1");
                    if (dt != null && dt.Rows.Count > 0)
                        _dt_layout_DMC = dt;

                    DataTable _dtMachine = SEL_APS_PLAN_ACTUAL("90_1", "Q", "A");
                    DataTable _dtModel = SEL_APS_PLAN_ACTUAL("90_1", "Q1", "A");
                    setGridData(_dtMachine, _dtModel);
                    //this.axGrid.Hide();
                    axGrid.Hide();                    
                    //axGridDMP.Hide();
                    //axGridDMP.SendToBack();
                    //axGrid.BringToFront();
                    DisplayGridDMC(_dt_layout_DMC, axGrid);
                    axGrid.Show();
                }
                else
                {
                    dt = SEL_APS_PLAN_ACTUAL("90");
                    if (dt != null && dt.Rows.Count > 0)
                        _dt_layout_DMP = dt;

                    DataTable _dtMachine = SEL_APS_PLAN_ACTUAL("90", "Q", "A");
                    DataTable _dtModel = SEL_APS_PLAN_ACTUAL("90", "Q1", "A");
                    setGridData(_dtMachine, _dtModel);
                    setGridData(_dtMachine, _dtModel);
                    //this.axGridDMP.Hide();
                    //axGridDMP.Hide();                    
                    axGrid.Hide();
                    //axGrid.SendToBack();
                    //axGridDMP.BringToFront();
                    DisplayGridDMP(_dt_layout_DMP, axGrid);
                    axGrid.Show();
                }
                

                //autoClick();
               // if (arg_status)
               // {
                   // WarehouseMaterialSystem.ClassLib.WinAPI.AnimateWindow(this.axGrid.Handle, 400, WarehouseMaterialSystem.ClassLib.WinAPI.getSlidType("2"));
                    //this.axGrid.Show();
                //}
            }
            catch (Exception)
            {}
        }

        private void setGridData(DataTable _dtMachine, DataTable _dtModel)
        {
            try
            {
                if (_dtMachine != null)
                {
                    grdviewMachine.DataSource = _dtMachine.Select("MACHINE_NAME <>'TOTAL'", "MACHINE_NAME").CopyToDataTable();
                    gvwviewMachine.Columns[2].OwnerBand.Caption = _dtMachine.Rows[0]["MOLD"].ToString();
                    gvwviewMachine.Columns[3].OwnerBand.Caption = _dtMachine.Rows[0]["INPUT"].ToString();
                    gvwviewMachine.Columns[4].OwnerBand.Caption = _dtMachine.Rows[0]["BALANCE"].ToString();
                    gvwviewMachine.Columns[5].OwnerBand.Caption = _dtMachine.Rows[0]["QTY"].ToString();
                }
                if (_dtModel != null)
                {
                    gridModel.DataSource = _dtModel.Select("SHORT_NAME <>'TOTAL'", "SHORT_NAME").CopyToDataTable();
                    bandedGridModel.Columns[5].OwnerBand.Caption = _dtModel.Rows[0]["QTY"].ToString();
                    bandedGridModel.Columns[6].OwnerBand.Caption = _dtModel.Rows[0]["MOLD_INPUT"].ToString();
                }

                for (int i = 0; i < gvwviewMachine.Columns.Count; i++)
                {

                    gvwviewMachine.Columns[i].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    gvwviewMachine.Columns[i].AppearanceCell.Options.UseTextOptions = true;
                    gvwviewMachine.Columns[i].OptionsColumn.ReadOnly = true;
                    gvwviewMachine.Columns[i].OptionsColumn.AllowEdit = false;
                    gvwviewMachine.Columns[i].OptionsFilter.AllowFilter = false;
                    gvwviewMachine.Columns[i].OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
                    gvwviewMachine.Columns[i].AppearanceCell.Font = new System.Drawing.Font("Calibri", 12, FontStyle.Bold);
                    
                    gvwviewMachine.Columns[i].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                }

                for (int i = 0; i < bandedGridModel.Columns.Count; i++)
                {
                    bandedGridModel.Columns[i].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    bandedGridModel.Columns[i].AppearanceCell.Options.UseTextOptions = true;
                    bandedGridModel.Columns[i].OptionsColumn.ReadOnly = true;
                    bandedGridModel.Columns[i].OptionsColumn.AllowEdit = false;
                    bandedGridModel.Columns[i].OptionsFilter.AllowFilter = false;
                    bandedGridModel.Columns[i].OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
                    bandedGridModel.Columns[i].AppearanceCell.Font = new System.Drawing.Font("Calibri", 12, FontStyle.Bold);
                    if (i == 0)
                    {
                        bandedGridModel.Columns[i].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
                    }
                    else
                    {
                        bandedGridModel.Columns[i].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    }
                        
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }

        private void autoClick(List<string> arg_list)
        {
            try
            {
                if (arg_list.Count > 0)
                {
                    string str = arg_list.ElementAt(_iCount);
                    string[] st = str.Split(' ');
                    //Ax_DSpreadEvents_ClickEvent ev = new Ax_DSpreadEvents_ClickEvent(Convert.ToInt32(st[0]), Convert.ToInt32(st[1]));
                    //axGrid_ClickEvent(axGrid, ev);
                    if (_iCount == arg_list.Count - 1) _iCount = 0;
                    else _iCount++;
                }
            }
            catch (Exception)
            {}
        }
                

        #endregion Fuction

        #region DB
        public DataTable SEL_APS_PLAN_ACTUAL(string arg_wh)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            System.Data.DataSet ds_ret;

            try
            {
                string process_name = "PKG_DMC.SEL_MOLD_PRODUCTION_LAYOUT";

                MyOraDB.ReDim_Parameter(2);
                MyOraDB.Process_Name = process_name;

 
                MyOraDB.Parameter_Name[0] = "ARG_WH_CD";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = arg_wh;
                MyOraDB.Parameter_Values[1] = "";

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

        public DataTable SEL_APS_PLAN_ACTUAL(string WH, string TYPE, string NO)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            System.Data.DataSet ds_ret;

            try
            {
                string process_name = "PKG_SPB_MOLD_WMS_V2.SEL_MOLD_PRODUCTION_LAYOUT_DMC";

                MyOraDB.ReDim_Parameter(4);
                MyOraDB.Process_Name = process_name;


                MyOraDB.Parameter_Name[0] = "ARG_WH";
                MyOraDB.Parameter_Name[1] = "ARG_TYPE";
                MyOraDB.Parameter_Name[2] = "ARG_NO";
                MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = WH;
                MyOraDB.Parameter_Values[1] = TYPE;
                MyOraDB.Parameter_Values[2] = NO;
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


        #endregion DB

        #region Event

        public void Frm_Mold_WS_Change_By_Shift_Load(object sender, EventArgs e)
        {
            //Smart_FTY.ComVar._frmPro_MoldLayout_dmc.Show();
            //Smart_FTY.ComVar._frmPro_MoldLayout_dmp.Show();
            lblDate.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd\nHH:mm:ss"));
            GoFullscreen();
            timer2.Start();
            //lblDmc_Click(lblDmc, null);
        }

        private void lblDate_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


       

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                //lblDate.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd")) + "\n\r" + string.Format(DateTime.Now.ToString("HH:mm:ss"));
                //blind();
                _time++;
                _time_auto++;             
                 


                if (_time >= _time_load)
                {
                    loaddata(true);
                    
                    _time = 0;
                }

                if (_bLoad && _time == 1)
                {
                    lblDmc_Click(lblDmc, null);
                    _load_form = false;
                }
               
            }
            catch
            {
            }
        }


        private void tmr_blind_Tick(object sender, EventArgs e)
        {
            if (_status=="DMC") blind(_Loc_change_DMC, axGrid);
            else blind(_Loc_change_DMP, axGrid);
        }



        private void Frm_Mold_WS_Change_By_Shift_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
            this.Dispose();
            base.Dispose(true);
        }


        private void Frm_Mold_WS_Change_By_Shift_VisibleChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.Visible)
                {
                    //_time_auto = 10;
                    //if (_load_form)
                    //{
                        timer1.Start();

                        
                        //lblDmp_Click(lblDmc, null);
                        _load_form = false;
                    //}                 
                }
                else
                {
                    _load_form = true;
                     timer1.Stop();
                }
                
            }
            catch (Exception)
            {}
        }


        //private void axGrid_BeforeEditMode(object sender, Ax_DSpreadEvents_BeforeEditModeEvent e)
        //{
        //    e.cancel = true;
        //}
        
        //private void axGrid_ClickEvent(object sender, Ax_DSpreadEvents_ClickEvent e)
        //{
        //    try
        //    {
        //        string str ;
        //        string str1 ;
        //        string[] st;
        //        string[] st1;

        //        //if (_status == "DMC")
        //        //{
        //        //    str = _Loc_change_DMC.Find(x => x.StartsWith(e.col + " " + e.row));
        //        //    str1 = _Loc_plan_DMC.Find(x => x.StartsWith(e.col + " " + e.row));
        //        //    _pop_change_pre._wh = "90_1";
        //        //}
        //        //else
        //        //{
        //        //    str = _Loc_change_DMP.Find(x => x.StartsWith(e.col + " " + e.row));
        //        //    str1 = _Loc_plan_DMP.Find(x => x.StartsWith(e.col + " " + e.row));
        //        //    _pop_change_pre._wh = "90";
        //        //}

        //        //if (str != null)
        //        //{
        //        //    st = str.Split(' ');
        //        //    _pop_change._machine = st[2];
        //        //    _pop_change.Hide();
        //        //    _pop_change.Show();

        //        //}
        //        //else if (str1 != null)
        //        //{
                   

        //        //}
        //        //else
        //        //{
        //        //    _pop_change.Hide();
        //        //    _pop_change_pre.Hide();
        //        //}
        //    }
        //    catch (Exception)
        //    {}          
        //}
        #endregion Event

        private void lblDmp_Click(object sender, EventArgs e)
        {
            try 
	        {
                _iCount = 0;
                //lblButton2.BackColor = Color.Gray;
                //lblButton2.ForeColor = Color.White;
                //lblButton1.BackColor = Color.White;
                //lblButton1.ForeColor = Color.Black;                
                loaddata(true);
                //lblButton2.Enabled = false;
                //lblButton1.Enabled = true;
                
	        }
	        catch (Exception)
	        {}
            
        }

        private void lblDmc_Click(object sender, EventArgs e)
        {
            try
            {
                _iCount = 0;
                //lblButton1.BackColor = Color.Gray;
                //lblButton1.ForeColor = Color.White;
                //lblButton2.BackColor = Color.White;
                //lblButton2.ForeColor = Color.Black;                
                loaddata(true);
                //lblButton1.Enabled = false;
                //lblButton2.Enabled = true;
                

            }
            catch (Exception)
            {}
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblDate.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd\nHH:mm:ss"));
            if (DateTime.Now.Hour >= 6 && DateTime.Now.Hour < 14) lbl_Shift.Text = "Shift 1";
            else if (DateTime.Now.Hour >= 14 && DateTime.Now.Hour < 22) lbl_Shift.Text = "Shift 2";
            else lbl_Shift.Text = "Shift 3";
        }

        private void lbl_plan_Click(object sender, EventArgs e)
        {
            lblDmc_Click(lblDmc, null);
        }

        private void lbl_actual_Click(object sender, EventArgs e)
        {
            lblDmp_Click(lblDmc, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Smart_FTY.ComVar._frm_home_dmp_dmc.Show();   
            this.Hide();
        }

        private void lblButton1_Click(object sender, EventArgs e)
        {
            //_status= "DMC";
            //lblTitle.Text = "DMC APS Planing && Actual Production";
            //lblDmc_Click(null, null);
            Smart_FTY.ComVar._frmPro_MoldLayout_dmc.Show();
            //FORM_MOLD_ACTUAL_PLAN frm = new FORM_MOLD_ACTUAL_PLAN("DMC");
            //frm.Show();
            this.Hide();
            

        }

        private void lblButton2_Click(object sender, EventArgs e)
        {
            //_status = "DMP";
            //lblTitle.Text = "DMP APS Planing && Actual Production";
            //lblDmp_Click(null, null);
            Smart_FTY.ComVar._frmPro_MoldLayout_dmp.Show();
            //FORM_MOLD_ACTUAL_PLAN frm = new FORM_MOLD_ACTUAL_PLAN("DMP");
            //frm.Show();
            this.Hide();
        }

        private void FORM_MOLD_ACTUAL_PLAN_Shown(object sender, EventArgs e)
        {
            //Smart_FTY.ComVar._frmPro_MoldLayout_dmc.Hide();
            //Smart_FTY.ComVar._frmPro_MoldLayout_dmp.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }




    }
}
