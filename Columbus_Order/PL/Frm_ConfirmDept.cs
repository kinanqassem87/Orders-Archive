using Columbus_Order.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Columbus_Order.PL
{
    public partial class Frm_ConfirmDept : Form
    {
        int oID;
        string dept = "";
        public Frm_ConfirmDept(int orderId, string d)
        {
            try
            {
                InitializeComponent();
                oID = orderId;
                dept = d;
                
            }
            catch { }
        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            Frm_ImgOrder frm = new Frm_ImgOrder(oID, "Report", "Order");
            frm.ShowDialog();

            this.Close();
        }

        private void btnMoveOrder_Click(object sender, EventArgs e)
        {
            if (Frm_Main.UserName.Equals("maaz")|| Frm_Main.UserName.Equals("print")|| Frm_Main.UserName.Equals("emp") || Frm_Main.UserName.Equals("noor"))
            {
                if (MessageBox.Show("هل تريد بالتأكيد ترحيل هذه الطلبية؟", "ترحيل طلبية", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    try
                    {
                        if (dept == "c")
                        {
                            int i = Orders.updateDoneOrderC(oID);
                            MessageBox.Show("تمت عملية الترحيل بنجاح ");
                        }
                        else if (dept == "p")
                        {
                            int i = Orders.updateDoneOrderP(oID);
                            MessageBox.Show("تمت عملية الترحيل بنجاح ");
                        }
                       else  if (dept == "e")
                        {
                            int i = Orders.updateDoneOrderE(oID);
                            MessageBox.Show("تمت عملية الترحيل بنجاح ");
                        }
                       else if (dept == "row")
                        {
                            int i = Orders.UpdateRowMaterialState(oID, "done");
                            MessageBox.Show("تمت عملية الترحيل بنجاح ");
                        }

                        this.Close();
                    }
                    catch { }
                }
            }
            else { MessageBox.Show("ليس لديك سماحية لترحيل هذه الطلبية"); }
        }
    }
}
