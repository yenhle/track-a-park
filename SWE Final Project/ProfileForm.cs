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
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void Butt_MyVehicles_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hides the current form.
            MyVehiclesForm vehicForm = new MyVehiclesForm();
            vehicForm.Closed += (s, args) => this.Close(); //Will close the first form if profile is closed
            vehicForm.Show(); //Show Prof form
        }

        private void Butt_ChkForParking_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hides the current form.
            CheckForParkingForm checkParkForm = new CheckForParkingForm();
            checkParkForm.Closed += (s, args) => this.Close(); //Will close the first form if profile is closed
            checkParkForm.Show(); //Show Prof form
        }
    }
}
