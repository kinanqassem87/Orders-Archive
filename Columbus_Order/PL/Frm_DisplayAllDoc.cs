using Columbus_Order.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Columbus_Order.PL
{
    public partial class Frm_DisplayAllDoc : Form
    {
        string DocID;
        DataTable dt = new DataTable();
        public Frm_DisplayAllDoc()
        {
            InitializeComponent();
            cmbDate.Text = "قبل";
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
            pic1.Image = null;
            pic2.Image = null;
        }

        private void dgvDoc_DoubleClick(object sender, EventArgs e)
        {
            pic1.Image = null;
            pic2.Image = null;
            try
            {
                DocID = dgvDoc.CurrentRow.Cells[0].Value.ToString();
                dt = ClassDocument.selectImgForOneDoc(int.Parse(dgvDoc.CurrentRow.Cells[0].Value.ToString()));

                byte[] arr = (byte[])(dt.Rows[0][1]);
                MemoryStream ms = new MemoryStream(arr);
                pic1.Image = Image.FromStream(ms);

                byte[] arr1 = (byte[])(dt.Rows[1][1]);
                MemoryStream ms1 = new MemoryStream(arr1);
                pic2.Image = Image.FromStream(ms1);
            }
            catch (Exception) { }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            pic1.Image = null;
            pic2.Image = null;

            if (cmbDate.Text.Equals("قبل"))
            {
                dgvDoc.DataSource = ClassDocument.SearchBeforDate(dtpSearch.Value);
                dgvDoc.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (cmbDate.Text.Equals("بعد"))
            {
                dgvDoc.DataSource = ClassDocument.SearchAfterDate(dtpSearch.Value);
                dgvDoc.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (cmbDate.Text.Equals("يساوي"))
            {
                dgvDoc.DataSource = ClassDocument.SearchEqualDate(dtpSearch.Value);
                dgvDoc.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        private void btnViewImg_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_ImgDoc a = new Frm_ImgDoc(DocID, "Report");
                a.ShowDialog();
            }
            catch (Exception) { }
        }

        private void dgvDoc_Click(object sender, EventArgs e)
        {
            pic1.Image = null;
            pic2.Image = null;
            try
            {
                DocID = dgvDoc.CurrentRow.Cells[0].Value.ToString();
                dt = ClassDocument.selectImgForOneDoc(int.Parse(dgvDoc.CurrentRow.Cells[0].Value.ToString()));

                byte[] arr = (byte[])(dt.Rows[0][1]);
                MemoryStream ms = new MemoryStream(arr);
                pic1.Image = Image.FromStream(ms);

                byte[] arr1 = (byte[])(dt.Rows[1][1]);
                MemoryStream ms1 = new MemoryStream(arr1);
                pic2.Image = Image.FromStream(ms1);
            }
            catch (Exception) { }
        }
    }
}
