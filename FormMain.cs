using Game_Database_Viewer.Properties;
using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Game_Database_Viewer
{
    public partial class FormMain : Form
    {

        #region FormInit
        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Settings.Default.Save();
            //   e.Cancel = MessageBox.Show("Do you want to quit?",
            //"Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes;

            var result = MessageBox.Show("Do you want to quit?",
         "Form Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No) e.Cancel = true;
            else this.Owner.Dispose();
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
        private void button_SQL_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand(this.textBox_SQL.Text, database);
            DataSet dataSet = new DataSet();

            try
            {
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(dataSet);
                this.dataGridView_SQL.DataSource = dataSet.Tables[0];
                //this.dataGridView_SQL.Columns[0].Visible = false;
                this.dataGridView_SQL.RowHeadersVisible = false;
            }
            catch
            {
                MessageBox.Show("Check correct sql query", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region MenuStripMain
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program for editing game database. Created by Artem Kuchmambetov & Andrey Mazur.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void playerOnServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPlayer formPlayer = new FormPlayer();
            formPlayer.ShowDialog();
        }
        private void playerClassSkillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSkill formSkill = new FormSkill();
            formSkill.ShowDialog();
        }
        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInventory formInventory = new FormInventory();
            formInventory.ShowDialog();
        }
        private void itemsCatalogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormItemsCatalog formitemsCatalog = new FormItemsCatalog();
            formitemsCatalog.ShowDialog();
        }
        private void itemRarityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRarity formRarity = new FormRarity();
            formRarity.ShowDialog();
        }
        private void itemTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormItemType formItemType = new FormItemType();
            formItemType.ShowDialog();
        }
        private void itemHandedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHanded formHanded = new FormHanded();
            formHanded.ShowDialog();
        }
        #endregion

    }
}

#region NumericUpDownColumn
public class NumericUpDownColumn : DataGridViewColumn
{
    public NumericUpDownColumn()
        : base(new NumericUpDownCell())
    {
    }

    public override DataGridViewCell CellTemplate
    {
        get { return base.CellTemplate; }
        set
        {
            if (value != null && !value.GetType().IsAssignableFrom(typeof(NumericUpDownCell)))
            {
                throw new InvalidCastException("Must be a NumericUpDownCell");
            }
            base.CellTemplate = value;
        }
    }
}

public class NumericUpDownCell : DataGridViewTextBoxCell
{
    private readonly decimal min = 0;
    private readonly decimal max = 1000000;

    public NumericUpDownCell()
        : base()
    {
        Style.Format = "F0";
    }
    public NumericUpDownCell(decimal min, decimal max)
        : base()
    {
        this.min = min;
        this.max = max;
        Style.Format = "F0";
    }

    public override void InitializeEditingControl(int rowIndex, object initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
    {
        base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);
        NumericUpDownEditingControl ctl = DataGridView.EditingControl as NumericUpDownEditingControl;
        ctl.Minimum = this.min;
        ctl.Maximum = this.max;
        if (this.Value.GetType() == typeof(System.Int32))
            ctl.Value = Convert.ToDecimal(this.Value);
    }

    public override Type EditType
    {
        get { return typeof(NumericUpDownEditingControl); }
    }

    public override Type ValueType
    {
        get { return typeof(Decimal); }
    }

    public override object DefaultNewRowValue
    {
        get { return null; }
    }
}

public class NumericUpDownEditingControl : NumericUpDown, IDataGridViewEditingControl
{
    private DataGridView dataGridViewControl;
    private bool valueIsChanged = false;
    private int rowIndexNum;

    public NumericUpDownEditingControl()
        : base()
    {
        this.DecimalPlaces = 0;
    }

    public DataGridView EditingControlDataGridView
    {
        get { return dataGridViewControl; }
        set { dataGridViewControl = value; }
    }

    public object EditingControlFormattedValue
    {
        get { return this.Value.ToString("F0"); }
        set { this.Value = Decimal.Parse(value.ToString()); }
    }
    public int EditingControlRowIndex
    {
        get { return rowIndexNum; }
        set { rowIndexNum = value; }
    }
    public bool EditingControlValueChanged
    {
        get { return valueIsChanged; }
        set { valueIsChanged = value; }
    }

    public Cursor EditingPanelCursor
    {
        get { return base.Cursor; }
    }

    public bool RepositionEditingControlOnValueChange
    {
        get { return false; }
    }

    public void ApplyCellStyleToEditingControl(DataGridViewCellStyle dataGridViewCellStyle)
    {
        this.Font = dataGridViewCellStyle.Font;
        this.ForeColor = dataGridViewCellStyle.ForeColor;
        this.BackColor = dataGridViewCellStyle.BackColor;
    }

    public bool EditingControlWantsInputKey(Keys keyData, bool dataGridViewWantsInputKey)
    {
        return (keyData == Keys.Left || keyData == Keys.Right ||
            keyData == Keys.Up || keyData == Keys.Down ||
            keyData == Keys.Home || keyData == Keys.End ||
            keyData == Keys.PageDown || keyData == Keys.PageUp);
    }

    public object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context)
    {
        return this.Value.ToString();
    }

    public void PrepareEditingControlForEdit(bool selectAll)
    {
    }

    protected override void OnValueChanged(EventArgs e)
    {
        valueIsChanged = true;
        this.EditingControlDataGridView.NotifyCurrentCellDirty(true);
        base.OnValueChanged(e);
    }
}
#endregion