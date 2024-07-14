
namespace Sparkling_CarWash
{
    partial class Make
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
            this.lbMakeHelp = new System.Windows.Forms.ListBox();
            this.gbUpdateMake = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMakeUpdate = new System.Windows.Forms.TextBox();
            this.lblNewMakeUpdate = new System.Windows.Forms.Label();
            this.lblMakeUpdate = new System.Windows.Forms.Label();
            this.cbMakeNameUpdate = new System.Windows.Forms.ComboBox();
            this.btnMakeUpdate = new System.Windows.Forms.Button();
            this.gbDeleteMake = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMakeDelete = new System.Windows.Forms.Label();
            this.cbMakeNameDelete = new System.Windows.Forms.ComboBox();
            this.btnMakeDelete = new System.Windows.Forms.Button();
            this.gbAddMake = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMakeNameAdd = new System.Windows.Forms.TextBox();
            this.lblMakeNameAdd = new System.Windows.Forms.Label();
            this.btnMakeAdd = new System.Windows.Forms.Button();
            this.btnCloseMake = new System.Windows.Forms.Button();
            this.lblActiveUserMake = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblMakeChooseAction = new System.Windows.Forms.Label();
            this.rbAddMake = new System.Windows.Forms.RadioButton();
            this.rbDeleteMake = new System.Windows.Forms.RadioButton();
            this.rbUpdateMake = new System.Windows.Forms.RadioButton();
            this.gbUpdateMake.SuspendLayout();
            this.gbDeleteMake.SuspendLayout();
            this.gbAddMake.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMakeHelp
            // 
            this.lbMakeHelp.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbMakeHelp.FormattingEnabled = true;
            this.lbMakeHelp.ItemHeight = 16;
            this.lbMakeHelp.Items.AddRange(new object[] {
            "Help Functionality",
            "",
            "Select whether you want to ",
            "Add, Delete or Update a make",
            "",
            "Add a make to the system:",
            "-Type in the name of the make",
            "-Click \"Add Make\" to add the ",
            "make to the system",
            "",
            "Update a make in the system:",
            "-Click on the drop down box to ",
            "display all the make names",
            "-Select the make you want to ",
            "update from the combo box ",
            "-Type in the name of the new ",
            "make",
            "-Click \"Update Make\" to update ",
            "the make",
            "",
            "Delete a make from the system:",
            "-Click on the drop down box to ",
            "display all the make names",
            "-Select the make you want to ",
            "delete from the combo box ",
            "-Click \"Delete Make\" to delete ",
            "the make from the system"});
            this.lbMakeHelp.Location = new System.Drawing.Point(1013, 122);
            this.lbMakeHelp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbMakeHelp.Name = "lbMakeHelp";
            this.lbMakeHelp.Size = new System.Drawing.Size(252, 452);
            this.lbMakeHelp.TabIndex = 34;
            // 
            // gbUpdateMake
            // 
            this.gbUpdateMake.Controls.Add(this.label5);
            this.gbUpdateMake.Controls.Add(this.tbMakeUpdate);
            this.gbUpdateMake.Controls.Add(this.lblNewMakeUpdate);
            this.gbUpdateMake.Controls.Add(this.lblMakeUpdate);
            this.gbUpdateMake.Controls.Add(this.cbMakeNameUpdate);
            this.gbUpdateMake.Controls.Add(this.btnMakeUpdate);
            this.gbUpdateMake.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbUpdateMake.Location = new System.Drawing.Point(689, 122);
            this.gbUpdateMake.Margin = new System.Windows.Forms.Padding(4);
            this.gbUpdateMake.Name = "gbUpdateMake";
            this.gbUpdateMake.Padding = new System.Windows.Forms.Padding(4);
            this.gbUpdateMake.Size = new System.Drawing.Size(295, 436);
            this.gbUpdateMake.TabIndex = 33;
            this.gbUpdateMake.TabStop = false;
            this.gbUpdateMake.Text = "UPDATE MAKE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(18, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "label5";
            // 
            // tbMakeUpdate
            // 
            this.tbMakeUpdate.Location = new System.Drawing.Point(127, 159);
            this.tbMakeUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.tbMakeUpdate.Name = "tbMakeUpdate";
            this.tbMakeUpdate.Size = new System.Drawing.Size(147, 22);
            this.tbMakeUpdate.TabIndex = 6;
            // 
            // lblNewMakeUpdate
            // 
            this.lblNewMakeUpdate.AutoSize = true;
            this.lblNewMakeUpdate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNewMakeUpdate.Location = new System.Drawing.Point(28, 162);
            this.lblNewMakeUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewMakeUpdate.Name = "lblNewMakeUpdate";
            this.lblNewMakeUpdate.Size = new System.Drawing.Size(80, 17);
            this.lblNewMakeUpdate.TabIndex = 14;
            this.lblNewMakeUpdate.Text = "New Name:";
            // 
            // lblMakeUpdate
            // 
            this.lblMakeUpdate.AutoSize = true;
            this.lblMakeUpdate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMakeUpdate.Location = new System.Drawing.Point(28, 108);
            this.lblMakeUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMakeUpdate.Name = "lblMakeUpdate";
            this.lblMakeUpdate.Size = new System.Drawing.Size(87, 17);
            this.lblMakeUpdate.TabIndex = 13;
            this.lblMakeUpdate.Text = "Make Name:";
            // 
            // cbMakeNameUpdate
            // 
            this.cbMakeNameUpdate.FormattingEnabled = true;
            this.cbMakeNameUpdate.Location = new System.Drawing.Point(127, 105);
            this.cbMakeNameUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.cbMakeNameUpdate.Name = "cbMakeNameUpdate";
            this.cbMakeNameUpdate.Size = new System.Drawing.Size(147, 24);
            this.cbMakeNameUpdate.TabIndex = 5;
            // 
            // btnMakeUpdate
            // 
            this.btnMakeUpdate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMakeUpdate.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnMakeUpdate.Location = new System.Drawing.Point(33, 278);
            this.btnMakeUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnMakeUpdate.Name = "btnMakeUpdate";
            this.btnMakeUpdate.Size = new System.Drawing.Size(225, 57);
            this.btnMakeUpdate.TabIndex = 7;
            this.btnMakeUpdate.Text = "Update Make";
            this.btnMakeUpdate.UseVisualStyleBackColor = false;
            this.btnMakeUpdate.Click += new System.EventHandler(this.btnMakeUpdate_Click);
            // 
            // gbDeleteMake
            // 
            this.gbDeleteMake.Controls.Add(this.label3);
            this.gbDeleteMake.Controls.Add(this.lblMakeDelete);
            this.gbDeleteMake.Controls.Add(this.cbMakeNameDelete);
            this.gbDeleteMake.Controls.Add(this.btnMakeDelete);
            this.gbDeleteMake.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbDeleteMake.Location = new System.Drawing.Point(361, 122);
            this.gbDeleteMake.Margin = new System.Windows.Forms.Padding(4);
            this.gbDeleteMake.Name = "gbDeleteMake";
            this.gbDeleteMake.Padding = new System.Windows.Forms.Padding(4);
            this.gbDeleteMake.Size = new System.Drawing.Size(295, 436);
            this.gbDeleteMake.TabIndex = 32;
            this.gbDeleteMake.TabStop = false;
            this.gbDeleteMake.Text = "DELETE MAKE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(7, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // lblMakeDelete
            // 
            this.lblMakeDelete.AutoSize = true;
            this.lblMakeDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMakeDelete.Location = new System.Drawing.Point(19, 107);
            this.lblMakeDelete.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMakeDelete.Name = "lblMakeDelete";
            this.lblMakeDelete.Size = new System.Drawing.Size(87, 17);
            this.lblMakeDelete.TabIndex = 8;
            this.lblMakeDelete.Text = "Make Name:";
            // 
            // cbMakeNameDelete
            // 
            this.cbMakeNameDelete.FormattingEnabled = true;
            this.cbMakeNameDelete.Location = new System.Drawing.Point(125, 103);
            this.cbMakeNameDelete.Margin = new System.Windows.Forms.Padding(4);
            this.cbMakeNameDelete.Name = "cbMakeNameDelete";
            this.cbMakeNameDelete.Size = new System.Drawing.Size(133, 24);
            this.cbMakeNameDelete.TabIndex = 3;
            // 
            // btnMakeDelete
            // 
            this.btnMakeDelete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMakeDelete.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnMakeDelete.Location = new System.Drawing.Point(35, 278);
            this.btnMakeDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnMakeDelete.Name = "btnMakeDelete";
            this.btnMakeDelete.Size = new System.Drawing.Size(225, 57);
            this.btnMakeDelete.TabIndex = 4;
            this.btnMakeDelete.Text = "Delete Make";
            this.btnMakeDelete.UseVisualStyleBackColor = false;
            this.btnMakeDelete.Click += new System.EventHandler(this.btnMakeDelete_Click);
            // 
            // gbAddMake
            // 
            this.gbAddMake.Controls.Add(this.label2);
            this.gbAddMake.Controls.Add(this.tbMakeNameAdd);
            this.gbAddMake.Controls.Add(this.lblMakeNameAdd);
            this.gbAddMake.Controls.Add(this.btnMakeAdd);
            this.gbAddMake.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbAddMake.Location = new System.Drawing.Point(36, 122);
            this.gbAddMake.Margin = new System.Windows.Forms.Padding(4);
            this.gbAddMake.Name = "gbAddMake";
            this.gbAddMake.Padding = new System.Windows.Forms.Padding(4);
            this.gbAddMake.Size = new System.Drawing.Size(295, 436);
            this.gbAddMake.TabIndex = 31;
            this.gbAddMake.TabStop = false;
            this.gbAddMake.Text = "ADD MAKE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(7, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // tbMakeNameAdd
            // 
            this.tbMakeNameAdd.Location = new System.Drawing.Point(125, 105);
            this.tbMakeNameAdd.Margin = new System.Windows.Forms.Padding(4);
            this.tbMakeNameAdd.Name = "tbMakeNameAdd";
            this.tbMakeNameAdd.Size = new System.Drawing.Size(132, 22);
            this.tbMakeNameAdd.TabIndex = 1;
            // 
            // lblMakeNameAdd
            // 
            this.lblMakeNameAdd.AutoSize = true;
            this.lblMakeNameAdd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMakeNameAdd.Location = new System.Drawing.Point(29, 107);
            this.lblMakeNameAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMakeNameAdd.Name = "lblMakeNameAdd";
            this.lblMakeNameAdd.Size = new System.Drawing.Size(87, 17);
            this.lblMakeNameAdd.TabIndex = 1;
            this.lblMakeNameAdd.Text = "Make Name:";
            // 
            // btnMakeAdd
            // 
            this.btnMakeAdd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMakeAdd.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnMakeAdd.Location = new System.Drawing.Point(33, 278);
            this.btnMakeAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnMakeAdd.Name = "btnMakeAdd";
            this.btnMakeAdd.Size = new System.Drawing.Size(225, 57);
            this.btnMakeAdd.TabIndex = 2;
            this.btnMakeAdd.Text = "Add Make";
            this.btnMakeAdd.UseVisualStyleBackColor = false;
            this.btnMakeAdd.Click += new System.EventHandler(this.btnMakeAdd_Click);
            // 
            // btnCloseMake
            // 
            this.btnCloseMake.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCloseMake.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnCloseMake.Location = new System.Drawing.Point(1013, 619);
            this.btnCloseMake.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseMake.Name = "btnCloseMake";
            this.btnCloseMake.Size = new System.Drawing.Size(253, 57);
            this.btnCloseMake.TabIndex = 8;
            this.btnCloseMake.Text = "Close Makes";
            this.btnCloseMake.UseVisualStyleBackColor = false;
            this.btnCloseMake.Click += new System.EventHandler(this.btnCloseMake_Click);
            // 
            // lblActiveUserMake
            // 
            this.lblActiveUserMake.AutoSize = true;
            this.lblActiveUserMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveUserMake.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblActiveUserMake.Location = new System.Drawing.Point(971, 11);
            this.lblActiveUserMake.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActiveUserMake.Name = "lblActiveUserMake";
            this.lblActiveUserMake.Size = new System.Drawing.Size(295, 31);
            this.lblActiveUserMake.TabIndex = 35;
            this.lblActiveUserMake.Text = "Active User: TNokoane";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblMakeChooseAction
            // 
            this.lblMakeChooseAction.AutoSize = true;
            this.lblMakeChooseAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblMakeChooseAction.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMakeChooseAction.Location = new System.Drawing.Point(315, 14);
            this.lblMakeChooseAction.Name = "lblMakeChooseAction";
            this.lblMakeChooseAction.Size = new System.Drawing.Size(408, 29);
            this.lblMakeChooseAction.TabIndex = 36;
            this.lblMakeChooseAction.Text = "Welcome, what would you like to do?";
            // 
            // rbAddMake
            // 
            this.rbAddMake.AutoSize = true;
            this.rbAddMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rbAddMake.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbAddMake.Location = new System.Drawing.Point(132, 71);
            this.rbAddMake.Name = "rbAddMake";
            this.rbAddMake.Size = new System.Drawing.Size(117, 28);
            this.rbAddMake.TabIndex = 37;
            this.rbAddMake.TabStop = true;
            this.rbAddMake.Text = "Add Make";
            this.rbAddMake.UseVisualStyleBackColor = true;
            this.rbAddMake.CheckedChanged += new System.EventHandler(this.rbAddMake_CheckedChanged);
            // 
            // rbDeleteMake
            // 
            this.rbDeleteMake.AutoSize = true;
            this.rbDeleteMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rbDeleteMake.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbDeleteMake.Location = new System.Drawing.Point(383, 71);
            this.rbDeleteMake.Name = "rbDeleteMake";
            this.rbDeleteMake.Size = new System.Drawing.Size(136, 28);
            this.rbDeleteMake.TabIndex = 38;
            this.rbDeleteMake.TabStop = true;
            this.rbDeleteMake.Text = "Delete Make";
            this.rbDeleteMake.UseVisualStyleBackColor = true;
            this.rbDeleteMake.CheckedChanged += new System.EventHandler(this.rbDeleteMake_CheckedChanged);
            // 
            // rbUpdateMake
            // 
            this.rbUpdateMake.AutoSize = true;
            this.rbUpdateMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rbUpdateMake.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbUpdateMake.Location = new System.Drawing.Point(687, 71);
            this.rbUpdateMake.Name = "rbUpdateMake";
            this.rbUpdateMake.Size = new System.Drawing.Size(142, 28);
            this.rbUpdateMake.TabIndex = 39;
            this.rbUpdateMake.TabStop = true;
            this.rbUpdateMake.Text = "Update Make";
            this.rbUpdateMake.UseVisualStyleBackColor = true;
            this.rbUpdateMake.CheckedChanged += new System.EventHandler(this.rbUpdateMake_CheckedChanged);
            // 
            // Make
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1320, 758);
            this.Controls.Add(this.rbUpdateMake);
            this.Controls.Add(this.rbDeleteMake);
            this.Controls.Add(this.rbAddMake);
            this.Controls.Add(this.lblMakeChooseAction);
            this.Controls.Add(this.lblActiveUserMake);
            this.Controls.Add(this.btnCloseMake);
            this.Controls.Add(this.lbMakeHelp);
            this.Controls.Add(this.gbUpdateMake);
            this.Controls.Add(this.gbDeleteMake);
            this.Controls.Add(this.gbAddMake);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Make";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Make";
            this.Load += new System.EventHandler(this.Make_Load);
            this.gbUpdateMake.ResumeLayout(false);
            this.gbUpdateMake.PerformLayout();
            this.gbDeleteMake.ResumeLayout(false);
            this.gbDeleteMake.PerformLayout();
            this.gbAddMake.ResumeLayout(false);
            this.gbAddMake.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbMakeHelp;
        private System.Windows.Forms.GroupBox gbUpdateMake;
        private System.Windows.Forms.ComboBox cbMakeNameUpdate;
        private System.Windows.Forms.Button btnMakeUpdate;
        private System.Windows.Forms.GroupBox gbDeleteMake;
        private System.Windows.Forms.ComboBox cbMakeNameDelete;
        private System.Windows.Forms.Button btnMakeDelete;
        private System.Windows.Forms.GroupBox gbAddMake;
        private System.Windows.Forms.TextBox tbMakeNameAdd;
        private System.Windows.Forms.Label lblMakeNameAdd;
        private System.Windows.Forms.Button btnMakeAdd;
        private System.Windows.Forms.TextBox tbMakeUpdate;
        private System.Windows.Forms.Label lblNewMakeUpdate;
        private System.Windows.Forms.Label lblMakeUpdate;
        private System.Windows.Forms.Label lblMakeDelete;
        private System.Windows.Forms.Button btnCloseMake;
        private System.Windows.Forms.Label lblActiveUserMake;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbUpdateMake;
        private System.Windows.Forms.RadioButton rbDeleteMake;
        private System.Windows.Forms.RadioButton rbAddMake;
        private System.Windows.Forms.Label lblMakeChooseAction;
    }
}