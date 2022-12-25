using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Game_Database_Viewer
{
    public partial class FormInventory : Form
    {

        #region FormInit
        public FormInventory()
        {
            InitializeComponent();
        }

        private void FormInventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gameDBDataSet1.inventory_item_info' table. You can move, or remove it, as needed.
            this.inventory_item_infoTableAdapter.Fill(this.gameDBDataSet1.inventory_item_info);
            // TODO: This line of code loads data into the 'gameDBDataSet.player_on_server' table. You can move, or remove it, as needed.
            this.player_on_serverTableAdapter.Fill(this.gameDBDataSet.player_on_server);
            // TODO: This line of code loads data into the 'gameDBDataSet.items_catalog' table. You can move, or remove it, as needed.
            this.items_catalogTableAdapter.Fill(this.gameDBDataSet.items_catalog);
            // TODO: This line of code loads data into the 'gameDBDataSet.inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.gameDBDataSet.inventory);
        }
        #endregion

        #region SetUpDataGridView
        public static string connectionString = Properties.Settings.Default.gameDBConnectionString;
        public static OleDbConnection database = new OleDbConnection(connectionString);
        private void dataGridView_DB_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e) //Printing numeration in row header
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }
        private void dataGridView_DB_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //This event is used to avoid the error of DataGridviewCombobox Cell 
        }
        #endregion

        #region BindingSourceNavigator
        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            this.inventoryTableAdapter.Update(this.gameDBDataSet.inventory);
        }
        #endregion

    }
}