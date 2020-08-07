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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void Signup_Click(object sender, EventArgs e)
        {
            new SignUpPage().Show();
            this.Close();
        }

        private void LI_Login_Click(object sender, EventArgs e)
        {
            using (HrMatchContext db = new HrMatchContext())
            {
                User user = db.Users.FirstOrDefault(u => u.Username == LI_Username.Text && u.Password == LI_Password.Text);
                if (user != null)
                {
                    var userRole = user.Role;
                    if (userRole == "Jobseeker")
                    {
                        new JobseekerMainPage(user).ShowDialog();
                    }
                    else if (userRole == "Employer")
                    {
                        new EmployerMainPage(user).ShowDialog();
                    }
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Wrong username or password", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
