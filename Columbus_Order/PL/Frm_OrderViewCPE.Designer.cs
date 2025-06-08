namespace Columbus_Order.PL
{
    partial class Frm_OrderViewCPE
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
            this.dgvOrderView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrderView
            // 
            this.dgvOrderView.AllowUserToAddRows = false;
            this.dgvOrderView.AllowUserToDeleteRows = false;
            this.dgvOrderView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrderView.ColumnHeadersHeight = 50;
            this.dgvOrderView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOrderView.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvOrderView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderView.Location = new System.Drawing.Point(0, 0);
            this.dgvOrderView.Margin = new System.Windows.Forms.Padding(21, 20, 21, 20);
            this.dgvOrderView.MultiSelect = false;
            this.dgvOrderView.Name = "dgvOrderView";
            this.dgvOrderView.ReadOnly = true;
            this.dgvOrderView.RowTemplate.Height = 50;
            this.dgvOrderView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderView.Size = new System.Drawing.Size(1912, 1049);
            this.dgvOrderView.TabIndex = 1;
            this.dgvOrderView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvOrderView_CellFormatting);
            this.dgvOrderView.Click += new System.EventHandler(this.dgvOrderView_Click);
            this.dgvOrderView.DoubleClick += new System.EventHandler(this.dgvOrderView_DoubleClick);
            // 
            // Frm_OrderViewCPE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1912, 1049);
            this.Controls.Add(this.dgvOrderView);
            this.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "Frm_OrderViewCPE";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "طلبيات الاقسام";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.Frm_OrderViewCPE_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvOrderView;
    }
}