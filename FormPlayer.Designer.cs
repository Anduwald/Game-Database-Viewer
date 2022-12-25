namespace Game_Database_Viewer
{
    partial class FormPlayer
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
            this.playeronserverBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.uIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerPositionXDataGridViewTextBoxColumn = new NumericUpDownColumn();
            this.playerPositionYDataGridViewTextBoxColumn = new NumericUpDownColumn();
            this.playerPositionZDataGridViewTextBoxColumn = new NumericUpDownColumn();
            this.playerLevelDataGridViewTextBoxColumn = new NumericUpDownColumn();
            this.playerMightDataGridViewTextBoxColumn = new NumericUpDownColumn();
            this.playerManaDataGridViewTextBoxColumn = new NumericUpDownColumn();
            this.playerArmorDataGridViewTextBoxColumn = new NumericUpDownColumn();
            this.playerHealthDataGridViewTextBoxColumn = new NumericUpDownColumn();
            this.playerClassSkillIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorMain)).BeginInit();
            this.bindingNavigatorMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playeronserverBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemscatalogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerclassskillBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rarityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemtypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.handeditemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DB)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigatorMain
            // 
            this.bindingNavigatorMain.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigatorMain.BackColor = System.Drawing.Color.CadetBlue;
            this.bindingNavigatorMain.BindingSource = this.playeronserverBindingSource;
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
            // playeronserverBindingSource
            // 
            this.playeronserverBindingSource.DataMember = "player_on_server";
            this.playeronserverBindingSource.DataSource = this.gameDBDataSet;
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
            // toolStripLabelSearch_Field
            // 
            this.toolStripLabelSearch_Field.Name = "toolStripLabelSearch_Field";
            this.toolStripLabelSearch_Field.Size = new System.Drawing.Size(42, 20);
            this.toolStripLabelSearch_Field.Text = "Search";
            // 
            // toolStripTextBoxSearch_Field
            // 
            this.toolStripTextBoxSearch_Field.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBoxSearch_Field.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            this.uIDDataGridViewTextBoxColumn,
            this.playerNameDataGridViewTextBoxColumn,
            this.playerPositionXDataGridViewTextBoxColumn,
            this.playerPositionYDataGridViewTextBoxColumn,
            this.playerPositionZDataGridViewTextBoxColumn,
            this.playerLevelDataGridViewTextBoxColumn,
            this.playerMightDataGridViewTextBoxColumn,
            this.playerManaDataGridViewTextBoxColumn,
            this.playerArmorDataGridViewTextBoxColumn,
            this.playerHealthDataGridViewTextBoxColumn,
            this.playerClassSkillIDDataGridViewTextBoxColumn});
            this.dataGridView_DB.DataSource = this.playeronserverBindingSource;
            this.dataGridView_DB.Location = new System.Drawing.Point(12, 32);
            this.dataGridView_DB.Name = "dataGridView_DB";
            this.dataGridView_DB.Size = new System.Drawing.Size(776, 406);
            this.dataGridView_DB.TabIndex = 2;
            this.dataGridView_DB.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_DB_CellEndEdit);
            this.dataGridView_DB.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView_DB_DataError);
            this.dataGridView_DB.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView_DB_RowPostPaint);
            // 
            // uIDDataGridViewTextBoxColumn
            // 
            this.uIDDataGridViewTextBoxColumn.DataPropertyName = "UID";
            this.uIDDataGridViewTextBoxColumn.HeaderText = "User ID (UID)";
            this.uIDDataGridViewTextBoxColumn.Name = "uIDDataGridViewTextBoxColumn";
            this.uIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.uIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.uIDDataGridViewTextBoxColumn.Width = 96;
            // 
            // playerNameDataGridViewTextBoxColumn
            // 
            this.playerNameDataGridViewTextBoxColumn.DataPropertyName = "Player_Name";
            this.playerNameDataGridViewTextBoxColumn.HeaderText = "Player Name";
            this.playerNameDataGridViewTextBoxColumn.Name = "playerNameDataGridViewTextBoxColumn";
            this.playerNameDataGridViewTextBoxColumn.Width = 92;
            // 
            // playerPositionXDataGridViewTextBoxColumn
            // 
            this.playerPositionXDataGridViewTextBoxColumn.DataPropertyName = "Player_Position_X";
            this.playerPositionXDataGridViewTextBoxColumn.HeaderText = "Position X";
            this.playerPositionXDataGridViewTextBoxColumn.Name = "playerPositionXDataGridViewTextBoxColumn";
            this.playerPositionXDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.playerPositionXDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.playerPositionXDataGridViewTextBoxColumn.Width = 79;
            // 
            // playerPositionYDataGridViewTextBoxColumn
            // 
            this.playerPositionYDataGridViewTextBoxColumn.DataPropertyName = "Player_Position_Y";
            this.playerPositionYDataGridViewTextBoxColumn.HeaderText = "Position Y";
            this.playerPositionYDataGridViewTextBoxColumn.Name = "playerPositionYDataGridViewTextBoxColumn";
            this.playerPositionYDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.playerPositionYDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.playerPositionYDataGridViewTextBoxColumn.Width = 79;
            // 
            // playerPositionZDataGridViewTextBoxColumn
            // 
            this.playerPositionZDataGridViewTextBoxColumn.DataPropertyName = "Player_Position_Z";
            this.playerPositionZDataGridViewTextBoxColumn.HeaderText = "Position Z";
            this.playerPositionZDataGridViewTextBoxColumn.Name = "playerPositionZDataGridViewTextBoxColumn";
            this.playerPositionZDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.playerPositionZDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.playerPositionZDataGridViewTextBoxColumn.Width = 79;
            // 
            // playerLevelDataGridViewTextBoxColumn
            // 
            this.playerLevelDataGridViewTextBoxColumn.DataPropertyName = "Player_Level";
            this.playerLevelDataGridViewTextBoxColumn.HeaderText = "Level";
            this.playerLevelDataGridViewTextBoxColumn.Name = "playerLevelDataGridViewTextBoxColumn";
            this.playerLevelDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.playerLevelDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.playerLevelDataGridViewTextBoxColumn.Width = 58;
            // 
            // playerMightDataGridViewTextBoxColumn
            // 
            this.playerMightDataGridViewTextBoxColumn.DataPropertyName = "Player_Might";
            this.playerMightDataGridViewTextBoxColumn.HeaderText = "Might";
            this.playerMightDataGridViewTextBoxColumn.Name = "playerMightDataGridViewTextBoxColumn";
            this.playerMightDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.playerMightDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.playerMightDataGridViewTextBoxColumn.Width = 58;
            // 
            // playerManaDataGridViewTextBoxColumn
            // 
            this.playerManaDataGridViewTextBoxColumn.DataPropertyName = "Player_Mana";
            this.playerManaDataGridViewTextBoxColumn.HeaderText = "Mana";
            this.playerManaDataGridViewTextBoxColumn.Name = "playerManaDataGridViewTextBoxColumn";
            this.playerManaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.playerManaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.playerManaDataGridViewTextBoxColumn.Width = 59;
            // 
            // playerArmorDataGridViewTextBoxColumn
            // 
            this.playerArmorDataGridViewTextBoxColumn.DataPropertyName = "Player_Armor";
            this.playerArmorDataGridViewTextBoxColumn.HeaderText = "Defence";
            this.playerArmorDataGridViewTextBoxColumn.Name = "playerArmorDataGridViewTextBoxColumn";
            this.playerArmorDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.playerArmorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.playerArmorDataGridViewTextBoxColumn.Width = 73;
            // 
            // playerHealthDataGridViewTextBoxColumn
            // 
            this.playerHealthDataGridViewTextBoxColumn.DataPropertyName = "Player_Health";
            this.playerHealthDataGridViewTextBoxColumn.HeaderText = "Health";
            this.playerHealthDataGridViewTextBoxColumn.Name = "playerHealthDataGridViewTextBoxColumn";
            this.playerHealthDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.playerHealthDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.playerHealthDataGridViewTextBoxColumn.Width = 63;
            // 
            // playerClassSkillIDDataGridViewTextBoxColumn
            // 
            this.playerClassSkillIDDataGridViewTextBoxColumn.DataPropertyName = "Player_Class_Skill_ID";
            this.playerClassSkillIDDataGridViewTextBoxColumn.DataSource = this.playerclassskillBindingSource;
            this.playerClassSkillIDDataGridViewTextBoxColumn.DisplayMember = "Skill_Name";
            this.playerClassSkillIDDataGridViewTextBoxColumn.HeaderText = "Class Skill";
            this.playerClassSkillIDDataGridViewTextBoxColumn.Name = "playerClassSkillIDDataGridViewTextBoxColumn";
            this.playerClassSkillIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.playerClassSkillIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.playerClassSkillIDDataGridViewTextBoxColumn.ValueMember = "Player_Class_Skill_ID";
            this.playerClassSkillIDDataGridViewTextBoxColumn.Width = 79;
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
            // FormPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_DB);
            this.Controls.Add(this.bindingNavigatorMain);
            this.MinimumSize = new System.Drawing.Size(800, 480);
            this.Name = "FormPlayer";
            this.Text = "Database viewer | Players List";
            this.Load += new System.EventHandler(this.FormPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorMain)).EndInit();
            this.bindingNavigatorMain.ResumeLayout(false);
            this.bindingNavigatorMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playeronserverBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemscatalogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerclassskillBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rarityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemtypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.handeditemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DB)).EndInit();
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
        private System.Windows.Forms.ToolStripLabel toolStripLabelSearch_Field;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxSearch_Field;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn uIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerNameDataGridViewTextBoxColumn;
        private NumericUpDownColumn playerPositionXDataGridViewTextBoxColumn;
        private NumericUpDownColumn playerPositionYDataGridViewTextBoxColumn;
        private NumericUpDownColumn playerPositionZDataGridViewTextBoxColumn;
        private NumericUpDownColumn playerLevelDataGridViewTextBoxColumn;
        private NumericUpDownColumn playerMightDataGridViewTextBoxColumn;
        private NumericUpDownColumn playerManaDataGridViewTextBoxColumn;
        private NumericUpDownColumn playerArmorDataGridViewTextBoxColumn;
        private NumericUpDownColumn playerHealthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn playerClassSkillIDDataGridViewTextBoxColumn;
    }
}

