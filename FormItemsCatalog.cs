using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Game_Database_Viewer
{
    public partial class FormItemsCatalog : Form
    {

        #region FormInit
        public FormItemsCatalog()
        {
            InitializeComponent();
        }

        private void FormItemsCatalog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gameDBDataSet.rarity' table. You can move, or remove it, as needed.
            this.rarityTableAdapter.Fill(this.gameDBDataSet.rarity);
            // TODO: This line of code loads data into the 'gameDBDataSet.item_type' table. You can move, or remove it, as needed.
            this.item_typeTableAdapter.Fill(this.gameDBDataSet.item_type);
            // TODO: This line of code loads data into the 'gameDBDataSet.handed_item' table. You can move, or remove it, as needed.
            this.handed_itemTableAdapter.Fill(this.gameDBDataSet.handed_item);
            // TODO: This line of code loads data into the 'gameDBDataSet.items_catalog' table. You can move, or remove it, as needed.
            this.items_catalogTableAdapter.Fill(this.gameDBDataSet.items_catalog);
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
        private void dataGridView_DB_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = e.ColumnIndex;
            int rowIndex = e.RowIndex;

            if (this.dataGridView_DB.Rows[rowIndex].Cells[columnIndex].Value != null)
            {
                string value = this.dataGridView_DB.Rows[rowIndex].Cells[columnIndex].Value.ToString();

                string pattern = @"[^\p{L}\p{M}\'\s]";
                string substitution = @"";
                RegexOptions options = RegexOptions.Multiline;

                Regex regex = new Regex(pattern, options);
                string resultValue;

                if (columnIndex == 1 || columnIndex == 4)
                    if (Regex.Match(value, pattern, options).Success)
                    {
                        resultValue = regex.Replace(value, substitution);
                        this.dataGridView_DB.Rows[rowIndex].Cells[columnIndex].Value = resultValue;
                        //For debuging
                        //Console.WriteLine(columnIndex + " " + rowIndex + " " + this.dataGridView_DB.Rows[rowIndex].Cells[columnIndex].Value + " " + resultValue);

                        MessageBox.Show("You can not enter number in this field! \nWe are delete them for you.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
            }
        }
        private void dataGridView_DB_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //This event is used to avoid the error of DataGridviewCombobox Cell 
        }
        #endregion

        #region BindingSourceNavigator
        private void toolStripTextBoxSearch_Field_TextChanged(object sender, EventArgs e)
        {
            int i = this.itemscatalogBindingSource.Find("Item_Name", toolStripTextBoxSearch_Field.Text);

            if (i == -1)
            {
                DataView dv = new DataView(this.gameDBDataSet.items_catalog as DataTable);

                string pattern = @"[^\p{L}\p{M}\s]";
                string substitution = @"";
                RegexOptions options = RegexOptions.Multiline;

                Regex regex = new Regex(pattern, options);

                if (Regex.Match(toolStripTextBoxSearch_Field.Text.ToString(), pattern, options).Success)
                {
                    toolStripTextBoxSearch_Field.Text = regex.Replace(toolStripTextBoxSearch_Field.Text.ToString(), substitution);

                    toolStripTextBoxSearch_Field.SelectionStart = toolStripTextBoxSearch_Field.Text.Length;
                    toolStripTextBoxSearch_Field.SelectionLength = 0;
                };

                dv.RowFilter = string.Format("Item_Name LIKE '*{0}*'", toolStripTextBoxSearch_Field.Text);
                if (dv.Count != 0)
                {
                    i = this.itemscatalogBindingSource.Find("Item_Name", dv[0]["Item_Name"]);
                }

                dv.Dispose();
            }
            this.itemscatalogBindingSource.Position = i;
        }
        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            this.items_catalogTableAdapter.Update(this.gameDBDataSet.items_catalog);
        }
        #endregion

    }
}