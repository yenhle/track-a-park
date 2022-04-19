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
    public partial class MyVehiclesForm : Form
    {
        public MyVehiclesForm()
        {
            InitializeComponent();
            string vUsername = LoginForm.profileName;
        }

        private void Butt_GoToProf_Click(object sender, EventArgs e)
        {

            this.Hide(); // Hides the current form.
            ProfileForm profForm = new ProfileForm();
            profForm.Closed += (s, args) => this.Close(); //Will close the first form if profile is closed
            profForm.Show(); //Show Prof form
            /* NOTE:
             * Froms will not communicate between each other
             * They are only used to navigate
             * So a new instance of the form is created every time you navigate.
             */
        }

        private void regVehicle_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hides the current form.
            RegisterVehicleForm rVehicForm = new RegisterVehicleForm();
            rVehicForm.Closed += (s, args) => this.Close(); //Will close the first form if profile is closed
            rVehicForm.Show(); //Show Prof form
        }

        private void MyVehiclesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_SWE_ProjectDataSet.Vehicles' table. You can move, or remove it, as needed.
            this.vehiclesTableAdapter.Fill(this._SWE_ProjectDataSet.Vehicles);



            string connectionString = @"Data Source= localhost\SQLEXPRESS; Initial Catalog=SWE-Project; Trusted_Connection=True;";
       
            SqlConnection cnn = new SqlConnection(connectionString);
            SqlDataAdapter sda = new SqlDataAdapter($"Select * from Vehicles where Username = '{LoginForm.profileName}'", cnn);

            DataTable data = new DataTable();
            sda.Fill(data);

            dataGridView1.DataSource = data;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
