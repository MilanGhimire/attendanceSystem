namespace StudentAttendence
{
    partial class AddUserAccount
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
            this.comboBoxDepartmentName = new System.Windows.Forms.ComboBox();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.panelSubmit = new System.Windows.Forms.Panel();
            this.buttonSubjectSubmit = new System.Windows.Forms.Button();
            this.panelSubjectContainer = new System.Windows.Forms.Panel();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.panelSubjectTextbox = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelAddUser = new System.Windows.Forms.Label();
            this.panelSubmit.SuspendLayout();
            this.panelSubjectContainer.SuspendLayout();
            this.panelSubjectTextbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxDepartmentName
            // 
            this.comboBoxDepartmentName.FormattingEnabled = true;
            this.comboBoxDepartmentName.Location = new System.Drawing.Point(203, 56);
            this.comboBoxDepartmentName.Name = "comboBoxDepartmentName";
            this.comboBoxDepartmentName.Size = new System.Drawing.Size(175, 25);
            this.comboBoxDepartmentName.TabIndex = 0;
            // 
            // labelDepartment
            // 
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.Location = new System.Drawing.Point(109, 59);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(88, 17);
            this.labelDepartment.TabIndex = 40;
            this.labelDepartment.Text = "Department  :";
            // 
            // panelSubmit
            // 
            this.panelSubmit.Controls.Add(this.buttonSubjectSubmit);
            this.panelSubmit.Location = new System.Drawing.Point(12, 183);
            this.panelSubmit.Name = "panelSubmit";
            this.panelSubmit.Size = new System.Drawing.Size(373, 46);
            this.panelSubmit.TabIndex = 39;
            // 
            // buttonSubjectSubmit
            // 
            this.buttonSubjectSubmit.Location = new System.Drawing.Point(191, 6);
            this.buttonSubjectSubmit.Name = "buttonSubjectSubmit";
            this.buttonSubjectSubmit.Size = new System.Drawing.Size(83, 31);
            this.buttonSubjectSubmit.TabIndex = 0;
            this.buttonSubjectSubmit.Text = "Submit";
            this.buttonSubjectSubmit.UseVisualStyleBackColor = true;
            this.buttonSubjectSubmit.Click += new System.EventHandler(this.buttonSubjectSubmit_Click);
            // 
            // panelSubjectContainer
            // 
            this.panelSubjectContainer.AutoSize = true;
            this.panelSubjectContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelSubjectContainer.Controls.Add(this.labelRole);
            this.panelSubjectContainer.Controls.Add(this.labelPassword);
            this.panelSubjectContainer.Controls.Add(this.panelSubjectTextbox);
            this.panelSubjectContainer.Controls.Add(this.labelUsername);
            this.panelSubjectContainer.Location = new System.Drawing.Point(12, 84);
            this.panelSubjectContainer.Name = "panelSubjectContainer";
            this.panelSubjectContainer.Size = new System.Drawing.Size(372, 99);
            this.panelSubjectContainer.TabIndex = 38;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(97, 9);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(41, 17);
            this.labelRole.TabIndex = 29;
            this.labelRole.Text = "Role :";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(97, 71);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(71, 17);
            this.labelPassword.TabIndex = 28;
            this.labelPassword.Text = "Password :";
            // 
            // panelSubjectTextbox
            // 
            this.panelSubjectTextbox.AutoSize = true;
            this.panelSubjectTextbox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelSubjectTextbox.Controls.Add(this.comboBoxRole);
            this.panelSubjectTextbox.Controls.Add(this.textBoxUserName);
            this.panelSubjectTextbox.Controls.Add(this.textBoxPassword);
            this.panelSubjectTextbox.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelSubjectTextbox.Location = new System.Drawing.Point(188, 3);
            this.panelSubjectTextbox.Name = "panelSubjectTextbox";
            this.panelSubjectTextbox.Size = new System.Drawing.Size(181, 93);
            this.panelSubjectTextbox.TabIndex = 27;
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Location = new System.Drawing.Point(3, 3);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(175, 25);
            this.comboBoxRole.TabIndex = 0;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(3, 34);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(175, 25);
            this.textBoxUserName.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(3, 65);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(175, 25);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(97, 40);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(74, 17);
            this.labelUsername.TabIndex = 18;
            this.labelUsername.Text = "Username :";
            // 
            // labelAddUser
            // 
            this.labelAddUser.AutoSize = true;
            this.labelAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddUser.Location = new System.Drawing.Point(12, 9);
            this.labelAddUser.Name = "labelAddUser";
            this.labelAddUser.Size = new System.Drawing.Size(127, 31);
            this.labelAddUser.TabIndex = 37;
            this.labelAddUser.Text = "Add User";
            // 
            // AddUserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(544, 286);
            this.Controls.Add(this.comboBoxDepartmentName);
            this.Controls.Add(this.labelDepartment);
            this.Controls.Add(this.panelSubmit);
            this.Controls.Add(this.panelSubjectContainer);
            this.Controls.Add(this.labelAddUser);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddUserAccount";
            this.Text = "AddUserAccount";
            this.Load += new System.EventHandler(this.AddUserAccount_Load);
            this.panelSubmit.ResumeLayout(false);
            this.panelSubjectContainer.ResumeLayout(false);
            this.panelSubjectContainer.PerformLayout();
            this.panelSubjectTextbox.ResumeLayout(false);
            this.panelSubjectTextbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDepartmentName;
        private System.Windows.Forms.Label labelDepartment;
        private System.Windows.Forms.Panel panelSubmit;
        private System.Windows.Forms.Button buttonSubjectSubmit;
        private System.Windows.Forms.Panel panelSubjectContainer;
        private System.Windows.Forms.Label labelPassword;
        public System.Windows.Forms.FlowLayoutPanel panelSubjectTextbox;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelAddUser;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelRole;
    }
}