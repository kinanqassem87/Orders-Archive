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
    public partial class Frm_ProductionForm : Form
    {
        public Frm_ProductionForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtOID.Text.Equals("") || txtProNum.Text.Equals(""))
            {
                MessageBox.Show("Please insert number");
            }
            else
            {
                try
                {
                    DataTable getOrder = Orders.selectOneOrder(int.Parse(txtOID.Text));
                    if (getOrder.Rows.Count > 0)
                    {
                        int i = Orders.UpdateProNumberDate(int.Parse(txtOID.Text), txtProNum.Text, dtpProDate.Value);
                        txtProNum.Text = txtOID.Text = "";
                        MessageBox.Show("Done");
                    }
                    else
                    {
                        MessageBox.Show("Wrong order number !!!");
                    }
                }
                catch(Exception)
                {
                    MessageBox.Show("There is an error");
                }
            }
        }
    }
}
