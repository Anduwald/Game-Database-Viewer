using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            if (userName == correctName && userPswd == correctPswd)
            {
                this.Hide();
                FormMain formMain = new FormMain();
                formMain.Owner = this;
                formMain.ShowDialog();
            }
            else MessageBox.Show("Failed Name or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
