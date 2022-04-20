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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            userBox.Text = "";
            passBox.Text = "";
        }

        public static string profileName;

        private void Butt_Login_Click(object sender, EventArgs e)
        {
            //Open the Profile Form if a user and password match
            /*CREATE Logic to check if the user appears in db
             * and if the password matches the one of the 
             * If true then:
             */

            bool currentUser = false;

            string connectionString;
            SqlConnection cnn;

            connectionString = @"Data Source= localhost\SQLEXPRESS; Initial Catalog=SWE-Project; Trusted_Connection=True;";
            cnn = new SqlConnection(connectionString);

            cnn.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = "", tempName, tempPass;

            sql = "Select Username, Password from Users";   

            command = new SqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + "\n";
                tempName = "" + dataReader.GetValue(0);
                tempPass = "" + dataReader.GetValue(1);

                if (("" + userBox.Text == tempName) && ("" + passBox.Text == tempPass)) //Checks if there is a matching pair of username and password in the database.
                {
                    currentUser = true;
                    profileName = tempName;
                }
            }


            if(currentUser == true) //If there is a match, login is successful. Continue to profile.
            {
                MessageBox.Show("Login Successful.");

                this.Hide(); // Hides the current form.
                ProfileForm profForm = new ProfileForm();
                profForm.Closed += (s, args) => this.Close(); //Will close the first form if profile is closed
                profForm.Show(); //Show Prof form
            }
            else    //No match, Invalid Login.
            {
                MessageBox.Show("Invalid Login.");
            }

            //MessageBox.Show(Output);

            //Close connections to database.
            dataReader.Close();
            command.Dispose();
            cnn.Close();

        }

        private void Butt_Register_Click(object sender, EventArgs e)
        {
            //this.Hide(); // Hides the current form.
            RegisterForm regForm = new RegisterForm();
            //regForm.Closed += (s, args) => this.Close(); //Will close the first form if profile is closed
            regForm.Show(); //Show Prof form
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_SWE_ProjectDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this._SWE_ProjectDataSet.Users);

        }

        private void userBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
