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
    public partial class Lot_D_Form : Form
    {
        int capacity = 10;
        int capacityfull = 0;
        static int temp = 0;
        public Lot_D_Form()
        {
            InitializeComponent();
            CHK_D1.Checked = false;
            CHK_D2.Checked = false;
            CHK_D3.Checked = false;
            CHK_D4.Checked = false;
            CHK_D5.Checked = false;
            CHK_D6.Checked = true;
            CHK_D7.Checked = false;
            CHK_D8.Checked = true;
            CHK_D9.Checked = false;
            CHK_D10.Checked = false;

            CHK_D1.Enabled = false;
            CHK_D2.Enabled = false;
            CHK_D3.Enabled = false;
            CHK_D4.Enabled = false;
            CHK_D5.Enabled = false;
            CHK_D6.Enabled = false;
            CHK_D7.Enabled = false;
            CHK_D8.Enabled = false;
            CHK_D9.Enabled = false;
            CHK_D10.Enabled = false;
        }

        private void CHK_D1_CheckedChanged(object sender, EventArgs e)
        {
            if (capacityfull == 10)
            {
                MessageBox.Show("The Lot is current at Capacity. Please Come again later");

            }
            else if (CHK_D1.Checked)
            {
                capacityfull++;
            }
        }

        private void CHK_D2_CheckedChanged(object sender, EventArgs e)
        {
            if (capacityfull == 10)
            {
                MessageBox.Show("The Lot is current at Capacity. Please Come again later");

            }
            else if (CHK_D2.Checked)
            {
                capacityfull++;
            }
        }

        private void CHK_D3_CheckedChanged(object sender, EventArgs e)
        {
            if (capacityfull == 10)
            {
                MessageBox.Show("The Lot is current at Capacity. Please Come again later");

            }
            else if (CHK_D3.Checked)
            {
                capacityfull++;
            }
        }

        private void CHK_D4_CheckedChanged(object sender, EventArgs e)
        {
            if (capacityfull == 10)
            {
                MessageBox.Show("The Lot is current at Capacity. Please Come again later");

            }
            else if (CHK_D4.Checked)
            {
                capacityfull++;
            }
        }

        private void CHK_D5_CheckedChanged(object sender, EventArgs e)
        {
            if (capacityfull == 10)
            {
                MessageBox.Show("The Lot is current at Capacity. Please Come again later");

            }
            else if (CHK_D5.Checked)
            {
                capacityfull++;
            }
        }

        private void CHK_D6_CheckedChanged(object sender, EventArgs e)
        {
            if (capacityfull == 10)
            {
                MessageBox.Show("The Lot is current at Capacity. Please Come again later");

            }
            else if (CHK_D6.Checked)
            {
                capacityfull++;
            }
        }

        private void CHK_D7_CheckedChanged(object sender, EventArgs e)
        {
            if (capacityfull == 10)
            {
                MessageBox.Show("The Lot is current at Capacity. Please Come again later");

            }
            else if (CHK_D7.Checked)
            {
                capacityfull++;
            }
        }

        private void CHK_D8_CheckedChanged(object sender, EventArgs e)
        {
            if (capacityfull == 10)
            {
                MessageBox.Show("The Lot is current at Capacity. Please Come again later");

            }
            else if (CHK_D8.Checked)
            {
                capacityfull++;
            }
        }

        private void CHK_D9_CheckedChanged(object sender, EventArgs e)
        {
            if (capacityfull == 10)
            {
                MessageBox.Show("The Lot is current at Capacity. Please Come again later");

            }
            else if (CHK_D9.Checked)
            {
                capacityfull++;
            }
        }

        private void CHK_D10_CheckedChanged(object sender, EventArgs e)
        {
            if (capacityfull == 10)
            {
                MessageBox.Show("The Lot is current at Capacity. Please Come again later");

            }
            else if (CHK_D10.Checked)
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
