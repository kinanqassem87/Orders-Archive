using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Columbus_Order.BL;

namespace Columbus_Order.PL
{
    public partial class Frm_CatManagement : Form
    {
        string name1 = "";
        public Frm_CatManagement(string name)
        {
            name1 = name;
            InitializeComponent();
            if (name1.Equals("cat"))
            {
                DisplayDataCat();
            }
            else
            {
                this.Text = "Collection Management";
                label1.Text = "ColID";
                label2.Text = "Col Name";
                DisplayDataCol();
            }
           
        }

        private void DisplayDataCat()
        {
            try
            {
                dgvCat.DataSource = Orders.SelectAllCat();
            }
            catch (Exception)
            {
                MessageBox.Show("There is an error");
            }
        }
        private void DisplayDataCol()
        {
            try
            {
                dgvCat.DataSource = Orders.SelectAllCol();
            }
            catch (Exception)
            {
                MessageBox.Show("There is an error");
            }
        }
        private void dgvCat_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtID.Text = dgvCat.CurrentRow.Cells[0].Value.ToString();
                txtName.Text = dgvCat.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception) { MessageBox.Show("There is un error!!!"); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Equals("") || txtName.Text.Equals(""))
            {
                MessageBox.Show("Please select one category!");
            }
            else
            {
                try
                {
                    if (name1.Equals("cat"))
                    {
                        int i = Orders.UpdateCat(int.Parse(txtID.Text), txtName.Text);
                        txtID.Text = txtName.Text = "";
                        MessageBox.Show("Update Done");
                        DisplayDataCat();
                    }
                    else
                    {
                        int i = Orders.UpdateCol(int.Parse(txtID.Text), txtName.Text);
                        txtID.Text = txtName.Text = "";
                        MessageBox.Show("Update Done");
                        DisplayDataCol();
                    }
                    
                }
                catch (Exception) { MessageBox.Show("There is an error"); }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Equals("") || txtName.Text.Equals(""))
            {
                MessageBox.Show("Please select one category!");
            }
            else
            {
                try
                {
                    if (name1.Equals("cat"))
                    {
                        DataTable dtCat = Orders.SelectOrdersByCat(int.Parse(txtID.Text));
                        if (dtCat.Rows.Count > 0)
                        {
                            MessageBox.Show("لا يمكن اتمام عملية الحذف لأن هناك طلبيات مرتبطة بها");
                        }
                        else
                        {
                            int i = Orders.DeleteCat(int.Parse(txtID.Text));
                            txtID.Text = txtName.Text = "";
                            MessageBox.Show("Delete Done");
                            DisplayDataCat();
                        }
                        
                    }
                    else
                    {
                        DataTable dtCol = Orders.SelectOrdersByCol(int.Parse(txtID.Text));
                        if (dtCol.Rows.Count > 0)
                        {
                            MessageBox.Show("لا يمكن اتمام عملية الحذف لأن هناك طلبيات مرتبطة بها");
                        }
                        else
                        {
                            int i = Orders.DeleteCol(int.Parse(txtID.Text));
                            txtID.Text = txtName.Text = "";
                            MessageBox.Show("Delete Done");
                            DisplayDataCol();
                        }
                        
                    }
                    
                }
                catch (Exception) { MessageBox.Show("There is an error"); }
            }
        }
    }
}
