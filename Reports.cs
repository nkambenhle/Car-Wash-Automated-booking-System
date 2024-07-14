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
    public partial class Reports : Form
    {
        frmWelcome q = new frmWelcome();  //Create an instance of the frmWelcome class
        private Form callingForm;
        public Reports(Form callingForm)
        {
            InitializeComponent();
            this.callingForm = callingForm;
        }
       

        public SqlConnection connect;
        public SqlCommand command;
        public SqlDataAdapter adapter;
        public DataSet dataset;
        public SqlDataReader dataReader;
        //string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";

        int count = 0;
        double income = 0;

        private void Reports_Load(object sender, EventArgs e)
        {
            try
            {
                q.activeUser(q, lblActiveUserReports);
                connect = new SqlConnection(q.conString);
                connect.Open();
                
                adapter = new SqlDataAdapter();
                dataset = new DataSet();
                String sql = @"SELECT * FROM [REPORTS]";
                command = new SqlCommand(sql, connect);
                //Filling the dataset
                adapter.SelectCommand = command;
                adapter.Fill(dataset, "[REPORTs]");
                //Adding the data into the data grid
                dgvReports.DataSource = dataset;
                dgvReports.DataMember = "[REPORTs]";

                //Closing the connection to the database
                connect.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (dateTimePickerStartDate.Value < dateTimePickerEndDate.Value || dateTimePickerStartDate.Value == dateTimePickerEndDate.Value)
            {
                try
                {
                    connect = new SqlConnection(q.conString);
                    string sql = $"SELECT * FROM [APPOINTMENT] WHERE App_Date_Time BETWEEN '{dateTimePickerStartDate.Value}' AND '{dateTimePickerEndDate.Value}'";
                    connect.Open();
                    command = new SqlCommand(sql, connect);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        count += 1;
                        income += double.Parse(dataReader.GetValue(2).ToString());
                    }
                    connect.Close();

                    connect = new SqlConnection(q.conString);
                    string sql1 = $"INSERT INTO [REPORTS](Report_Date, StartDate, EndDate, Num_Of_App, Total_Income) VALUES('{DateTime.Now.ToString()}','{dateTimePickerStartDate.Value}','{dateTimePickerEndDate.Value}','{count}','{income}')";
                    connect.Open();
                    command = new SqlCommand(sql1, connect);
                    adapter = new SqlDataAdapter();
                    adapter.InsertCommand = command;
                    adapter.InsertCommand.ExecuteNonQuery();
                    connect.Close();

                    connect = new SqlConnection(q.conString);
                    string sql2 = $"SELECT * FROM [REPORTS]";
                    connect.Open();
                    adapter = new SqlDataAdapter();
                    dataset = new DataSet();
                    command = new SqlCommand(sql2, connect);
                    //Filling the dataset
                    adapter.SelectCommand = command;
                    adapter.Fill(dataset, "[REPORTs]");
                    //Adding the data into the data grid
                    dgvReports.DataSource = dataset;
                    dgvReports.DataMember = "[REPORTs]";
                    connect.Close();

                    count = 0;
                    income = 0;
                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else if (dateTimePickerStartDate.Value > dateTimePickerEndDate.Value)
            {
                MessageBox.Show("The Start date cannot be ahead of the End date, please correct range.");
            }

        }

        private void button4_Click(object sender, EventArgs e)
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
    }
}



