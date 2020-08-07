using HR_Task.Context;
using HR_Task.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Task.Forms
{
    public partial class EmployerVacanciesPage : Form
    {
        public User user;
        List<MyVac> myVac = new List<MyVac>();
        public EmployerVacanciesPage(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void EmployerVacanciesPage_Load(object sender, EventArgs e)
        {
            using (HrMatchContext db = new HrMatchContext())
            {
                var myVacancies = db.Vacancies.Where(x => x.UserId == user.ID).ToList();
                foreach (var item in myVacancies)
                {
                    myVac.Add(new MyVac()
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
            myVacancies.DataSource = myVac;
            myVacancies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void myVacancies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.myVacancies.Rows[e.RowIndex];
            int ID = int.Parse(row.Cells["ID"].Value.ToString());
            DialogResult result = MessageBox.Show($"Delete vacancy with id - {ID}", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                using (HrMatchContext db = new HrMatchContext())
                {
                    var delete = db.Database.ExecuteSqlCommand($"DELETE FROM Vacancies WHERE ID = {ID}");
                    try
                    {
                        if (delete > 0)
                        {
                            MessageBox.Show("Vacancy Deleted");
                            this.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("Vacancy not Deleted");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Can't find any Vacancy");
                    }
                }

            }
        }
    }
    class MyVac
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