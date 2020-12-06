namespace TareaDI01
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makeFlagDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.finishedGoodsFlagDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.safetyStockLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reorderPointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.standardCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeUnitMeasureCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightUnitMeasureCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daysToManufactureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productLineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.styleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productSubcategoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productModelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellStartDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellEndDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discontinuedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowguidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifiedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resultsPerPage = new System.Windows.Forms.ComboBox();
            this.resultsPerPageText = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboFilter = new System.Windows.Forms.ComboBox();
            this.comboSelectedFilter = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.productNumberDataGridViewTextBoxColumn,
            this.makeFlagDataGridViewCheckBoxColumn,
            this.finishedGoodsFlagDataGridViewCheckBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.safetyStockLevelDataGridViewTextBoxColumn,
            this.reorderPointDataGridViewTextBoxColumn,
            this.standardCostDataGridViewTextBoxColumn,
            this.listPriceDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.sizeUnitMeasureCodeDataGridViewTextBoxColumn,
            this.weightUnitMeasureCodeDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.daysToManufactureDataGridViewTextBoxColumn,
            this.productLineDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn,
            this.styleDataGridViewTextBoxColumn,
            this.productSubcategoryIDDataGridViewTextBoxColumn,
            this.productModelIDDataGridViewTextBoxColumn,
            this.sellStartDateDataGridViewTextBoxColumn,
            this.sellEndDateDataGridViewTextBoxColumn,
            this.discontinuedDateDataGridViewTextBoxColumn,
            this.rowguidDataGridViewTextBoxColumn,
            this.modifiedDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productBindingSource2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(12, 50);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1261, 820);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIDDataGridViewTextBoxColumn.Width = 60;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // productNumberDataGridViewTextBoxColumn
            // 
            this.productNumberDataGridViewTextBoxColumn.DataPropertyName = "ProductNumber";
            this.productNumberDataGridViewTextBoxColumn.HeaderText = "ProductNumber";
            this.productNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productNumberDataGridViewTextBoxColumn.Name = "productNumberDataGridViewTextBoxColumn";
            this.productNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.productNumberDataGridViewTextBoxColumn.Width = 85;
            // 
            // makeFlagDataGridViewCheckBoxColumn
            // 
            this.makeFlagDataGridViewCheckBoxColumn.DataPropertyName = "MakeFlag";
            this.makeFlagDataGridViewCheckBoxColumn.HeaderText = "MakeFlag";
            this.makeFlagDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.makeFlagDataGridViewCheckBoxColumn.Name = "makeFlagDataGridViewCheckBoxColumn";
            this.makeFlagDataGridViewCheckBoxColumn.ReadOnly = true;
            this.makeFlagDataGridViewCheckBoxColumn.Width = 60;
            // 
            // finishedGoodsFlagDataGridViewCheckBoxColumn
            // 
            this.finishedGoodsFlagDataGridViewCheckBoxColumn.DataPropertyName = "FinishedGoodsFlag";
            this.finishedGoodsFlagDataGridViewCheckBoxColumn.HeaderText = "FinishedGoodsFlag";
            this.finishedGoodsFlagDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.finishedGoodsFlagDataGridViewCheckBoxColumn.Name = "finishedGoodsFlagDataGridViewCheckBoxColumn";
            this.finishedGoodsFlagDataGridViewCheckBoxColumn.ReadOnly = true;
            this.finishedGoodsFlagDataGridViewCheckBoxColumn.Width = 60;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.ReadOnly = true;
            this.colorDataGridViewTextBoxColumn.Width = 60;
            // 
            // safetyStockLevelDataGridViewTextBoxColumn
            // 
            this.safetyStockLevelDataGridViewTextBoxColumn.DataPropertyName = "SafetyStockLevel";
            this.safetyStockLevelDataGridViewTextBoxColumn.HeaderText = "SafetyStockLevel";
            this.safetyStockLevelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.safetyStockLevelDataGridViewTextBoxColumn.Name = "safetyStockLevelDataGridViewTextBoxColumn";
            this.safetyStockLevelDataGridViewTextBoxColumn.ReadOnly = true;
            this.safetyStockLevelDataGridViewTextBoxColumn.Width = 95;
            // 
            // reorderPointDataGridViewTextBoxColumn
            // 
            this.reorderPointDataGridViewTextBoxColumn.DataPropertyName = "ReorderPoint";
            this.reorderPointDataGridViewTextBoxColumn.HeaderText = "ReorderPoint";
            this.reorderPointDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reorderPointDataGridViewTextBoxColumn.Name = "reorderPointDataGridViewTextBoxColumn";
            this.reorderPointDataGridViewTextBoxColumn.ReadOnly = true;
            this.reorderPointDataGridViewTextBoxColumn.Width = 90;
            // 
            // standardCostDataGridViewTextBoxColumn
            // 
            this.standardCostDataGridViewTextBoxColumn.DataPropertyName = "StandardCost";
            this.standardCostDataGridViewTextBoxColumn.HeaderText = "StandardCost";
            this.standardCostDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.standardCostDataGridViewTextBoxColumn.Name = "standardCostDataGridViewTextBoxColumn";
            this.standardCostDataGridViewTextBoxColumn.ReadOnly = true;
            this.standardCostDataGridViewTextBoxColumn.Width = 90;
            // 
            // listPriceDataGridViewTextBoxColumn
            // 
            this.listPriceDataGridViewTextBoxColumn.DataPropertyName = "ListPrice";
            this.listPriceDataGridViewTextBoxColumn.HeaderText = "ListPrice";
            this.listPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.listPriceDataGridViewTextBoxColumn.Name = "listPriceDataGridViewTextBoxColumn";
            this.listPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.listPriceDataGridViewTextBoxColumn.Width = 65;
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.sizeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            this.sizeDataGridViewTextBoxColumn.ReadOnly = true;
            this.sizeDataGridViewTextBoxColumn.Width = 45;
            // 
            // sizeUnitMeasureCodeDataGridViewTextBoxColumn
            // 
            this.sizeUnitMeasureCodeDataGridViewTextBoxColumn.DataPropertyName = "SizeUnitMeasureCode";
            this.sizeUnitMeasureCodeDataGridViewTextBoxColumn.HeaderText = "SizeUnitMeasureCode";
            this.sizeUnitMeasureCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sizeUnitMeasureCodeDataGridViewTextBoxColumn.Name = "sizeUnitMeasureCodeDataGridViewTextBoxColumn";
            this.sizeUnitMeasureCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.sizeUnitMeasureCodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // weightUnitMeasureCodeDataGridViewTextBoxColumn
            // 
            this.weightUnitMeasureCodeDataGridViewTextBoxColumn.DataPropertyName = "WeightUnitMeasureCode";
            this.weightUnitMeasureCodeDataGridViewTextBoxColumn.HeaderText = "WeightUnitMeasureCode";
            this.weightUnitMeasureCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.weightUnitMeasureCodeDataGridViewTextBoxColumn.Name = "weightUnitMeasureCodeDataGridViewTextBoxColumn";
            this.weightUnitMeasureCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.weightUnitMeasureCodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.weightDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.ReadOnly = true;
            this.weightDataGridViewTextBoxColumn.Width = 55;
            // 
            // daysToManufactureDataGridViewTextBoxColumn
            // 
            this.daysToManufactureDataGridViewTextBoxColumn.DataPropertyName = "DaysToManufacture";
            this.daysToManufactureDataGridViewTextBoxColumn.HeaderText = "DaysToManufacture";
            this.daysToManufactureDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.daysToManufactureDataGridViewTextBoxColumn.Name = "daysToManufactureDataGridViewTextBoxColumn";
            this.daysToManufactureDataGridViewTextBoxColumn.ReadOnly = true;
            this.daysToManufactureDataGridViewTextBoxColumn.Width = 105;
            // 
            // productLineDataGridViewTextBoxColumn
            // 
            this.productLineDataGridViewTextBoxColumn.DataPropertyName = "ProductLine";
            this.productLineDataGridViewTextBoxColumn.HeaderText = "ProductLine";
            this.productLineDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productLineDataGridViewTextBoxColumn.Name = "productLineDataGridViewTextBoxColumn";
            this.productLineDataGridViewTextBoxColumn.ReadOnly = true;
            this.productLineDataGridViewTextBoxColumn.Width = 80;
            // 
            // classDataGridViewTextBoxColumn
            // 
            this.classDataGridViewTextBoxColumn.DataPropertyName = "Class";
            this.classDataGridViewTextBoxColumn.HeaderText = "Class";
            this.classDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
            this.classDataGridViewTextBoxColumn.ReadOnly = true;
            this.classDataGridViewTextBoxColumn.Width = 45;
            // 
            // styleDataGridViewTextBoxColumn
            // 
            this.styleDataGridViewTextBoxColumn.DataPropertyName = "Style";
            this.styleDataGridViewTextBoxColumn.HeaderText = "Style";
            this.styleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.styleDataGridViewTextBoxColumn.Name = "styleDataGridViewTextBoxColumn";
            this.styleDataGridViewTextBoxColumn.ReadOnly = true;
            this.styleDataGridViewTextBoxColumn.Width = 45;
            // 
            // productSubcategoryIDDataGridViewTextBoxColumn
            // 
            this.productSubcategoryIDDataGridViewTextBoxColumn.DataPropertyName = "ProductSubcategoryID";
            this.productSubcategoryIDDataGridViewTextBoxColumn.HeaderText = "ProductSubcategoryID";
            this.productSubcategoryIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productSubcategoryIDDataGridViewTextBoxColumn.Name = "productSubcategoryIDDataGridViewTextBoxColumn";
            this.productSubcategoryIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.productSubcategoryIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // productModelIDDataGridViewTextBoxColumn
            // 
            this.productModelIDDataGridViewTextBoxColumn.DataPropertyName = "ProductModelID";
            this.productModelIDDataGridViewTextBoxColumn.HeaderText = "ProductModelID";
            this.productModelIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productModelIDDataGridViewTextBoxColumn.Name = "productModelIDDataGridViewTextBoxColumn";
            this.productModelIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.productModelIDDataGridViewTextBoxColumn.Width = 90;
            // 
            // sellStartDateDataGridViewTextBoxColumn
            // 
            this.sellStartDateDataGridViewTextBoxColumn.DataPropertyName = "SellStartDate";
            this.sellStartDateDataGridViewTextBoxColumn.HeaderText = "SellStartDate";
            this.sellStartDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sellStartDateDataGridViewTextBoxColumn.Name = "sellStartDateDataGridViewTextBoxColumn";
            this.sellStartDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.sellStartDateDataGridViewTextBoxColumn.Width = 80;
            // 
            // sellEndDateDataGridViewTextBoxColumn
            // 
            this.sellEndDateDataGridViewTextBoxColumn.DataPropertyName = "SellEndDate";
            this.sellEndDateDataGridViewTextBoxColumn.HeaderText = "SellEndDate";
            this.sellEndDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sellEndDateDataGridViewTextBoxColumn.Name = "sellEndDateDataGridViewTextBoxColumn";
            this.sellEndDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.sellEndDateDataGridViewTextBoxColumn.Width = 80;
            // 
            // discontinuedDateDataGridViewTextBoxColumn
            // 
            this.discontinuedDateDataGridViewTextBoxColumn.DataPropertyName = "DiscontinuedDate";
            this.discontinuedDateDataGridViewTextBoxColumn.HeaderText = "DiscontinuedDate";
            this.discontinuedDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.discontinuedDateDataGridViewTextBoxColumn.Name = "discontinuedDateDataGridViewTextBoxColumn";
            this.discontinuedDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.discontinuedDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // rowguidDataGridViewTextBoxColumn
            // 
            this.rowguidDataGridViewTextBoxColumn.DataPropertyName = "rowguid";
            this.rowguidDataGridViewTextBoxColumn.HeaderText = "rowguid";
            this.rowguidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rowguidDataGridViewTextBoxColumn.Name = "rowguidDataGridViewTextBoxColumn";
            this.rowguidDataGridViewTextBoxColumn.ReadOnly = true;
            this.rowguidDataGridViewTextBoxColumn.Width = 125;
            // 
            // modifiedDateDataGridViewTextBoxColumn
            // 
            this.modifiedDateDataGridViewTextBoxColumn.DataPropertyName = "ModifiedDate";
            this.modifiedDateDataGridViewTextBoxColumn.HeaderText = "ModifiedDate";
            this.modifiedDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modifiedDateDataGridViewTextBoxColumn.Name = "modifiedDateDataGridViewTextBoxColumn";
            this.modifiedDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.modifiedDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // productBindingSource2
            // 
            this.productBindingSource2.DataSource = typeof(TareaDI01.Product);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.Location = new System.Drawing.Point(69, 894);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(47, 22);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 894);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pagina";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 894);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "de";
            // 
            // resultsPerPage
            // 
            this.resultsPerPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resultsPerPage.FormattingEnabled = true;
            this.resultsPerPage.Items.AddRange(new object[] {
            "10",
            "20",
            "28",
            "50"});
            this.resultsPerPage.Location = new System.Drawing.Point(1071, 894);
            this.resultsPerPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resultsPerPage.Name = "resultsPerPage";
            this.resultsPerPage.Size = new System.Drawing.Size(55, 24);
            this.resultsPerPage.TabIndex = 4;
            this.resultsPerPage.SelectedIndexChanged += new System.EventHandler(this.resultsPerPage_SelectedIndexChanged);
            // 
            // resultsPerPageText
            // 
            this.resultsPerPageText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resultsPerPageText.AutoSize = true;
            this.resultsPerPageText.Location = new System.Drawing.Point(1131, 894);
            this.resultsPerPageText.Name = "resultsPerPageText";
            this.resultsPerPageText.Size = new System.Drawing.Size(134, 17);
            this.resultsPerPageText.TabIndex = 5;
            this.resultsPerPageText.Text = "resultats per pagina";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 12);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(340, 22);
            this.textBox1.TabIndex = 6;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cercar:";
            // 
            // comboFilter
            // 
            this.comboFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboFilter.FormattingEnabled = true;
            this.comboFilter.Location = new System.Drawing.Point(858, 11);
            this.comboFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboFilter.Name = "comboFilter";
            this.comboFilter.Size = new System.Drawing.Size(196, 24);
            this.comboFilter.TabIndex = 8;
            this.comboFilter.SelectedIndexChanged += new System.EventHandler(this.comboFilter_SelectedIndexChanged);
            // 
            // comboSelectedFilter
            // 
            this.comboSelectedFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboSelectedFilter.FormattingEnabled = true;
            this.comboSelectedFilter.Location = new System.Drawing.Point(1060, 11);
            this.comboSelectedFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboSelectedFilter.Name = "comboSelectedFilter";
            this.comboSelectedFilter.Size = new System.Drawing.Size(213, 24);
            this.comboSelectedFilter.TabIndex = 9;
            this.comboSelectedFilter.SelectedIndexChanged += new System.EventHandler(this.comboSelectedFilter_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(803, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Filtres:";
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataSource = typeof(TareaDI01.Product);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(TareaDI01.Product);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 937);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboSelectedFilter);
            this.Controls.Add(this.comboFilter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.resultsPerPageText);
            this.Controls.Add(this.resultsPerPage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(861, 481);
            this.Name = "Form1";
            this.Text = "Products";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn recorderPointDataGridViewTextBoxColumn;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox resultsPerPage;
        private System.Windows.Forms.Label resultsPerPageText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private System.Windows.Forms.BindingSource productBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn makeFlagDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn finishedGoodsFlagDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn safetyStockLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reorderPointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn standardCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn listPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeUnitMeasureCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightUnitMeasureCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn daysToManufactureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productLineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn styleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productSubcategoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productModelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellStartDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellEndDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discontinuedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowguidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifiedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboFilter;
        private System.Windows.Forms.ComboBox comboSelectedFilter;
        private System.Windows.Forms.Label label4;
    }
}

