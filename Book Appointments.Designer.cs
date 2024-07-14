
namespace Sparkling_CarWash
{
    partial class Book_Appointments
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Employee_Appointment = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnConfirmBooking = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.btnRequestReports = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCalculation = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblAppointmentMessage = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbEmployee2 = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cbEmployee1 = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbService = new System.Windows.Forms.ComboBox();
            this.cbTimeSlot = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblClientDetails = new System.Windows.Forms.Label();
            this.btnGetAdditionalFee = new System.Windows.Forms.Button();
            this.tbNumerPlateApp = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvUpcomingAppointment = new System.Windows.Forms.DataGridView();
            this.lbHelpAppointment = new System.Windows.Forms.ListBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btnDeleteAppointment = new System.Windows.Forms.Button();
            this.tbAppointmentID = new System.Windows.Forms.TextBox();
            this.btnCloseAppointments = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dgvEmpApp = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblActiveUserApp = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Employee_Appointment.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpcomingAppointment)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Employee_Appointment
            // 
            this.Employee_Appointment.Controls.Add(this.tabPage1);
            this.Employee_Appointment.Controls.Add(this.tabPage2);
            this.Employee_Appointment.Controls.Add(this.tabPage5);
            this.Employee_Appointment.Location = new System.Drawing.Point(21, 44);
            this.Employee_Appointment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Employee_Appointment.Name = "Employee_Appointment";
            this.Employee_Appointment.SelectedIndex = 0;
            this.Employee_Appointment.Size = new System.Drawing.Size(1272, 700);
            this.Employee_Appointment.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnClose);
            this.tabPage1.Controls.Add(this.btnConfirmBooking);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.btnRequestReports);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.ForeColor = System.Drawing.Color.DarkCyan;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1264, 671);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Book Appointment";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkCyan;
            this.btnClose.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(566, 587);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(169, 52);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close Form";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnConfirmBooking
            // 
            this.btnConfirmBooking.BackColor = System.Drawing.Color.DarkCyan;
            this.btnConfirmBooking.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnConfirmBooking.Location = new System.Drawing.Point(1056, 586);
            this.btnConfirmBooking.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmBooking.Name = "btnConfirmBooking";
            this.btnConfirmBooking.Size = new System.Drawing.Size(169, 52);
            this.btnConfirmBooking.TabIndex = 8;
            this.btnConfirmBooking.Text = "Confirm Booking";
            this.btnConfirmBooking.UseVisualStyleBackColor = false;
            this.btnConfirmBooking.Click += new System.EventHandler(this.btnConfirmBooking_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(53, 641);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(114, 17);
            this.label20.TabIndex = 17;
            this.label20.Text = "(Managers Only)";
            // 
            // btnRequestReports
            // 
            this.btnRequestReports.BackColor = System.Drawing.Color.DarkCyan;
            this.btnRequestReports.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRequestReports.Location = new System.Drawing.Point(21, 586);
            this.btnRequestReports.Margin = new System.Windows.Forms.Padding(4);
            this.btnRequestReports.Name = "btnRequestReports";
            this.btnRequestReports.Size = new System.Drawing.Size(169, 52);
            this.btnRequestReports.TabIndex = 9;
            this.btnRequestReports.Text = "Request Reports";
            this.btnRequestReports.UseVisualStyleBackColor = false;
            this.btnRequestReports.Click += new System.EventHandler(this.btnRequestReports_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCalculation);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.lblGrandTotal);
            this.groupBox1.Controls.Add(this.lblAppointmentMessage);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.cbTimeSlot);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkCyan;
            this.groupBox1.Location = new System.Drawing.Point(21, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1204, 558);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Appointment Details";
            // 
            // lblCalculation
            // 
            this.lblCalculation.AutoSize = true;
            this.lblCalculation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculation.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblCalculation.Location = new System.Drawing.Point(12, 435);
            this.lblCalculation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalculation.Name = "lblCalculation";
            this.lblCalculation.Size = new System.Drawing.Size(254, 31);
            this.lblCalculation.TabIndex = 22;
            this.lblCalculation.Text = "Grand Total: R500";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.DarkCyan;
            this.label22.Location = new System.Drawing.Point(134, 111);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(37, 17);
            this.label22.TabIndex = 21;
            this.label22.Text = "Day:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(134, 156);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Time Slot:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.DarkCyan;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(226, 104);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(252, 22);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblGrandTotal.Location = new System.Drawing.Point(932, 435);
            this.lblGrandTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(254, 31);
            this.lblGrandTotal.TabIndex = 2;
            this.lblGrandTotal.Text = "Grand Total: R500";
            // 
            // lblAppointmentMessage
            // 
            this.lblAppointmentMessage.AutoSize = true;
            this.lblAppointmentMessage.ForeColor = System.Drawing.Color.Red;
            this.lblAppointmentMessage.Location = new System.Drawing.Point(32, 502);
            this.lblAppointmentMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAppointmentMessage.Name = "lblAppointmentMessage";
            this.lblAppointmentMessage.Size = new System.Drawing.Size(202, 17);
            this.lblAppointmentMessage.TabIndex = 9;
            this.lblAppointmentMessage.Text = "Label For Validation Messages";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.cbEmployee2);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.cbEmployee1);
            this.groupBox5.ForeColor = System.Drawing.Color.DarkCyan;
            this.groupBox5.Location = new System.Drawing.Point(607, 241);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(579, 181);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "AVAILABLE EMPLOYEES";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(291, 78);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 17);
            this.label15.TabIndex = 10;
            this.label15.Text = "Employee02:";
            // 
            // cbEmployee2
            // 
            this.cbEmployee2.FormattingEnabled = true;
            this.cbEmployee2.Location = new System.Drawing.Point(395, 73);
            this.cbEmployee2.Margin = new System.Windows.Forms.Padding(4);
            this.cbEmployee2.Name = "cbEmployee2";
            this.cbEmployee2.Size = new System.Drawing.Size(160, 24);
            this.cbEmployee2.TabIndex = 7;
            this.cbEmployee2.SelectedIndexChanged += new System.EventHandler(this.cbEmployee2_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(11, 78);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(90, 17);
            this.label19.TabIndex = 7;
            this.label19.Text = "Employee01:";
            // 
            // cbEmployee1
            // 
            this.cbEmployee1.FormattingEnabled = true;
            this.cbEmployee1.Location = new System.Drawing.Point(115, 73);
            this.cbEmployee1.Margin = new System.Windows.Forms.Padding(4);
            this.cbEmployee1.Name = "cbEmployee1";
            this.cbEmployee1.Size = new System.Drawing.Size(160, 24);
            this.cbEmployee1.TabIndex = 6;
            this.cbEmployee1.SelectedIndexChanged += new System.EventHandler(this.cbEmployee1_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.cbService);
            this.groupBox4.ForeColor = System.Drawing.Color.DarkCyan;
            this.groupBox4.Location = new System.Drawing.Point(18, 241);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(579, 181);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "SERVICE DETAILS";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(124, 76);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 17);
            this.label14.TabIndex = 7;
            this.label14.Text = "Service Name:";
            // 
            // cbService
            // 
            this.cbService.FormattingEnabled = true;
            this.cbService.Location = new System.Drawing.Point(247, 73);
            this.cbService.Margin = new System.Windows.Forms.Padding(4);
            this.cbService.Name = "cbService";
            this.cbService.Size = new System.Drawing.Size(160, 24);
            this.cbService.TabIndex = 5;
            this.cbService.SelectedIndexChanged += new System.EventHandler(this.cbService_SelectedIndexChanged_1);
            // 
            // cbTimeSlot
            // 
            this.cbTimeSlot.FormattingEnabled = true;
            this.cbTimeSlot.Items.AddRange(new object[] {
            "08:00 - 08:30",
            "08:30 - 09:00",
            "09:00 - 09:30",
            "09:30 - 10:00"});
            this.cbTimeSlot.Location = new System.Drawing.Point(226, 153);
            this.cbTimeSlot.Margin = new System.Windows.Forms.Padding(4);
            this.cbTimeSlot.Name = "cbTimeSlot";
            this.cbTimeSlot.Size = new System.Drawing.Size(252, 24);
            this.cbTimeSlot.TabIndex = 2;
            this.cbTimeSlot.SelectedIndexChanged += new System.EventHandler(this.cbTimeSlot_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblClientDetails);
            this.groupBox3.Controls.Add(this.btnGetAdditionalFee);
            this.groupBox3.Controls.Add(this.tbNumerPlateApp);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.ForeColor = System.Drawing.Color.DarkCyan;
            this.groupBox3.Location = new System.Drawing.Point(607, 44);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(571, 189);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "VEHICLE DETAILS";
            // 
            // lblClientDetails
            // 
            this.lblClientDetails.AutoSize = true;
            this.lblClientDetails.Location = new System.Drawing.Point(55, 142);
            this.lblClientDetails.Name = "lblClientDetails";
            this.lblClientDetails.Size = new System.Drawing.Size(46, 17);
            this.lblClientDetails.TabIndex = 5;
            this.lblClientDetails.Text = "label2";
            // 
            // btnGetAdditionalFee
            // 
            this.btnGetAdditionalFee.BackColor = System.Drawing.Color.DarkCyan;
            this.btnGetAdditionalFee.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGetAdditionalFee.Location = new System.Drawing.Point(237, 77);
            this.btnGetAdditionalFee.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetAdditionalFee.Name = "btnGetAdditionalFee";
            this.btnGetAdditionalFee.Size = new System.Drawing.Size(169, 43);
            this.btnGetAdditionalFee.TabIndex = 4;
            this.btnGetAdditionalFee.Text = "Get Additional Fee";
            this.btnGetAdditionalFee.UseVisualStyleBackColor = false;
            this.btnGetAdditionalFee.Click += new System.EventHandler(this.btnGetAdditionalFee_Click);
            // 
            // tbNumerPlateApp
            // 
            this.tbNumerPlateApp.Location = new System.Drawing.Point(270, 33);
            this.tbNumerPlateApp.Margin = new System.Windows.Forms.Padding(4);
            this.tbNumerPlateApp.Name = "tbNumerPlateApp";
            this.tbNumerPlateApp.Size = new System.Drawing.Size(160, 22);
            this.tbNumerPlateApp.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(132, 36);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Number Plate:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvUpcomingAppointment);
            this.tabPage2.Controls.Add(this.lbHelpAppointment);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.btnDeleteAppointment);
            this.tabPage2.Controls.Add(this.tbAppointmentID);
            this.tabPage2.Controls.Add(this.btnCloseAppointments);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1264, 671);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Upcoming Appointments";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvUpcomingAppointment
            // 
            this.dgvUpcomingAppointment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUpcomingAppointment.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUpcomingAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpcomingAppointment.Location = new System.Drawing.Point(19, 28);
            this.dgvUpcomingAppointment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvUpcomingAppointment.Name = "dgvUpcomingAppointment";
            this.dgvUpcomingAppointment.RowHeadersWidth = 51;
            this.dgvUpcomingAppointment.RowTemplate.Height = 24;
            this.dgvUpcomingAppointment.Size = new System.Drawing.Size(1043, 535);
            this.dgvUpcomingAppointment.TabIndex = 0;
            // 
            // lbHelpAppointment
            // 
            this.lbHelpAppointment.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbHelpAppointment.FormattingEnabled = true;
            this.lbHelpAppointment.ItemHeight = 16;
            this.lbHelpAppointment.Items.AddRange(new object[] {
            "Help Functionality:",
            "",
            "To delete an upcoming ",
            "appointment",
            "-Type in the ID of the ",
            "appointment you ",
            "want to delete by ",
            "Primary Key",
            "-Click on Delete ",
            "Appointment to",
            "Delete the ",
            "appointment"});
            this.lbHelpAppointment.Location = new System.Drawing.Point(1068, 28);
            this.lbHelpAppointment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbHelpAppointment.Name = "lbHelpAppointment";
            this.lbHelpAppointment.Size = new System.Drawing.Size(177, 532);
            this.lbHelpAppointment.TabIndex = 33;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.DarkCyan;
            this.label21.Location = new System.Drawing.Point(236, 610);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(84, 17);
            this.label21.TabIndex = 32;
            this.label21.Text = "Primary Key";
            // 
            // btnDeleteAppointment
            // 
            this.btnDeleteAppointment.BackColor = System.Drawing.Color.DarkCyan;
            this.btnDeleteAppointment.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteAppointment.Location = new System.Drawing.Point(19, 593);
            this.btnDeleteAppointment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteAppointment.Name = "btnDeleteAppointment";
            this.btnDeleteAppointment.Size = new System.Drawing.Size(179, 49);
            this.btnDeleteAppointment.TabIndex = 2;
            this.btnDeleteAppointment.Text = "Delete Appointment";
            this.btnDeleteAppointment.UseVisualStyleBackColor = false;
            this.btnDeleteAppointment.Click += new System.EventHandler(this.btnDeleteAppointment_Click);
            // 
            // tbAppointmentID
            // 
            this.tbAppointmentID.Location = new System.Drawing.Point(339, 607);
            this.tbAppointmentID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAppointmentID.Name = "tbAppointmentID";
            this.tbAppointmentID.Size = new System.Drawing.Size(100, 22);
            this.tbAppointmentID.TabIndex = 1;
            // 
            // btnCloseAppointments
            // 
            this.btnCloseAppointments.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCloseAppointments.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCloseAppointments.Location = new System.Drawing.Point(1068, 593);
            this.btnCloseAppointments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCloseAppointments.Name = "btnCloseAppointments";
            this.btnCloseAppointments.Size = new System.Drawing.Size(179, 50);
            this.btnCloseAppointments.TabIndex = 3;
            this.btnCloseAppointments.Text = "Close";
            this.btnCloseAppointments.UseVisualStyleBackColor = false;
            this.btnCloseAppointments.Click += new System.EventHandler(this.btnCloseAppointments_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dgvEmpApp);
            this.tabPage5.Controls.Add(this.listBox1);
            this.tabPage5.Controls.Add(this.button1);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1264, 671);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Employee_Appointment";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dgvEmpApp
            // 
            this.dgvEmpApp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpApp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEmpApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpApp.Location = new System.Drawing.Point(18, 28);
            this.dgvEmpApp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvEmpApp.Name = "dgvEmpApp";
            this.dgvEmpApp.RowHeadersWidth = 51;
            this.dgvEmpApp.RowTemplate.Height = 24;
            this.dgvEmpApp.Size = new System.Drawing.Size(1043, 535);
            this.dgvEmpApp.TabIndex = 34;
            // 
            // listBox1
            // 
            this.listBox1.ForeColor = System.Drawing.Color.DarkCyan;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Help Functionality:",
            "",
            "This is just to display the ",
            "employees that will be ",
            "attending to appointments"});
            this.listBox1.Location = new System.Drawing.Point(1067, 28);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(177, 532);
            this.listBox1.TabIndex = 36;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(1067, 593);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 50);
            this.button1.TabIndex = 35;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblActiveUserApp
            // 
            this.lblActiveUserApp.AutoSize = true;
            this.lblActiveUserApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveUserApp.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblActiveUserApp.Location = new System.Drawing.Point(971, 11);
            this.lblActiveUserApp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActiveUserApp.Name = "lblActiveUserApp";
            this.lblActiveUserApp.Size = new System.Drawing.Size(295, 31);
            this.lblActiveUserApp.TabIndex = 14;
            this.lblActiveUserApp.Text = "Active User: TNokoane";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Book_Appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1323, 769);
            this.Controls.Add(this.Employee_Appointment);
            this.Controls.Add(this.lblActiveUserApp);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Book_Appointments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Book_Appointments_Load_1);
            this.Employee_Appointment.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpcomingAppointment)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Employee_Appointment;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnConfirmBooking;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnRequestReports;
        private System.Windows.Forms.ListBox lbHelpAppointment;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnDeleteAppointment;
        private System.Windows.Forms.TextBox tbAppointmentID;
        private System.Windows.Forms.Button btnCloseAppointments;
        private System.Windows.Forms.DataGridView dgvUpcomingAppointment;
        private System.Windows.Forms.Label lblActiveUserApp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label lblAppointmentMessage;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbEmployee2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cbEmployee1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbService;
        private System.Windows.Forms.ComboBox cbTimeSlot;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbNumerPlateApp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnGetAdditionalFee;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dgvEmpApp;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCalculation;
        private System.Windows.Forms.Label lblClientDetails;
    }
}