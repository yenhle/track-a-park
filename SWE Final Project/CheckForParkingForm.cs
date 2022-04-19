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
    public partial class CheckForParkingForm : Form
    {
        public CheckForParkingForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Butt_GoToProf_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hides the current form.
            ProfileForm vehicForm = new ProfileForm();
            vehicForm.Closed += (s, args) => this.Close(); //Will close the first form if profile is closed
            vehicForm.Show(); //Show Prof form
            /* NOTE:
             * Froms will not communicate between each other
             * They are only used to navigate
             * So a new instance of the form is created every time you navigate.
             */
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Lot_A_Form F = new Lot_A_Form();

            //F.Availablelot();
            F.Availablelot();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Change the Lotfor # here (Lot2_Form())
            Lot_B_Form F = new Lot_B_Form();

            //F.Availablelot();
            F.Availablelot();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Change the Lotfor # here (Lot3_Form())
            Lot_C_Form F = new Lot_C_Form();

            //F.Availablelot();
            F.Availablelot();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Change the Lotfor # here (Lot4_Form())
            Lot_D_Form F = new Lot_D_Form();

            //F.Availablelot();
            F.Availablelot();
        }
    }
}
