using System;
using System.Data;
using System.Drawing;
using System.Data.OracleClient;


namespace Smart_FTY
{
	/// <summary>
	/// ComVar에 대한 요약 설명입니다.
	/// </summary>
	public class ComVar 
	{
		public ComVar()
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
		}
        public static string Form_Type = "1";

        public static Form_Home_DMP_DMC _frm_home_dmp_dmc = new Form_Home_DMP_DMC();
        public static FORM_MOLD_ACTUAL_PLAN _frmPro_MoldLayout_dmp = new FORM_MOLD_ACTUAL_PLAN("DMP");
        public static FORM_MOLD_ACTUAL_PLAN _frmPro_MoldLayout_dmc = new FORM_MOLD_ACTUAL_PLAN("DMC");
        public static FORM_SMT_DMP_DMC_MOLD_ACTUAL_PLAN _frmPro_MoldActualPlanDMP = new FORM_SMT_DMP_DMC_MOLD_ACTUAL_PLAN("DMP");
        public static FORM_SMT_DMP_DMC_MOLD_ACTUAL_PLAN _frmPro_MoldActualPlanDMC = new FORM_SMT_DMP_DMC_MOLD_ACTUAL_PLAN("DMC");
        public static FORM_DMP_DEFFECTIVE_STATUS_YEAR _frmdefectiveyear = new FORM_DMP_DEFFECTIVE_STATUS_YEAR();
        public static FORM_DMP_DEFFECTIVE_STATUS _frmDefective = new FORM_DMP_DEFFECTIVE_STATUS();
        //public static string This_Action;
        //public static string This_Win_ID;
        //public static string This_PGM = "MOLD";
        //public static string This_Packages;
        //public static string This_REF1 = "";
        //public static string This_REF2 = "";
        //public static string This_REF3 = "";
        ////public static string This_User = "admin";
        //// 공통사용
        //public const string Insert = "I";
        //public const string Update = "U";
        //public const string Delete = "D";
	}
}
