namespace Columbus_Order.PL
{
    partial class Frm_OrderView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvOrderView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrderView
            // 
            this.dgvOrderView.AllowUserToAddRows = false;
            this.dgvOrderView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.dgvOrderView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrderView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 20F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrderView.ColumnHeadersHeight = 50;
            this.dgvOrderView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOrderView.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvOrderView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderView.Location = new System.Drawing.Point(0, 0);
            this.dgvOrderView.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.dgvOrderView.MultiSelect = false;
            this.dgvOrderView.Name = "dgvOrderView";
            this.dgvOrderView.ReadOnly = true;
            this.dgvOrderView.RowTemplate.Height = 50;
            this.dgvOrderView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderView.Size = new System.Drawing.Size(1783, 860);
            this.dgvOrderView.TabIndex = 0;
            this.dgvOrderView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderView_CellClick);
            this.dgvOrderView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvOrderView_CellFormatting);
            this.dgvOrderView.Click += new System.EventHandler(this.dgvOrderView_Click);
            this.dgvOrderView.DoubleClick += new System.EventHandler(this.dgvOrderView_DoubleClick);
            this.dgvOrderView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvOrderView_KeyPress);
            this.dgvOrderView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvOrderView_MouseClick);
            // 
            // Frm_OrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1783, 860);
            this.Controls.Add(this.dgvOrderView);
            this.Font = new System.Drawing.Font("Arial", 20F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.MaximizeBox = false;
            this.Name = "Frm_OrderView";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "الطلبيات الحالية";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.Frm_OrderView_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvOrderView;
    }
}