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
    public partial class JobseekerAppliedPage : Form
    {
        public User user;

        List<AllAppliedvac> allAppliedvac = new List<AllAppliedvac>();
        public JobseekerAppliedPage(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void JobseekerApplied_Load(object sender, EventArgs e)
        {
            using (HrMatchContext db = new HrMatchContext())
            {
                var requested = db.CVs.Include("Vacancies").FirstOrDefault(x => x.UserId == user.ID);
                foreach (var item in requested.Vacancies)
                {
                    allAppliedvac.Add(new AllAppliedvac()
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
            AppliedVacancy.DataSource = allAppliedvac;
            AppliedVacancy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
    }
    class AllAppliedvac
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
