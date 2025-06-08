namespace Columbus_Order.PL
{
    partial class Frm_Update_Order
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chbReadyPro = new System.Windows.Forms.CheckBox();
            this.chbEmp = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chbPrint = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbCol = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbCat = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbsex = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbSeason = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNumOfPic = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOrderBarcode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtFollower = new System.Windows.Forms.TextBox();
            this.dtpDeadLine = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chbReadyPro
            // 
            this.chbReadyPro.AutoSize = true;
            this.chbReadyPro.Location = new System.Drawing.Point(335, 15);
            this.chbReadyPro.Name = "chbReadyPro";
            this.chbReadyPro.Size = new System.Drawing.Size(85, 17);
            this.chbReadyPro.TabIndex = 8;
            this.chbReadyPro.Text = "بضاعة جاهزة";
            this.chbReadyPro.UseVisualStyleBackColor = true;
            // 
            // chbEmp
            // 
            this.chbEmp.AutoSize = true;
            this.chbEmp.Location = new System.Drawing.Point(194, 15);
            this.chbEmp.Name = "chbEmp";
            this.chbEmp.Size = new System.Drawing.Size(74, 17);
            this.chbEmp.TabIndex = 6;
            this.chbEmp.Text = "يوجد تطريز";
            this.chbEmp.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chbReadyPro);
            this.groupBox5.Controls.Add(this.chbPrint);
            this.groupBox5.Controls.Add(this.chbEmp);
            this.groupBox5.Location = new System.Drawing.Point(10, 392);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(448, 38);
            this.groupBox5.TabIndex = 25;
            this.groupBox5.TabStop = false;
            // 
            // chbPrint
            // 
            this.chbPrint.AutoSize = true;
            this.chbPrint.Location = new System.Drawing.Point(29, 15);
            this.chbPrint.Name = "chbPrint";
            this.chbPrint.Size = new System.Drawing.Size(77, 17);
            this.chbPrint.TabIndex = 7;
            this.chbPrint.Text = "يوجد طباعة";
            this.chbPrint.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.Location = new System.Drawing.Point(10, 442);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(448, 51);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "إلغاء";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(206, 19);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(119, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "تعديل";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cmbCol
            // 
            this.cmbCol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCol.FormattingEnabled = true;
            this.cmbCol.Location = new System.Drawing.Point(8, 343);
            this.cmbCol.Name = "cmbCol";
            this.cmbCol.Size = new System.Drawing.Size(318, 21);
            this.cmbCol.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(335, 346);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Collection";
            // 
            // cmbCat
            // 
            this.cmbCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCat.FormattingEnabled = true;
            this.cmbCat.Location = new System.Drawing.Point(6, 309);
            this.cmbCat.Name = "cmbCat";
            this.cmbCat.Size = new System.Drawing.Size(318, 21);
            this.cmbCat.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOrderID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbCol);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cmbCat);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cmbsex);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cmbSeason);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtNumOfPic);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtOrderBarcode);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtClientName);
            this.groupBox1.Controls.Add(this.txtDesc);
            this.groupBox1.Controls.Add(this.txtFollower);
            this.groupBox1.Controls.Add(this.dtpDeadLine);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(448, 382);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(7, 16);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(319, 20);
            this.txtOrderID.TabIndex = 0;
            this.txtOrderID.TextChanged += new System.EventHandler(this.txtOrderID_TextChanged);
            this.txtOrderID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOrderID_KeyDown);
            this.txtOrderID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOrderID_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "رقم الطلبية :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(332, 312);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Category";
            // 
            // cmbsex
            // 
            this.cmbsex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbsex.FormattingEnabled = true;
            this.cmbsex.Items.AddRange(new object[] {
            "Women",
            "Men",
            "Kids",
            "Others"});
            this.cmbsex.Location = new System.Drawing.Point(6, 277);
            this.cmbsex.Name = "cmbsex";
            this.cmbsex.Size = new System.Drawing.Size(318, 21);
            this.cmbsex.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(332, 280);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "الجنس:";
            // 
            // cmbSeason
            // 
            this.cmbSeason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeason.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSeason.FormattingEnabled = true;
            this.cmbSeason.Items.AddRange(new object[] {
            "ربيعي",
            "صيفي",
            "خريفي",
            "شتائي",
            "متعدد المواسم "});
            this.cmbSeason.Location = new System.Drawing.Point(7, 193);
            this.cmbSeason.Name = "cmbSeason";
            this.cmbSeason.Size = new System.Drawing.Size(318, 21);
            this.cmbSeason.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(335, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "الموسم: ";
            // 
            // txtNumOfPic
            // 
            this.txtNumOfPic.Location = new System.Drawing.Point(6, 93);
            this.txtNumOfPic.Name = "txtNumOfPic";
            this.txtNumOfPic.Size = new System.Drawing.Size(319, 20);
            this.txtNumOfPic.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(335, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "عدد القطع : ";
            // 
            // txtOrderBarcode
            // 
            this.txtOrderBarcode.Location = new System.Drawing.Point(7, 42);
            this.txtOrderBarcode.Name = "txtOrderBarcode";
            this.txtOrderBarcode.Size = new System.Drawing.Size(319, 20);
            this.txtOrderBarcode.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(332, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "باركود القطعة: ";
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(6, 67);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(319, 20);
            this.txtClientName.TabIndex = 2;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(6, 118);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDesc.Size = new System.Drawing.Size(319, 69);
            this.txtDesc.TabIndex = 4;
            // 
            // txtFollower
            // 
            this.txtFollower.Location = new System.Drawing.Point(6, 220);
            this.txtFollower.Name = "txtFollower";
            this.txtFollower.Size = new System.Drawing.Size(319, 20);
            this.txtFollower.TabIndex = 5;
            // 
            // dtpDeadLine
            // 
            this.dtpDeadLine.Location = new System.Drawing.Point(6, 246);
            this.dtpDeadLine.Name = "dtpDeadLine";
            this.dtpDeadLine.Size = new System.Drawing.Size(319, 20);
            this.dtpDeadLine.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "اسم الزبون : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "تاريخ تسليم الطلبية : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "وصف الطلبية : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "متابع الطلبية : ";
            // 
            // Frm_Update_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 504);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Update_Order";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تعديل طلبية";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chbReadyPro;
        private System.Windows.Forms.CheckBox chbEmp;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox chbPrint;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cmbCol;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbCat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbsex;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbSeason;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNumOfPic;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtOrderBarcode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtFollower;
        private System.Windows.Forms.DateTimePicker dtpDeadLine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label label1;
    }
}