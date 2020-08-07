namespace HR_Task.Forms
{
    partial class JobseekerAddCVPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobseekerAddCVPage));
            this.cvAge = new System.Windows.Forms.NumericUpDown();
            this.cvPhone = new System.Windows.Forms.MaskedTextBox();
            this.addVacancy = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cvSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cvName = new System.Windows.Forms.TextBox();
            this.cvExperience = new System.Windows.Forms.ComboBox();
            this.cvEducation = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cvCity = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cvGender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cvCategory = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cvSalary = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.cvAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cvSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // cvAge
            // 
            this.cvAge.AllowDrop = true;
            this.cvAge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cvAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cvAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.cvAge.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cvAge.Location = new System.Drawing.Point(119, 217);
            this.cvAge.Maximum = new decimal(new int[] {
            65,
            0,
            0,
            0});
            this.cvAge.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.cvAge.Name = "cvAge";
            this.cvAge.ReadOnly = true;
            this.cvAge.Size = new System.Drawing.Size(204, 26);
            this.cvAge.TabIndex = 7;
            this.cvAge.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // cvPhone
            // 
            this.cvPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cvPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cvPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.cvPhone.Location = new System.Drawing.Point(119, 321);
            this.cvPhone.Mask = "+(000)(00)-000-00-00";
            this.cvPhone.Name = "cvPhone";
            this.cvPhone.Size = new System.Drawing.Size(204, 26);
            this.cvPhone.TabIndex = 10;
            // 
            // addVacancy
            // 
            this.addVacancy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(226)))));
            this.addVacancy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addVacancy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(226)))));
            this.addVacancy.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.addVacancy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(226)))));
            this.addVacancy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(226)))));
            this.addVacancy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addVacancy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addVacancy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.addVacancy.Location = new System.Drawing.Point(16, 408);
            this.addVacancy.Name = "addVacancy";
            this.addVacancy.Size = new System.Drawing.Size(306, 33);
            this.addVacancy.TabIndex = 11;
            this.addVacancy.TabStop = false;
            this.addVacancy.Text = "Add CV";
            this.addVacancy.UseVisualStyleBackColor = false;
            this.addVacancy.Click += new System.EventHandler(this.addVacancy_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.label10.Location = new System.Drawing.Point(15, 323);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 20);
            this.label10.TabIndex = 29;
            this.label10.Text = "Phone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.label9.Location = new System.Drawing.Point(13, 288);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "Experience";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.label5.Location = new System.Drawing.Point(15, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Salary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Surname";
            // 
            // cvSurname
            // 
            this.cvSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cvSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cvSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.cvSurname.Location = new System.Drawing.Point(118, 51);
            this.cvSurname.Name = "cvSurname";
            this.cvSurname.Size = new System.Drawing.Size(204, 26);
            this.cvSurname.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Name";
            // 
            // cvName
            // 
            this.cvName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cvName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cvName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.cvName.Location = new System.Drawing.Point(118, 19);
            this.cvName.Name = "cvName";
            this.cvName.Size = new System.Drawing.Size(204, 26);
            this.cvName.TabIndex = 1;
            // 
            // cvExperience
            // 
            this.cvExperience.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cvExperience.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cvExperience.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cvExperience.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.cvExperience.FormattingEnabled = true;
            this.cvExperience.Items.AddRange(new object[] {
            "1-3 years",
            "3-5 years",
            "Less than 1 year",
            "More than 5 years"});
            this.cvExperience.Location = new System.Drawing.Point(119, 285);
            this.cvExperience.Name = "cvExperience";
            this.cvExperience.Size = new System.Drawing.Size(204, 28);
            this.cvExperience.TabIndex = 9;
            // 
            // cvEducation
            // 
            this.cvEducation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cvEducation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cvEducation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cvEducation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.cvEducation.FormattingEnabled = true;
            this.cvEducation.Items.AddRange(new object[] {
            "Bachelor\'s degree",
            "Master\'s degree",
            "Doctoral degree"});
            this.cvEducation.Location = new System.Drawing.Point(119, 251);
            this.cvEducation.Name = "cvEducation";
            this.cvEducation.Size = new System.Drawing.Size(204, 28);
            this.cvEducation.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.label7.Location = new System.Drawing.Point(15, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Education";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.label6.Location = new System.Drawing.Point(15, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Age";
            // 
            // cvCity
            // 
            this.cvCity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cvCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cvCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cvCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.cvCity.FormattingEnabled = true;
            this.cvCity.Items.AddRange(new object[] {
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
            this.cvCity.Location = new System.Drawing.Point(118, 117);
            this.cvCity.Name = "cvCity";
            this.cvCity.Size = new System.Drawing.Size(204, 28);
            this.cvCity.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "City";
            // 
            // cvGender
            // 
            this.cvGender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cvGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cvGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cvGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.cvGender.FormattingEnabled = true;
            this.cvGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cvGender.Location = new System.Drawing.Point(118, 83);
            this.cvGender.Name = "cvGender";
            this.cvGender.Size = new System.Drawing.Size(204, 28);
            this.cvGender.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.label4.Location = new System.Drawing.Point(12, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Gender";
            // 
            // cvCategory
            // 
            this.cvCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cvCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cvCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cvCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.cvCategory.FormattingEnabled = true;
            this.cvCategory.Items.AddRange(new object[] {
            "Banking",
            "IT",
            "Programing",
            "Teacher",
            "Driver"});
            this.cvCategory.Location = new System.Drawing.Point(119, 151);
            this.cvCategory.Name = "cvCategory";
            this.cvCategory.Size = new System.Drawing.Size(204, 28);
            this.cvCategory.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.label8.Location = new System.Drawing.Point(13, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 36;
            this.label8.Text = "Category";
            // 
            // cvSalary
            // 
            this.cvSalary.AllowDrop = true;
            this.cvSalary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cvSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cvSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.cvSalary.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cvSalary.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.cvSalary.Location = new System.Drawing.Point(118, 185);
            this.cvSalary.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.cvSalary.Minimum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.cvSalary.Name = "cvSalary";
            this.cvSalary.ReadOnly = true;
            this.cvSalary.Size = new System.Drawing.Size(204, 26);
            this.cvSalary.TabIndex = 6;
            this.cvSalary.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // AddCVPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(191)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(334, 461);
            this.Controls.Add(this.cvSalary);
            this.Controls.Add(this.cvCategory);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cvAge);
            this.Controls.Add(this.cvPhone);
            this.Controls.Add(this.addVacancy);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cvSurname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cvName);
            this.Controls.Add(this.cvExperience);
            this.Controls.Add(this.cvEducation);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cvCity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cvGender);
            this.Controls.Add(this.label4);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(350, 500);
            this.MinimumSize = new System.Drawing.Size(350, 500);
            this.Name = "AddCVPage";
            this.Text = "Add CV";
            ((System.ComponentModel.ISupportInitialize)(this.cvAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cvSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown cvAge;
        private System.Windows.Forms.MaskedTextBox cvPhone;
        private System.Windows.Forms.Button addVacancy;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cvSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cvName;
        private System.Windows.Forms.ComboBox cvExperience;
        private System.Windows.Forms.ComboBox cvEducation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cvCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cvGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cvCategory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown cvSalary;
    }
}