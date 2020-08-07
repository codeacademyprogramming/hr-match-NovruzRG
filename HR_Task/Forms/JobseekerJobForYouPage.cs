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
    public partial class JobseekerJobForYouPage : Form
    {
        public User user;
        List<VacForYou> vacForYou = new List<VacForYou>();
        public JobseekerJobForYouPage(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void JobseekerJobForYouPage_Load(object sender, EventArgs e)
        {

            using (HrMatchContext db = new HrMatchContext())
            {
                var myCv = db.CVs.FirstOrDefault(c => c.UserId == user.ID);
                if (myCv != null)
                {
                    var myCvVac = db.Vacancies.Where(x =>
                    x.Category == myCv.Category &&
                    x.City == myCv.City &&
                    x.Salary >= myCv.Salary
                    ).ToList();
                    if (myCvVac.Count > 0)
                    {
                        foreach (var item in myCvVac)
                        {
                            vacForYou.Add(new VacForYou()
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
                    else
                    {
                        MessageBox.Show("Can't find any Vacancy based your CV", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }

                }
                else
                {
                    MessageBox.Show("Can't find any CV - At First add CV", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
            }

            VacancyForYou.DataSource = vacForYou;
            VacancyForYou.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
    }
    class VacForYou
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
