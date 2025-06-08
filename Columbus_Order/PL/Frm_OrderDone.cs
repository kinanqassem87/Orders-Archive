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
    public partial class Frm_OrderDone : Form
    {
        string dept = "";
        public Frm_OrderDone(string dept1)
        {
            InitializeComponent();
            dept = dept1;
        }

        private void txtOrderNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                try
                {
                    DataTable dt = Orders.selectOneOrder(int.Parse(txtOrderNum.Text));
                    txtName.Text = dt.Rows[0][3].ToString();
                }
                catch (Exception) { }
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (txtOrderNum.Text.Equals("") || txtName.Text.Equals(""))
            {
                MessageBox.Show("Please insert Order number and press ENTER");
            }
            else
            {
                try
                {
                    if (dept.Equals("tafseel"))
                    {
                        int i = Orders.updateTafseel(int.Parse(txtOrderNum.Text), "Done");
                    }
                    else if (dept.Equals("printOne"))
                    {
                        int i = Orders.updatePrint_One(int.Parse(txtOrderNum.Text), "Done");
                    }
                    else if (dept.Equals("printTwo"))
                    {
                        int i = Orders.updatePrint_Two(int.Parse(txtOrderNum.Text), "Done");
                    }
                    else if (dept.Equals("tatreez"))
                    {
                        int i = Orders.updateTatreez(int.Parse(txtOrderNum.Text), "Done");
                    }
                    else if (dept.Equals("tasfia"))
                    {
                        int i = Orders.updateTasfia(int.Parse(txtOrderNum.Text), "Done");
                        //Here is All details of Order is Done
                        int i2 = Orders.updateDoneOrder(int.Parse(txtOrderNum.Text));
                    }
                    else if (dept.Equals("sewing"))
                    {
                        int i = Orders.updateSewing(int.Parse(txtOrderNum.Text), "Done");
                    }
                    MessageBox.Show("Done");
                    txtName.Text = txtOrderNum.Text = "";
                }
                catch (Exception) { MessageBox.Show("There is an error !!!"); }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtOrderNum.Text.Equals("") || txtName.Text.Equals(""))
            {
                MessageBox.Show("Please insert Order number and press ENTER");
            }
            else
            {
                try
                {
                    if (dept.Equals("tafseel"))
                    {
                        int i = Orders.updateTafseel(int.Parse(txtOrderNum.Text), "");
                    }
                    else if (dept.Equals("printOne"))
                    {
                        int i = Orders.updatePrint_One(int.Parse(txtOrderNum.Text), "");
                    }
                    else if (dept.Equals("printTwo"))
                    {
                        int i = Orders.updatePrint_Two(int.Parse(txtOrderNum.Text), "");
                    }
                    else if (dept.Equals("tatreez"))
                    {
                        int i = Orders.updateTatreez(int.Parse(txtOrderNum.Text), "");
                    }
                    else if (dept.Equals("tasfia"))
                    {
                        int i = Orders.updateTasfia(int.Parse(txtOrderNum.Text), "");
                        //Here return order to execute 
                        int returnToUnDone = Orders.updateToUnDone(int.Parse(txtOrderNum.Text));
                    }
                    else if (dept.Equals("sewing"))
                    {
                        int i = Orders.updateSewing(int.Parse(txtOrderNum.Text), "");
                    }
                    MessageBox.Show("Done");
                    txtName.Text = txtOrderNum.Text = "";
                }
                catch (Exception) { MessageBox.Show("There is an error !!!"); }
            }
        }
    }
}
