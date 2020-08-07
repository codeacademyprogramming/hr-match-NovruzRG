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
    public partial class EmployerPendingPage : Form
    {
        public User user;

        List<AllPendingRequests> allPendingRequests = new List<AllPendingRequests>();
        public EmployerPendingPage(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void EmployerPendingPage_Load(object sender, EventArgs e)
        {
            using (HrMatchContext db = new HrMatchContext())
            {
                var myActiveVacancy = db.Vacancies.Include("CVs").Where(x => x.UserId == user.ID).ToList();


                foreach (var vacancy in myActiveVacancy)
                {
                    foreach (var cv in vacancy.CVs)
                    {
                        allPendingRequests.Add(new AllPendingRequests()
                        {
                            JobTitle = vacancy.JobTitle,

                            ID = cv.ID,
                            Name = cv.Name,
                            Surname = cv.Surname,
                            Gender = cv.Gender,
                            City = cv.City,
                            Category = cv.Category,
                            Salary = cv.Salary,
                            Age = cv.Age,
                            Education = cv.Education,
                            Experience = cv.Experience,
                            Phone = cv.Phone,
                        });
                    }
                }
                PendingRequests.DataSource = allPendingRequests;
                PendingRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
        }
        class AllPendingRequests
        {
            /// <summary>
            /// Vacancy
            /// </summary>
            public string JobTitle { get; set; }

            /// <summary>
            /// Jobseeker
            /// </summary>
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
