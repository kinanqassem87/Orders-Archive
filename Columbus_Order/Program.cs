using Columbus_Order.BL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Columbus_Order
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                DataTable dt = Orders.SelectVersion();
                if (dt.Rows[0][0].ToString().Equals("V2-8"))
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Frm_Main());
                }
                else
                {
                    MessageBox.Show("هذه النسخة قديمة .. الرجاء تحديث النسخة ");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("لا يمكن الوصول الى قاعدة البيانات");
            }

            
        }
    }
}
