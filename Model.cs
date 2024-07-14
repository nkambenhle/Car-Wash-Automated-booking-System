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
    public partial class Model : Form
    {
        frmWelcome welcome = new frmWelcome(); // create an instance of frmWelcome form
        private Form callingForm;
        public Model(Form callingForm)
        {
            InitializeComponent();
            this.callingForm = callingForm;
        }

        
        String activeName;
        SqlConnection connect;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        SqlDataReader dataReader;

        int type;
        int make;

        public void populateMakeCB(string sqlStatement)
        {
            connect = new SqlConnection(welcome.conString);

            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();

                command = new SqlCommand(sqlStatement, connect);
                dataReader = command.ExecuteReader();


                while (dataReader.Read())
                {
                    string servnameDelete = dataReader.GetValue(1).ToString();
                    cbMakeName.Items.Add(servnameDelete);
                }

                connect.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void populateVehicleTypeCB(string sqlStatement)  //method to populate VehicleType combobox
        {
            connect = new SqlConnection(welcome.conString);

            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();

                command = new SqlCommand(sqlStatement, connect);
                dataReader = command.ExecuteReader();


                while (dataReader.Read())
                {
                    string servnameDelete = dataReader.GetValue(1).ToString();
                    cbVehicleTypeName.Items.Add(servnameDelete);
                }

                connect.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void findPKmake(string sqlStatement)  //method to find the Primary key of Make table
        {
            connect = new SqlConnection(welcome.conString);

            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();

                command = new SqlCommand(sqlStatement, connect);
                dataReader = command.ExecuteReader();


                while (dataReader.Read())
                {
                    make = int.Parse(dataReader.GetValue(0).ToString());
                }

                connect.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void findPKtype(string sqlStatement) //method to find the Primary key of Vehicle Type
        {
            connect = new SqlConnection(welcome.conString);

            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();

                command = new SqlCommand(sqlStatement, connect);
                dataReader = command.ExecuteReader();


                while (dataReader.Read())
                {
                    type = int.Parse(dataReader.GetValue(0).ToString());
                }

                connect.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void Model_Load(object sender, EventArgs e) //form load method
        {
            errorProvider1.Clear();
            welcome.activeUser(welcome, lblActiveUserVehicles);
            //This simply display the name of the active user on the form
            try
            {
                label4.Visible = false;
                connect = new SqlConnection(welcome.conString);
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

                lblActiveUserVehicles.Text = "Active User: " + activeName;
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

            tbModelName.Focus();
            populateMakeCB($"SELECT * FROM [MAKE] ");  //method call
            populateVehicleTypeCB($"SELECT * FROM [VEHICLE_TYPE] "); //method call 
        }

        private void btnMakeAdd_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear(); // Clear the errorProvider1
            label4.Text = "";
            try
            {
                if (tbModelName.Text != "")
                {
                    
                    
                        if(cbMakeName.Text != "")
                    {
                            if (cbVehicleTypeName.Text != "")
                            {
                                // Find the primary keys for Make and Vehicle Type
                                findPKmake($"SELECT * FROM [MAKE] WHERE Make_Name = '{cbMakeName.SelectedItem}'");
                                findPKtype($"SELECT * FROM [VEHICLE_TYPE] WHERE Vehicle_Type = '{cbVehicleTypeName.SelectedItem}'");

                                // Check if the model with the same name, make, and vehicle type already exists
                                if (!IsModelExists(tbModelName.Text, make, type))
                                {
                                    DialogResult result = MessageBox.Show("ARE YOU SURE YOU WANT TO ADD THE MODEL?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                    if (result == DialogResult.Yes)
                                    {
                                        connect = new SqlConnection(welcome.conString);
                                        if (connect.State == ConnectionState.Closed)
                                            connect.Open();

                                        string sql = $"INSERT INTO [MODEL](ModelName, Make_ID, Vehicle_Type_ID) VALUES('{tbModelName.Text}','{make}','{type}')";

                                        dataAdapter = new SqlDataAdapter();
                                        command = new SqlCommand(sql, connect);
                                        dataAdapter.InsertCommand = command;
                                        dataAdapter.InsertCommand.ExecuteNonQuery();
                                        connect.Close();
                                        label4.Visible = true;
                                        label4.Text = "Vehicle Model added successfully.";
                                        tbModelName.Text = "";
                                        cbMakeName.Text = "";
                                        cbVehicleTypeName.Text = "";
                                    }
                                    else
                                    {
                                        MessageBox.Show("Operation cancelled");
                                        errorProvider1.Clear();
                                    }


                                }
                                else
                                {
                                    errorProvider1.SetError(tbModelName, "Model with the same name, make, and vehicle type already exists.");
                                    tbModelName.Focus();
                                }
                            }
                            else
                            {
                                errorProvider1.SetError(cbVehicleTypeName, "Select Vehicle Type");
                                cbVehicleTypeName.Focus();
                            }
                        }
                    else
                        {
                            errorProvider1.SetError(cbMakeName, "Select the Vehicle Make");
                            cbMakeName.Focus();
                        }
                    
                    
                    
                    
                }
                else
                {
                    errorProvider1.SetError(tbModelName, "Enter Model Name");
                    tbModelName.Focus();
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private bool IsModelExists(string modelName, int makeID, int vehicleTypeID)
        {
            // Check if a model with the same name, make, and vehicle type already exists in the database
            connect = new SqlConnection(welcome.conString);
            if (connect.State == ConnectionState.Closed)
                connect.Open();

            string query = $"SELECT COUNT(*) FROM [MODEL] WHERE ModelName = '{modelName}' AND Make_ID = {makeID} AND Vehicle_Type_ID = {vehicleTypeID}";
            command = new SqlCommand(query, connect);
            int count = Convert.ToInt32(command.ExecuteScalar());
            connect.Close();

            return count > 0;
        }



        private void button1_Click(object sender, EventArgs e)  //model form "close" button
        {
            try
            {
                //this is to close the Model form 
                callingForm.Show();
                this.Hide(); 

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}


