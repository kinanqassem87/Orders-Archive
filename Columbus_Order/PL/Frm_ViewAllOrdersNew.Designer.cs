namespace Columbus_Order.PL
{
    partial class Frm_ViewAllOrdersNew
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvOrderView = new ADGV.AdvancedDataGridView();
            this.رقمالطلبيةDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.تاريخانشاءالطلبيةDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.رقمالانتاجDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.تاريخالانتاجDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.باركودالقطعةDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.عددالقطعDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.اسمالزبونDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.وصفالطلبيةDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.متابعالطلبيةDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.تاريختسليمالطلبيةDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.الموسمDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.الجنسDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.تفصيلDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.طباعة1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.تطريزDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.خياطةDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.طباعة2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.تصفيةDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.صورةالطلبيةDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectOrderViewNewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pdc_Columbus_OrderDataSet2 = new Columbus_Order.pdc_Columbus_OrderDataSet2();
            this.selectOrderViewNewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.odcNewColumbus_OrderDataSet2 = new Columbus_Order.odcNewColumbus_OrderDataSet2();
            this.selectOrderViewNewTableAdapter = new Columbus_Order.pdc_Columbus_OrderDataSet2TableAdapters.SelectOrderViewNewTableAdapter();
            this.selectOrderViewNewTableAdapter1 = new Columbus_Order.odcNewColumbus_OrderDataSet2TableAdapters.SelectOrderViewNewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectOrderViewNewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdc_Columbus_OrderDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectOrderViewNewBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odcNewColumbus_OrderDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrderView
            // 
            this.dgvOrderView.AllowUserToAddRows = false;
            this.dgvOrderView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.dgvOrderView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrderView.AutoGenerateColumns = false;
            this.dgvOrderView.AutoGenerateContextFilters = true;
            this.dgvOrderView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrderView.ColumnHeadersHeight = 80;
            this.dgvOrderView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOrderView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.رقمالطلبيةDataGridViewTextBoxColumn,
            this.تاريخانشاءالطلبيةDataGridViewTextBoxColumn,
            this.رقمالانتاجDataGridViewTextBoxColumn,
            this.تاريخالانتاجDataGridViewTextBoxColumn,
            this.باركودالقطعةDataGridViewTextBoxColumn,
            this.عددالقطعDataGridViewTextBoxColumn,
            this.اسمالزبونDataGridViewTextBoxColumn,
            this.وصفالطلبيةDataGridViewTextBoxColumn,
            this.متابعالطلبيةDataGridViewTextBoxColumn,
            this.تاريختسليمالطلبيةDataGridViewTextBoxColumn,
            this.الموسمDataGridViewTextBoxColumn,
            this.الجنسDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.collectionDataGridViewTextBoxColumn,
            this.تفصيلDataGridViewTextBoxColumn,
            this.طباعة1DataGridViewTextBoxColumn,
            this.تطريزDataGridViewTextBoxColumn,
            this.خياطةDataGridViewTextBoxColumn,
            this.طباعة2DataGridViewTextBoxColumn,
            this.تصفيةDataGridViewTextBoxColumn,
            this.صورةالطلبيةDataGridViewTextBoxColumn});
            this.dgvOrderView.DataSource = this.selectOrderViewNewBindingSource1;
            this.dgvOrderView.DateWithTime = false;
            this.dgvOrderView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderView.Location = new System.Drawing.Point(0, 0);
            this.dgvOrderView.MultiSelect = false;
            this.dgvOrderView.Name = "dgvOrderView";
            this.dgvOrderView.ReadOnly = true;
            this.dgvOrderView.RowTemplate.Height = 50;
            this.dgvOrderView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderView.Size = new System.Drawing.Size(956, 593);
            this.dgvOrderView.TabIndex = 0;
            this.dgvOrderView.TimeFilter = false;
            this.dgvOrderView.SortStringChanged += new System.EventHandler(this.dgvOrderView_SortStringChanged);
            this.dgvOrderView.FilterStringChanged += new System.EventHandler(this.dgvOrderView_FilterStringChanged);
            this.dgvOrderView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderView_CellClick);
            this.dgvOrderView.Click += new System.EventHandler(this.dgvOrderView_Click);
            this.dgvOrderView.DoubleClick += new System.EventHandler(this.dgvOrderView_DoubleClick);
            this.dgvOrderView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvOrderView_KeyPress);
            this.dgvOrderView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvOrderView_MouseClick);
            // 
            // رقمالطلبيةDataGridViewTextBoxColumn
            // 
            this.رقمالطلبيةDataGridViewTextBoxColumn.DataPropertyName = "رقم الطلبية";
            this.رقمالطلبيةDataGridViewTextBoxColumn.HeaderText = "رقم الطلبية";
            this.رقمالطلبيةDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.رقمالطلبيةDataGridViewTextBoxColumn.Name = "رقمالطلبيةDataGridViewTextBoxColumn";
            this.رقمالطلبيةDataGridViewTextBoxColumn.ReadOnly = true;
            this.رقمالطلبيةDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.رقمالطلبيةDataGridViewTextBoxColumn.Width = 78;
            // 
            // تاريخانشاءالطلبيةDataGridViewTextBoxColumn
            // 
            this.تاريخانشاءالطلبيةDataGridViewTextBoxColumn.DataPropertyName = "تاريخ انشاء الطلبية";
            this.تاريخانشاءالطلبيةDataGridViewTextBoxColumn.HeaderText = "تاريخ انشاء الطلبية";
            this.تاريخانشاءالطلبيةDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.تاريخانشاءالطلبيةDataGridViewTextBoxColumn.Name = "تاريخانشاءالطلبيةDataGridViewTextBoxColumn";
            this.تاريخانشاءالطلبيةDataGridViewTextBoxColumn.ReadOnly = true;
            this.تاريخانشاءالطلبيةDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.تاريخانشاءالطلبيةDataGridViewTextBoxColumn.Width = 78;
            // 
            // رقمالانتاجDataGridViewTextBoxColumn
            // 
            this.رقمالانتاجDataGridViewTextBoxColumn.DataPropertyName = "رقم الانتاج";
            this.رقمالانتاجDataGridViewTextBoxColumn.HeaderText = "رقم الانتاج";
            this.رقمالانتاجDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.رقمالانتاجDataGridViewTextBoxColumn.Name = "رقمالانتاجDataGridViewTextBoxColumn";
            this.رقمالانتاجDataGridViewTextBoxColumn.ReadOnly = true;
            this.رقمالانتاجDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.رقمالانتاجDataGridViewTextBoxColumn.Width = 73;
            // 
            // تاريخالانتاجDataGridViewTextBoxColumn
            // 
            this.تاريخالانتاجDataGridViewTextBoxColumn.DataPropertyName = "تاريخ الانتاج";
            this.تاريخالانتاجDataGridViewTextBoxColumn.HeaderText = "تاريخ الانتاج";
            this.تاريخالانتاجDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.تاريخالانتاجDataGridViewTextBoxColumn.Name = "تاريخالانتاجDataGridViewTextBoxColumn";
            this.تاريخالانتاجDataGridViewTextBoxColumn.ReadOnly = true;
            this.تاريخالانتاجDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.تاريخالانتاجDataGridViewTextBoxColumn.Width = 77;
            // 
            // باركودالقطعةDataGridViewTextBoxColumn
            // 
            this.باركودالقطعةDataGridViewTextBoxColumn.DataPropertyName = "باركود القطعة";
            this.باركودالقطعةDataGridViewTextBoxColumn.HeaderText = "باركود القطعة";
            this.باركودالقطعةDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.باركودالقطعةDataGridViewTextBoxColumn.Name = "باركودالقطعةDataGridViewTextBoxColumn";
            this.باركودالقطعةDataGridViewTextBoxColumn.ReadOnly = true;
            this.باركودالقطعةDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.باركودالقطعةDataGridViewTextBoxColumn.Width = 85;
            // 
            // عددالقطعDataGridViewTextBoxColumn
            // 
            this.عددالقطعDataGridViewTextBoxColumn.DataPropertyName = "عدد القطع";
            this.عددالقطعDataGridViewTextBoxColumn.HeaderText = "عدد القطع";
            this.عددالقطعDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.عددالقطعDataGridViewTextBoxColumn.Name = "عددالقطعDataGridViewTextBoxColumn";
            this.عددالقطعDataGridViewTextBoxColumn.ReadOnly = true;
            this.عددالقطعDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.عددالقطعDataGridViewTextBoxColumn.Width = 73;
            // 
            // اسمالزبونDataGridViewTextBoxColumn
            // 
            this.اسمالزبونDataGridViewTextBoxColumn.DataPropertyName = "اسم الزبون";
            this.اسمالزبونDataGridViewTextBoxColumn.HeaderText = "اسم الزبون";
            this.اسمالزبونDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.اسمالزبونDataGridViewTextBoxColumn.Name = "اسمالزبونDataGridViewTextBoxColumn";
            this.اسمالزبونDataGridViewTextBoxColumn.ReadOnly = true;
            this.اسمالزبونDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.اسمالزبونDataGridViewTextBoxColumn.Width = 77;
            // 
            // وصفالطلبيةDataGridViewTextBoxColumn
            // 
            this.وصفالطلبيةDataGridViewTextBoxColumn.DataPropertyName = "وصف الطلبية";
            this.وصفالطلبيةDataGridViewTextBoxColumn.HeaderText = "وصف الطلبية";
            this.وصفالطلبيةDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.وصفالطلبيةDataGridViewTextBoxColumn.Name = "وصفالطلبيةDataGridViewTextBoxColumn";
            this.وصفالطلبيةDataGridViewTextBoxColumn.ReadOnly = true;
            this.وصفالطلبيةDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.وصفالطلبيةDataGridViewTextBoxColumn.Width = 84;
            // 
            // متابعالطلبيةDataGridViewTextBoxColumn
            // 
            this.متابعالطلبيةDataGridViewTextBoxColumn.DataPropertyName = "متابع الطلبية";
            this.متابعالطلبيةDataGridViewTextBoxColumn.HeaderText = "متابع الطلبية";
            this.متابعالطلبيةDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.متابعالطلبيةDataGridViewTextBoxColumn.Name = "متابعالطلبيةDataGridViewTextBoxColumn";
            this.متابعالطلبيةDataGridViewTextBoxColumn.ReadOnly = true;
            this.متابعالطلبيةDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.متابعالطلبيةDataGridViewTextBoxColumn.Width = 82;
            // 
            // تاريختسليمالطلبيةDataGridViewTextBoxColumn
            // 
            this.تاريختسليمالطلبيةDataGridViewTextBoxColumn.DataPropertyName = "تاريخ تسليم الطلبية";
            this.تاريختسليمالطلبيةDataGridViewTextBoxColumn.HeaderText = "تاريخ تسليم الطلبية";
            this.تاريختسليمالطلبيةDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.تاريختسليمالطلبيةDataGridViewTextBoxColumn.Name = "تاريختسليمالطلبيةDataGridViewTextBoxColumn";
            this.تاريختسليمالطلبيةDataGridViewTextBoxColumn.ReadOnly = true;
            this.تاريختسليمالطلبيةDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.تاريختسليمالطلبيةDataGridViewTextBoxColumn.Width = 83;
            // 
            // الموسمDataGridViewTextBoxColumn
            // 
            this.الموسمDataGridViewTextBoxColumn.DataPropertyName = "الموسم";
            this.الموسمDataGridViewTextBoxColumn.HeaderText = "الموسم";
            this.الموسمDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.الموسمDataGridViewTextBoxColumn.Name = "الموسمDataGridViewTextBoxColumn";
            this.الموسمDataGridViewTextBoxColumn.ReadOnly = true;
            this.الموسمDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.الموسمDataGridViewTextBoxColumn.Width = 69;
            // 
            // الجنسDataGridViewTextBoxColumn
            // 
            this.الجنسDataGridViewTextBoxColumn.DataPropertyName = "الجنس";
            this.الجنسDataGridViewTextBoxColumn.HeaderText = "الجنس";
            this.الجنسDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.الجنسDataGridViewTextBoxColumn.Name = "الجنسDataGridViewTextBoxColumn";
            this.الجنسDataGridViewTextBoxColumn.ReadOnly = true;
            this.الجنسDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.الجنسDataGridViewTextBoxColumn.Width = 63;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.categoryDataGridViewTextBoxColumn.Width = 77;
            // 
            // collectionDataGridViewTextBoxColumn
            // 
            this.collectionDataGridViewTextBoxColumn.DataPropertyName = "Collection";
            this.collectionDataGridViewTextBoxColumn.HeaderText = "Collection";
            this.collectionDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.collectionDataGridViewTextBoxColumn.Name = "collectionDataGridViewTextBoxColumn";
            this.collectionDataGridViewTextBoxColumn.ReadOnly = true;
            this.collectionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.collectionDataGridViewTextBoxColumn.Width = 78;
            // 
            // تفصيلDataGridViewTextBoxColumn
            // 
            this.تفصيلDataGridViewTextBoxColumn.DataPropertyName = "تفصيل";
            this.تفصيلDataGridViewTextBoxColumn.HeaderText = "تفصيل";
            this.تفصيلDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.تفصيلDataGridViewTextBoxColumn.Name = "تفصيلDataGridViewTextBoxColumn";
            this.تفصيلDataGridViewTextBoxColumn.ReadOnly = true;
            this.تفصيلDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.تفصيلDataGridViewTextBoxColumn.Width = 62;
            // 
            // طباعة1DataGridViewTextBoxColumn
            // 
            this.طباعة1DataGridViewTextBoxColumn.DataPropertyName = "طباعة - 1";
            this.طباعة1DataGridViewTextBoxColumn.HeaderText = "طباعة - 1";
            this.طباعة1DataGridViewTextBoxColumn.MinimumWidth = 22;
            this.طباعة1DataGridViewTextBoxColumn.Name = "طباعة1DataGridViewTextBoxColumn";
            this.طباعة1DataGridViewTextBoxColumn.ReadOnly = true;
            this.طباعة1DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.طباعة1DataGridViewTextBoxColumn.Width = 64;
            // 
            // تطريزDataGridViewTextBoxColumn
            // 
            this.تطريزDataGridViewTextBoxColumn.DataPropertyName = "تطريز";
            this.تطريزDataGridViewTextBoxColumn.HeaderText = "تطريز";
            this.تطريزDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.تطريزDataGridViewTextBoxColumn.Name = "تطريزDataGridViewTextBoxColumn";
            this.تطريزDataGridViewTextBoxColumn.ReadOnly = true;
            this.تطريزDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.تطريزDataGridViewTextBoxColumn.Width = 56;
            // 
            // خياطةDataGridViewTextBoxColumn
            // 
            this.خياطةDataGridViewTextBoxColumn.DataPropertyName = "خياطة";
            this.خياطةDataGridViewTextBoxColumn.HeaderText = "خياطة";
            this.خياطةDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.خياطةDataGridViewTextBoxColumn.Name = "خياطةDataGridViewTextBoxColumn";
            this.خياطةDataGridViewTextBoxColumn.ReadOnly = true;
            this.خياطةDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.خياطةDataGridViewTextBoxColumn.Width = 59;
            // 
            // طباعة2DataGridViewTextBoxColumn
            // 
            this.طباعة2DataGridViewTextBoxColumn.DataPropertyName = "طباعة - 2";
            this.طباعة2DataGridViewTextBoxColumn.HeaderText = "طباعة - 2";
            this.طباعة2DataGridViewTextBoxColumn.MinimumWidth = 22;
            this.طباعة2DataGridViewTextBoxColumn.Name = "طباعة2DataGridViewTextBoxColumn";
            this.طباعة2DataGridViewTextBoxColumn.ReadOnly = true;
            this.طباعة2DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.طباعة2DataGridViewTextBoxColumn.Width = 64;
            // 
            // تصفيةDataGridViewTextBoxColumn
            // 
            this.تصفيةDataGridViewTextBoxColumn.DataPropertyName = "تصفية";
            this.تصفيةDataGridViewTextBoxColumn.HeaderText = "تصفية";
            this.تصفيةDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.تصفيةDataGridViewTextBoxColumn.Name = "تصفيةDataGridViewTextBoxColumn";
            this.تصفيةDataGridViewTextBoxColumn.ReadOnly = true;
            this.تصفيةDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.تصفيةDataGridViewTextBoxColumn.Width = 60;
            // 
            // صورةالطلبيةDataGridViewTextBoxColumn
            // 
            this.صورةالطلبيةDataGridViewTextBoxColumn.DataPropertyName = "صورة الطلبية";
            this.صورةالطلبيةDataGridViewTextBoxColumn.HeaderText = "صورة الطلبية";
            this.صورةالطلبيةDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.صورةالطلبيةDataGridViewTextBoxColumn.Name = "صورةالطلبيةDataGridViewTextBoxColumn";
            this.صورةالطلبيةDataGridViewTextBoxColumn.ReadOnly = true;
            this.صورةالطلبيةDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.صورةالطلبيةDataGridViewTextBoxColumn.Width = 83;
            // 
            // selectOrderViewNewBindingSource
            // 
            this.selectOrderViewNewBindingSource.DataMember = "SelectOrderViewNew";
            this.selectOrderViewNewBindingSource.DataSource = this.pdc_Columbus_OrderDataSet2;
            this.selectOrderViewNewBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.selectOrderViewNewBindingSource_ListChanged_1);
            // 
            // pdc_Columbus_OrderDataSet2
            // 
            this.pdc_Columbus_OrderDataSet2.DataSetName = "pdc_Columbus_OrderDataSet2";
            this.pdc_Columbus_OrderDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // selectOrderViewNewBindingSource1
            // 
            this.selectOrderViewNewBindingSource1.DataMember = "SelectOrderViewNew";
            this.selectOrderViewNewBindingSource1.DataSource = this.odcNewColumbus_OrderDataSet2;
            this.selectOrderViewNewBindingSource1.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.selectOrderViewNewBindingSource1_ListChanged);
            // 
            // odcNewColumbus_OrderDataSet2
            // 
            this.odcNewColumbus_OrderDataSet2.DataSetName = "odcNewColumbus_OrderDataSet2";
            this.odcNewColumbus_OrderDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // selectOrderViewNewTableAdapter
            // 
            this.selectOrderViewNewTableAdapter.ClearBeforeFill = true;
            // 
            // selectOrderViewNewTableAdapter1
            // 
            this.selectOrderViewNewTableAdapter1.ClearBeforeFill = true;
            // 
            // Frm_ViewAllOrdersNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 593);
            this.Controls.Add(this.dgvOrderView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Frm_ViewAllOrdersNew";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "عرض الطلبيات";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_ViewAllOrdersNew_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectOrderViewNewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdc_Columbus_OrderDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectOrderViewNewBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odcNewColumbus_OrderDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ADGV.AdvancedDataGridView dgvOrderView;
        private pdc_Columbus_OrderDataSet2 pdc_Columbus_OrderDataSet2;
        private System.Windows.Forms.BindingSource selectOrderViewNewBindingSource;
        private pdc_Columbus_OrderDataSet2TableAdapters.SelectOrderViewNewTableAdapter selectOrderViewNewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn رقمالطلبيةDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn تاريخانشاءالطلبيةDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn رقمالانتاجDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn تاريخالانتاجDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn باركودالقطعةDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn عددالقطعDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn اسمالزبونDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn وصفالطلبيةDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn متابعالطلبيةDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn تاريختسليمالطلبيةDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn الموسمDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn الجنسDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn collectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn تفصيلDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn طباعة1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn تطريزDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn خياطةDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn طباعة2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn تصفيةDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn صورةالطلبيةDataGridViewTextBoxColumn;
        private odcNewColumbus_OrderDataSet2 odcNewColumbus_OrderDataSet2;
        private odcNewColumbus_OrderDataSet2TableAdapters.SelectOrderViewNewTableAdapter selectOrderViewNewTableAdapter1;
        public System.Windows.Forms.BindingSource selectOrderViewNewBindingSource1;
    }
}