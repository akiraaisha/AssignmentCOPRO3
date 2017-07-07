namespace COPRO3_Assignment1
{
    partial class CMS
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEnrolleeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.developedByJulianLugodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.PanelForEnrollee = new System.Windows.Forms.Panel();
            this.CivilStatus_ListBox = new System.Windows.Forms.ListBox();
            this.CivilStatus_Label = new System.Windows.Forms.Label();
            this.ImageImport_Button = new System.Windows.Forms.Button();
            this.Profile_Picture = new System.Windows.Forms.PictureBox();
            this.Submit_Button = new System.Windows.Forms.Button();
            this.Female_Button = new System.Windows.Forms.RadioButton();
            this.Male_Button = new System.Windows.Forms.RadioButton();
            this.Gender_Label = new System.Windows.Forms.Label();
            this.AgeInput = new System.Windows.Forms.TextBox();
            this.Age_Label = new System.Windows.Forms.Label();
            this.MiddleInitialInput = new System.Windows.Forms.TextBox();
            this.MiddleInitial_Label = new System.Windows.Forms.Label();
            this.FirstNameInput = new System.Windows.Forms.TextBox();
            this.FirstName_Label = new System.Windows.Forms.Label();
            this.SurnameInput = new System.Windows.Forms.TextBox();
            this.SurName_Label = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.PanelForEnrollee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Profile_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(966, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEnrolleeToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // addEnrolleeToolStripMenuItem
            // 
            this.addEnrolleeToolStripMenuItem.Name = "addEnrolleeToolStripMenuItem";
            this.addEnrolleeToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.addEnrolleeToolStripMenuItem.Text = "Add Enrollee";
            this.addEnrolleeToolStripMenuItem.Click += new System.EventHandler(this.addEnrolleeToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.developedByJulianLugodToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // developedByJulianLugodToolStripMenuItem
            // 
            this.developedByJulianLugodToolStripMenuItem.Name = "developedByJulianLugodToolStripMenuItem";
            this.developedByJulianLugodToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.developedByJulianLugodToolStripMenuItem.Text = "Developed by Julian Lugod";
            // 
            // PanelForEnrollee
            // 
            this.PanelForEnrollee.BackColor = System.Drawing.SystemColors.Control;
            this.PanelForEnrollee.Controls.Add(this.CivilStatus_ListBox);
            this.PanelForEnrollee.Controls.Add(this.CivilStatus_Label);
            this.PanelForEnrollee.Controls.Add(this.ImageImport_Button);
            this.PanelForEnrollee.Controls.Add(this.Profile_Picture);
            this.PanelForEnrollee.Controls.Add(this.Submit_Button);
            this.PanelForEnrollee.Controls.Add(this.Female_Button);
            this.PanelForEnrollee.Controls.Add(this.Male_Button);
            this.PanelForEnrollee.Controls.Add(this.Gender_Label);
            this.PanelForEnrollee.Controls.Add(this.AgeInput);
            this.PanelForEnrollee.Controls.Add(this.Age_Label);
            this.PanelForEnrollee.Controls.Add(this.MiddleInitialInput);
            this.PanelForEnrollee.Controls.Add(this.MiddleInitial_Label);
            this.PanelForEnrollee.Controls.Add(this.FirstNameInput);
            this.PanelForEnrollee.Controls.Add(this.FirstName_Label);
            this.PanelForEnrollee.Controls.Add(this.SurnameInput);
            this.PanelForEnrollee.Controls.Add(this.SurName_Label);
            this.PanelForEnrollee.Location = new System.Drawing.Point(12, 27);
            this.PanelForEnrollee.Name = "PanelForEnrollee";
            this.PanelForEnrollee.Size = new System.Drawing.Size(941, 389);
            this.PanelForEnrollee.TabIndex = 1;
            this.PanelForEnrollee.Visible = false;
            this.PanelForEnrollee.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelForEnrollee_Paint);
            // 
            // CivilStatus_ListBox
            // 
            this.CivilStatus_ListBox.FormattingEnabled = true;
            this.CivilStatus_ListBox.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Divorced",
            "Widowed"});
            this.CivilStatus_ListBox.Location = new System.Drawing.Point(481, 83);
            this.CivilStatus_ListBox.Name = "CivilStatus_ListBox";
            this.CivilStatus_ListBox.Size = new System.Drawing.Size(120, 56);
            this.CivilStatus_ListBox.TabIndex = 16;
            this.CivilStatus_ListBox.Click += new System.EventHandler(this.CivilStatus_ListBox_Click);
            this.CivilStatus_ListBox.SelectedIndexChanged += new System.EventHandler(this.CivilStatus_ListBox_SelectedIndexChanged);
            // 
            // CivilStatus_Label
            // 
            this.CivilStatus_Label.AutoSize = true;
            this.CivilStatus_Label.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CivilStatus_Label.Location = new System.Drawing.Point(407, 83);
            this.CivilStatus_Label.Name = "CivilStatus_Label";
            this.CivilStatus_Label.Size = new System.Drawing.Size(73, 15);
            this.CivilStatus_Label.TabIndex = 15;
            this.CivilStatus_Label.Text = "Civil Status:";
            // 
            // ImageImport_Button
            // 
            this.ImageImport_Button.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageImport_Button.Location = new System.Drawing.Point(68, 164);
            this.ImageImport_Button.Name = "ImageImport_Button";
            this.ImageImport_Button.Size = new System.Drawing.Size(75, 23);
            this.ImageImport_Button.TabIndex = 13;
            this.ImageImport_Button.Text = "Upload";
            this.ImageImport_Button.UseVisualStyleBackColor = true;
            this.ImageImport_Button.Click += new System.EventHandler(this.ImageImport_Button_Click);
            // 
            // Profile_Picture
            // 
            this.Profile_Picture.BackColor = System.Drawing.Color.White;
            this.Profile_Picture.Location = new System.Drawing.Point(27, 12);
            this.Profile_Picture.Name = "Profile_Picture";
            this.Profile_Picture.Size = new System.Drawing.Size(165, 146);
            this.Profile_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Profile_Picture.TabIndex = 12;
            this.Profile_Picture.TabStop = false;
            this.Profile_Picture.Click += new System.EventHandler(this.Profile_Picture_Click);
            // 
            // Submit_Button
            // 
            this.Submit_Button.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit_Button.Location = new System.Drawing.Point(228, 185);
            this.Submit_Button.Name = "Submit_Button";
            this.Submit_Button.Size = new System.Drawing.Size(75, 23);
            this.Submit_Button.TabIndex = 11;
            this.Submit_Button.Text = "Submit";
            this.Submit_Button.UseVisualStyleBackColor = true;
            this.Submit_Button.Click += new System.EventHandler(this.Submit_Button_Click);
            // 
            // Female_Button
            // 
            this.Female_Button.AccessibleRole = System.Windows.Forms.AccessibleRole.ListItem;
            this.Female_Button.AutoSize = true;
            this.Female_Button.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Female_Button.Location = new System.Drawing.Point(286, 137);
            this.Female_Button.Name = "Female_Button";
            this.Female_Button.Size = new System.Drawing.Size(73, 20);
            this.Female_Button.TabIndex = 10;
            this.Female_Button.TabStop = true;
            this.Female_Button.Text = "Female";
            this.Female_Button.UseVisualStyleBackColor = true;
            this.Female_Button.CheckedChanged += new System.EventHandler(this.Female_Button_CheckedChanged);
            // 
            // Male_Button
            // 
            this.Male_Button.AccessibleRole = System.Windows.Forms.AccessibleRole.ListItem;
            this.Male_Button.AutoSize = true;
            this.Male_Button.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Male_Button.Location = new System.Drawing.Point(286, 111);
            this.Male_Button.Name = "Male_Button";
            this.Male_Button.Size = new System.Drawing.Size(56, 20);
            this.Male_Button.TabIndex = 9;
            this.Male_Button.TabStop = true;
            this.Male_Button.Text = "Male";
            this.Male_Button.UseVisualStyleBackColor = true;
            this.Male_Button.CheckedChanged += new System.EventHandler(this.Male_Button_CheckedChanged);
            // 
            // Gender_Label
            // 
            this.Gender_Label.AutoSize = true;
            this.Gender_Label.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender_Label.Location = new System.Drawing.Point(225, 111);
            this.Gender_Label.Name = "Gender_Label";
            this.Gender_Label.Size = new System.Drawing.Size(54, 15);
            this.Gender_Label.TabIndex = 8;
            this.Gender_Label.Text = "Gender: ";
            // 
            // AgeInput
            // 
            this.AgeInput.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeInput.Location = new System.Drawing.Point(266, 70);
            this.AgeInput.Name = "AgeInput";
            this.AgeInput.Size = new System.Drawing.Size(100, 20);
            this.AgeInput.TabIndex = 7;
            // 
            // Age_Label
            // 
            this.Age_Label.AutoSize = true;
            this.Age_Label.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Age_Label.Location = new System.Drawing.Point(225, 72);
            this.Age_Label.Name = "Age_Label";
            this.Age_Label.Size = new System.Drawing.Size(35, 15);
            this.Age_Label.TabIndex = 6;
            this.Age_Label.Text = "Age: ";
            // 
            // MiddleInitialInput
            // 
            this.MiddleInitialInput.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiddleInitialInput.Location = new System.Drawing.Point(682, 33);
            this.MiddleInitialInput.Name = "MiddleInitialInput";
            this.MiddleInitialInput.Size = new System.Drawing.Size(100, 20);
            this.MiddleInitialInput.TabIndex = 5;
            // 
            // MiddleInitial_Label
            // 
            this.MiddleInitial_Label.AutoSize = true;
            this.MiddleInitial_Label.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiddleInitial_Label.Location = new System.Drawing.Point(596, 35);
            this.MiddleInitial_Label.Name = "MiddleInitial_Label";
            this.MiddleInitial_Label.Size = new System.Drawing.Size(80, 15);
            this.MiddleInitial_Label.TabIndex = 4;
            this.MiddleInitial_Label.Text = "Middle Initial:";
            // 
            // FirstNameInput
            // 
            this.FirstNameInput.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameInput.Location = new System.Drawing.Point(481, 33);
            this.FirstNameInput.Name = "FirstNameInput";
            this.FirstNameInput.Size = new System.Drawing.Size(100, 20);
            this.FirstNameInput.TabIndex = 3;
            // 
            // FirstName_Label
            // 
            this.FirstName_Label.AutoSize = true;
            this.FirstName_Label.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName_Label.Location = new System.Drawing.Point(407, 35);
            this.FirstName_Label.Name = "FirstName_Label";
            this.FirstName_Label.Size = new System.Drawing.Size(71, 15);
            this.FirstName_Label.TabIndex = 2;
            this.FirstName_Label.Text = "First Name:";
            // 
            // SurnameInput
            // 
            this.SurnameInput.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurnameInput.Location = new System.Drawing.Point(293, 33);
            this.SurnameInput.Name = "SurnameInput";
            this.SurnameInput.Size = new System.Drawing.Size(100, 20);
            this.SurnameInput.TabIndex = 1;
            this.SurnameInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SurName_Label
            // 
            this.SurName_Label.AutoSize = true;
            this.SurName_Label.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurName_Label.Location = new System.Drawing.Point(225, 35);
            this.SurName_Label.Name = "SurName_Label";
            this.SurName_Label.Size = new System.Drawing.Size(62, 15);
            this.SurName_Label.TabIndex = 0;
            this.SurName_Label.Text = "Surname:";
            // 
            // CMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 428);
            this.Controls.Add(this.PanelForEnrollee);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CMS";
            this.Text = "CMS";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CMS_FormClosed_1);
            this.Load += new System.EventHandler(this.CMS_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PanelForEnrollee.ResumeLayout(false);
            this.PanelForEnrollee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Profile_Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem addEnrolleeToolStripMenuItem;
        private System.Windows.Forms.Panel PanelForEnrollee;
        private System.Windows.Forms.RadioButton Female_Button;
        private System.Windows.Forms.RadioButton Male_Button;
        private System.Windows.Forms.Label Gender_Label;
        private System.Windows.Forms.TextBox AgeInput;
        private System.Windows.Forms.Label Age_Label;
        private System.Windows.Forms.TextBox MiddleInitialInput;
        private System.Windows.Forms.Label MiddleInitial_Label;
        private System.Windows.Forms.TextBox FirstNameInput;
        private System.Windows.Forms.Label FirstName_Label;
        private System.Windows.Forms.TextBox SurnameInput;
        private System.Windows.Forms.Label SurName_Label;
        private System.Windows.Forms.Button Submit_Button;
        private System.Windows.Forms.PictureBox Profile_Picture;
        private System.Windows.Forms.Button ImageImport_Button;
        private System.Windows.Forms.ToolStripMenuItem developedByJulianLugodToolStripMenuItem;
        private System.Windows.Forms.Label CivilStatus_Label;
        private System.Windows.Forms.ListBox CivilStatus_ListBox;
    }
}