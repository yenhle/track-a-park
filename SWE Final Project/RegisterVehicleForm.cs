using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWE_Final_Project
{
    public partial class RegisterVehicleForm : Form
    {
        public RegisterVehicleForm()
        {
            InitializeComponent();
        }


        /*  Code for vehicle registration.
         *  Needs input validation for null entries or incorrect data types.
         */
        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;

            connetionString = @"Data Source= localhost\SQLEXPRESS; Initial Catalog=SWE-Project; Trusted_Connection=True;";
            cnn = new SqlConnection(connetionString);

            cnn.Open();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql;

            string plate = licensePlate.Text;
            string make = vMake.Text;
            string model = vModel.Text;
            string color = vColor.Text;
            string year = vYear.Text;


            sql = $"Insert into Vehicles (License, Make, Model, Color, Username, Year) values('{plate}', '{make}', '{model}', '{color}', '{LoginForm.profileName}', '{year}')";

            command = new SqlCommand(sql, cnn);

            adapter.InsertCommand = new SqlCommand(sql, cnn);

            //Add a try/catch block here for the exception where two vehicles with the same license plate are entered.
            

            try
            {
                adapter.InsertCommand.ExecuteNonQuery();
                command.Dispose();
                cnn.Close();
                this.Hide();
                MyVehiclesForm vehicForm = new MyVehiclesForm();
                vehicForm.Closed += (s, args) => this.Close(); //Will close the first form if profile is closed
                vehicForm.Show(); //Show Prof form
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("License Plate is already registered. Try again.");
                licensePlate.Clear();
            }
        }

        //Return to Profile
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hides the current form.
            ProfileForm profForm = new ProfileForm();
            profForm.Closed += (s, args) => this.Close(); //Will close the first form if profile is closed
            profForm.Show(); //Show Prof form
        }

        //Return to MyVehicles
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hides the current form.
            MyVehiclesForm vehicForm = new MyVehiclesForm();
            vehicForm.Closed += (s, args) => this.Close(); //Will close the first form if profile is closed
            vehicForm.Show(); //Show Prof form
        }
    }
}
