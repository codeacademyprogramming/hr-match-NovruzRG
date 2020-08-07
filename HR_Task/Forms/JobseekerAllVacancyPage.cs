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
    public partial class JobseekerAllVacancyPage : Form
    {
        public User user;
        List<Allvac> allVac = new List<Allvac>();
        public JobseekerAllVacancyPage(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void AllVacancyPage_Load(object sender, EventArgs e)
        {
            using (HrMatchContext db = new HrMatchContext())
            {
                foreach (var item in db.Vacancies)
                {
                    allVac.Add(new Allvac()
                    {
                        ID = item.ID,
                        JobTitle = item.JobTitle,
                        Company = item.Company,
                        Category = item.Category,
                        City = item.City,
                        Salary = item.Salary,
                        Age = item.Age,
                        Education = item.Education,
                        Experience = item.Experience,
                        Phone = item.Phone,
                        About = item.About
                    });
                }
            }
            ActiveVacancy.DataSource = allVac;
            ActiveVacancy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void sendRequest_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Send request?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);



            if (result == DialogResult.Yes)
            {
                using (HrMatchContext db = new HrMatchContext())
                {
                    bool foundVac = db.Vacancies.ToList().Exists(x => x.ID == vacancyID.Value);
                    if (vacancyID.Value == 0 || !foundVac)
                    {
                        MessageBox.Show("Wrong Vacancy ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        var foundCv = db.CVs.FirstOrDefault(x => x.UserId == user.ID);
                        if (foundCv == null)
                        {
                            MessageBox.Show("You don't gave any active CV - please add CV at first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            try
                            {
                                var requestVac = db.Vacancies.FirstOrDefault(x => x.ID == vacancyID.Value);
                                requestVac.CVs.Add(foundCv);
                                db.SaveChanges();
                                MessageBox.Show("Your request send", "Sucsess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                vacancyID.Value = 0;
                            }
                            catch
                            {
                                MessageBox.Show("You can't send request 2 times for one vacancy", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                        }
                    }
                }
            }
        }
    }
    class Allvac
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
}
