namespace HR_Task.Forms
{
    partial class EmployerMainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployerMainPage));
            this.addVacancy = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.pendingRequest = new System.Windows.Forms.Button();
            this.logOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.activeUser = new System.Windows.Forms.Label();
            this.myVacancies = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addVacancy
            // 
            this.addVacancy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(226)))));
            this.addVacancy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addVacancy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addVacancy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addVacancy.Location = new System.Drawing.Point(12, 91);
            this.addVacancy.Name = "addVacancy";
            this.addVacancy.Size = new System.Drawing.Size(310, 33);
            this.addVacancy.TabIndex = 1;
            this.addVacancy.Text = "Add Vacancy";
            this.addVacancy.UseVisualStyleBackColor = false;
            this.addVacancy.Click += new System.EventHandler(this.addVacancy_Click);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(226)))));
            this.Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search.Location = new System.Drawing.Point(12, 130);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(310, 33);
            this.Search.TabIndex = 2;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // pendingRequest
            // 
            this.pendingRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(226)))));
            this.pendingRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pendingRequest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pendingRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pendingRequest.Location = new System.Drawing.Point(12, 169);
            this.pendingRequest.Name = "pendingRequest";
            this.pendingRequest.Size = new System.Drawing.Size(310, 33);
            this.pendingRequest.TabIndex = 3;
            this.pendingRequest.Text = "Pending requests";
            this.pendingRequest.UseVisualStyleBackColor = false;
            this.pendingRequest.Click += new System.EventHandler(this.pendingRequest_Click);
            // 
            // logOut
            // 
            this.logOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(226)))));
            this.logOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logOut.Location = new System.Drawing.Point(12, 416);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(310, 33);
            this.logOut.TabIndex = 5;
            this.logOut.Text = "Log Out";
            this.logOut.UseVisualStyleBackColor = false;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome - ";
            // 
            // activeUser
            // 
            this.activeUser.AutoSize = true;
            this.activeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.activeUser.Location = new System.Drawing.Point(109, 31);
            this.activeUser.Name = "activeUser";
            this.activeUser.Size = new System.Drawing.Size(97, 24);
            this.activeUser.TabIndex = 1;
            this.activeUser.Text = "Username";
            // 
            // myVacancies
            // 
            this.myVacancies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(226)))));
            this.myVacancies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myVacancies.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.myVacancies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.myVacancies.Location = new System.Drawing.Point(12, 208);
            this.myVacancies.Name = "myVacancies";
            this.myVacancies.Size = new System.Drawing.Size(310, 33);
            this.myVacancies.TabIndex = 4;
            this.myVacancies.Text = "My Vacancies";
            this.myVacancies.UseVisualStyleBackColor = false;
            this.myVacancies.Click += new System.EventHandler(this.myVacancies_Click);
            // 
            // EmployerMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(191)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(334, 461);
            this.Controls.Add(this.myVacancies);
            this.Controls.Add(this.activeUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logOut);
            this.Controls.Add(this.pendingRequest);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.addVacancy);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(350, 500);
            this.MinimumSize = new System.Drawing.Size(350, 500);
            this.Name = "EmployerMainPage";
            this.Text = "Employer Main Page";
            this.Load += new System.EventHandler(this.EmployerMainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addVacancy;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button pendingRequest;
        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label activeUser;
        private System.Windows.Forms.Button myVacancies;
    }
}