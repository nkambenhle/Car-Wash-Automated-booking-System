using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sparkling_CarWash
{
    public partial class Employees : Form
    {
        frmWelcome q = new frmWelcome();
        // Declare variables and connection string
        private Form callingForm;
        SqlConnection conn;
        SqlCommand comm;
        SqlDataAdapter adapt;
        DataSet ds;

        public Employees(Form callingForm)
        {
            InitializeComponent();
            this.callingForm = callingForm;
        }

        public void noneSelected()  //this method is for when no radioButton is checked
        {
            if (rbAddEmployee.Checked == false && rbDeleteEmployee.Checked == false && rbUpdateEmployee.Checked == false)
            {
                gbAddEmployee.Enabled = false;
                gbDeleteEmployee.Enabled = false;
                gbUpdateEmployee.Enabled = false;

            }
        }


        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            //Exception handling
            try
            {

                if (tbCellNumberUpdate.Text == "")
                {
                    if (tbSurnameUpdate.Text == "")
                    {
                        errorProvider1.Clear();
                        errorProvider1.SetError(tbSurnameUpdate, "Insert Surname");
                    }
                    else
                    {
                        //Declare new SqlConnnection and open connection
                        conn = new SqlConnection(q.conString);
                        conn.Open();
                        //Declare sql statement
                        string updatesql = $"UPDATE [EMPLOYEE] SET EmpLastName = '{tbSurnameUpdate.Text}', Employee_Cell = '{tbCellNumberUpdate.Text}' WHERE Employee_ID = '{tbEmployeeIDUpdate.Text}'";

                        //Declare new SqlCommand and SqlDataAdapter.
                        comm = new SqlCommand(updatesql, conn);
                        adapt = new SqlDataAdapter();

                        //Declare InsertCommand and use ExecuteNonQuery.
                        adapt.UpdateCommand = comm;
                        adapt.UpdateCommand.ExecuteNonQuery();

                        tbSurnameUpdate.Text = "";
                        tbCellNumberUpdate.Text = "";
                        tbEmployeeIDUpdate.Text = "";



                        //Display message.
                        lblUpdatedSuccessfully.Visible = true;
                        //Display messagebox
                        DialogResult result = MessageBox.Show("You are about to update an employee's surname. Do you want to proceed?", "Confirmation", MessageBoxButtons.YesNo);

                        // Check the user's response
                        if (result == DialogResult.Yes)
                        {
                            // User clicked "Yes," so update label11
                            lblUpdatedSuccessfully.Text = "Employee surname successfully updated";
                            noneSelected();
                        }
                        else
                        {
                            lblUpdatedSuccessfully.Text = "Employee surname not updated";
                            noneSelected();
                        }
                        noneSelected();
                    }
                }
                else if (tbSurnameUpdate.Text == "")
                {
                    if (tbCellNumberUpdate.Text == "")
                    {
                        errorProvider1.Clear();
                        errorProvider1.SetError(tbCellNumberUpdate, "Insert Cellphone Number");
                    }
                    else if (tbCellNumberUpdate.TextLength != 10)
                    {
                        errorProvider1.Clear();
                        errorProvider1.SetError(tbCellNumberUpdate, "Cellphone number not 10 didgits");


                    }
                    else if (!(Int32.TryParse(tbCellNumberUpdate.Text, out int cellNumber)))
                    {
                        errorProvider1.Clear();
                        errorProvider1.SetError(tbCellNumberUpdate, "Please enter valid number");

                    }
                    else
                    {
                        //Declare new SqlConnnection and open connection
                        conn = new SqlConnection(q.conString);
                        conn.Open();
                        //Declare sql statement
                        string updatesql = $"UPDATE [EMPLOYEE] SET EmpLastName = '{tbSurnameUpdate.Text}', Employee_Cell = '{tbCellNumberUpdate.Text}' WHERE Employee_ID = '{tbEmployeeIDUpdate.Text}'";

                        //Declare new SqlCommand and SqlDataAdapter.
                        comm = new SqlCommand(updatesql, conn);
                        adapt = new SqlDataAdapter();

                        //Declare InsertCommand and use ExecuteNonQuery.
                        adapt.UpdateCommand = comm;
                        adapt.UpdateCommand.ExecuteNonQuery();

                        tbSurnameUpdate.Text = "";
                        tbCellNumberUpdate.Text = "";
                        tbEmployeeIDUpdate.Text = "";

                        //Display message
                        lblUpdatedSuccessfully.Visible = true;
                        //Display messagebox
                        DialogResult result = MessageBox.Show("You are about to update an employee's cellphone number. Do you want to proceed?", "Confirmation", MessageBoxButtons.YesNo);

                        // Check the user's response
                        if (result == DialogResult.Yes)
                        {
                            // User clicked "Yes," so update label11
                            lblUpdatedSuccessfully.Text = "Employee cellphone number updated";
                            noneSelected();
                        }
                        else
                        {
                            lblUpdatedSuccessfully.Text = "Employee cellphone number not updated";
                            noneSelected();
                        }
                    }
                }
                else
                {
                    //Declare new SqlConnnection and open connection
                    conn = new SqlConnection(q.conString);
                    conn.Open();
                    //Declare sql statement
                    string updatesql = $"UPDATE [EMPLOYEE] SET EmpLastName = '{tbSurnameUpdate.Text}', Employee_Cell = '{tbCellNumberUpdate.Text}' WHERE Employee_ID = '{tbEmployeeIDUpdate.Text}'";

                    //Declare new SqlCommand and SqlDataAdapter.
                    comm = new SqlCommand(updatesql, conn);
                    adapt = new SqlDataAdapter();

                    //Declare InsertCommand and use ExecuteNonQuery.
                    adapt.UpdateCommand = comm;
                    adapt.UpdateCommand.ExecuteNonQuery();

                    tbSurnameUpdate.Text = "";
                    tbCellNumberUpdate.Text = "";
                    tbEmployeeIDUpdate.Text = "";

                    /*ds = new DataSet();
                    adapt.SelectCommand = comm;
                    adapt.Fill(ds, "[Employees]");

                    dgvEmployeeUpdate.DataSource = ds;
                    dgvEmployeeUpdate.DataMember = "[Employees]";
                    conn.Close();*/


                    //Close connection
                    conn.Close();
                    errorProvider1.Clear();
                    lblAddedSuccessfully.Visible = false;
                    lblDeletedSuccessfully.Visible = false;
                    lblUpdatedSuccessfully.Visible = true;
                    //Display messagebox
                    DialogResult result = MessageBox.Show("You are about to update an employee. Do you want to proceed?", "Confirmation", MessageBoxButtons.YesNo);

                    // Check the user's response
                    if (result == DialogResult.Yes)
                    {
                        // User clicked "Yes," so update label11
                        lblUpdatedSuccessfully.Text = "Employee successfully updated";
                        noneSelected();
                    }
                    else
                    {
                        lblUpdatedSuccessfully.Text = "Employee not updated";
                        noneSelected();
                    }

                }

            }
            catch (Exception er)
            {
                //Display error message.
                MessageBox.Show("Error occured at: \t " + er.ToString());
            }

        }

        private void btnDeleteEmployees_Click_2(object sender, EventArgs e)
        {
            try
            {
                if (tbEmployeeIDDelete.Text == "")
                {
                    errorProvider1.SetError(tbEmployeeIDDelete, "Insert ID Number");
                }
                else
                {
                    conn = new SqlConnection(q.conString);
                    //Open Connection.
                    conn.Open();

                    //Provide string.
                    string sql = "DELETE FROM [EMPLOYEE] WHERE Employee_ID LIKE '%" + tbEmployeeIDDelete.Text + "'";
                    comm = new SqlCommand(sql, conn);
                    adapt = new SqlDataAdapter();
                    adapt.DeleteCommand = comm;
                    adapt.DeleteCommand.ExecuteNonQuery();

                    tbEmployeeIDDelete.Text = "";

                    //Close connection
                    conn.Close();
                    errorProvider1.Clear();
                    lblAddedSuccessfully.Visible = false;
                    lblDeletedSuccessfully.Visible = true;
                    lblUpdatedSuccessfully.Visible = false;
                    lblDeletedSuccessfully.Text = "Employee successfully deleted";
                    tbEmpIDNumberDelete.Text = "";

                    /*//display add and update group boxes
                    gbAddEmployee.Visible = true;
                    gbUpdateEmployee.Visible = true;*/

                    //deselects delete employee radio button
                    rbDeleteEmployee.Checked = false;
                    //Display messagebox
                    DialogResult result = MessageBox.Show("You are about to delete an employee number. Do you want to proceed?", "Confirmation", MessageBoxButtons.YesNo);

                    // Check the user's response
                    if (result == DialogResult.Yes)
                    {
                        // User clicked "Yes," so update label11
                        lblDeletedSuccessfully.Text = "Employee number successfully deleted";
                        noneSelected();
                    }
                    else
                    {
                        lblDeletedSuccessfully.Text = "Employee not deleted";
                    }

                    noneSelected();
                }

            }
            catch (Exception)
            {
                //Display error message
                MessageBox.Show("This employee cannot be deleted as they are already assigned to an appointment");
            }

        }

        private void btnAddEmployees_Click(object sender, EventArgs e)
        {
            //Exception handling
            try
            {
                if (tbEmployeeName.Text == "")
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(tbEmployeeName, "Insert Name");
                }
                else if (tbEmployeeSurnameAdd.Text == "")
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(tbEmployeeSurnameAdd, "Insert Surname");
                }
                else if (tbEmpIDNumberAdd.Text == "")
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(tbEmpIDNumberAdd, "Insert ID Number");
                }
                else if (tbEmpIDNumberAdd.TextLength != 13)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(tbEmpIDNumberAdd, "ID number not 13 digits");
                }
                else if (!(Int32.TryParse(tbEmpCellNumberAdd.Text, out int cellNumber)))
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(tbEmpCellNumberAdd, "Please enter valid number");
                }
                else if (tbEmpCellNumberAdd.Text == "")
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(tbEmpCellNumberAdd, "Insert Cellphone numbers");
                }
                else if (tbEmpCellNumberAdd.TextLength != 10)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(tbEmpCellNumberAdd, "Cellphone number not 10 digits");
                }
                else
                {
                    //Declare new SqlConnnection and open connection
                    conn = new SqlConnection(q.conString);
                    conn.Open();
                    //Declare sql statement
                    string insertsql = "INSERT INTO [EMPLOYEE](EmpFirstName, EmpLastName, EmpLoyee_ID_Num, Employee_Cell) VALUES('" + tbEmployeeName.Text + "' ,'" + tbEmployeeSurnameAdd.Text + "' ,'" + tbEmpIDNumberAdd.Text + "' ,'" + tbEmpCellNumberAdd.Text + "')";

                    //Declare new SqlCommand and SqlDataAdapter.
                    comm = new SqlCommand(insertsql, conn);
                    adapt = new SqlDataAdapter();

                    //Declare InsertCommand and use ExecuteNonQuery.
                    adapt.InsertCommand = comm;
                    adapt.InsertCommand.ExecuteNonQuery();

                    tbEmployeeName.Text = "";
                    tbEmployeeSurnameAdd.Text = "";
                    tbEmpCellNumberAdd.Text = "";
                    tbEmpIDNumberAdd.Text = "";


                    //Close connection
                    conn.Close();
                    errorProvider1.Clear();
                    lblAddedSuccessfully.Visible = true;
                    lblDeletedSuccessfully.Visible = false;
                    lblUpdatedSuccessfully.Visible = false;
                    lblAddedSuccessfully.Text = "Employee successfully added";

                    //deselects add employee radio button
                    rbAddEmployee.Checked = false;
                    noneSelected();
                    /*//display update and delete group boxes
                    gbDeleteEmployee.Visible = true;
                    gbUpdateEmployee.Visible = true;*/

                    //Display messagebox
                    DialogResult result = MessageBox.Show("You are about to add an employee. Do you want to proceed?", "Confirmation", MessageBoxButtons.YesNo);

                    // Check the user's response
                    if (result == DialogResult.Yes)
                    {
                        // User clicked "Yes," so update label11
                        lblAddedSuccessfully.Text = "Employee successfully added";


                    }
                    else
                    {
                        lblAddedSuccessfully.Text = "Employee not added";
                    }

                }


            }
            catch (Exception er)
            {
                //Display error message.
                MessageBox.Show("Error occured at: \t " + er.ToString());
            }
        }

        private void btnEmpDeleteSearch_Click_2(object sender, EventArgs e)
        {
            //Use Exception Handling.
            try
            {
                if (tbEmpIDNumberDelete.TextLength != 13)
                {
                    errorProvider1.SetError(tbEmpIDNumberDelete, "Employee ID not 13 digits");
                }
                else
                {
                    conn = new SqlConnection(q.conString);
                    //Open Connection.
                    conn.Open();

                    //Provide string.
                    string sql = "SELECT Employee_ID FROM [EMPLOYEE] WHERE Employee_ID_Num LIKE '%" + tbEmpIDNumberDelete.Text + "'";
                    comm = new SqlCommand(sql, conn);
                    adapt = new SqlDataAdapter();
                    adapt.SelectCommand = comm;

                    ds = new DataSet();
                    adapt.Fill(ds, "[EMPLOYEEs]");

                    //View on Datagrid
                    dgvEmployeeDelete.DataSource = ds;
                    dgvEmployeeDelete.DataMember = "[EMPLOYEEs]";

                    //Close connection
                    conn.Close();
                    errorProvider1.Clear();

                }
            }
            catch (Exception er)
            {
                //Display Messagebox.
                MessageBox.Show("Error occured at: \t" + er.ToString());
            }
        }

        private void btnEmpUpdateSearch_Click(object sender, EventArgs e)
        {
            //Use Exception Handling.
            try
            {
                if (tbEmpIDNumberUpdate.TextLength != 13)
                {
                    errorProvider1.SetError(tbEmpIDNumberUpdate, "Employee ID not 13 digits");
                }
                else
                {
                    conn = new SqlConnection(q.conString);
                    //Open Connection.
                    conn.Open();

                    //Provide string.
                    string sql = "SELECT Employee_ID FROM [EMPLOYEE] WHERE Employee_ID_Num LIKE '%" + tbEmpIDNumberUpdate.Text + "'";
                    comm = new SqlCommand(sql, conn);
                    adapt = new SqlDataAdapter();
                    adapt.SelectCommand = comm;

                    ds = new DataSet();
                    adapt.Fill(ds, "[EMPLOYEEs]");

                    //View on Datagrid
                    dgvEmployeeUpdate.DataSource = ds;
                    dgvEmployeeUpdate.DataMember = "[EMPLOYEEs]";

                    //Close connection
                    conn.Close();
                    errorProvider1.Clear();

                }

            }
            catch (Exception er)
            {
                //Display Messagebox.
                MessageBox.Show("Error occured at: \t" + er.ToString());
            }
        }

        private void btnCloseEmployees_Click_1(object sender, EventArgs e)
        {
            try
            {
                callingForm.Show();
                this.Hide();
            }
            catch (Exception er)
            {
                //Display error message.
                MessageBox.Show("Error occured at: \t " + er.ToString());
            }
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            //This simply display the name of the active user on the form
            try
            {
                q.activeUser(q, lblActiveUserEmployees);
                gbAddEmployee.Enabled = false;
                gbDeleteEmployee.Enabled = false;
                gbUpdateEmployee.Enabled = false;

                tbEmployeeName.Focus();
                lblAddedSuccessfully.Visible = false;
                lblDeletedSuccessfully.Visible = false;
                lblUpdatedSuccessfully.Visible = false;

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void rbAddEmployee_CheckedChanged_1(object sender, EventArgs e)
        {

            //controls to be displayed when adding an employee
            gbAddEmployee.Enabled = true;

            //controls to be hidden when adding an employee
            gbDeleteEmployee.Enabled = false;
            gbUpdateEmployee.Enabled = false;

            //sets focus on employee name
            tbEmployeeName.Focus();
        }

        private void rbDeleteEmployee_CheckedChanged_1(object sender, EventArgs e)
        {

            //controls to be displayed when deleting an employee
            gbDeleteEmployee.Enabled = true;

            //controls to be hidden when adding an employee
            gbAddEmployee.Enabled = false;
            gbUpdateEmployee.Enabled = false;

            //sets focus on employee ID number
            tbEmpIDNumberDelete.Focus();
        }

        private void rbUpdateEmployee_CheckedChanged_1(object sender, EventArgs e)
        {
            //controls to be displayed when deleting an employee
            gbUpdateEmployee.Enabled = true;

            //controls to be hidden when adding an employee
            gbAddEmployee.Enabled = false;
            gbDeleteEmployee.Enabled = false;

            //sets focus on employee ID number
            tbEmpIDNumberUpdate.Focus();
        }
    }
}






