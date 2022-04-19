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
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
            string connectionString = @"Data Source= localhost\SQLEXPRESS; Initial Catalog=SWE-Project; Trusted_Connection=True;";

            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();
            /*SqlDataAdapter sda = new SqlDataAdapter($"Select Points from Users where Username = '{LoginForm.profileName}'", cnn);

            currentPoints.Text = sda.ToString();
            */


            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = "";

            sql = $"Select Points from Users where Username = '{LoginForm.profileName}'";

            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0);
            }

            currentPoints.Text = Output;
            cnn.Close();

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

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm.profileName = null;
            this.Hide(); // Hides the current form.
            LoginForm L = new LoginForm();
            L.Closed += (s, args) => this.Close(); //Will close the first form if profile is closed
            L.Show(); //Show Prof form
        }
    }
}
