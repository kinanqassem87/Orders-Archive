namespace Columbus_Order.PL
{
    partial class Frm_MessageConfirm
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
            this.btnViewOrder = new System.Windows.Forms.Button();
            this.btnMoveOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewOrder
            // 
            this.btnViewOrder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOrder.Location = new System.Drawing.Point(12, 12);
            this.btnViewOrder.Name = "btnViewOrder";
            this.btnViewOrder.Size = new System.Drawing.Size(204, 35);
            this.btnViewOrder.TabIndex = 0;
            this.btnViewOrder.Text = "عرض الطلبية";
            this.btnViewOrder.UseVisualStyleBackColor = true;
            this.btnViewOrder.Click += new System.EventHandler(this.btnViewOrder_Click);
            // 
            // btnMoveOrder
            // 
            this.btnMoveOrder.Enabled = false;
            this.btnMoveOrder.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveOrder.ForeColor = System.Drawing.Color.DarkRed;
            this.btnMoveOrder.Location = new System.Drawing.Point(316, 12);
            this.btnMoveOrder.Name = "btnMoveOrder";
            this.btnMoveOrder.Size = new System.Drawing.Size(204, 35);
            this.btnMoveOrder.TabIndex = 1;
            this.btnMoveOrder.Text = "ترحيل الطلبية";
            this.btnMoveOrder.UseVisualStyleBackColor = true;
            this.btnMoveOrder.Click += new System.EventHandler(this.btnMoveOrder_Click);
            // 
            // Frm_MessageConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 55);
            this.Controls.Add(this.btnMoveOrder);
            this.Controls.Add(this.btnViewOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_MessageConfirm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "العملية المراد تنفيذها";
            this.Load += new System.EventHandler(this.Frm_MessageConfirm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewOrder;
        private System.Windows.Forms.Button btnMoveOrder;
    }
}