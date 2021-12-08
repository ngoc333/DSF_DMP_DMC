using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Diagnostics;
using System.IO;
using DevExpress.Utils;
using System.Runtime.InteropServices;
using System.Threading;
using DevExpress.XtraGauges.Core.Model;
using Smart_FTY.Source_DMP_DMC;


namespace Smart_FTY
{
    public partial class Form_Home_DMP_DMC : SampleFrm1 
    {
        public Form_Home_DMP_DMC()
        {
            InitializeComponent();

        }       
        
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void SwitchToThisWindow(IntPtr hWnd, bool turnon);



        private int _timeLoad =0;

        #region Add Form
       

        public static Dictionary<string, string> Form_Group = new Dictionary<string, string>();
        public static Dictionary<string, string> Form_Type = new Dictionary<string, string>();
        public static string FrmEvaRub = "";

        //public static FORM_DMC_PROD_SET_STATUS _frmProd_DMC = new FORM_DMC_PROD_SET_STATUS();
        //public static FORM_DMP_PROD_SET_STATUS _frmProd_DMP = new FORM_DMP_PROD_SET_STATUS();

        public static FRM_SMT_DM_OSD_MONTH _frmQua_Ex_OSD_Month = new FRM_SMT_DM_OSD_MONTH();   

        public static FORM_DMP_MOLD_REPAIR_WEEKLY _frmQua_Mold = new FORM_DMP_MOLD_REPAIR_WEEKLY();

        public static FRM_SMT_B_DMP_HR_ABSENT _frmHr_Absent = new FRM_SMT_B_DMP_HR_ABSENT();

        public static FRM_SMT_DMP_TOPO_DAILY _frmHr_TOPO = new FRM_SMT_DMP_TOPO_DAILY();
        public static FRM_SMT_DMP_TOPO_WEEKLY _frmHr_TOPO_Week = new FRM_SMT_DMP_TOPO_WEEKLY();

        public static FRM_BOTTOM_INV_SET_ANALYSIS _frmInv = new FRM_BOTTOM_INV_SET_ANALYSIS();
        public static FORM_DMC_SET_BALANCE _frmInv_Tracking = new FORM_DMC_SET_BALANCE();
        public static FORM_LEADTIME_COMP_DMP _frmLeadTime = new FORM_LEADTIME_COMP_DMP();
        public static FORM_DMP_KPI_PERFOMANCE _frmKPI = new FORM_DMP_KPI_PERFOMANCE();

        public static FRM_DMC_AGING_LOCATION_NEW _frmAging_Loc = new FRM_DMC_AGING_LOCATION_NEW();

        // public static FRM_DMP_DMC_PROD_DAIYSHIFT _frmProd_Daily = new FRM_DMP_DMC_PROD_DAIYSHIFT();
        public static FRM_DMP_DMC_PROD_DAILY _frmProd_Daily = new FRM_DMP_DMC_PROD_DAILY();



        public static FORM_SMT_DMP_MOLD_ACTUAL_PLAN _frmPlanActual = new FORM_SMT_DMP_MOLD_ACTUAL_PLAN();
        public static FRM_SMT_BTS _frmBTS = new FRM_SMT_BTS();


        


        #endregion Add Form

        

        #region Proc
        private void loadData()
        {
            try
            {
                System.Data.DataSet ds = GET_DATA("B1");
                //OSD

                

                //if (ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
                //{
                //    DataTable dt = ds.Tables[0];
                //    lblOSDPlanDMC.Text = Convert.ToDouble(ds.Tables[0].Rows[1]["VALUE_DATA"].ToString()).ToString("###,###,###");
                //    lblOSDDMC.Text = Convert.ToDouble(ds.Tables[0].Rows[0]["VALUE_DATA"].ToString()).ToString("###,###,###");
                //    chartOSD2(ds.Tables[0], arcScale_ValDMC, lbl_ScaleDMC);
                //}
                if (ds.Tables[1] != null && ds.Tables[1].Rows.Count > 0)
                {
                    lblOSDPlanDMP.Text = Convert.ToDouble(ds.Tables[1].Rows[1]["VALUE_DATA"].ToString()).ToString("###,###,###")+" Prs" ;
                    lblOSDDMP.Text = Convert.ToDouble(ds.Tables[1].Rows[0]["VALUE_DATA"].ToString()).ToString("###,###,###") + " Prs";
                    chartOSD2(ds.Tables[1], arcScale_ValDMP, lbl_ScaleDMP);
                }
                //Produciton
                if (ds.Tables[2] != null && ds.Tables[2].Rows.Count > 0) 
                    chartGaugesProd(ds.Tables[2], false, arcProdRub, lblProdDMC, arcScaleRangeBarComponent2);
                if (ds.Tables[3] != null && ds.Tables[3].Rows.Count > 0) 
                    chartGaugesProd(ds.Tables[3], true, arcProdEva, lblProdDMP, arcScaleRangeBarComponent3);
                //POD
                //if (ds.Tables[4] != null && ds.Tables[4].Rows.Count > 0) 
                //    chartPOD(arcScaleCompDMC, lblPodDMC, ds.Tables[4].Rows[0]["qty"].ToString()
                //            , ds.Tables[4].Rows[0]["yellow_qty"].ToString(), ds.Tables[4].Rows[0]["Green_qty"].ToString(), ds.Tables[4].Rows[0]["max_qty"].ToString());
                if (ds.Tables[5] != null && ds.Tables[5].Rows.Count > 0) 
                    chartPOD(arcScaleCompDMP, lblPodDMP, ds.Tables[5].Rows[0]["qty"].ToString()
                           , ds.Tables[5].Rows[0]["yellow_qty"].ToString(), ds.Tables[5].Rows[0]["green_qty"].ToString(), ds.Tables[5].Rows[0]["max_qty"].ToString());

                //Inventory
                if (ds.Tables[6] != null && ds.Tables[6].Rows.Count > 0) 
                    chartGaugesInv(ds.Tables[6], false, arcInvDMC, arcScaleRangeBarComponent4, lblInvDMCDay, lblInvRubPlan, lblInvRubTon);
                if (ds.Tables[7] != null && ds.Tables[7].Rows.Count > 0) 
                    chartGaugesInv(ds.Tables[7], true, arcInvDMP, arcScaleRangeBarComponent6, lblInvdMPDay, lblInvEvaPlan, lblInvEvaTon);
                //Human Resource
                //if (ds.Tables[8] != null && ds.Tables[8].Rows.Count > 0) 
                //    chartHr(ds.Tables[8], chartHrDMC);
                if (ds.Tables[9] != null && ds.Tables[9].Rows.Count > 0) 
                chartHr(ds.Tables[9], chartHrDMP);
            }
            catch 
            {
               
            }
            

        }

        private void GoFullscreen()
        {
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;

        }

        #region Production
        private void chartGaugesProd(DataTable argDt, bool argEva, DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent argArcScale
                                 ,DevExpress.XtraGauges.Win.Base.LabelComponent argLabel
                                 ,DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent arcRangeBar)
        {
            
         
            argArcScale.EnableAnimation = false;
            argArcScale.EasingMode = DevExpress.XtraGauges.Core.Model.EasingMode.EaseIn;
            argArcScale.EasingFunction = new BackEase();
            argArcScale.MinValue = 0;
            
      
            argArcScale.Value = 0;
            argLabel.Text = "0";
            try
            {
            

                argArcScale.MinValue = 0;
                argArcScale.MaxValue = Convert.ToInt32(argDt.Rows[0]["VALUE_MAX"]);

                argArcScale.EnableAnimation = true;
                argArcScale.EasingMode = DevExpress.XtraGauges.Core.Model.EasingMode.EaseInOut;
                argArcScale.EasingFunction = new BackEase();
                double num;
                double.TryParse(argDt.Rows[0]["VALUE_DATA"].ToString(), out num);
                argArcScale.Value = (float)num;
                argLabel.Text = num.ToString() + "%";

                if (argEva)
                {
                    lblProDMPDPlan.Text = argDt.Rows[0]["D_PLAN"].ToString();
                    lblProDMPRPlan.Text = argDt.Rows[0]["R_PLAN"].ToString();
                    lblProDMPProd.Text = argDt.Rows[0]["PROD"].ToString();
                }
                else
                {
                    lblProDMCDPlan.Text = argDt.Rows[0]["D_PLAN"].ToString();
                    lblProDMCRPlan.Text = argDt.Rows[0]["R_PLAN"].ToString();
                    lblProDMCProd.Text = argDt.Rows[0]["PROD"].ToString();
                }

                if (num> 98)
                    arcRangeBar.Shader = new DevExpress.XtraGauges.Core.Drawing.StyleShader("Colors[Style1:Green;Style2:Green]");
                else if (num>= 95)
                    arcRangeBar.Shader = new DevExpress.XtraGauges.Core.Drawing.StyleShader("Colors[Style1:Yellow;Style2:Yellow]");
                else
                    arcRangeBar.Shader = new DevExpress.XtraGauges.Core.Drawing.StyleShader("Colors[Style1:Red;Style2:Red]");
         
            }
            catch 
            { }
            // }
        }



        #endregion Production

        #region Inventory
        private void chartGaugesInv(DataTable argDt, bool argEva
                                     , DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent argArcScale
                                     , DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent arcRangeBar
                                     , DevExpress.XtraGauges.Win.Base.LabelComponent argLabelDay
                                     , DevExpress.XtraGauges.Win.Base.LabelComponent argLabePlan
                                     , DevExpress.XtraGauges.Win.Base.LabelComponent argLabeTon)
        {
            try
            {
          
            argArcScale.EnableAnimation = false;
            argArcScale.EasingMode = DevExpress.XtraGauges.Core.Model.EasingMode.EaseIn;
            argArcScale.EasingFunction = new BackEase();
            argArcScale.MinValue = 0;

         
            argArcScale.Value = 0;
            argLabelDay.Text = "";
            argLabePlan.Text = "";
            argLabeTon.Text = "";
            


                argArcScale.MinValue = 0;
                argArcScale.MaxValue = Convert.ToSingle(argDt.Rows[0]["VALUE_MAX"]);

                argArcScale.EnableAnimation = true;
                argArcScale.EasingMode = DevExpress.XtraGauges.Core.Model.EasingMode.EaseInOut;
                argArcScale.EasingFunction = new BackEase();
                double num;
                double.TryParse(argDt.Rows[0]["VALUE_DATA"].ToString(), out num);
                argArcScale.Value = (float)num;
                argLabelDay.Text = num.ToString("0.00");
                argLabePlan.Text = argDt.Rows[0]["PLAN_DATA"].ToString();
                argLabeTon.Text = argDt.Rows[0]["INV"].ToString();
            
                
                if (argDt.Rows[0]["Factory"].ToString() =="DMC")
                    if (num > 1)
                        arcRangeBar.Shader = new DevExpress.XtraGauges.Core.Drawing.StyleShader("Colors[Style1:Red;Style2:Red]");
                  
                    else
                        arcRangeBar.Shader = new DevExpress.XtraGauges.Core.Drawing.StyleShader("Colors[Style1:Green;Style2:Green]");
                else if (argDt.Rows[0]["Factory"].ToString() =="DMP")
                    if (num > 2.5)
                        arcRangeBar.Shader = new DevExpress.XtraGauges.Core.Drawing.StyleShader("Colors[Style1:Red;Style2:Red]");
                  
                    else
                        arcRangeBar.Shader = new DevExpress.XtraGauges.Core.Drawing.StyleShader("Colors[Style1:Green;Style2:Green]");
                
            }
            catch
            { }
            // }
        }

        #endregion Inventory

        #region Human Resource

        private void chartHr(DataTable argDt, DevExpress.XtraCharts.ChartControl argChart)
        {
            try
            {

                DataTable dt = argDt.Clone();
                dt.Columns["VALUE_DATA"].DataType = typeof(double);
                foreach (DataRow row in argDt.Rows)
                    dt.ImportRow(row);

                argChart.DataSource = dt;
                argChart.Series[0].ArgumentDataMember = "CAPTION";
                argChart.Series[0].ValueDataMembers.AddRange(new string[] { "VALUE_DATA" });
                

                double iAbsent, iAttend, iAbsentUnplant;
                double.TryParse(dt.Rows[0][1].ToString(), out iAbsent);
                double.TryParse(dt.Rows[1][1].ToString(), out iAbsentUnplant);
                double.TryParse(dt.Rows[2][1].ToString(), out iAttend);

                double totalAbsent =0;
                double totalRate = 0;

                totalAbsent = iAbsent + iAbsentUnplant;

                if (totalAbsent + iAttend != 0)
                {
                    totalRate = Math.Round((totalAbsent / (totalAbsent + iAttend)) * 100, 1);
                }
                lblTotalAbsent.Text = "Total Absent\n" + totalAbsent.ToString() + " Person(s)\n" + totalRate.ToString() + "%";

                //if (iAbsent / (iAbsent + iAttend) * 100 >= 5)
                //    argChart.PaletteName = "Absent_Red";
                //else
                //    argChart.PaletteName = "Absent_Blue";
            }
            catch
            {
            }
            
            //argChart.Series[0].ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            //DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
           // chartTitle1.Font = new System.Drawing.Font("Tahoma", 20F);
            //this.argChart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] { chartTitle1 });
        }

        #endregion Human Resource

        #region OSD

        private void chartOSD(DataTable argDt, DevExpress.XtraCharts.ChartControl argChart)
        {
            try
            {
                DataTable dt = argDt.Clone();
                dt.Columns["VALUE_DATA"].DataType = typeof(double);
                foreach (DataRow row in argDt.Rows)
                    dt.ImportRow(row);

                argChart.DataSource = dt;
                argChart.Series[0].ArgumentDataMember = "CAPTION";
                argChart.Series[0].ValueDataMembers.AddRange(new string[] { "VALUE_DATA" });
            }
            catch 
            {
            }
        }

        private void chartOSD2(DataTable argDt, DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent
                                    
                                    , DevExpress.XtraGauges.Win.Base.LabelComponent arglbl                                   
                                    )
        {
            try
            {
                //Chart Per


                if (argDt.Rows.Count > 0)
                {
                    arcScaleComponent.Ranges.Clear();

                    DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRangeRed = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
                    DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRangeGreen = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
                    arcScaleComponent.EnableAnimation = false;
                    arcScaleComponent.EasingMode = DevExpress.XtraGauges.Core.Model.EasingMode.EaseInOut;
                    arcScaleComponent.EasingFunction = new BackEase();
                    arglbl.Text = "0";
                    arcScaleComponent.Value = 0;

                    double dProd, dOsd;
                    double.TryParse(argDt.Rows[0][1].ToString(), out dOsd);
                    double.TryParse(argDt.Rows[1][1].ToString(), out dProd);
                    float fValue = dOsd + dProd == 0 ? 0 : Convert.ToSingle(Math.Round(dOsd / (dOsd + dProd) * 100, 2));




                    arcScaleComponent.EnableAnimation = true;
                    arcScaleComponent.EasingMode = DevExpress.XtraGauges.Core.Model.EasingMode.EaseInOut;
                    arcScaleComponent.EasingFunction = new BackEase();
                    arcScaleComponent.Value = fValue;
                    arcScaleComponent.Ranges.Clear();

                    arglbl.Text = fValue + "%";
                    arcScaleRangeRed.StartThickness = 18;
                    arcScaleRangeRed.EndThickness = 18;
                    arcScaleRangeRed.StartValue = 0;
                    arcScaleRangeRed.Name = "Range0";
                    arcScaleRangeRed.ShapeOffset = 29F;

                    if (fValue > 10 )
                    {

                        arcScaleRangeRed.EndValue = 10;
                    }
                    else
                    {
                        arcScaleRangeRed.EndValue = fValue;
                    }
                    arcScaleRangeRed.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Red");


                    arcScaleRangeGreen.StartThickness = 18;
                    arcScaleRangeGreen.EndThickness = 18;
                    arcScaleRangeGreen.StartValue = 0;
                    arcScaleRangeGreen.Name = "Range1";
                    arcScaleRangeGreen.ShapeOffset = 29F;
                    arcScaleRangeGreen.StartValue = 0;
                    if (fValue > (float)Convert.ToDouble(argDt.Rows[0]["Target"].ToString()))
                    {

                        arcScaleRangeGreen.EndValue = 10 ;
                    }
                    else
                    {
                        arcScaleRangeGreen.EndValue = fValue;
                    }
                    arcScaleRangeGreen.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Green");

                    if (fValue < (float)Convert.ToDouble(argDt.Rows[0]["Target"].ToString()))
                    {
                        
                        arcScaleComponent.Ranges.AddRange(new DevExpress.XtraGauges.Core.Model.IRange[] { arcScaleRangeGreen });
                    }
                    else
                    {
                        arcScaleComponent.Ranges.AddRange(new DevExpress.XtraGauges.Core.Model.IRange[] { arcScaleRangeRed });
                    }

                    
                }
            }
            catch
            {
            }
        }
        

        #endregion OSD

        #region POD
        private void chartPOD(DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent
                                    , DevExpress.XtraGauges.Win.Base.LabelComponent arglbl
                                    , string argPer, string argYellow, string argGreen, string argMax)
        {
            try
            {

                //Chart Per
                float fValue = Convert.ToSingle(argPer);
                float fMaxValue = Convert.ToSingle(argMax);
                string strMaxValue = argMax;

                DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRangeRed = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
                DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRangeYellow = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
                DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRangeGreen = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();

                arcScaleComponent.EnableAnimation = false;
                arcScaleComponent.EasingMode = DevExpress.XtraGauges.Core.Model.EasingMode.EaseInOut;
                arcScaleComponent.EasingFunction = new BackEase();
                arglbl.Text = "0";
                arcScaleComponent.Value = 0;

                arcScaleComponent.EnableAnimation = true;
                arcScaleComponent.EasingMode = DevExpress.XtraGauges.Core.Model.EasingMode.EaseInOut;
                arcScaleComponent.EasingFunction = new BackEase();
                arglbl.Text = argPer;
                
                arcScaleComponent.Value = fValue;

                arcScaleComponent.Ranges.Clear();

                if (fValue >= Convert.ToDouble(argGreen))
                {                   
                    arglbl.AppearanceText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Green");
                    arcScaleRangeGreen.StartThickness = 18;
                    arcScaleRangeGreen.EndThickness = 18;
                    arcScaleRangeGreen.Name = "Range2";
                    arcScaleRangeGreen.ShapeOffset = -10F;
                    arcScaleRangeGreen.StartValue = 0;
                    arcScaleRangeGreen.EndValue = Convert.ToSingle(fValue);
                    arcScaleRangeGreen.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Green");

                    arcScaleComponent.Ranges.AddRange(new DevExpress.XtraGauges.Core.Model.IRange[] { arcScaleRangeGreen });
                }
                else if (fValue > Convert.ToDouble(argYellow))
                {
                   
                    arglbl.AppearanceText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Yellow");
                    arcScaleRangeYellow.StartThickness = 18;
                    arcScaleRangeYellow.EndThickness = 18;
                    arcScaleRangeYellow.Name = "Range1";
                    arcScaleRangeYellow.ShapeOffset = -10F;
                    arcScaleRangeYellow.StartValue = 0;
                    arcScaleRangeYellow.EndValue = Convert.ToSingle(fValue);
                    arcScaleRangeYellow.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Yellow");
                    arcScaleComponent.Ranges.AddRange(new DevExpress.XtraGauges.Core.Model.IRange[] {  arcScaleRangeYellow });
                }
                else
                {
                    arglbl.AppearanceText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Red");
                    arcScaleRangeRed.StartThickness = 18;
                    arcScaleRangeRed.EndThickness = 18;
                    arcScaleRangeRed.Name = "Range0";
                    arcScaleRangeRed.ShapeOffset = -10F;
                    arcScaleRangeRed.StartValue = 0;
                    arcScaleRangeRed.EndValue = Convert.ToSingle(fValue);
                    arcScaleRangeRed.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Red");

                    arcScaleComponent.Ranges.AddRange(new DevExpress.XtraGauges.Core.Model.IRange[] { arcScaleRangeRed});
                }

                if (fValue > fMaxValue)
                {
                    strMaxValue = (fValue + 1).ToString();
                    arcScaleComponent.MaxValue = Convert.ToSingle(strMaxValue);
                }
                else
                {
                    arcScaleComponent.MaxValue = fMaxValue +1;
                }



               // AddRange(arcScaleComponent, "0", argYellow, argGreen, strMaxValue);
                
               
            }
            catch 
            {
            }
        }

        private void AddRange(DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent, string startValue, string strRedValue, string strYellowValue, string strGreenValue)
        {
            
            
            DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRangeRed = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
            DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRangeYellow = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
            DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRangeGreen = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
            arcScaleComponent.Ranges.Clear();
            
            arcScaleRangeRed.StartThickness = 18;
            arcScaleRangeRed.EndThickness = 18;
            arcScaleRangeRed.Name = "Range0";
            arcScaleRangeRed.ShapeOffset = -10F;
            arcScaleRangeRed.EndValue = Convert.ToSingle(strRedValue);
            arcScaleRangeRed.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Red");

            arcScaleRangeYellow.StartThickness = 18;
            arcScaleRangeYellow.EndThickness = 18;
            arcScaleRangeYellow.Name = "Range1";
            arcScaleRangeYellow.ShapeOffset = -10F;
            arcScaleRangeYellow.StartValue = Convert.ToSingle(strRedValue);
            arcScaleRangeYellow.EndValue = Convert.ToSingle(strYellowValue);
            arcScaleRangeYellow.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Yellow");

            arcScaleRangeGreen.StartThickness = 18;
            arcScaleRangeGreen.EndThickness = 18;
            arcScaleRangeGreen.Name = "Range2";
            arcScaleRangeGreen.ShapeOffset = -10F;
            arcScaleRangeGreen.StartValue = Convert.ToSingle(strYellowValue);
            arcScaleRangeGreen.EndValue = Convert.ToSingle(strGreenValue);
            arcScaleRangeGreen.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Green");

            arcScaleComponent.Ranges.AddRange(new DevExpress.XtraGauges.Core.Model.IRange[] { arcScaleRangeRed, arcScaleRangeYellow, arcScaleRangeGreen });
           
        }
        #endregion POD


        
       
        #endregion Proc

        #region DB
        private System.Data.DataSet GET_DATA(string argWH)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;
            try
            {
                string process_name = "MES.PKG_SMT_DMP_DMC.SEL_DATA_MAIN_DMP_DMC";

                MyOraDB.ReDim_Parameter(11);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "ARG_WH_CD";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR1";
                MyOraDB.Parameter_Name[3] = "OUT_CURSOR2";
                MyOraDB.Parameter_Name[4] = "OUT_CURSOR3";
                MyOraDB.Parameter_Name[5] = "OUT_CURSOR4";
                MyOraDB.Parameter_Name[6] = "OUT_CURSOR5";
                MyOraDB.Parameter_Name[7] = "OUT_CURSOR6";
                MyOraDB.Parameter_Name[8] = "OUT_CURSOR7";
                MyOraDB.Parameter_Name[9] = "OUT_CURSOR8";
                MyOraDB.Parameter_Name[10] = "OUT_CURSOR9";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
                MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
                MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;
                MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;
                MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor;
                MyOraDB.Parameter_Type[7] = (int)OracleType.Cursor;
                MyOraDB.Parameter_Type[8] = (int)OracleType.Cursor;
                MyOraDB.Parameter_Type[9] = (int)OracleType.Cursor;
                MyOraDB.Parameter_Type[10] = (int)OracleType.Cursor;


                MyOraDB.Parameter_Values[0] = argWH;
                MyOraDB.Parameter_Values[1] = "";
                MyOraDB.Parameter_Values[2] = "";
                MyOraDB.Parameter_Values[3] = "";
                MyOraDB.Parameter_Values[4] = "";
                MyOraDB.Parameter_Values[5] = "";
                MyOraDB.Parameter_Values[6] = "";
                MyOraDB.Parameter_Values[7] = "";
                MyOraDB.Parameter_Values[8] = "";
                MyOraDB.Parameter_Values[9] = "";
                MyOraDB.Parameter_Values[10] = "";

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

        #region Event Form

        private void Form_Home_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dtXML = ReadXML(Application.StartupPath + "\\Config.XML");

                if (dtXML == null)
                {
                    cmdBack.Visible = true;
                }
                else
                {
                    if (dtXML.Rows[0]["DMP_BACK_YN"].ToString() == "N")
                    {
                        cmdBack.Visible = false;

                    }
                    else
                    {
                        cmdBack.Visible = true;
                    }
                }
                //DataTable dt = LOAD_DATA();
              // cmdBack.Visible = false;
                Form_Group.Add("200", "FRM_SMT_DMP_TOPO_WEEKLY");
                Form_Group.Add("201", "FRM_SMT_DMP_TOPO_DAILY");
                pnButton.Visible = false;
                // lblShift.Visible = true;
                GoFullscreen();
            //    Smart_FTY.ComVar._frmPro_MoldLayout_dmc.Show();
            //    Smart_FTY.ComVar._frmPro_MoldLayout_dmp.Show();
            //    Smart_FTY.ComVar._frmPro_MoldLayout_dmc.Hide();
            //    Smart_FTY.ComVar._frmPro_MoldLayout_dmp.Hide();
            }
            catch 
            {}
           
            
            
        }

        #region Read File XML
        public static Dictionary<string, string>[] Init_File_XML(string str_FileName, string arg_TagName)
        {
            try
            {
                using (FileStream fs = new FileStream(str_FileName, FileMode.Open, FileAccess.Read))
                {
                    System.Xml.XmlDocument xmldoc = new System.Xml.XmlDocument();
                    xmldoc.Load(fs);

                    //Get Configuration OF Production Form
                    Dictionary<string, string>[] rtn_VarName = new Dictionary<string, string>[xmldoc.GetElementsByTagName(arg_TagName).Count];
                    int i = 0;
                    foreach (System.Xml.XmlNode xmlnode in xmldoc.GetElementsByTagName(arg_TagName))
                    {
                        rtn_VarName[i] = new Dictionary<string, string>();
                        foreach (System.Xml.XmlElement xmllist in xmlnode.ChildNodes)
                        {
                            rtn_VarName[i].Add(xmllist.Name, xmllist.InnerText);
                        }
                        i++;
                    }
                    return rtn_VarName;
                }
            }
            catch
            {

                return null;
            }

        }
        private DataTable ReadXML(string file)
        {
            DataTable table = new DataTable("Base");
            try
            {
                DataSet lstNode = new DataSet();
                lstNode.ReadXml(file);
                table = lstNode.Tables["Base"];
                return table;
            }
            catch (Exception ex)
            {
                return table;
            }
        }
        #endregion Read File XML

        private void Form_Home_VisibleChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.Visible)
                {
                    // addUcMachinery();
                    lblTitle.Text = "Digital Shop Floor For DMC && DMP";
                    _timeLoad = 27;
                    tmrLoad.Start();
                    tmrTime.Start();
                }
                else
                {
                    tmrLoad.Stop();
                    tmrTime.Start();
                }
            }
            catch 
            {}
            
        }



        private void tmrLoad_Tick(object sender, EventArgs e)
        {
            _timeLoad++;
            if (_timeLoad == 30)
            {
               
                loadData();
                _timeLoad = 0;
            }
                        
        }
        

        #region Click Event

        private void cmdQuality1_Click(object sender, EventArgs e)
        {
         
            Smart_FTY.ComVar._frmDefective.Show();
            this.Hide();
        }

        private void cmdQuality2_Click(object sender, EventArgs e)
        {
            
            _frmQua_Ex_OSD_Month.Show();
            this.Hide();
        }

        private void cmdQuality3_Click(object sender, EventArgs e)
        {
           
            _frmQua_Mold.Show();
            this.Hide();
        }

        private void cmdProduction1_Click(object sender, EventArgs e)
        {

            Smart_FTY.ComVar._frmPro_MoldLayout_dmc.Show();  
            this.Hide();
         
        }

        private void cmdProduction2_Click(object sender, EventArgs e)
        {

            Smart_FTY.ComVar._frmPro_MoldActualPlanDMP.Show();
            this.Hide();
        }

          

        private void simpleButton13_Click(object sender, EventArgs e)
        {
         
            _frmInv.Show();       
            //this.Hide();
        }

        private void simpleButton31_Click(object sender, EventArgs e)
        {
         
            _frmHr_Absent.Show();
            this.Hide();
        }

      

        #endregion Click Event

        private void groupBoxEx1_Enter(object sender, EventArgs e)
        {

        }

        



        #endregion Event Form

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            _frmInv_Tracking.Show();
            this.Hide();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            _frmLeadTime.Show();
            this.Hide();
        }

        private void groupBoxEx4_Enter(object sender, EventArgs e)
        {

        }

        private void cmdWH_Click(object sender, EventArgs e)
        {
            try
            {

                string patch = Application.StartupPath + "\\Mold\\MoldDMP.exe";

                if (!ProgramIsRunning(patch))
                {
                    Process.Start(patch);
                }
                else
                {
                    System.Diagnostics.Process result = System.Diagnostics.Process.GetProcessesByName("MoldDMP").FirstOrDefault();
                    //SetWindowPos(result.MainWindowHandle, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE | SWP_SHOWWINDOW);
                    SwitchToThisWindow(result.MainWindowHandle, false);
                }                
 
            }
            catch
            { }
        }


        //Kiem tra Program co dang chay hay chua?
        private bool ProgramIsRunning(string FullPath)
        {
            try
            {
                string FilePath = Path.GetDirectoryName(FullPath);
                string FileName = Path.GetFileNameWithoutExtension(FullPath).ToLower();
                bool isRunning = false;

                Process[] pList = Process.GetProcessesByName(FileName);
                foreach (Process p in pList)
                    if (p.MainModule.FileName.StartsWith(FilePath, StringComparison.InvariantCultureIgnoreCase))
                    {
                        isRunning = true;
                        break;
                    }

                return isRunning;
            }
            catch
            {

                return false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            _frmKPI.Show();
            this.Hide();
        }

    

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            //_type = "CMP";
            Smart_FTY.ComVar._frmPro_MoldLayout_dmp.Show();
            this.Hide();
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {

        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            try
            {

                System.Diagnostics.Process result = System.Diagnostics.Process.GetProcessesByName("B1_DASHBOARD").FirstOrDefault();
                SwitchToThisWindow(result.MainWindowHandle, true);
            }
            catch
            { }

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            _frmProd_Daily.Show();
            this.Hide();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
           // Smart_FTY.ComVar._frmPro_MoldActualPlanDMP.Show();
            _frmPlanActual.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string patch = Application.StartupPath + "\\DMC_WS\\DMC_WS.exe";

                if (!ProgramIsRunning(patch))
                {
                    Process.Start(patch);
                }
                else
                {
                    System.Diagnostics.Process result = System.Diagnostics.Process.GetProcessesByName("DMC_WS").FirstOrDefault();
                    //SetWindowPos(result.MainWindowHandle, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE | SWP_SHOWWINDOW);
                    SwitchToThisWindow(result.MainWindowHandle, false);
                }

            }
            catch
            { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                string patch = Application.StartupPath + "\\DMP_WS\\DMP_WS.exe";

                if (!ProgramIsRunning(patch))
                {
                    Process.Start(patch);
                }
                else
                {
                    System.Diagnostics.Process result = System.Diagnostics.Process.GetProcessesByName("DMP_WS").FirstOrDefault();
                    //SetWindowPos(result.MainWindowHandle, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE | SWP_SHOWWINDOW);
                    SwitchToThisWindow(result.MainWindowHandle, false);
                }

            }
            catch
            { }
        }

        private void simpleButton5_Click_1(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            _frmBTS.Show();
            Cursor.Current = Cursors.Default; 
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            _frmHr_TOPO.Show();
            this.Hide();
        }

        private void cmdAging_Loc_Click(object sender, EventArgs e)
        {
            _frmAging_Loc.Show();
            this.Hide();
        }
    }
}
