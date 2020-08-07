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
    public partial class EmployerMainPage : Form
    {

        public User user;

        public EmployerMainPage(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void EmployerMainPage_Load(object sender, EventArgs e)
        {
            activeUser.Text = user.Username;
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addVacancy_Click(object sender, EventArgs e)
        {
            new EmployerAddVacancyPage(user).ShowDialog();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            new EmployerSearchPage(user).ShowDialog();
        }

        private void pendingRequest_Click(object sender, EventArgs e)
        {
            new EmployerPendingPage(user).ShowDialog();
        }

        private void myVacancies_Click(object sender, EventArgs e)
        {
            new EmployerVacanciesPage(user).ShowDialog();
        }
    }
}
