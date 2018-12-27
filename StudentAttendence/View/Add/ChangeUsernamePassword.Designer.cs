namespace StudentAttendence.View.Add
{
    partial class ChangeUsernamePassword
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
            this.ReEnterPassword = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ChangeUPCancelButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ReNewPasswordLabel = new System.Windows.Forms.Label();
            this.OldPasswordTextbox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.NewPasswordLabel = new System.Windows.Forms.Label();
            this.ChangeUsernameCheckBox = new System.Windows.Forms.CheckBox();
            this.UsernameTB = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReEnterPassword
            // 
            this.ReEnterPassword.Location = new System.Drawing.Point(133, 171);
            this.ReEnterPassword.Name = "ReEnterPassword";
            this.ReEnterPassword.PasswordChar = '*';
            this.ReEnterPassword.Size = new System.Drawing.Size(161, 25);
            this.ReEnterPassword.TabIndex = 21;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(12, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(369, 31);
            this.TitleLabel.TabIndex = 27;
            this.TitleLabel.Text = "Change Username/Password";
            // 
            // ChangeUPCancelButton
            // 
            this.ChangeUPCancelButton.Location = new System.Drawing.Point(219, 210);
            this.ChangeUPCancelButton.Name = "ChangeUPCancelButton";
            this.ChangeUPCancelButton.Size = new System.Drawing.Size(75, 25);
            this.ChangeUPCancelButton.TabIndex = 23;
            this.ChangeUPCancelButton.Text = "&Cancel";
            this.ChangeUPCancelButton.UseVisualStyleBackColor = true;
            this.ChangeUPCancelButton.Click += new System.EventHandler(this.ChangeUPCancelButton_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(133, 210);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 25);
            this.SubmitButton.TabIndex = 22;
            this.SubmitButton.Text = "&Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ReNewPasswordLabel
            // 
            this.ReNewPasswordLabel.AutoSize = true;
            this.ReNewPasswordLabel.Location = new System.Drawing.Point(15, 174);
            this.ReNewPasswordLabel.Name = "ReNewPasswordLabel";
            this.ReNewPasswordLabel.Size = new System.Drawing.Size(121, 17);
            this.ReNewPasswordLabel.TabIndex = 26;
            this.ReNewPasswordLabel.Text = "Re-New Password :";
            // 
            // OldPasswordTextbox
            // 
            this.OldPasswordTextbox.Location = new System.Drawing.Point(133, 109);
            this.OldPasswordTextbox.Name = "OldPasswordTextbox";
            this.OldPasswordTextbox.PasswordChar = '*';
            this.OldPasswordTextbox.Size = new System.Drawing.Size(161, 25);
            this.OldPasswordTextbox.TabIndex = 19;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(15, 112);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(96, 17);
            this.PasswordLabel.TabIndex = 24;
            this.PasswordLabel.Text = "Old Password :";
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(133, 140);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.PasswordChar = '*';
            this.PasswordTB.Size = new System.Drawing.Size(161, 25);
            this.PasswordTB.TabIndex = 20;
            // 
            // NewPasswordLabel
            // 
            this.NewPasswordLabel.AutoSize = true;
            this.NewPasswordLabel.Location = new System.Drawing.Point(15, 143);
            this.NewPasswordLabel.Name = "NewPasswordLabel";
            this.NewPasswordLabel.Size = new System.Drawing.Size(101, 17);
            this.NewPasswordLabel.TabIndex = 25;
            this.NewPasswordLabel.Text = "New Password :";
            // 
            // ChangeUsernameCheckBox
            // 
            this.ChangeUsernameCheckBox.AutoSize = true;
            this.ChangeUsernameCheckBox.Location = new System.Drawing.Point(302, 81);
            this.ChangeUsernameCheckBox.Name = "ChangeUsernameCheckBox";
            this.ChangeUsernameCheckBox.Size = new System.Drawing.Size(134, 21);
            this.ChangeUsernameCheckBox.TabIndex = 18;
            this.ChangeUsernameCheckBox.Text = "Change Username";
            this.ChangeUsernameCheckBox.UseVisualStyleBackColor = true;
            this.ChangeUsernameCheckBox.CheckedChanged += new System.EventHandler(this.ChangeUsernameCheckBox_CheckedChanged);
            // 
            // UsernameTB
            // 
            this.UsernameTB.Location = new System.Drawing.Point(133, 78);
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.ReadOnly = true;
            this.UsernameTB.Size = new System.Drawing.Size(161, 25);
            this.UsernameTB.TabIndex = 16;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(15, 81);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(74, 17);
            this.UsernameLabel.TabIndex = 17;
            this.UsernameLabel.Text = "Username :";
            // 
            // ChangeUsernamePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(457, 269);
            this.Controls.Add(this.ReEnterPassword);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.ChangeUPCancelButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.ReNewPasswordLabel);
            this.Controls.Add(this.OldPasswordTextbox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.NewPasswordLabel);
            this.Controls.Add(this.ChangeUsernameCheckBox);
            this.Controls.Add(this.UsernameTB);
            this.Controls.Add(this.UsernameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ChangeUsernamePassword";
            this.Text = "ChangeUsernamePassword";
            this.Load += new System.EventHandler(this.ChangeUsernamePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ReEnterPassword;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button ChangeUPCancelButton;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label ReNewPasswordLabel;
        private System.Windows.Forms.TextBox OldPasswordTextbox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Label NewPasswordLabel;
        private System.Windows.Forms.CheckBox ChangeUsernameCheckBox;
        private System.Windows.Forms.TextBox UsernameTB;
        private System.Windows.Forms.Label UsernameLabel;
    }
}