namespace HR_Task.Forms
{
    partial class JobseekerAllVacancyPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobseekerAllVacancyPage));
            this.ActiveVacancy = new System.Windows.Forms.DataGridView();
            this.vacancyID = new System.Windows.Forms.NumericUpDown();
            this.sendRequest = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ActiveVacancy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacancyID)).BeginInit();
            this.SuspendLayout();
            // 
            // ActiveVacancy
            // 
            this.ActiveVacancy.AllowUserToAddRows = false;
            this.ActiveVacancy.AllowUserToDeleteRows = false;
            this.ActiveVacancy.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(191)))), ((int)(((byte)(139)))));
            this.ActiveVacancy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActiveVacancy.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ActiveVacancy.Location = new System.Drawing.Point(0, 115);
            this.ActiveVacancy.Name = "ActiveVacancy";
            this.ActiveVacancy.ReadOnly = true;
            this.ActiveVacancy.Size = new System.Drawing.Size(804, 346);
            this.ActiveVacancy.TabIndex = 1;
            this.ActiveVacancy.TabStop = false;
            // 
            // vacancyID
            // 
            this.vacancyID.AllowDrop = true;
            this.vacancyID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vacancyID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vacancyID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.vacancyID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.vacancyID.Location = new System.Drawing.Point(435, 46);
            this.vacancyID.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.vacancyID.Name = "vacancyID";
            this.vacancyID.ReadOnly = true;
            this.vacancyID.Size = new System.Drawing.Size(204, 26);
            this.vacancyID.TabIndex = 1;
            // 
            // sendRequest
            // 
            this.sendRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(226)))));
            this.sendRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendRequest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(226)))));
            this.sendRequest.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.sendRequest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(226)))));
            this.sendRequest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(226)))));
            this.sendRequest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sendRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendRequest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.sendRequest.Location = new System.Drawing.Point(671, 14);
            this.sendRequest.Name = "sendRequest";
            this.sendRequest.Size = new System.Drawing.Size(121, 94);
            this.sendRequest.TabIndex = 2;
            this.sendRequest.TabStop = false;
            this.sendRequest.Text = "Request";
            this.sendRequest.UseVisualStyleBackColor = false;
            this.sendRequest.Click += new System.EventHandler(this.sendRequest_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.label8.Location = new System.Drawing.Point(167, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(248, 20);
            this.label8.TabIndex = 45;
            this.label8.Text = "Input vacancy ID for send request";
            // 
            // JobseekerAllVacancyPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(191)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.vacancyID);
            this.Controls.Add(this.sendRequest);
            this.Controls.Add(this.ActiveVacancy);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(820, 500);
            this.MinimumSize = new System.Drawing.Size(820, 500);
            this.Name = "JobseekerAllVacancyPage";
            this.Text = "All Vacancy List";
            this.Load += new System.EventHandler(this.AllVacancyPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ActiveVacancy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacancyID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ActiveVacancy;
        private System.Windows.Forms.NumericUpDown vacancyID;
        private System.Windows.Forms.Button sendRequest;
        private System.Windows.Forms.Label label8;
    }
}