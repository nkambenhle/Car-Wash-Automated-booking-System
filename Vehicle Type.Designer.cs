
namespace Sparkling_CarWash
{
    partial class Vehicle_Type
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
            this.AddVehicle = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbVehicleTypeName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbVehicleBillingRecord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DeleteVehicle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbVehicleTypeName = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.lblActiveUserVTpyes = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblClientsChooseAction = new System.Windows.Forms.Label();
            this.rbAddVehicleType = new System.Windows.Forms.RadioButton();
            this.rbDeleteVehicleType = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddVehicle
            // 
            this.AddVehicle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AddVehicle.ForeColor = System.Drawing.Color.DarkCyan;
            this.AddVehicle.Location = new System.Drawing.Point(26, 238);
            this.AddVehicle.Margin = new System.Windows.Forms.Padding(2);
            this.AddVehicle.Name = "AddVehicle";
            this.AddVehicle.Size = new System.Drawing.Size(225, 42);
            this.AddVehicle.TabIndex = 3;
            this.AddVehicle.Text = "Add Vehicle Type";
            this.AddVehicle.UseVisualStyleBackColor = false;
            this.AddVehicle.Click += new System.EventHandler(this.AddVehicle_Click);
            // 
            // listBox1
            // 
            this.listBox1.ForeColor = System.Drawing.Color.DarkCyan;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Help Functionality",
            "",
            "Add a vehicle type to the system:",
            "-Type in the name of the vehicle type",
            "-Type in the billing record of the vehicle type",
            "-Click \"Add Vehicle Type\" to add the ",
            "vehicle type to the system",
            "",
            "Delete a vehicle type from the system:",
            "-Click on the drop down box to ",
            "display all the vehicle type names",
            "-Select the vehicle type you want to ",
            "delete from the combo box ",
            "-Click \"Delete Vehicle Type\" to delete the ",
            "vehicle type from the system"});
            this.listBox1.Location = new System.Drawing.Point(707, 103);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(217, 381);
            this.listBox1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(23, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Vehicle Type Name:";
            // 
            // tbVehicleTypeName
            // 
            this.tbVehicleTypeName.Location = new System.Drawing.Point(130, 107);
            this.tbVehicleTypeName.Margin = new System.Windows.Forms.Padding(2);
            this.tbVehicleTypeName.Name = "tbVehicleTypeName";
            this.tbVehicleTypeName.Size = new System.Drawing.Size(121, 20);
            this.tbVehicleTypeName.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbVehicleBillingRecord);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbVehicleTypeName);
            this.groupBox1.Controls.Add(this.AddVehicle);
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(80, 103);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(271, 375);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADD VEHICLE TYPE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(23, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Billing Record:";
            // 
            // tbVehicleBillingRecord
            // 
            this.tbVehicleBillingRecord.Location = new System.Drawing.Point(130, 146);
            this.tbVehicleBillingRecord.Margin = new System.Windows.Forms.Padding(2);
            this.tbVehicleBillingRecord.Name = "tbVehicleBillingRecord";
            this.tbVehicleBillingRecord.Size = new System.Drawing.Size(121, 20);
            this.tbVehicleBillingRecord.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(23, 329);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "label2";
            // 
            // DeleteVehicle
            // 
            this.DeleteVehicle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DeleteVehicle.ForeColor = System.Drawing.Color.DarkCyan;
            this.DeleteVehicle.Location = new System.Drawing.Point(23, 238);
            this.DeleteVehicle.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteVehicle.Name = "DeleteVehicle";
            this.DeleteVehicle.Size = new System.Drawing.Size(228, 42);
            this.DeleteVehicle.TabIndex = 5;
            this.DeleteVehicle.Text = "Delete Vehicle Type";
            this.DeleteVehicle.UseVisualStyleBackColor = false;
            this.DeleteVehicle.Click += new System.EventHandler(this.DeleteVehicle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(20, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Vehicle Type Name:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbVehicleTypeName);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.DeleteVehicle);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Location = new System.Drawing.Point(383, 103);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(285, 375);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DELETE VEHICLE TYPE";
            // 
            // cbVehicleTypeName
            // 
            this.cbVehicleTypeName.FormattingEnabled = true;
            this.cbVehicleTypeName.Items.AddRange(new object[] {
            "  "});
            this.cbVehicleTypeName.Location = new System.Drawing.Point(125, 106);
            this.cbVehicleTypeName.Margin = new System.Windows.Forms.Padding(2);
            this.cbVehicleTypeName.Name = "cbVehicleTypeName";
            this.cbVehicleTypeName.Size = new System.Drawing.Size(126, 21);
            this.cbVehicleTypeName.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(20, 329);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "label12";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button3.ForeColor = System.Drawing.Color.DarkCyan;
            this.button3.Location = new System.Drawing.Point(707, 507);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(217, 42);
            this.button3.TabIndex = 6;
            this.button3.Text = "Close Vehicle Types";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblActiveUserVTpyes
            // 
            this.lblActiveUserVTpyes.AutoSize = true;
            this.lblActiveUserVTpyes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveUserVTpyes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblActiveUserVTpyes.Location = new System.Drawing.Point(728, 9);
            this.lblActiveUserVTpyes.Name = "lblActiveUserVTpyes";
            this.lblActiveUserVTpyes.Size = new System.Drawing.Size(235, 26);
            this.lblActiveUserVTpyes.TabIndex = 42;
            this.lblActiveUserVTpyes.Text = "Active User: TNokoane";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblClientsChooseAction
            // 
            this.lblClientsChooseAction.AutoSize = true;
            this.lblClientsChooseAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblClientsChooseAction.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblClientsChooseAction.Location = new System.Drawing.Point(240, 23);
            this.lblClientsChooseAction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClientsChooseAction.Name = "lblClientsChooseAction";
            this.lblClientsChooseAction.Size = new System.Drawing.Size(322, 24);
            this.lblClientsChooseAction.TabIndex = 43;
            this.lblClientsChooseAction.Text = "Welcome, what would you like to do?";
            // 
            // rbAddVehicleType
            // 
            this.rbAddVehicleType.AutoSize = true;
            this.rbAddVehicleType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rbAddVehicleType.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbAddVehicleType.Location = new System.Drawing.Point(161, 59);
            this.rbAddVehicleType.Margin = new System.Windows.Forms.Padding(2);
            this.rbAddVehicleType.Name = "rbAddVehicleType";
            this.rbAddVehicleType.Size = new System.Drawing.Size(138, 22);
            this.rbAddVehicleType.TabIndex = 44;
            this.rbAddVehicleType.TabStop = true;
            this.rbAddVehicleType.Text = "Add Vehicle Type";
            this.rbAddVehicleType.UseVisualStyleBackColor = true;
            this.rbAddVehicleType.CheckedChanged += new System.EventHandler(this.rbAddVehicleType_CheckedChanged_1);
            // 
            // rbDeleteVehicleType
            // 
            this.rbDeleteVehicleType.AutoSize = true;
            this.rbDeleteVehicleType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rbDeleteVehicleType.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbDeleteVehicleType.Location = new System.Drawing.Point(457, 59);
            this.rbDeleteVehicleType.Margin = new System.Windows.Forms.Padding(2);
            this.rbDeleteVehicleType.Name = "rbDeleteVehicleType";
            this.rbDeleteVehicleType.Size = new System.Drawing.Size(155, 22);
            this.rbDeleteVehicleType.TabIndex = 45;
            this.rbDeleteVehicleType.TabStop = true;
            this.rbDeleteVehicleType.Text = "Delete Vehicle Type";
            this.rbDeleteVehicleType.UseVisualStyleBackColor = true;
            this.rbDeleteVehicleType.CheckedChanged += new System.EventHandler(this.rbDeleteVehicleType_CheckedChanged);
            // 
            // Vehicle_Type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(990, 609);
            this.Controls.Add(this.rbDeleteVehicleType);
            this.Controls.Add(this.rbAddVehicleType);
            this.Controls.Add(this.lblClientsChooseAction);
            this.Controls.Add(this.lblActiveUserVTpyes);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Vehicle_Type";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle_Type";
            this.Load += new System.EventHandler(this.Vehicle_Type_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddVehicle;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbVehicleTypeName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DeleteVehicle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbVehicleTypeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblActiveUserVTpyes;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbVehicleBillingRecord;
        private System.Windows.Forms.Label lblClientsChooseAction;
        private System.Windows.Forms.RadioButton rbDeleteVehicleType;
        private System.Windows.Forms.RadioButton rbAddVehicleType;
    }
}