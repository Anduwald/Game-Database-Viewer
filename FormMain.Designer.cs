namespace Game_Database_Viewer
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
            this.dataGridView_SQL = new System.Windows.Forms.DataGridView();
            this.textBox_SQL = new System.Windows.Forms.TextBox();
            this.button_SQL = new System.Windows.Forms.Button();
            this.rarityIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.itemTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.handedItemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.itemtypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameDBDataSet = new Game_Database_Viewer.gameDBDataSet();
            this.handeditemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.generalinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemscatalogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rarityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.items_catalogTableAdapter = new Game_Database_Viewer.gameDBDataSetTableAdapters.items_catalogTableAdapter();
            this.rarityTableAdapter = new Game_Database_Viewer.gameDBDataSetTableAdapters.rarityTableAdapter();
            this.item_typeTableAdapter = new Game_Database_Viewer.gameDBDataSetTableAdapters.item_typeTableAdapter();
            this.handed_itemTableAdapter = new Game_Database_Viewer.gameDBDataSetTableAdapters.handed_itemTableAdapter();
            this.general_infoTableAdapter = new Game_Database_Viewer.gameDBDataSetTableAdapters.general_infoTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SQL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemtypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.handeditemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemscatalogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rarityBindingSource)).BeginInit();
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
            this.tablesToolStripMenuItem.Image = global::Game_Database_Viewer.Properties.Resources.NewWindow;
            this.tablesToolStripMenuItem.Name = "tablesToolStripMenuItem";
            this.tablesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.tablesToolStripMenuItem.Text = "Tables";
            // 
            // playerOnServerToolStripMenuItem
            // 
            this.playerOnServerToolStripMenuItem.Name = "playerOnServerToolStripMenuItem";
            this.playerOnServerToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.playerOnServerToolStripMenuItem.Text = "Player On Server";
            this.playerOnServerToolStripMenuItem.Click += new System.EventHandler(this.playerOnServerToolStripMenuItem_Click);
            // 
            // playerClassSkillToolStripMenuItem
            // 
            this.playerClassSkillToolStripMenuItem.Name = "playerClassSkillToolStripMenuItem";
            this.playerClassSkillToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.playerClassSkillToolStripMenuItem.Text = "Player Class Skill";
            this.playerClassSkillToolStripMenuItem.Click += new System.EventHandler(this.playerClassSkillToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            this.inventoryToolStripMenuItem.Click += new System.EventHandler(this.inventoryToolStripMenuItem_Click);
            // 
            // itemsCatalogToolStripMenuItem
            // 
            this.itemsCatalogToolStripMenuItem.Name = "itemsCatalogToolStripMenuItem";
            this.itemsCatalogToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.itemsCatalogToolStripMenuItem.Text = "Items Catalog";
            this.itemsCatalogToolStripMenuItem.Click += new System.EventHandler(this.itemsCatalogToolStripMenuItem_Click);
            // 
            // itemRarityToolStripMenuItem
            // 
            this.itemRarityToolStripMenuItem.Name = "itemRarityToolStripMenuItem";
            this.itemRarityToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.itemRarityToolStripMenuItem.Text = "Item Rarity";
            this.itemRarityToolStripMenuItem.Click += new System.EventHandler(this.itemRarityToolStripMenuItem_Click);
            // 
            // itemTypeToolStripMenuItem
            // 
            this.itemTypeToolStripMenuItem.Name = "itemTypeToolStripMenuItem";
            this.itemTypeToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.itemTypeToolStripMenuItem.Text = "Item Type";
            this.itemTypeToolStripMenuItem.Click += new System.EventHandler(this.itemTypeToolStripMenuItem_Click);
            // 
            // itemHandedToolStripMenuItem
            // 
            this.itemHandedToolStripMenuItem.Name = "itemHandedToolStripMenuItem";
            this.itemHandedToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.itemHandedToolStripMenuItem.Text = "Item Handed";
            this.itemHandedToolStripMenuItem.Click += new System.EventHandler(this.itemHandedToolStripMenuItem_Click);
            // 
            // dataGridView_SQL
            // 
            this.dataGridView_SQL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_SQL.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView_SQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SQL.Location = new System.Drawing.Point(13, 55);
            this.dataGridView_SQL.Name = "dataGridView_SQL";
            this.dataGridView_SQL.ReadOnly = true;
            this.dataGridView_SQL.Size = new System.Drawing.Size(775, 357);
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
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Custom query result table";
            // 
            // itemtypeBindingSource
            // 
            this.itemtypeBindingSource.DataMember = "item_type";
            this.itemtypeBindingSource.DataSource = this.gameDBDataSet;
            // 
            // gameDBDataSet
            // 
            this.gameDBDataSet.DataSetName = "gameDBDataSet";
            this.gameDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // handeditemBindingSource
            // 
            this.handeditemBindingSource.DataMember = "handed_item";
            this.handeditemBindingSource.DataSource = this.gameDBDataSet;
            // 
            // generalinfoBindingSource
            // 
            this.generalinfoBindingSource.DataMember = "general_info";
            this.generalinfoBindingSource.DataSource = this.gameDBDataSet;
            // 
            // itemscatalogBindingSource
            // 
            this.itemscatalogBindingSource.DataMember = "items_catalog";
            this.itemscatalogBindingSource.DataSource = this.gameDBDataSet;
            // 
            // rarityBindingSource
            // 
            this.rarityBindingSource.DataMember = "rarity";
            this.rarityBindingSource.DataSource = this.gameDBDataSet;
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
            // general_infoTableAdapter
            // 
            this.general_infoTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Item_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Item_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 51;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Item_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Item_Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 95;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Item_Durability";
            this.dataGridViewTextBoxColumn3.HeaderText = "Item_Durability";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 93;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Item_Cost";
            this.dataGridViewTextBoxColumn4.HeaderText = "Item_Cost";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 85;
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
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_SQL);
            this.Controls.Add(this.textBox_SQL);
            this.Controls.Add(this.dataGridView_SQL);
            this.Controls.Add(this.menuStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.MinimumSize = new System.Drawing.Size(800, 480);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database viewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SQL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemtypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.handeditemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemscatalogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rarityBindingSource)).EndInit();
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
        private System.Windows.Forms.Label label1;
    }
}

