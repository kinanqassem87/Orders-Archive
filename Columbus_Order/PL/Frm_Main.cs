using Columbus_Order.PL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Columbus_Order.BL
{
    public partial class Frm_Main : Form
    {
        public static string ServerName = "";
        public static string ServerNamePassword = "";


        public static string FullName = "";
        public static string UserName = "";
        public static string U_Password = "";
        public static string u_id = "";
        public static string Per = "";
        public static string User_Type = "";
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void تسجيلالدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_SignIN a = new FRM_SignIN();
            a.ShowDialog();
        }

        private void Frm_Main_Activated(object sender, EventArgs e)
        {
            if (Per.Equals("admin"))
            {
                تسجيلالخروجToolStripMenuItem.Enabled = عرضالطلبياتToolStripMenuItem.Enabled = إدارةالطلبياتToolStripMenuItem.Enabled = true;
                طلبياتالاقسامToolStripMenuItem.Enabled = طلبياتالتفصيلوالقصToolStripMenuItem.Enabled = true;
                طلبياتالطباعةToolStripMenuItem.Enabled = true;
                طلبياتالتطريزToolStripMenuItem.Enabled = true;
                ادارةطلبياتالقصوالتفصيلToolStripMenuItem.Enabled = ادارةطلبياتالطباعةToolStripMenuItem.Enabled = ادارةطلبياتالتطريزToolStripMenuItem.Enabled = true;
                البحثفيالطلبياتToolStripMenuItem.Enabled = true;

                الارشيفToolStripMenuItem.Enabled = عرضجميعالمستنداتToolStripMenuItem.Enabled = true;
                اضافةمستندجديدToolStripMenuItem.Enabled =ادارةالارشيفToolStripMenuItem.Enabled= true;
                قسمتحضيرالموادالاوليةToolStripMenuItem.Enabled = true;

                تسجيلالدخولToolStripMenuItem.Enabled = false;
            }
            if (Per.Equals("user"))
            {
                if (UserName.Equals("maaz"))
                {
                    طلبياتالاقسامToolStripMenuItem.Enabled = طلبياتالتفصيلوالقصToolStripMenuItem.Enabled = true;
                    ادارةطلبياتالقصوالتفصيلToolStripMenuItem.Enabled = true;
                    TafseelDone.Enabled = true;
                }
                if (UserName.Equals("print"))
                {
                    طلبياتالاقسامToolStripMenuItem.Enabled = طلبياتالطباعةToolStripMenuItem.Enabled = true;
                    ادارةطلبياتالطباعةToolStripMenuItem.Enabled = true;
                    printDone.Enabled = true;
                }
                if (UserName.Equals("emp"))
                {
                    طلبياتالاقسامToolStripMenuItem.Enabled = طلبياتالتطريزToolStripMenuItem.Enabled = true;
                    ادارةطلبياتالتطريزToolStripMenuItem.Enabled = true;
                    tatreezDone.Enabled = true;
                }
                تسجيلالخروجToolStripMenuItem.Enabled = عرضالطلبياتToolStripMenuItem.Enabled = true;
                if (UserName.Equals("UserA"))
                {
                    الارشيفToolStripMenuItem.Enabled = عرضجميعالمستنداتToolStripMenuItem.Enabled = true;
                }
                if (UserName.Equals("1"))
                {
                    الارشيفToolStripMenuItem.Enabled = عرضجميعالمستنداتToolStripMenuItem.Enabled = true;
                    طلبياتالاقسامToolStripMenuItem.Enabled = طلبياتالتفصيلوالقصToolStripMenuItem.Enabled = true;
                    طلبياتالطباعةToolStripMenuItem.Enabled = true;
                    طلبياتالتطريزToolStripMenuItem.Enabled = true;
                    البحثفيالطلبياتToolStripMenuItem.Enabled = true;
                    sewingDone.Enabled = true;
                }

                if (UserName.Equals("noor"))
                {
                    طلبياتالاقسامToolStripMenuItem.Enabled = true;
                    قسمتحضيرالموادالاوليةToolStripMenuItem.Enabled = true;
                    عرضالطلبياتToolStripMenuItem.Enabled = true;
                    noorDone.Enabled = true;
                }
                تسجيلالدخولToolStripMenuItem.Enabled = false;
            }
        }

        private void تسجيلالخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Per = "out";
            تسجيلالخروجToolStripMenuItem.Enabled = عرضالطلبياتToolStripMenuItem.Enabled = إدارةالطلبياتToolStripMenuItem.Enabled = false;
            الارشيفToolStripMenuItem.Enabled = عرضجميعالمستنداتToolStripMenuItem.Enabled = false;
            اضافةمستندجديدToolStripMenuItem.Enabled = ادارةالارشيفToolStripMenuItem.Enabled = false;
            تسجيلالدخولToolStripMenuItem.Enabled = true;
            ادارةطلبياتالقصوالتفصيلToolStripMenuItem.Enabled = ادارةطلبياتالطباعةToolStripMenuItem.Enabled = ادارةطلبياتالتطريزToolStripMenuItem.Enabled = false;

            طلبياتالاقسامToolStripMenuItem.Enabled = طلبياتالتفصيلوالقصToolStripMenuItem.Enabled = false;
            طلبياتالطباعةToolStripMenuItem.Enabled = false;
            طلبياتالتطريزToolStripMenuItem.Enabled = false;
            البحثفيالطلبياتToolStripMenuItem.Enabled = false;
            قسمتحضيرالموادالاوليةToolStripMenuItem.Enabled = false;
            sewingDone.Enabled = printDone.Enabled = TafseelDone.Enabled = tatreezDone.Enabled = noorDone.Enabled = false;

            FRM_SignIN s = new FRM_SignIN();
            s.ShowDialog();
        }

        private void إدخالطلبيةجديدةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_NewOrder frm = new Frm_NewOrder();
            frm.ShowDialog();
        }

        private void عرضالطلبياتToolStripMenuItem_Click(object sender, EventArgs e)
        {
             //Frm_OrderView frm = new Frm_OrderView();
            Frm_ViewAllOrdersNew frm = new Frm_ViewAllOrdersNew();
            frm.ShowDialog();
        }

        private void جدولالارشيفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_OrderArchive frm = new Frm_OrderArchive("Archive");
            frm.ShowDialog();
        }

        private void إدارةالطلبياتالحاليةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_OrderArchive frm = new Frm_OrderArchive("View");
            frm.ShowDialog();
        }

        private void اضافةمستندجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_AddNewDoc frm = new Frm_AddNewDoc();
            frm.ShowDialog();
        }

        private void عرضجميعالمستنداتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DisplayAllDoc frm = new Frm_DisplayAllDoc();
            frm.ShowDialog();
        }

        private void ادارةالارشيفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DocManagement frm = new Frm_DocManagement();
            frm.ShowDialog();
        }

        private void طلبياتالتفصيلوالقصToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_OrderViewCPE frm = new Frm_OrderViewCPE("c");
            frm.ShowDialog();
        }

        private void طلبياتالطباعةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_OrderViewCPE frm = new Frm_OrderViewCPE("p");
            frm.ShowDialog();
        }

        private void طلبياتالتطريزToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_OrderViewCPE frm = new Frm_OrderViewCPE("e");
            frm.ShowDialog();
        }

        private void ادارةطلبياتالقصوالتفصيلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_OrderCPEManag frm = new Frm_OrderCPEManag("c");
            frm.ShowDialog();
        }

        private void ادارةطلبياتالطباعةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_OrderCPEManag frm = new Frm_OrderCPEManag("p");
            frm.ShowDialog();
        }

        private void ادارةطلبياتالتطريزToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_OrderCPEManag frm = new Frm_OrderCPEManag("e");
            frm.ShowDialog();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            ServerName = txtServer.Text;
            ServerNamePassword = txtPassServer.Text;

            MessageBox.Show("تم تعيين الابي الخاص بالسيرفر");
            txtServer.Text = "";
            txtPassServer.Text = "";
        }

        private void عرضجميعالطلبياتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_OrderArchive frm = new Frm_OrderArchive("AllOrders");
            frm.ShowDialog();
        }

        private void البحثفيالطلبياتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_OrderArchive frm = new Frm_OrderArchive("AllOrders");
            frm.ShowDialog();
        }

        private void طلبياتفيالانتظارToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_OrderViewCPE frm = new Frm_OrderViewCPE("row");
            frm.ShowDialog();
        }

        private void طلبياتتمتحضيرهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_OrderCPEManag frm = new Frm_OrderCPEManag("row");
            frm.ShowDialog();
        }

        private void addNewCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Category frm = new Frm_Category();
            frm.ShowDialog();
        }

        private void addNewCollectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Collection frm = new Frm_Collection();
            frm.ShowDialog();
        }

        private void editCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CatManagement frm = new Frm_CatManagement("cat");
            frm.ShowDialog();
        }

        private void editCollectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CatManagement frm = new Frm_CatManagement("col");
            frm.ShowDialog();
        }

        private void TafseelDone_Click(object sender, EventArgs e)
        {
            Frm_OrderDone frm = new Frm_OrderDone("tafseel");
            frm.ShowDialog();
        }

        private void طباعةمرحلةاولىToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_OrderDone frm = new Frm_OrderDone("printOne");
            frm.ShowDialog();
        }

        private void طباعةمرحلةثانيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_OrderDone frm = new Frm_OrderDone("printTwo");
            frm.ShowDialog();
        }

        private void tatreezDone_Click(object sender, EventArgs e)
        {
            Frm_OrderDone frm = new Frm_OrderDone("tatreez");
            frm.ShowDialog();
        }

        private void noorDone_Click(object sender, EventArgs e)
        {
            Frm_OrderDone frm = new Frm_OrderDone("tasfia");
            frm.ShowDialog();
        }

        private void تأكيدتنفيذالطلبيةToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Frm_OrderDone frm = new Frm_OrderDone("sewing");
            frm.ShowDialog();
        }

        private void ادخالرقموتاريخالانتاجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ProductionForm frm = new Frm_ProductionForm();
            frm.ShowDialog();
        }

        private void updateColCatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Update_Col_Cat frm = new Frm_Update_Col_Cat();
            frm.ShowDialog();
        }

        private void تعديلطلبيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Update_Order frm = new Frm_Update_Order();
            frm.ShowDialog();
        }
    }
}
