using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sparkling_CarWash
{
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        public string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";

        SqlConnection connect;
        SqlCommand command;
        SqlDataReader dataReader;

        String activeName;



        //This method set Active status of every user to false
        public void setStatusToFalse(string username)
        {
            connect = new SqlConnection(conString);
            //int initialStatus = 0;

            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();

                command = new SqlCommand($"UPDATE [USERS] SET IsActive = 0 WHERE Username = '{username}'", connect);
                command.Parameters.AddWithValue("@num", 0);
                command.ExecuteNonQuery();

                connect.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

        }


        public void activeUser(frmWelcome con, Label label)
        {
            //This simply display the name of the active user on the form
            try
            {
                con = new frmWelcome();
                connect = new SqlConnection(con.conString);
                if (connect.State == ConnectionState.Closed)
                    connect.Open();


                string query = $"SELECT * FROM [USERS] WHERE IsActive = 1";
                command = new SqlCommand(query, connect);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    activeName = dataReader.GetValue(1).ToString();
                }

                connect.Close();

                label.Text = "Active User: " + activeName;
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

        }

        //This method will be called when the details of the user are valid to set active status to True (1)
        public void setActiveStatus(string userName, string passWord)
        {
            connect = new SqlConnection(conString);
            int status = 1;
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();

                string query = @"UPDATE [USERS] SET IsActive = @num WHERE Username = @name AND Password = @passcode";

                command = new SqlCommand(query, connect);
                command.Parameters.AddWithValue("@num",status);
                command.Parameters.AddWithValue("@name",userName);
                command.Parameters.AddWithValue("@passcode",passWord);
                command.ExecuteNonQuery();

                connect.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            connect = new SqlConnection(conString);

            //These variables will store login details from the user
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            try
            {

                if (connect.State == ConnectionState.Closed)
                    connect.Open();

                string query = $"SELECT * FROM [USERS] WHERE Username = '{tbUsername.Text}'";

                command = new SqlCommand(query, connect);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    //Validates the user details with the onces in the database
                    if (username == dataReader.GetValue(1).ToString())
                    {
                        if (password == dataReader.GetValue(2).ToString())
                        {
                            setActiveStatus(username,password);

                            Sparkling_Car_Wash mainForm = new Sparkling_Car_Wash();
                            mainForm.Show();
                            this.Hide();

                            tbUsername.Text = "";
                            tbPassword.Text = "";
                        }
                        else
                        {
                            errorProvider1.SetError(tbPassword,"Invalid Password");
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(tbUsername, "Invalid Username");
                    }

                }


                connect.Close();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnExitLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmWelcome_Load(object sender, EventArgs e)
        {
            connect = new SqlConnection(conString);
            string name;

            try
            {
                connect.Open();

                string query = $"SELECT * FROM [USERS]";

                command = new SqlCommand(query, connect);
                dataReader = command.ExecuteReader();
                
                //Read through all records to make sure that their IsActive status if set to false
                while (dataReader.Read())
                {
                    name = dataReader.GetValue(1).ToString();
                    setStatusToFalse(name);
                }

                connect.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

            tbUsername.Focus();
        }
    }
}
