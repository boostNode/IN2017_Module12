namespace ExampleDB
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.Label languageIDLabel;
            System.Windows.Forms.Label languageNameLabel;
            System.Windows.Forms.Label languageDescriptionLabel;
            System.Windows.Forms.Label languageStronglyTypedLabel;
            System.Windows.Forms.Label lblPROS;
            System.Windows.Forms.Label lblCONS;
            this.dataSet_Languages = new ExampleDB.DataSet_Languages();
            this.tblLanguageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblLanguageTableAdapter = new ExampleDB.DataSet_LanguagesTableAdapters.tblLanguageTableAdapter();
            this.tableAdapterManager = new ExampleDB.DataSet_LanguagesTableAdapters.TableAdapterManager();
            this.tblLanguageBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tblLanguageBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.languageIDTextBox = new System.Windows.Forms.TextBox();
            this.languageNameTextBox = new System.Windows.Forms.TextBox();
            this.languageDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.languageStronglyTypedCheckBox = new System.Windows.Forms.CheckBox();
            this.tblLanguageCONSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblLanguageCONSTableAdapter = new ExampleDB.DataSet_LanguagesTableAdapters.tblLanguageCONSTableAdapter();
            this.tblLanguagePROSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblLanguagePROSTableAdapter = new ExampleDB.DataSet_LanguagesTableAdapters.tblLanguagePROSTableAdapter();
            this.tblLanguagePROSDataGridView = new System.Windows.Forms.DataGridView();
            this.tblLanguageCONSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblLanguageCONSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            languageIDLabel = new System.Windows.Forms.Label();
            languageNameLabel = new System.Windows.Forms.Label();
            languageDescriptionLabel = new System.Windows.Forms.Label();
            languageStronglyTypedLabel = new System.Windows.Forms.Label();
            lblPROS = new System.Windows.Forms.Label();
            lblCONS = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Languages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLanguageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLanguageBindingNavigator)).BeginInit();
            this.tblLanguageBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblLanguageCONSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLanguagePROSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLanguagePROSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLanguageCONSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLanguageCONSDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet_Languages
            // 
            this.dataSet_Languages.DataSetName = "DataSet_Languages";
            this.dataSet_Languages.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblLanguageBindingSource
            // 
            this.tblLanguageBindingSource.DataMember = "tblLanguage";
            this.tblLanguageBindingSource.DataSource = this.dataSet_Languages;
            // 
            // tblLanguageTableAdapter
            // 
            this.tblLanguageTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblLanguageCONSTableAdapter = this.tblLanguageCONSTableAdapter;
            this.tableAdapterManager.tblLanguagePROSTableAdapter = this.tblLanguagePROSTableAdapter;
            this.tableAdapterManager.tblLanguageTableAdapter = this.tblLanguageTableAdapter;
            this.tableAdapterManager.UpdateOrder = ExampleDB.DataSet_LanguagesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblLanguageBindingNavigator
            // 
            this.tblLanguageBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblLanguageBindingNavigator.BindingSource = this.tblLanguageBindingSource;
            this.tblLanguageBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblLanguageBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblLanguageBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tblLanguageBindingNavigatorSaveItem});
            this.tblLanguageBindingNavigator.Location = new System.Drawing.Point(5, 5);
            this.tblLanguageBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblLanguageBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblLanguageBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblLanguageBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblLanguageBindingNavigator.Name = "tblLanguageBindingNavigator";
            this.tblLanguageBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblLanguageBindingNavigator.Size = new System.Drawing.Size(874, 25);
            this.tblLanguageBindingNavigator.TabIndex = 0;
            this.tblLanguageBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // tblLanguageBindingNavigatorSaveItem
            // 
            this.tblLanguageBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblLanguageBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblLanguageBindingNavigatorSaveItem.Image")));
            this.tblLanguageBindingNavigatorSaveItem.Name = "tblLanguageBindingNavigatorSaveItem";
            this.tblLanguageBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tblLanguageBindingNavigatorSaveItem.Text = "Save Data";
            this.tblLanguageBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblLanguageBindingNavigatorSaveItem_Click_1);
            // 
            // languageIDLabel
            // 
            languageIDLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            languageIDLabel.Location = new System.Drawing.Point(10, 35);
            languageIDLabel.Margin = new System.Windows.Forms.Padding(5);
            languageIDLabel.Name = "languageIDLabel";
            languageIDLabel.Size = new System.Drawing.Size(125, 18);
            languageIDLabel.TabIndex = 1;
            languageIDLabel.Text = "ID:";
            // 
            // languageIDTextBox
            // 
            this.languageIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblLanguageBindingSource, "LanguageID", true));
            this.languageIDTextBox.Location = new System.Drawing.Point(145, 34);
            this.languageIDTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.languageIDTextBox.MaxLength = 6;
            this.languageIDTextBox.Name = "languageIDTextBox";
            this.languageIDTextBox.ReadOnly = true;
            this.languageIDTextBox.Size = new System.Drawing.Size(50, 20);
            this.languageIDTextBox.TabIndex = 2;
            // 
            // languageNameLabel
            // 
            languageNameLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            languageNameLabel.Location = new System.Drawing.Point(10, 63);
            languageNameLabel.Margin = new System.Windows.Forms.Padding(5);
            languageNameLabel.Name = "languageNameLabel";
            languageNameLabel.Size = new System.Drawing.Size(125, 18);
            languageNameLabel.TabIndex = 3;
            languageNameLabel.Text = "Name:";
            // 
            // languageNameTextBox
            // 
            this.languageNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblLanguageBindingSource, "LanguageName", true));
            this.languageNameTextBox.Location = new System.Drawing.Point(145, 61);
            this.languageNameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.languageNameTextBox.MaxLength = 25;
            this.languageNameTextBox.Name = "languageNameTextBox";
            this.languageNameTextBox.Size = new System.Drawing.Size(120, 20);
            this.languageNameTextBox.TabIndex = 4;
            // 
            // languageDescriptionLabel
            // 
            languageDescriptionLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            languageDescriptionLabel.Location = new System.Drawing.Point(313, 34);
            languageDescriptionLabel.Margin = new System.Windows.Forms.Padding(5);
            languageDescriptionLabel.Name = "languageDescriptionLabel";
            languageDescriptionLabel.Size = new System.Drawing.Size(125, 18);
            languageDescriptionLabel.TabIndex = 5;
            languageDescriptionLabel.Text = "Description:";
            // 
            // languageDescriptionTextBox
            // 
            this.languageDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblLanguageBindingSource, "LanguageDescription", true));
            this.languageDescriptionTextBox.Location = new System.Drawing.Point(448, 34);
            this.languageDescriptionTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.languageDescriptionTextBox.Multiline = true;
            this.languageDescriptionTextBox.Name = "languageDescriptionTextBox";
            this.languageDescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.languageDescriptionTextBox.Size = new System.Drawing.Size(420, 100);
            this.languageDescriptionTextBox.TabIndex = 6;
            // 
            // languageStronglyTypedLabel
            // 
            languageStronglyTypedLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            languageStronglyTypedLabel.Location = new System.Drawing.Point(10, 91);
            languageStronglyTypedLabel.Margin = new System.Windows.Forms.Padding(5);
            languageStronglyTypedLabel.Name = "languageStronglyTypedLabel";
            languageStronglyTypedLabel.Size = new System.Drawing.Size(125, 18);
            languageStronglyTypedLabel.TabIndex = 7;
            languageStronglyTypedLabel.Text = "Strongly Typed:";
            // 
            // languageStronglyTypedCheckBox
            // 
            this.languageStronglyTypedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tblLanguageBindingSource, "LanguageStronglyTyped", true));
            this.languageStronglyTypedCheckBox.Location = new System.Drawing.Point(145, 88);
            this.languageStronglyTypedCheckBox.Name = "languageStronglyTypedCheckBox";
            this.languageStronglyTypedCheckBox.Size = new System.Drawing.Size(20, 24);
            this.languageStronglyTypedCheckBox.TabIndex = 8;
            this.languageStronglyTypedCheckBox.UseVisualStyleBackColor = true;
            this.languageStronglyTypedCheckBox.CheckedChanged += new System.EventHandler(this.languageStronglyTypedCheckBox_CheckedChanged);
            // 
            // tblLanguageCONSBindingSource
            // 
            this.tblLanguageCONSBindingSource.DataMember = "tblLanguageCONS";
            this.tblLanguageCONSBindingSource.DataSource = this.dataSet_Languages;
            // 
            // tblLanguageCONSTableAdapter
            // 
            this.tblLanguageCONSTableAdapter.ClearBeforeFill = true;
            // 
            // tblLanguagePROSBindingSource
            // 
            this.tblLanguagePROSBindingSource.DataMember = "FK_tblLanguagePROS_tblLanguage";
            this.tblLanguagePROSBindingSource.DataSource = this.tblLanguageBindingSource;
            // 
            // tblLanguagePROSTableAdapter
            // 
            this.tblLanguagePROSTableAdapter.ClearBeforeFill = true;
            // 
            // tblLanguagePROSDataGridView
            // 
            this.tblLanguagePROSDataGridView.AutoGenerateColumns = false;
            this.tblLanguagePROSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblLanguagePROSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3});
            this.tblLanguagePROSDataGridView.DataSource = this.tblLanguagePROSBindingSource;
            this.tblLanguagePROSDataGridView.Location = new System.Drawing.Point(8, 178);
            this.tblLanguagePROSDataGridView.Margin = new System.Windows.Forms.Padding(5);
            this.tblLanguagePROSDataGridView.Name = "tblLanguagePROSDataGridView";
            this.tblLanguagePROSDataGridView.Size = new System.Drawing.Size(420, 200);
            this.tblLanguagePROSDataGridView.TabIndex = 9;
            this.tblLanguagePROSDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblLanguagePROSDataGridView_CellContentClick);
            // 
            // tblLanguageCONSBindingSource1
            // 
            this.tblLanguageCONSBindingSource1.DataMember = "FK_tblLanguageCONS_tblLanguage";
            this.tblLanguageCONSBindingSource1.DataSource = this.tblLanguageBindingSource;
            // 
            // tblLanguageCONSDataGridView
            // 
            this.tblLanguageCONSDataGridView.AutoGenerateColumns = false;
            this.tblLanguageCONSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblLanguageCONSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6});
            this.tblLanguageCONSDataGridView.DataSource = this.tblLanguageCONSBindingSource1;
            this.tblLanguageCONSDataGridView.Location = new System.Drawing.Point(448, 178);
            this.tblLanguageCONSDataGridView.Name = "tblLanguageCONSDataGridView";
            this.tblLanguageCONSDataGridView.Size = new System.Drawing.Size(420, 200);
            this.tblLanguageCONSDataGridView.TabIndex = 10;
            // 
            // lblPROS
            // 
            lblPROS.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPROS.Location = new System.Drawing.Point(10, 152);
            lblPROS.Margin = new System.Windows.Forms.Padding(5);
            lblPROS.Name = "lblPROS";
            lblPROS.Size = new System.Drawing.Size(125, 18);
            lblPROS.TabIndex = 11;
            lblPROS.Text = "Language PROS:";
            // 
            // lblCONS
            // 
            lblCONS.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblCONS.Location = new System.Drawing.Point(445, 152);
            lblCONS.Margin = new System.Windows.Forms.Padding(5);
            lblCONS.Name = "lblCONS";
            lblCONS.Size = new System.Drawing.Size(125, 18);
            lblCONS.TabIndex = 12;
            lblCONS.Text = "Language CONS:";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ProDescription";
            this.dataGridViewTextBoxColumn3.HeaderText = "ProDescription";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 360;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ConDescription";
            this.dataGridViewTextBoxColumn6.HeaderText = "ConDescription";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 360;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 392);
            this.Controls.Add(lblCONS);
            this.Controls.Add(lblPROS);
            this.Controls.Add(this.tblLanguageCONSDataGridView);
            this.Controls.Add(this.tblLanguagePROSDataGridView);
            this.Controls.Add(languageIDLabel);
            this.Controls.Add(this.languageIDTextBox);
            this.Controls.Add(languageNameLabel);
            this.Controls.Add(this.languageNameTextBox);
            this.Controls.Add(languageDescriptionLabel);
            this.Controls.Add(this.languageDescriptionTextBox);
            this.Controls.Add(languageStronglyTypedLabel);
            this.Controls.Add(this.languageStronglyTypedCheckBox);
            this.Controls.Add(this.tblLanguageBindingNavigator);
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Programming Languages - Example Database App";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Languages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLanguageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLanguageBindingNavigator)).EndInit();
            this.tblLanguageBindingNavigator.ResumeLayout(false);
            this.tblLanguageBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblLanguageCONSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLanguagePROSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLanguagePROSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLanguageCONSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLanguageCONSDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet_Languages dataSet_Languages;
        private System.Windows.Forms.BindingSource tblLanguageBindingSource;
        private DataSet_LanguagesTableAdapters.tblLanguageTableAdapter tblLanguageTableAdapter;
        private DataSet_LanguagesTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblLanguageBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tblLanguageBindingNavigatorSaveItem;
        private DataSet_LanguagesTableAdapters.tblLanguageCONSTableAdapter tblLanguageCONSTableAdapter;
        private System.Windows.Forms.TextBox languageIDTextBox;
        private System.Windows.Forms.TextBox languageNameTextBox;
        private System.Windows.Forms.TextBox languageDescriptionTextBox;
        private System.Windows.Forms.CheckBox languageStronglyTypedCheckBox;
        private System.Windows.Forms.BindingSource tblLanguageCONSBindingSource;
        private DataSet_LanguagesTableAdapters.tblLanguagePROSTableAdapter tblLanguagePROSTableAdapter;
        private System.Windows.Forms.BindingSource tblLanguagePROSBindingSource;
        private System.Windows.Forms.DataGridView tblLanguagePROSDataGridView;
        private System.Windows.Forms.BindingSource tblLanguageCONSBindingSource1;
        private System.Windows.Forms.DataGridView tblLanguageCONSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}

