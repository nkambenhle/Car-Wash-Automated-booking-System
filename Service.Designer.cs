
namespace Sparkling_CarWash
{
    partial class Service
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
            this.gbUpdateService = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbServiceDurationUpdate = new System.Windows.Forms.TextBox();
            this.tbServicePriceUpdate = new System.Windows.Forms.TextBox();
            this.cbServiceNameUpdate = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnServiceUpdate = new System.Windows.Forms.Button();
            this.gbDeleteService = new System.Windows.Forms.GroupBox();
            this.cbServiceNameDelete = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnServiceDelete = new System.Windows.Forms.Button();
            this.gbAddService = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbServiceDurationAdd = new System.Windows.Forms.TextBox();
            this.tbServicePriceAdd = new System.Windows.Forms.TextBox();
            this.tbServiceNameAdd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnServiceAdd = new System.Windows.Forms.Button();
            this.lblServiceHelp = new System.Windows.Forms.ListBox();
            this.btnCloseService = new System.Windows.Forms.Button();
            this.lblActiveUserServices = new System.Windows.Forms.Label();
            this.lblServiceChooseAction = new System.Windows.Forms.Label();
            this.rbAddService = new System.Windows.Forms.RadioButton();
            this.rbDeleteService = new System.Windows.Forms.RadioButton();
            this.rbUpdateService = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblAddService = new System.Windows.Forms.Label();
            this.lblDeleteService = new System.Windows.Forms.Label();
            this.lblUpdateService = new System.Windows.Forms.Label();
            this.gbUpdateService.SuspendLayout();
            this.gbDeleteService.SuspendLayout();
            this.gbAddService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbUpdateService
            // 
            this.gbUpdateService.Controls.Add(this.lblUpdateService);
            this.gbUpdateService.Controls.Add(this.label8);
            this.gbUpdateService.Controls.Add(this.label4);
            this.gbUpdateService.Controls.Add(this.label5);
            this.gbUpdateService.Controls.Add(this.tbServiceDurationUpdate);
            this.gbUpdateService.Controls.Add(this.tbServicePriceUpdate);
            this.gbUpdateService.Controls.Add(this.cbServiceNameUpdate);
            this.gbUpdateService.Controls.Add(this.label9);
            this.gbUpdateService.Controls.Add(this.btnServiceUpdate);
            this.gbUpdateService.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbUpdateService.Location = new System.Drawing.Point(709, 126);
            this.gbUpdateService.Margin = new System.Windows.Forms.Padding(4);
            this.gbUpdateService.Name = "gbUpdateService";
            this.gbUpdateService.Padding = new System.Windows.Forms.Padding(4);
            this.gbUpdateService.Size = new System.Drawing.Size(295, 436);
            this.gbUpdateService.TabIndex = 11;
            this.gbUpdateService.TabStop = false;
            this.gbUpdateService.Text = "UPDATE SERVICE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(187, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "( HH:mm:ss)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(28, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Duration:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(28, 126);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Service Price:";
            // 
            // tbServiceDurationUpdate
            // 
            this.tbServiceDurationUpdate.Location = new System.Drawing.Point(139, 167);
            this.tbServiceDurationUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.tbServiceDurationUpdate.Name = "tbServiceDurationUpdate";
            this.tbServiceDurationUpdate.Size = new System.Drawing.Size(132, 22);
            this.tbServiceDurationUpdate.TabIndex = 9;
            // 
            // tbServicePriceUpdate
            // 
            this.tbServicePriceUpdate.Location = new System.Drawing.Point(139, 122);
            this.tbServicePriceUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.tbServicePriceUpdate.Name = "tbServicePriceUpdate";
            this.tbServicePriceUpdate.Size = new System.Drawing.Size(132, 22);
            this.tbServicePriceUpdate.TabIndex = 8;
            // 
            // cbServiceNameUpdate
            // 
            this.cbServiceNameUpdate.FormattingEnabled = true;
            this.cbServiceNameUpdate.Location = new System.Drawing.Point(139, 71);
            this.cbServiceNameUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.cbServiceNameUpdate.Name = "cbServiceNameUpdate";
            this.cbServiceNameUpdate.Size = new System.Drawing.Size(132, 24);
            this.cbServiceNameUpdate.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(28, 75);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Service Name:";
            // 
            // btnServiceUpdate
            // 
            this.btnServiceUpdate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnServiceUpdate.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnServiceUpdate.Location = new System.Drawing.Point(47, 314);
            this.btnServiceUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnServiceUpdate.Name = "btnServiceUpdate";
            this.btnServiceUpdate.Size = new System.Drawing.Size(225, 57);
            this.btnServiceUpdate.TabIndex = 10;
            this.btnServiceUpdate.Text = "Update Service";
            this.btnServiceUpdate.UseVisualStyleBackColor = false;
            this.btnServiceUpdate.Click += new System.EventHandler(this.btnServiceUpdate_Click);
            // 
            // gbDeleteService
            // 
            this.gbDeleteService.Controls.Add(this.lblDeleteService);
            this.gbDeleteService.Controls.Add(this.cbServiceNameDelete);
            this.gbDeleteService.Controls.Add(this.label6);
            this.gbDeleteService.Controls.Add(this.btnServiceDelete);
            this.gbDeleteService.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbDeleteService.Location = new System.Drawing.Point(383, 126);
            this.gbDeleteService.Margin = new System.Windows.Forms.Padding(4);
            this.gbDeleteService.Name = "gbDeleteService";
            this.gbDeleteService.Padding = new System.Windows.Forms.Padding(4);
            this.gbDeleteService.Size = new System.Drawing.Size(295, 436);
            this.gbDeleteService.TabIndex = 10;
            this.gbDeleteService.TabStop = false;
            this.gbDeleteService.Text = "DELETE SERVICE";
            // 
            // cbServiceNameDelete
            // 
            this.cbServiceNameDelete.FormattingEnabled = true;
            this.cbServiceNameDelete.Location = new System.Drawing.Point(127, 70);
            this.cbServiceNameDelete.Margin = new System.Windows.Forms.Padding(4);
            this.cbServiceNameDelete.Name = "cbServiceNameDelete";
            this.cbServiceNameDelete.Size = new System.Drawing.Size(129, 24);
            this.cbServiceNameDelete.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(28, 74);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Service Name:";
            // 
            // btnServiceDelete
            // 
            this.btnServiceDelete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnServiceDelete.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnServiceDelete.Location = new System.Drawing.Point(32, 314);
            this.btnServiceDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnServiceDelete.Name = "btnServiceDelete";
            this.btnServiceDelete.Size = new System.Drawing.Size(225, 57);
            this.btnServiceDelete.TabIndex = 6;
            this.btnServiceDelete.Text = "Delete Service";
            this.btnServiceDelete.UseVisualStyleBackColor = false;
            this.btnServiceDelete.Click += new System.EventHandler(this.btnServiceDelete_Click);
            // 
            // gbAddService
            // 
            this.gbAddService.Controls.Add(this.lblAddService);
            this.gbAddService.Controls.Add(this.label7);
            this.gbAddService.Controls.Add(this.label3);
            this.gbAddService.Controls.Add(this.label2);
            this.gbAddService.Controls.Add(this.tbServiceDurationAdd);
            this.gbAddService.Controls.Add(this.tbServicePriceAdd);
            this.gbAddService.Controls.Add(this.tbServiceNameAdd);
            this.gbAddService.Controls.Add(this.label1);
            this.gbAddService.Controls.Add(this.btnServiceAdd);
            this.gbAddService.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbAddService.Location = new System.Drawing.Point(55, 126);
            this.gbAddService.Margin = new System.Windows.Forms.Padding(4);
            this.gbAddService.Name = "gbAddService";
            this.gbAddService.Padding = new System.Windows.Forms.Padding(4);
            this.gbAddService.Size = new System.Drawing.Size(295, 436);
            this.gbAddService.TabIndex = 9;
            this.gbAddService.TabStop = false;
            this.gbAddService.Text = "ADD SERVICE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(173, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "( HH:mm:ss)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(29, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Duration:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(29, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Service Price:";
            // 
            // tbServiceDurationAdd
            // 
            this.tbServiceDurationAdd.Location = new System.Drawing.Point(137, 169);
            this.tbServiceDurationAdd.Margin = new System.Windows.Forms.Padding(4);
            this.tbServiceDurationAdd.Name = "tbServiceDurationAdd";
            this.tbServiceDurationAdd.Size = new System.Drawing.Size(120, 22);
            this.tbServiceDurationAdd.TabIndex = 3;
            // 
            // tbServicePriceAdd
            // 
            this.tbServicePriceAdd.Location = new System.Drawing.Point(137, 121);
            this.tbServicePriceAdd.Margin = new System.Windows.Forms.Padding(4);
            this.tbServicePriceAdd.Name = "tbServicePriceAdd";
            this.tbServicePriceAdd.Size = new System.Drawing.Size(120, 22);
            this.tbServicePriceAdd.TabIndex = 2;
            // 
            // tbServiceNameAdd
            // 
            this.tbServiceNameAdd.Location = new System.Drawing.Point(135, 71);
            this.tbServiceNameAdd.Margin = new System.Windows.Forms.Padding(4);
            this.tbServiceNameAdd.Name = "tbServiceNameAdd";
            this.tbServiceNameAdd.Size = new System.Drawing.Size(123, 22);
            this.tbServiceNameAdd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(29, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Service Name:";
            // 
            // btnServiceAdd
            // 
            this.btnServiceAdd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnServiceAdd.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnServiceAdd.Location = new System.Drawing.Point(33, 314);
            this.btnServiceAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnServiceAdd.Name = "btnServiceAdd";
            this.btnServiceAdd.Size = new System.Drawing.Size(225, 57);
            this.btnServiceAdd.TabIndex = 4;
            this.btnServiceAdd.Text = "Add Service";
            this.btnServiceAdd.UseVisualStyleBackColor = false;
            this.btnServiceAdd.Click += new System.EventHandler(this.btnServiceAdd_Click);
            // 
            // lblServiceHelp
            // 
            this.lblServiceHelp.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblServiceHelp.FormattingEnabled = true;
            this.lblServiceHelp.ItemHeight = 16;
            this.lblServiceHelp.Items.AddRange(new object[] {
            "Help Functionality",
            "",
            "Select whether you want to ",
            "Add, Delete or Update a service",
            "",
            "Add a service to the system:",
            "-Type in the name of the service",
            "-Type in the price of the service",
            "-Type in the duration of the service",
            "-Click \"Add Service\" to add the ",
            "service to the system",
            "",
            "Update a service in the system:",
            "-Click on the drop down box to ",
            "display all the service names",
            "-Select the service you want to ",
            "update from the combo box ",
            "-Type in the details that you want to ",
            "update",
            "-Click \"Update Service\" to update ",
            "the service",
            "",
            "Delete a service from the system:",
            "-Click on the drop down box to ",
            "display all the service names",
            "-Select the service you want to ",
            "delete from the combo box ",
            "-Click \"Delete Service\" to delete the ",
            "service from the system"});
            this.lblServiceHelp.Location = new System.Drawing.Point(1033, 126);
            this.lblServiceHelp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblServiceHelp.Name = "lblServiceHelp";
            this.lblServiceHelp.Size = new System.Drawing.Size(224, 452);
            this.lblServiceHelp.TabIndex = 30;
            // 
            // btnCloseService
            // 
            this.btnCloseService.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCloseService.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnCloseService.Location = new System.Drawing.Point(1033, 606);
            this.btnCloseService.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseService.Name = "btnCloseService";
            this.btnCloseService.Size = new System.Drawing.Size(225, 57);
            this.btnCloseService.TabIndex = 12;
            this.btnCloseService.Text = "Close Services";
            this.btnCloseService.UseVisualStyleBackColor = false;
            this.btnCloseService.Click += new System.EventHandler(this.btnCloseService_Click);
            // 
            // lblActiveUserServices
            // 
            this.lblActiveUserServices.AutoSize = true;
            this.lblActiveUserServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveUserServices.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblActiveUserServices.Location = new System.Drawing.Point(971, 11);
            this.lblActiveUserServices.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActiveUserServices.Name = "lblActiveUserServices";
            this.lblActiveUserServices.Size = new System.Drawing.Size(295, 31);
            this.lblActiveUserServices.TabIndex = 37;
            this.lblActiveUserServices.Text = "Active User: TNokoane";
            // 
            // lblServiceChooseAction
            // 
            this.lblServiceChooseAction.AutoSize = true;
            this.lblServiceChooseAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblServiceChooseAction.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblServiceChooseAction.Location = new System.Drawing.Point(337, 23);
            this.lblServiceChooseAction.Name = "lblServiceChooseAction";
            this.lblServiceChooseAction.Size = new System.Drawing.Size(408, 29);
            this.lblServiceChooseAction.TabIndex = 38;
            this.lblServiceChooseAction.Text = "Welcome, what would you like to do?";
            // 
            // rbAddService
            // 
            this.rbAddService.AutoSize = true;
            this.rbAddService.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rbAddService.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbAddService.Location = new System.Drawing.Point(142, 77);
            this.rbAddService.Name = "rbAddService";
            this.rbAddService.Size = new System.Drawing.Size(134, 28);
            this.rbAddService.TabIndex = 39;
            this.rbAddService.TabStop = true;
            this.rbAddService.Text = "Add Service";
            this.rbAddService.UseVisualStyleBackColor = true;
            this.rbAddService.CheckedChanged += new System.EventHandler(this.rbAddService_CheckedChanged);
            // 
            // rbDeleteService
            // 
            this.rbDeleteService.AutoSize = true;
            this.rbDeleteService.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rbDeleteService.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbDeleteService.Location = new System.Drawing.Point(433, 77);
            this.rbDeleteService.Name = "rbDeleteService";
            this.rbDeleteService.Size = new System.Drawing.Size(153, 28);
            this.rbDeleteService.TabIndex = 40;
            this.rbDeleteService.TabStop = true;
            this.rbDeleteService.Text = "Delete Service";
            this.rbDeleteService.UseVisualStyleBackColor = true;
            // 
            // rbUpdateService
            // 
            this.rbUpdateService.AutoSize = true;
            this.rbUpdateService.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rbUpdateService.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbUpdateService.Location = new System.Drawing.Point(709, 77);
            this.rbUpdateService.Name = "rbUpdateService";
            this.rbUpdateService.Size = new System.Drawing.Size(159, 28);
            this.rbUpdateService.TabIndex = 41;
            this.rbUpdateService.TabStop = true;
            this.rbUpdateService.Text = "Update Service";
            this.rbUpdateService.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblAddService
            // 
            this.lblAddService.AutoSize = true;
            this.lblAddService.Location = new System.Drawing.Point(7, 405);
            this.lblAddService.Name = "lblAddService";
            this.lblAddService.Size = new System.Drawing.Size(54, 17);
            this.lblAddService.TabIndex = 42;
            this.lblAddService.Text = "label10";
            // 
            // lblDeleteService
            // 
            this.lblDeleteService.AutoSize = true;
            this.lblDeleteService.Location = new System.Drawing.Point(18, 405);
            this.lblDeleteService.Name = "lblDeleteService";
            this.lblDeleteService.Size = new System.Drawing.Size(54, 17);
            this.lblDeleteService.TabIndex = 43;
            this.lblDeleteService.Text = "label11";
            // 
            // lblUpdateService
            // 
            this.lblUpdateService.AutoSize = true;
            this.lblUpdateService.Location = new System.Drawing.Point(7, 405);
            this.lblUpdateService.Name = "lblUpdateService";
            this.lblUpdateService.Size = new System.Drawing.Size(54, 17);
            this.lblUpdateService.TabIndex = 44;
            this.lblUpdateService.Text = "label12";
            // 
            // Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1320, 758);
            this.Controls.Add(this.rbUpdateService);
            this.Controls.Add(this.rbDeleteService);
            this.Controls.Add(this.rbAddService);
            this.Controls.Add(this.lblServiceChooseAction);
            this.Controls.Add(this.lblActiveUserServices);
            this.Controls.Add(this.btnCloseService);
            this.Controls.Add(this.lblServiceHelp);
            this.Controls.Add(this.gbUpdateService);
            this.Controls.Add(this.gbDeleteService);
            this.Controls.Add(this.gbAddService);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Service";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service";
            this.Load += new System.EventHandler(this.Service_Load);
            this.gbUpdateService.ResumeLayout(false);
            this.gbUpdateService.PerformLayout();
            this.gbDeleteService.ResumeLayout(false);
            this.gbDeleteService.PerformLayout();
            this.gbAddService.ResumeLayout(false);
            this.gbAddService.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUpdateService;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnServiceUpdate;
        private System.Windows.Forms.GroupBox gbDeleteService;
        private System.Windows.Forms.ComboBox cbServiceNameDelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnServiceDelete;
        private System.Windows.Forms.GroupBox gbAddService;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbServiceDurationAdd;
        private System.Windows.Forms.TextBox tbServicePriceAdd;
        private System.Windows.Forms.TextBox tbServiceNameAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnServiceAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbServiceDurationUpdate;
        private System.Windows.Forms.TextBox tbServicePriceUpdate;
        private System.Windows.Forms.ComboBox cbServiceNameUpdate;
        private System.Windows.Forms.ListBox lblServiceHelp;
        private System.Windows.Forms.Button btnCloseService;
        private System.Windows.Forms.Label lblActiveUserServices;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblServiceChooseAction;
        private System.Windows.Forms.RadioButton rbAddService;
        private System.Windows.Forms.RadioButton rbDeleteService;
        private System.Windows.Forms.RadioButton rbUpdateService;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblUpdateService;
        private System.Windows.Forms.Label lblDeleteService;
        private System.Windows.Forms.Label lblAddService;
    }
}