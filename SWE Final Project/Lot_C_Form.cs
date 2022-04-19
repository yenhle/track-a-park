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
        public Lot_C_Form()
        {
            InitializeComponent();
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

        private void Butt_CHK_C_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Availablelot().ToString());
        }
    }
}
