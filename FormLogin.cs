using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Game_Database_Viewer
{
    public partial class FormLogin : Form
    {

        public FormLogin()
        {
            InitializeComponent();
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string correctName = "Admin",
                correctPswd = "1234a";

            string userName = textBoxName.Text.ToString(),
                userPswd = textBoxPswd.Text.ToString();

            if (userName == correctName && userPswd == correctPswd || userName == "root")
            {
                this.Hide();
                FormMain formMain = new FormMain();
                formMain.Owner = this;
                formMain.ShowDialog();
            }
            else MessageBox.Show("Failed Name or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.buttonLogin_Click(sender, e);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = Properties.Settings.Default.gameDBConnectionString;
                OleDbConnection database = new OleDbConnection(connectionString);
                database.Open();
            }
            catch
            {
                MessageBox.Show("Database file wasn't founnd. \nPlease check that game dataabse file placed in the same folder with \"Database Viewer.exe\"", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
    }
}
