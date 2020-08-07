namespace HR_Task
{
    partial class SignUpPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpPage));
            this.SP_Username = new System.Windows.Forms.TextBox();
            this.SP_Password = new System.Windows.Forms.TextBox();
            this.SP_CPassword = new System.Windows.Forms.TextBox();
            this.SP_Email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.SubmitCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SP_Signup = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Role = new System.Windows.Forms.ComboBox();
            this.RandomCode = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SP_Username
            // 
            this.SP_Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SP_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SP_Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.SP_Username.Location = new System.Drawing.Point(118, 32);
            this.SP_Username.Name = "SP_Username";
            this.SP_Username.Size = new System.Drawing.Size(204, 26);
            this.SP_Username.TabIndex = 1;
            // 
            // SP_Password
            // 
            this.SP_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SP_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.SP_Password.Location = new System.Drawing.Point(120, 131);
            this.SP_Password.Name = "SP_Password";
            this.SP_Password.PasswordChar = '*';
            this.SP_Password.Size = new System.Drawing.Size(204, 26);
            this.SP_Password.TabIndex = 3;
            // 
            // SP_CPassword
            // 
            this.SP_CPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SP_CPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.SP_CPassword.Location = new System.Drawing.Point(118, 182);
            this.SP_CPassword.Name = "SP_CPassword";
            this.SP_CPassword.PasswordChar = '*';
            this.SP_CPassword.Size = new System.Drawing.Size(204, 26);
            this.SP_CPassword.TabIndex = 4;
            // 
            // SP_Email
            // 
            this.SP_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SP_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.SP_Email.Location = new System.Drawing.Point(118, 82);
            this.SP_Email.Name = "SP_Email";
            this.SP_Email.Size = new System.Drawing.Size(204, 26);
            this.SP_Email.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(12, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.label3.Location = new System.Drawing.Point(12, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm\r\nPassword";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.Email.Location = new System.Drawing.Point(12, 87);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(48, 20);
            this.Email.TabIndex = 2;
            this.Email.Text = "Email";
            // 
            // SubmitCode
            // 
            this.SubmitCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubmitCode.Location = new System.Drawing.Point(222, 303);
            this.SubmitCode.Name = "SubmitCode";
            this.SubmitCode.Size = new System.Drawing.Size(100, 26);
            this.SubmitCode.TabIndex = 6;
            this.SubmitCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.label5.Location = new System.Drawing.Point(207, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Enter Verification Code";
            // 
            // SP_Signup
            // 
            this.SP_Signup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(226)))));
            this.SP_Signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SP_Signup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(226)))));
            this.SP_Signup.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SP_Signup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(226)))));
            this.SP_Signup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(226)))));
            this.SP_Signup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SP_Signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SP_Signup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.SP_Signup.Location = new System.Drawing.Point(18, 374);
            this.SP_Signup.Name = "SP_Signup";
            this.SP_Signup.Size = new System.Drawing.Size(306, 33);
            this.SP_Signup.TabIndex = 7;
            this.SP_Signup.TabStop = false;
            this.SP_Signup.Text = "Sign Up";
            this.SP_Signup.UseVisualStyleBackColor = false;
            this.SP_Signup.Click += new System.EventHandler(this.SP_Signup_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.label4.Location = new System.Drawing.Point(14, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Role";
            // 
            // Role
            // 
            this.Role.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Role.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.Role.FormattingEnabled = true;
            this.Role.Items.AddRange(new object[] {
            "Employer",
            "Jobseeker "});
            this.Role.Location = new System.Drawing.Point(118, 232);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(204, 28);
            this.Role.TabIndex = 5;
            // 
            // RandomCode
            // 
            this.RandomCode.Cursor = System.Windows.Forms.Cursors.No;
            this.RandomCode.Enabled = false;
            this.RandomCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RandomCode.Location = new System.Drawing.Point(116, 303);
            this.RandomCode.Name = "RandomCode";
            this.RandomCode.ReadOnly = true;
            this.RandomCode.Size = new System.Drawing.Size(100, 26);
            this.RandomCode.TabIndex = 0;
            this.RandomCode.TabStop = false;
            this.RandomCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.Login.Location = new System.Drawing.Point(123, 439);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(199, 13);
            this.Login.TabIndex = 8;
            this.Login.Text = "Already have an account? Click to Login";
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // SignUpPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(191)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(334, 461);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Role);
            this.Controls.Add(this.SP_Signup);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RandomCode);
            this.Controls.Add(this.SubmitCode);
            this.Controls.Add(this.SP_Email);
            this.Controls.Add(this.SP_CPassword);
            this.Controls.Add(this.SP_Password);
            this.Controls.Add(this.SP_Username);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(350, 500);
            this.MinimumSize = new System.Drawing.Size(350, 500);
            this.Name = "SignUpPage";
            this.Text = "Sign Up";
            this.Load += new System.EventHandler(this.SignUpPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SP_Username;
        private System.Windows.Forms.TextBox SP_Password;
        private System.Windows.Forms.TextBox SP_CPassword;
        private System.Windows.Forms.TextBox SP_Email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox SubmitCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SP_Signup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Role;
        private System.Windows.Forms.TextBox RandomCode;
        private System.Windows.Forms.Label Login;
    }
}