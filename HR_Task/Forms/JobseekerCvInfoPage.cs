using HR_Task.Context;
using HR_Task.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Task.Forms
{
    public partial class JobseekerCvInfoPage : Form
    {
        public User user;
        public JobseekerCvInfoPage(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void addVacancy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CvInfoDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Delete CV", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                using (HrMatchContext db = new HrMatchContext())
                {
                    var delete = db.Database.ExecuteSqlCommand($"DELETE FROM CVs WHERE UserID = {user.ID}");
                    try
                    {
                        if (delete > 0)
                        {
                            MessageBox.Show("Cv Deleted");
                            this.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("CV not Deleted");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Can't find any CV");
                    }
                }
            }
        }

        private void CvInfoPage_Load(object sender, EventArgs e)
        {
            using (HrMatchContext db = new HrMatchContext())
            {
                CV cv = db.CVs.FirstOrDefault(c => c.UserId == user.ID);
                CvInfoName.Text = cv.Name;
                CvInfoSurname.Text = cv.Surname;
                CvInfoGender.Text = cv.Gender;
                CvInfoCity.Text = cv.City;
                CvInfoCategory.Text = cv.Category;
                CvInfoSalary.Text = cv.Salary.ToString();
                CvInfoAge.Text = cv.Age.ToString();
                CvInfoEducation.Text = cv.Education;
                CvInfoExperience.Text = cv.Experience;
                CvInfoPhone.Text = cv.Phone;
            }
        }
    }
}
