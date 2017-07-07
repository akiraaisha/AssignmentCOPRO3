using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COPRO3_Assignment1
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            string Username = "root";
            string Password = "toor";

            if (Input_Username.Text == Username && Input_Password.Text == Password)
            {
                MessageBox.Show("Login Successful!");
                CMS GoToCMS = new CMS();
                GoToCMS.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please try again.");
            }
        }

        private void Input_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void Input_Password_TextChanged(object sender, EventArgs e)
        {
        }

        private void Login_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
