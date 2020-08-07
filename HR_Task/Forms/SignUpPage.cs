using HR_Task.Context;
using HR_Task.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Task
{
    public partial class SignUpPage : Form
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        private void SignUpPage_Load(object sender, EventArgs e)
        {

            RandomCode.Text = RandomString(4);
        }
        private void SP_Signup_Click(object sender, EventArgs e)
        {
            var passChecker = @"^.*(?=.{4,15})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$";

            if (RandomCode.Text == SubmitCode.Text) //Randome Code Check  -> Find "Generat code"
            {
                if (SP_Password.Text == SP_CPassword.Text) //Password Check 
                {
                    if (Role.Text != "") // Role Check
                    {
                        if (SP_Username.Text.Length > 4 || SP_Username.Text.Length < 20) //Username Check
                        {
                            if (Regex.IsMatch(SP_Password.Text, passChecker))
                            {
                                if (IsValidEmail(SP_Email.Text)) // Email format Check  -> Find "Email format Check"
                                {
                                    using (HrMatchContext db = new HrMatchContext())
                                    {
                                        bool emailCheck = db.Users.ToList().Exists(u => u.Email.ToLower().Equals(SP_Email.Text.ToLower()));
                                        bool usernameCheck = db.Users.ToList().Exists(u => u.Username.ToLower().Equals(SP_Username.Text.ToLower()));

                                        if (emailCheck)
                                        {
                                            ErrorMessage("This email address already exists.");
                                        }
                                        else if (usernameCheck)
                                        {
                                            ErrorMessage("This username already exists.");
                                        }
                                        else
                                        {
                                            User user = new User()
                                            {
                                                Username = SP_Username.Text,
                                                Email = SP_Email.Text,
                                                Role = Role.SelectedItem.ToString(),
                                                Password = SP_Password.Text,
                                            };
                                            this.Dispose();

                                            db.Users.Add(user);
                                            db.SaveChanges();
                                            MessageBox.Show("Thank you for registering. You may now Login.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                            new LoginPage().ShowDialog();
                                        }
                                    }
                                }
                                else
                                {
                                    ErrorMessage("Wrong Email format");
                                }
                            }
                            else
                            {
                                ErrorMessage("Your password must be 4-15 characters long, be of mixed case and also contain a digit and symbol.");
                            }
                        }
                        else
                        {
                            ErrorMessage("Username must contain 4-20 characters");
                        }
                    }
                    else
                    {
                        ErrorMessage("Choose Role");
                    }
                }
                else
                {
                    ErrorMessage("Password does not match");
                }
            }
            else
            {
                ErrorMessage("Verification code does not match");
            }
        }

        private void Login_Click(object sender, EventArgs e)
        {
            new LoginPage().Show();
            this.Close();
        }


        //  Generat code
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        //  Generat code end
        //  Error message        
        public string ErrorMessage(string errorMessage)
        {
            DialogResult result = MessageBox.Show(errorMessage, "Try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (result == DialogResult.OK)
            {
                //SubmitCode.Text = "";
                //RandomCode.Text = RandomString(4);
                //SP_Password.Text = "";
                //SP_CPassword.Text = "";
            }
            return "";
        }
        //  Error message end
        //  Email format Check        
        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        //  Email format Check end
    }
}
