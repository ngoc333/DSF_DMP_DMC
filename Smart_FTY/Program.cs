using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace Smart_FTY
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);     
            Start();
            
            
        }

        public static void Start()   // <-- must be marked public!
        {
           // MessageBox.Show("Start");
            Application.Run(Smart_FTY.ComVar._frm_home_dmp_dmc);

            //Application.Run(new FORM_DMP_DEFFECTIVE_STATUS_YEAR());
        }

    }
  
}
