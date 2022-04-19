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
    public partial class Lot_B_Form : Form
    {
        public Lot_B_Form()
        {
            InitializeComponent();
        }

        private void Lot_B_Form_Load(object sender, EventArgs e)
        {

        }

        private void CHK_B1_CheckedChanged(object sender, EventArgs e)
        {
            if (capacityfull == 10)
            {
                MessageBox.Show("The Lot is current at Capacity. Please Come again later");

            }
            else if (CHK_B1.Checked)
            {
                capacityfull++;
            }
        }

        private void CHK_B2_CheckedChanged(object sender, EventArgs e)
        {
            if (capacityfull == 10)
            {
                MessageBox.Show("The Lot is current at Capacity. Please Come again later");

            }
            else if (CHK_B2.Checked)
            {
                capacityfull++;
            }
        }

        private void CHK_B3_CheckedChanged(object sender, EventArgs e)
        {
            if (capacityfull == 10)
            {
                MessageBox.Show("The Lot is current at Capacity. Please Come again later");

            }
            else if (CHK_B3.Checked)
            {
                capacityfull++;
            }
        }

        private void CHK_B4_CheckedChanged(object sender, EventArgs e)
        {
            if (capacityfull == 10)
            {
                MessageBox.Show("The Lot is current at Capacity. Please Come again later");

            }
            else if (CHK_B4.Checked)
            {
                capacityfull++;
            }
        }

        private void CHK_B5_CheckedChanged(object sender, EventArgs e)
        {
            if (capacityfull == 10)
            {
                MessageBox.Show("The Lot is current at Capacity. Please Come again later");

            }
            else if (CHK_B5.Checked)
            {
                capacityfull++;
            }
        }

        private void CHK_B6_CheckedChanged(object sender, EventArgs e)
        {
            if (capacityfull == 10)
            {
                MessageBox.Show("The Lot is current at Capacity. Please Come again later");

            }
            else if (CHK_B6.Checked)
            {
                capacityfull++;
            }
        }

        private void CHK_B7_CheckedChanged(object sender, EventArgs e)
        {
            if (capacityfull == 10)
            {
                MessageBox.Show("The Lot is current at Capacity. Please Come again later");

            }
            else if (CHK_B7.Checked)
            {
                capacityfull++;
            }
        }

        private void CHK_B8_CheckedChanged(object sender, EventArgs e)
        {
            if (capacityfull == 10)
            {
                MessageBox.Show("The Lot is current at Capacity. Please Come again later");

            }
            else if (CHK_B8.Checked)
            {
                capacityfull++;
            }
        }

        private void CHK_B9_CheckedChanged(object sender, EventArgs e)
        {
            if (capacityfull == 10)
            {
                MessageBox.Show("The Lot is current at Capacity. Please Come again later");

            }
            else if (CHK_B9.Checked)
            {
                capacityfull++;
            }
        }

        private void CHK_B10_CheckedChanged(object sender, EventArgs e)
        {
            if (capacityfull == 10)
            {
                MessageBox.Show("The Lot is current at Capacity. Please Come again later");

            }
            else if (CHK_B10.Checked)
            {
                capacityfull++;
            }
        }

        public int Availablelot()
        {

            if (capacityfull == capacity)
            {
                MessageBox.Show("This Lot is currently full");
                return 0;
            }
            else
            {
                return capacity - capacityfull;
            }

        }
        private void Butt_CHK_B_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Availablelot().ToString());
        }
    }
}
