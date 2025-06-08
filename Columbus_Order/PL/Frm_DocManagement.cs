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
    public partial class Frm_DocManagement : Form
    {
        public Frm_DocManagement()
        {
            InitializeComponent();
            display();
        }
        void display()
        {
            dgvDoc.DataSource = ClassDocument.selectAllDoc();
            dgvDoc.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvDoc.DataSource = ClassDocument.searchForDoc(txtSearch.Text);
            dgvDoc.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void dgvDoc_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtID.Text = dgvDoc.CurrentRow.Cells[0].Value.ToString();
                txtType.Text = dgvDoc.CurrentRow.Cells[1].Value.ToString();
                txtOwnDoc.Text = dgvDoc.CurrentRow.Cells[2].Value.ToString();
                txtNumber.Text = dgvDoc.CurrentRow.Cells[3].Value.ToString();
                dtpDoc.Value = DateTime.Parse(dgvDoc.CurrentRow.Cells[4].Value.ToString());
                rtxtNote.Text = dgvDoc.CurrentRow.Cells[5].Value.ToString();
            }
            catch (Exception) { }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text.Equals(""))
                {
                    MessageBox.Show("الرجاء تحديد مستند");
                }
                else
                {
                    int i = ClassDocument.updateDocDetails(int.Parse(txtID.Text), txtType.Text, txtOwnDoc.Text, txtNumber.Text, dtpDoc.Value, rtxtNote.Text);
                    txtID.Text = txtNumber.Text = txtOwnDoc.Text = txtType.Text = rtxtNote.Text = "";
                    MessageBox.Show("تمت العملية بنجاح");
                    display();
                }
            }
            catch (Exception) { }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text.Equals(""))
                {
                    MessageBox.Show("الرجاء اختيار مستند محدد");
                }
                else
                {
                    if (MessageBox.Show("هل تريد بالتأكيد حذف هذا المستند", "حذف مستند", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        int DelImgWith = ClassDocument.DeleteImgWithDelDoc(int.Parse(txtID.Text));
                        int i = ClassDocument.DeleteDoc(int.Parse(txtID.Text));
                        txtID.Text = txtNumber.Text = txtOwnDoc.Text = txtType.Text = rtxtNote.Text = "";
                        MessageBox.Show("تمت عملية الحذف بنجاح");
                        display();
                    }
                }
            }
            catch (Exception) { }
        }

        private void btnImageView_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Equals("")) { MessageBox.Show("الرجاء اختيار مستند محدد"); }
            else
            {
                try
                {
                    Frm_ImgDoc a = new Frm_ImgDoc(txtID.Text, "Management");
                    a.ShowDialog();
                }
                catch (Exception) { }
            }
        }
    }
}
