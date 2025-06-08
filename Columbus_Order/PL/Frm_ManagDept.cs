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
    public partial class Frm_ManagDept : Form
    {
        int oID;
        string d;
        public Frm_ManagDept(int id,string dept)
        {
            InitializeComponent();
            oID = id;
            d = dept;
        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            Frm_ImgOrder frm = new Frm_ImgOrder(oID, "Report", "Order");
            frm.ShowDialog();

            this.Close();
        }

        private void btnMoveOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد بالتأكيد اعادة هذه الطلبية للتنفيذ؟", "اعادة الطلبية للتنفيذ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                try
                {
                    if (d == "c")
                    {
                        int i = Orders.updateToUnDoneC(oID);
                        MessageBox.Show("تمت عملية الترحيل بنجاح ");
                    }
                   else if (d == "p")
                    {
                        int i = Orders.updateToUnDoneP(oID);
                        MessageBox.Show("تمت عملية الترحيل بنجاح ");
                    }
                  else  if (d == "e")
                    {
                        int i = Orders.updateToUnDoneE(oID);
                        MessageBox.Show("تمت عملية الترحيل بنجاح ");
                    }
                  else if (d == "row")
                    {
                        int i = Orders.UpdateRowMaterialState(oID, "pending");
                        MessageBox.Show("تمت عملية الترحيل بنجاح ");
                    }

                    this.Close();
                }
                catch { }
            }
        }
    }
}
