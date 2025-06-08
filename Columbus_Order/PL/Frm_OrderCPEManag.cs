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
    public partial class Frm_OrderCPEManag : Form
    {
        int oID;
        string d = "";
        public Frm_OrderCPEManag(string dept)
        {
            InitializeComponent();
            d = dept;
            display();
        }

        void display()
        {
            try
            {
                if (d == "c") { dgvCPEManag.DataSource = Orders.SelectOrderViewCManag();this.Text = " طلبيات القص و التفصيل المنفذة"; }
                if (d == "p") { dgvCPEManag.DataSource = Orders.SelectOrderViewPManag();this.Text = "طلبيات الطباعة المنفذة"; }
                if (d == "e") { dgvCPEManag.DataSource = Orders.SelectOrderViewEManag();this.Text = "طلبيات التطريز المنفذة"; }
                if (d == "row") { dgvCPEManag.DataSource = Orders.SelectRowDoneOrder(); this.Text = "طلبيات تم تحضير موادها الاولية"; }

                dgvCPEManag.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvCPEManag.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            catch { MessageBox.Show("لم يتم تحميل الداتا من السيرفر"); }
        }

        private void dgvCPEManag_Click(object sender, EventArgs e)
        {
            try
            {
                oID = int.Parse(dgvCPEManag.CurrentRow.Cells[0].Value.ToString());
            }
            catch { }
        }

        private void dgvCPEManag_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                oID = int.Parse(dgvCPEManag.CurrentRow.Cells[0].Value.ToString());
            }
            catch { }

            Frm_ManagDept frm = new Frm_ManagDept(oID, d);
            frm.ShowDialog();
        }

        private void Frm_OrderCPEManag_Activated(object sender, EventArgs e)
        {
           // display();
        }
    }
}
