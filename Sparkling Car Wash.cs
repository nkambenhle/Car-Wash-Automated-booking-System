using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sparkling_CarWash
{
    public partial class Sparkling_Car_Wash : Form
    {
        public Sparkling_Car_Wash()
        {
            InitializeComponent();
        }

        //View Vehicle form
        private void vehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vehicle frmVehicle = new Vehicle();
            frmVehicle.Show();
            this.Hide();
        }

        //close the main form and goes back to the login form
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmWelcome form1 = new frmWelcome();
            form1.Show();
            this.Hide();
        }

        private void appointmentsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Book_Appointments frmAppointments = new Book_Appointments(this);
            frmAppointments.Show();
            this.Hide();
        }

        private void clientsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Clients frmClients = new Clients(this);
            frmClients.Show();
            this.Hide();
        }

        private void makesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Make frmMake = new Make(this);
            frmMake.Show();
            this.Hide();
        }

        private void vehicleTypesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Vehicle_Type frmVType = new Vehicle_Type();
            frmVType.Show();
            this.Hide();
        }

        private void servicesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Service frmService = new Service(this);
            frmService.Show();
            this.Hide();
        }

        private void employeesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Employees frmEmployees = new Employees(this);
            frmEmployees.Show();
            this.Hide();

        }

        private void modelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Model model = new Model(this);
            model.Show();
            this.Hide();
        }

        private void Sparkling_Car_Wash_Load(object sender, EventArgs e)
        {

        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports report = new Reports(this);
            report.Show();
            this.Hide();
        }
    }
}


