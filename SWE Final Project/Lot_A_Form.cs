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
    public partial class Lot_A_Form : Form
    {
        int capacity = 10;
        int capacityfull = 0;
        static int temp = 0;

        public Lot_A_Form()
        {
            InitializeComponent();
            CHK_A1.Checked = true;
            CHK_A2.Checked = false;
            CHK_A3.Checked = false;
            CHK_A4.Checked = true;
            CHK_A5.Checked = false;
            CHK_A6.Checked = false;
            CHK_A7.Checked = true;
            CHK_A8.Checked = true;
            CHK_A9.Checked = false;
            CHK_A10.Checked = false;

            CHK_A1.Enabled = false;
            CHK_A2.Enabled = false;
            CHK_A3.Enabled = false;
            CHK_A4.Enabled = false;
            CHK_A5.Enabled = false;
            CHK_A6.Enabled = false;
            CHK_A7.Enabled = false;
            CHK_A8.Enabled = false;
            CHK_A9.Enabled = false;
            CHK_A10.Enabled = false;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (capacityfull == 10)
            {
                MessageBox.Show("The Lot is current at Capacity. Please Come again later");

            }
            else if (CHK_A1.Checked)
            {
                capacityfull++;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (capacityfull == 10)
            {
                MessageBox.Show("The Lot is current at Capacity. Please Come again later");

            }
            else if (CHK_A2.Checked)
            {
                capacityfull++;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (capacityfull == 10)
            {
                MessageBox.Show("The Lot is current at Capacity. Please Come again later");

            }
            else if (CHK_A3.Checked)
            {
                capacityfull++;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (capacityfull == 10)
            {
                MessageBox.Show("The Lot is current at Capacity. Please Come again later");

            }
            else if (CHK_A4.Checked)
            {
                capacityfull++;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (capacityfull == 10)
            {
                MessageBox.Show("The Lot is current at Capacity. Please Come again later");

            }
            else if (CHK_A5.Checked)
            {
                capacityfull++;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (capacityfull == 10)
            {
                MessageBox.Show("The Lot is current at Capacity. Please Come again later");

            }
            else if (CHK_A6.Checked)
            {
                capacityfull++;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (capacityfull == 10)
            {
                MessageBox.Show("The Lot is current at Capacity. Please Come again later");

            }
            else if (CHK_A7.Checked)
            {
                capacityfull++;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (capacityfull == 10)
            {
                MessageBox.Show("The Lot is current at Capacity. Please Come again later");

            }
            else if (CHK_A8.Checked)
            {
                capacityfull++;
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (capacityfull == 10)
            {
                MessageBox.Show("The Lot is current at Capacity. Please Come again later");

            }
            else if (CHK_A9.Checked)
            {
                capacityfull++;
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (capacityfull == 10)
            {
                MessageBox.Show("The Lot is current at Capacity. Please Come again later");

            }
            else if (CHK_A10.Checked)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Availablelot();
        }

        private void Lot_A_Form_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Hide(); // Hides the current form.
            CheckForParkingForm P = new CheckForParkingForm();
            P.Closed += (s, args) => this.Close();
            P.Show();
        }
    }
}
