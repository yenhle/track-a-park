using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWE_Final_Project
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Butt_Login_Click(object sender, EventArgs e)
        {
            //Open the Profile Form if a user and password match
            /*CREATE Logic to check if the user appears in db
             * and if the password matches the one of the 
             * If true then:
             */
            this.Hide(); // Hides the current form.
            ProfileForm profForm = new ProfileForm();
            profForm.Closed += (s, args) => this.Close(); //Will close the first form if profile is closed
            profForm.Show(); //Show Prof form

        }

        private void Butt_Register_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hides the current form.
            RegisterForm regForm = new RegisterForm();
            regForm.Closed += (s, args) => this.Close(); //Will close the first form if profile is closed
            regForm.Show(); //Show Prof form
        }
    }
}
