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
    public partial class Frm_NewOrder : Form
    {
        
        int NumOfImage = 0;
        List<byte[]> images = new List<byte[]>();

        int NumOfImageQute = 0;
        List<byte[]> imagesQute = new List<byte[]>();

        public Frm_NewOrder()
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

        private void btnChooseImg_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtOrderBarcode.Text.Equals("") || txtClientName.Text.Equals("") || txtDesc.Text.Equals("")
                    || txtFollower.Text.Equals("") || NumOfImage == 0 || NumOfImageQute == 0 || cmbSeason.Text.Equals("")
                    || cmbsex.Text.Equals("") || txtNumOfPic.Text.Equals(""))
                {
                    MessageBox.Show("الرجاء ملئ جميع الحقول الضرورية وكذلك تحميل صور الطلبية");
                }
                else
                {
                    
                    string Order_State = "";
                    string Print_Emp = " ";
                    string o_print = "";
                    string o_emp = "";
                    string ReadyPro = "";
                    string Tafseel = "";
                    string IsCut = "cut";
                    string Print_one = "";
                    string Tatreez = "";
                    string print_two = "";
                    if (chbState.Checked == true) { Order_State = "مستعجلة"; }
                    if (chbEmp.Checked == true) { Print_Emp += "تطريز"; o_emp = "emp"; } else { Tatreez += "لا يوجد";  }
                    if (chbPrint.Checked == true) { Print_Emp += "  طباعة"; o_print = "print"; } else { Print_one = print_two += "لا يوجد";  }
                    if (chbReadyPro.Checked == true) { ReadyPro += "جاهزة"; IsCut = ""; Tafseel += "بضاعة جاهزة"; }



                    //Add to Orders

                    //int addDoc = Orders.InsertOrder(dtpCreater.Value,txtNumOfPic.Text, txtClientName.Text, txtDesc.Text, txtFollower.Text,dtpDeadLine.Value,
                    //    Order_State, Print_Emp, "cut", o_print,o_emp,txtOrderBarcode.Text,cmbSeason.Text);
                    int addDoc = Orders.InsertNewOrder(dtpCreater.Value,txtNumOfPic.Text, txtClientName.Text, txtDesc.Text, txtFollower.Text,dtpDeadLine.Value,
                        Order_State, Print_Emp, IsCut , o_print,o_emp,txtOrderBarcode.Text,cmbSeason.Text,cmbsex.Text,
                        Convert.ToInt32(cmbCat.SelectedValue),Convert.ToInt32(cmbCol.SelectedValue),"", dtpCreater.Value, ReadyPro, Tafseel,Print_one, Tatreez,print_two);
                    DataTable LastOne = Orders.lastOrderId();
                    if (NumOfImage > 0)
                    {
                        for (int i = 0; i < images.Count; i++)
                        {
                            int AddImg = Orders.InsertImg(images[i], int.Parse(LastOne.Rows[0][0].ToString()),"طلبية");
                        }
                    }


                    if (NumOfImageQute > 0)
                    {
                        for (int i = 0; i < imagesQute.Count; i++)
                        {
                            int AddImg = Orders.InsertImg(imagesQute[i], int.Parse(LastOne.Rows[0][0].ToString()), "اسعار");
                        }
                    }



                    //Add to Archive

                     int addDocToArchive = ClassDocument.AddDoc("طلبيات كولومبس", txtClientName.Text, txtFollower.Text, dtpCreater.Value, txtDesc.Text);
                     DataTable LastOnefromArchive = ClassDocument.SelectLastDoc();

                        if (NumOfImage > 0)
                        {
                            for (int i = 0; i < images.Count; i++)
                            {
                                int AddImgArchiveO = ClassDocument.AddDocImage(images[i], int.Parse(LastOnefromArchive.Rows[0][0].ToString()));
                            }
                        }


                        if (NumOfImageQute > 0)
                        {
                            for (int i = 0; i < imagesQute.Count; i++)
                            {
                                 int AddImgArchiveQ = ClassDocument.AddDocImage(imagesQute[i], int.Parse(LastOnefromArchive.Rows[0][0].ToString()));
                            }
                        }


                    //Add All Status of Departments

                    int c = Orders.InsertDeptState("pending", "pending", "pending", "pending", int.Parse(LastOne.Rows[0][0].ToString()));


                    txtClientName.Text = txtDesc.Text = txtFollower.Text= txtOrderBarcode.Text = txtNumOfPic.Text = cmbSeason.Text = "";
                    chbState.Checked = false;
                    chbEmp.Checked = chbPrint.Checked = false;
                    lbNumIMG.Text = "0";
                    lbNumQuteImg.Text = "0";
                    NumOfImage = 0;
                    NumOfImageQute = 0;
                    images.Clear();
                    imagesQute.Clear();
                    MessageBox.Show("تمت عملية الحفظ بنجاح");
                }
            }
            catch { MessageBox.Show("حدث خطأ !! العملية لم تحفظ. "); }
        }

        private void btnChoosQutemg_Click(object sender, EventArgs e)
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
                        imagesQute.Add(arr);

                        NumOfImageQute++;
                    }
                }
                lbNumQuteImg.Text = NumOfImageQute.ToString();
            }
            catch (Exception) { MessageBox.Show("Wrong with Selected Image..\n Image Not Selected"); }
        }

        private void btnUndoQute_Click(object sender, EventArgs e)
        {
            lbNumQuteImg.Text = "0";
            NumOfImageQute = 0;
            imagesQute.Clear();
        }

        private void txtOrderBarcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumOfPic_KeyPress(object sender, KeyPressEventArgs e)
        {
            char d = char.Parse(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;

            }
        }
    }
}
