namespace HR_Task.Forms
{
    partial class JobseekerSearchPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobseekerSearchPage));
            this.searchByJob = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ActiveVacancy = new System.Windows.Forms.DataGridView();
            this.searchVacancyParams = new System.Windows.Forms.Button();
            this.byCategoryJob = new System.Windows.Forms.ComboBox();
            this.byExperienceJob = new System.Windows.Forms.ComboBox();
            this.byEducationJob = new System.Windows.Forms.ComboBox();
            this.byCityJob = new System.Windows.Forms.ComboBox();
            this.bySalaryJob = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ActiveVacancy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bySalaryJob)).BeginInit();
            this.SuspendLayout();
            // 
            // searchByJob
            // 
            this.searchByJob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchByJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchByJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchByJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.searchByJob.FormattingEnabled = true;
            this.searchByJob.Items.AddRange(new object[] {
            "Category",
            "City",
            "Education",
            "Salary",
            "Experience"});
            this.searchByJob.Location = new System.Drawing.Point(118, 47);
            this.searchByJob.Name = "searchByJob";
            this.searchByJob.Size = new System.Drawing.Size(204, 28);
            this.searchByJob.TabIndex = 1;
            this.searchByJob.SelectedIndexChanged += new System.EventHandler(this.searchByJob_SelectedIndexChanged_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.label8.Location = new System.Drawing.Point(12, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 46;
            this.label8.Text = "Search by";
            // 
            // ActiveVacancy
            // 
            this.ActiveVacancy.AllowUserToAddRows = false;
            this.ActiveVacancy.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ActiveVacancy.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ActiveVacancy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ActiveVacancy.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(191)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ActiveVacancy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ActiveVacancy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActiveVacancy.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ActiveVacancy.Location = new System.Drawing.Point(0, 115);
            this.ActiveVacancy.Name = "ActiveVacancy";
            this.ActiveVacancy.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ActiveVacancy.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ActiveVacancy.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.ActiveVacancy.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ActiveVacancy.Size = new System.Drawing.Size(804, 346);
            this.ActiveVacancy.TabIndex = 43;
            this.ActiveVacancy.TabStop = false;
            // 
            // searchVacancyParams
            // 
            this.searchVacancyParams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(226)))));
            this.searchVacancyParams.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchVacancyParams.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(226)))));
            this.searchVacancyParams.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.searchVacancyParams.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(226)))));
            this.searchVacancyParams.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(226)))));
            this.searchVacancyParams.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchVacancyParams.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchVacancyParams.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.searchVacancyParams.Location = new System.Drawing.Point(671, 12);
            this.searchVacancyParams.Name = "searchVacancyParams";
            this.searchVacancyParams.Size = new System.Drawing.Size(121, 94);
            this.searchVacancyParams.TabIndex = 3;
            this.searchVacancyParams.TabStop = false;
            this.searchVacancyParams.Text = "Search";
            this.searchVacancyParams.UseVisualStyleBackColor = false;
            this.searchVacancyParams.Click += new System.EventHandler(this.searchVacancyParams_Click);
            // 
            // byCategoryJob
            // 
            this.byCategoryJob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.byCategoryJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.byCategoryJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.byCategoryJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.byCategoryJob.FormattingEnabled = true;
            this.byCategoryJob.Items.AddRange(new object[] {
            "Banking",
            "IT",
            "Programing",
            "Teacher",
            "Driver"});
            this.byCategoryJob.Location = new System.Drawing.Point(389, 47);
            this.byCategoryJob.Name = "byCategoryJob";
            this.byCategoryJob.Size = new System.Drawing.Size(204, 28);
            this.byCategoryJob.TabIndex = 2;
            this.byCategoryJob.TabStop = false;
            this.byCategoryJob.Visible = false;
            // 
            // byExperienceJob
            // 
            this.byExperienceJob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.byExperienceJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.byExperienceJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.byExperienceJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.byExperienceJob.FormattingEnabled = true;
            this.byExperienceJob.Items.AddRange(new object[] {
            "1-3 years",
            "3-5 years",
            "Less than 1 year",
            "More than 5 years"});
            this.byExperienceJob.Location = new System.Drawing.Point(389, 47);
            this.byExperienceJob.Name = "byExperienceJob";
            this.byExperienceJob.Size = new System.Drawing.Size(204, 28);
            this.byExperienceJob.TabIndex = 2;
            this.byExperienceJob.TabStop = false;
            this.byExperienceJob.Visible = false;
            // 
            // byEducationJob
            // 
            this.byEducationJob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.byEducationJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.byEducationJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.byEducationJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.byEducationJob.FormattingEnabled = true;
            this.byEducationJob.Items.AddRange(new object[] {
            "Bachelor\'s degree",
            "Master\'s degree",
            "Doctoral degree"});
            this.byEducationJob.Location = new System.Drawing.Point(389, 47);
            this.byEducationJob.Name = "byEducationJob";
            this.byEducationJob.Size = new System.Drawing.Size(204, 28);
            this.byEducationJob.TabIndex = 2;
            this.byEducationJob.TabStop = false;
            this.byEducationJob.Visible = false;
            // 
            // byCityJob
            // 
            this.byCityJob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.byCityJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.byCityJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.byCityJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.byCityJob.FormattingEnabled = true;
            this.byCityJob.Items.AddRange(new object[] {
            "Ağcabədi",
            "Ağdam",
            "Ağdaş",
            "Ağdərə",
            "Ağstafa",
            "Ağsu",
            "Astara",
            "Babək",
            "Bakı",
            "Balakən",
            "Beyləqan",
            "Bərdə",
            "Biləsuvar",
            "Cəbrayıl",
            "Cəlilabad",
            "Culfa",
            "Daşkəsən",
            "Dəliməmmədli",
            "Əsgəran",
            "Füzuli",
            "Gədəbəy",
            "Gəncə",
            "Goranboy",
            "Göyçay",
            "Göygöl",
            "Göytəpə",
            "Hacıqabul",
            "Horadiz",
            "Xaçmaz",
            "Xankəndi",
            "Xocalı",
            "Xocavənd",
            "Xırdalan",
            "Xızı",
            "Xudat",
            "İmişli",
            "İsmayıllı",
            "Kəlbəcər",
            "Kürdəmir",
            "Qax",
            "Qazax",
            "Qəbələ",
            "Qobustan",
            "Qovlar",
            "Quba",
            "Qubadlı",
            "Qusar",
            "Laçın",
            "Lerik",
            "Lənkəran",
            "Liman",
            "Masallı",
            "Mingəçevir",
            "Naftalan",
            "Naxçıvan",
            "Neftçala",
            "Oğuz",
            "Ordubad",
            "Saatlı",
            "Sabirabad",
            "Salyan",
            "Samux",
            "Siyəzən",
            "Sumqayıt",
            "Şabran",
            "Şahbuz",
            "Şamaxı",
            "Şəki",
            "Şəmkir",
            "Şərur",
            "Şirvan",
            "Şuşa",
            "Tərtər",
            "Tovuz",
            "Ucar",
            "Yardımlı",
            "Yevlax",
            "Zaqatala",
            "Zəngilan",
            "Zərdab"});
            this.byCityJob.Location = new System.Drawing.Point(389, 47);
            this.byCityJob.Name = "byCityJob";
            this.byCityJob.Size = new System.Drawing.Size(204, 28);
            this.byCityJob.TabIndex = 2;
            this.byCityJob.TabStop = false;
            this.byCityJob.Visible = false;
            // 
            // bySalaryJob
            // 
            this.bySalaryJob.AllowDrop = true;
            this.bySalaryJob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bySalaryJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bySalaryJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.bySalaryJob.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bySalaryJob.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.bySalaryJob.Location = new System.Drawing.Point(389, 47);
            this.bySalaryJob.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.bySalaryJob.Minimum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.bySalaryJob.Name = "bySalaryJob";
            this.bySalaryJob.ReadOnly = true;
            this.bySalaryJob.Size = new System.Drawing.Size(204, 26);
            this.bySalaryJob.TabIndex = 2;
            this.bySalaryJob.TabStop = false;
            this.bySalaryJob.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.bySalaryJob.Visible = false;
            // 
            // JobseekerSearchPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(191)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.bySalaryJob);
            this.Controls.Add(this.byCategoryJob);
            this.Controls.Add(this.byExperienceJob);
            this.Controls.Add(this.byEducationJob);
            this.Controls.Add(this.byCityJob);
            this.Controls.Add(this.searchByJob);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ActiveVacancy);
            this.Controls.Add(this.searchVacancyParams);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(389, 47);
            this.MaximumSize = new System.Drawing.Size(820, 500);
            this.MinimumSize = new System.Drawing.Size(820, 500);
            this.Name = "JobseekerSearchPage";
            this.Text = "Search Vacancies by Categories";
            ((System.ComponentModel.ISupportInitialize)(this.ActiveVacancy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bySalaryJob)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox searchByJob;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.DataGridView ActiveVacancy;
        private System.Windows.Forms.Button searchVacancyParams;
        private System.Windows.Forms.ComboBox byCategoryJob;
        private System.Windows.Forms.ComboBox byExperienceJob;
        private System.Windows.Forms.ComboBox byEducationJob;
        private System.Windows.Forms.ComboBox byCityJob;
        private System.Windows.Forms.NumericUpDown bySalaryJob;
    }
}