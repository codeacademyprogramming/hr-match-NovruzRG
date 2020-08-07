using HR_Task.Context;
using HR_Task.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Task.Forms
{
    public partial class JobseekerAddCVPage : Form
    {
        public User user;
        public JobseekerAddCVPage(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void addVacancy_Click(object sender, EventArgs e)
        {

            if (cvName.Text == "" || cvSurname.Text == "" || cvGender.Text == "" || cvCity.Text == "" || cvCategory.Text == "" || cvSalary.Text == "" || cvAge.Text == "" || cvEducation.Text == "" || cvExperience.Text == "")
            {
                ErrorMessage("Empty fields");
            }
            else if (!IsValidNumber(cvPhone.Text))
            {
                ErrorMessage("Wrong Phone number type");
            }
            else
            {
                using (HrMatchContext db = new HrMatchContext())
                {
                    CV cv = new CV()
                    {
                        Name = cvName.Text,
                        Surname = cvSurname.Text,
                        Gender = cvGender.Text,
                        City = cvCity.Text,
                        Category = cvCategory.Text,
                        Salary = int.Parse(cvSalary.Value.ToString()),
                        Age = int.Parse(cvAge.Value.ToString()),
                        Education = cvEducation.Text,
                        Experience = cvExperience.Text,
                        Phone = cvPhone.Text,
                        UserId = user.ID
                    };
                    this.Dispose();

                    db.CVs.Add(cv);
                    db.SaveChanges();
                    MessageBox.Show("Cv added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        //  Error message        
        public string ErrorMessage(string errorMessage)
        {
            DialogResult result = MessageBox.Show(errorMessage, "Try again", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return "";
        }
        //  Error message end
        //  Number format Check        
        public bool IsValidNumber(string number)
        {

            Regex regex = new Regex(@"([+(994)]{6})[- ]?([(50,51,55,70,77)]{4})[- ]?([0-9]{3})[- ]?([0-9]{2})[- ]?([0-9]{2})");
            bool isValidated = regex.IsMatch(number);

            return isValidated;
        }
             
        //  NUmber format Check end
    }
}
