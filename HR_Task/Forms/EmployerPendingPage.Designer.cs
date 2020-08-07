namespace HR_Task.Forms
{
    partial class EmployerPendingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployerPendingPage));
            this.PendingRequests = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PendingRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // PendingRequests
            // 
            this.PendingRequests.AllowUserToAddRows = false;
            this.PendingRequests.AllowUserToDeleteRows = false;
            this.PendingRequests.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(191)))), ((int)(((byte)(139)))));
            this.PendingRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PendingRequests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PendingRequests.Location = new System.Drawing.Point(0, 0);
            this.PendingRequests.Name = "PendingRequests";
            this.PendingRequests.ReadOnly = true;
            this.PendingRequests.Size = new System.Drawing.Size(804, 461);
            this.PendingRequests.TabIndex = 3;
            this.PendingRequests.TabStop = false;
            // 
            // EmployerPendingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(191)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.PendingRequests);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(820, 500);
            this.MinimumSize = new System.Drawing.Size(820, 500);
            this.Name = "EmployerPendingPage";
            this.Text = "Pending requests";
            this.Load += new System.EventHandler(this.EmployerPendingPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PendingRequests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PendingRequests;
    }
}