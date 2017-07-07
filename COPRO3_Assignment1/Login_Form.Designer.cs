namespace COPRO3_Assignment1
{
    partial class Login_Form
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
            this.Label_Username = new System.Windows.Forms.Label();
            this.Label_Password = new System.Windows.Forms.Label();
            this.Input_Username = new System.Windows.Forms.TextBox();
            this.Input_Password = new System.Windows.Forms.TextBox();
            this.Login_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_Username
            // 
            this.Label_Username.AutoSize = true;
            this.Label_Username.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Username.Location = new System.Drawing.Point(106, 60);
            this.Label_Username.Name = "Label_Username";
            this.Label_Username.Size = new System.Drawing.Size(88, 18);
            this.Label_Username.TabIndex = 0;
            this.Label_Username.Text = "Username: ";
            // 
            // Label_Password
            // 
            this.Label_Password.AutoSize = true;
            this.Label_Password.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Password.Location = new System.Drawing.Point(106, 95);
            this.Label_Password.Name = "Label_Password";
            this.Label_Password.Size = new System.Drawing.Size(82, 18);
            this.Label_Password.TabIndex = 1;
            this.Label_Password.Text = "Password:";
            // 
            // Input_Username
            // 
            this.Input_Username.AccessibleDescription = "Input Username";
            this.Input_Username.Location = new System.Drawing.Point(189, 60);
            this.Input_Username.Name = "Input_Username";
            this.Input_Username.Size = new System.Drawing.Size(100, 23);
            this.Input_Username.TabIndex = 2;
            this.Input_Username.TextChanged += new System.EventHandler(this.Input_Username_TextChanged);
            // 
            // Input_Password
            // 
            this.Input_Password.AccessibleDescription = "Input Password";
            this.Input_Password.Location = new System.Drawing.Point(189, 94);
            this.Input_Password.Name = "Input_Password";
            this.Input_Password.PasswordChar = '*';
            this.Input_Password.Size = new System.Drawing.Size(100, 23);
            this.Input_Password.TabIndex = 3;
            this.Input_Password.TextChanged += new System.EventHandler(this.Input_Password_TextChanged);
            // 
            // Login_Button
            // 
            this.Login_Button.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Button.Location = new System.Drawing.Point(189, 132);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(100, 27);
            this.Login_Button.TabIndex = 4;
            this.Login_Button.Text = "Login";
            this.Login_Button.UseVisualStyleBackColor = true;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(411, 206);
            this.Controls.Add(this.Login_Button);
            this.Controls.Add(this.Input_Password);
            this.Controls.Add(this.Input_Username);
            this.Controls.Add(this.Label_Password);
            this.Controls.Add(this.Label_Username);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login_Form";
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_Form_FormClosed);
            this.Load += new System.EventHandler(this.Login_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Username;
        private System.Windows.Forms.Label Label_Password;
        private System.Windows.Forms.TextBox Input_Username;
        private System.Windows.Forms.TextBox Input_Password;
        private System.Windows.Forms.Button Login_Button;
    }
}

