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
    public partial class JobseekerSearchPage : Form
    {
        public User user;
        List<FoundBySearchJob> foundBySearchJob = new List<FoundBySearchJob>();
        public JobseekerSearchPage(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void searchVacancyParams_Click(object sender, EventArgs e)
        {

            if (searchByJob.Text != "")
            {
                using (HrMatchContext db = new HrMatchContext())
                {
                    if (byCategoryJob.Text != "" && byCategoryJob.Visible)
                    {
                        var foundBySecond = db.Vacancies.Where(x => x.Category == byCategoryJob.Text).ToList();
                        Generate(foundBySecond);
                    }
                    if (byCityJob.Text != "" && byCityJob.Visible)
                    {
                        var foundBySecond = db.Vacancies.Where(x => x.City == byCityJob.Text).ToList();
                        Generate(foundBySecond);
                    }
                    if (byEducationJob.Text != "" && byEducationJob.Visible)
                    {
                        var foundBySecond = db.Vacancies.Where(x => x.Education == byEducationJob.Text).ToList();
                        Generate(foundBySecond);
                    }
                    if (byExperienceJob.Text != "" && byExperienceJob.Visible)
                    {
                        var foundBySecond = db.Vacancies.Where(x => x.Experience == byExperienceJob.Text).ToList();
                        Generate(foundBySecond);
                    }                   
                    if (bySalaryJob.Value >= 250 && bySalaryJob.Visible)
                    {
                        var foundBySecond = db.Vacancies.Where(x => x.Salary <= bySalaryJob.Value).ToList();
                        Generate(foundBySecond);
                    }
                }
            }
            ActiveVacancy.DataSource = null;
            ActiveVacancy.DataSource = foundBySearchJob;
            ActiveVacancy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
     
        private void Hide()
        {
            byCategoryJob.Hide();
            byCategoryJob.Text = "";
            byCityJob.Hide();
            byCityJob.Text = "";
            byExperienceJob.Hide();
            byExperienceJob.Text = "";
            byEducationJob.Hide();
            byEducationJob.Text = "";
            bySalaryJob.Hide();
            bySalaryJob.Value = 250;
        }
        private void Generate(List<Vacancy> foundBySecond)
        {
            foundBySearchJob.Clear();
            foreach (var item in foundBySecond)
            {
                foundBySearchJob.Add(new FoundBySearchJob()
                {
                    ID = item.ID,
                    JobTitle = item.JobTitle,
                    Company = item.Company,
                    About = item.About,
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
        class FoundBySearchJob
        {
            public int ID { get; set; }
            public string JobTitle { get; set; }
            public string Company { get; set; }
            public string Category { get; set; }
            public string City { get; set; }
            public int Salary { get; set; }
            public int Age { get; set; }
            public string Education { get; set; }
            public string Experience { get; set; }
            public string Phone { get; set; }
            public string About { get; set; }
        }

        private void searchByJob_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ActiveVacancy.DataSource = null;
            switch (searchByJob.Text)
            {
                case "Category":
                    Hide();
                    byCategoryJob.Show();
                    break;
                case "City":
                    Hide();
                    byCityJob.Show();
                    break;
                case "Salary":
                    Hide();
                    bySalaryJob.Show();
                    break;
                case "Experience":
                    Hide();
                    byExperienceJob.Show();
                    break;
                case "Education":
                    Hide();
                    byEducationJob.Show();
                    break;
                default:
                    Hide();
                    break;
            }
        }
    }
}
