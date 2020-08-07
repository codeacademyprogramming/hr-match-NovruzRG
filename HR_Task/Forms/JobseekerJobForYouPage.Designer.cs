namespace HR_Task.Forms
{
    partial class JobseekerJobForYouPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobseekerJobForYouPage));
            this.VacancyForYou = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.VacancyForYou)).BeginInit();
            this.SuspendLayout();
            // 
            // VacancyForYou
            // 
            this.VacancyForYou.AllowUserToAddRows = false;
            this.VacancyForYou.AllowUserToDeleteRows = false;
            this.VacancyForYou.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(191)))), ((int)(((byte)(139)))));
            this.VacancyForYou.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VacancyForYou.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VacancyForYou.Location = new System.Drawing.Point(0, 0);
            this.VacancyForYou.Name = "VacancyForYou";
            this.VacancyForYou.ReadOnly = true;
            this.VacancyForYou.Size = new System.Drawing.Size(804, 461);
            this.VacancyForYou.TabIndex = 2;
            this.VacancyForYou.TabStop = false;
            // 
            // JobseekerJobForYouPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(191)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.VacancyForYou);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(820, 500);
            this.MinimumSize = new System.Drawing.Size(820, 500);
            this.Name = "JobseekerJobForYouPage";
            this.Text = "Jobs based your CV";
            this.Load += new System.EventHandler(this.JobseekerJobForYouPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VacancyForYou)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView VacancyForYou;
    }
}