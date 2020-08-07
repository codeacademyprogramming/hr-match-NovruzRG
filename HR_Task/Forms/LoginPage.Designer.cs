namespace HR_Task
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.LI_Login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LI_Password = new System.Windows.Forms.TextBox();
            this.LI_Username = new System.Windows.Forms.TextBox();
            this.Signup = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LI_Login
            // 
            this.LI_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(226)))));
            this.LI_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LI_Login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(226)))));
            this.LI_Login.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LI_Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(226)))));
            this.LI_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(226)))));
            this.LI_Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LI_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LI_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.LI_Login.Location = new System.Drawing.Point(16, 307);
            this.LI_Login.Name = "LI_Login";
            this.LI_Login.Size = new System.Drawing.Size(306, 33);
            this.LI_Login.TabIndex = 3;
            this.LI_Login.TabStop = false;
            this.LI_Login.Text = "Login";
            this.LI_Login.UseVisualStyleBackColor = false;
            this.LI_Login.Click += new System.EventHandler(this.LI_Login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(12, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(12, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Username";
            // 
            // LI_Password
            // 
            this.LI_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LI_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.LI_Password.Location = new System.Drawing.Point(118, 176);
            this.LI_Password.Name = "LI_Password";
            this.LI_Password.PasswordChar = '*';
            this.LI_Password.Size = new System.Drawing.Size(204, 26);
            this.LI_Password.TabIndex = 2;
            // 
            // LI_Username
            // 
            this.LI_Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LI_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LI_Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.LI_Username.Location = new System.Drawing.Point(118, 116);
            this.LI_Username.Name = "LI_Username";
            this.LI_Username.Size = new System.Drawing.Size(204, 26);
            this.LI_Username.TabIndex = 1;
            // 
            // Signup
            // 
            this.Signup.AutoSize = true;
            this.Signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Signup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.Signup.Location = new System.Drawing.Point(123, 439);
            this.Signup.Name = "Signup";
            this.Signup.Size = new System.Drawing.Size(199, 13);
            this.Signup.TabIndex = 4;
            this.Signup.Text = "Don\'t have an account? Click to Sign up";
            this.Signup.Click += new System.EventHandler(this.Signup_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(191)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(334, 461);
            this.Controls.Add(this.Signup);
            this.Controls.Add(this.LI_Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LI_Password);
            this.Controls.Add(this.LI_Username);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(350, 500);
            this.MinimumSize = new System.Drawing.Size(350, 500);
            this.Name = "LoginPage";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LI_Login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LI_Password;
        private System.Windows.Forms.TextBox LI_Username;
        private System.Windows.Forms.Label Signup;
    }
}