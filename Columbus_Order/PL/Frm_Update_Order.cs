using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Columbus_Order.BL;

namespace Columbus_Order.PL
{
    public partial class Frm_Update_Order : Form
    {
        public Frm_Update_Order()
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

        private void txtOrderID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char d = char.Parse(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;

            }
        }

        private void txtOrderID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)

                if (txtOrderID.Text.Equals(""))
                {
                    MessageBox.Show("الرجاء ادخال رقم الطلبية");
                }
                else
                {
                    DataTable dt = Orders.selectOneOrder(int.Parse(txtOrderID.Text));
                    if (dt.Rows.Count > 0)
                    {
                        txtOrderBarcode.Enabled = txtClientName.Enabled = txtDesc.Enabled = txtFollower.Enabled = txtNumOfPic.Enabled = true;
                        txtNumOfPic.Text = dt.Rows[0][2].ToString();
                        txtClientName.Text = dt.Rows[0][3].ToString();
                        txtDesc.Text = dt.Rows[0][4].ToString();
                        txtFollower.Text = dt.Rows[0][5].ToString();
                        dtpDeadLine.Value = DateTime.Parse(dt.Rows[0][6].ToString());
                        txtOrderBarcode.Text = dt.Rows[0][13].ToString();
                        cmbSeason.Text = dt.Rows[0][14].ToString();
                        cmbsex.Text = dt.Rows[0][15].ToString();
                        cmbCat.Text = dt.Rows[0]["CatName"].ToString();
                        cmbCol.Text = dt.Rows[0]["ColName"].ToString();

                        if (dt.Rows[0][18].ToString().Equals("بضاعة جاهزة")) { chbReadyPro.Checked = true; } else { chbReadyPro.Checked = false; }
                        if (dt.Rows[0][19].ToString().Equals("لا يوجد")) { chbPrint.Checked = false; } else { chbPrint.Checked = true; }
                        if (dt.Rows[0][20].ToString().Equals("لا يوجد")) { chbEmp.Checked = false; } else { chbEmp.Checked = true; }
                        

                    }
                    else
                    {
                        MessageBox.Show("wrong order number");
                    }
                }
        }

        private void txtOrderID_TextChanged(object sender, EventArgs e)
        {
              txtOrderBarcode.Enabled = txtClientName.Enabled = txtDesc.Enabled = txtFollower.Enabled = txtNumOfPic.Enabled = false;
              txtOrderBarcode.Text = txtClientName.Text = txtDesc.Text = txtFollower.Text = txtNumOfPic.Text = "";
            chbReadyPro.Checked = chbPrint.Checked = chbEmp.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtOrderID.Text.Equals("") || txtOrderBarcode.Text.Equals("") || txtClientName.Text.Equals("") || txtDesc.Text.Equals("")
                    || txtFollower.Text.Equals("") || cmbSeason.Text.Equals("")
                    || cmbsex.Text.Equals(""))
                {
                    MessageBox.Show("الرجاء ملئ جميع الحقول الضرورية");
                }
                else
                {
                    string Print_Emp = " ";
                    string o_print = "";
                    string o_emp = "";
                    string ReadyPro = "";
                    string Tafseel = "";
                    string IsCut = "cut";
                    string Print_one = "";
                    string Tatreez = "";
                    string print_two = "";
                    if (chbEmp.Checked == true) { Print_Emp += "تطريز"; o_emp = "emp"; } else { Tatreez += "لا يوجد"; }
                    if (chbPrint.Checked == true) { Print_Emp += "  طباعة"; o_print = "print"; } else { Print_one = print_two += "لا يوجد"; }
                    if (chbReadyPro.Checked == true) { ReadyPro += "جاهزة"; IsCut = ""; Tafseel += "بضاعة جاهزة"; }

                    int UpdateDoc = Orders.UpdateNewOrder(int.Parse(txtOrderID.Text), txtNumOfPic.Text, txtClientName.Text, txtDesc.Text, txtFollower.Text, dtpDeadLine.Value,
                       Print_Emp, IsCut, o_print, o_emp, txtOrderBarcode.Text, cmbSeason.Text, cmbsex.Text,
                       Convert.ToInt32(cmbCat.SelectedValue), Convert.ToInt32(cmbCol.SelectedValue),ReadyPro, Tafseel, Print_one, Tatreez, print_two);

                    txtOrderID.Text = txtClientName.Text = txtDesc.Text = txtFollower.Text = txtOrderBarcode.Text = txtNumOfPic.Text = cmbSeason.Text = "";
                    chbEmp.Checked = chbPrint.Checked = false;
                    MessageBox.Show("تمت عملية التعديل بنجاح");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There is an error!!!");
            }
        }
    }
}
