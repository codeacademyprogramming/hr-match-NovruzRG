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
    public partial class EmployerAddVacancyPage : Form
    {
        public User user;
        public EmployerAddVacancyPage(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void addVacancy_Click(object sender, EventArgs e)
        {
            if (vacancyTitle.Text == "" || vacancyCompany.Text == "" || vacancyCategory.Text == "" || vacancyCity.Text == "" || vacancyEducation.Text == "" || vacancyExperience.Text == "" || vacancyAbout.Text == "")
            {
                ErrorMessage("Empty fields");
            }
            else if (!IsValidNumber(vacancyPhone.Text))
            {
                ErrorMessage("Wrong Phone number type");
            }
            else
            {
                using (HrMatchContext db = new HrMatchContext())
                {
                    Vacancy vacancy = new Vacancy()
                    {
                        JobTitle = vacancyTitle.Text,
                        Company = vacancyCompany.Text,
                        Category = vacancyCategory.Text,
                        City = vacancyCity.Text,
                        Salary = int.Parse(vacancySalary.Value.ToString()),
                        Age = int.Parse(vacancyAge.Value.ToString()),
                        Education = vacancyEducation.Text,
                        Experience = vacancyExperience.Text,
                        Phone = vacancyPhone.Text,
                        About = vacancyAbout.Text,
                        UserId = user.ID
                    };
                    this.Dispose();

                    db.Vacancies.Add(vacancy);
                    db.SaveChanges();
                    MessageBox.Show("Vacancy Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
