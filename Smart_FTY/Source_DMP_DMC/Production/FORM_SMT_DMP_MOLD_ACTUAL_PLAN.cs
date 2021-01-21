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
using System.Diagnostics;

namespace Smart_FTY
{

    

    public partial class FORM_SMT_DMP_MOLD_ACTUAL_PLAN : Form
    {
        public FORM_SMT_DMP_MOLD_ACTUAL_PLAN()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }


        #region Init

        string _status ;
        public int _Izone = 1;
       // string _lbl1, _lbl2, _lbl3;
        public int _time = 0;
        int _time_load = 20;
        int _time_auto = 0;
        DataTable _dt_layout_DMC = null;
        DataTable _dt_layout_DMP = null;
      //  string[] str_yellow;
        int _iColor = 0;
        bool _load_form = true;
        int _iCount = 0;
        int _count = 0;
        //int _bf_clickRow=0, _bf_clickCol=0;
        string _shift = "1";
        bool _isLoad = true;


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

        private void create_default()
        {
            try
            {
                int iRowHeight, iFontSize;
                double iColWidth;

                if (_status == "DMC")
                {
                    iRowHeight = 27;
                    iColWidth = 6.5;
                    iFontSize = 14; //11
                }
                else
                {
                    iRowHeight = 32;
                    iColWidth = 9.8;
                    iFontSize = 15;
                }

                axGrid.Reset();
                axGrid.DisplayColHeaders = false;
                axGrid.DisplayRowHeaders = false;
                axGrid.ActiveCellHighlightStyle = ActiveCellHighlightStyleConstants.ActiveCellHighlightStyleOff;
                axGrid.ColHeaderRows = 0;
           //     axGrid.ScrollBars = ScrollBarsConstants.ScrollBarsHorizontal;
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
            
            if (arg_dt.Rows[arg_idt]["text_cen"] != null && arg_dt.Rows[arg_idt]["text_cen"].ToString() != "")          
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
                arg_grid.set_RowHeight(arg_row, 30);
                arg_grid.Text = arg_dt.Rows[arg_idt]["MACHINE_NAME"].ToString();
                arg_grid.Font = new System.Drawing.Font("Calibri", 20, FontStyle.Bold);
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

        public void set_qty_actual(bool arg_status)
        {
            

            DataTable dtData;
            int iYellow = 0, iPlan=0, iActual=0;
            if (_status == "DMP")
            {
                int iPlanL = (int)_dt_layout_DMP.Compute("count(PLAN_L)", "");
                int iPlanR = (int)_dt_layout_DMP.Compute("count(PLAN_R)", "");
                int iActualL = (int)_dt_layout_DMP.Compute("count(ACTUAL_L)", "");
                int iActualR = (int)_dt_layout_DMP.Compute("count(ACTUAL_R)", "");
                int iYellowL = (int)_dt_layout_DMP.Compute("count(STATUS_L)", "STATUS_L = '1'");
                int iYellowR = (int)_dt_layout_DMP.Compute("count(STATUS_R)", "STATUS_R = '1'");
                iPlan = iPlanL + iPlanR;
                iYellow = iYellowL + iYellowR;
                iActual = iActualL + iActualR;
            }               
            else
            {
                iYellow = (int)_dt_layout_DMC.Compute("count(STATUS)", "STATUS = '1'");
                iPlan = (int)_dt_layout_DMC.Compute("count(SIZE_PLAN)", "");
                iActual = (int)_dt_layout_DMC.Compute("count(USE_SIZE)", "");
            }

            lbl_Plan.Text = "Total Plan: " + iPlan;
            lbl_Actual.Text = "Total Actual: " + iActual;
            
            if (_shift == "1")
            {
                lbl_dif1.Text = iPlan == 0 ? "" : ((float)iYellow / iPlan * 100.0).ToString("###,##0.#") + "%";
            }
            else if (_shift == "2")
            {
                lbl_dif2.Text = iPlan == 0 ? "" : ((float)iYellow / iPlan * 100.0).ToString("###,##0.#") + "%";
            }
            else
            {
                lbl_dif3.Text = iPlan == 0 ? "" : ((float)iYellow / iPlan * 100.0).ToString("###,##0.#") + "%";
            }


            if (!arg_status) return;

            if (_shift == "1")
            {
                DataTable dtShif2 = SEL_APS_PLAN_ACTUAL("2");
                SetTextDif(dtShif2, lbl_dif2);

                DataTable dtShif3 = SEL_APS_PLAN_ACTUAL("3");
                SetTextDif(dtShif3, lbl_dif3);

            }
            else if (_shift == "2")
            {
                DataTable dtShif1 = SEL_APS_PLAN_ACTUAL("1");
                SetTextDif(dtShif1, lbl_dif1);

                DataTable dtShif3 = SEL_APS_PLAN_ACTUAL("3");
                SetTextDif(dtShif3, lbl_dif3);
            }
            else
            {
                DataTable dtShif2 = SEL_APS_PLAN_ACTUAL("2");
                SetTextDif(dtShif2, lbl_dif2);

                DataTable dtShif1 = SEL_APS_PLAN_ACTUAL("3");
                SetTextDif(dtShif1, lbl_dif1);
            }
        }

        private void SetTextDif(DataTable dtShift, Label lbl_dif)
        {
            try
            {
                if (dtShift == null || dtShift.Rows.Count == 0)
                {
                    lbl_dif.Text = "";
                    return;
                }

                if (_status =="DMC")
                {
                    int iPlan = (int)dtShift.Compute("count(SIZE_PLAN)", "");
                    int iYellow = (int)dtShift.Compute("count(STATUS)", "STATUS = '1'");
                    if (iPlan == 0)
                    {
                        lbl_dif.Text = "";
                        return;
                    }
                    lbl_dif.Text = ((double)iYellow / iPlan * 100.0).ToString("###,##0.#") + "%";
                }
                else
                {
                    int iPlanL = (int)dtShift.Compute("count(PLAN_L)", "");
                    int iPlanR = (int)dtShift.Compute("count(PLAN_R)", "");
                    int iYellowL = (int)dtShift.Compute("count(STATUS_L)", "STATUS_L = '1'");
                    int iYellowR = (int)dtShift.Compute("count(STATUS_R)", "STATUS_R = '1'");
                    if (iPlanL + iPlanR == 0)
                    {
                        lbl_dif.Text = "";
                        return;
                    }
                    lbl_dif.Text = ((double)(iYellowL + iYellowR) / (iPlanL + iPlanR) * 100.0).ToString("###,##0.#") + "%";

                }
                
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
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
                arg_grid.BackColor = Color.FromName(arg_dt.Rows[arg_idt]["color_B_value"].ToString());
                arg_grid.ForeColor = Color.FromName(arg_dt.Rows[arg_idt]["color_F_value"].ToString());
            }
            catch (Exception)
            {}
            
        }



        private void DisplayGridDMC(DataTable arg_dt, AxfpSpread arg_grid)
        {
            _count = 0;
            create_default();
            _Loc_plan_DMP.Clear();
            axGrid.ScrollBars = ScrollBarsConstants.ScrollBarsNone;
           // lbl_Plan.Text = arg_dt.Rows[0]["TOT_PLAN"].ToString();
           // lbl_Actual.Text = arg_dt.Rows[0]["TOT_ACT"].ToString();



            try
            {
                if (arg_dt == null || arg_dt.Rows.Count == 0) return;
                int row_s = 3;
                int irow = row_s;
                int icol = 2;
                arg_grid.MaxRows = row_s + 25;
                MachineHeadDMCC(icol, irow, 0, arg_dt, arg_grid);
                irow = row_s + 2;
                MachineBodyDMCC(icol, irow, 0, arg_dt, arg_grid);
                for (int i = 1; i < arg_dt.Rows.Count; i++)
                {
                    if (arg_dt.Rows[i]["MACHINE_CD"].ToString() == arg_dt.Rows[i - 1]["MACHINE_CD"].ToString())
                    {
                       // if (arg_dt.Rows[i]["MINI_LINE_ID"].ToString() == arg_dt.Rows[i - 1]["MINI_LINE_ID"].ToString())
                       // {
                            irow++;
                       // }
                      //  else
                       // {
                       //     irow = row_s + 2;
                      //      icol += 3;
                      //  }
                        MachineBodyDMCC(icol, irow, i, arg_dt, arg_grid);
                    }
                    else
                    {
                        arg_grid.set_ColWidth(icol +3, 5);
                        icol +=4;
                        irow = row_s;
                        MachineHeadDMCC(icol, irow, i, arg_dt, arg_grid);
                        irow = row_s + 2;
                        MachineBodyDMCC(icol, irow, i, arg_dt, arg_grid);
                    }
                }
                //double d;
                //int x = _count;
                //int y = Convert.ToInt32(arg_dt.Rows[0]["TOT_PLAN"].ToString().Substring(12));
                //d = (float)x / y * 100.0;
                //lblMold_change.Text = "Difference Plan: " + d.ToString("###,###") + "%";
                
                arg_grid.MaxCols = icol + 3;
            }
            catch
            { }
            finally
            {
                // WarehouseMaterialSystem.ClassLib.WinAPI.AnimateWindow(arg_grid.Handle, 200, WarehouseMaterialSystem.ClassLib.WinAPI.getSlidType("2"));
                //   arg_grid.Visible = true;
            }
          //  set_qty_actual(arg_dt = SEL_TOTAL_PLAN_ACTUAL());
           //try
           // {
           //     if (arg_dt == null || arg_dt.Rows.Count == 0) return;
           //     axGrid.ClearRange(0, 0, 50, 50, true);
           //     create_default();
           //     _Loc_change_DMC.Clear();
           //     int row_s2 = 15;
           //     int row_s1 = 7;
           //     int row_s3 = 23;
           //     int col_s3 = 6;
           //     int irow = row_s2;
           //     int icol = 2;

           //   //  MachineBodyDMCC(icol, irow, 0, arg_dt, arg_grid);
           //   //  MachineCenterText(icol, irow, 0, arg_dt, arg_grid);
           //     //MachineCenterBG(icol, irow, 0, arg_dt, arg_grid);
           //     lbl_plan.Text = arg_dt.Rows[0]["TOT_PLAN"].ToString();
           //     lbl_actual.Text = arg_dt.Rows[0]["TOT_ACT"].ToString();
           //     for (int i = 1; i < arg_dt.Rows.Count; i++)
           //     {

           //         if (arg_dt.Rows[i]["machine_cd"].ToString() == arg_dt.Rows[i - 1]["machine_cd"].ToString())
           //         {
           //             if (arg_dt.Rows[i]["direction"].ToString() == arg_dt.Rows[i - 1]["direction"].ToString())
           //             {
           //                 if (arg_dt.Rows[i]["direction"].ToString() == "1")
           //                 {
           //                     irow--;
           //                  //   MachineCenterBG(icol, irow, i, arg_dt, arg_grid); 
           //                 }
           //                 else if (arg_dt.Rows[i]["direction"].ToString() == "2") icol++;
           //                 else if (arg_dt.Rows[i]["direction"].ToString() == "3") irow++;
           //                 else icol--;
           //                 MachineBodyDMCC(icol, irow, i, arg_dt, arg_grid);
                                                     
           //             }
           //             else
           //             {
           //                 if (arg_dt.Rows[i]["direction"].ToString() == "2")
           //                 {
           //                     irow--;
           //                     icol++;
           //                     MachineHeadDMCC(icol, irow - 1, i, arg_dt, arg_grid);
           //                 }
           //                 else if (arg_dt.Rows[i]["direction"].ToString() == "3")
           //                 {
           //                     icol++;
           //                     irow++;
           //                 }
           //                 else if (arg_dt.Rows[i]["direction"].ToString() == "4")
           //                 {
           //                     irow++;
           //                     icol--;
           //                 }
           //                 MachineBodyDMCC(icol, irow, i, arg_dt, arg_grid);
           //             }
           //         }
           //         else
           //         {
           //             if (arg_dt.Rows[i]["line_id"].ToString() == "2")
           //             {
           //                 irow = row_s2;
           //                 icol = icol + 6;
           //               //  axGrid.SetText(icol, irow, "2");
           //             }
           //             else if (arg_dt.Rows[i]["line_id"].ToString() == "1")
           //             {
           //                 irow = row_s1;
           //                 icol--;
           //                 //   axGrid.SetText(icol, irow,"1");
           //             }
           //             else 
           //             {
           //                 irow = row_s3;
           //                 col_s3 += 8;
           //                 icol= col_s3 ;
           //             }
           //             MachineBodyDMCC(icol, irow, i, arg_dt, arg_grid);
           //          //   MachineCenterText(icol, irow, i, arg_dt, arg_grid);
           //           //  MachineCenterBG(icol, irow, i, arg_dt, arg_grid); 
           //         }
           //     }

           //    // if (_Loc_change.Count > 0) tmr_blind.Start();
           //    // else tmr_blind.Stop();
           // }
           //catch
           //{}
        }
        private void MachineHeadDMCC(int arg_icol, int arg_irow, int arg_idt, DataTable arg_dt, AxfpSpread arg_grid)
        {
            try
            {
                int iRow = 1;
                arg_grid.Col = arg_icol;
                arg_grid.Row = arg_irow;
                arg_grid.Text =  arg_dt.Rows[arg_idt]["MACHINE_NAME"].ToString();
                arg_grid.FontSize = 15;
                arg_grid.FontBold = true;
                arg_grid.set_RowHeight(arg_irow, 20);


                arg_grid.BackColor = Color.DodgerBlue;
                arg_grid.ForeColor = Color.White;
                arg_grid.TypeVAlign = TypeVAlignConstants.TypeVAlignCenter;
                arg_grid.AddCellSpan(arg_icol, arg_irow, iRow * 3, 1);

                //arg_grid.SetCellBorder(arg_icol, arg_irow, arg_icol, arg_irow, CellBorderIndexConstants.CellBorderIndexOutline, 0, CellBorderStyleConstants.CellBorderStyleSolid);
                // arg_grid.SetCellBorder(icol, irow, icol + 3, irow + 1, CellBorderIndexConstants.CellBorderIndexLeft, 0, CellBorderStyleConstants.CellBorderStyleSolid);
                //arg_grid.SetCellBorder(icol, irow, icol + 2, irow +1, CellBorderIndexConstants.CellBorderIndexBottom, 0, CellBorderStyleConstants.CellBorderStyleSolid);
                //arg_grid.SetCellBorder(icol, irow, icol + 2, irow, CellBorderIndexConstants.CellBorderIndexTop, 0, CellBorderStyleConstants.CellBorderStyleSolid);


                arg_irow++;
                arg_grid.Row = arg_irow;
                for (int i = 0; i < iRow; i++)
                {
                    //if (arg_dt.Rows[arg_idt]["LINE_NAME"].ToString() == "E")
                    //    arg_grid.set_ColWidth(arg_icol + (i * 3), 6.0);

                    arg_grid.Col = arg_icol + (i * 3);
                    arg_grid.Text = "STA";
                    arg_grid.BackColor = Color.LightSkyBlue;
                      //arg_grid.ForeColor = Color.White;
                    arg_grid.FontSize = 13;
                    arg_grid.FontBold = true;

                    arg_grid.Col = arg_icol + (i * 3) + 1;
                    arg_grid.Text = "PLAN";
                    arg_grid.BackColor = Color.LightSkyBlue;
                   //   arg_grid.ForeColor = Color.White;
                    arg_grid.FontSize = 13;
                    arg_grid.FontBold = true;

                    arg_grid.Col = arg_icol + (i * 3) + 2;
                    arg_grid.Text = "ACT";
                    arg_grid.BackColor = Color.LightSkyBlue;
                   // arg_grid.ForeColor = Color.White;
                    arg_grid.FontSize = 13;
                    arg_grid.FontBold = true;

                    //arg_grid.Col = arg_icol + (i * 3) + 3;
                    //arg_grid.Text = "Act";
                    //arg_grid.BackColor = Color.Orange;
                    //arg_grid.ForeColor = Color.White;
                    //arg_grid.FontSize = 13;
                    //arg_grid.FontBold = true;
                }
                arg_grid.Col = -1;
                arg_grid.set_RowHeight(arg_irow, 20);

                //arg_grid.Col = arg_icol + 2;
                //arg_grid.Text = "R";
                //arg_grid.BackColor = Color.LightSkyBlue;
                ////  arg_grid.ForeColor = Color.White;
                //arg_grid.Font = new System.Drawing.Font("Calibri", 15, FontStyle.Bold);


            }
            catch
            { }

        }

        public void MachineBodyDMCC(int arg_icol, int arg_irow, int arg_idt, DataTable arg_dt, AxfpSpread arg_grid)
        {
            //  _count = 0;
            try
            {
                arg_grid.SetCellBorder(arg_icol + 1, arg_irow, arg_icol + 2, arg_irow, CellBorderIndexConstants.CellBorderIndexLeft, 0, CellBorderStyleConstants.CellBorderStyleSolid);
                arg_grid.SetCellBorder(arg_icol, arg_irow, arg_icol + 3, arg_irow, CellBorderIndexConstants.CellBorderIndexLeft, 0, CellBorderStyleConstants.CellBorderStyleSolid);
                arg_grid.SetCellBorder(arg_icol, arg_irow, arg_icol + 2, arg_irow, CellBorderIndexConstants.CellBorderIndexBottom, 0, CellBorderStyleConstants.CellBorderStyleSolid);

                arg_grid.set_RowHeight(arg_irow, 30);
                arg_grid.set_ColWidth(arg_icol, 4.5);
                arg_grid.set_ColWidth(arg_icol + 1, 5);
                arg_grid.set_ColWidth(arg_icol + 2, 5);
                arg_grid.set_ColWidth(arg_icol + 3, 4);

                arg_grid.Col = arg_icol;
                arg_grid.Row = arg_irow;
                arg_grid.Text = arg_dt.Rows[arg_idt]["STATION_CD"].ToString();
                arg_grid.FontSize = 11;
                arg_grid.FontBold = true;
                arg_grid.BackColor = Color.LightGreen;

                ///MOLD_CD
                arg_grid.Col = arg_icol + 1;
                arg_grid.Row = arg_irow;
                arg_grid.Text = arg_dt.Rows[arg_idt]["SIZE_PLAN"].ToString();
                arg_grid.FontSize = 11;
                //   arg_grid.FontBold = true;
                //  arg_grid.BackColor = Color.LightGreen;


                ///Plan
                arg_grid.Col = arg_icol + 2;
                arg_grid.Text = arg_dt.Rows[arg_idt]["USE_SIZE"].ToString();
                arg_grid.FontSize = 11;
                if (arg_dt.Rows[arg_idt]["STATUS"].ToString() == "1")
                {
                    arg_grid.BackColor = Color.Yellow;
                    _count++;
                }
                else
                {
                    arg_grid.BackColor = Color.White;
                }

                ///Act
                arg_grid.Col = arg_icol + 3;
                arg_grid.Text = arg_dt.Rows[arg_idt]["ACTUAL"].ToString();
                arg_grid.FontSize = 11;
                if (arg_dt.Rows[arg_idt]["STATUS"].ToString() == "1")
                {
                    arg_grid.BackColor = Color.Yellow;
                }
                else
                {
                    arg_grid.BackColor = Color.White;
                }


            }
            catch (Exception)
            { }
          //  axGrid.ScrollBars = ScrollBarsConstants.ScrollBarsHorizontal;

        }


        #endregion DMC


        #region DMP
        private void DisplayGridDMP(DataTable arg_dt, AxfpSpread arg_grid)
        {
            try
            {
                _count = 0;
                if (arg_dt == null || arg_dt.Rows.Count == 0) return;
                // axGrid.ClearRange(0, 0, 50, 50, true);
                create_default();
                _Loc_plan_DMP.Clear();
                //_row1 = Convert.ToInt32(arg_dt.Rows[0]["Row1"]);
                //_row2 = Convert.ToInt32(arg_dt.Rows[0]["Row2"]);
                //_row3 = Convert.ToInt32(arg_dt.Rows[0]["Row3"]);
                int row_s = 3;
                int irow = row_s;
                int icol = 2;
                lbl_Plan.Text = arg_dt.Rows[0]["TOT_PLAN"].ToString();
                lbl_Actual.Text = arg_dt.Rows[0]["TOT_ACT"].ToString();

                arg_grid.set_ColWidth(icol, 5);
                MachineHeadDMP(icol, irow, 0, arg_dt, arg_grid);
                irow += 3;               
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

                        icol += 6;
                        arg_grid.set_ColWidth(icol, 5);
                        irow = row_s;
                        MachineHeadDMP(icol, irow, i, arg_dt, arg_grid);
                        irow += 3;
                        MachineBodyDMP(icol, irow, i, arg_dt, arg_grid);
                        irow++; 
                    }
                }
                double d;
                int x = _count;
                int y = Convert.ToInt32(arg_dt.Rows[0]["TOT_PLAN"].ToString().Substring(12));
                d = (float)x / y * 100.0;
                lblMold_change.Text = "Difference Plan: " + d.ToString("###,###") + "%";
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
                arg_grid.AddCellSpan(arg_icol, arg_irow, 5, 1);

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
                arg_grid.AddCellSpan(arg_icol, arg_irow, 1, 2);

                arg_grid.set_RowHeight(arg_irow, 22);
                arg_grid.Col = arg_icol + 1;
                arg_grid.Text = "L";
                arg_grid.BackColor = Color.LightSkyBlue;
                //  arg_grid.ForeColor = Color.White;
                arg_grid.Font = new System.Drawing.Font("Calibri", 15, FontStyle.Bold);
                arg_grid.AddCellSpan(arg_icol+1, arg_irow, 2, 1);


      

                arg_grid.Col = arg_icol + 3;
                arg_grid.Text = "R";
                arg_grid.BackColor = Color.LightSkyBlue;
                //  arg_grid.ForeColor = Color.White;
                arg_grid.Font = new System.Drawing.Font("Calibri", 15, FontStyle.Bold);
                arg_grid.AddCellSpan(arg_icol+3, arg_irow, 2, 1);


                arg_irow++;
                arg_grid.Row = arg_irow;    
                arg_grid.Col = arg_icol + 1;
                arg_grid.Text = "PLAN";
                arg_grid.BackColor = Color.LightSkyBlue;
                //  arg_grid.ForeColor = Color.White;
                arg_grid.Font = new System.Drawing.Font("Calibri", 15, FontStyle.Bold);

                arg_grid.Col = arg_icol + 2;
                arg_grid.Text = "ACT";
                arg_grid.BackColor = Color.LightSkyBlue;
                //  arg_grid.ForeColor = Color.White;
                arg_grid.Font = new System.Drawing.Font("Calibri", 15, FontStyle.Bold);

                arg_grid.Col = arg_icol + 3;
                arg_grid.Text = "PLAN";
                arg_grid.BackColor = Color.LightSkyBlue;
                //  arg_grid.ForeColor = Color.White;
                arg_grid.Font = new System.Drawing.Font("Calibri", 15, FontStyle.Bold);

                arg_grid.Col = arg_icol + 4;
                arg_grid.Text = "ACT";
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
                arg_grid.SetCellBorder(arg_icol, arg_irow, arg_icol + 5, arg_irow, CellBorderIndexConstants.CellBorderIndexLeft, 0, CellBorderStyleConstants.CellBorderStyleSolid);
                arg_grid.SetCellBorder(arg_icol, arg_irow, arg_icol + 4, arg_irow, CellBorderIndexConstants.CellBorderIndexBottom, 0, CellBorderStyleConstants.CellBorderStyleSolid);

                arg_grid.set_RowHeight(arg_irow, 45);
             //   arg_grid.set_RowHeight(arg_irow, 30);
                arg_grid.set_ColWidth(arg_icol, 5);
                arg_grid.set_ColWidth(arg_icol + 1, 5.5);
                arg_grid.set_ColWidth(arg_icol + 2, 5.5);
                arg_grid.set_ColWidth(arg_icol + 3, 5.5);
                arg_grid.set_ColWidth(arg_icol + 4, 5.5);
                arg_grid.set_ColWidth(arg_icol + 5, 6.9);


                arg_grid.Col = arg_icol;
                arg_grid.Row = arg_irow;
                arg_grid.Text = arg_dt.Rows[arg_idt]["STA"].ToString();
                arg_grid.Font = new System.Drawing.Font("Calibri", 15, FontStyle.Bold);
                arg_grid.BackColor = Color.LightGreen;

                arg_grid.Col = arg_icol + 1;
                arg_grid.Text =  arg_dt.Rows[arg_idt]["PLAN_L"].ToString();
                //arg_grid.BackColor = Color.FromName(arg_dt.Rows[arg_idt]["L_color_B_value"].ToString());
                //arg_grid.ForeColor = Color.FromName(arg_dt.Rows[arg_idt]["L_color_F_value"].ToString());

                arg_grid.Col = arg_icol + 2;
                arg_grid.Text = arg_dt.Rows[arg_idt]["ACTUAL_L"].ToString();
                if (arg_dt.Rows[arg_idt]["STATUS_L"].ToString() == "1")
                {
                    arg_grid.BackColor = Color.Yellow;
                    _count++;
                }
                else
                {
                    arg_grid.BackColor = Color.White;
                }
                //arg_grid.BackColor = Color.FromName(arg_dt.Rows[arg_idt]["L_color_B_value"].ToString());
                //arg_grid.ForeColor = Color.FromName(arg_dt.Rows[arg_idt]["L_color_F_value"].ToString());


                arg_grid.Col = arg_icol + 3;
                arg_grid.Text = arg_dt.Rows[arg_idt]["PLAN_R"].ToString();
                //arg_grid.BackColor = Color.FromName(arg_dt.Rows[arg_idt]["R_color_B_value"].ToString());
                //arg_grid.ForeColor = Color.FromName(arg_dt.Rows[arg_idt]["R_color_F_value"].ToString());

                arg_grid.Col = arg_icol + 4;
                arg_grid.Text = arg_dt.Rows[arg_idt]["ACTUAL_R"].ToString();
                if (arg_dt.Rows[arg_idt]["STATUS_R"].ToString() == "1")
                {
                    arg_grid.BackColor = Color.Yellow;
                    _count++;
                }
                else
                {
                    arg_grid.BackColor = Color.White;
                }
                //arg_grid.BackColor = Color.FromName(arg_dt.Rows[arg_idt]["L_color_B_value"].ToString());
                //arg_grid.ForeColor = Color.FromName(arg_dt.Rows[arg_idt]["L_color_F_value"].ToString());


                
                //if (arg_dt.Rows[arg_idt]["L_Status"].ToString() == "1")
                //    _Loc_plan_DMP.Add((arg_icol + 1) + " " + arg_irow + " " + arg_dt.Rows[arg_idt]["machine_cd"].ToString());
                //if (arg_dt.Rows[arg_idt]["R_Status"].ToString() == "1")
                //    _Loc_plan_DMP.Add((arg_icol + 3) + " " + arg_irow + " " + arg_dt.Rows[arg_idt]["machine_cd"].ToString());

                //if (arg_dt.Rows[arg_idt]["L_Status"].ToString() == "2")
                //    _Loc_change_DMP.Add((arg_icol + 1) + " " + arg_irow + " " + arg_dt.Rows[arg_idt]["machine_cd"].ToString());
                //if (arg_dt.Rows[arg_idt]["R_Status"].ToString() == "2")
                //    _Loc_change_DMP.Add((arg_icol + 3) + " " + arg_irow + " " + arg_dt.Rows[arg_idt]["machine_cd"].ToString());

            }
            catch (Exception)
            {}
            axGrid.ScrollBars = ScrollBarsConstants.ScrollBarsNone;

        }

       


        #endregion DMP

        private void blind( List<string> arg_list)
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
                            axGrid.BackColor = Color.Gray;
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
            GoFullscreen();
            try
            {
                
               // if (arg_status)
                  //  this.axGrid.Hide();
                DataTable dt = null;
                if (_status == "DMC")
                {
                    dt = SEL_APS_PLAN_ACTUAL(_shift);
                    if (dt != null && dt.Rows.Count > 0)
                        _dt_layout_DMC = dt;

                    this.axGrid.Hide();
                    DisplayGridDMC(_dt_layout_DMC, axGrid);

                    set_qty_actual(arg_status);

                }
                else
                {
                    dt = SEL_APS_PLAN_ACTUAL(_shift);
                    if (dt != null && dt.Rows.Count > 0)
                        _dt_layout_DMP = dt;

                    this.axGrid.Hide();
                    DisplayGridDMP(_dt_layout_DMP, axGrid);

                    set_qty_actual(arg_status);
                }
                

                //autoClick();
               // if (arg_status)
               // {
                   // WarehouseMaterialSystem.ClassLib.WinAPI.AnimateWindow(this.axGrid.Handle, 400, WarehouseMaterialSystem.ClassLib.WinAPI.getSlidType("2"));
                    
                //}
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                this.axGrid.Show();
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
        public DataTable SEL_APS_PLAN_ACTUAL(string arg_shift)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            System.Data.DataSet ds_ret;

            try
            {
                string process_name = "PKG_SPB_MOLD_WMS_V2.SEL_MOLD_APS_ACTUAL_V2";

                MyOraDB.ReDim_Parameter(4);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "ARG_WH_CD";
                MyOraDB.Parameter_Name[1] = "ARG_DATE";
                MyOraDB.Parameter_Name[2] = "ARG_SHIFT";
                MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = _status == "DMC" ? "90_1":"90";
                MyOraDB.Parameter_Values[1] = dtpDate.DateTime.ToString("yyyyMMdd");
                MyOraDB.Parameter_Values[2] = arg_shift;
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
           // GoFullscreen();
            //timer2.Start();
            //lblDmc_Click(lblDmc, null);
            axGrid.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                
                lblDate.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd")) + "\n\r" + string.Format(DateTime.Now.ToString("HH:mm:ss"));
                //blind();
                _time++;
                _time_auto++;
               // if (_time_auto == 10) _pop_change.Hide();
                //if (_time_auto >= 40)
                //{
                //    if (_status == "DMC") autoClick(_Loc_change_DMC);
                //    else autoClick(_Loc_change_DMP);
                //    _time_auto = 0;
                //}

                //if (DateTime.Now.Hour >= 6 && DateTime.Now.Hour < 14) lbl_Shift1.Text = "Shift 1";
                //else if (DateTime.Now.Hour >= 14 && DateTime.Now.Hour < 22) lbl_Shift1.Text = "Shift 2";
                //else lbl_Shift1.Text = "Shift 3";
                

                if (_time >= _time_load)
                {
                    loaddata(false);
                    
                    _time = 0;
                }

                //if (Convert.ToInt16(DateTime.Now.ToString("HH")) >= 14 && Convert.ToInt16(DateTime.Now.ToString("HH")) < 22)
                //    lblShift.Text = "SHIFT 2";
                //else if (Convert.ToInt16(DateTime.Now.ToString("HH")) >= 6 && Convert.ToInt16(DateTime.Now.ToString("HH")) < 14)
                //    lblShift.Text = "SHIFT 1";
                //else
                //    lblShift.Text = "SHIFT 3";
            }
            catch
            {
            }
        }


        private void tmr_blind_Tick(object sender, EventArgs e)
        {
            if (_status=="DMC") blind(_Loc_change_DMC);
            else blind(_Loc_change_DMP);
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
                    lbl_dif1.Text = "";
                    lbl_dif2.Text = "";
                    lbl_dif3.Text = "";
                    _isLoad = true;
                    dtpDate.EditValue = DateTime.Now;
                    //_time_auto = 10;
                    //if (_load_form)
                    //{
                    if (Convert.ToInt16(DateTime.Now.ToString("HH")) >= 14 && Convert.ToInt16(DateTime.Now.ToString("HH")) < 22)
                    {
                        lbl_Shift_Click(lbl_Shift2, null);
                    }
                    else if (Convert.ToInt16(DateTime.Now.ToString("HH")) >= 6 && Convert.ToInt16(DateTime.Now.ToString("HH")) < 14)
                    {
                        lbl_Shift_Click(lbl_Shift1, null);
                    }
                    else
                    {
                        lbl_Shift_Click(lbl_Shift3, null);
                    }

                    lblDmc_Click(lblDmc, null);

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
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                _isLoad = false;
            }
        }

        //private void axGrid_BeforeEditMode(object sender, Ax_DSpreadEvents_BeforeEditModeEvent e)
        //{
        //    e.cancel = true;
        //}

        private void lblDmp_Click(object sender, EventArgs e)
        {
            try
            {
                _iCount = 0;
                lblDmp.BackColor = Color.Gray;
                lblDmp.ForeColor = Color.White;
                lblDmc.BackColor = Color.White;
                lblDmc.ForeColor = Color.Black;
                _status = "DMP";
                loaddata(true);

            }
            catch (Exception)
            { }

        }

        private void lblDmc_Click(object sender, EventArgs e)
        {
            try
            {
                _iCount = 0;
                lblDmc.BackColor = Color.Gray;
                lblDmc.ForeColor = Color.White;
                lblDmp.BackColor = Color.White;
                lblDmp.ForeColor = Color.Black;
                _status = "DMC";
                loaddata(true);


            }
            catch (Exception)
            { }

        }

        private void lbl_plan_Click(object sender, EventArgs e)
        {
            lblDmc_Click(lblDmc, null);
        }

        private void lbl_actual_Click(object sender, EventArgs e)
        {
            lblDmp_Click(lblDmc, null);
        }
        
        #endregion Event

        private void cmdBack_Click(object sender, EventArgs e)
        {
            Smart_FTY.ComVar._frm_home_dmp_dmc.Show();
            this.Hide();
        }

        private void lblCMP_Click(object sender, EventArgs e)
        {
            lblTitle2.Text = "DMC APS Plan && Actual";
            pn1.GradientEndColor = Color.White;
            pn2.GradientEndColor = Color.Gray;
            try
            {
                _time = 0;
                _iCount = 0;
                lblDmc.BackColor = Color.Gray;
                lblDmc.ForeColor = Color.White;
                lblDmp.BackColor = Color.White;
                lblDmp.ForeColor = Color.Black;
                _status = "DMC";
                loaddata(true);


            }
            catch (Exception)
            { }
            pn1.Enabled = false;
            pn2.Enabled = true;
        }

        private void lblPhylon_Click(object sender, EventArgs e)
        {
            lblTitle2.Text = "DMP APS Plan && Actual";
            pn1.GradientEndColor = Color.Gray;
            pn2.GradientEndColor = Color.White;
            try
            {
                _time = 0;
                _iCount = 0;
                lblDmp.BackColor = Color.Gray;
                lblDmp.ForeColor = Color.White;
                lblDmc.BackColor = Color.White;
                lblDmc.ForeColor = Color.Black;
                _status = "DMP";
                loaddata(true);

            }
            catch (Exception)
            { }
            pn1.Enabled = true;
            pn2.Enabled = false;
        }

        private void lbl_Shift_Click(object sender, EventArgs e)
        {
            Control cmd = (Control)sender;
            foreach (Control ctr in pnShift.Controls)
            {
                if (!ctr.Name.Contains("lbl_Shift")) continue;
                if (ctr.Name == cmd.Name)
                {
                    cmd.BackColor = Color.DodgerBlue;
                    cmd.ForeColor = Color.White;
                    _shift = cmd.Tag.ToString();
                    if (!_isLoad)
                    {
                        loaddata(false);
                    }
                    _time = 0;
                }
                else
                {
                    ctr.BackColor = Color.Gray;
                    ctr.ForeColor = Color.White;
                }
            }
        }

        private void dtpDate_EditValueChanged(object sender, EventArgs e)
        {
            if (_isLoad) return;

            loaddata(true);
            _time = 0;
        }


    }
}
