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
    public partial class Frm_ImgOrder : Form
    {
        int Id;
        int numOfImag = 0;
        int counter = 1;
        int counterPerv = 0;
        DataTable dt = new DataTable();
        byte[] arr;
        string ImgId = "";
        string u_type = "";
        Image imgZoom;
        public Frm_ImgOrder(int orderId,string statefrom,string user_Type)
        {
            InitializeComponent();
            Id = orderId;
            u_type = user_Type;
            if (statefrom.Equals("Report")) { btnSave.Visible = btnDelete.Visible = btnSelectOne.Visible = false;btnUpdateImage.Visible = false; }

            if (u_type == "all") { dt = Orders.selectImgForOneDoc(Id); }
            if (u_type == "Order") { dt = Orders.selectImgForOneDocOrders(Id, "طلبية"); }
            if (u_type == "Qute") { dt = Orders.selectImgForOneDocOrders(Id, "اسعار"); }
            
            numOfImag = dt.Rows.Count;
            counterPerv = dt.Rows.Count-1;
            txtIMGid.Text = orderId.ToString();
            try
            {
                //   txtIMGid.Text = dt.Rows[0][0].ToString();
                ImgId = dt.Rows[0][0].ToString();
                byte[] arr = (byte[])(dt.Rows[0][1]);
                MemoryStream ms = new MemoryStream(arr);
                picImage.Image = Image.FromStream(ms);
                imgZoom= Image.FromStream(ms); 
            }
            catch (Exception) { }
        }

        private void btnNextIMG_Click(object sender, EventArgs e)
        {
            if (numOfImag > 0)
            {
                try
                {
                    // txtIMGid.Text = dt.Rows[counter][0].ToString();
                    ImgId = dt.Rows[counter][0].ToString();
                    byte[] arr = (byte[])(dt.Rows[counter][1]);
                    MemoryStream ms = new MemoryStream(arr);
                    picImage.Image = Image.FromStream(ms);
                    imgZoom = Image.FromStream(ms);
                    counterPerv = counter - 1;
                    counter++;
                    
                }
                catch (Exception)
                {
                    // txtIMGid.Text = dt.Rows[0][0].ToString();
                    ImgId = dt.Rows[0][0].ToString();
                    byte[] arr = (byte[])(dt.Rows[0][1]);
                    MemoryStream ms = new MemoryStream(arr);
                    picImage.Image = Image.FromStream(ms);
                    imgZoom = Image.FromStream(ms);
                    counter = 1;
                    counterPerv = dt.Rows.Count - 1;
                }
            }
        }

        private void btnFirstIMG_Click(object sender, EventArgs e)
        {
            if (numOfImag > 0)
            {
                // txtIMGid.Text = dt.Rows[0][0].ToString();
                ImgId = dt.Rows[0][0].ToString();
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

                    //  txtIMGid.Text = "";
                    ImgId = "";

                }

            }
            catch (Exception) { MessageBox.Show("Wrong with Selected Image..\n Image Not Selected"); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ImgId.Equals("") && picImage.Image != null)
                {
                    if (MessageBox.Show("إذا كانت الصورة المضافة عبارة عن طلبية اضغط 'نعم' و اذا كانت عرض اسعار اضغط 'لا' ? ", "اضافة مستند جديد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        int addIMG = Orders.InsertImg(arr, Id, "طلبية");
                        dt = Orders.selectImgForOneDoc(Id);
                    }
                    else
                    {
                        int addIMG = Orders.InsertImg(arr, Id, "اسعار");
                        dt = Orders.selectImgForOneDoc(Id);
                    }

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
            if (ImgId.Equals(""))
            {
                picImage.Image = null;
                imgZoom = null;
            }
            else
            {
                int delImage = Orders.DeleteImg(int.Parse(ImgId));
                dt = Orders.selectImgForOneDoc(Id);

                MessageBox.Show("Done . .");
                ImgId = "";
                picImage.Image = null;
                imgZoom = null;
            }
            numOfImag = dt.Rows.Count;
            btnFirstIMG_Click(null, null);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            //PrintDialog myPrinDialog1 = new PrintDialog();
            pd.PrintPage += Pd_PrintPage; ppd.Document = pd;
            ppd.Width = 595;
            ppd.Height = 842;
            ppd.ShowDialog();
        }

        private void Pd_PrintPage(object sender, PrintPageEventArgs e)
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

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (numOfImag > 0)
            {
                try
                {
                    ImgId = dt.Rows[counterPerv][0].ToString();
                    byte[] arr = (byte[])(dt.Rows[counterPerv][1]);
                    MemoryStream ms = new MemoryStream(arr);
                    picImage.Image = Image.FromStream(ms);
                    imgZoom = Image.FromStream(ms);
                    counter = counterPerv + 1;
                    counterPerv--;
                    
                }
                catch (Exception)
                {
                    // txtIMGid.Text = dt.Rows[0][0].ToString();
                    ImgId = dt.Rows[0][0].ToString();
                    byte[] arr = (byte[])(dt.Rows[0][1]);
                    MemoryStream ms = new MemoryStream(arr);
                    picImage.Image = Image.FromStream(ms);
                    imgZoom = Image.FromStream(ms);
                    counterPerv = dt.Rows.Count-1;
                    counter = 1;
                }
            }
        }

        private void btnUpdateImage_Click(object sender, EventArgs e)
        {
            byte[] arrimg;
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Please Select Images";
                ofd.Filter = "JPG|*.jpg|JPEG|*.jpeg|GIF|*.gif|PNG|*.png";
                DialogResult dr = ofd.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    picImage.Image = Image.FromFile(ofd.FileName);
                   // imgZoom = Image.FromFile(ofd.FileName);

                    MemoryStream ms = new MemoryStream();
                    picImage.Image.Save(ms, picImage.Image.RawFormat);
                    arrimg = ms.ToArray();

                    int i = Orders.UpdateImgOrder(int.Parse(ImgId), arrimg);
                    MessageBox.Show("تم التعديل بنجاح");
                    //  txtIMGid.Text = "";
                    //  ImgId = "";
                    this.Close();
                }

            }
            catch (Exception) { MessageBox.Show("Wrong with Selected Image..\n Image Not Selected"); }
        }
    }
}
