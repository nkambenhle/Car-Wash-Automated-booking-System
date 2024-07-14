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
    public partial class Clients : Form
    {
        frmWelcome q = new frmWelcome();
        private Form callingForm;
        public Clients(Form callingForm)
        {
            InitializeComponent();
            this.callingForm = callingForm;
        }
        


        SqlConnection conn;
        SqlCommand command;
        SqlDataAdapter adapter;
        DataSet ds;

        private void frmClients_Load(object sender, EventArgs e)
        {
            try
            {
                //disabling everything
                tbClientCellNum.Enabled = false;
                tbClientName.Enabled = false;
                lblClientName.Enabled = false;
                tbClientSurname.Enabled = false;
                lblClientSurname.Enabled = false;
                btnUpdateClient.Enabled = false;
                btnAddClient.Enabled = false;
                btnAddClient.Enabled = false;
                btnDeleteClient.Enabled = false;
                lblClientID.Enabled = false;
                tbClientID.Enabled = false;
                btnClientsSearch.Enabled = false;
                btnUpdateClient.Enabled = false;
                btnDeleteClient.Enabled = false;


                q.activeUser(q, lblActiveUserClients);
                conn = new SqlConnection(q.conString);

                lblClientErrorMeassge.Visible = false;
                
                string sql = $"SELECT * FROM [ClIENT]";

                conn.Open();
                adapter = new SqlDataAdapter();
                command = new SqlCommand(sql, conn);
                ds = new DataSet();
                adapter.SelectCommand = command;
                adapter.Fill(ds, "[Cleints]");

                dgvClients.DataSource = ds;
                dgvClients.DataMember = "[Cleints]";
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.ToString());
            }

        }

        private void btnAddClient_Click_1(object sender, EventArgs e)
        {

            try
            {
                if (tbClientName.Text == "")
                {
                    errorProvider1.SetError(tbClientName, "Insert Name");
                }
                else if (tbClientSurname.Text == "")
                {
                    errorProvider1.SetError(tbClientSurname, "Insert Surname");
                }
                else if (tbClientCellNum.Text == "")
                {
                    errorProvider1.SetError(tbClientCellNum, "Insert Cellphone numbers");
                }
                else if (tbClientCellNum.TextLength != 10)
                {
                    errorProvider1.SetError(tbClientCellNum, "Cellphone number not 10 digits");
                }
                else
                {
                    string sql = $"INSERT INTO [CLIENT](ClientFirstName, ClientLastName, ClientCellNumber) VALUES('{tbClientName.Text}', '{tbClientSurname.Text}', '{tbClientCellNum.Text}')";
                    conn = new SqlConnection(q.conString);
                    conn.Open();
                    adapter = new SqlDataAdapter();
                    command = new SqlCommand(sql, conn);
                    adapter.InsertCommand = command;
                    adapter.InsertCommand.ExecuteNonQuery();
                    conn.Close();
                    tbClientName.Text = "";
                    tbClientSurname.Text = "";
                    tbClientCellNum.Text = "";
                    lblClientErrorMeassge.Visible = true;
                    lblClientErrorMeassge.Text = "Succesfully added";
                    conn = new SqlConnection(q.conString);
                    string sql2 = $"SELECT * FROM [ClIENT]";

                    conn.Open();
                    adapter = new SqlDataAdapter();
                    command = new SqlCommand(sql2, conn);
                    ds = new DataSet();
                    adapter.SelectCommand = command;
                    adapter.Fill(ds, "[Cleints]");

                    dgvClients.DataSource = ds;
                    dgvClients.DataMember = "[Cleints]";
                    conn.Close();

                    
                    tbClientID.Text = "";
                   
                    //display hidden controls
                    lblClientID.Visible = true;
                    tbClientID.Enabled = true;
                    btnClientsSearch.Enabled = true;
                    btnUpdateClient.Enabled = true;
                    btnDeleteClient.Enabled = true;

                    //deselects the add client radio button
                    rbAddClient.Checked = false;
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Couldn't add clint");
            }
        }

        private void btnUpdateClient_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (tbClientID.Text == "")
                {
                    errorProvider1.SetError(tbClientID, "Insert Primary Key");
                }
                else
                {
                    if (tbClientCellNum.Text == "")
                    {
                        if (tbClientSurname.Text == "")
                        {
                            errorProvider1.SetError(tbClientSurname, "Insert Surname");
                        }
                        else
                        {
                            string sql = $"UPDATE [CLIENT] SET ClientLastName = '{tbClientSurname.Text}' WHERE Client_ID = '{tbClientID.Text}'";
                            conn = new SqlConnection(q.conString);
                            conn.Open();
                            adapter = new SqlDataAdapter();
                            command = new SqlCommand(sql, conn);
                            adapter.UpdateCommand = command;
                            adapter.UpdateCommand.ExecuteNonQuery();
                            conn.Close();
                            tbClientName.Text = "";
                            tbClientSurname.Text = "";
                            tbClientCellNum.Text = "";
                            tbClientID.Text = "";
                            lblClientErrorMeassge.Visible = true;
                            lblClientErrorMeassge.Text = "Succesfully Updated";

                            //display hidden controls
                            btnAddClient.Enabled = true;
                            btnDeleteClient.Enabled = true;

                            //deselects the update client radio button
                            rbUpdateClient.Checked = false;
                        }
                    }
                    else if (tbClientSurname.Text == "")
                    {
                        if (tbClientCellNum.Text == "")
                        {
                            errorProvider1.SetError(tbClientCellNum, "Insert Cellphone Number");
                        }
                        else
                        {
                            string sql = $"UPDATE [CLIENT] SET ClientCellNumber = '{tbClientCellNum.Text}' WHERE Client_ID = '{tbClientID.Text}'";
                            conn = new SqlConnection(q.conString);
                            conn.Open();
                            adapter = new SqlDataAdapter();
                            command = new SqlCommand(sql, conn);
                            adapter.UpdateCommand = command;
                            adapter.UpdateCommand.ExecuteNonQuery();
                            conn.Close();
                            tbClientName.Text = "";
                            tbClientSurname.Text = "";
                            tbClientCellNum.Text = "";
                            lblClientErrorMeassge.Visible = true;
                            lblClientErrorMeassge.Text = "Succesfully Updated";

                            //display hidden controls
                            btnAddClient.Enabled = true;
                            btnDeleteClient.Enabled = true;

                            //deselects the update client radio button
                            rbUpdateClient.Checked = false;
                        }
                    }
                    else
                    {
                        string sql = $"UPDATE [CLIENT] SET ClientLastName = '{tbClientSurname.Text}', ClientCellNumber = '{tbClientCellNum.Text}' WHERE Client_ID = '{tbClientID.Text}'";
                        conn = new SqlConnection(q.conString);
                        conn.Open();
                        adapter = new SqlDataAdapter();
                        command = new SqlCommand(sql, conn);
                        adapter.UpdateCommand = command;
                        adapter.UpdateCommand.ExecuteNonQuery();
                        conn.Close();
                        tbClientName.Text = "";
                        tbClientSurname.Text = "";
                        tbClientCellNum.Text = "";
                        lblClientErrorMeassge.Visible = true;
                        lblClientErrorMeassge.Text = "Succesfully Updated";

                        //display hidden controls
                        btnAddClient.Enabled = true;
                        btnDeleteClient.Enabled = true;

                        //deselects the update client radio button
                        rbUpdateClient.Checked = false;
                    }
                    conn = new SqlConnection(q.conString);
                    string sql2 = $"SELECT * FROM [ClIENT]";

                    conn.Open();
                    adapter = new SqlDataAdapter();
                    command = new SqlCommand(sql2, conn);
                    ds = new DataSet();
                    adapter.SelectCommand = command;
                    adapter.Fill(ds, "[Cleints]");

                    dgvClients.DataSource = ds;
                    dgvClients.DataMember = "[Cleints]";
                    conn.Close();
                }


            }
            catch (SqlException )
            {
                MessageBox.Show("Couldn't update client");
            }
        }

        private void btnDeleteClient_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (tbClientID.Text == "")
                {
                    errorProvider1.SetError(tbClientID, "Insert Primary Key of Client");
                }
                else
                {
                    conn = new SqlConnection(q.conString);
                    string sql = "DELETE FROM [CLIENT] WHERE Client_ID ='" + tbClientID.Text + "'";
                    conn.Open();
                    command = new SqlCommand(sql, conn);
                    adapter = new SqlDataAdapter();
                    adapter.DeleteCommand = command;
                    adapter.DeleteCommand.ExecuteNonQuery();

                    conn.Close();
                    tbClientID.Text = "";

                    
                    string sql2 = $"SELECT * FROM [ClIENT]";

                    conn.Open();
                    adapter = new SqlDataAdapter();
                    command = new SqlCommand(sql2, conn);
                    ds = new DataSet();
                    adapter.SelectCommand = command;
                    adapter.Fill(ds, "[Cleints]");

                    dgvClients.DataSource = ds;
                    dgvClients.DataMember = "[Cleints]";
                    conn.Close();
                    lblClientErrorMeassge.Visible = true;
                    lblClientErrorMeassge.Text = "Succesfully Deleted";

                    //display hidden controls
                    tbClientName.Enabled = true;
                    lblClientName.Enabled = true;
                    tbClientSurname.Enabled = true;
                    lblClientSurname.Enabled = true;
                    btnUpdateClient.Enabled = true;
                    btnAddClient.Enabled = true;

                    //deselects the delete client radio button
                    rbDeleteClient.Checked = false;
                }

            }
            catch (SqlException)
            {
                MessageBox.Show("Cannot Delete client, because it is linked to a vehicle");
            }
        }

        private void btnClientsSearch_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (tbClientCellNum.TextLength != 10)
                {
                    errorProvider1.SetError(tbClientCellNum, "Cellphone number not 10 digits");
                }
                else
                {
                    conn = new SqlConnection(q.conString);
                    string sql = $"SELECT * FROM [ClIENT] WHERE ClientCellNumber LIKE '%{tbClientCellNum.Text}%'";

                    conn.Open();
                    adapter = new SqlDataAdapter();
                    command = new SqlCommand(sql, conn);
                    ds = new DataSet();
                    adapter.SelectCommand = command;
                    adapter.Fill(ds, "[Cleints]");

                    dgvClients.DataSource = ds;
                    dgvClients.DataMember = "[Cleints]";
                    conn.Close();
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show("Couldn't search");
            }
        }

        private void btnCloseClients_Click_1(object sender, EventArgs e)
        {
            try
            {
                callingForm.Show();
                this.Hide();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void rbAddClient_CheckedChanged(object sender, EventArgs e)
        {
            //controls to be displayed when adding a client
            lblClientCellNum.Visible = true;
            tbClientCellNum.Enabled = true;
            tbClientName.Enabled = true;
            lblClientName.Enabled = true;
            tbClientSurname.Enabled = true;
            lblClientSurname.Enabled = true;
            btnAddClient.Enabled = true;


            //controls to be hidden when adding a client
            lblClientID.Enabled = false;
            tbClientID.Enabled = false;
            btnClientsSearch.Enabled = false;
            btnUpdateClient.Enabled = false;
            btnDeleteClient.Enabled = false;

            //sets focus on client cellphone number
            tbClientCellNum.Focus();
        }

        private void rbUpdateClient_CheckedChanged(object sender, EventArgs e)
        {
            //controls to be displayed when updating a client
            lblClientCellNum.Enabled = true;
            tbClientCellNum.Enabled = true;
            tbClientName.Enabled = true;
            lblClientName.Enabled = true;
            tbClientSurname.Enabled = true;
            lblClientSurname.Enabled = true;
            lblClientID.Enabled = true;
            tbClientID.Enabled = true;
            btnUpdateClient.Enabled = true;
            btnClientsSearch.Enabled = true;

            //controls to be hidden when updating a client
            btnAddClient.Enabled = false;
            btnDeleteClient.Enabled = false;

            //sets focus on client cellphone number
            tbClientCellNum.Focus();
        }

        private void rbDeleteClient_CheckedChanged(object sender, EventArgs e)
        {
            //controls to be displayed when deleting a client
            lblClientID.Enabled = true;
            tbClientID.Enabled = true;
            lblClientCellNum.Enabled = true;
            tbClientCellNum.Enabled = true;
            btnDeleteClient.Enabled = true;
            btnClientsSearch.Enabled = true;

            //controls to be hidden when deleting a client
            tbClientName.Enabled = false;
            lblClientName.Enabled = false;
            tbClientSurname.Enabled = false;
            lblClientSurname.Enabled = false;
            btnUpdateClient.Enabled = false;
            btnAddClient.Enabled = false;

            //sets focus on client cellphone number
            tbClientCellNum.Focus();

        }

    }
}


