namespace StudentAttendence
{
    partial class AddSubjectForm
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
            this.comboBoxSemesterName = new System.Windows.Forms.ComboBox();
            this.labelSemester = new System.Windows.Forms.Label();
            this.panelSubmit = new System.Windows.Forms.Panel();
            this.buttonSubjectSubmit = new System.Windows.Forms.Button();
            this.panelSubjectContainer = new System.Windows.Forms.Panel();
            this.labelTeacherName = new System.Windows.Forms.Label();
            this.panelSubjectTextbox = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxSubjectName = new System.Windows.Forms.TextBox();
            this.comboBoxTeacherName = new System.Windows.Forms.ComboBox();
            this.labelSubjectName = new System.Windows.Forms.Label();
            this.labelAddSubject = new System.Windows.Forms.Label();
            this.panelSubmit.SuspendLayout();
            this.panelSubjectContainer.SuspendLayout();
            this.panelSubjectTextbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxSemesterName
            // 
            this.comboBoxSemesterName.FormattingEnabled = true;
            this.comboBoxSemesterName.Location = new System.Drawing.Point(203, 56);
            this.comboBoxSemesterName.Name = "comboBoxSemesterName";
            this.comboBoxSemesterName.Size = new System.Drawing.Size(175, 25);
            this.comboBoxSemesterName.TabIndex = 36;
            // 
            // labelSemester
            // 
            this.labelSemester.AutoSize = true;
            this.labelSemester.Location = new System.Drawing.Point(99, 59);
            this.labelSemester.Name = "labelSemester";
            this.labelSemester.Size = new System.Drawing.Size(73, 17);
            this.labelSemester.TabIndex = 35;
            this.labelSemester.Text = "Semester  :";
            // 
            // panelSubmit
            // 
            this.panelSubmit.Controls.Add(this.buttonSubjectSubmit);
            this.panelSubmit.Location = new System.Drawing.Point(12, 152);
            this.panelSubmit.Name = "panelSubmit";
            this.panelSubmit.Size = new System.Drawing.Size(373, 46);
            this.panelSubmit.TabIndex = 34;
            // 
            // buttonSubjectSubmit
            // 
            this.buttonSubjectSubmit.Location = new System.Drawing.Point(191, 6);
            this.buttonSubjectSubmit.Name = "buttonSubjectSubmit";
            this.buttonSubjectSubmit.Size = new System.Drawing.Size(83, 31);
            this.buttonSubjectSubmit.TabIndex = 25;
            this.buttonSubjectSubmit.Text = "Submit";
            this.buttonSubjectSubmit.UseVisualStyleBackColor = true;
            this.buttonSubjectSubmit.Click += new System.EventHandler(this.buttonSubjectSubmit_Click);
            // 
            // panelSubjectContainer
            // 
            this.panelSubjectContainer.AutoSize = true;
            this.panelSubjectContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelSubjectContainer.Controls.Add(this.labelTeacherName);
            this.panelSubjectContainer.Controls.Add(this.panelSubjectTextbox);
            this.panelSubjectContainer.Controls.Add(this.labelSubjectName);
            this.panelSubjectContainer.Location = new System.Drawing.Point(12, 84);
            this.panelSubjectContainer.Name = "panelSubjectContainer";
            this.panelSubjectContainer.Size = new System.Drawing.Size(372, 68);
            this.panelSubjectContainer.TabIndex = 33;
            // 
            // labelTeacherName
            // 
            this.labelTeacherName.AutoSize = true;
            this.labelTeacherName.Location = new System.Drawing.Point(86, 40);
            this.labelTeacherName.Name = "labelTeacherName";
            this.labelTeacherName.Size = new System.Drawing.Size(100, 17);
            this.labelTeacherName.TabIndex = 28;
            this.labelTeacherName.Text = "Teacher Name :";
            // 
            // panelSubjectTextbox
            // 
            this.panelSubjectTextbox.AutoSize = true;
            this.panelSubjectTextbox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelSubjectTextbox.Controls.Add(this.textBoxSubjectName);
            this.panelSubjectTextbox.Controls.Add(this.comboBoxTeacherName);
            this.panelSubjectTextbox.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelSubjectTextbox.Location = new System.Drawing.Point(188, 3);
            this.panelSubjectTextbox.Name = "panelSubjectTextbox";
            this.panelSubjectTextbox.Size = new System.Drawing.Size(181, 62);
            this.panelSubjectTextbox.TabIndex = 27;
            // 
            // textBoxSubjectName
            // 
            this.textBoxSubjectName.Location = new System.Drawing.Point(3, 3);
            this.textBoxSubjectName.Name = "textBoxSubjectName";
            this.textBoxSubjectName.Size = new System.Drawing.Size(175, 25);
            this.textBoxSubjectName.TabIndex = 29;
            // 
            // comboBoxTeacherName
            // 
            this.comboBoxTeacherName.FormattingEnabled = true;
            this.comboBoxTeacherName.Location = new System.Drawing.Point(3, 34);
            this.comboBoxTeacherName.Name = "comboBoxTeacherName";
            this.comboBoxTeacherName.Size = new System.Drawing.Size(175, 25);
            this.comboBoxTeacherName.TabIndex = 37;
            // 
            // labelSubjectName
            // 
            this.labelSubjectName.AutoSize = true;
            this.labelSubjectName.Location = new System.Drawing.Point(87, 3);
            this.labelSubjectName.Name = "labelSubjectName";
            this.labelSubjectName.Size = new System.Drawing.Size(96, 17);
            this.labelSubjectName.TabIndex = 18;
            this.labelSubjectName.Text = "Subject Name :";
            // 
            // labelAddSubject
            // 
            this.labelAddSubject.AutoSize = true;
            this.labelAddSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddSubject.Location = new System.Drawing.Point(12, 9);
            this.labelAddSubject.Name = "labelAddSubject";
            this.labelAddSubject.Size = new System.Drawing.Size(160, 31);
            this.labelAddSubject.TabIndex = 32;
            this.labelAddSubject.Text = "Add Subject";
            // 
            // AddSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(523, 279);
            this.Controls.Add(this.comboBoxSemesterName);
            this.Controls.Add(this.labelSemester);
            this.Controls.Add(this.panelSubmit);
            this.Controls.Add(this.panelSubjectContainer);
            this.Controls.Add(this.labelAddSubject);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddSubjectForm";
            this.Text = "AddSubjectForm";
            this.Load += new System.EventHandler(this.AddSubjectForm_Load);
            this.panelSubmit.ResumeLayout(false);
            this.panelSubjectContainer.ResumeLayout(false);
            this.panelSubjectContainer.PerformLayout();
            this.panelSubjectTextbox.ResumeLayout(false);
            this.panelSubjectTextbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSemesterName;
        private System.Windows.Forms.Label labelSemester;
        private System.Windows.Forms.Panel panelSubmit;
        private System.Windows.Forms.Button buttonSubjectSubmit;
        private System.Windows.Forms.Panel panelSubjectContainer;
        public System.Windows.Forms.FlowLayoutPanel panelSubjectTextbox;
        private System.Windows.Forms.TextBox textBoxSubjectName;
        private System.Windows.Forms.Label labelSubjectName;
        private System.Windows.Forms.Label labelAddSubject;
        private System.Windows.Forms.Label labelTeacherName;
        private System.Windows.Forms.ComboBox comboBoxTeacherName;
    }
}