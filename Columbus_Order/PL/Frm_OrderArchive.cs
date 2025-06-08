using Columbus_Order.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace Columbus_Order.PL
{
    public partial class Frm_OrderArchive : Form
    {
        string state = ""; 
        public Frm_OrderArchive(string tableOrder)
        {
            InitializeComponent();
            try
            {
                if (tableOrder == "Archive") { displayArchive(); state = tableOrder; }
                else if (tableOrder == "AllOrders") { displayAllOrder(); state = tableOrder; }
                else { displayView(); state = tableOrder; }
            }
            catch { MessageBox.Show("لا يمكن الاتصال بالسيرفر"); }
        }
        void displayArchive()
        {
            dgvOrder.DataSource = Orders.SelectOrderArchive();
            dgvOrder.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvOrder.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
            
        }

        void displayAllOrder()
        {
            dgvOrder.DataSource = Orders.SelectAllOrder();
            dgvOrder.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvOrder.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
            this.Text = "عرض جميع الطلبيات";
            this.gboxOrder.Text = "عرض جميع الطلبيات";
            groupBox1.Visible = false;
            groupBox3.Visible = false;

        }

        void displayView()
        {
            dgvOrder.DataSource = Orders.SelectOrderView();
            dgvOrder.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvOrder.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
            this.Text = "إدارة الطلبيات الحالية";
            this.gboxOrder.Text = "الطلبيات الحالية";
        }

        private void dgvOrder_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (state.Equals("View")|| state.Equals("Archive"))
                {
                    txtID.Text = dgvOrder.CurrentRow.Cells[0].Value.ToString();
                    dtpCreater.Value = DateTime.Parse(dgvOrder.CurrentRow.Cells[1].Value.ToString());
                    txtNumOfPic.Text = dgvOrder.CurrentRow.Cells[2].Value.ToString();
                    txtClient.Text = dgvOrder.CurrentRow.Cells[3].Value.ToString();
                    txtDesc.Text = dgvOrder.CurrentRow.Cells[4].Value.ToString();
                    txtFollwo.Text = dgvOrder.CurrentRow.Cells[5].Value.ToString();
                    if (dgvOrder.CurrentRow.Cells[6].Value.ToString() != "") { chbState.Checked = true; }
                    else { chbState.Checked = false; }
                    dtpDeadLine.Value = DateTime.Parse(dgvOrder.CurrentRow.Cells[7].Value.ToString());

                    if (dgvOrder.CurrentRow.Cells[8].Value.ToString() == " تطريز") { chbEmp.Checked = true; chbPrint.Checked = false; }
                    else if (dgvOrder.CurrentRow.Cells[8].Value.ToString() == " ") { chbEmp.Checked = false; chbPrint.Checked = false; }
                    else if (dgvOrder.CurrentRow.Cells[8].Value.ToString() == " تطريز  طباعة")
                    { chbEmp.Checked = true; chbPrint.Checked = true; }
                    else { chbEmp.Checked = false; chbPrint.Checked = true; }

                    txtBarcode.Text = dgvOrder.CurrentRow.Cells[9].Value.ToString();
                    cmbSeason.Text = dgvOrder.CurrentRow.Cells[10].Value.ToString();
                }
                else
                {

                }
            }
            catch { }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
              if (state == "Archive")
               {
                   dgvOrder.DataSource = Orders.SearchOrderArchive(txtSearch.Text);
                   dgvOrder.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy";
                   dgvOrder.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
               }
              else if (state == "AllOrders")
            {
                dgvOrder.DataSource = Orders.SearchAllOrder(txtSearch.Text);
                dgvOrder.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvOrder.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            else
               {
                   dgvOrder.DataSource = Orders.SearchOrderView(txtSearch.Text);
                   dgvOrder.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy";
                   dgvOrder.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
               }
           }

        private void btnViewImg_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Equals("")) { MessageBox.Show("الرجاء اختيار طلبية محددة"); }
            else
            {
                try
                {
                    Frm_ImgOrder a = new Frm_ImgOrder(int.Parse(txtID.Text), "Management", "all");
                    a.ShowDialog();
                }
                catch (Exception) { }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text.Equals("")||txtClient.Text.Equals("")||txtDesc.Text.Equals("")||txtFollwo.Text.Equals("") || cmbSeason.Text.Equals(""))
                {
                    MessageBox.Show("الرجاء اختيار طلبية و ملىء الحقول المطلوبة");
                }
                else
                {
                    if (MessageBox.Show("هل تريد بالتأكيد تعديل هذه الطلبية", "تعديل طلبية", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        string s = "";
                        string Print_Emp = " ";
                        string Order_Print = "";
                        string Order_Emp = "";
                        if (chbState.Checked == true) { s = "مستعجلة"; }
                        if (chbEmp.Checked == true) { Print_Emp += "تطريز"; Order_Emp = "emp"; }
                        if (chbPrint.Checked == true) { Print_Emp += "  طباعة"; Order_Print = "print"; }

                        int i = Orders.UpdateOrder(int.Parse(txtID.Text),dtpCreater.Value,txtNumOfPic.Text, txtClient.Text,
                            txtDesc.Text, txtFollwo.Text, dtpDeadLine.Value,s, Print_Emp, Order_Print, Order_Emp,txtBarcode.Text,cmbSeason.Text);

                        txtClient.Text = txtDesc.Text = txtFollwo.Text = txtID.Text = txtSearch.Text = txtBarcode.Text = txtNumOfPic.Text = "";
                        chbState.Checked = false;
                        chbEmp.Checked = chbPrint.Checked = false;
                        MessageBox.Show("تمت عملية التعديل بنجاح");
                        if (state == "Archive")
                        {
                            dgvOrder.DataSource = Orders.SearchOrderArchive(txtSearch.Text);
                            dgvOrder.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy";
                            dgvOrder.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                        }
                        else if (state == "AllOrders")
                        {
                            dgvOrder.DataSource = Orders.SearchAllOrder(txtSearch.Text);
                            dgvOrder.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
                            dgvOrder.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                        }
                        else
                        {
                            dgvOrder.DataSource = Orders.SearchOrderView(txtSearch.Text);
                            dgvOrder.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy";
                            dgvOrder.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                        }
                    }
                    else
                    {
                        MessageBox.Show("تم الغاء عملية التعديل");
                        txtClient.Text = txtDesc.Text = txtFollwo.Text = txtID.Text = txtSearch.Text = txtBarcode.Text = "";
                        chbState.Checked = false;
                        chbEmp.Checked = chbPrint.Checked = false;

                    }
                }
            }
            catch (Exception) { MessageBox.Show("حدث خطأ عند الاتصال بقاعدة البيانات"); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text.Equals(""))
                {
                    MessageBox.Show("الرجاء اختيار طلبية محدد");
                }
                else
                {
                    if (MessageBox.Show("هل تريد بالتأكيد حذف هذه الطلبية", "حذف طلبية", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        //  int DelImgWith = ClassDocument.DeleteImgWithDelDoc(int.Parse(txtID.Text));
                        //  int i = ClassDocument.DeleteDoc(int.Parse(txtID.Text));

                        int i = Orders.deleteImgOrder(int.Parse(txtID.Text));
                        int ii = Orders.deleteOrder(int.Parse(txtID.Text));

                        txtClient.Text = txtDesc.Text = txtFollwo.Text = txtID.Text = txtSearch.Text = "";
                        MessageBox.Show("تمت عملية الحذف بنجاح");
                        if (state == "Archive")
                        {
                            dgvOrder.DataSource = Orders.SearchOrderArchive(txtSearch.Text);
                            dgvOrder.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy";
                            dgvOrder.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                        }

                        else if (state == "AllOrders")
                        {
                            dgvOrder.DataSource = Orders.SearchAllOrder(txtSearch.Text);
                            dgvOrder.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
                            dgvOrder.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                        }
                        else
                        {
                            dgvOrder.DataSource = Orders.SearchOrderView(txtSearch.Text);
                            dgvOrder.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy";
                            dgvOrder.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                        }
                    }
                    else {
                        MessageBox.Show("تم الغاء عملية الحذف");
                        txtClient.Text = txtDesc.Text = txtFollwo.Text = txtID.Text = txtSearch.Text = txtNumOfPic.Text = "";
                        chbState.Checked = false;
                        chbEmp.Checked = chbPrint.Checked = false;
                    }
                }
            }
            catch (Exception) { MessageBox.Show("حدث خطأ عند الاتصال بقاعدة البيانات"); }
        }

        private void dgvOrder_MouseClick(object sender, MouseEventArgs e)
        {
            
            
                if (e.Button == MouseButtons.Right)
                {/*
                    if (txtID.Text == "") { MessageBox.Show("الرجاء تحديد طلبية"); }
                    else
                {
                    if (MessageBox.Show("الطلبية ذات الرقم  "+txtID.Text+"  : \n"+"هل تريد بالتأكيد اعادة هذه الطلبية الى حالة التنفيذ", "اعادة الطلبية للتنفيذ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        

                        if (state == "Archive")
                        {
                            dgvOrder.DataSource = Orders.SearchOrderArchive(txtSearch.Text);
                            dgvOrder.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy";
                            dgvOrder.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";

                            int returnToUnDone = Orders.updateToUnDone(int.Parse(txtID.Text));
                            MessageBox.Show("تمت العملية بنجاح");
                        }

                        else if (state == "AllOrders")
                        {
                            dgvOrder.DataSource = Orders.SearchAllOrder(txtSearch.Text);
                            dgvOrder.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
                            dgvOrder.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";

                            MessageBox.Show("لا يمكن تعديل البيانات من هنا !!!");
                        }
                        else
                        {
                            dgvOrder.DataSource = Orders.SearchOrderView(txtSearch.Text);
                            dgvOrder.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy";
                            dgvOrder.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";

                            int returnToUnDone = Orders.updateToUnDone(int.Parse(txtID.Text));
                            MessageBox.Show("تمت العملية بنجاح");
                        }
                        txtClient.Text = txtDesc.Text = txtFollwo.Text = txtID.Text = txtSearch.Text = "";
                        chbState.Checked = false;
                        
                    }
                }
                */
                }
                else
            {
                try
                {
                    txtID.Text = dgvOrder.CurrentRow.Cells[0].Value.ToString();
                    dtpCreater.Value = DateTime.Parse(dgvOrder.CurrentRow.Cells[1].Value.ToString());
                    txtNumOfPic.Text = dgvOrder.CurrentRow.Cells[2].Value.ToString();
                    txtClient.Text = dgvOrder.CurrentRow.Cells[3].Value.ToString();
                    txtDesc.Text = dgvOrder.CurrentRow.Cells[4].Value.ToString();
                    txtFollwo.Text = dgvOrder.CurrentRow.Cells[5].Value.ToString();
                    if (dgvOrder.CurrentRow.Cells[6].Value.ToString() != "") { chbState.Checked = true; }
                    else { chbState.Checked = false; }
                    dtpDeadLine.Value = DateTime.Parse(dgvOrder.CurrentRow.Cells[7].Value.ToString());

                    if (dgvOrder.CurrentRow.Cells[8].Value.ToString() == " تطريز") { chbEmp.Checked = true; chbPrint.Checked = false; }
                    else if (dgvOrder.CurrentRow.Cells[8].Value.ToString() == " ") { chbEmp.Checked = false; chbPrint.Checked = false; }
                    else if (dgvOrder.CurrentRow.Cells[8].Value.ToString() == " تطريز  طباعة")
                    { chbEmp.Checked = true; chbPrint.Checked = true; }
                    else { chbEmp.Checked = false; chbPrint.Checked = true; }

                    txtBarcode.Text = dgvOrder.CurrentRow.Cells[9].Value.ToString();
                    cmbSeason.Text = dgvOrder.CurrentRow.Cells[10].Value.ToString();
                }
                catch { }
            }
            
        }
    }
    }
