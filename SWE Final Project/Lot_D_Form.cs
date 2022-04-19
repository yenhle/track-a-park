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
        public Lot_D_Form()
        {
            InitializeComponent();
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

        private void Butt_CHK_D_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Availablelot().ToString());
        }
    }
}
