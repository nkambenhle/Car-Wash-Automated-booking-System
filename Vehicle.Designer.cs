
namespace Sparkling_CarWash
{
    partial class Vehicle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbVehicleHelp = new System.Windows.Forms.ListBox();
            this.btnDeleteVehicle = new System.Windows.Forms.Button();
            this.btnUpdateVehicle = new System.Windows.Forms.Button();
            this.btnAddVehicle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvVehicles = new System.Windows.Forms.DataGridView();
            this.gbVehicleDetails = new System.Windows.Forms.GroupBox();
            this.tbVClientCellNum = new System.Windows.Forms.TextBox();
            this.btnAddModel = new System.Windows.Forms.Button();
            this.cbVehicleModelName = new System.Windows.Forms.ComboBox();
            this.btnSearchVehicleNumberPlate = new System.Windows.Forms.Button();
            this.lblClientCell = new System.Windows.Forms.Label();
            this.cbVehicleColor = new System.Windows.Forms.ComboBox();
            this.lblVehicleColor = new System.Windows.Forms.Label();
            this.lblVehicleModel = new System.Windows.Forms.Label();
            this.tbVehicleNumberPlate = new System.Windows.Forms.TextBox();
            this.tbVehicleID = new System.Windows.Forms.TextBox();
            this.lblVehicleID = new System.Windows.Forms.Label();
            this.lblNumberPlate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCloseVehicles = new System.Windows.Forms.Button();
            this.lblActiveUserVehicles = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblActionSuccessful = new System.Windows.Forms.Label();
            this.rbAddVehicle = new System.Windows.Forms.RadioButton();
            this.rbUpdateVehicle = new System.Windows.Forms.RadioButton();
            this.rbDeleteVehicle = new System.Windows.Forms.RadioButton();
            this.lblVehicleChooseAction = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).BeginInit();
            this.gbVehicleDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbVehicleHelp
            // 
            this.lbVehicleHelp.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbVehicleHelp.FormattingEnabled = true;
            this.lbVehicleHelp.ItemHeight = 16;
            this.lbVehicleHelp.Items.AddRange(new object[] {
            "Help Functionality",
            "",
            "Select whether you would like to ",
            "Add, Update or Delete a Vehicle.",
            "",
            "Add a vehicle to the system:",
            "-Type in the number plate of the ",
            "vehicle",
            "-Type in the cell phone number of the ",
            "client",
            "-Click on the drop down box to display ",
            "all of the vehicle models",
            "-Select a model from the drop down",
            "-Click on the drop down box to display ",
            "all of the vehicle colors",
            "-Select a color from the drop down",
            "-Click \"Add Vehicle\" to add the ",
            "vehicle to the system",
            "",
            "Update a vehicle in the system:",
            "-Type in the number plate of the ",
            "vehicle",
            "-Click \"Search NumberPlate\" to ",
            "search for ",
            "the specific vehicle to be updated ",
            "-Type the Vehicle_ID that is ",
            "displayed in VehicleNo",
            "-Type in the specific details to be ",
            "updated in the relevant text boxes",
            "-And/Or select from the drop down ",
            "boxes the details to be updated ",
            "-Click \"Update Vehicle\" to update the ",
            "vehicle in the system",
            "",
            "Delete a vehicle from the system:",
            "-Type in the number plate of the ",
            "vehicle",
            "-Click \"Search NumberPlate\" to ",
            "search for ",
            "the specific vehicle to be deleted",
            "-Type in the vehicle number that will ",
            "be displayed in the data grid view ",
            "next to \"Vehicle No.\"",
            "-Click \"Delete Vehicle\" to delete the ",
            "vehicle from the system"});
            this.lbVehicleHelp.Location = new System.Drawing.Point(1047, 113);
            this.lbVehicleHelp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbVehicleHelp.Name = "lbVehicleHelp";
            this.lbVehicleHelp.Size = new System.Drawing.Size(261, 548);
            this.lbVehicleHelp.TabIndex = 31;
            // 
            // btnDeleteVehicle
            // 
            this.btnDeleteVehicle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteVehicle.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnDeleteVehicle.Location = new System.Drawing.Point(748, 682);
            this.btnDeleteVehicle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteVehicle.Name = "btnDeleteVehicle";
            this.btnDeleteVehicle.Size = new System.Drawing.Size(259, 57);
            this.btnDeleteVehicle.TabIndex = 10;
            this.btnDeleteVehicle.Text = "Delete Vehicle Details";
            this.btnDeleteVehicle.UseVisualStyleBackColor = false;
            this.btnDeleteVehicle.Click += new System.EventHandler(this.btnDeleteVehicle_Click);
            // 
            // btnUpdateVehicle
            // 
            this.btnUpdateVehicle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdateVehicle.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnUpdateVehicle.Location = new System.Drawing.Point(408, 682);
            this.btnUpdateVehicle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateVehicle.Name = "btnUpdateVehicle";
            this.btnUpdateVehicle.Size = new System.Drawing.Size(259, 57);
            this.btnUpdateVehicle.TabIndex = 8;
            this.btnUpdateVehicle.Text = "Update Vehicle Detials";
            this.btnUpdateVehicle.UseVisualStyleBackColor = false;
            this.btnUpdateVehicle.Click += new System.EventHandler(this.btnUpdateVehicle_Click);
            // 
            // btnAddVehicle
            // 
            this.btnAddVehicle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddVehicle.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnAddVehicle.Location = new System.Drawing.Point(59, 682);
            this.btnAddVehicle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.Size = new System.Drawing.Size(259, 57);
            this.btnAddVehicle.TabIndex = 5;
            this.btnAddVehicle.Text = "Add New Vehicle";
            this.btnAddVehicle.UseVisualStyleBackColor = false;
            this.btnAddVehicle.Click += new System.EventHandler(this.btnAddVehicle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvVehicles);
            this.groupBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Location = new System.Drawing.Point(52, 380);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(955, 281);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "VEHICLES ON THE SYSTEM";
            // 
            // dgvVehicles
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvVehicles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVehicles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVehicles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVehicles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVehicles.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVehicles.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvVehicles.Location = new System.Drawing.Point(7, 22);
            this.dgvVehicles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvVehicles.Name = "dgvVehicles";
            this.dgvVehicles.RowHeadersWidth = 51;
            this.dgvVehicles.RowTemplate.Height = 24;
            this.dgvVehicles.Size = new System.Drawing.Size(941, 254);
            this.dgvVehicles.TabIndex = 20;
            // 
            // gbVehicleDetails
            // 
            this.gbVehicleDetails.Controls.Add(this.tbVClientCellNum);
            this.gbVehicleDetails.Controls.Add(this.btnAddModel);
            this.gbVehicleDetails.Controls.Add(this.cbVehicleModelName);
            this.gbVehicleDetails.Controls.Add(this.btnSearchVehicleNumberPlate);
            this.gbVehicleDetails.Controls.Add(this.lblClientCell);
            this.gbVehicleDetails.Controls.Add(this.cbVehicleColor);
            this.gbVehicleDetails.Controls.Add(this.lblVehicleColor);
            this.gbVehicleDetails.Controls.Add(this.lblVehicleModel);
            this.gbVehicleDetails.Controls.Add(this.tbVehicleNumberPlate);
            this.gbVehicleDetails.Controls.Add(this.tbVehicleID);
            this.gbVehicleDetails.Controls.Add(this.lblVehicleID);
            this.gbVehicleDetails.Controls.Add(this.lblNumberPlate);
            this.gbVehicleDetails.Controls.Add(this.label6);
            this.gbVehicleDetails.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbVehicleDetails.Location = new System.Drawing.Point(52, 117);
            this.gbVehicleDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbVehicleDetails.Name = "gbVehicleDetails";
            this.gbVehicleDetails.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbVehicleDetails.Size = new System.Drawing.Size(949, 242);
            this.gbVehicleDetails.TabIndex = 26;
            this.gbVehicleDetails.TabStop = false;
            this.gbVehicleDetails.Text = "VEHICLE DETAILS";
            // 
            // tbVClientCellNum
            // 
            this.tbVClientCellNum.Location = new System.Drawing.Point(663, 63);
            this.tbVClientCellNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbVClientCellNum.Name = "tbVClientCellNum";
            this.tbVClientCellNum.Size = new System.Drawing.Size(193, 22);
            this.tbVClientCellNum.TabIndex = 25;
            // 
            // btnAddModel
            // 
            this.btnAddModel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddModel.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnAddModel.Location = new System.Drawing.Point(187, 186);
            this.btnAddModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddModel.Name = "btnAddModel";
            this.btnAddModel.Size = new System.Drawing.Size(671, 38);
            this.btnAddModel.TabIndex = 9;
            this.btnAddModel.Text = "NewModel";
            this.btnAddModel.UseVisualStyleBackColor = false;
            this.btnAddModel.Click += new System.EventHandler(this.btnAddModel_Click_1);
            // 
            // cbVehicleModelName
            // 
            this.cbVehicleModelName.FormattingEnabled = true;
            this.cbVehicleModelName.Location = new System.Drawing.Point(663, 98);
            this.cbVehicleModelName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbVehicleModelName.Name = "cbVehicleModelName";
            this.cbVehicleModelName.Size = new System.Drawing.Size(193, 24);
            this.cbVehicleModelName.TabIndex = 3;
            // 
            // btnSearchVehicleNumberPlate
            // 
            this.btnSearchVehicleNumberPlate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearchVehicleNumberPlate.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnSearchVehicleNumberPlate.Location = new System.Drawing.Point(187, 90);
            this.btnSearchVehicleNumberPlate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchVehicleNumberPlate.Name = "btnSearchVehicleNumberPlate";
            this.btnSearchVehicleNumberPlate.Size = new System.Drawing.Size(188, 38);
            this.btnSearchVehicleNumberPlate.TabIndex = 6;
            this.btnSearchVehicleNumberPlate.Text = "Search NumberPlate";
            this.btnSearchVehicleNumberPlate.UseVisualStyleBackColor = false;
            this.btnSearchVehicleNumberPlate.Click += new System.EventHandler(this.btnSearchVehicleNumberPlate_Click);
            // 
            // lblClientCell
            // 
            this.lblClientCell.AutoSize = true;
            this.lblClientCell.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblClientCell.Location = new System.Drawing.Point(504, 60);
            this.lblClientCell.Name = "lblClientCell";
            this.lblClientCell.Size = new System.Drawing.Size(136, 17);
            this.lblClientCell.TabIndex = 24;
            this.lblClientCell.Text = "Client Cellphone No.";
            // 
            // cbVehicleColor
            // 
            this.cbVehicleColor.FormattingEnabled = true;
            this.cbVehicleColor.Items.AddRange(new object[] {
            "Black",
            "Blue",
            "Brown",
            "Gold",
            "Gray",
            "Green",
            "Orange",
            "Purple",
            "Red",
            "Silver",
            "Tan",
            "White",
            "Yellow"});
            this.cbVehicleColor.Location = new System.Drawing.Point(663, 140);
            this.cbVehicleColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbVehicleColor.Name = "cbVehicleColor";
            this.cbVehicleColor.Size = new System.Drawing.Size(193, 24);
            this.cbVehicleColor.TabIndex = 4;
            // 
            // lblVehicleColor
            // 
            this.lblVehicleColor.AutoSize = true;
            this.lblVehicleColor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblVehicleColor.Location = new System.Drawing.Point(504, 143);
            this.lblVehicleColor.Name = "lblVehicleColor";
            this.lblVehicleColor.Size = new System.Drawing.Size(99, 17);
            this.lblVehicleColor.TabIndex = 22;
            this.lblVehicleColor.Text = "Vehicle Colour";
            // 
            // lblVehicleModel
            // 
            this.lblVehicleModel.AutoSize = true;
            this.lblVehicleModel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblVehicleModel.Location = new System.Drawing.Point(503, 101);
            this.lblVehicleModel.Name = "lblVehicleModel";
            this.lblVehicleModel.Size = new System.Drawing.Size(96, 17);
            this.lblVehicleModel.TabIndex = 18;
            this.lblVehicleModel.Text = "Vehicle Model";
            // 
            // tbVehicleNumberPlate
            // 
            this.tbVehicleNumberPlate.Location = new System.Drawing.Point(187, 57);
            this.tbVehicleNumberPlate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbVehicleNumberPlate.Name = "tbVehicleNumberPlate";
            this.tbVehicleNumberPlate.Size = new System.Drawing.Size(187, 22);
            this.tbVehicleNumberPlate.TabIndex = 1;
            // 
            // tbVehicleID
            // 
            this.tbVehicleID.Location = new System.Drawing.Point(187, 138);
            this.tbVehicleID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbVehicleID.Name = "tbVehicleID";
            this.tbVehicleID.Size = new System.Drawing.Size(187, 22);
            this.tbVehicleID.TabIndex = 7;
            // 
            // lblVehicleID
            // 
            this.lblVehicleID.AutoSize = true;
            this.lblVehicleID.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblVehicleID.Location = new System.Drawing.Point(79, 142);
            this.lblVehicleID.Name = "lblVehicleID";
            this.lblVehicleID.Size = new System.Drawing.Size(71, 17);
            this.lblVehicleID.TabIndex = 5;
            this.lblVehicleID.Text = "Vehicle ID";
            // 
            // lblNumberPlate
            // 
            this.lblNumberPlate.AutoSize = true;
            this.lblNumberPlate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNumberPlate.Location = new System.Drawing.Point(79, 63);
            this.lblNumberPlate.Name = "lblNumberPlate";
            this.lblNumberPlate.Size = new System.Drawing.Size(94, 17);
            this.lblNumberPlate.TabIndex = 6;
            this.lblNumberPlate.Text = "Number Plate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 7;
            // 
            // btnCloseVehicles
            // 
            this.btnCloseVehicles.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCloseVehicles.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnCloseVehicles.Location = new System.Drawing.Point(1061, 682);
            this.btnCloseVehicles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCloseVehicles.Name = "btnCloseVehicles";
            this.btnCloseVehicles.Size = new System.Drawing.Size(229, 57);
            this.btnCloseVehicles.TabIndex = 11;
            this.btnCloseVehicles.Text = "Close Vehicles";
            this.btnCloseVehicles.UseVisualStyleBackColor = false;
            this.btnCloseVehicles.Click += new System.EventHandler(this.btnCloseVehicles_Click);
            // 
            // lblActiveUserVehicles
            // 
            this.lblActiveUserVehicles.AutoSize = true;
            this.lblActiveUserVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveUserVehicles.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblActiveUserVehicles.Location = new System.Drawing.Point(971, 11);
            this.lblActiveUserVehicles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActiveUserVehicles.Name = "lblActiveUserVehicles";
            this.lblActiveUserVehicles.Size = new System.Drawing.Size(295, 31);
            this.lblActiveUserVehicles.TabIndex = 43;
            this.lblActiveUserVehicles.Text = "Active User: TNokoane";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblActionSuccessful
            // 
            this.lblActionSuccessful.AutoSize = true;
            this.lblActionSuccessful.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblActionSuccessful.ForeColor = System.Drawing.Color.Red;
            this.lblActionSuccessful.Location = new System.Drawing.Point(475, 361);
            this.lblActionSuccessful.Name = "lblActionSuccessful";
            this.lblActionSuccessful.Size = new System.Drawing.Size(0, 20);
            this.lblActionSuccessful.TabIndex = 44;
            // 
            // rbAddVehicle
            // 
            this.rbAddVehicle.AutoSize = true;
            this.rbAddVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rbAddVehicle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbAddVehicle.Location = new System.Drawing.Point(133, 66);
            this.rbAddVehicle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbAddVehicle.Name = "rbAddVehicle";
            this.rbAddVehicle.Size = new System.Drawing.Size(135, 28);
            this.rbAddVehicle.TabIndex = 45;
            this.rbAddVehicle.TabStop = true;
            this.rbAddVehicle.Text = "Add Vehicle";
            this.rbAddVehicle.UseVisualStyleBackColor = true;
            this.rbAddVehicle.CheckedChanged += new System.EventHandler(this.rbAddVehicle_CheckedChanged);
            // 
            // rbUpdateVehicle
            // 
            this.rbUpdateVehicle.AutoSize = true;
            this.rbUpdateVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rbUpdateVehicle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbUpdateVehicle.Location = new System.Drawing.Point(395, 66);
            this.rbUpdateVehicle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbUpdateVehicle.Name = "rbUpdateVehicle";
            this.rbUpdateVehicle.Size = new System.Drawing.Size(160, 28);
            this.rbUpdateVehicle.TabIndex = 46;
            this.rbUpdateVehicle.TabStop = true;
            this.rbUpdateVehicle.Text = "Update Vehicle";
            this.rbUpdateVehicle.UseVisualStyleBackColor = true;
            this.rbUpdateVehicle.CheckedChanged += new System.EventHandler(this.rbUpdateVehicle_CheckedChanged);
            // 
            // rbDeleteVehicle
            // 
            this.rbDeleteVehicle.AutoSize = true;
            this.rbDeleteVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rbDeleteVehicle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbDeleteVehicle.Location = new System.Drawing.Point(672, 66);
            this.rbDeleteVehicle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbDeleteVehicle.Name = "rbDeleteVehicle";
            this.rbDeleteVehicle.Size = new System.Drawing.Size(154, 28);
            this.rbDeleteVehicle.TabIndex = 47;
            this.rbDeleteVehicle.TabStop = true;
            this.rbDeleteVehicle.Text = "Delete Vehicle";
            this.rbDeleteVehicle.UseVisualStyleBackColor = true;
            this.rbDeleteVehicle.CheckedChanged += new System.EventHandler(this.rbDeleteVehicle_CheckedChanged);
            // 
            // lblVehicleChooseAction
            // 
            this.lblVehicleChooseAction.AutoSize = true;
            this.lblVehicleChooseAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblVehicleChooseAction.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblVehicleChooseAction.Location = new System.Drawing.Point(284, 14);
            this.lblVehicleChooseAction.Name = "lblVehicleChooseAction";
            this.lblVehicleChooseAction.Size = new System.Drawing.Size(408, 29);
            this.lblVehicleChooseAction.TabIndex = 48;
            this.lblVehicleChooseAction.Text = "Welcome, what would you like to do?";
            // 
            // Vehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1320, 750);
            this.Controls.Add(this.lblVehicleChooseAction);
            this.Controls.Add(this.rbDeleteVehicle);
            this.Controls.Add(this.rbUpdateVehicle);
            this.Controls.Add(this.rbAddVehicle);
            this.Controls.Add(this.lblActionSuccessful);
            this.Controls.Add(this.lblActiveUserVehicles);
            this.Controls.Add(this.btnCloseVehicles);
            this.Controls.Add(this.lbVehicleHelp);
            this.Controls.Add(this.btnDeleteVehicle);
            this.Controls.Add(this.btnUpdateVehicle);
            this.Controls.Add(this.btnAddVehicle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbVehicleDetails);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Vehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle";
            this.Load += new System.EventHandler(this.Vehicle_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).EndInit();
            this.gbVehicleDetails.ResumeLayout(false);
            this.gbVehicleDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbVehicleHelp;
        private System.Windows.Forms.Button btnDeleteVehicle;
        private System.Windows.Forms.Button btnUpdateVehicle;
        private System.Windows.Forms.Button btnAddVehicle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvVehicles;
        private System.Windows.Forms.GroupBox gbVehicleDetails;
        private System.Windows.Forms.Label lblClientCell;
        private System.Windows.Forms.ComboBox cbVehicleColor;
        private System.Windows.Forms.Label lblVehicleColor;
        private System.Windows.Forms.Label lblVehicleModel;
        private System.Windows.Forms.TextBox tbVehicleNumberPlate;
        private System.Windows.Forms.TextBox tbVehicleID;
        private System.Windows.Forms.Label lblVehicleID;
        private System.Windows.Forms.Label lblNumberPlate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSearchVehicleNumberPlate;
        private System.Windows.Forms.Button btnCloseVehicles;
        private System.Windows.Forms.Label lblActiveUserVehicles;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cbVehicleModelName;
        private System.Windows.Forms.Button btnAddModel;
        private System.Windows.Forms.Label lblActionSuccessful;
        private System.Windows.Forms.Label lblVehicleChooseAction;
        private System.Windows.Forms.RadioButton rbDeleteVehicle;
        private System.Windows.Forms.RadioButton rbUpdateVehicle;
        private System.Windows.Forms.RadioButton rbAddVehicle;
        private System.Windows.Forms.TextBox tbVClientCellNum;
    }
}