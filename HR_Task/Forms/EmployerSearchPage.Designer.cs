namespace HR_Task.Forms
{
    partial class EmployerSearchPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployerSearchPage));
            this.ActiveCV = new System.Windows.Forms.DataGridView();
            this.searchBy = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.searchCvParams = new System.Windows.Forms.Button();
            this.bySalary = new System.Windows.Forms.NumericUpDown();
            this.byCategory = new System.Windows.Forms.ComboBox();
            this.byExperience = new System.Windows.Forms.ComboBox();
            this.byEducation = new System.Windows.Forms.ComboBox();
            this.byCity = new System.Windows.Forms.ComboBox();
            this.byGender = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ActiveCV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bySalary)).BeginInit();
            this.SuspendLayout();
            // 
            // ActiveCV
            // 
            this.ActiveCV.AllowUserToAddRows = false;
            this.ActiveCV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ActiveCV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ActiveCV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ActiveCV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(191)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ActiveCV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ActiveCV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActiveCV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ActiveCV.Location = new System.Drawing.Point(0, 115);
            this.ActiveCV.Name = "ActiveCV";
            this.ActiveCV.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ActiveCV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ActiveCV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.ActiveCV.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ActiveCV.Size = new System.Drawing.Size(804, 346);
            this.ActiveCV.TabIndex = 0;
            this.ActiveCV.TabStop = false;
            // 
            // searchBy
            // 
            this.searchBy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.searchBy.FormattingEnabled = true;
            this.searchBy.Items.AddRange(new object[] {
            "Category",
            "City",
            "Education",
            "Salary",
            "Experience",
            "Gender"});
            this.searchBy.Location = new System.Drawing.Point(118, 47);
            this.searchBy.Name = "searchBy";
            this.searchBy.Size = new System.Drawing.Size(204, 28);
            this.searchBy.TabIndex = 1;
            this.searchBy.SelectedIndexChanged += new System.EventHandler(this.searchBy_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.label8.Location = new System.Drawing.Point(12, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 38;
            this.label8.Text = "Search by";
            // 
            // searchCvParams
            // 
            this.searchCvParams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(226)))));
            this.searchCvParams.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchCvParams.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(226)))));
            this.searchCvParams.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.searchCvParams.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(226)))));
            this.searchCvParams.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(226)))));
            this.searchCvParams.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchCvParams.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchCvParams.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.searchCvParams.Location = new System.Drawing.Point(671, 12);
            this.searchCvParams.Name = "searchCvParams";
            this.searchCvParams.Size = new System.Drawing.Size(121, 94);
            this.searchCvParams.TabIndex = 3;
            this.searchCvParams.TabStop = false;
            this.searchCvParams.Text = "Search";
            this.searchCvParams.UseVisualStyleBackColor = false;
            this.searchCvParams.Click += new System.EventHandler(this.searchCvParams_Click);
            // 
            // bySalary
            // 
            this.bySalary.AllowDrop = true;
            this.bySalary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bySalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bySalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.bySalary.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bySalary.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.bySalary.Location = new System.Drawing.Point(389, 47);
            this.bySalary.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.bySalary.Minimum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.bySalary.Name = "bySalary";
            this.bySalary.ReadOnly = true;
            this.bySalary.Size = new System.Drawing.Size(204, 26);
            this.bySalary.TabIndex = 2;
            this.bySalary.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.bySalary.Visible = false;
            // 
            // byCategory
            // 
            this.byCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.byCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.byCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.byCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.byCategory.FormattingEnabled = true;
            this.byCategory.Items.AddRange(new object[] {
            "Banking",
            "IT",
            "Programing",
            "Teacher",
            "Driver"});
            this.byCategory.Location = new System.Drawing.Point(389, 47);
            this.byCategory.Name = "byCategory";
            this.byCategory.Size = new System.Drawing.Size(204, 28);
            this.byCategory.TabIndex = 2;
            this.byCategory.Visible = false;
            // 
            // byExperience
            // 
            this.byExperience.Cursor = System.Windows.Forms.Cursors.Hand;
            this.byExperience.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.byExperience.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.byExperience.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.byExperience.FormattingEnabled = true;
            this.byExperience.Items.AddRange(new object[] {
            "1-3 years",
            "3-5 years",
            "Less than 1 year",
            "More than 5 years"});
            this.byExperience.Location = new System.Drawing.Point(389, 47);
            this.byExperience.Name = "byExperience";
            this.byExperience.Size = new System.Drawing.Size(204, 28);
            this.byExperience.TabIndex = 2;
            this.byExperience.Visible = false;
            // 
            // byEducation
            // 
            this.byEducation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.byEducation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.byEducation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.byEducation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.byEducation.FormattingEnabled = true;
            this.byEducation.Items.AddRange(new object[] {
            "Bachelor\'s degree",
            "Master\'s degree",
            "Doctoral degree"});
            this.byEducation.Location = new System.Drawing.Point(389, 47);
            this.byEducation.Name = "byEducation";
            this.byEducation.Size = new System.Drawing.Size(204, 28);
            this.byEducation.TabIndex = 2;
            this.byEducation.Visible = false;
            // 
            // byCity
            // 
            this.byCity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.byCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.byCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.byCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.byCity.FormattingEnabled = true;
            this.byCity.Items.AddRange(new object[] {
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
            this.byCity.Location = new System.Drawing.Point(389, 47);
            this.byCity.Name = "byCity";
            this.byCity.Size = new System.Drawing.Size(204, 28);
            this.byCity.TabIndex = 2;
            this.byCity.Visible = false;
            // 
            // byGender
            // 
            this.byGender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.byGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.byGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.byGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.byGender.FormattingEnabled = true;
            this.byGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.byGender.Location = new System.Drawing.Point(389, 47);
            this.byGender.Name = "byGender";
            this.byGender.Size = new System.Drawing.Size(204, 28);
            this.byGender.TabIndex = 2;
            this.byGender.Visible = false;
            // 
            // EmployerSearchPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(191)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.bySalary);
            this.Controls.Add(this.byCategory);
            this.Controls.Add(this.byExperience);
            this.Controls.Add(this.byEducation);
            this.Controls.Add(this.byCity);
            this.Controls.Add(this.byGender);
            this.Controls.Add(this.searchBy);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ActiveCV);
            this.Controls.Add(this.searchCvParams);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(820, 500);
            this.MinimumSize = new System.Drawing.Size(820, 500);
            this.Name = "EmployerSearchPage";
            this.Text = "Search CV by Categories";
            ((System.ComponentModel.ISupportInitialize)(this.ActiveCV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bySalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox searchBy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button searchCvParams;
        public System.Windows.Forms.DataGridView ActiveCV;
        private System.Windows.Forms.NumericUpDown bySalary;
        private System.Windows.Forms.ComboBox byCategory;
        private System.Windows.Forms.ComboBox byExperience;
        private System.Windows.Forms.ComboBox byEducation;
        private System.Windows.Forms.ComboBox byCity;
        private System.Windows.Forms.ComboBox byGender;
    }
}