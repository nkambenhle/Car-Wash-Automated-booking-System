using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sparkling_CarWash
{
    public partial class Vehicle_Type : Form
    {
        frmWelcome welcome = new frmWelcome();
        
        public Vehicle_Type()
        {
            InitializeComponent();
            
        }



        SqlConnection cnn;
        SqlCommand command;
        SqlDataAdapter adapter;
        DataSet ds;
        SqlDataReader dataReader;
        private void Vehicle_Type_Load(object sender, EventArgs e)
        {
            label2.Text = "";
            label12.Text = "";
            cbVehicleTypeName.Text = "";
            errorProvider1.Clear(); //clear the errorProvider
            welcome.activeUser(welcome, lblActiveUserVTpyes);
            groupBox1.Enabled = false;
            groupBox3.Enabled = false;

            try
            {
                //add values into the VehicleTypeName comboBox

                string sql = "SELECT Vehicle_Type FROM [VEHICLE_TYPE]";
                cnn = new SqlConnection(welcome.conString);
                cnn.Open();

                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();


                while (dataReader.Read())
                {
                    string employee1 = dataReader.GetValue(0).ToString();
                    cbVehicleTypeName.Items.Add(employee1);
                    
                }

                cnn.Close();

                cnn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void AddVehicle_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            errorProvider1.Clear();

            try
            {
                if (tbVehicleTypeName.Text == "")
                {
                    errorProvider1.SetError(tbVehicleTypeName, "Insert Vehicle Type name");
                }
                else if (tbVehicleBillingRecord.Text == "")
                {
                    errorProvider1.SetError(tbVehicleBillingRecord, "Insert Vehicle billing record price");
                }
                else
                {
                    DialogResult result = MessageBox.Show("ARE YOU SURE YOU WANT TO ADD THE VEHICLE TYPE", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string sql = $"INSERT INTO [VEHICLE_TYPE](Vehicle_Type, Vehicle_Billing_Record) VALUES('{tbVehicleTypeName.Text}', '{tbVehicleBillingRecord.Text}')";
                        cnn = new SqlConnection(welcome.conString);
                        if (cnn.State == ConnectionState.Closed)
                            cnn.Open();
                        adapter = new SqlDataAdapter();
                        command = new SqlCommand(sql, cnn);
                        adapter.InsertCommand = command;
                        adapter.InsertCommand.ExecuteNonQuery();
                        cnn.Close();
                        tbVehicleTypeName.Text = "";
                        tbVehicleBillingRecord.Text = "";
                        label2.Text = "Added successfully";
                        label2.Visible = true;
                        label12.Visible = false;
                        errorProvider1.Clear();

                        string sql1 = "SELECT Vehicle_Type FROM [VEHICLE_TYPE]";
                        cnn = new SqlConnection(welcome.conString);
                        adapter = new SqlDataAdapter(sql1, cnn);
                        cnn.Open();

                        ds = new DataSet();
                        adapter.Fill(ds, "[VEHICLE_TYPE]");

                        cbVehicleTypeName.DisplayMember = "Vehicle_Type";
                        cbVehicleTypeName.DataSource = ds.Tables["[VEHICLE_TYPE]"];

                        cnn.Close();

                    }

                    else
                    {
                        MessageBox.Show("OPERATION CANCELLED");
                        errorProvider1.Clear();
                        tbVehicleTypeName.Clear();
                        tbVehicleBillingRecord.Clear();
                    }


                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void DeleteVehicle_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            try
            {
                if (cbVehicleTypeName.SelectedItem == null)
                {
                    errorProvider1.SetError(cbVehicleTypeName, "Nothing selected");
                }
                else
                {
                    DialogResult result = MessageBox.Show("ARE YOU SURE YOU WANT TO DELETE THE VEHICLE TYPE", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {

                        cnn = new SqlConnection(welcome.conString);
                        string sql = "DELETE FROM [VEHICLE_TYPE] WHERE Vehicle_Type LIKE '" + cbVehicleTypeName.Text + "'";
                        if (cnn.State == ConnectionState.Closed)
                            cnn.Open();
                        command = new SqlCommand(sql, cnn);
                        adapter = new SqlDataAdapter();
                        adapter.DeleteCommand = command;
                        adapter.DeleteCommand.ExecuteNonQuery();
                        cnn.Close();

                        cbVehicleTypeName.Text = "";
                        label12.Text = "Deleted";
                        cbVehicleTypeName.Text = "";


                        //refresh the VehicleType comboBox

                        string sql1 = "SELECT Vehicle_Type FROM [VEHICLE_TYPE]";
                        cnn = new SqlConnection(welcome.conString);
                        if (cnn.State == ConnectionState.Closed)
                            cnn.Open();
                        adapter = new SqlDataAdapter(sql1, cnn);


                        ds = new DataSet();
                        adapter.Fill(ds, "[VEHICLE_TYPE]");

                        cbVehicleTypeName.DisplayMember = "Vehicle_Type";
                        cbVehicleTypeName.DataSource = ds.Tables["[VEHICLE_TYPE]"];

                        cnn.Close();
                        cbVehicleTypeName.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("OPERATION CANCELLED");
                        errorProvider1.Clear();
                        cbVehicleTypeName.Text = "";
                    }


                }
            }
            catch (SqlException)
            {
                MessageBox.Show("YOU CANNOT DELETE A VEHICLE TYPE THAT IS ASSOCIATED WITH A MODEL");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                Sparkling_Car_Wash car_Wash = new Sparkling_Car_Wash();
                car_Wash.Show();
                this.Hide();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void rbAddVehicleType_CheckedChanged_1(object sender, EventArgs e)
        {
            //Disable controls not under the "Add Vehicle Type GroupBox"
            label2.Text = "";
            errorProvider1.Clear();
            groupBox3.Enabled = false;

            //Enable controls under the "Add Vehicle Type GroupBox"
            groupBox1.Enabled = true;

            //
        }

        private void rbDeleteVehicleType_CheckedChanged(object sender, EventArgs e)
        {
            //disable controls that are not under the Delete Vehicle Type GroupBox
            label12.Text = "";
            errorProvider1.Clear();
            groupBox1.Enabled = false;

            //Enable controls that are under the Delete VehicleType GroupBox

            groupBox3.Enabled = true;
        }
    }
}



