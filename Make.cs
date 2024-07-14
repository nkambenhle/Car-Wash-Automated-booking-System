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
    public partial class Make : Form
    {
        frmWelcome q = new frmWelcome();  //Create an instance of the frmWelcome class
        private Form callingForm;
        public Make(Form callingForm)
        {
            InitializeComponent();
            this.callingForm = callingForm;
        }
        
        
        String activeName;
        SqlConnection connect;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        SqlDataReader dataReader;

        private void Make_Load(object sender, EventArgs e)
        {
            q.activeUser(q, lblActiveUserMake);
            //Call the method for combobox population with relevent query statement
            populateMakeNameCB(@"SELECT Make_Name FROM [MAKE]");
            tbMakeNameAdd.Focus();
            label2.Visible = false;
            label3.Visible = false;
            label5.Visible = false;


            if (rbAddMake.Checked)
            {
                cbMakeNameDelete.Focus();

                tbMakeNameAdd.Enabled = false;
                btnMakeAdd.Enabled = false;
                cbMakeNameDelete.Enabled = true;
                cbMakeNameUpdate.Enabled = false;
                tbMakeUpdate.Enabled = false;
                btnMakeDelete.Enabled = true;
                btnMakeUpdate.Enabled = false;
                label2.Visible = true;
                label3.Visible = false;
                label5.Visible = false;
                errorProvider1.Clear();
            }
            else if (rbDeleteMake.Checked)
            {
                cbMakeNameDelete.Focus();

                tbMakeNameAdd.Enabled = false;
                btnMakeAdd.Enabled = false;
                cbMakeNameDelete.Enabled = true;
                cbMakeNameUpdate.Enabled = false;
                tbMakeUpdate.Enabled = false;
                btnMakeDelete.Enabled = true;
                btnMakeUpdate.Enabled = false;
                label2.Enabled = true;
                label3.Enabled = false;
                label5.Enabled = false;
                errorProvider1.Clear();
            }
            else if (rbUpdateMake.Checked)
            {
                cbMakeNameUpdate.Focus();

                tbMakeNameAdd.Enabled = false;
                btnMakeAdd.Enabled = false;
                cbMakeNameDelete.Enabled = false;
                cbMakeNameUpdate.Enabled = true;
                tbMakeUpdate.Enabled = true;
                btnMakeDelete.Enabled = false;
                btnMakeUpdate.Enabled = true;
                label2.Visible = false;
                label3.Visible = false;
                label5.Visible = true;
                errorProvider1.Clear();
            }
            else
            {

                tbMakeNameAdd.Enabled = false;
                btnMakeAdd.Enabled = false;
                cbMakeNameDelete.Enabled = false;
                cbMakeNameUpdate.Enabled = false;
                tbMakeUpdate.Enabled = false;
                btnMakeDelete.Enabled = false;
                btnMakeUpdate.Enabled = false;
                label2.Visible = false;
                label3.Visible = false;
                label5.Visible = false;
                errorProvider1.Clear();
            }


            connect = new SqlConnection(q.conString);



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

                lblActiveUserMake.Text = "Active User: " + activeName;
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            tbMakeNameAdd.Focus();

        }

        //Method for populating the combobox of sercive names
        public void populateMakeNameCB(string sqlStatement)
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
                    string makeNameDelete = dataReader.GetValue(0).ToString();
                    string makeNameUpdate = dataReader.GetValue(0).ToString();
                    cbMakeNameDelete.Items.Add(makeNameDelete);
                    cbMakeNameUpdate.Items.Add(makeNameUpdate);

                }


                connect.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

        }


        private void btnMakeAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbMakeNameAdd.Text == "")
                {
                    errorProvider1.SetError(tbMakeNameAdd, "Make Name not inserted");
                }
                else
                {
                    DialogResult result = MessageBox.Show("You are about to add the Make name ", "Confirm", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        connect = new SqlConnection(q.conString);
                        string sql = $"INSERT INTO [MAKE](Make_Name) VALUES('{tbMakeNameAdd.Text}') ";

                        connect.Open();
                        command = new SqlCommand(sql, connect);
                        dataAdapter = new SqlDataAdapter();
                        dataAdapter.InsertCommand = command;
                        dataAdapter.InsertCommand.ExecuteNonQuery();
                        connect.Close();

                        tbMakeNameAdd.Text = "";
                        label2.Text = "Added successfully";
                        label2.Visible = true;
                        label3.Visible = false;
                        label5.Visible = false;

                    }
                    else if (result == DialogResult.No)
                    {
                        MessageBox.Show("A new Make name was not added");
                        tbMakeNameAdd.Text = "";
                        label2.Visible = false;
                        errorProvider1.Clear();

                    }

                    cbMakeNameDelete.Items.Clear();
                    cbMakeNameUpdate.Items.Clear();

                    populateMakeNameCB(@"SELECT Make_Name FROM [MAKE]");

                }
            }
            catch (SqlException error)
            {

                MessageBox.Show(error.Message);
            }
        }

        private void btnMakeDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbMakeNameDelete.SelectedItem == null)
                {
                    errorProvider1.SetError(cbMakeNameDelete, "Select Make to delete");
                }
                else
                {
                    DialogResult result = MessageBox.Show("You are about to delete the Make name ", "Confirm", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        connect = new SqlConnection(q.conString);
                        string sql = $"DELETE FROM [MAKE] WHERE Make_Name = '{cbMakeNameDelete.SelectedItem}'";

                        connect.Open();
                        command = new SqlCommand(sql, connect);
                        dataAdapter = new SqlDataAdapter();
                        dataAdapter.DeleteCommand = command;
                        dataAdapter.DeleteCommand.ExecuteNonQuery();
                        connect.Close();
                        cbMakeNameDelete.SelectedIndex = -1;
                        label2.Visible = false;
                        label3.Text = "Removed successfully";
                        label3.Visible = true;
                        label5.Visible = false;
                    }
                    else if (result == DialogResult.No)
                    {
                        MessageBox.Show("Make name was not deleted");
                        cbMakeNameDelete.SelectedIndex = -1;
                        label2.Visible = false;
                        label3.Visible = false;
                        errorProvider1.Clear();

                    }

                    cbMakeNameDelete.Items.Clear();
                    cbMakeNameUpdate.Items.Clear();

                    populateMakeNameCB(@"SELECT Make_Name FROM [MAKE]");

                }


            }
            catch (SqlException)
            {
                MessageBox.Show("Can not delete Make, It is associated with a model.");
            }
        }

        private void btnMakeUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbMakeUpdate.Text == "")
                {
                    errorProvider1.SetError(tbMakeUpdate, "Insert updated Name");
                }
                else if (cbMakeNameUpdate.SelectedItem == null)
                {
                    errorProvider1.SetError(cbMakeNameUpdate, "Select item to update");
                }
                else
                {
                    DialogResult result = MessageBox.Show("You are about to delete the Make name ", "Confirm", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        connect = new SqlConnection(q.conString);
                        string sql = $"UPDATE [MAKE] SET Make_Name = '{tbMakeUpdate.Text}' WHERE Make_Name = '{cbMakeNameUpdate.SelectedItem}'";

                        connect.Open();
                        command = new SqlCommand(sql, connect);
                        dataAdapter = new SqlDataAdapter();
                        dataAdapter.UpdateCommand = command;
                        dataAdapter.UpdateCommand.ExecuteNonQuery();

                        connect.Close();

                        tbMakeUpdate.Text = "";
                        cbMakeNameUpdate.SelectedItem = null;
                        label2.Visible = false;
                        label3.Visible = false;
                        label5.Text = "Updated Successfully";
                        label5.Visible = true;
                    }
                    else if (result == DialogResult.No)
                    {
                        MessageBox.Show("Make name was not updated.");
                        tbMakeUpdate.Text = "";
                        cbMakeNameUpdate.SelectedItem = null;
                        label5.Visible = false;
                        errorProvider1.Clear();

                    }

                    cbMakeNameDelete.Items.Clear();
                    cbMakeNameUpdate.Items.Clear();

                    populateMakeNameCB(@"SELECT Make_Name FROM [MAKE]");

                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnCloseMake_Click(object sender, EventArgs e)
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

        private void rbAddMake_CheckedChanged(object sender, EventArgs e)
        {
            tbMakeNameAdd.Focus();

            tbMakeNameAdd.Enabled = true;
            btnMakeAdd.Enabled = true;
            cbMakeNameDelete.Enabled = false;
            cbMakeNameUpdate.Enabled = false;
            tbMakeUpdate.Enabled = false;
            btnMakeDelete.Enabled = false;
            btnMakeUpdate.Enabled = false;
            label2.Visible = false;
            label3.Visible = false;
            label5.Visible = false;
            errorProvider1.Clear();

        }

        private void rbDeleteMake_CheckedChanged(object sender, EventArgs e)
        {
            cbMakeNameDelete.Focus();

            tbMakeNameAdd.Enabled = false;
            btnMakeAdd.Enabled = false;
            cbMakeNameDelete.Enabled = true;
            cbMakeNameUpdate.Enabled = false;
            tbMakeUpdate.Enabled = false;
            btnMakeDelete.Enabled = true;
            btnMakeUpdate.Enabled = false;
            label2.Visible = false;
            label3.Visible = false;
            label5.Visible = false;
            errorProvider1.Clear();

        }

        private void rbUpdateMake_CheckedChanged(object sender, EventArgs e)
        {
            cbMakeNameUpdate.Focus();

            tbMakeNameAdd.Enabled = false;
            btnMakeAdd.Enabled = false;
            cbMakeNameDelete.Enabled = false;
            cbMakeNameUpdate.Enabled = true;
            tbMakeUpdate.Enabled = true;
            btnMakeDelete.Enabled = false;
            btnMakeUpdate.Enabled = true;
            label2.Visible = false;
            label3.Visible = false;
            label5.Visible = false;
            errorProvider1.Clear();

        }
    }
}


