using HR_Task.Context;
using HR_Task.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Task.Forms
{
    public partial class EmployerSearchPage : Form
    {
        public User user;
        List<FoundBySearch> foundBySearch = new List<FoundBySearch>();
        public EmployerSearchPage(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void searchCvParams_Click(object sender, EventArgs e)
        {

            if (searchBy.Text != "")
            {
                using (HrMatchContext db = new HrMatchContext())
                {
                    if (byCategory.Text != "" && byCategory.Visible)
                    {
                        var foundBy = db.CVs.Where(x => x.Category == byCategory.Text).ToList();
                        Generate(foundBy);
                    }
                    if (byCity.Text != "" && byCity.Visible)
                    {
                        var foundBy = db.CVs.Where(x => x.City == byCity.Text).ToList();
                        Generate(foundBy);
                    }
                    if (byEducation.Text != "" && byEducation.Visible)
                    {
                        var foundBy = db.CVs.Where(x => x.Education == byEducation.Text).ToList();
                        Generate(foundBy);
                    }
                    if (byExperience.Text != "" && byExperience.Visible)
                    {
                        var foundBy = db.CVs.Where(x => x.Experience == byExperience.Text).ToList();
                        Generate(foundBy);
                    }
                    if (byGender.Text != "" && byGender.Visible)
                    {
                        var foundBy = db.CVs.Where(x => x.Gender == byGender.Text).ToList();
                        Generate(foundBy);
                    }
                    if (bySalary.Value >= 250 && bySalary.Visible)
                    {
                        var foundBy = db.CVs.Where(x => x.Salary <= bySalary.Value).ToList();
                        Generate(foundBy);
                    }
                }
            }
            ActiveCV.DataSource = null;
            ActiveCV.DataSource = foundBySearch;
            ActiveCV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void searchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActiveCV.DataSource = null;
            switch (searchBy.Text)
            {
                case "Category":
                    Hide();
                    byCategory.Show();
                    break;
                case "City":
                    Hide();
                    byCity.Show();
                    break;
                case "Salary":
                    Hide();
                    bySalary.Show();
                    break;
                case "Experience":
                    Hide();
                    byExperience.Show();
                    break;
                case "Education":
                    Hide();
                    byEducation.Show();
                    break;
                case "Gender":
                    Hide();
                    byGender.Show();
                    break;
                default:
                    Hide();
                    break;
            }
        }
        private void Hide()
        {
            byCategory.Hide();
            byCategory.Text = "";
            byCity.Hide();
            byCity.Text = "";
            byGender.Hide();
            byGender.Text = "";
            byExperience.Hide();
            byExperience.Text = "";
            byEducation.Hide();
            byEducation.Text = "";
            bySalary.Hide();
            bySalary.Value = 250;
        }

        private void Generate(List<CV> foundBy)
        {
            foundBySearch.Clear();
            foreach (var item in foundBy)
            {
                foundBySearch.Add(new FoundBySearch()
                {
                    ID = item.ID,
                    Name = item.Name,
                    Surname = item.Surname,
                    Gender = item.Gender,
                    City = item.City,
                    Category = item.Category,
                    Salary = item.Salary,
                    Age = item.Age,
                    Education = item.Education,
                    Experience = item.Experience,
                    Phone = item.Phone
                });
            }
        }
        class FoundBySearch
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Gender { get; set; }
            public string City { get; set; }
            public string Category { get; set; }
            public int Salary { get; set; }
            public int Age { get; set; }
            public string Education { get; set; }
            public string Experience { get; set; }
            public string Phone { get; set; }
        }       
    }
}