
namespace Sparkling_CarWash
{
    partial class Clients
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
            this.lbClientsHelp = new System.Windows.Forms.ListBox();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.btnUpdateClient = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.gbClientDetails = new System.Windows.Forms.GroupBox();
            this.btnClientsSearch = new System.Windows.Forms.Button();
            this.tbClientCellNum = new System.Windows.Forms.TextBox();
            this.lblClientCellNum = new System.Windows.Forms.Label();
            this.tbClientName = new System.Windows.Forms.TextBox();
            this.tbClientSurname = new System.Windows.Forms.TextBox();
            this.tbClientID = new System.Windows.Forms.TextBox();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblClientSurname = new System.Windows.Forms.Label();
            this.lblClientID = new System.Windows.Forms.Label();
            this.lblActiveUserClients = new System.Windows.Forms.Label();
            this.btnCloseClients = new System.Windows.Forms.Button();
            this.lblClientErrorMeassge = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblClientsChooseAction = new System.Windows.Forms.Label();
            this.rbAddClient = new System.Windows.Forms.RadioButton();
            this.rbUpdateClient = new System.Windows.Forms.RadioButton();
            this.rbDeleteClient = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.gbClientDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbClientsHelp
            // 
            this.lbClientsHelp.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbClientsHelp.FormattingEnabled = true;
            this.lbClientsHelp.ItemHeight = 16;
            this.lbClientsHelp.Items.AddRange(new object[] {
            "Help Functionality",
            "",
            "Select whether you want to ",
            "Add, Update or Delete a client",
            "",
            "Add a client to the system:",
            "-Type in the cell phone number of the ",
            "client",
            "-Type in the name of the client ",
            "-Type in the surname of the client",
            "-Click \"Add New Client\" to add the ",
            "client to the system",
            "",
            "Delete a client from the system:",
            "-Type in the cell phone number of the ",
            "client",
            "-Click \"Search ID\" to find the client",
            "-Type in the Client No. that is shown  ",
            "-Click \"Delete Client Details\" to ",
            "delete the client from the system",
            "",
            "Update a client in the system:",
            "-Type in the cell phone number of the ",
            "client",
            "-Click \"Search ID\" to display the details",
            "of the client",
            "-Type the Client No. that is displayed",
            "-Type in the details that you want to ",
            "update",
            "-Click \"Update Client Details\" to update ",
            "the client details"});
            this.lbClientsHelp.Location = new System.Drawing.Point(1020, 98);
            this.lbClientsHelp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbClientsHelp.Name = "lbClientsHelp";
            this.lbClientsHelp.Size = new System.Drawing.Size(265, 484);
            this.lbClientsHelp.TabIndex = 31;
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteClient.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnDeleteClient.Location = new System.Drawing.Point(698, 614);
            this.btnDeleteClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(259, 57);
            this.btnDeleteClient.TabIndex = 8;
            this.btnDeleteClient.Text = "Delete Clients Details";
            this.btnDeleteClient.UseVisualStyleBackColor = false;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click_1);
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdateClient.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnUpdateClient.Location = new System.Drawing.Point(371, 614);
            this.btnUpdateClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(259, 57);
            this.btnUpdateClient.TabIndex = 7;
            this.btnUpdateClient.Text = "Update Client Details";
            this.btnUpdateClient.UseVisualStyleBackColor = false;
            this.btnUpdateClient.Click += new System.EventHandler(this.btnUpdateClient_Click_1);
            // 
            // btnAddClient
            // 
            this.btnAddClient.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddClient.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnAddClient.Location = new System.Drawing.Point(44, 614);
            this.btnAddClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(259, 57);
            this.btnAddClient.TabIndex = 6;
            this.btnAddClient.Text = "Add Client";
            this.btnAddClient.UseVisualStyleBackColor = false;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvClients);
            this.groupBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Location = new System.Drawing.Point(44, 345);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(955, 230);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CLIENTS ON THE SYSTEM";
            // 
            // dgvClients
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvClients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClients.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClients.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClients.Location = new System.Drawing.Point(7, 22);
            this.dgvClients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.RowHeadersWidth = 51;
            this.dgvClients.RowTemplate.Height = 24;
            this.dgvClients.Size = new System.Drawing.Size(941, 197);
            this.dgvClients.TabIndex = 0;
            // 
            // gbClientDetails
            // 
            this.gbClientDetails.Controls.Add(this.btnClientsSearch);
            this.gbClientDetails.Controls.Add(this.tbClientCellNum);
            this.gbClientDetails.Controls.Add(this.lblClientCellNum);
            this.gbClientDetails.Controls.Add(this.tbClientName);
            this.gbClientDetails.Controls.Add(this.tbClientSurname);
            this.gbClientDetails.Controls.Add(this.tbClientID);
            this.gbClientDetails.Controls.Add(this.lblClientName);
            this.gbClientDetails.Controls.Add(this.lblClientSurname);
            this.gbClientDetails.Controls.Add(this.lblClientID);
            this.gbClientDetails.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbClientDetails.Location = new System.Drawing.Point(51, 98);
            this.gbClientDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbClientDetails.Name = "gbClientDetails";
            this.gbClientDetails.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbClientDetails.Size = new System.Drawing.Size(955, 226);
            this.gbClientDetails.TabIndex = 26;
            this.gbClientDetails.TabStop = false;
            this.gbClientDetails.Text = "CLIENT DETAILS";
            // 
            // btnClientsSearch
            // 
            this.btnClientsSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClientsSearch.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnClientsSearch.Location = new System.Drawing.Point(227, 80);
            this.btnClientsSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClientsSearch.Name = "btnClientsSearch";
            this.btnClientsSearch.Size = new System.Drawing.Size(221, 47);
            this.btnClientsSearch.TabIndex = 2;
            this.btnClientsSearch.Text = "Search";
            this.btnClientsSearch.UseVisualStyleBackColor = false;
            this.btnClientsSearch.Click += new System.EventHandler(this.btnClientsSearch_Click_1);
            // 
            // tbClientCellNum
            // 
            this.tbClientCellNum.Location = new System.Drawing.Point(228, 49);
            this.tbClientCellNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbClientCellNum.Name = "tbClientCellNum";
            this.tbClientCellNum.Size = new System.Drawing.Size(220, 22);
            this.tbClientCellNum.TabIndex = 1;
            // 
            // lblClientCellNum
            // 
            this.lblClientCellNum.AutoSize = true;
            this.lblClientCellNum.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblClientCellNum.Location = new System.Drawing.Point(97, 54);
            this.lblClientCellNum.Name = "lblClientCellNum";
            this.lblClientCellNum.Size = new System.Drawing.Size(97, 17);
            this.lblClientCellNum.TabIndex = 24;
            this.lblClientCellNum.Text = "Cellphone No.";
            // 
            // tbClientName
            // 
            this.tbClientName.Location = new System.Drawing.Point(228, 164);
            this.tbClientName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.Size = new System.Drawing.Size(220, 22);
            this.tbClientName.TabIndex = 3;
            // 
            // tbClientSurname
            // 
            this.tbClientSurname.Location = new System.Drawing.Point(647, 162);
            this.tbClientSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbClientSurname.Name = "tbClientSurname";
            this.tbClientSurname.Size = new System.Drawing.Size(220, 22);
            this.tbClientSurname.TabIndex = 4;
            // 
            // tbClientID
            // 
            this.tbClientID.Location = new System.Drawing.Point(647, 51);
            this.tbClientID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbClientID.Name = "tbClientID";
            this.tbClientID.Size = new System.Drawing.Size(220, 22);
            this.tbClientID.TabIndex = 5;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblClientName.Location = new System.Drawing.Point(97, 167);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(45, 17);
            this.lblClientName.TabIndex = 2;
            this.lblClientName.Text = "Name";
            // 
            // lblClientSurname
            // 
            this.lblClientSurname.AutoSize = true;
            this.lblClientSurname.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblClientSurname.Location = new System.Drawing.Point(537, 167);
            this.lblClientSurname.Name = "lblClientSurname";
            this.lblClientSurname.Size = new System.Drawing.Size(65, 17);
            this.lblClientSurname.TabIndex = 3;
            this.lblClientSurname.Text = "Surname";
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblClientID.Location = new System.Drawing.Point(537, 54);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(60, 17);
            this.lblClientID.TabIndex = 4;
            this.lblClientID.Text = "Client ID";
            // 
            // lblActiveUserClients
            // 
            this.lblActiveUserClients.AutoSize = true;
            this.lblActiveUserClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveUserClients.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblActiveUserClients.Location = new System.Drawing.Point(971, 11);
            this.lblActiveUserClients.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActiveUserClients.Name = "lblActiveUserClients";
            this.lblActiveUserClients.Size = new System.Drawing.Size(295, 31);
            this.lblActiveUserClients.TabIndex = 32;
            this.lblActiveUserClients.Text = "Active User: TNokoane";
            // 
            // btnCloseClients
            // 
            this.btnCloseClients.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCloseClients.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnCloseClients.Location = new System.Drawing.Point(1020, 614);
            this.btnCloseClients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCloseClients.Name = "btnCloseClients";
            this.btnCloseClients.Size = new System.Drawing.Size(267, 57);
            this.btnCloseClients.TabIndex = 9;
            this.btnCloseClients.Text = "Close";
            this.btnCloseClients.UseVisualStyleBackColor = false;
            this.btnCloseClients.Click += new System.EventHandler(this.btnCloseClients_Click_1);
            // 
            // lblClientErrorMeassge
            // 
            this.lblClientErrorMeassge.AutoSize = true;
            this.lblClientErrorMeassge.BackColor = System.Drawing.Color.DarkCyan;
            this.lblClientErrorMeassge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClientErrorMeassge.ForeColor = System.Drawing.Color.Red;
            this.lblClientErrorMeassge.Location = new System.Drawing.Point(56, 704);
            this.lblClientErrorMeassge.Name = "lblClientErrorMeassge";
            this.lblClientErrorMeassge.Size = new System.Drawing.Size(154, 19);
            this.lblClientErrorMeassge.TabIndex = 26;
            this.lblClientErrorMeassge.Text = "                                    ";
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
            this.lblClientsChooseAction.Location = new System.Drawing.Point(274, 14);
            this.lblClientsChooseAction.Name = "lblClientsChooseAction";
            this.lblClientsChooseAction.Size = new System.Drawing.Size(408, 29);
            this.lblClientsChooseAction.TabIndex = 33;
            this.lblClientsChooseAction.Text = "Welcome, what would you like to do?";
            // 
            // rbAddClient
            // 
            this.rbAddClient.AutoSize = true;
            this.rbAddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rbAddClient.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbAddClient.Location = new System.Drawing.Point(92, 55);
            this.rbAddClient.Name = "rbAddClient";
            this.rbAddClient.Size = new System.Drawing.Size(118, 28);
            this.rbAddClient.TabIndex = 34;
            this.rbAddClient.TabStop = true;
            this.rbAddClient.Text = "Add Client";
            this.rbAddClient.UseVisualStyleBackColor = true;
            this.rbAddClient.CheckedChanged += new System.EventHandler(this.rbAddClient_CheckedChanged);
            // 
            // rbUpdateClient
            // 
            this.rbUpdateClient.AutoSize = true;
            this.rbUpdateClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rbUpdateClient.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbUpdateClient.Location = new System.Drawing.Point(389, 62);
            this.rbUpdateClient.Name = "rbUpdateClient";
            this.rbUpdateClient.Size = new System.Drawing.Size(143, 28);
            this.rbUpdateClient.TabIndex = 35;
            this.rbUpdateClient.TabStop = true;
            this.rbUpdateClient.Text = "Update Client";
            this.rbUpdateClient.UseVisualStyleBackColor = true;
            this.rbUpdateClient.CheckedChanged += new System.EventHandler(this.rbUpdateClient_CheckedChanged);
            // 
            // rbDeleteClient
            // 
            this.rbDeleteClient.AutoSize = true;
            this.rbDeleteClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rbDeleteClient.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbDeleteClient.Location = new System.Drawing.Point(698, 62);
            this.rbDeleteClient.Name = "rbDeleteClient";
            this.rbDeleteClient.Size = new System.Drawing.Size(137, 28);
            this.rbDeleteClient.TabIndex = 36;
            this.rbDeleteClient.TabStop = true;
            this.rbDeleteClient.Text = "Delete Client";
            this.rbDeleteClient.UseVisualStyleBackColor = true;
            this.rbDeleteClient.CheckedChanged += new System.EventHandler(this.rbDeleteClient_CheckedChanged);
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1320, 758);
            this.Controls.Add(this.rbDeleteClient);
            this.Controls.Add(this.rbUpdateClient);
            this.Controls.Add(this.rbAddClient);
            this.Controls.Add(this.lblClientsChooseAction);
            this.Controls.Add(this.lblClientErrorMeassge);
            this.Controls.Add(this.btnCloseClients);
            this.Controls.Add(this.lblActiveUserClients);
            this.Controls.Add(this.lbClientsHelp);
            this.Controls.Add(this.btnDeleteClient);
            this.Controls.Add(this.btnUpdateClient);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbClientDetails);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Clients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.frmClients_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.gbClientDetails.ResumeLayout(false);
            this.gbClientDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbClientsHelp;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.Button btnUpdateClient;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.GroupBox gbClientDetails;
        private System.Windows.Forms.TextBox tbClientCellNum;
        private System.Windows.Forms.Label lblClientCellNum;
        private System.Windows.Forms.TextBox tbClientName;
        private System.Windows.Forms.TextBox tbClientSurname;
        private System.Windows.Forms.TextBox tbClientID;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblClientSurname;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.Label lblActiveUserClients;
        private System.Windows.Forms.Button btnCloseClients;
        private System.Windows.Forms.Label lblClientErrorMeassge;
        private System.Windows.Forms.Button btnClientsSearch;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.RadioButton rbDeleteClient;
        private System.Windows.Forms.RadioButton rbUpdateClient;
        private System.Windows.Forms.RadioButton rbAddClient;
        private System.Windows.Forms.Label lblClientsChooseAction;
    }
}