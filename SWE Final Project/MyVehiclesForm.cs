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
    public partial class MyVehiclesForm : Form
    {
        public MyVehiclesForm()
        {
            InitializeComponent();
            string vUsername = LoginForm.profileName;
        }

        private void Butt_GoToProf_Click(object sender, EventArgs e)
        {

            this.Hide(); // Hides the current form.
            ProfileForm profForm = new ProfileForm();
            profForm.Closed += (s, args) => this.Close(); //Will close the first form if profile is closed
            profForm.Show(); //Show Prof form
            /* NOTE:
             * Froms will not communicate between each other
             * They are only used to navigate
             * So a new instance of the form is created every time you navigate.
             */
        }

        private void regVehicle_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hides the current form.
            RegisterVehicleForm rVehicForm = new RegisterVehicleForm();
            rVehicForm.Closed += (s, args) => this.Close(); //Will close the first form if profile is closed
            rVehicForm.Show(); //Show Prof form
        }
    }
}
