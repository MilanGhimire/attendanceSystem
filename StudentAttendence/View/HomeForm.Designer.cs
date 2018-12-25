namespace StudentAttendence
{
    partial class HomeForm
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
            this.buttonViewStudent = new System.Windows.Forms.Button();
            this.buttonViewAttandance = new System.Windows.Forms.Button();
            this.buttonViewTeacher = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeUsernamePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSubjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSemesterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSubjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUserAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonViewStudent
            // 
            this.buttonViewStudent.Location = new System.Drawing.Point(68, 80);
            this.buttonViewStudent.Name = "buttonViewStudent";
            this.buttonViewStudent.Size = new System.Drawing.Size(119, 30);
            this.buttonViewStudent.TabIndex = 0;
            this.buttonViewStudent.Text = "View Student";
            this.buttonViewStudent.UseVisualStyleBackColor = true;
            // 
            // buttonViewAttandance
            // 
            this.buttonViewAttandance.Location = new System.Drawing.Point(68, 159);
            this.buttonViewAttandance.Name = "buttonViewAttandance";
            this.buttonViewAttandance.Size = new System.Drawing.Size(119, 30);
            this.buttonViewAttandance.TabIndex = 2;
            this.buttonViewAttandance.Text = "View Attandence";
            this.buttonViewAttandance.UseVisualStyleBackColor = true;
            // 
            // buttonViewTeacher
            // 
            this.buttonViewTeacher.Location = new System.Drawing.Point(255, 80);
            this.buttonViewTeacher.Name = "buttonViewTeacher";
            this.buttonViewTeacher.Size = new System.Drawing.Size(119, 30);
            this.buttonViewTeacher.TabIndex = 3;
            this.buttonViewTeacher.Text = "View Teacher";
            this.buttonViewTeacher.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolStripMenuItem1,
            this.preferencesToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(613, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentToolStripMenuItem,
            this.addTeacherToolStripMenuItem,
            this.addSectionToolStripMenuItem,
            this.changeUsernamePasswordToolStripMenuItem,
            this.addDepartmentToolStripMenuItem,
            this.addSubjectToolStripMenuItem,
            this.addUserAccountToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.editToolStripMenuItem.Text = "Add";
            // 
            // addStudentToolStripMenuItem
            // 
            this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            this.addStudentToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.addStudentToolStripMenuItem.Text = "Add Student";
            this.addStudentToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
            // 
            // addTeacherToolStripMenuItem
            // 
            this.addTeacherToolStripMenuItem.Name = "addTeacherToolStripMenuItem";
            this.addTeacherToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.addTeacherToolStripMenuItem.Text = "Add Teacher";
            this.addTeacherToolStripMenuItem.Click += new System.EventHandler(this.addTeacherToolStripMenuItem_Click);
            // 
            // addSectionToolStripMenuItem
            // 
            this.addSectionToolStripMenuItem.Name = "addSectionToolStripMenuItem";
            this.addSectionToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.addSectionToolStripMenuItem.Text = "Add Section";
            this.addSectionToolStripMenuItem.Click += new System.EventHandler(this.addSectionToolStripMenuItem_Click);
            // 
            // changeUsernamePasswordToolStripMenuItem
            // 
            this.changeUsernamePasswordToolStripMenuItem.Name = "changeUsernamePasswordToolStripMenuItem";
            this.changeUsernamePasswordToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.changeUsernamePasswordToolStripMenuItem.Text = "Change Username/Password";
            // 
            // addDepartmentToolStripMenuItem
            // 
            this.addDepartmentToolStripMenuItem.Name = "addDepartmentToolStripMenuItem";
            this.addDepartmentToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.addDepartmentToolStripMenuItem.Text = "Add Department";
            this.addDepartmentToolStripMenuItem.Click += new System.EventHandler(this.addDepartmentToolStripMenuItem_Click);
            // 
            // addSubjectToolStripMenuItem
            // 
            this.addSubjectToolStripMenuItem.Name = "addSubjectToolStripMenuItem";
            this.addSubjectToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.addSubjectToolStripMenuItem.Text = "Add Subject";
            this.addSubjectToolStripMenuItem.Click += new System.EventHandler(this.addSubjectToolStripMenuItem_Click);
            // 
            // addUserAccountToolStripMenuItem
            // 
            this.addUserAccountToolStripMenuItem.Name = "addUserAccountToolStripMenuItem";
            this.addUserAccountToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.addUserAccountToolStripMenuItem.Text = "Add User Account";
            this.addUserAccountToolStripMenuItem.Click += new System.EventHandler(this.addUserAccountToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewStudentToolStripMenuItem,
            this.viewTeacherToolStripMenuItem,
            this.viewSemesterToolStripMenuItem,
            this.viewSubjectToolStripMenuItem,
            this.viewSectionToolStripMenuItem,
            this.viewDepartmentToolStripMenuItem,
            this.viewUserAccountToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItem1.Text = "View";
            // 
            // viewStudentToolStripMenuItem
            // 
            this.viewStudentToolStripMenuItem.Name = "viewStudentToolStripMenuItem";
            this.viewStudentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewStudentToolStripMenuItem.Text = "View Student";
            this.viewStudentToolStripMenuItem.Click += new System.EventHandler(this.viewStudentToolStripMenuItem_Click);
            // 
            // viewTeacherToolStripMenuItem
            // 
            this.viewTeacherToolStripMenuItem.Name = "viewTeacherToolStripMenuItem";
            this.viewTeacherToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewTeacherToolStripMenuItem.Text = "View Teacher";
            this.viewTeacherToolStripMenuItem.Click += new System.EventHandler(this.viewTeacherToolStripMenuItem_Click);
            // 
            // viewSemesterToolStripMenuItem
            // 
            this.viewSemesterToolStripMenuItem.Name = "viewSemesterToolStripMenuItem";
            this.viewSemesterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewSemesterToolStripMenuItem.Text = "View Semester";
            this.viewSemesterToolStripMenuItem.Click += new System.EventHandler(this.viewSemesterToolStripMenuItem_Click);
            // 
            // viewSubjectToolStripMenuItem
            // 
            this.viewSubjectToolStripMenuItem.Name = "viewSubjectToolStripMenuItem";
            this.viewSubjectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewSubjectToolStripMenuItem.Text = "View Subject";
            this.viewSubjectToolStripMenuItem.Click += new System.EventHandler(this.viewSubjectToolStripMenuItem_Click);
            // 
            // viewSectionToolStripMenuItem
            // 
            this.viewSectionToolStripMenuItem.Name = "viewSectionToolStripMenuItem";
            this.viewSectionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewSectionToolStripMenuItem.Text = "View Section";
            this.viewSectionToolStripMenuItem.Click += new System.EventHandler(this.viewSectionToolStripMenuItem_Click);
            // 
            // viewDepartmentToolStripMenuItem
            // 
            this.viewDepartmentToolStripMenuItem.Name = "viewDepartmentToolStripMenuItem";
            this.viewDepartmentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewDepartmentToolStripMenuItem.Text = "View Department";
            this.viewDepartmentToolStripMenuItem.Click += new System.EventHandler(this.viewDepartmentToolStripMenuItem_Click);
            // 
            // viewUserAccountToolStripMenuItem
            // 
            this.viewUserAccountToolStripMenuItem.Name = "viewUserAccountToolStripMenuItem";
            this.viewUserAccountToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewUserAccountToolStripMenuItem.Text = "View User Account";
            this.viewUserAccountToolStripMenuItem.Click += new System.EventHandler(this.viewUserAccountToolStripMenuItem_Click);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(613, 461);
            this.Controls.Add(this.buttonViewTeacher);
            this.Controls.Add(this.buttonViewAttandance);
            this.Controls.Add(this.buttonViewStudent);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HomeForm";
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomeForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonViewStudent;
        private System.Windows.Forms.Button buttonViewAttandance;
        private System.Windows.Forms.Button buttonViewTeacher;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTeacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeUsernamePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDepartmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSubjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewTeacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSemesterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSubjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDepartmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUserAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserAccountToolStripMenuItem;
    }
}