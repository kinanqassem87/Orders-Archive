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
    public partial class Frm_MessageConfirm : Form
    {
        int oID;
        public Frm_MessageConfirm(int orderId)
        {
            try
            {
                InitializeComponent();
                oID = orderId;
            }
            catch { }
        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            
            if (Frm_Main.User_Type == "no") { MessageBox.Show("ليس لديك سماحية للقيام بهذا الاجراء"); }
            else
            {
                
                Frm_ImgOrder frm = new Frm_ImgOrder(oID, "Report", Frm_Main.User_Type);
                frm.ShowDialog();
            }
            this.Close();

        }

        private void btnMoveOrder_Click(object sender, EventArgs e)
        {
            if (Frm_Main.User_Type == "all" && Frm_Main.Per == "admin")
            {
                if (MessageBox.Show("هل تريد بالتأكيد ترحيل هذه الطلبية؟", "ترحيل طلبية", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    try
                    {
                        int i = Orders.updateDoneOrder(oID);
                        MessageBox.Show("تمت عملية الترحيل بنجاح ");
                        

                    }
                    catch { MessageBox.Show("لا يمكن الوصول الى قاعدة البيانات"); }
                }
            }
            else { MessageBox.Show("ليس لديك السماحية للقيام بهذا الاجراء"); }

            this.Close();
        }

        private void Frm_MessageConfirm_Load(object sender, EventArgs e)
        {

        }
    }
}
