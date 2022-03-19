using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightsControlSystemFiveLED
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_login_Enter_Click(object sender, EventArgs e)
        {
            if (txtbox_login_PasswordField.Text == "")
            {
                MessageBox.Show("Please enter the password!");
            }
            else if (txtbox_login_PasswordField.Text == "harvey123")
            {
                Form1.correctPassword = true;
                this.Close();
            }
            else {
                MessageBox.Show("Sorry. Wrong password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Enter key event handler
        private void txtbox_login_PasswordField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login_Enter.PerformClick();
            }
        }

    }
}
