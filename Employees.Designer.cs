
namespace Sparkling_CarWash
{
    partial class Employees
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCloseEmployees = new System.Windows.Forms.Button();
            this.gbUpdateEmployee = new System.Windows.Forms.GroupBox();
            this.btnEmpUpdateSearch = new System.Windows.Forms.Button();
            this.tbEmployeeIDUpdate = new System.Windows.Forms.TextBox();
            this.lblEmployeeIDUpdate = new System.Windows.Forms.Label();
            this.lblUpdatedSuccessfully = new System.Windows.Forms.Label();
            this.tbEmpIDNumberUpdate = new System.Windows.Forms.TextBox();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.tbCellNumberUpdate = new System.Windows.Forms.TextBox();
            this.lblEmpIDNumUpdate = new System.Windows.Forms.Label();
            this.tbSurnameUpdate = new System.Windows.Forms.TextBox();
            this.lblSurnameUpdate = new System.Windows.Forms.Label();
            this.dgvEmployeeUpdate = new System.Windows.Forms.DataGridView();
            this.lblCellNumberUpdate = new System.Windows.Forms.Label();
            this.gbDeleteEmployee = new System.Windows.Forms.GroupBox();
            this.btnEmpDeleteSearch = new System.Windows.Forms.Button();
            this.lblDeletedSuccessfully = new System.Windows.Forms.Label();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.tbEmployeeIDDelete = new System.Windows.Forms.TextBox();
            this.tbEmpIDNumberDelete = new System.Windows.Forms.TextBox();
            this.lblIdNumDelete = new System.Windows.Forms.Label();
            this.lblEmployeeIDDelete = new System.Windows.Forms.Label();
            this.dgvEmployeeDelete = new System.Windows.Forms.DataGridView();
            this.gbAddEmployee = new System.Windows.Forms.GroupBox();
            this.lblAddedSuccessfully = new System.Windows.Forms.Label();
            this.tbEmpCellNumberAdd = new System.Windows.Forms.TextBox();
            this.lblEmpCellNumberAdd = new System.Windows.Forms.Label();
            this.tbEmployeeName = new System.Windows.Forms.TextBox();
            this.lblFirstNameAdd = new System.Windows.Forms.Label();
            this.tbEmpIDNumberAdd = new System.Windows.Forms.TextBox();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.tbEmployeeSurnameAdd = new System.Windows.Forms.TextBox();
            this.lblLastNameAdd = new System.Windows.Forms.Label();
            this.lblEmpIdNumberAdd = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbEmployeeHelp = new System.Windows.Forms.ListBox();
            this.lblActiveUserEmployees = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.rbAddEmployee = new System.Windows.Forms.RadioButton();
            this.rbUpdateEmployee = new System.Windows.Forms.RadioButton();
            this.rbDeleteEmployee = new System.Windows.Forms.RadioButton();
            this.lblEmpChooseAction = new System.Windows.Forms.Label();
            this.gbUpdateEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeUpdate)).BeginInit();
            this.gbDeleteEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeDelete)).BeginInit();
            this.gbAddEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCloseEmployees
            // 
            this.btnCloseEmployees.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCloseEmployees.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnCloseEmployees.Location = new System.Drawing.Point(1040, 586);
            this.btnCloseEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCloseEmployees.Name = "btnCloseEmployees";
            this.btnCloseEmployees.Size = new System.Drawing.Size(253, 54);
            this.btnCloseEmployees.TabIndex = 16;
            this.btnCloseEmployees.Text = "Close";
            this.btnCloseEmployees.UseVisualStyleBackColor = false;
            this.btnCloseEmployees.Click += new System.EventHandler(this.btnCloseEmployees_Click_1);
            // 
            // gbUpdateEmployee
            // 
            this.gbUpdateEmployee.Controls.Add(this.btnEmpUpdateSearch);
            this.gbUpdateEmployee.Controls.Add(this.tbEmployeeIDUpdate);
            this.gbUpdateEmployee.Controls.Add(this.lblEmployeeIDUpdate);
            this.gbUpdateEmployee.Controls.Add(this.lblUpdatedSuccessfully);
            this.gbUpdateEmployee.Controls.Add(this.tbEmpIDNumberUpdate);
            this.gbUpdateEmployee.Controls.Add(this.btnUpdateEmployee);
            this.gbUpdateEmployee.Controls.Add(this.tbCellNumberUpdate);
            this.gbUpdateEmployee.Controls.Add(this.lblEmpIDNumUpdate);
            this.gbUpdateEmployee.Controls.Add(this.tbSurnameUpdate);
            this.gbUpdateEmployee.Controls.Add(this.lblSurnameUpdate);
            this.gbUpdateEmployee.Controls.Add(this.dgvEmployeeUpdate);
            this.gbUpdateEmployee.Controls.Add(this.lblCellNumberUpdate);
            this.gbUpdateEmployee.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbUpdateEmployee.Location = new System.Drawing.Point(711, 107);
            this.gbUpdateEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbUpdateEmployee.Name = "gbUpdateEmployee";
            this.gbUpdateEmployee.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbUpdateEmployee.Size = new System.Drawing.Size(295, 503);
            this.gbUpdateEmployee.TabIndex = 13;
            this.gbUpdateEmployee.TabStop = false;
            this.gbUpdateEmployee.Text = "UPDATE EMPLOYEE";
            // 
            // btnEmpUpdateSearch
            // 
            this.btnEmpUpdateSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEmpUpdateSearch.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnEmpUpdateSearch.Location = new System.Drawing.Point(135, 84);
            this.btnEmpUpdateSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmpUpdateSearch.Name = "btnEmpUpdateSearch";
            this.btnEmpUpdateSearch.Size = new System.Drawing.Size(129, 38);
            this.btnEmpUpdateSearch.TabIndex = 11;
            this.btnEmpUpdateSearch.Text = "Search ID";
            this.btnEmpUpdateSearch.UseVisualStyleBackColor = false;
            this.btnEmpUpdateSearch.Click += new System.EventHandler(this.btnEmpUpdateSearch_Click);
            // 
            // tbEmployeeIDUpdate
            // 
            this.tbEmployeeIDUpdate.Location = new System.Drawing.Point(135, 251);
            this.tbEmployeeIDUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmployeeIDUpdate.Name = "tbEmployeeIDUpdate";
            this.tbEmployeeIDUpdate.Size = new System.Drawing.Size(128, 22);
            this.tbEmployeeIDUpdate.TabIndex = 12;
            // 
            // lblEmployeeIDUpdate
            // 
            this.lblEmployeeIDUpdate.AutoSize = true;
            this.lblEmployeeIDUpdate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEmployeeIDUpdate.Location = new System.Drawing.Point(33, 255);
            this.lblEmployeeIDUpdate.Name = "lblEmployeeIDUpdate";
            this.lblEmployeeIDUpdate.Size = new System.Drawing.Size(87, 17);
            this.lblEmployeeIDUpdate.TabIndex = 21;
            this.lblEmployeeIDUpdate.Text = "Employee ID";
            // 
            // lblUpdatedSuccessfully
            // 
            this.lblUpdatedSuccessfully.AutoSize = true;
            this.lblUpdatedSuccessfully.ForeColor = System.Drawing.Color.Red;
            this.lblUpdatedSuccessfully.Location = new System.Drawing.Point(6, 468);
            this.lblUpdatedSuccessfully.Name = "lblUpdatedSuccessfully";
            this.lblUpdatedSuccessfully.Size = new System.Drawing.Size(54, 17);
            this.lblUpdatedSuccessfully.TabIndex = 12;
            this.lblUpdatedSuccessfully.Text = "label13";
            // 
            // tbEmpIDNumberUpdate
            // 
            this.tbEmpIDNumberUpdate.Location = new System.Drawing.Point(135, 43);
            this.tbEmpIDNumberUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmpIDNumberUpdate.Name = "tbEmpIDNumberUpdate";
            this.tbEmpIDNumberUpdate.Size = new System.Drawing.Size(128, 22);
            this.tbEmpIDNumberUpdate.TabIndex = 10;
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdateEmployee.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnUpdateEmployee.Location = new System.Drawing.Point(39, 373);
            this.btnUpdateEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(225, 57);
            this.btnUpdateEmployee.TabIndex = 15;
            this.btnUpdateEmployee.Text = "Update Employee Details";
            this.btnUpdateEmployee.UseVisualStyleBackColor = false;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // tbCellNumberUpdate
            // 
            this.tbCellNumberUpdate.Location = new System.Drawing.Point(135, 320);
            this.tbCellNumberUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCellNumberUpdate.Name = "tbCellNumberUpdate";
            this.tbCellNumberUpdate.Size = new System.Drawing.Size(128, 22);
            this.tbCellNumberUpdate.TabIndex = 14;
            // 
            // lblEmpIDNumUpdate
            // 
            this.lblEmpIDNumUpdate.AutoSize = true;
            this.lblEmpIDNumUpdate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEmpIDNumUpdate.Location = new System.Drawing.Point(35, 46);
            this.lblEmpIDNumUpdate.Name = "lblEmpIDNumUpdate";
            this.lblEmpIDNumUpdate.Size = new System.Drawing.Size(75, 17);
            this.lblEmpIDNumUpdate.TabIndex = 17;
            this.lblEmpIDNumUpdate.Text = "ID Number";
            // 
            // tbSurnameUpdate
            // 
            this.tbSurnameUpdate.Location = new System.Drawing.Point(135, 285);
            this.tbSurnameUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSurnameUpdate.Name = "tbSurnameUpdate";
            this.tbSurnameUpdate.Size = new System.Drawing.Size(128, 22);
            this.tbSurnameUpdate.TabIndex = 13;
            // 
            // lblSurnameUpdate
            // 
            this.lblSurnameUpdate.AutoSize = true;
            this.lblSurnameUpdate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSurnameUpdate.Location = new System.Drawing.Point(33, 290);
            this.lblSurnameUpdate.Name = "lblSurnameUpdate";
            this.lblSurnameUpdate.Size = new System.Drawing.Size(76, 17);
            this.lblSurnameUpdate.TabIndex = 3;
            this.lblSurnameUpdate.Text = "Last Name";
            // 
            // dgvEmployeeUpdate
            // 
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.DarkCyan;
            this.dgvEmployeeUpdate.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvEmployeeUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeUpdate.Location = new System.Drawing.Point(39, 135);
            this.dgvEmployeeUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvEmployeeUpdate.Name = "dgvEmployeeUpdate";
            this.dgvEmployeeUpdate.RowHeadersWidth = 51;
            this.dgvEmployeeUpdate.RowTemplate.Height = 24;
            this.dgvEmployeeUpdate.Size = new System.Drawing.Size(225, 97);
            this.dgvEmployeeUpdate.TabIndex = 18;
            // 
            // lblCellNumberUpdate
            // 
            this.lblCellNumberUpdate.AutoSize = true;
            this.lblCellNumberUpdate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCellNumberUpdate.Location = new System.Drawing.Point(35, 324);
            this.lblCellNumberUpdate.Name = "lblCellNumberUpdate";
            this.lblCellNumberUpdate.Size = new System.Drawing.Size(97, 17);
            this.lblCellNumberUpdate.TabIndex = 6;
            this.lblCellNumberUpdate.Text = "Cellphone No.";
            // 
            // gbDeleteEmployee
            // 
            this.gbDeleteEmployee.Controls.Add(this.btnEmpDeleteSearch);
            this.gbDeleteEmployee.Controls.Add(this.lblDeletedSuccessfully);
            this.gbDeleteEmployee.Controls.Add(this.btnDeleteEmployee);
            this.gbDeleteEmployee.Controls.Add(this.tbEmployeeIDDelete);
            this.gbDeleteEmployee.Controls.Add(this.tbEmpIDNumberDelete);
            this.gbDeleteEmployee.Controls.Add(this.lblIdNumDelete);
            this.gbDeleteEmployee.Controls.Add(this.lblEmployeeIDDelete);
            this.gbDeleteEmployee.Controls.Add(this.dgvEmployeeDelete);
            this.gbDeleteEmployee.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbDeleteEmployee.Location = new System.Drawing.Point(387, 107);
            this.gbDeleteEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDeleteEmployee.Name = "gbDeleteEmployee";
            this.gbDeleteEmployee.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDeleteEmployee.Size = new System.Drawing.Size(295, 503);
            this.gbDeleteEmployee.TabIndex = 12;
            this.gbDeleteEmployee.TabStop = false;
            this.gbDeleteEmployee.Text = "DELETE EMPLOYEE";
            // 
            // btnEmpDeleteSearch
            // 
            this.btnEmpDeleteSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEmpDeleteSearch.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnEmpDeleteSearch.Location = new System.Drawing.Point(129, 79);
            this.btnEmpDeleteSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmpDeleteSearch.Name = "btnEmpDeleteSearch";
            this.btnEmpDeleteSearch.Size = new System.Drawing.Size(129, 38);
            this.btnEmpDeleteSearch.TabIndex = 7;
            this.btnEmpDeleteSearch.Text = "Search ID";
            this.btnEmpDeleteSearch.UseVisualStyleBackColor = false;
            this.btnEmpDeleteSearch.Click += new System.EventHandler(this.btnEmpDeleteSearch_Click_2);
            // 
            // lblDeletedSuccessfully
            // 
            this.lblDeletedSuccessfully.AutoSize = true;
            this.lblDeletedSuccessfully.ForeColor = System.Drawing.Color.Red;
            this.lblDeletedSuccessfully.Location = new System.Drawing.Point(6, 468);
            this.lblDeletedSuccessfully.Name = "lblDeletedSuccessfully";
            this.lblDeletedSuccessfully.Size = new System.Drawing.Size(54, 17);
            this.lblDeletedSuccessfully.TabIndex = 11;
            this.lblDeletedSuccessfully.Text = "label12";
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteEmployee.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnDeleteEmployee.Location = new System.Drawing.Point(33, 373);
            this.btnDeleteEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(225, 57);
            this.btnDeleteEmployee.TabIndex = 9;
            this.btnDeleteEmployee.Text = "Delete Employee Details";
            this.btnDeleteEmployee.UseVisualStyleBackColor = false;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployees_Click_2);
            // 
            // tbEmployeeIDDelete
            // 
            this.tbEmployeeIDDelete.Location = new System.Drawing.Point(139, 267);
            this.tbEmployeeIDDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmployeeIDDelete.Name = "tbEmployeeIDDelete";
            this.tbEmployeeIDDelete.Size = new System.Drawing.Size(119, 22);
            this.tbEmployeeIDDelete.TabIndex = 8;
            // 
            // tbEmpIDNumberDelete
            // 
            this.tbEmpIDNumberDelete.Location = new System.Drawing.Point(129, 42);
            this.tbEmpIDNumberDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmpIDNumberDelete.Name = "tbEmpIDNumberDelete";
            this.tbEmpIDNumberDelete.Size = new System.Drawing.Size(128, 22);
            this.tbEmpIDNumberDelete.TabIndex = 6;
            // 
            // lblIdNumDelete
            // 
            this.lblIdNumDelete.AutoSize = true;
            this.lblIdNumDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblIdNumDelete.Location = new System.Drawing.Point(29, 44);
            this.lblIdNumDelete.Name = "lblIdNumDelete";
            this.lblIdNumDelete.Size = new System.Drawing.Size(75, 17);
            this.lblIdNumDelete.TabIndex = 17;
            this.lblIdNumDelete.Text = "ID Number";
            // 
            // lblEmployeeIDDelete
            // 
            this.lblEmployeeIDDelete.AutoSize = true;
            this.lblEmployeeIDDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEmployeeIDDelete.Location = new System.Drawing.Point(29, 271);
            this.lblEmployeeIDDelete.Name = "lblEmployeeIDDelete";
            this.lblEmployeeIDDelete.Size = new System.Drawing.Size(87, 17);
            this.lblEmployeeIDDelete.TabIndex = 18;
            this.lblEmployeeIDDelete.Text = "Employee ID";
            // 
            // dgvEmployeeDelete
            // 
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.dgvEmployeeDelete.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvEmployeeDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployeeDelete.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvEmployeeDelete.Location = new System.Drawing.Point(33, 136);
            this.dgvEmployeeDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvEmployeeDelete.Name = "dgvEmployeeDelete";
            this.dgvEmployeeDelete.RowHeadersWidth = 51;
            this.dgvEmployeeDelete.RowTemplate.Height = 24;
            this.dgvEmployeeDelete.Size = new System.Drawing.Size(225, 96);
            this.dgvEmployeeDelete.TabIndex = 17;
            // 
            // gbAddEmployee
            // 
            this.gbAddEmployee.Controls.Add(this.lblAddedSuccessfully);
            this.gbAddEmployee.Controls.Add(this.tbEmpCellNumberAdd);
            this.gbAddEmployee.Controls.Add(this.lblEmpCellNumberAdd);
            this.gbAddEmployee.Controls.Add(this.tbEmployeeName);
            this.gbAddEmployee.Controls.Add(this.lblFirstNameAdd);
            this.gbAddEmployee.Controls.Add(this.tbEmpIDNumberAdd);
            this.gbAddEmployee.Controls.Add(this.btnAddEmployee);
            this.gbAddEmployee.Controls.Add(this.tbEmployeeSurnameAdd);
            this.gbAddEmployee.Controls.Add(this.lblLastNameAdd);
            this.gbAddEmployee.Controls.Add(this.lblEmpIdNumberAdd);
            this.gbAddEmployee.Controls.Add(this.label6);
            this.gbAddEmployee.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbAddEmployee.Location = new System.Drawing.Point(53, 107);
            this.gbAddEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbAddEmployee.Name = "gbAddEmployee";
            this.gbAddEmployee.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbAddEmployee.Size = new System.Drawing.Size(295, 503);
            this.gbAddEmployee.TabIndex = 11;
            this.gbAddEmployee.TabStop = false;
            this.gbAddEmployee.Text = "ADD EMPLOYEE";
            // 
            // lblAddedSuccessfully
            // 
            this.lblAddedSuccessfully.AutoSize = true;
            this.lblAddedSuccessfully.ForeColor = System.Drawing.Color.Red;
            this.lblAddedSuccessfully.Location = new System.Drawing.Point(6, 468);
            this.lblAddedSuccessfully.Name = "lblAddedSuccessfully";
            this.lblAddedSuccessfully.Size = new System.Drawing.Size(54, 17);
            this.lblAddedSuccessfully.TabIndex = 10;
            this.lblAddedSuccessfully.Text = "label11";
            // 
            // tbEmpCellNumberAdd
            // 
            this.tbEmpCellNumberAdd.Location = new System.Drawing.Point(129, 252);
            this.tbEmpCellNumberAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmpCellNumberAdd.Name = "tbEmpCellNumberAdd";
            this.tbEmpCellNumberAdd.Size = new System.Drawing.Size(124, 22);
            this.tbEmpCellNumberAdd.TabIndex = 4;
            // 
            // lblEmpCellNumberAdd
            // 
            this.lblEmpCellNumberAdd.AutoSize = true;
            this.lblEmpCellNumberAdd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEmpCellNumberAdd.Location = new System.Drawing.Point(25, 256);
            this.lblEmpCellNumberAdd.Name = "lblEmpCellNumberAdd";
            this.lblEmpCellNumberAdd.Size = new System.Drawing.Size(97, 17);
            this.lblEmpCellNumberAdd.TabIndex = 19;
            this.lblEmpCellNumberAdd.Text = "Cellphone No.";
            // 
            // tbEmployeeName
            // 
            this.tbEmployeeName.Location = new System.Drawing.Point(127, 87);
            this.tbEmployeeName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmployeeName.Name = "tbEmployeeName";
            this.tbEmployeeName.Size = new System.Drawing.Size(127, 22);
            this.tbEmployeeName.TabIndex = 1;
            // 
            // lblFirstNameAdd
            // 
            this.lblFirstNameAdd.AutoSize = true;
            this.lblFirstNameAdd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFirstNameAdd.Location = new System.Drawing.Point(27, 87);
            this.lblFirstNameAdd.Name = "lblFirstNameAdd";
            this.lblFirstNameAdd.Size = new System.Drawing.Size(76, 17);
            this.lblFirstNameAdd.TabIndex = 17;
            this.lblFirstNameAdd.Text = "First Name";
            // 
            // tbEmpIDNumberAdd
            // 
            this.tbEmpIDNumberAdd.Location = new System.Drawing.Point(128, 193);
            this.tbEmpIDNumberAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmpIDNumberAdd.Name = "tbEmpIDNumberAdd";
            this.tbEmpIDNumberAdd.Size = new System.Drawing.Size(125, 22);
            this.tbEmpIDNumberAdd.TabIndex = 3;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddEmployee.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnAddEmployee.Location = new System.Drawing.Point(29, 373);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(225, 57);
            this.btnAddEmployee.TabIndex = 5;
            this.btnAddEmployee.Text = "Add New Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployees_Click);
            // 
            // tbEmployeeSurnameAdd
            // 
            this.tbEmployeeSurnameAdd.Location = new System.Drawing.Point(128, 139);
            this.tbEmployeeSurnameAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmployeeSurnameAdd.Name = "tbEmployeeSurnameAdd";
            this.tbEmployeeSurnameAdd.Size = new System.Drawing.Size(125, 22);
            this.tbEmployeeSurnameAdd.TabIndex = 2;
            // 
            // lblLastNameAdd
            // 
            this.lblLastNameAdd.AutoSize = true;
            this.lblLastNameAdd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblLastNameAdd.Location = new System.Drawing.Point(27, 139);
            this.lblLastNameAdd.Name = "lblLastNameAdd";
            this.lblLastNameAdd.Size = new System.Drawing.Size(76, 17);
            this.lblLastNameAdd.TabIndex = 2;
            this.lblLastNameAdd.Text = "Last Name";
            // 
            // lblEmpIdNumberAdd
            // 
            this.lblEmpIdNumberAdd.AutoSize = true;
            this.lblEmpIdNumberAdd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEmpIdNumberAdd.Location = new System.Drawing.Point(27, 193);
            this.lblEmpIdNumberAdd.Name = "lblEmpIdNumberAdd";
            this.lblEmpIdNumberAdd.Size = new System.Drawing.Size(75, 17);
            this.lblEmpIdNumberAdd.TabIndex = 5;
            this.lblEmpIdNumberAdd.Text = "ID Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(577, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 7;
            // 
            // lbEmployeeHelp
            // 
            this.lbEmployeeHelp.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbEmployeeHelp.FormattingEnabled = true;
            this.lbEmployeeHelp.ItemHeight = 16;
            this.lbEmployeeHelp.Items.AddRange(new object[] {
            "Help Functionality",
            "",
            "Select whether you want to ",
            "Add, Delete or Update an employee",
            "",
            "Add an employee to the system:",
            "-Type in the name of the employee",
            "-Type in the last name of the employee",
            "-Type in the ID number of the employee",
            "-Type in the cell phone number of the ",
            "employee",
            "-Click \"Add New Employee\" to add the ",
            "employee to the system",
            "",
            "Delete an employee from the system:",
            "-Type in the ID number of the employee",
            "-Click \"Search ID\" to find the employee",
            "-Type in the primary key that is shown  ",
            "-Click \"Delete Employee Details\" to ",
            "delete the employee from the system",
            "",
            "Update an employee in the system:",
            "-Type in the ID number of the ",
            "desired employee",
            "-Click \"Search ID\" to display the details",
            "of the employee",
            "-Type the primary key that is displayed",
            "-Type in the details that you want to ",
            "update",
            "-Click \"Update Employee Details\" to update ",
            "the employee details"});
            this.lbEmployeeHelp.Location = new System.Drawing.Point(1040, 107);
            this.lbEmployeeHelp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbEmployeeHelp.Name = "lbEmployeeHelp";
            this.lbEmployeeHelp.Size = new System.Drawing.Size(252, 452);
            this.lbEmployeeHelp.TabIndex = 26;
            // 
            // lblActiveUserEmployees
            // 
            this.lblActiveUserEmployees.AutoSize = true;
            this.lblActiveUserEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveUserEmployees.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblActiveUserEmployees.Location = new System.Drawing.Point(971, 11);
            this.lblActiveUserEmployees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActiveUserEmployees.Name = "lblActiveUserEmployees";
            this.lblActiveUserEmployees.Size = new System.Drawing.Size(295, 31);
            this.lblActiveUserEmployees.TabIndex = 27;
            this.lblActiveUserEmployees.Text = "Active User: TNokoane";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // rbAddEmployee
            // 
            this.rbAddEmployee.AutoSize = true;
            this.rbAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rbAddEmployee.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbAddEmployee.Location = new System.Drawing.Point(142, 53);
            this.rbAddEmployee.Name = "rbAddEmployee";
            this.rbAddEmployee.Size = new System.Drawing.Size(157, 28);
            this.rbAddEmployee.TabIndex = 28;
            this.rbAddEmployee.TabStop = true;
            this.rbAddEmployee.Text = "Add Employee";
            this.rbAddEmployee.UseVisualStyleBackColor = true;
            this.rbAddEmployee.CheckedChanged += new System.EventHandler(this.rbAddEmployee_CheckedChanged_1);
            // 
            // rbUpdateEmployee
            // 
            this.rbUpdateEmployee.AutoSize = true;
            this.rbUpdateEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rbUpdateEmployee.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbUpdateEmployee.Location = new System.Drawing.Point(711, 53);
            this.rbUpdateEmployee.Name = "rbUpdateEmployee";
            this.rbUpdateEmployee.Size = new System.Drawing.Size(182, 28);
            this.rbUpdateEmployee.TabIndex = 29;
            this.rbUpdateEmployee.TabStop = true;
            this.rbUpdateEmployee.Text = "Update Employee";
            this.rbUpdateEmployee.UseVisualStyleBackColor = true;
            this.rbUpdateEmployee.CheckedChanged += new System.EventHandler(this.rbUpdateEmployee_CheckedChanged_1);
            // 
            // rbDeleteEmployee
            // 
            this.rbDeleteEmployee.AutoSize = true;
            this.rbDeleteEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rbDeleteEmployee.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbDeleteEmployee.Location = new System.Drawing.Point(419, 53);
            this.rbDeleteEmployee.Name = "rbDeleteEmployee";
            this.rbDeleteEmployee.Size = new System.Drawing.Size(176, 28);
            this.rbDeleteEmployee.TabIndex = 30;
            this.rbDeleteEmployee.TabStop = true;
            this.rbDeleteEmployee.Text = "Delete Employee";
            this.rbDeleteEmployee.UseVisualStyleBackColor = true;
            this.rbDeleteEmployee.CheckedChanged += new System.EventHandler(this.rbDeleteEmployee_CheckedChanged_1);
            // 
            // lblEmpChooseAction
            // 
            this.lblEmpChooseAction.AutoSize = true;
            this.lblEmpChooseAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblEmpChooseAction.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEmpChooseAction.Location = new System.Drawing.Point(311, 11);
            this.lblEmpChooseAction.Name = "lblEmpChooseAction";
            this.lblEmpChooseAction.Size = new System.Drawing.Size(408, 29);
            this.lblEmpChooseAction.TabIndex = 31;
            this.lblEmpChooseAction.Text = "Welcome, what would you like to do?";
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1320, 758);
            this.Controls.Add(this.lblEmpChooseAction);
            this.Controls.Add(this.rbDeleteEmployee);
            this.Controls.Add(this.rbUpdateEmployee);
            this.Controls.Add(this.rbAddEmployee);
            this.Controls.Add(this.lblActiveUserEmployees);
            this.Controls.Add(this.lbEmployeeHelp);
            this.Controls.Add(this.btnCloseEmployees);
            this.Controls.Add(this.gbUpdateEmployee);
            this.Controls.Add(this.gbDeleteEmployee);
            this.Controls.Add(this.gbAddEmployee);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Employees_Load);
            this.gbUpdateEmployee.ResumeLayout(false);
            this.gbUpdateEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeUpdate)).EndInit();
            this.gbDeleteEmployee.ResumeLayout(false);
            this.gbDeleteEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeDelete)).EndInit();
            this.gbAddEmployee.ResumeLayout(false);
            this.gbAddEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCloseEmployees;
        private System.Windows.Forms.GroupBox gbUpdateEmployee;
        private System.Windows.Forms.Button btnEmpUpdateSearch;
        private System.Windows.Forms.TextBox tbEmployeeIDUpdate;
        private System.Windows.Forms.Label lblEmployeeIDUpdate;
        private System.Windows.Forms.Label lblUpdatedSuccessfully;
        private System.Windows.Forms.TextBox tbEmpIDNumberUpdate;
        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.TextBox tbCellNumberUpdate;
        private System.Windows.Forms.Label lblEmpIDNumUpdate;
        private System.Windows.Forms.TextBox tbSurnameUpdate;
        private System.Windows.Forms.Label lblSurnameUpdate;
        private System.Windows.Forms.DataGridView dgvEmployeeUpdate;
        private System.Windows.Forms.Label lblCellNumberUpdate;
        private System.Windows.Forms.GroupBox gbDeleteEmployee;
        private System.Windows.Forms.Button btnEmpDeleteSearch;
        private System.Windows.Forms.Label lblDeletedSuccessfully;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.TextBox tbEmployeeIDDelete;
        private System.Windows.Forms.TextBox tbEmpIDNumberDelete;
        private System.Windows.Forms.Label lblIdNumDelete;
        private System.Windows.Forms.Label lblEmployeeIDDelete;
        private System.Windows.Forms.DataGridView dgvEmployeeDelete;
        private System.Windows.Forms.GroupBox gbAddEmployee;
        private System.Windows.Forms.Label lblAddedSuccessfully;
        private System.Windows.Forms.TextBox tbEmpCellNumberAdd;
        private System.Windows.Forms.Label lblEmpCellNumberAdd;
        private System.Windows.Forms.TextBox tbEmployeeName;
        private System.Windows.Forms.Label lblFirstNameAdd;
        private System.Windows.Forms.TextBox tbEmpIDNumberAdd;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.TextBox tbEmployeeSurnameAdd;
        private System.Windows.Forms.Label lblLastNameAdd;
        private System.Windows.Forms.Label lblEmpIdNumberAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbEmployeeHelp;
        private System.Windows.Forms.Label lblActiveUserEmployees;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblEmpChooseAction;
        private System.Windows.Forms.RadioButton rbDeleteEmployee;
        private System.Windows.Forms.RadioButton rbUpdateEmployee;
        private System.Windows.Forms.RadioButton rbAddEmployee;
    }
}