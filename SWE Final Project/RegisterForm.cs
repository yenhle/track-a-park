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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_SWE_ProjectDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this._SWE_ProjectDataSet.Users);

        }

        private void Butt_Register_Click(object sender, EventArgs e)    //Registers users to database
        {
            /*Need to add:
             * Validation
             * Checks for matching usernames
             */

            string connetionString;
            SqlConnection cnn;

            connetionString = @"Data Source= localhost\SQLEXPRESS; Initial Catalog=SWE-Project; Trusted_Connection=True;";
            cnn = new SqlConnection(connetionString);

            cnn.Open();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql;

            string regUsername = regUserBox.Text;
            string regPassword = regPassBox.Text;

            
            sql = $"Insert into Users (Username, Password) values('{regUsername}', '{regPassword}')";

            command = new SqlCommand(sql, cnn);

            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();
            this.Hide();
        }
    }
}
