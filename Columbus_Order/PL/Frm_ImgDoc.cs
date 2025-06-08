using Columbus_Order.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Columbus_Order.PL
{
    public partial class Frm_ImgDoc : Form
    {
        Image imgZoom;
        string DocID;
        int numOfImag = 0;
        int counter = 1;
        DataTable dt = new DataTable();
        byte[] arr;

        public Frm_ImgDoc(string id, string Rep_status)
        {
            InitializeComponent();
            DocID = id;
            if (Rep_status.Equals("Report")) { btnSave.Visible = btnDelete.Visible = btnSelectOne.Visible = false; }
            dt = ClassDocument.selectImgForOneDoc(int.Parse(DocID));
            numOfImag = dt.Rows.Count;
            try
            {
                txtIMGid.Text = dt.Rows[0][0].ToString();
                byte[] arr = (byte[])(dt.Rows[0][1]);
                MemoryStream ms = new MemoryStream(arr);
                picImage.Image = Image.FromStream(ms);
                imgZoom = Image.FromStream(ms);
            }
            catch (Exception) { }
        }

        private void btnNextIMG_Click(object sender, EventArgs e)
        {
            if (numOfImag > 0)
            {
                try
                {
                    txtIMGid.Text = dt.Rows[counter][0].ToString();
                    byte[] arr = (byte[])(dt.Rows[counter][1]);
                    MemoryStream ms = new MemoryStream(arr);
                    picImage.Image = Image.FromStream(ms);
                    imgZoom = Image.FromStream(ms);
                    counter++;
                }
                catch (Exception)
                {
                    txtIMGid.Text = dt.Rows[0][0].ToString();
                    byte[] arr = (byte[])(dt.Rows[0][1]);
                    MemoryStream ms = new MemoryStream(arr);
                    picImage.Image = Image.FromStream(ms);
                    imgZoom = Image.FromStream(ms);
                    counter = 1;
                }
            }
        }

        private void btnFirstIMG_Click(object sender, EventArgs e)
        {
            if (numOfImag > 0)
            {
                txtIMGid.Text = dt.Rows[0][0].ToString();
                byte[] arr = (byte[])(dt.Rows[0][1]);
                MemoryStream ms = new MemoryStream(arr);
                picImage.Image = Image.FromStream(ms);
                imgZoom = Image.FromStream(ms);
                counter = 1;
            }
        }

        private void btnSelectOne_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Please Select Images";
                ofd.Filter = "JPG|*.jpg|JPEG|*.jpeg|GIF|*.gif|PNG|*.png";
                DialogResult dr = ofd.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    picImage.Image = Image.FromFile(ofd.FileName);
                    imgZoom = Image.FromFile(ofd.FileName);

                    MemoryStream ms = new MemoryStream();
                    picImage.Image.Save(ms, picImage.Image.RawFormat);
                    arr = ms.ToArray();

                    txtIMGid.Text = "";

                }

            }
            catch (Exception) { MessageBox.Show("Wrong with Selected Image..\n Image Not Selected"); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIMGid.Text.Equals("") && picImage.Image != null)
                {
                    int addIMG = ClassDocument.insertImgToDoc(arr, int.Parse(DocID));
                    dt = ClassDocument.selectImgForOneDoc(int.Parse(DocID));

                    MessageBox.Show("Done . .");
                    numOfImag = dt.Rows.Count;
                    btnFirstIMG_Click(null, null);
                }

            }
            catch (Exception) { }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (picImage.Image == null) { MessageBox.Show("No Image Selected !!."); }
            else
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                // saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif"; 
                saveFileDialog1.Filter = "JPG|*.jpg|JPEG|*.jpeg|GIF|*.gif|PNG|*.png";
                saveFileDialog1.Title = "Save an Image File";
                saveFileDialog1.ShowDialog();

                if (saveFileDialog1.FileName != "")
                {
                    // Saves the Image via a FileStream created by the OpenFile method.  

                    System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                    picImage.Image.Save(fs, picImage.Image.RawFormat);
                    MessageBox.Show("تمت تصدير الصورة بنجاح");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtIMGid.Text.Equals(""))
            {
                picImage.Image = null;
                imgZoom = null;
            }
            else
            {
                if (MessageBox.Show(" هل تريد بالتأكيد حذف هذه الصورة", "حذف صورة مستند", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int delImage = ClassDocument.DeleteImg(int.Parse(txtIMGid.Text));
                    dt = ClassDocument.selectImgForOneDoc(int.Parse(DocID));

                    MessageBox.Show("Done . .");
                    txtIMGid.Text = "";
                    picImage.Image = null;
                    imgZoom = null;
                }
            }
            numOfImag = dt.Rows.Count;
            btnFirstIMG_Click(null, null);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            //PrintDialog myPrinDialog1 = new PrintDialog();
            pd.PrintPage += PrintPage;

            ppd.Document = pd;
            ppd.Width = 595;
            ppd.Height = 842;
            ppd.ShowDialog();
            //myPrinDialog1.Document = pd;
            //if (myPrinDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    pd.Print();
            //}
        }
        private void PrintPage(object o, PrintPageEventArgs e)
        {
            System.Drawing.Image img = picImage.Image;
            Point loc = new Point(0, 0);
            e.Graphics.DrawImage(img, loc);
        }

        private void picImage_DoubleClick(object sender, EventArgs e)
        {
            Frm_ImgZoom frm = new Frm_ImgZoom(imgZoom);
            frm.ShowDialog();
        }
    }
}
