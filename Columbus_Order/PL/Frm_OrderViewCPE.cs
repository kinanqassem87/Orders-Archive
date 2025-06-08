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
    public partial class Frm_OrderViewCPE : Form
    {
        string d = "";
        int orderId;
        public Frm_OrderViewCPE(string dept)
        {
            InitializeComponent();
            d = dept;
            display();
        }

        void display()
        {
            try
            {
                if (d == "c") { dgvOrderView.DataSource = Orders.SelectOrderViewC(); this.Text = "طلبيات القص و التفصيل"; }
                if (d == "p") { dgvOrderView.DataSource = Orders.SelectOrderViewP(); this.Text = "طلبيات الطباعة"; }
                if (d == "e") { dgvOrderView.DataSource = Orders.SelectOrderViewE(); this.Text = "طلبيات التطريز"; }

                if (d == "row") { dgvOrderView.DataSource = Orders.SelectRowPendingOrder(); this.Text = "تحضير المواد الاولية"; }

                dgvOrderView.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvOrderView.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            catch { MessageBox.Show("لم يتم تحميل الداتا من السيرفر"); }
        }

        private void dgvOrderView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           /* try
            {
                foreach (DataGridViewRow Myrow in dgvOrderView.Rows)
                {

                    if (DateTime.Parse(Myrow.Cells[6].Value.ToString()) < DateTime.Now.AddDays(7) || Myrow.Cells[5].Value.ToString().Equals("مستعجلة"))
                    {
                        Myrow.DefaultCellStyle.BackColor = Color.Red;
                    }
                    else if (DateTime.Parse(Myrow.Cells[6].Value.ToString()) >= DateTime.Now.AddDays(7) && DateTime.Parse(Myrow.Cells[6].Value.ToString()) < DateTime.Now.AddDays(30))
                    {
                        Myrow.DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    else if (DateTime.Parse(Myrow.Cells[6].Value.ToString()) >= DateTime.Now.AddDays(30))
                    {
                        Myrow.DefaultCellStyle.BackColor = Color.YellowGreen;
                    }
                }
            }
            catch { MessageBox.Show("حدث خطأ عند الاتصال بقاعدة البيانات"); }*/
        }

        private void dgvOrderView_Click(object sender, EventArgs e)
        {
            try
            {
                orderId = int.Parse(dgvOrderView.CurrentRow.Cells[0].Value.ToString());
            }
            catch { }
        }

        private void dgvOrderView_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                orderId = int.Parse(dgvOrderView.CurrentRow.Cells[0].Value.ToString());
            }
            catch { }
            Frm_ConfirmDept frm = new Frm_ConfirmDept(orderId,d);
            frm.ShowDialog();
        }

        private void Frm_OrderViewCPE_Activated(object sender, EventArgs e)
        {
           // display();
        }
    }
}
