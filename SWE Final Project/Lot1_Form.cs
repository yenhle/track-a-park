﻿using System;
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
    public partial class Lot1_Form : Form
    {
        public Lot1_Form()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(capacityfull == 10)
            {
                MessageBox.Show("The Lot is current at Capacity. Please Come again later");

            }
            else if(checkBox1.Checked)
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
            else if (checkBox2.Checked)
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
            else if (checkBox3.Checked)
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
            else if (checkBox4.Checked)
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
            else if (checkBox5.Checked)
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
            else if (checkBox6.Checked)
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
            else if (checkBox7.Checked)
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
            else if (checkBox8.Checked)
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
            else if (checkBox9.Checked)
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
            else if (checkBox10.Checked)
            {
                capacityfull++;
            }
        }

        public int Availablelot()
        {
            
            if(capacityfull == capacity)
            {
                MessageBox.Show("This Lot is currently full");
                return 0;
            }
            else 
            { 
                return capacity - capacityfull;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Availablelot().ToString());
        }
    }
}
