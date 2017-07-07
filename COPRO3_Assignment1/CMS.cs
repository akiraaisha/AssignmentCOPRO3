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
    public partial class CMS : Form
    {
        public CMS()
        {
            InitializeComponent();
        }

        private void CMS_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Login_Form GoBackToLoginForm = new Login_Form();
            this.Hide();
            GoBackToLoginForm.Show();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login_Form GoBackToLoginForm = new Login_Form();
            this.Hide();
            GoBackToLoginForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void addEnrolleeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!PanelForEnrollee.Visible)
            {
                PanelForEnrollee.Visible = true;
            }
        }

        private void PanelForEnrollee_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void CMS_Load(object sender, EventArgs e)
        {

        }

        private void ImageImport_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogue = new OpenFileDialog();
            openFileDialogue.Filter = "Image Files|*.jpg; *.png; *.bmp";

            if (openFileDialogue.ShowDialog() == DialogResult.OK)
            {
                Profile_Picture.ImageLocation = openFileDialogue.FileName;
            }


            //Bitmap loadedBitmap = Bitmap.FromFile(ImageImport_Button);
        }

        public static string SelectedGender = String.Empty;
        private void Female_Button_CheckedChanged(object sender, EventArgs e)
        {
            if (Female_Button.Checked == true)
            {
                Male_Button.Checked = false;
                SelectedGender = "Male";
            }

        }
    
        private void Male_Button_CheckedChanged(object sender, EventArgs e)
        {
            if (Male_Button.Checked == true)
            {
                    Female_Button.Checked = false;
                SelectedGender = "Male";
            } 
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Submit_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Full Name: " + FirstNameInput.Text + MiddleInitialInput.Text + SurnameInput.Text
                + Environment.NewLine + "Age: " + AgeInput.Text
                + Environment.NewLine + "Gender: " + SelectedGender
                + Environment.NewLine + "Civil Status: " + CivilStatus_ListBox.SelectedItem.ToString());
                //Exporting an Image in MessageBox is not possible.
                //+ Environment.NewLine + Profile_Picture);



        }
        
        private void CivilStatus_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CivilStatus_ListBox_Click(object sender, EventArgs e)
        {
           
        }

        private void Profile_Picture_Click(object sender, EventArgs e)
        {

        }
    }
}
