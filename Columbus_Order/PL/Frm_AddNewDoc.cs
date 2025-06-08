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
    public partial class Frm_AddNewDoc : Form
    {
        int NumOfImage = 0;
        List<byte[]> images = new List<byte[]>();

        public Frm_AddNewDoc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                PictureBox img = new PictureBox();
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Please Select Images";
                // ofd.Multiselect = true;
                ofd.Filter = "JPG|*.jpg|JPEG|*.jpeg|GIF|*.gif|PNG|*.png";
                DialogResult dr = ofd.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    string[] files = ofd.FileNames;
                    foreach (string fileName in files)
                    {
                        img.Image = Image.FromFile(ofd.FileName);

                        MemoryStream ms = new MemoryStream();
                        img.Image.Save(ms, img.Image.RawFormat);
                        byte[] arr = ms.ToArray();
                        images.Add(arr);

                        NumOfImage++;
                    }
                }
                lbNumIMG.Text = NumOfImage.ToString();
            }
            catch (Exception) { MessageBox.Show("Wrong with Selected Image..\n Image Not Selected"); }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            lbNumIMG.Text = "0";
            NumOfImage = 0;
            images.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtType.Text.Equals("") || txtOwnDoc.Text.Equals(""))
            {
                MessageBox.Show("الرجاء ملئ الحقول الضرورية");
            }
            else
            {
                int addDoc = ClassDocument.AddDoc(txtType.Text, txtOwnDoc.Text, txtNumber.Text, dtpDoc.Value, rtxtNote.Text);
                if (NumOfImage > 0)
                {
                    DataTable LastOne = ClassDocument.SelectLastDoc();
                    for (int i = 0; i < images.Count; i++)
                    {
                        int AddImg = ClassDocument.AddDocImage(images[i], int.Parse(LastOne.Rows[0][0].ToString()));
                    }
                }
                txtNumber.Text = txtOwnDoc.Text = txtType.Text = rtxtNote.Text = "";
                lbNumIMG.Text = "0";
                NumOfImage = 0;
                images.Clear();
                MessageBox.Show("تمت عملية الحفظ بنجاح");
            }
        }
    }
}
