﻿namespace Game_Database_Viewer
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerOnServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerClassSkillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsCatalogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemRarityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemHandedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingNavigatorMain = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.itemscatalogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameDBDataSet = new Game_Database_Viewer.gameDBDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelSearch_Field = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxSearch_Field = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.dataGridView_DB = new System.Windows.Forms.DataGridView();
            this.rarityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemtypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.handeditemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView_SQL = new System.Windows.Forms.DataGridView();
            this.textBox_SQL = new System.Windows.Forms.TextBox();
            this.button_SQL = new System.Windows.Forms.Button();
            this.rarityIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.itemTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.handedItemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.items_catalogTableAdapter = new Game_Database_Viewer.gameDBDataSetTableAdapters.items_catalogTableAdapter();
            this.rarityTableAdapter = new Game_Database_Viewer.gameDBDataSetTableAdapters.rarityTableAdapter();
            this.item_typeTableAdapter = new Game_Database_Viewer.gameDBDataSetTableAdapters.item_typeTableAdapter();
            this.handed_itemTableAdapter = new Game_Database_Viewer.gameDBDataSetTableAdapters.handed_itemTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generalinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.general_infoTableAdapter = new Game_Database_Viewer.gameDBDataSetTableAdapters.general_infoTableAdapter();
            this.uIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skillNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorMain)).BeginInit();
            this.bindingNavigatorMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemscatalogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rarityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemtypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.handeditemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SQL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalinfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.BackColor = System.Drawing.Color.CadetBlue;
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.tablesToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(800, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.toolStripMenuItem2,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::Game_Database_Viewer.Properties.Resources.About;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(104, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Image = global::Game_Database_Viewer.Properties.Resources.Quit;
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // tablesToolStripMenuItem
            // 
            this.tablesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerOnServerToolStripMenuItem,
            this.playerClassSkillToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.itemsCatalogToolStripMenuItem,
            this.itemRarityToolStripMenuItem,
            this.itemTypeToolStripMenuItem,
            this.itemHandedToolStripMenuItem});
            this.tablesToolStripMenuItem.Name = "tablesToolStripMenuItem";
            this.tablesToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.tablesToolStripMenuItem.Text = "Tables";
            // 
            // playerOnServerToolStripMenuItem
            // 
            this.playerOnServerToolStripMenuItem.Name = "playerOnServerToolStripMenuItem";
            this.playerOnServerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.playerOnServerToolStripMenuItem.Text = "Player On Server";
            this.playerOnServerToolStripMenuItem.Click += new System.EventHandler(this.playerOnServerToolStripMenuItem_Click);
            // 
            // playerClassSkillToolStripMenuItem
            // 
            this.playerClassSkillToolStripMenuItem.Name = "playerClassSkillToolStripMenuItem";
            this.playerClassSkillToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.playerClassSkillToolStripMenuItem.Text = "Player Class Skill";
            this.playerClassSkillToolStripMenuItem.Click += new System.EventHandler(this.playerClassSkillToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            this.inventoryToolStripMenuItem.Click += new System.EventHandler(this.inventoryToolStripMenuItem_Click);
            // 
            // itemsCatalogToolStripMenuItem
            // 
            this.itemsCatalogToolStripMenuItem.Name = "itemsCatalogToolStripMenuItem";
            this.itemsCatalogToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.itemsCatalogToolStripMenuItem.Text = "Items Catalog";
            this.itemsCatalogToolStripMenuItem.Click += new System.EventHandler(this.itemsCatalogToolStripMenuItem_Click);
            // 
            // itemRarityToolStripMenuItem
            // 
            this.itemRarityToolStripMenuItem.Name = "itemRarityToolStripMenuItem";
            this.itemRarityToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.itemRarityToolStripMenuItem.Text = "Item Rarity";
            this.itemRarityToolStripMenuItem.Click += new System.EventHandler(this.itemRarityToolStripMenuItem_Click);
            // 
            // itemTypeToolStripMenuItem
            // 
            this.itemTypeToolStripMenuItem.Name = "itemTypeToolStripMenuItem";
            this.itemTypeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.itemTypeToolStripMenuItem.Text = "Item Type";
            this.itemTypeToolStripMenuItem.Click += new System.EventHandler(this.itemTypeToolStripMenuItem_Click);
            // 
            // itemHandedToolStripMenuItem
            // 
            this.itemHandedToolStripMenuItem.Name = "itemHandedToolStripMenuItem";
            this.itemHandedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.itemHandedToolStripMenuItem.Text = "Item Handed";
            this.itemHandedToolStripMenuItem.Click += new System.EventHandler(this.itemHandedToolStripMenuItem_Click);
            // 
            // bindingNavigatorMain
            // 
            this.bindingNavigatorMain.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigatorMain.BackColor = System.Drawing.Color.CadetBlue;
            this.bindingNavigatorMain.BindingSource = this.itemscatalogBindingSource;
            this.bindingNavigatorMain.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorMain.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigatorMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.toolStripLabelSearch_Field,
            this.toolStripTextBoxSearch_Field,
            this.toolStripButtonSave});
            this.bindingNavigatorMain.Location = new System.Drawing.Point(0, 24);
            this.bindingNavigatorMain.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorMain.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorMain.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorMain.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorMain.Name = "bindingNavigatorMain";
            this.bindingNavigatorMain.Padding = new System.Windows.Forms.Padding(0, 2, 1, 4);
            this.bindingNavigatorMain.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bindingNavigatorMain.Size = new System.Drawing.Size(800, 29);
            this.bindingNavigatorMain.TabIndex = 1;
            this.bindingNavigatorMain.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // itemscatalogBindingSource
            // 
            this.itemscatalogBindingSource.DataMember = "items_catalog";
            this.itemscatalogBindingSource.DataSource = this.gameDBDataSet;
            // 
            // gameDBDataSet
            // 
            this.gameDBDataSet.DataSetName = "gameDBDataSet";
            this.gameDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 20);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 23);
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripLabelSearch_Field
            // 
            this.toolStripLabelSearch_Field.Name = "toolStripLabelSearch_Field";
            this.toolStripLabelSearch_Field.Size = new System.Drawing.Size(42, 20);
            this.toolStripLabelSearch_Field.Text = "Search";
            // 
            // toolStripTextBoxSearch_Field
            // 
            this.toolStripTextBoxSearch_Field.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBoxSearch_Field.Name = "toolStripTextBoxSearch_Field";
            this.toolStripTextBoxSearch_Field.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBoxSearch_Field.TextChanged += new System.EventHandler(this.toolStripTextBoxSearch_Field_TextChanged);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Image = global::Game_Database_Viewer.Properties.Resources.Save;
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(23, 20);
            this.toolStripButtonSave.Text = "Save";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // dataGridView_DB
            // 
            this.dataGridView_DB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_DB.AutoGenerateColumns = false;
            this.dataGridView_DB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_DB.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView_DB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uIDDataGridViewTextBoxColumn,
            this.playerNameDataGridViewTextBoxColumn,
            this.playerLevelDataGridViewTextBoxColumn,
            this.skillNameDataGridViewTextBoxColumn});
            this.dataGridView_DB.DataSource = this.generalinfoBindingSource;
            this.dataGridView_DB.Location = new System.Drawing.Point(12, 56);
            this.dataGridView_DB.Name = "dataGridView_DB";
            this.dataGridView_DB.ReadOnly = true;
            this.dataGridView_DB.Size = new System.Drawing.Size(776, 169);
            this.dataGridView_DB.TabIndex = 2;
            this.dataGridView_DB.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_DB_CellEndEdit);
            this.dataGridView_DB.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView_DB_DataError);
            this.dataGridView_DB.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView_DB_RowPostPaint);
            // 
            // rarityBindingSource
            // 
            this.rarityBindingSource.DataMember = "rarity";
            this.rarityBindingSource.DataSource = this.gameDBDataSet;
            // 
            // itemtypeBindingSource
            // 
            this.itemtypeBindingSource.DataMember = "item_type";
            this.itemtypeBindingSource.DataSource = this.gameDBDataSet;
            // 
            // handeditemBindingSource
            // 
            this.handeditemBindingSource.DataMember = "handed_item";
            this.handeditemBindingSource.DataSource = this.gameDBDataSet;
            // 
            // dataGridView_SQL
            // 
            this.dataGridView_SQL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_SQL.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView_SQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SQL.Location = new System.Drawing.Point(13, 232);
            this.dataGridView_SQL.Name = "dataGridView_SQL";
            this.dataGridView_SQL.ReadOnly = true;
            this.dataGridView_SQL.Size = new System.Drawing.Size(775, 180);
            this.dataGridView_SQL.TabIndex = 3;
            // 
            // textBox_SQL
            // 
            this.textBox_SQL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_SQL.Location = new System.Drawing.Point(13, 418);
            this.textBox_SQL.Name = "textBox_SQL";
            this.textBox_SQL.Size = new System.Drawing.Size(694, 20);
            this.textBox_SQL.TabIndex = 4;
            this.textBox_SQL.Text = "SELECT * FROM player_on_server";
            // 
            // button_SQL
            // 
            this.button_SQL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_SQL.Location = new System.Drawing.Point(713, 416);
            this.button_SQL.Name = "button_SQL";
            this.button_SQL.Size = new System.Drawing.Size(75, 23);
            this.button_SQL.TabIndex = 5;
            this.button_SQL.Text = "RUN";
            this.button_SQL.UseVisualStyleBackColor = true;
            this.button_SQL.Click += new System.EventHandler(this.button_SQL_Click);
            // 
            // rarityIDDataGridViewTextBoxColumn
            // 
            this.rarityIDDataGridViewTextBoxColumn.DataPropertyName = "Rarity_ID";
            this.rarityIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.rarityIDDataGridViewTextBoxColumn.HeaderText = "Rarity_ID";
            this.rarityIDDataGridViewTextBoxColumn.Name = "rarityIDDataGridViewTextBoxColumn";
            this.rarityIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.rarityIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // itemTypeIDDataGridViewTextBoxColumn
            // 
            this.itemTypeIDDataGridViewTextBoxColumn.DataPropertyName = "Item_Type_ID";
            this.itemTypeIDDataGridViewTextBoxColumn.DataSource = this.itemtypeBindingSource;
            this.itemTypeIDDataGridViewTextBoxColumn.DisplayMember = "Type_Name";
            this.itemTypeIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.itemTypeIDDataGridViewTextBoxColumn.HeaderText = "Item_Type_ID";
            this.itemTypeIDDataGridViewTextBoxColumn.Name = "itemTypeIDDataGridViewTextBoxColumn";
            this.itemTypeIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.itemTypeIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.itemTypeIDDataGridViewTextBoxColumn.ValueMember = "Item_Type_ID";
            // 
            // handedItemIDDataGridViewTextBoxColumn
            // 
            this.handedItemIDDataGridViewTextBoxColumn.DataPropertyName = "Handed_Item_ID";
            this.handedItemIDDataGridViewTextBoxColumn.DataSource = this.handeditemBindingSource;
            this.handedItemIDDataGridViewTextBoxColumn.DisplayMember = "Item_Handed";
            this.handedItemIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.handedItemIDDataGridViewTextBoxColumn.HeaderText = "Handed_Item_ID";
            this.handedItemIDDataGridViewTextBoxColumn.Name = "handedItemIDDataGridViewTextBoxColumn";
            this.handedItemIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.handedItemIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.handedItemIDDataGridViewTextBoxColumn.ValueMember = "Item_Handed";
            // 
            // items_catalogTableAdapter
            // 
            this.items_catalogTableAdapter.ClearBeforeFill = true;
            // 
            // rarityTableAdapter
            // 
            this.rarityTableAdapter.ClearBeforeFill = true;
            // 
            // item_typeTableAdapter
            // 
            this.item_typeTableAdapter.ClearBeforeFill = true;
            // 
            // handed_itemTableAdapter
            // 
            this.handed_itemTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Item_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Item_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Item_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Item_Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Item_Durability";
            this.dataGridViewTextBoxColumn3.HeaderText = "Item_Durability";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Item_Cost";
            this.dataGridViewTextBoxColumn4.HeaderText = "Item_Cost";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Weapon_Skill";
            this.dataGridViewTextBoxColumn5.HeaderText = "Weapon_Skill";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Item_Type_ID";
            this.dataGridViewTextBoxColumn6.HeaderText = "Item_Type_ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Handed_Item_ID";
            this.dataGridViewTextBoxColumn7.HeaderText = "Handed_Item_ID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // generalinfoBindingSource
            // 
            this.generalinfoBindingSource.DataMember = "general_info";
            this.generalinfoBindingSource.DataSource = this.gameDBDataSet;
            // 
            // general_infoTableAdapter
            // 
            this.general_infoTableAdapter.ClearBeforeFill = true;
            // 
            // uIDDataGridViewTextBoxColumn
            // 
            this.uIDDataGridViewTextBoxColumn.DataPropertyName = "UID";
            this.uIDDataGridViewTextBoxColumn.HeaderText = "UID";
            this.uIDDataGridViewTextBoxColumn.Name = "uIDDataGridViewTextBoxColumn";
            this.uIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.uIDDataGridViewTextBoxColumn.Width = 51;
            // 
            // playerNameDataGridViewTextBoxColumn
            // 
            this.playerNameDataGridViewTextBoxColumn.DataPropertyName = "Player_Name";
            this.playerNameDataGridViewTextBoxColumn.HeaderText = "Player_Name";
            this.playerNameDataGridViewTextBoxColumn.Name = "playerNameDataGridViewTextBoxColumn";
            this.playerNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.playerNameDataGridViewTextBoxColumn.Width = 95;
            // 
            // playerLevelDataGridViewTextBoxColumn
            // 
            this.playerLevelDataGridViewTextBoxColumn.DataPropertyName = "Player_Level";
            this.playerLevelDataGridViewTextBoxColumn.HeaderText = "Player_Level";
            this.playerLevelDataGridViewTextBoxColumn.Name = "playerLevelDataGridViewTextBoxColumn";
            this.playerLevelDataGridViewTextBoxColumn.ReadOnly = true;
            this.playerLevelDataGridViewTextBoxColumn.Width = 93;
            // 
            // skillNameDataGridViewTextBoxColumn
            // 
            this.skillNameDataGridViewTextBoxColumn.DataPropertyName = "Skill_Name";
            this.skillNameDataGridViewTextBoxColumn.HeaderText = "Skill_Name";
            this.skillNameDataGridViewTextBoxColumn.Name = "skillNameDataGridViewTextBoxColumn";
            this.skillNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.skillNameDataGridViewTextBoxColumn.Width = 85;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_SQL);
            this.Controls.Add(this.textBox_SQL);
            this.Controls.Add(this.dataGridView_SQL);
            this.Controls.Add(this.dataGridView_DB);
            this.Controls.Add(this.bindingNavigatorMain);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.MinimumSize = new System.Drawing.Size(800, 480);
            this.Name = "FormMain";
            this.Text = "Database viewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorMain)).EndInit();
            this.bindingNavigatorMain.ResumeLayout(false);
            this.bindingNavigatorMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemscatalogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rarityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemtypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.handeditemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SQL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalinfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerOnServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerClassSkillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemsCatalogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemRarityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemHandedToolStripMenuItem;
        private System.Windows.Forms.BindingNavigator bindingNavigatorMain;
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
        private System.Windows.Forms.ToolStripLabel toolStripLabelSearch_Field;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxSearch_Field;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.DataGridView dataGridView_DB;
        private gameDBDataSet gameDBDataSet;
        private gameDBDataSetTableAdapters.items_catalogTableAdapter items_catalogTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView_SQL;
        private System.Windows.Forms.TextBox textBox_SQL;
        private System.Windows.Forms.Button button_SQL;
        private gameDBDataSetTableAdapters.rarityTableAdapter rarityTableAdapter;
        private System.Windows.Forms.BindingSource itemtypeBindingSource;
        private gameDBDataSetTableAdapters.item_typeTableAdapter item_typeTableAdapter;
        private System.Windows.Forms.BindingSource handeditemBindingSource;
        private gameDBDataSetTableAdapters.handed_itemTableAdapter handed_itemTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn rarityIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn itemTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn handedItemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.BindingSource rarityBindingSource;
        private System.Windows.Forms.BindingSource itemscatalogBindingSource;
        private System.Windows.Forms.BindingSource generalinfoBindingSource;
        private gameDBDataSetTableAdapters.general_infoTableAdapter general_infoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn uIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skillNameDataGridViewTextBoxColumn;
    }
}

