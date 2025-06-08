using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Columbus_Order.BL;

namespace Columbus_Order.PL
{
    public partial class Frm_Update_Col_Cat : Form
    {
        public Frm_Update_Col_Cat()
        {
            InitializeComponent();
            try
            {
                FillAllCat();
                FillAllCol();
            }
            catch (Exception) { MessageBox.Show("There is an error!!!"); }
        }
        private void FillAllCol()
        {
            cmbCat.DataSource = Orders.SelectAllCat();
            cmbCat.DisplayMember = "CatName";
            cmbCat.ValueMember = "CatID";
        }

        private void FillAllCat()
        {
            cmbCol.DataSource = Orders.SelectAllCol();
            cmbCol.DisplayMember = "ColName";
            cmbCol.ValueMember = "ColID";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtOrderID.Text.Equals(""))
            {
                MessageBox.Show("Please insert number");
            }
            else
            {
                try
                {
                    DataTable getOrder = Orders.selectOneOrder(int.Parse(txtOrderID.Text));
                    if (getOrder.Rows.Count > 0)
                    {
                        int i = Orders.Update_Col_Cat(int.Parse(txtOrderID.Text), Convert.ToInt32(cmbCol.SelectedValue), Convert.ToInt32(cmbCat.SelectedValue));
                        txtOrderID.Text = "";
                        MessageBox.Show("Updated");
                    }
                    else
                    {
                        MessageBox.Show("Wrong order number !!!");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("There is an error");
                }
            }
        }
    }
}
