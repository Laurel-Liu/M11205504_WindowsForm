namespace M11205504_WindowsForm
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.co2_Per_Capita_Europe_2018_DescBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.co2_Per_Capita_Europe_2018_DescBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eU_Co2_2018_DataSet = new M11205504_WindowsForm.EU_Co2_2018_DataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.co2_Per_Capita_Europe_2018_DescDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.populationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gDPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flaringCO2PercentageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subregionCO2Emissions2018DescBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sub_2018_DataSet = new M11205504_WindowsForm.Sub_2018_DataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.keywordToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.keywordToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.region_Subregion_CO2_Emissions_DescDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.region_Subregion_CO2_Emissions_DescBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.region_DataSet = new M11205504_WindowsForm.Region_DataSet();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.fillByToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.keywordToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.keywordToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.high_CO2_Emissions_From_Coal_DescDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.high_CO2_Emissions_From_Coal_DescBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yearly_DataSet = new M11205504_WindowsForm.Yearly_DataSet();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.co2_Per_Capita_Europe_2018_DescTableAdapter = new M11205504_WindowsForm.EU_Co2_2018_DataSetTableAdapters.Co2_Per_Capita_Europe_2018_DescTableAdapter();
            this.tableAdapterManager = new M11205504_WindowsForm.EU_Co2_2018_DataSetTableAdapters.TableAdapterManager();
            this.subregion_CO2_Emissions_2018_DescTableAdapter = new M11205504_WindowsForm.Sub_2018_DataSetTableAdapters.Subregion_CO2_Emissions_2018_DescTableAdapter();
            this.region_Subregion_CO2_Emissions_DescTableAdapter = new M11205504_WindowsForm.Region_DataSetTableAdapters.Region_Subregion_CO2_Emissions_DescTableAdapter();
            this.tableAdapterManager1 = new M11205504_WindowsForm.Region_DataSetTableAdapters.TableAdapterManager();
            this.high_CO2_Emissions_From_Coal_DescTableAdapter = new M11205504_WindowsForm.Yearly_DataSetTableAdapters.High_CO2_Emissions_From_Coal_DescTableAdapter();
            this.tableAdapterManager2 = new M11205504_WindowsForm.Yearly_DataSetTableAdapters.TableAdapterManager();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.eUCo22018DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.co2PerCapitaEurope2018DescBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.co2_Per_Capita_Europe_2018_DescBindingNavigator)).BeginInit();
            this.co2_Per_Capita_Europe_2018_DescBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.co2_Per_Capita_Europe_2018_DescBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eU_Co2_2018_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.co2_Per_Capita_Europe_2018_DescDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subregionCO2Emissions2018DescBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sub_2018_DataSet)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.region_Subregion_CO2_Emissions_DescDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.region_Subregion_CO2_Emissions_DescBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.region_DataSet)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.fillByToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.high_CO2_Emissions_From_Coal_DescDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.high_CO2_Emissions_From_Coal_DescBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearly_DataSet)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eUCo22018DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.co2PerCapitaEurope2018DescBindingSource)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(866, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.co2_Per_Capita_Europe_2018_DescBindingNavigator);
            this.tabPage1.Controls.Add(this.co2_Per_Capita_Europe_2018_DescDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(858, 413);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "EU_Co2_2018";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // co2_Per_Capita_Europe_2018_DescBindingNavigator
            // 
            this.co2_Per_Capita_Europe_2018_DescBindingNavigator.AddNewItem = null;
            this.co2_Per_Capita_Europe_2018_DescBindingNavigator.BindingSource = this.co2_Per_Capita_Europe_2018_DescBindingSource;
            this.co2_Per_Capita_Europe_2018_DescBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.co2_Per_Capita_Europe_2018_DescBindingNavigator.DeleteItem = null;
            this.co2_Per_Capita_Europe_2018_DescBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.co2_Per_Capita_Europe_2018_DescBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.co2_Per_Capita_Europe_2018_DescBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.co2_Per_Capita_Europe_2018_DescBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.co2_Per_Capita_Europe_2018_DescBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.co2_Per_Capita_Europe_2018_DescBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.co2_Per_Capita_Europe_2018_DescBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.co2_Per_Capita_Europe_2018_DescBindingNavigator.Name = "co2_Per_Capita_Europe_2018_DescBindingNavigator";
            this.co2_Per_Capita_Europe_2018_DescBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.co2_Per_Capita_Europe_2018_DescBindingNavigator.Size = new System.Drawing.Size(852, 27);
            this.co2_Per_Capita_Europe_2018_DescBindingNavigator.TabIndex = 1;
            this.co2_Per_Capita_Europe_2018_DescBindingNavigator.Text = "bindingNavigator1";
            // 
            // co2_Per_Capita_Europe_2018_DescBindingSource
            // 
            this.co2_Per_Capita_Europe_2018_DescBindingSource.DataMember = "Co2_Per_Capita_Europe_2018_Desc";
            this.co2_Per_Capita_Europe_2018_DescBindingSource.DataSource = this.eU_Co2_2018_DataSet;
            // 
            // eU_Co2_2018_DataSet
            // 
            this.eU_Co2_2018_DataSet.DataSetName = "EU_Co2_2018_DataSet";
            this.eU_Co2_2018_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(34, 24);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "目前的位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // co2_Per_Capita_Europe_2018_DescDataGridView
            // 
            this.co2_Per_Capita_Europe_2018_DescDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.co2_Per_Capita_Europe_2018_DescDataGridView.AutoGenerateColumns = false;
            this.co2_Per_Capita_Europe_2018_DescDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.co2_Per_Capita_Europe_2018_DescDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.co2_Per_Capita_Europe_2018_DescDataGridView.DataSource = this.co2_Per_Capita_Europe_2018_DescBindingSource;
            this.co2_Per_Capita_Europe_2018_DescDataGridView.Location = new System.Drawing.Point(3, 43);
            this.co2_Per_Capita_Europe_2018_DescDataGridView.Name = "co2_Per_Capita_Europe_2018_DescDataGridView";
            this.co2_Per_Capita_Europe_2018_DescDataGridView.RowHeadersWidth = 51;
            this.co2_Per_Capita_Europe_2018_DescDataGridView.RowTemplate.Height = 27;
            this.co2_Per_Capita_Europe_2018_DescDataGridView.Size = new System.Drawing.Size(644, 362);
            this.co2_Per_Capita_Europe_2018_DescDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Country";
            this.dataGridViewTextBoxColumn1.HeaderText = "Country";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CO2_per_capita";
            this.dataGridViewTextBoxColumn2.HeaderText = "CO2_per_capita";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 400;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(858, 413);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sub_2018";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Subregions";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.countryDataGridViewTextBoxColumn,
            this.populationDataGridViewTextBoxColumn,
            this.gDPDataGridViewTextBoxColumn,
            this.flaringCO2PercentageDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.subregionCO2Emissions2018DescBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(8, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(842, 324);
            this.dataGridView1.TabIndex = 1;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.Width = 125;
            // 
            // populationDataGridViewTextBoxColumn
            // 
            this.populationDataGridViewTextBoxColumn.DataPropertyName = "Population";
            this.populationDataGridViewTextBoxColumn.HeaderText = "Population";
            this.populationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.populationDataGridViewTextBoxColumn.Name = "populationDataGridViewTextBoxColumn";
            this.populationDataGridViewTextBoxColumn.Width = 125;
            // 
            // gDPDataGridViewTextBoxColumn
            // 
            this.gDPDataGridViewTextBoxColumn.DataPropertyName = "GDP";
            this.gDPDataGridViewTextBoxColumn.HeaderText = "GDP";
            this.gDPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gDPDataGridViewTextBoxColumn.Name = "gDPDataGridViewTextBoxColumn";
            this.gDPDataGridViewTextBoxColumn.Width = 125;
            // 
            // flaringCO2PercentageDataGridViewTextBoxColumn
            // 
            this.flaringCO2PercentageDataGridViewTextBoxColumn.DataPropertyName = "Flaring_CO2_Percentage";
            this.flaringCO2PercentageDataGridViewTextBoxColumn.HeaderText = "Flaring_CO2_Percentage";
            this.flaringCO2PercentageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.flaringCO2PercentageDataGridViewTextBoxColumn.Name = "flaringCO2PercentageDataGridViewTextBoxColumn";
            this.flaringCO2PercentageDataGridViewTextBoxColumn.Width = 300;
            // 
            // subregionCO2Emissions2018DescBindingSource
            // 
            this.subregionCO2Emissions2018DescBindingSource.DataMember = "Subregion_CO2_Emissions_2018_Desc";
            this.subregionCO2Emissions2018DescBindingSource.DataSource = this.sub_2018_DataSet;
            // 
            // sub_2018_DataSet
            // 
            this.sub_2018_DataSet.DataSetName = "Sub_2018_DataSet";
            this.sub_2018_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.subregionCO2Emissions2018DescBindingSource;
            this.comboBox1.DisplayMember = "Country";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(211, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(270, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "Country";
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.fillByToolStrip);
            this.tabPage3.Controls.Add(this.region_Subregion_CO2_Emissions_DescDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(858, 413);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Region_2010/15/20";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keywordToolStripLabel,
            this.keywordToolStripTextBox,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(54, 31);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(244, 27);
            this.fillByToolStrip.TabIndex = 1;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // keywordToolStripLabel
            // 
            this.keywordToolStripLabel.Name = "keywordToolStripLabel";
            this.keywordToolStripLabel.Size = new System.Drawing.Size(69, 24);
            this.keywordToolStripLabel.Text = "Regions:";
            // 
            // keywordToolStripTextBox
            // 
            this.keywordToolStripTextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.keywordToolStripTextBox.Name = "keywordToolStripTextBox";
            this.keywordToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(60, 24);
            this.fillByToolStripButton.Text = "Search";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // region_Subregion_CO2_Emissions_DescDataGridView
            // 
            this.region_Subregion_CO2_Emissions_DescDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.region_Subregion_CO2_Emissions_DescDataGridView.AutoGenerateColumns = false;
            this.region_Subregion_CO2_Emissions_DescDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.region_Subregion_CO2_Emissions_DescDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.region_Subregion_CO2_Emissions_DescDataGridView.DataSource = this.region_Subregion_CO2_Emissions_DescBindingSource;
            this.region_Subregion_CO2_Emissions_DescDataGridView.Location = new System.Drawing.Point(8, 95);
            this.region_Subregion_CO2_Emissions_DescDataGridView.Name = "region_Subregion_CO2_Emissions_DescDataGridView";
            this.region_Subregion_CO2_Emissions_DescDataGridView.RowHeadersWidth = 51;
            this.region_Subregion_CO2_Emissions_DescDataGridView.RowTemplate.Height = 27;
            this.region_Subregion_CO2_Emissions_DescDataGridView.Size = new System.Drawing.Size(847, 315);
            this.region_Subregion_CO2_Emissions_DescDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Region";
            this.dataGridViewTextBoxColumn3.HeaderText = "Region";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Subregion";
            this.dataGridViewTextBoxColumn4.HeaderText = "Subregion";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 300;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Year";
            this.dataGridViewTextBoxColumn5.HeaderText = "Year";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Total_Cement_CO2_Emissions";
            this.dataGridViewTextBoxColumn6.HeaderText = "Total_Cement_CO2_Emissions";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 400;
            // 
            // region_Subregion_CO2_Emissions_DescBindingSource
            // 
            this.region_Subregion_CO2_Emissions_DescBindingSource.DataMember = "Region_Subregion_CO2_Emissions_Desc";
            this.region_Subregion_CO2_Emissions_DescBindingSource.DataSource = this.region_DataSet;
            // 
            // region_DataSet
            // 
            this.region_DataSet.DataSetName = "Region_DataSet";
            this.region_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.fillByToolStrip1);
            this.tabPage4.Controls.Add(this.high_CO2_Emissions_From_Coal_DescDataGridView);
            this.tabPage4.ForeColor = System.Drawing.Color.Black;
            this.tabPage4.Location = new System.Drawing.Point(4, 33);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(858, 413);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Yearly_Co2";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // fillByToolStrip1
            // 
            this.fillByToolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByToolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keywordToolStripLabel1,
            this.keywordToolStripTextBox1,
            this.fillByToolStripButton1});
            this.fillByToolStrip1.Location = new System.Drawing.Point(3, 35);
            this.fillByToolStrip1.Name = "fillByToolStrip1";
            this.fillByToolStrip1.Size = new System.Drawing.Size(218, 27);
            this.fillByToolStrip1.TabIndex = 1;
            this.fillByToolStrip1.Text = "fillByToolStrip1";
            // 
            // keywordToolStripLabel1
            // 
            this.keywordToolStripLabel1.Name = "keywordToolStripLabel1";
            this.keywordToolStripLabel1.Size = new System.Drawing.Size(43, 24);
            this.keywordToolStripLabel1.Text = "Year:";
            // 
            // keywordToolStripTextBox1
            // 
            this.keywordToolStripTextBox1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.keywordToolStripTextBox1.Name = "keywordToolStripTextBox1";
            this.keywordToolStripTextBox1.Size = new System.Drawing.Size(100, 27);
            // 
            // fillByToolStripButton1
            // 
            this.fillByToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton1.Name = "fillByToolStripButton1";
            this.fillByToolStripButton1.Size = new System.Drawing.Size(60, 24);
            this.fillByToolStripButton1.Text = "Search";
            this.fillByToolStripButton1.Click += new System.EventHandler(this.fillByToolStripButton1_Click);
            // 
            // high_CO2_Emissions_From_Coal_DescDataGridView
            // 
            this.high_CO2_Emissions_From_Coal_DescDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.high_CO2_Emissions_From_Coal_DescDataGridView.AutoGenerateColumns = false;
            this.high_CO2_Emissions_From_Coal_DescDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.high_CO2_Emissions_From_Coal_DescDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.high_CO2_Emissions_From_Coal_DescDataGridView.DataSource = this.high_CO2_Emissions_From_Coal_DescBindingSource;
            this.high_CO2_Emissions_From_Coal_DescDataGridView.Location = new System.Drawing.Point(3, 109);
            this.high_CO2_Emissions_From_Coal_DescDataGridView.Name = "high_CO2_Emissions_From_Coal_DescDataGridView";
            this.high_CO2_Emissions_From_Coal_DescDataGridView.RowHeadersWidth = 51;
            this.high_CO2_Emissions_From_Coal_DescDataGridView.RowTemplate.Height = 27;
            this.high_CO2_Emissions_From_Coal_DescDataGridView.Size = new System.Drawing.Size(859, 298);
            this.high_CO2_Emissions_From_Coal_DescDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Year";
            this.dataGridViewTextBoxColumn7.HeaderText = "Year";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Country";
            this.dataGridViewTextBoxColumn8.HeaderText = "Country";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Subregion";
            this.dataGridViewTextBoxColumn9.HeaderText = "Subregion";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 400;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "CO2_Emissions_From_Coal";
            this.dataGridViewTextBoxColumn10.HeaderText = "CO2_Emissions_From_Coal";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 400;
            // 
            // high_CO2_Emissions_From_Coal_DescBindingSource
            // 
            this.high_CO2_Emissions_From_Coal_DescBindingSource.DataMember = "High_CO2_Emissions_From_Coal_Desc";
            this.high_CO2_Emissions_From_Coal_DescBindingSource.DataSource = this.yearly_DataSet;
            // 
            // yearly_DataSet
            // 
            this.yearly_DataSet.DataSetName = "Yearly_DataSet";
            this.yearly_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.reportViewer1);
            this.tabPage5.Location = new System.Drawing.Point(4, 33);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(858, 413);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Report_EU";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // co2_Per_Capita_Europe_2018_DescTableAdapter
            // 
            this.co2_Per_Capita_Europe_2018_DescTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Co2_Per_Capita_Europe_2018_DescTableAdapter = this.co2_Per_Capita_Europe_2018_DescTableAdapter;
            this.tableAdapterManager.UpdateOrder = M11205504_WindowsForm.EU_Co2_2018_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // subregion_CO2_Emissions_2018_DescTableAdapter
            // 
            this.subregion_CO2_Emissions_2018_DescTableAdapter.ClearBeforeFill = true;
            // 
            // region_Subregion_CO2_Emissions_DescTableAdapter
            // 
            this.region_Subregion_CO2_Emissions_DescTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Region_Subregion_CO2_Emissions_DescTableAdapter = this.region_Subregion_CO2_Emissions_DescTableAdapter;
            this.tableAdapterManager1.UpdateOrder = M11205504_WindowsForm.Region_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // high_CO2_Emissions_From_Coal_DescTableAdapter
            // 
            this.high_CO2_Emissions_From_Coal_DescTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.High_CO2_Emissions_From_Coal_DescTableAdapter = this.high_CO2_Emissions_From_Coal_DescTableAdapter;
            this.tableAdapterManager2.UpdateOrder = M11205504_WindowsForm.Yearly_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "EU_Co2_2018";
            reportDataSource1.Value = this.co2PerCapitaEurope2018DescBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "M11205504_WindowsForm.Report_EU_Co2_2018.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(852, 407);
            this.reportViewer1.TabIndex = 0;
            // 
            // eUCo22018DataSetBindingSource
            // 
            this.eUCo22018DataSetBindingSource.DataSource = this.eU_Co2_2018_DataSet;
            this.eUCo22018DataSetBindingSource.Position = 0;
            // 
            // co2PerCapitaEurope2018DescBindingSource
            // 
            this.co2PerCapitaEurope2018DescBindingSource.DataMember = "Co2_Per_Capita_Europe_2018_Desc";
            this.co2PerCapitaEurope2018DescBindingSource.DataSource = this.eUCo22018DataSetBindingSource;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.reportViewer2);
            this.tabPage6.Location = new System.Drawing.Point(4, 33);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(858, 413);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Report_Yearly";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "Yearly_Co2";
            reportDataSource2.Value = this.high_CO2_Emissions_From_Coal_DescBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "M11205504_WindowsForm.Report_Yearly_Co2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(3, 3);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(852, 407);
            this.reportViewer2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.co2_Per_Capita_Europe_2018_DescBindingNavigator)).EndInit();
            this.co2_Per_Capita_Europe_2018_DescBindingNavigator.ResumeLayout(false);
            this.co2_Per_Capita_Europe_2018_DescBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.co2_Per_Capita_Europe_2018_DescBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eU_Co2_2018_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.co2_Per_Capita_Europe_2018_DescDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subregionCO2Emissions2018DescBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sub_2018_DataSet)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.region_Subregion_CO2_Emissions_DescDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.region_Subregion_CO2_Emissions_DescBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.region_DataSet)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.fillByToolStrip1.ResumeLayout(false);
            this.fillByToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.high_CO2_Emissions_From_Coal_DescDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.high_CO2_Emissions_From_Coal_DescBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearly_DataSet)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eUCo22018DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.co2PerCapitaEurope2018DescBindingSource)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private EU_Co2_2018_DataSet eU_Co2_2018_DataSet;
        private System.Windows.Forms.BindingSource co2_Per_Capita_Europe_2018_DescBindingSource;
        private EU_Co2_2018_DataSetTableAdapters.Co2_Per_Capita_Europe_2018_DescTableAdapter co2_Per_Capita_Europe_2018_DescTableAdapter;
        private EU_Co2_2018_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator co2_Per_Capita_Europe_2018_DescBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView co2_Per_Capita_Europe_2018_DescDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private Sub_2018_DataSet sub_2018_DataSet;
        private System.Windows.Forms.BindingSource subregionCO2Emissions2018DescBindingSource;
        private Sub_2018_DataSetTableAdapters.Subregion_CO2_Emissions_2018_DescTableAdapter subregion_CO2_Emissions_2018_DescTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn populationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gDPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flaringCO2PercentageDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private Region_DataSet region_DataSet;
        private System.Windows.Forms.BindingSource region_Subregion_CO2_Emissions_DescBindingSource;
        private Region_DataSetTableAdapters.Region_Subregion_CO2_Emissions_DescTableAdapter region_Subregion_CO2_Emissions_DescTableAdapter;
        private Region_DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView region_Subregion_CO2_Emissions_DescDataGridView;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel keywordToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox keywordToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private Yearly_DataSet yearly_DataSet;
        private System.Windows.Forms.BindingSource high_CO2_Emissions_From_Coal_DescBindingSource;
        private Yearly_DataSetTableAdapters.High_CO2_Emissions_From_Coal_DescTableAdapter high_CO2_Emissions_From_Coal_DescTableAdapter;
        private Yearly_DataSetTableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.DataGridView high_CO2_Emissions_From_Coal_DescDataGridView;
        private System.Windows.Forms.ToolStrip fillByToolStrip1;
        private System.Windows.Forms.ToolStripLabel keywordToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox keywordToolStripTextBox1;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.TabPage tabPage5;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource co2PerCapitaEurope2018DescBindingSource;
        private System.Windows.Forms.BindingSource eUCo22018DataSetBindingSource;
        private System.Windows.Forms.TabPage tabPage6;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
    }
}

