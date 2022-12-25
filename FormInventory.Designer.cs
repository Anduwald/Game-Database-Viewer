namespace Game_Database_Viewer
{
    partial class FormInventory
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
            this.bindingNavigatorMain = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.playeronserverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemscatalogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playerclassskillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rarityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemtypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.handeditemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rarityIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.itemTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.handedItemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.items_catalogTableAdapter = new Game_Database_Viewer.gameDBDataSetTableAdapters.items_catalogTableAdapter();
            this.rarityTableAdapter = new Game_Database_Viewer.gameDBDataSetTableAdapters.rarityTableAdapter();
            this.item_typeTableAdapter = new Game_Database_Viewer.gameDBDataSetTableAdapters.item_typeTableAdapter();
            this.handed_itemTableAdapter = new Game_Database_Viewer.gameDBDataSetTableAdapters.handed_itemTableAdapter();
            this.player_on_serverTableAdapter = new Game_Database_Viewer.gameDBDataSetTableAdapters.player_on_serverTableAdapter();
            this.player_class_skillTableAdapter = new Game_Database_Viewer.gameDBDataSetTableAdapters.player_class_skillTableAdapter();
            this.dataGridView_DB = new System.Windows.Forms.DataGridView();
            this.inventoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.itemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.inventoryiteminfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameDBDataSet1 = new Game_Database_Viewer.gameDBDataSet();
            this.equipedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.questItemDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.damageDataGridViewTextBoxColumn = new NumericUpDownColumn();
            this.manaCostDataGridViewTextBoxColumn = new NumericUpDownColumn();
            this.hPCostDataGridViewTextBoxColumn = new NumericUpDownColumn();
            this.itemscatalogBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryTableAdapter = new Game_Database_Viewer.gameDBDataSetTableAdapters.inventoryTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numericUpDownColumn1 = new NumericUpDownColumn();
            this.numericUpDownColumn2 = new NumericUpDownColumn();
            this.numericUpDownColumn3 = new NumericUpDownColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventory_item_infoTableAdapter = new Game_Database_Viewer.gameDBDataSetTableAdapters.inventory_item_infoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorMain)).BeginInit();
            this.bindingNavigatorMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playeronserverBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemscatalogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerclassskillBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rarityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemtypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.handeditemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryiteminfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemscatalogBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigatorMain
            // 
            this.bindingNavigatorMain.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigatorMain.BackColor = System.Drawing.Color.CadetBlue;
            this.bindingNavigatorMain.BindingSource = this.inventoryBindingSource;
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
            this.toolStripButtonSave});
            this.bindingNavigatorMain.Location = new System.Drawing.Point(0, 0);
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
            this.bindingNavigatorAddNewItem.Image = global::Game_Database_Viewer.Properties.Resources.NewLine;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "inventory";
            this.inventoryBindingSource.DataSource = this.gameDBDataSet;
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
            this.bindingNavigatorDeleteItem.Image = global::Game_Database_Viewer.Properties.Resources.Delete;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = global::Game_Database_Viewer.Properties.Resources.LeftEnd;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = global::Game_Database_Viewer.Properties.Resources.LeftNext;
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            this.bindingNavigatorMoveNextItem.Image = global::Game_Database_Viewer.Properties.Resources.RightNext;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = global::Game_Database_Viewer.Properties.Resources.RightEnd;
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
            // playeronserverBindingSource
            // 
            this.playeronserverBindingSource.DataMember = "player_on_server";
            this.playeronserverBindingSource.DataSource = this.gameDBDataSet;
            // 
            // itemscatalogBindingSource
            // 
            this.itemscatalogBindingSource.DataMember = "items_catalog";
            this.itemscatalogBindingSource.DataSource = this.gameDBDataSet;
            // 
            // playerclassskillBindingSource
            // 
            this.playerclassskillBindingSource.DataMember = "player_class_skill";
            this.playerclassskillBindingSource.DataSource = this.gameDBDataSet;
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
            // player_on_serverTableAdapter
            // 
            this.player_on_serverTableAdapter.ClearBeforeFill = true;
            // 
            // player_class_skillTableAdapter
            // 
            this.player_class_skillTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView_DB
            // 
            this.dataGridView_DB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_DB.AutoGenerateColumns = false;
            this.dataGridView_DB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_DB.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView_DB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inventoryIDDataGridViewTextBoxColumn,
            this.uIDDataGridViewTextBoxColumn,
            this.itemIDDataGridViewTextBoxColumn,
            this.equipedDataGridViewCheckBoxColumn,
            this.questItemDataGridViewCheckBoxColumn,
            this.damageDataGridViewTextBoxColumn,
            this.manaCostDataGridViewTextBoxColumn,
            this.hPCostDataGridViewTextBoxColumn});
            this.dataGridView_DB.DataSource = this.inventoryBindingSource;
            this.dataGridView_DB.Location = new System.Drawing.Point(12, 32);
            this.dataGridView_DB.Name = "dataGridView_DB";
            this.dataGridView_DB.Size = new System.Drawing.Size(776, 406);
            this.dataGridView_DB.TabIndex = 2;
            this.dataGridView_DB.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView_DB_DataError);
            this.dataGridView_DB.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView_DB_RowPostPaint);
            // 
            // inventoryIDDataGridViewTextBoxColumn
            // 
            this.inventoryIDDataGridViewTextBoxColumn.DataPropertyName = "Inventory_ID";
            this.inventoryIDDataGridViewTextBoxColumn.HeaderText = "Inventory_ID";
            this.inventoryIDDataGridViewTextBoxColumn.Name = "inventoryIDDataGridViewTextBoxColumn";
            this.inventoryIDDataGridViewTextBoxColumn.Visible = false;
            this.inventoryIDDataGridViewTextBoxColumn.Width = 93;
            // 
            // uIDDataGridViewTextBoxColumn
            // 
            this.uIDDataGridViewTextBoxColumn.DataPropertyName = "UID";
            this.uIDDataGridViewTextBoxColumn.DataSource = this.playeronserverBindingSource;
            this.uIDDataGridViewTextBoxColumn.DisplayMember = "Player_Name";
            this.uIDDataGridViewTextBoxColumn.HeaderText = "Player Name";
            this.uIDDataGridViewTextBoxColumn.Name = "uIDDataGridViewTextBoxColumn";
            this.uIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.uIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.uIDDataGridViewTextBoxColumn.ValueMember = "UID";
            this.uIDDataGridViewTextBoxColumn.Width = 92;
            // 
            // itemIDDataGridViewTextBoxColumn
            // 
            this.itemIDDataGridViewTextBoxColumn.DataPropertyName = "Item_ID";
            this.itemIDDataGridViewTextBoxColumn.DataSource = this.inventoryiteminfoBindingSource;
            this.itemIDDataGridViewTextBoxColumn.DisplayMember = "Item_Full_Name";
            this.itemIDDataGridViewTextBoxColumn.HeaderText = "Item Name";
            this.itemIDDataGridViewTextBoxColumn.Name = "itemIDDataGridViewTextBoxColumn";
            this.itemIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.itemIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.itemIDDataGridViewTextBoxColumn.ValueMember = "Item_ID";
            this.itemIDDataGridViewTextBoxColumn.Width = 83;
            // 
            // inventoryiteminfoBindingSource
            // 
            this.inventoryiteminfoBindingSource.DataMember = "inventory_item_info";
            this.inventoryiteminfoBindingSource.DataSource = this.gameDBDataSet1;
            // 
            // gameDBDataSet1
            // 
            this.gameDBDataSet1.DataSetName = "gameDBDataSet";
            this.gameDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // equipedDataGridViewCheckBoxColumn
            // 
            this.equipedDataGridViewCheckBoxColumn.DataPropertyName = "Equiped";
            this.equipedDataGridViewCheckBoxColumn.HeaderText = "Equiped";
            this.equipedDataGridViewCheckBoxColumn.Name = "equipedDataGridViewCheckBoxColumn";
            this.equipedDataGridViewCheckBoxColumn.Width = 52;
            // 
            // questItemDataGridViewCheckBoxColumn
            // 
            this.questItemDataGridViewCheckBoxColumn.DataPropertyName = "Quest_Item";
            this.questItemDataGridViewCheckBoxColumn.HeaderText = "Quest_Item";
            this.questItemDataGridViewCheckBoxColumn.Name = "questItemDataGridViewCheckBoxColumn";
            this.questItemDataGridViewCheckBoxColumn.Width = 67;
            // 
            // damageDataGridViewTextBoxColumn
            // 
            this.damageDataGridViewTextBoxColumn.DataPropertyName = "Damage";
            this.damageDataGridViewTextBoxColumn.HeaderText = "Damage";
            this.damageDataGridViewTextBoxColumn.Name = "damageDataGridViewTextBoxColumn";
            this.damageDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.damageDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.damageDataGridViewTextBoxColumn.Width = 72;
            // 
            // manaCostDataGridViewTextBoxColumn
            // 
            this.manaCostDataGridViewTextBoxColumn.DataPropertyName = "Mana_Cost";
            this.manaCostDataGridViewTextBoxColumn.HeaderText = "Mana Cost";
            this.manaCostDataGridViewTextBoxColumn.Name = "manaCostDataGridViewTextBoxColumn";
            this.manaCostDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.manaCostDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.manaCostDataGridViewTextBoxColumn.Width = 83;
            // 
            // hPCostDataGridViewTextBoxColumn
            // 
            this.hPCostDataGridViewTextBoxColumn.DataPropertyName = "HP_Cost";
            this.hPCostDataGridViewTextBoxColumn.HeaderText = "HP Cost";
            this.hPCostDataGridViewTextBoxColumn.Name = "hPCostDataGridViewTextBoxColumn";
            this.hPCostDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hPCostDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.hPCostDataGridViewTextBoxColumn.Width = 71;
            // 
            // itemscatalogBindingSource1
            // 
            this.itemscatalogBindingSource1.DataMember = "items_catalog";
            this.itemscatalogBindingSource1.DataSource = this.gameDBDataSet;
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Item_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Item_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 93;
            // 
            // numericUpDownColumn1
            // 
            this.numericUpDownColumn1.DataPropertyName = "Damage";
            this.numericUpDownColumn1.HeaderText = "Damage";
            this.numericUpDownColumn1.Name = "numericUpDownColumn1";
            this.numericUpDownColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.numericUpDownColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.numericUpDownColumn1.Width = 72;
            // 
            // numericUpDownColumn2
            // 
            this.numericUpDownColumn2.DataPropertyName = "Mana_Cost";
            this.numericUpDownColumn2.HeaderText = "Mana Cost";
            this.numericUpDownColumn2.Name = "numericUpDownColumn2";
            this.numericUpDownColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.numericUpDownColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.numericUpDownColumn2.Width = 83;
            // 
            // numericUpDownColumn3
            // 
            this.numericUpDownColumn3.DataPropertyName = "HP_Cost";
            this.numericUpDownColumn3.HeaderText = "HP Cost";
            this.numericUpDownColumn3.Name = "numericUpDownColumn3";
            this.numericUpDownColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.numericUpDownColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.numericUpDownColumn3.Width = 71;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Item_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Item_Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.Width = 69;
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
            // inventory_item_infoTableAdapter
            // 
            this.inventory_item_infoTableAdapter.ClearBeforeFill = true;
            // 
            // FormInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_DB);
            this.Controls.Add(this.bindingNavigatorMain);
            this.MinimumSize = new System.Drawing.Size(800, 480);
            this.Name = "FormInventory";
            this.Text = "Database viewer | Inventory";
            this.Load += new System.EventHandler(this.FormInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorMain)).EndInit();
            this.bindingNavigatorMain.ResumeLayout(false);
            this.bindingNavigatorMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playeronserverBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemscatalogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerclassskillBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rarityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemtypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.handeditemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryiteminfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemscatalogBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.DataGridView dataGridView_DB;
        private gameDBDataSet gameDBDataSet;
        private gameDBDataSetTableAdapters.items_catalogTableAdapter items_catalogTableAdapter;
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
        private System.Windows.Forms.BindingSource playeronserverBindingSource;
        private gameDBDataSetTableAdapters.player_on_serverTableAdapter player_on_serverTableAdapter;
        private System.Windows.Forms.BindingSource playerclassskillBindingSource;
        private gameDBDataSetTableAdapters.player_class_skillTableAdapter player_class_skillTableAdapter;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private gameDBDataSetTableAdapters.inventoryTableAdapter inventoryTableAdapter;
        private System.Windows.Forms.BindingSource itemscatalogBindingSource1;
        private NumericUpDownColumn numericUpDownColumn1;
        private NumericUpDownColumn numericUpDownColumn2;
        private NumericUpDownColumn numericUpDownColumn3;
        private gameDBDataSet gameDBDataSet1;
        private System.Windows.Forms.BindingSource inventoryiteminfoBindingSource;
        private gameDBDataSetTableAdapters.inventory_item_infoTableAdapter inventory_item_infoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn uIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn equipedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn questItemDataGridViewCheckBoxColumn;
        private NumericUpDownColumn damageDataGridViewTextBoxColumn;
        private NumericUpDownColumn manaCostDataGridViewTextBoxColumn;
        private NumericUpDownColumn hPCostDataGridViewTextBoxColumn;
    }
}

