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
    public partial class Lot_C_Form : Form
    {
        int capacity = 10;
        int capacityfull = 0;
        static int temp = 0;
        public Lot_C_Form()
        {
            InitializeComponent();
            CHK_C1.Checked = true;
            CHK_C2.Checked = true;
            CHK_C3.Checked = true;
            CHK_C4.Checked = true;
            CHK_C5.Checked = true;
            CHK_C6.Checked = true;
            CHK_C7.Checked = true;
            CHK_C8.Checked = true;
            CHK_C9.Checked = true;
            CHK_C10.Checked = true;

            CHK_C1.Enabled = false;
            CHK_C2.Enabled = false;
            CHK_C3.Enabled = false;
            CHK_C4.Enabled = false;
            CHK_C5.Enabled = false;
            CHK_C6.Enabled = false;
            CHK_C7.Enabled = false;
            CHK_C8.Enabled = false;
            CHK_C9.Enabled = false;
            CHK_C10.Enabled = false;
        }

        private void CHK_C1_CheckedChanged(object sender, EventArgs e)
        {
            if (capacityfull == 10)
            {
                MessageBox.Show("The Lot is current at Capacity. Please Come again later");

            }
            else if (CHK_C1.Checked)
            {
                capacityfull++;
            }
        }

        private void CHK_C2_CheckedChanged(object sender, EventArgs e)
        {
            if (capacityfull == 10)
            {
                MessageBox.Show("The Lot is current at Capacity. Please Come again later");

            }
            else if (CHK_C2.Checked)
            {
                capacityfull++;
            }
        }

        private void CHK_C3_CheckedChanged(object sender, EventArgs e)
        {
            if (capacityfull == 10)
            {
                MessageBox.Show("The Lot is current at Capacity. Please Come again later");

            }
            else if (CHK_C3.Checked)
            {
                capacityfull++;
            }
        }

        private void CHK_C4_CheckedChanged(object sender, EventArgs e)
        {
            if (capacityfull == 10)
            {
                MessageBox.Show("The Lot is current at Capacity. Please Come again later");

            }
            else if (CHK_C4.Checked)
            {
                capacityfull++;
            }
        }

        private void CHK_C5_CheckedChanged(object sender, EventArgs e)
        {
            if (capacityfull == 10)
            {
                MessageBox.Show("The Lot is current at Capacity. Please Come again later");

            }
            else if (CHK_C5.Checked)
            {
                capacityfull++;
            }
        }

        private void CHK_C6_CheckedChanged(object sender, EventArgs e)
        {
            if (capacityfull == 10)
            {
                MessageBox.Show("The Lot is current at Capacity. Please Come again later");

            }
            else if (CHK_C6.Checked)
            {
                capacityfull++;
            }
        }

        private void CHK_C7_CheckedChanged(object sender, EventArgs e)
        {
            if (capacityfull == 10)
            {
                MessageBox.Show("The Lot is current at Capacity. Please Come again later");

            }
            else if (CHK_C7.Checked)
            {
                capacityfull++;
            }
        }

        private void CHK_C8_CheckedChanged(object sender, EventArgs e)
        {
            if (capacityfull == 10)
            {
                MessageBox.Show("The Lot is current at Capacity. Please Come again later");

            }
            else if (CHK_C8.Checked)
            {
                capacityfull++;
            }
        }

        private void CHK_C9_CheckedChanged(object sender, EventArgs e)
        {
            if (capacityfull == 10)
            {
                MessageBox.Show("The Lot is current at Capacity. Please Come again later");

            }
            else if (CHK_C9.Checked)
            {
                capacityfull++;
            }
        }

        private void CHK_C10_CheckedChanged(object sender, EventArgs e)
        {
            if (capacityfull == 10)
            {
                MessageBox.Show("The Lot is current at Capacity. Please Come again later");

            }
            else if (CHK_C10.Checked)
            {
                capacityfull++;
            }
        }

        public void Availablelot()
        {

            if ((capacityfull) == capacity)
            {
                MessageBox.Show("This Lot is currently full");
            }
            else
            {
                temp = capacity - (capacityfull);
                MessageBox.Show(temp.ToString() + " Spots Remaining.");
            }

        }


        private void Butt_CHK_A_Click(object sender, EventArgs e)
        {
            Availablelot();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hides the current form.
            CheckForParkingForm P = new CheckForParkingForm();
            P.Closed += (s, args) => this.Close();
            P.Show();
        }
    }
}
