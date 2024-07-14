using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sparkling_CarWash
{
    public partial class Book_Appointments : Form
    {
        private Form callingForm;
        public Book_Appointments(Form callingForm)
        {
            InitializeComponent();
            this.callingForm = callingForm;
        }
        frmWelcome q = new frmWelcome();  //Create an instance of the frmWelcome class
        
        SqlConnection connect;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        SqlDataReader dataReader;

        public double servicePrice = 0.0, addtionalPrice = 0.0, grandTotal = 0, vehicleTypePrice = 0;
        public int vehiclePK, emp1, emp2, servicePK, modelPK, vehicleTypePK, empAppPK, clientPK;
        string name, lastname, cellnumber;

        public void findPKVehicle(string sqlStatement)
        {
            try
            {
                connect = new SqlConnection(q.conString);
                connect.Open();

                command = new SqlCommand(sqlStatement, connect);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    vehiclePK = int.Parse(dataReader.GetValue(0).ToString());
                    modelPK = int.Parse(dataReader.GetValue(4).ToString());
                    clientPK = int.Parse(dataReader.GetValue(2).ToString());
                }

                connect.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void findPKModel(string sqlStatement)
        {
            try
            {
                connect = new SqlConnection(q.conString);
                connect.Open();

                command = new SqlCommand(sqlStatement, connect);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    vehicleTypePK = int.Parse(dataReader.GetValue(3).ToString());
                }

                connect.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void findPKVehicleType(string sqlStatement)
        {
            try
            {
                connect = new SqlConnection(q.conString);
                connect.Open();

                command = new SqlCommand(sqlStatement, connect);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    vehicleTypePrice = double.Parse(dataReader.GetValue(2).ToString());
                }

                connect.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void findPKService(string sqlStatement)
        {
            try
            {
                connect = new SqlConnection(q.conString);
                connect.Open();

                command = new SqlCommand(sqlStatement, connect);
                dataReader = command.ExecuteReader();


                while (dataReader.Read())
                {
                    servicePK = int.Parse(dataReader.GetValue(0).ToString());
                    servicePrice = double.Parse(dataReader.GetValue(1).ToString());
                }

                connect.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void findPKEmployee1(string sqlStatement)
        {
            try
            {
                connect = new SqlConnection(q.conString);
                connect.Open();

                command = new SqlCommand(sqlStatement, connect);
                dataReader = command.ExecuteReader();


                while (dataReader.Read())
                {
                    emp1 = int.Parse(dataReader.GetValue(0).ToString());
                }

                connect.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void findClientDetails(string sqlStatement)
        {
            try
            {

                connect = new SqlConnection(q.conString);
                connect.Open();

                command = new SqlCommand(sqlStatement, connect);
                dataReader = command.ExecuteReader();


                while (dataReader.Read())
                {
                    name = dataReader.GetValue(1).ToString();
                    lastname = dataReader.GetValue(2).ToString();
                    cellnumber = dataReader.GetValue(3).ToString();
                }
                lblClientDetails.Text = "Client: " + name + " " + lastname + " with cellphone number: " + cellnumber;
                connect.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnGetAdditionalFee_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbNumerPlateApp.Text == "")
                {
                    errorProvider1.SetError(tbNumerPlateApp, "Insert Numberplate");
                }
                else
                {
                    lblClientDetails.Visible = true;
                    findPKVehicle($"SELECT * FROM [VEHICLE] WHERE Vehicle_NumPlate = '{tbNumerPlateApp.Text}'");
                    findPKModel($"SELECT * FROM [MODEL] WHERE Model_ID = '{modelPK}'");
                    findPKVehicleType($"SELECT * FROM [VEHICLE_TYPE] WHERE Vehicle_type_ID = '{vehicleTypePK}'");
                    findClientDetails($"SELECT * FROM [CLIENT] WHERE CLient_ID = '{clientPK}'");
                    lblGrandTotal.Visible = true;
                    lblCalculation.Visible = true;
                    grandTotal = servicePrice + vehicleTypePrice;
                    lblGrandTotal.Text = "Total: R" + grandTotal;
                    lblCalculation.Text = "Sevice price = " + servicePrice + ", additional price = " + vehicleTypePrice;
                    errorProvider1.Clear();
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnRequestReports_Click_1(object sender, EventArgs e)
        {
            Reports report = new Reports(this);
            report.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
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

        private void cbEmployee1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string emp1Name = cbEmployee1.SelectedItem as string;
            string emp2Name = cbEmployee2.SelectedItem as string;

            if (string.Equals(emp1Name, emp2Name, StringComparison.OrdinalIgnoreCase))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cbEmployee1, "Employee already selected");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void cbEmployee2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string emp1Name = cbEmployee1.SelectedItem as string;
            string emp2Name = cbEmployee2.SelectedItem as string;

            if (string.Equals(emp2Name, emp1Name, StringComparison.OrdinalIgnoreCase))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cbEmployee2, "Employee already selected");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void cbTimeSlot_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (dateTimePicker1.Value < DateTime.Now)
                {
                    errorProvider1.SetError(dateTimePicker1, "Date has passed");
                }
                else
                {
                    if (dateTimePicker1.Value == DateTime.Now)
                    {
                        errorProvider1.Clear();
                    }
                    else
                    {
                        errorProvider1.Clear();
                    }
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
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

        private void btnDeleteAppointment_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbAppointmentID.Text == "")
                {
                    errorProvider1.SetError(tbAppointmentID, "Insert Primary Key of Appointment_ID");
                }
                else
                {
                    connect = new SqlConnection(q.conString);
                    string sql1 = $"DELETE FROM [APPOINTMENT] WHERE App_ID = '{tbAppointmentID.Text}'";
                    connect.Open();
                    command = new SqlCommand(sql1, connect);
                    dataAdapter = new SqlDataAdapter();
                    dataAdapter.DeleteCommand = command;
                    dataAdapter.DeleteCommand.ExecuteNonQuery();

                    connect.Close();
                    tbAppointmentID.Text = "";

                    connect = new SqlConnection(q.conString);
                    string sql2 = $"SELECT App_ID, App_Date_Time, Grand_Total, Vehicle_NumPlate, ServiceName FROM [APPOINTMENT], [VEHICLE], [SERVICE] WHERE App_Date_Time > '{DateTime.Now.ToString()}' AND VEHICLE.Vehicle_ID = APPOINTMENT.Vehicle_ID AND SERVICE.Service_ID = APPOINTMENT.Service_ID";

                    connect.Open();
                    dataAdapter = new SqlDataAdapter();
                    command = new SqlCommand(sql2, connect);
                    DataSet ds = new DataSet();
                    dataAdapter.SelectCommand = command;
                    dataAdapter.Fill(ds, "[APPOINTMENTs]");

                    dgvUpcomingAppointment.DataSource = ds;
                    dgvUpcomingAppointment.DataMember = "[APPOINTMENTs]";
                    connect.Close();
                }
                errorProvider1.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("This appiontment cannot be deleted becuase it linked to Employee_Appointment.");
            }
        }

        public void findPKEmployee2(string sqlStatement)
        {
            try
            {
                connect = new SqlConnection(q.conString);
                connect.Open();

                command = new SqlCommand(sqlStatement, connect);
                dataReader = command.ExecuteReader();


                while (dataReader.Read())
                {
                    emp2 = int.Parse(dataReader.GetValue(0).ToString());
                }

                connect.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnCloseAppointments_Click(object sender, EventArgs e)
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

        //Method for populating the combobox of employee names
        public void populateEmployeeNameCB(string sqlStatement)
        {
            try
            {
                connect = new SqlConnection(q.conString);
                connect.Open();

                command = new SqlCommand(sqlStatement, connect);
                dataReader = command.ExecuteReader();


                while (dataReader.Read())
                {
                    string employee1 = dataReader.GetValue(0).ToString();
                    string employee2 = dataReader.GetValue(0).ToString();
                    cbEmployee1.Items.Add(employee1);
                    cbEmployee2.Items.Add(employee2);
                }

                connect.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //Method for populating the combobox of service names
        public void populateServNameCB(string sqlStatement)
        {
            try
            {
                connect = new SqlConnection(q.conString);
                connect.Open();

                command = new SqlCommand(sqlStatement, connect);
                dataReader = command.ExecuteReader();


                while (dataReader.Read())
                {
                    string servnameApp = dataReader.GetValue(0).ToString();
                    cbService.Items.Add(servnameApp);

                }

                connect.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void empApp(string sqlStatement)
        {
            try
            {
                connect = new SqlConnection(q.conString);
                connect.Open();

                command = new SqlCommand(sqlStatement, connect);
                dataReader = command.ExecuteReader();


                while (dataReader.Read())
                {
                    empAppPK = int.Parse(dataReader.GetValue(0).ToString());
                }

                connect.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void cbService_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                connect = new SqlConnection(q.conString);
                connect.Open();

                command = new SqlCommand($"SELECT * FROM [SERVICE] WHERE ServiceName LIKE '%{cbService.SelectedItem}%'", connect);
                dataReader = command.ExecuteReader();


                while (dataReader.Read())
                {
                    servicePrice = double.Parse(dataReader.GetValue(1).ToString());
                }
                lblGrandTotal.Visible = true;
                lblCalculation.Visible = true;
                grandTotal = servicePrice + vehicleTypePrice;
                lblGrandTotal.Text = "Total: R" + grandTotal;
                lblCalculation.Text = "Sevice price = " + servicePrice + ", additional price = " + vehicleTypePrice;

                connect.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnConfirmBooking_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbTimeSlot.SelectedItem == null)
                {
                    errorProvider1.SetError(cbTimeSlot, "Choose Time Slot");
                }
                else if (cbService.SelectedItem == null)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(cbService, "Choose Service");
                }
                else if (tbNumerPlateApp.Text == "")
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(tbNumerPlateApp, "Insert Number plate");
                }
                else if (cbEmployee1.SelectedItem == null)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(cbEmployee1, "Choose Employee 1");
                }
                else if (cbEmployee2.SelectedItem == null)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(cbEmployee2, "Choose Employee 2");
                }
                else
                {
                    findPKVehicle($"SELECT * FROM [VEHICLE] WHERE Vehicle_NumPlate LIKE '%{tbNumerPlateApp.Text}%'");
                    findPKEmployee1($"SELECT * FROM [EMPLOYEE] WHERE EmpFirstName LIKE '%{cbEmployee1.SelectedItem}%'");
                    findPKEmployee2($"SELECT * FROM [EMPLOYEE] WHERE EmpFirstName LIKE '%{cbEmployee2.SelectedItem}%'");
                    findPKService($"SELECT * FROM [SERVICE] WHERE ServiceName LIKE '%{cbService.SelectedItem}%'");
                    findPKModel($"SELECT * FROM [MODEL] WHERE Model_ID = '{modelPK}'");
                    findPKVehicleType($"SELECT * FROM [VEHICLE_TYPE] WHERE Vehicle_type_ID = '{vehicleTypePK}'");
                    empApp($"SELECT * FROM [APPOINTMENT]");

                    grandTotal = servicePrice + vehicleTypePrice;
                    // string time = string.Format(dateTimePicker1.CustomFormat);
                    connect = new SqlConnection(q.conString);
                    string sql = $"INSERT INTO [APPOINTMENT](App_Date_Time, Grand_Total, Vehicle_ID, Service_ID) VALUES('{this.dateTimePicker1.Text + " " + cbTimeSlot.SelectedItem}','{grandTotal}','{vehiclePK}','{servicePK}')";
                    connect.Open();
                    command = new SqlCommand(sql, connect);
                    dataAdapter = new SqlDataAdapter();
                    dataAdapter.InsertCommand = command;
                    dataAdapter.InsertCommand.ExecuteNonQuery();
                    connect.Close();
                    cbEmployee1.SelectedItem = null;
                    cbEmployee2.SelectedItem = null;
                    cbService.SelectedItem = null;
                    tbNumerPlateApp.Text = "";
                    lblAppointmentMessage.Text = "Appointment Booked";
                    lblAppointmentMessage.Visible = true;

                    //Showing upcoming appointments 
                    string sq32 = $"SELECT App_ID, App_Date_Time, Grand_Total, Vehicle_NumPlate, ServiceName FROM [APPOINTMENT], [VEHICLE], [SERVICE] WHERE App_Date_Time > '{DateTime.Now.ToString()}' AND VEHICLE.Vehicle_ID = APPOINTMENT.Vehicle_ID AND SERVICE.Service_ID = APPOINTMENT.Service_ID";
                    connect.Open();
                    command = new SqlCommand(sq32, connect);
                    dataAdapter = new SqlDataAdapter();
                    DataSet ds = new DataSet();

                    dataAdapter.SelectCommand = command;
                    dataAdapter.Fill(ds, "[APPIONTMENTs]");

                    dgvUpcomingAppointment.DataSource = ds;
                    dgvUpcomingAppointment.DataMember = "[APPIONTMENTs]";
                    connect.Close();

                    string sql2 = $"INSERT INTO [EMPLOYEE_APPOINTMENT](Employee_ID, App_ID, Employee_ID2) VALUES('{emp1}','{empAppPK}','{emp2}')";
                    connect.Open();
                    command = new SqlCommand(sql2, connect);
                    SqlDataAdapter dataAdapter1 = new SqlDataAdapter();
                    dataAdapter1.InsertCommand = command;
                    dataAdapter1.InsertCommand.ExecuteNonQuery();
                    connect.Close();

                    string sql1 = $"SELECT* FROM [EMPLOYEE_APPOINTMENT]";
                    connect.Open();
                    command = new SqlCommand(sql1, connect);
                    dataAdapter = new SqlDataAdapter();
                    // DataSet ds = new DataSet();

                    dataAdapter.SelectCommand = command;
                    dataAdapter.Fill(ds, "[EMPLOYEE_APPOINTMENTs]");

                    dgvEmpApp.DataSource = ds;
                    dgvEmpApp.DataMember = "[EMPLOYEE_APPOINTMENTs]";
                    connect.Close();
                    cbTimeSlot.SelectedIndex = -1;
                    lblGrandTotal.Visible = false;
                    lblCalculation.Visible = false;
                    lblClientDetails.Visible = false;

                    errorProvider1.Clear();
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }
        string activeName;
        bool rank;
        
        //Method for checking if user is a manager
        public void checkRank(string sqlStatement)
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
                    rank = bool.Parse((dataReader.GetValue(3).ToString()));
                }

                connect.Close();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }


        private void Book_Appointments_Load_1(object sender, EventArgs e)
        {
            checkRank(@"SELECT * FROM [USERS] WHERE IsActive = 1");

            if (rank == false)
                btnRequestReports.Enabled = false;
            else if (rank == true)
                btnRequestReports.Enabled = true;
            else
            {
                MessageBox.Show("Something went wrong with validating your rank, Request Reports will be disabled");
                btnRequestReports.Enabled = false;
            }

            try
            {
                q.activeUser(q, lblActiveUserApp);
                connect = new SqlConnection(q.conString);
                connect.Open();

                string query = $"SELECT * FROM [USERS] WHERE IsActive = 1";
                command = new SqlCommand(query, connect);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    activeName = dataReader.GetValue(1).ToString();
                }

                connect.Close();

                lblActiveUserApp.Text = "Active User: " + activeName;
                lblClientDetails.Visible = false;
                lblAppointmentMessage.Visible = false;
                lblGrandTotal.Visible = false;
                lblGrandTotal.Visible = false;
                lblCalculation.Visible = false;
                //Call the methods for combobox population with relevent query statement
                populateServNameCB(@"SELECT ServiceName FROM [SERVICE]");
                populateEmployeeNameCB(@"SELECT EmpFirstName FROM [EMPLOYEE]");
                lblGrandTotal.Text = " ";

                //Showing upcoming appointments 
                connect = new SqlConnection(q.conString);
                string sql = $"SELECT App_ID, App_Date_Time, Grand_Total, Vehicle_NumPlate, ServiceName FROM [APPOINTMENT], [VEHICLE], [SERVICE] WHERE App_Date_Time > '{DateTime.Now.ToString()}' AND VEHICLE.Vehicle_ID = APPOINTMENT.Vehicle_ID AND SERVICE.Service_ID = APPOINTMENT.Service_ID";
                connect.Open();
                command = new SqlCommand(sql, connect);
                dataAdapter = new SqlDataAdapter();
                DataSet ds = new DataSet();

                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(ds, "[APPIONTMENTs]");

                dgvUpcomingAppointment.DataSource = ds;
                dgvUpcomingAppointment.DataMember = "[APPIONTMENTs]";
                connect.Close();

                //Displying the EMPLOYEE_APPOINTMENT
                connect = new SqlConnection(q.conString);
                string sql1 = $"SELECT * FROM [EMPLOYEE_APPOINTMENT]";
                connect.Open();
                command = new SqlCommand(sql1, connect);
                dataAdapter = new SqlDataAdapter();
                //DataSet ds = new DataSet();

                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(ds, "[EMPLOYEE_APPOINTMENTs]");

                dgvEmpApp.DataSource = ds;
                dgvEmpApp.DataMember = "[EMPLOYEE_APPOINTMENTs]";
                connect.Close();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}




