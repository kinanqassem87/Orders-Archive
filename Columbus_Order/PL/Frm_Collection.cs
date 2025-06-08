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
    public partial class Frm_Collection : Form
    {
        public Frm_Collection()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtColName.Text.Equals(""))
            {
                MessageBox.Show("الرجاء ادخال اسم معين");
            }
            else
            {
                try
                {
                    int i = Orders.AddCol(txtColName.Text);
                    txtColName.Text = "";
                    MessageBox.Show("تمت عملية الحفظ بنجاح");
                }
                catch (Exception)
                {
                    MessageBox.Show("There is an error");
                }
            }
        }
    }
}
