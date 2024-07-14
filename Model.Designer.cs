
namespace Sparkling_CarWash
{
    partial class Model
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbVehicleTypeName = new System.Windows.Forms.ComboBox();
            this.cbMakeName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbModelName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMakeAdd = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblActiveUserVehicles = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbVehicleTypeName);
            this.groupBox1.Controls.Add(this.cbMakeName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbModelName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnMakeAdd);
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(162, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 429);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADD MODEL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(104, 329);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 7;
            // 
            // cbVehicleTypeName
            // 
            this.cbVehicleTypeName.FormattingEnabled = true;
            this.cbVehicleTypeName.Location = new System.Drawing.Point(187, 171);
            this.cbVehicleTypeName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbVehicleTypeName.Name = "cbVehicleTypeName";
            this.cbVehicleTypeName.Size = new System.Drawing.Size(116, 21);
            this.cbVehicleTypeName.TabIndex = 3;
            // 
            // cbMakeName
            // 
            this.cbMakeName.FormattingEnabled = true;
            this.cbMakeName.Location = new System.Drawing.Point(187, 132);
            this.cbMakeName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbMakeName.Name = "cbMakeName";
            this.cbMakeName.Size = new System.Drawing.Size(116, 21);
            this.cbMakeName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(102, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Make Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(102, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vehicle Type";
            // 
            // tbModelName
            // 
            this.tbModelName.Location = new System.Drawing.Point(187, 94);
            this.tbModelName.Name = "tbModelName";
            this.tbModelName.Size = new System.Drawing.Size(116, 20);
            this.tbModelName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(102, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Model Name:";
            // 
            // btnMakeAdd
            // 
            this.btnMakeAdd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMakeAdd.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnMakeAdd.Location = new System.Drawing.Point(105, 234);
            this.btnMakeAdd.Name = "btnMakeAdd";
            this.btnMakeAdd.Size = new System.Drawing.Size(198, 46);
            this.btnMakeAdd.TabIndex = 4;
            this.btnMakeAdd.Text = "Add Model";
            this.btnMakeAdd.UseVisualStyleBackColor = false;
            this.btnMakeAdd.Click += new System.EventHandler(this.btnMakeAdd_Click);
            // 
            // listBox1
            // 
            this.listBox1.ForeColor = System.Drawing.Color.DarkCyan;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Help Functionality",
            "",
            "Add a model to the system:",
            "-Type in the name of the model",
            "-Click on the drop down for the ",
            "\"Make Name\"",
            "-Select the Make name of the ",
            "model you have just inserted",
            "-Click on the drop down for the ",
            "\"Vehicle Type\"",
            "-Select the Vehicle type of the ",
            "model you have just inserted",
            "-Click \"Add Model\" to add the ",
            "model to the system"});
            this.listBox1.Location = new System.Drawing.Point(618, 96);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(177, 368);
            this.listBox1.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.ForeColor = System.Drawing.Color.DarkCyan;
            this.button1.Location = new System.Drawing.Point(618, 479);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "Close Model";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblActiveUserVehicles
            // 
            this.lblActiveUserVehicles.AutoSize = true;
            this.lblActiveUserVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveUserVehicles.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblActiveUserVehicles.Location = new System.Drawing.Point(728, 9);
            this.lblActiveUserVehicles.Name = "lblActiveUserVehicles";
            this.lblActiveUserVehicles.Size = new System.Drawing.Size(235, 26);
            this.lblActiveUserVehicles.TabIndex = 44;
            this.lblActiveUserVehicles.Text = "Active User: TNokoane";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Model
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(990, 609);
            this.Controls.Add(this.lblActiveUserVehicles);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Model";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Model";
            this.Load += new System.EventHandler(this.Model_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbModelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMakeAdd;
        private System.Windows.Forms.ComboBox cbVehicleTypeName;
        private System.Windows.Forms.ComboBox cbMakeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblActiveUserVehicles;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label4;
    }
}