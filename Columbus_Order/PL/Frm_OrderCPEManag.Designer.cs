namespace Columbus_Order.PL
{
    partial class Frm_OrderCPEManag
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCPEManag = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCPEManag)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCPEManag
            // 
            this.dgvCPEManag.AllowUserToAddRows = false;
            this.dgvCPEManag.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.dgvCPEManag.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCPEManag.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCPEManag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCPEManag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCPEManag.Location = new System.Drawing.Point(0, 0);
            this.dgvCPEManag.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgvCPEManag.MultiSelect = false;
            this.dgvCPEManag.Name = "dgvCPEManag";
            this.dgvCPEManag.ReadOnly = true;
            this.dgvCPEManag.RowTemplate.Height = 50;
            this.dgvCPEManag.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCPEManag.Size = new System.Drawing.Size(1784, 1049);
            this.dgvCPEManag.TabIndex = 1;
            this.dgvCPEManag.Click += new System.EventHandler(this.dgvCPEManag_Click);
            this.dgvCPEManag.DoubleClick += new System.EventHandler(this.dgvCPEManag_DoubleClick);
            // 
            // Frm_OrderCPEManag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1784, 1049);
            this.Controls.Add(this.dgvCPEManag);
            this.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "Frm_OrderCPEManag";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ادارة الاقسام";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.Frm_OrderCPEManag_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCPEManag)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCPEManag;
    }
}