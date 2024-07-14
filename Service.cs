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
    public partial class Service : Form
    {
        private Form callingForm;
        public Service(Form callingForm)
        {
            InitializeComponent();
            this.callingForm = callingForm;
        }

        string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
        string activeName;

        SqlConnection connect;
        SqlCommand command;
        //SqlDataAdapter dataAdapter;
        SqlDataReader dataReader;
        //DataSet dataSet;

        //Method for populating the combobox of sercive names
        public void populateServNameCB(string sqlStatement)
        {
            connect = new SqlConnection(conString);

            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();

                command = new SqlCommand(sqlStatement, connect);
                dataReader = command.ExecuteReader();


                while (dataReader.Read())
                {
                    string servnameDelete = dataReader.GetValue(0).ToString();
                    string servnameUpdate = dataReader.GetValue(0).ToString();
                    cbServiceNameDelete.Items.Add(servnameDelete);
                    cbServiceNameUpdate.Items.Add(servnameUpdate);
                }

                connect.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //

        private void Service_Load(object sender, EventArgs e)
        {

            //Call the method for combobox population with relevent query statement
            populateServNameCB(@"SELECT ServiceName FROM [SERVICE]");


            connect = new SqlConnection(conString);
            errorProvider1.Clear();
            //This simply display the name of the active user on the form
            try
            {
                connect.Open();

                string query = $"SELECT * FROM [USERS] WHERE IsActive = 1";
                command = new SqlCommand(query, connect);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    activeName = dataReader.GetValue(1).ToString();
                }

                connect.Close();

                lblActiveUserServices.Text = "Active User: " + activeName;
                lblAddService.Visible = false;
                lblDeleteService.Visible = false;
                lblUpdateService.Visible = false;
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            //tbServiceNameAdd.Focus();

            /*Disable all features*/
            tbServiceDurationAdd.Enabled = false;
            tbServiceNameAdd.Enabled = false;
            tbServicePriceAdd.Enabled = false;

            cbServiceNameUpdate.Enabled = false;
            tbServicePriceUpdate.Enabled = false;
            tbServiceDurationUpdate.Enabled = false;

            cbServiceNameDelete.Enabled = false;
            btnServiceAdd.Enabled = false;
            btnServiceDelete.Enabled = false;
            btnServiceUpdate.Enabled = false;
        }

        private void btnCloseService_Click(object sender, EventArgs e)
        {
            try
            {
                callingForm.Show();
                this.Hide();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnServiceUpdate_Click(object sender, EventArgs e)
        {
            if (cbServiceNameUpdate.SelectedItem == null)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cbServiceNameUpdate, "Choose Service");
            }
            else if (tbServiceDurationUpdate.Text == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(tbServiceDurationUpdate, "Insert New Name");
            }
            else if (tbServicePriceUpdate.Text == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(tbServicePriceUpdate, "Insert new duration time");
            }
            else
            {
                connect = new SqlConnection(conString);

                string name = cbServiceNameUpdate.Text;
                double price = double.Parse(tbServicePriceUpdate.Text);
                string time = tbServiceDurationUpdate.Text;

                try
                {
                    if (connect.State == ConnectionState.Closed)
                        connect.Open();

                    string query = @"UPDATE [SERVICE] SET ServicePrice = @num, Duration = @time WHERE ServiceName = @name";

                    command = new SqlCommand(query, connect);
                    command.Parameters.AddWithValue("@num", price);
                    command.Parameters.AddWithValue("@time", time);
                    command.Parameters.AddWithValue("@name", name);



                    //display add and delete group boxes
                    //gbAddService.Visible = true;
                    //gbDeleteService.Visible = true;

                    //deselects update service radio button
                    rbUpdateService.Checked = false;

                    connect.Close();
                    cbServiceNameDelete.Items.Clear();
                    cbServiceNameUpdate.Items.Clear();
                    populateServNameCB(@"SELECT ServiceName FROM [SERVICE]");

                    //Display messagebox
                    DialogResult result = MessageBox.Show("You are about to add a service. Do you want to proceed?", "Confirmation", MessageBoxButtons.YesNo);

                    // Check the user's response
                    if (result == DialogResult.Yes)
                    {
                        // User clicked "Yes," so update label11
                        lblUpdateService.Text = "Service successfully updated";


                    }
                    else
                    {
                        lblUpdateService.Text = "Service not updated";
                    }
                    lblAddService.Visible = false;
                    lblDeleteService.Visible = false;
                    lblUpdateService.Visible = true;

                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);
                }
                errorProvider1.Clear();
                cbServiceNameDelete.SelectedIndex = -1;
                tbServiceDurationUpdate.Text = "";
                tbServicePriceUpdate.Text = "";
            }
        }

        private void btnServiceAdd_Click(object sender, EventArgs e)
        {
            connect = new SqlConnection(conString);

            if (tbServiceNameAdd.Text == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(tbServiceNameAdd, "Choose Service");
            }
            else if (tbServicePriceAdd.Text == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(tbServicePriceAdd, "Insert Price");
            }
            else if (tbServiceDurationAdd.Text == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(tbServiceDurationAdd, "Insert Time");
            }
            else
            {
                try
                {
                    if (connect.State == ConnectionState.Closed)
                        connect.Open();

                    string query = $"INSERT INTO [SERVICE] Values({tbServicePriceAdd.Text}, '{tbServiceNameAdd.Text}','{tbServiceDurationAdd.Text}')";
                    command = new SqlCommand(query, connect);
                    command.ExecuteNonQuery();



                    //deselects add service radio button
                    rbAddService.Checked = false;

                    //display update and delete group boxes
                    //gbDeleteService.Visible = true;
                    //gbUpdateService.Visible = true;

                    connect.Close();
                    cbServiceNameDelete.Items.Clear();
                    cbServiceNameUpdate.Items.Clear();
                    populateServNameCB(@"SELECT ServiceName FROM [SERVICE]");

                    lblAddService.Visible = true;
                    lblDeleteService.Visible = false;
                    lblUpdateService.Visible = false;


                    tbServiceNameAdd.Text = "";
                    tbServicePriceAdd.Text = "";
                    tbServiceDurationAdd.Text = "";
                    errorProvider1.Clear();

                    //Display messagebox
                    DialogResult result = MessageBox.Show("You are about to add a service. Do you want to proceed?", "Confirmation", MessageBoxButtons.YesNo);

                    // Check the user's response
                    if (result == DialogResult.Yes)
                    {
                        // User clicked "Yes," so update label11
                        lblAddService.Text = "Service successfully added";


                    }
                    else
                    {
                        lblAddService.Text = "Service not added";
                    }
                    lblAddService.Visible = true;
                    lblDeleteService.Visible = false;
                    lblUpdateService.Visible = false;
                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);
                }

            }
        }

        private void btnServiceDelete_Click(object sender, EventArgs e)
        {
            if (cbServiceNameDelete.SelectedItem == null)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cbServiceNameDelete, "Choose Service");
            }
            else
            {
                try
                {
                    connect = new SqlConnection(conString);
                    connect.Open();

                    string query = $"DELETE FROM [SERVICE] WHERE ServiceName = '{cbServiceNameDelete.Text}'";
                    command = new SqlCommand(query, connect);
                    command.ExecuteNonQuery();



                    //display add and update group boxes
                    //gbAddService.Visible = true;
                    //gbUpdateService.Visible = true;

                    //deselects delete service radio button
                    rbDeleteService.Checked = false;

                    cbServiceNameDelete.SelectedIndex = -1;

                    connect.Close();
                    cbServiceNameDelete.Items.Clear();
                    cbServiceNameUpdate.Items.Clear();
                    populateServNameCB(@"SELECT ServiceName FROM [SERVICE]");


                    //Display messagebox
                    DialogResult result = MessageBox.Show("You are about to add a service. Do you want to proceed?", "Confirmation", MessageBoxButtons.YesNo);

                    // Check the user's response
                    if (result == DialogResult.Yes)
                    {
                        // User clicked "Yes," so update label11
                        lblAddService.Text = "Service successfully deleted";


                    }
                    else
                    {
                        lblAddService.Text = "Service not deleted";
                    }
                    lblAddService.Visible = false;
                    lblDeleteService.Visible = true;
                    lblUpdateService.Visible = false;

                }
                catch (SqlException)
                {
                    MessageBox.Show("Service cannot be deleted as it is linked to an upcoming appointment");
                }
                errorProvider1.Clear();
                cbServiceNameDelete.SelectedIndex = -1;
            }
        }



        private void rbAddService_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAddService.Checked)
            {
                errorProvider1.Clear();
                /*Enable relevant features*/
                tbServiceDurationAdd.Enabled = true;
                tbServiceNameAdd.Enabled = true;
                tbServicePriceAdd.Enabled = true;
                btnServiceAdd.Enabled = true;

                tbServiceNameAdd.Focus();

                /*Disable irrelevent feature*/
                cbServiceNameDelete.Enabled = false;

                cbServiceNameUpdate.Enabled = false;
                tbServicePriceUpdate.Enabled = false;
                tbServiceDurationUpdate.Enabled = false;
                btnServiceDelete.Enabled = false;
                btnServiceUpdate.Enabled = false;

            }
            else if (rbDeleteService.Checked)
            {
                errorProvider1.Clear();
                /*Enable relevant features*/
                cbServiceNameDelete.Enabled = true;
                btnServiceDelete.Enabled = true;
                cbServiceNameDelete.SelectedIndex = -1;

                /*Disable irrelevent feature*/
                tbServiceDurationAdd.Enabled = false;
                tbServiceNameAdd.Enabled = false;
                tbServicePriceAdd.Enabled = false;

                cbServiceNameUpdate.Enabled = false;
                tbServicePriceUpdate.Enabled = false;
                tbServiceDurationUpdate.Enabled = false;
                btnServiceAdd.Enabled = false;
                btnServiceUpdate.Enabled = false;

            }
            else if (rbUpdateService.Checked)
            {
                errorProvider1.Clear();
                /*Enable relevant features*/
                cbServiceNameUpdate.Enabled = true;
                tbServicePriceUpdate.Enabled = true;
                tbServiceDurationUpdate.Enabled = true;

                /*Disable irrelevent feature*/
                tbServiceDurationAdd.Enabled = false;
                tbServiceNameAdd.Enabled = false;
                tbServicePriceAdd.Enabled = false;

                cbServiceNameDelete.Enabled = false;
                btnServiceAdd.Enabled = false;
                btnServiceDelete.Enabled = false;
                btnServiceUpdate.Enabled = true;
            }
            else
            {
                errorProvider1.Clear();

                /*Disable all features*/
                tbServiceDurationAdd.Enabled = false;
                tbServiceNameAdd.Enabled = false;
                tbServicePriceAdd.Enabled = false;

                cbServiceNameUpdate.Enabled = false;
                tbServicePriceUpdate.Enabled = false;
                tbServiceDurationUpdate.Enabled = false;

                cbServiceNameDelete.Enabled = false;
                btnServiceAdd.Enabled = false;
                btnServiceDelete.Enabled = false;
                btnServiceUpdate.Enabled = false;
            }
        }
    }
}




