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
    public partial class Vehicle : Form
    {
        frmWelcome q = new frmWelcome();  //Create an instance of the frmWelcome class

        public SqlConnection connect;
        public SqlCommand command;
        public SqlDataAdapter adapter;
        public DataSet dataset;
        public SqlDataReader dataReader;
        
        int value;
        public Vehicle()
        {
            InitializeComponent();
        }

        public void noneSelected()  //this method is for when no radioButton is checked
        {
            if (rbAddVehicle.Checked == false && rbDeleteVehicle.Checked == false && rbUpdateVehicle.Checked == false)
            {
                cbVehicleModelName.Enabled = false;
                tbVClientCellNum.Enabled = false;
                cbVehicleColor.Enabled = false;
                tbVehicleID.Enabled = false;
                tbVehicleNumberPlate.Enabled = false;
                btnSearchVehicleNumberPlate.Enabled = false;
                btnUpdateVehicle.Enabled = false;
                btnDeleteVehicle.Enabled = false;
                btnAddVehicle.Enabled = false;

            }
        }

        int clientPK, modelPK;

        public void refresh(String query)  //method to refresh the datagridView
        {
            connect = new SqlConnection(q.conString);

            if (connect.State == ConnectionState.Closed)
                connect.Open();

            adapter = new SqlDataAdapter();
            dataset = new DataSet();

            command = new SqlCommand(query, connect);
            //Filling the dataset
            adapter.SelectCommand = command;
            adapter.Fill(dataset, "VEHICLE");
            //Adding the data into the data grid
            dgvVehicles.DataSource = dataset;
            dgvVehicles.DataMember = "VEHICLE";
            //Closing the connection to the database
            connect.Close();
        }
        public void populateModelCB(string sqlStatement)   //method to populate the "model" combobox
        {

            connect = new SqlConnection(q.conString);

            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();

                command = new SqlCommand(sqlStatement, connect);
                dataReader = command.ExecuteReader();


                while (dataReader.Read())
                {
                    string ModelName = dataReader.GetValue(1).ToString();
                    cbVehicleModelName.Items.Add(ModelName);
                }

                connect.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Vehicle_Load(object sender, EventArgs e)  //method for when the Vehicle form loads
        {
            q.activeUser(q, lblActiveUserVehicles);  //active user method call 
            

            //disable controls until the user selects one of the radioButtons
            tbVClientCellNum.Enabled = false;
            tbVehicleID.Enabled = false;
            tbVehicleNumberPlate.Enabled = false;
            cbVehicleColor.Enabled = false;
            cbVehicleModelName.Enabled = false;
            btnSearchVehicleNumberPlate.Enabled = false;
            btnAddVehicle.Enabled = false;
            btnUpdateVehicle.Enabled = false;
            btnDeleteVehicle.Enabled = false;

            //populating the Vehicle form's dataGridView
            try
            {
                refresh($"Select * From [Vehicle]");

                //Closing the connection to the database
                connect.Close();


                populateModelCB("SELECT * FROM [MODEL]");   //method to populate the Model comboBox "CALL"

                errorProvider1.Clear();  //clearing the errorProvider1
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        // this method finds the primary key of a client based on the provided SQL statement
        public void findPKClient(string sqlStatement)
        {
            try
            {
                connect = new SqlConnection(q.conString);
                if (connect.State == ConnectionState.Closed)
                    connect.Open();

                command = new SqlCommand(sqlStatement, connect);
                dataReader = command.ExecuteReader();


                while (dataReader.Read())
                {
                    clientPK = int.Parse(dataReader.GetValue(0).ToString());
                }

                connect.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }
        // this method finds the primary key of a model based on the provided SQL statement
        public void findPKModel(string sqlStatement)
        {
            try
            {
                connect = new SqlConnection(q.conString);
                if (connect.State == ConnectionState.Closed)

                    connect.Open();

                command = new SqlCommand(sqlStatement, connect);
                dataReader = command.ExecuteReader();


                while (dataReader.Read())
                {
                    modelPK = int.Parse(dataReader.GetValue(0).ToString());
                }

                connect.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }
        public void clear()  //method for clearing controls 
        {
            cbVehicleModelName.Text = "";
            tbVClientCellNum.Text = "";
            tbVehicleID.Text = "";
            tbVehicleNumberPlate.Text = "";
            cbVehicleColor.Text = "";
            tbVehicleID.Text = "";

        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear(); //clear the errorProvider1 


            if (tbVehicleNumberPlate.Text != "")
            {
                if (tbVClientCellNum.Text != "")
                {
                    if (cbVehicleModelName.Text != "")
                    {
                        if (cbVehicleColor.Text != "")
                        {
                            if(int.TryParse(tbVClientCellNum.Text, out value))
                            {
                                findPKClient($"SELECT * FROM [CLIENT] WHERE ClientCellNumber = '{tbVClientCellNum.Text}'");  //"findPKClient" method call
                                findPKModel($"SELECT * FROM [MODEL] WHERE ModelName LIKE '{cbVehicleModelName.SelectedItem}'"); //"findModel" method call 

                                try
                                {
                                    DialogResult result = MessageBox.Show("PROCEED WITH ADDING THE VEHICLE?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                    if (result == DialogResult.Yes)
                                    {
                                        //Inserting to the Vehicle database 
                                        connect = new SqlConnection(q.conString);
                                        if (connect.State == ConnectionState.Closed)
                                            connect.Open();

                                        string sql1 = $"INSERT INTO [VEHICLE](Vehicle_NumPlate, Client_ID, VehicleColor, Model_ID) VALUES('{tbVehicleNumberPlate.Text}',{clientPK},'{cbVehicleColor.SelectedItem}',{modelPK})";

                                        //inserting into the Vehicle table
                                        command = new SqlCommand(sql1, connect);
                                        adapter = new SqlDataAdapter();
                                        adapter.InsertCommand = command;
                                        adapter.InsertCommand.ExecuteNonQuery();
                                        connect.Close();
                                        lblActionSuccessful.Visible = true;
                                        MessageBox.Show("Vehicle added successfully");


                                        errorProvider1.Clear();  //Clear the error provider



                                        clear();   //clear controls after the insertion into the Vehicle table



                                        refresh($"Select * From [Vehicle]"); //refresh the datagridView after the insertion into the Vehicle table

                                        rbAddVehicle.Checked = false; //deselects add vehicle radio button

                                        //re-diplays controls after a vehicle has been added 
                                        btnSearchVehicleNumberPlate.Visible = true;
                                        tbVehicleID.Visible = true;
                                        lblVehicleID.Visible = true;
                                        btnUpdateVehicle.Visible = true;
                                        btnDeleteVehicle.Visible = true;

                                        noneSelected();
                                    }
                                    else
                                    {
                                        MessageBox.Show("OPERATION CANCELLED");
                                        rbAddVehicle.Checked = false;
                                        clear(); //clear all controls 
                                        //re-diplays controls after a vehicle has been added 
                                        btnSearchVehicleNumberPlate.Visible = true;
                                        tbVehicleID.Visible = true;
                                        lblVehicleID.Visible = true;
                                        btnUpdateVehicle.Visible = true;
                                        btnDeleteVehicle.Visible = true;

                                        noneSelected();
                                    }

                                     
                                }
                                catch (SqlException)
                                {
                                    MessageBox.Show("CELL PHONE IS NOT ASSOCIATED WITH ANY CLIENT"); //if the cell phone number doesn't exist in the database
                                    rbAddVehicle.Checked = false;
                                    clear(); //clear all controls 
                                    btnSearchVehicleNumberPlate.Visible = true;
                                    tbVehicleID.Visible = true;
                                    lblVehicleID.Visible = true;
                                    btnUpdateVehicle.Visible = true;
                                    btnDeleteVehicle.Visible = true;

                                    noneSelected();

                                }




                            }
                            else
                            {
                                errorProvider1.SetError(tbVClientCellNum, "Enter valid cell numbers");
                            }
                          
                        }
                        else
                        {
                            errorProvider1.SetError(cbVehicleColor, "Select a color for a Vehicle");
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(cbVehicleModelName, "Select a Vehicle Model");
                    }
                }
                else
                {
                    errorProvider1.SetError(tbVClientCellNum, "Enter Client Cell Numbers");
                }
            }
            else
            {
                errorProvider1.SetError(tbVehicleNumberPlate, "Enter Vehicle Number Plates");
            }

        }

        private void btnSearchVehicleNumberPlate_Click(object sender, EventArgs e)
        {
            if (tbVehicleNumberPlate.Text != "")
            {
                string sql = $"SELECT * FROM [VEHICLE] WHERE Vehicle_NumPlate LIKE '{tbVehicleNumberPlate.Text}'";

                refresh(sql);  //refresh the dataGridView 
                tbVehicleNumberPlate.Text = "";  //clear the Number Plate textBox
                errorProvider1.Clear(); //clear the errorProvider1 
            }
            else
            {
                errorProvider1.SetError(tbVehicleNumberPlate, "Enter something in the Number Plate TextBox to Search for a number plate");

                tbVehicleNumberPlate.Focus(); //set the focus to Vehicle Number Plate textBox
            }




        }

        private void btnUpdateVehicle_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            try
            {
                if (tbVehicleID.Text == "") //input validation to ensure that the VehicleID is inserted in the 
                                            // VehicleID textBox 
                {
                    errorProvider1.SetError(tbVehicleID, "Insert the VehicleID"); //call to the setError method
                }
                else if (tbVehicleNumberPlate.Text == "") //input validation to ensure that the Vehicle number plate is inserted in the 
                                                          //textBox
                {
                    if (cbVehicleColor.Text == "")  //if any color is not selected from the color combobox
                    {
                        errorProvider1.SetError(cbVehicleColor, "Select Colour");   //call the errorProvider1's SetError method
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("ARE YOU SURE YOU WANT TO PROCEED WITH THE UPDATE?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            connect = new SqlConnection(q.conString);
                            if (connect.State == ConnectionState.Closed)
                                connect.Open();
                            string updateSql = $"UPDATE [VEHICLE] SET VehicleColor = '{cbVehicleColor.Text}' WHERE Vehicle_ID = {Int32.Parse(tbVehicleID.Text)} ";


                            command = new SqlCommand(updateSql, connect);
                            adapter = new SqlDataAdapter();
                            adapter.UpdateCommand = command;
                            adapter.UpdateCommand.ExecuteNonQuery();
                            connect.Close();
                            lblActionSuccessful.Visible = true;
                            lblActionSuccessful.Text = "Vehicle Updated Succesfully";
                            clear(); //clear controls 

                            errorProvider1.Clear();  //clear the errorProvider1

                            rbUpdateVehicle.Checked = false; //deselects update vehicle radio button

                            //re-displays all controls after a vehicle has been updated
                            cbVehicleModelName.Visible = true;
                            lblVehicleModel.Visible = true;
                            btnAddModel.Visible = true;
                            btnAddVehicle.Visible = true;
                            btnDeleteVehicle.Visible = true;


                            noneSelected();
                        }
                        else
                        {
                            MessageBox.Show("OPERATION CANCELLED");
                            clear(); //clear all controls 
                            rbUpdateVehicle.Checked = false;
                            //re-diplays controls after a vehicle has been added 
                            btnSearchVehicleNumberPlate.Visible = true;
                            tbVehicleID.Visible = true;
                            lblVehicleID.Visible = true;
                            btnUpdateVehicle.Visible = true;
                            btnDeleteVehicle.Visible = true;

                            noneSelected();
                        }
                    }
                }
                else if (cbVehicleColor.Text == "")
                {
                    if (tbVehicleNumberPlate.Text == "")
                    {
                        errorProvider1.SetError(tbVehicleNumberPlate, "Insert the Number Plate");  //errorProvider1's Set method call
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("ARE YOU SURE YOU WANT TO PROCEED WITH THE UPDATE?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            connect = new SqlConnection(q.conString);
                            if (connect.State == ConnectionState.Closed)
                                connect.Open();
                            string updateSql = $"UPDATE [VEHICLE] SET Vehicle_NumPlate = '{tbVehicleNumberPlate.Text}' WHERE Vehicle_ID = '{tbVehicleID.Text}' ";


                            command = new SqlCommand(updateSql, connect);
                            adapter = new SqlDataAdapter();
                            adapter.UpdateCommand = command;
                            adapter.UpdateCommand.ExecuteNonQuery();
                            connect.Close();
                            lblActionSuccessful.Text = "Vehicle Updated Succesfully";
                            clear(); //clear controls 

                            errorProvider1.Clear();  //clear the errorProvider1

                            rbUpdateVehicle.Checked = false; //deselects update vehicle radio button

                            //re-displays all controls after a vehicle has been updated
                            cbVehicleModelName.Visible = true;

                            lblVehicleModel.Visible = true;
                            btnAddModel.Visible = true;
                            btnAddVehicle.Visible = true;
                            btnDeleteVehicle.Visible = true;

                            noneSelected();
                        }
                        else
                        {
                            MessageBox.Show("OPERATION CANCELLED");
                            clear(); //clear all controls 
                            rbUpdateVehicle.Checked = false;
                            //re-diplays controls after a vehicle has been added 
                            btnSearchVehicleNumberPlate.Visible = true;
                            tbVehicleID.Visible = true;
                            lblVehicleID.Visible = true;
                            btnUpdateVehicle.Visible = true;
                            btnDeleteVehicle.Visible = true;

                            noneSelected();
                        }
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("ARE YOU SURE YOU WANT TO PROCEED WITH THE UPDATE?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        connect = new SqlConnection(q.conString);
                        if (connect.State == ConnectionState.Closed)
                            connect.Open();
                        string updateSql = $"UPDATE [VEHICLE] SET Vehicle_NumPlate = '{tbVehicleNumberPlate.Text}', VehicleColor = '{cbVehicleColor.Text}' WHERE Vehicle_ID = {Int32.Parse(tbVehicleID.Text)} ";


                        command = new SqlCommand(updateSql, connect);
                        adapter = new SqlDataAdapter();
                        adapter.UpdateCommand = command;
                        adapter.UpdateCommand.ExecuteNonQuery();
                        connect.Close();

                        lblActionSuccessful.Text = "Vehicle Updated Succesfully";

                        clear(); //clear the controls 

                        errorProvider1.Clear();  //clear the errorProvider1

                        rbUpdateVehicle.Checked = false; //deselects update vehicle radio button

                        //re-displays all controls after a vehicle has been updated
                        cbVehicleModelName.Visible = true;
                        lblVehicleModel.Visible = true;
                        btnAddModel.Visible = true;
                        btnAddVehicle.Visible = true;
                        btnDeleteVehicle.Visible = true;

                        noneSelected();
                    }
                    else
                    {
                        MessageBox.Show("OPERATION CANCELLED");
                        clear(); //clear all controls 
                        rbUpdateVehicle.Checked = false;
                        //re-diplays controls after a vehicle has been added 
                        btnSearchVehicleNumberPlate.Visible = true;
                        tbVehicleID.Visible = true;
                        lblVehicleID.Visible = true;
                        btnUpdateVehicle.Visible = true;
                        btnDeleteVehicle.Visible = true;

                        noneSelected();
                    }

                        
                }
                refresh($"Select * From [Vehicle]");  //refresh the dataGridView

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

       
        private void btnDeleteVehicle_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear(); //clear the errorProvider1 
            
            try
            {
                if (tbVehicleID.Text != "")  //if the Vehicle textBox is not empty
                {
                   if(int.TryParse(tbVehicleID.Text, out value)) //if the entered value is a number
                    {
                        DialogResult result = MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            String deleteSql = $"DELETE FROM [VEHICLE] WHERE Vehicle_ID = {Int32.Parse(tbVehicleID.Text)}";
                            connect = new SqlConnection(q.conString);
                            connect.Open();

                            command = new SqlCommand(deleteSql, connect);
                            command.ExecuteNonQuery();
                            adapter = new SqlDataAdapter();
                            adapter.DeleteCommand = command;
                            adapter.DeleteCommand.ExecuteNonQuery();
                            connect.Close();
                            
                           
                            //clear controls 
                            clear();

                            //refresh the database

                            refresh($"Select * From [Vehicle]");

                            errorProvider1.Clear();


                            MessageBox.Show("Vehicle Deleted Succesfully");
                            
                            rbDeleteVehicle.Checked = false; //deselects delete vehicle radio button


                            //re-displays all controls after a vehicle has been deleted
                            tbVClientCellNum.Visible = true;
                            cbVehicleModelName.Visible = true;
                            cbVehicleColor.Visible = true;
                            lblClientCell.Visible = true;
                            lblVehicleModel.Visible = true;
                            lblVehicleColor.Visible = true;
                            btnAddModel.Visible = true;
                            btnAddVehicle.Visible = true;
                            btnUpdateVehicle.Visible = true;

                            noneSelected();
                        }
                        else
                        {
                            MessageBox.Show("Operation cancelled");
                            clear(); //clear all controls 
                            rbDeleteVehicle.Checked = false;
                            //re-diplays controls after a vehicle has been added 
                            btnSearchVehicleNumberPlate.Visible = true;
                            tbVehicleID.Visible = true;
                            lblVehicleID.Visible = true;
                            btnUpdateVehicle.Visible = true;
                            btnDeleteVehicle.Visible = true;

                            noneSelected();

                        }
                           
                    }
                   else
                    {
                        errorProvider1.SetError(tbVehicleID, "Enter a numeral value");    
                    }
                        
                }
                else
                {
                    errorProvider1.SetError(tbVehicleID, "Insert Vehicle_ID to Delete");
                }



            }
            catch (SqlException )
            {
                MessageBox.Show("YOU CANNOT DELETE A VEHICLE ASSOCIATED WITH AN APPOINTMENT");
                clear(); //clear all controls 
                rbDeleteVehicle.Checked = false;
                refresh($"Select * From [Vehicle]"); //refresh the dataGridView

                //re-displays all controls after a vehicle has been deleted
                tbVClientCellNum.Visible = true;
                cbVehicleModelName.Visible = true;
                cbVehicleColor.Visible = true;
                lblClientCell.Visible = true;
                lblVehicleModel.Visible = true;
                lblVehicleColor.Visible = true;
                btnAddModel.Visible = true;
                btnAddVehicle.Visible = true;
                btnUpdateVehicle.Visible = true;

                noneSelected();
            }

        }

        private void btnCloseVehicles_Click(object sender, EventArgs e)
        {
            try
            {
                //this is to close the Vehicle form and go back to the main form
                Sparkling_Car_Wash car_Wash = new Sparkling_Car_Wash();  //create an instance of the "Sparkling Car Wash class"
                car_Wash.Show(); //call the Sparkling Car Wash's "Show()" method
                this.Hide();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void rbAddVehicle_CheckedChanged(object sender, EventArgs e)   
        {
            //sets focus on vehicle number plate
            tbVehicleNumberPlate.Focus();

            //controls to be Enabled when adding a vehicle
            
            tbVehicleNumberPlate.Enabled = true;
            
            
            tbVClientCellNum.Enabled = true;
            lblVehicleID.Enabled = true;
            
            cbVehicleModelName.Enabled = true;
            
          
            cbVehicleColor.Enabled = true;
            
            
            btnAddVehicle.Enabled = true;
            

            //controls to be hidden when adding a vehicle
            btnSearchVehicleNumberPlate.Enabled = false;
            tbVehicleID.Enabled = false;
          
            btnUpdateVehicle.Enabled = false;
            btnDeleteVehicle.Enabled = false;

            //hides label that displays that a vehicle has been added/updated/deleted successfully
            lblActionSuccessful.Visible = false;
        }

        private void rbUpdateVehicle_CheckedChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            //sets focus on vehicle number plate
            tbVehicleNumberPlate.Focus();

            //controls to be Enabled when adding a vehicle
            
            tbVehicleNumberPlate.Enabled = true;
            
            btnSearchVehicleNumberPlate.Enabled = true;
           
           
            tbVehicleID.Enabled = true;
            lblVehicleID.Enabled = true;
           
            lblClientCell.Visible = true;
            cbVehicleColor.Enabled = true;
            cbVehicleColor.Visible = true;
            lblVehicleColor.Visible = true;
            btnUpdateVehicle.Enabled = true;
            btnUpdateVehicle.Visible = true;
            lblVehicleModel.Enabled = true;

            //controls to be disabled when updating a vehicle
            cbVehicleModelName.Enabled = false;
            
            btnAddModel.Enabled = false;
            btnAddVehicle.Enabled = false;
            btnDeleteVehicle.Enabled = false;
            tbVClientCellNum.Enabled = false;

            //hides label that displays that a vehicle has been added/updated/deleted successfully
            lblActionSuccessful.Enabled = false;
        }

        private void rbDeleteVehicle_CheckedChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear(); //clear the errorProvider1
            //sets focus on vehicle number plate
            tbVehicleNumberPlate.Focus();

            //controls to be Enabled when deleting a vehicle
            
            tbVehicleNumberPlate.Enabled = true;
            
            btnSearchVehicleNumberPlate.Enabled = true;
            lblVehicleID.Enabled = true;
            tbVehicleID.Enabled = true;
            lblClientCell.Enabled = true;
            lblVehicleModel.Enabled = false;
            lblVehicleColor.Enabled = false;
            btnDeleteVehicle.Enabled = true;
            lblActionSuccessful.Enabled = true;

            //controls to be hidden when deleting a vehicle
            tbVClientCellNum.Enabled = false;
            cbVehicleModelName.Enabled = false;
            cbVehicleColor.Enabled = false;
            
            btnAddModel.Enabled = false;
            btnAddVehicle.Enabled = false;
            btnUpdateVehicle.Enabled = false;

           
        }

        private void btnAddModel_Click_1(object sender, EventArgs e)
        {
            try
            {
                Model model = new Model(this);  //create an instance of the Model class
                model.Show(); //show the Model form in modal fashion
                this.Hide();
                
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

    }
}






