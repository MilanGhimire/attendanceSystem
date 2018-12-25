namespace StudentAttendence
{
    partial class AddTeacherForm
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
            this.panelSubmit = new System.Windows.Forms.Panel();
            this.buttonTeacherSubmit = new System.Windows.Forms.Button();
            this.panelTeacherContainer = new System.Windows.Forms.Panel();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelContact = new System.Windows.Forms.Label();
            this.panelTeacherTextbox = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxTeacherName = new System.Windows.Forms.TextBox();
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelTeacherName = new System.Windows.Forms.Label();
            this.labelAddTeacher = new System.Windows.Forms.Label();
            this.panelSubmit.SuspendLayout();
            this.panelTeacherContainer.SuspendLayout();
            this.panelTeacherTextbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSubmit
            // 
            this.panelSubmit.Controls.Add(this.buttonTeacherSubmit);
            this.panelSubmit.Location = new System.Drawing.Point(12, 180);
            this.panelSubmit.Name = "panelSubmit";
            this.panelSubmit.Size = new System.Drawing.Size(373, 46);
            this.panelSubmit.TabIndex = 34;
            // 
            // buttonTeacherSubmit
            // 
            this.buttonTeacherSubmit.Location = new System.Drawing.Point(191, 6);
            this.buttonTeacherSubmit.Name = "buttonTeacherSubmit";
            this.buttonTeacherSubmit.Size = new System.Drawing.Size(83, 31);
            this.buttonTeacherSubmit.TabIndex = 25;
            this.buttonTeacherSubmit.Text = "Submit";
            this.buttonTeacherSubmit.UseVisualStyleBackColor = true;
            this.buttonTeacherSubmit.Click += new System.EventHandler(this.buttonTeacherSubmit_Click);
            // 
            // panelTeacherContainer
            // 
            this.panelTeacherContainer.AutoSize = true;
            this.panelTeacherContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelTeacherContainer.Controls.Add(this.labelEmail);
            this.panelTeacherContainer.Controls.Add(this.labelAddress);
            this.panelTeacherContainer.Controls.Add(this.labelContact);
            this.panelTeacherContainer.Controls.Add(this.panelTeacherTextbox);
            this.panelTeacherContainer.Controls.Add(this.labelTeacherName);
            this.panelTeacherContainer.Location = new System.Drawing.Point(12, 50);
            this.panelTeacherContainer.Name = "panelTeacherContainer";
            this.panelTeacherContainer.Size = new System.Drawing.Size(372, 130);
            this.panelTeacherContainer.TabIndex = 33;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(87, 102);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(46, 17);
            this.labelEmail.TabIndex = 30;
            this.labelEmail.Text = "Email :";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(85, 71);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(63, 17);
            this.labelAddress.TabIndex = 29;
            this.labelAddress.Text = "Address :";
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.Location = new System.Drawing.Point(85, 40);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(59, 17);
            this.labelContact.TabIndex = 28;
            this.labelContact.Text = "Contact :";
            // 
            // panelTeacherTextbox
            // 
            this.panelTeacherTextbox.AutoSize = true;
            this.panelTeacherTextbox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelTeacherTextbox.Controls.Add(this.textBoxTeacherName);
            this.panelTeacherTextbox.Controls.Add(this.textBoxContact);
            this.panelTeacherTextbox.Controls.Add(this.textBoxAddress);
            this.panelTeacherTextbox.Controls.Add(this.textBoxEmail);
            this.panelTeacherTextbox.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelTeacherTextbox.Location = new System.Drawing.Point(188, 3);
            this.panelTeacherTextbox.Name = "panelTeacherTextbox";
            this.panelTeacherTextbox.Size = new System.Drawing.Size(181, 124);
            this.panelTeacherTextbox.TabIndex = 27;
            // 
            // textBoxTeacherName
            // 
            this.textBoxTeacherName.Location = new System.Drawing.Point(3, 3);
            this.textBoxTeacherName.Name = "textBoxTeacherName";
            this.textBoxTeacherName.Size = new System.Drawing.Size(175, 25);
            this.textBoxTeacherName.TabIndex = 29;
            // 
            // textBoxContact
            // 
            this.textBoxContact.Location = new System.Drawing.Point(3, 34);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new System.Drawing.Size(175, 25);
            this.textBoxContact.TabIndex = 30;
            this.textBoxContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxContact_KeyPress);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(3, 65);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(175, 25);
            this.textBoxAddress.TabIndex = 31;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(3, 96);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(175, 25);
            this.textBoxEmail.TabIndex = 32;
            // 
            // labelTeacherName
            // 
            this.labelTeacherName.AutoSize = true;
            this.labelTeacherName.Location = new System.Drawing.Point(87, 9);
            this.labelTeacherName.Name = "labelTeacherName";
            this.labelTeacherName.Size = new System.Drawing.Size(100, 17);
            this.labelTeacherName.TabIndex = 18;
            this.labelTeacherName.Text = "Teacher Name :";
            // 
            // labelAddTeacher
            // 
            this.labelAddTeacher.AutoSize = true;
            this.labelAddTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddTeacher.Location = new System.Drawing.Point(12, 9);
            this.labelAddTeacher.Name = "labelAddTeacher";
            this.labelAddTeacher.Size = new System.Drawing.Size(169, 31);
            this.labelAddTeacher.TabIndex = 32;
            this.labelAddTeacher.Text = "Add Teacher";
            // 
            // AddTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(546, 287);
            this.Controls.Add(this.panelSubmit);
            this.Controls.Add(this.panelTeacherContainer);
            this.Controls.Add(this.labelAddTeacher);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddTeacherForm";
            this.Text = "AddTeacherForm";
            this.Load += new System.EventHandler(this.AddTeacherForm_Load);
            this.panelSubmit.ResumeLayout(false);
            this.panelTeacherContainer.ResumeLayout(false);
            this.panelTeacherContainer.PerformLayout();
            this.panelTeacherTextbox.ResumeLayout(false);
            this.panelTeacherTextbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelSubmit;
        private System.Windows.Forms.Button buttonTeacherSubmit;
        private System.Windows.Forms.Panel panelTeacherContainer;
        public System.Windows.Forms.FlowLayoutPanel panelTeacherTextbox;
        private System.Windows.Forms.TextBox textBoxTeacherName;
        private System.Windows.Forms.Label labelTeacherName;
        private System.Windows.Forms.Label labelAddTeacher;
        private System.Windows.Forms.TextBox textBoxContact;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelContact;
    }
}