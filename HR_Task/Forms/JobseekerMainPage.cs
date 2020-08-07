using HR_Task.Context;
using HR_Task.Forms;
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

namespace HR_Task
{
    public partial class JobseekerMainPage : Form
    {
        public User user;

        public JobseekerMainPage(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void addCV_Click(object sender, EventArgs e)
        {
            using (HrMatchContext db = new HrMatchContext())
            {
                CV cv = db.CVs.FirstOrDefault(c => c.UserId == user.ID);
                if (cv == null)
                {
                    new JobseekerAddCVPage(user).ShowDialog();
                }
                else
                {
                    MessageBox.Show("You already have active CV - for change delete it", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void myCvInfo_Click(object sender, EventArgs e)
        {
            using (HrMatchContext db = new HrMatchContext())
            {
                CV cv = db.CVs.FirstOrDefault(c => c.UserId == user.ID);
                if (cv != null)
                {
                    new JobseekerCvInfoPage(user).ShowDialog();
                }
                else
                {
                    MessageBox.Show("Can't find any CV - At First add CV", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void applied_Click(object sender, EventArgs e)
        {
            new JobseekerAppliedPage(user).ShowDialog();
        }

        private void jobsForYou_Click(object sender, EventArgs e)
        {
            new JobseekerJobForYouPage(user).ShowDialog();
        }

        private void search_Click(object sender, EventArgs e)
        {
            new JobseekerSearchPage(user).ShowDialog();
        }

        private void activeJobs_Click(object sender, EventArgs e)
        {
            new JobseekerAllVacancyPage(user).ShowDialog();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void JobseekerMainPage_Load(object sender, EventArgs e)
        {
            activeUser.Text = user.Username;
        }
    }
}
