namespace StudentAttendence
{
    partial class AttandenceForm
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
            this.splitContainerAttandence = new System.Windows.Forms.SplitContainer();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelSubject = new System.Windows.Forms.Label();
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            this.labelAttandenceTitle = new System.Windows.Forms.Label();
            this.labelStudentName = new System.Windows.Forms.Label();
            this.labelSection = new System.Windows.Forms.Label();
            this.labelSemester = new System.Windows.Forms.Label();
            this.textBoxStudentName = new System.Windows.Forms.TextBox();
            this.comboBoxSection = new System.Windows.Forms.ComboBox();
            this.comboBoxSemester = new System.Windows.Forms.ComboBox();
            this.dataGridViewStudent = new System.Windows.Forms.DataGridView();
            this.ColumnSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSemester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPresentDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAbsentDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAttandence)).BeginInit();
            this.splitContainerAttandence.Panel1.SuspendLayout();
            this.splitContainerAttandence.Panel2.SuspendLayout();
            this.splitContainerAttandence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerAttandence
            // 
            this.splitContainerAttandence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAttandence.Location = new System.Drawing.Point(0, 0);
            this.splitContainerAttandence.Name = "splitContainerAttandence";
            this.splitContainerAttandence.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerAttandence.Panel1
            // 
            this.splitContainerAttandence.Panel1.Controls.Add(this.buttonSearch);
            this.splitContainerAttandence.Panel1.Controls.Add(this.labelSubject);
            this.splitContainerAttandence.Panel1.Controls.Add(this.comboBoxSubject);
            this.splitContainerAttandence.Panel1.Controls.Add(this.labelAttandenceTitle);
            this.splitContainerAttandence.Panel1.Controls.Add(this.labelStudentName);
            this.splitContainerAttandence.Panel1.Controls.Add(this.labelSection);
            this.splitContainerAttandence.Panel1.Controls.Add(this.labelSemester);
            this.splitContainerAttandence.Panel1.Controls.Add(this.textBoxStudentName);
            this.splitContainerAttandence.Panel1.Controls.Add(this.comboBoxSection);
            this.splitContainerAttandence.Panel1.Controls.Add(this.comboBoxSemester);
            // 
            // splitContainerAttandence.Panel2
            // 
            this.splitContainerAttandence.Panel2.Controls.Add(this.dataGridViewStudent);
            this.splitContainerAttandence.Size = new System.Drawing.Size(810, 398);
            this.splitContainerAttandence.SplitterDistance = 126;
            this.splitContainerAttandence.TabIndex = 7;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(567, 93);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(88, 26);
            this.buttonSearch.TabIndex = 16;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Location = new System.Drawing.Point(317, 96);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(57, 17);
            this.labelSubject.TabIndex = 15;
            this.labelSubject.Text = "Subject :";
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Location = new System.Drawing.Point(385, 93);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(156, 25);
            this.comboBoxSubject.TabIndex = 14;
            // 
            // labelAttandenceTitle
            // 
            this.labelAttandenceTitle.AutoSize = true;
            this.labelAttandenceTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAttandenceTitle.Location = new System.Drawing.Point(12, 9);
            this.labelAttandenceTitle.Name = "labelAttandenceTitle";
            this.labelAttandenceTitle.Size = new System.Drawing.Size(273, 37);
            this.labelAttandenceTitle.TabIndex = 13;
            this.labelAttandenceTitle.Text = "Student Attandence";
            // 
            // labelStudentName
            // 
            this.labelStudentName.AutoSize = true;
            this.labelStudentName.Location = new System.Drawing.Point(12, 96);
            this.labelStudentName.Name = "labelStudentName";
            this.labelStudentName.Size = new System.Drawing.Size(98, 17);
            this.labelStudentName.TabIndex = 12;
            this.labelStudentName.Text = "Student Name :";
            // 
            // labelSection
            // 
            this.labelSection.AutoSize = true;
            this.labelSection.Location = new System.Drawing.Point(317, 58);
            this.labelSection.Name = "labelSection";
            this.labelSection.Size = new System.Drawing.Size(57, 17);
            this.labelSection.TabIndex = 11;
            this.labelSection.Text = "Section :";
            // 
            // labelSemester
            // 
            this.labelSemester.AutoSize = true;
            this.labelSemester.Location = new System.Drawing.Point(12, 58);
            this.labelSemester.Name = "labelSemester";
            this.labelSemester.Size = new System.Drawing.Size(69, 17);
            this.labelSemester.TabIndex = 10;
            this.labelSemester.Text = "Semester :";
            // 
            // textBoxStudentName
            // 
            this.textBoxStudentName.Location = new System.Drawing.Point(116, 93);
            this.textBoxStudentName.Name = "textBoxStudentName";
            this.textBoxStudentName.Size = new System.Drawing.Size(156, 25);
            this.textBoxStudentName.TabIndex = 9;
            // 
            // comboBoxSection
            // 
            this.comboBoxSection.FormattingEnabled = true;
            this.comboBoxSection.Location = new System.Drawing.Point(385, 55);
            this.comboBoxSection.Name = "comboBoxSection";
            this.comboBoxSection.Size = new System.Drawing.Size(156, 25);
            this.comboBoxSection.TabIndex = 8;
            // 
            // comboBoxSemester
            // 
            this.comboBoxSemester.FormattingEnabled = true;
            this.comboBoxSemester.Location = new System.Drawing.Point(116, 55);
            this.comboBoxSemester.Name = "comboBoxSemester";
            this.comboBoxSemester.Size = new System.Drawing.Size(156, 25);
            this.comboBoxSemester.TabIndex = 7;
            this.comboBoxSemester.SelectionChangeCommitted += new System.EventHandler(this.comboBoxSemester_SelectionChangeCommitted);
            // 
            // dataGridViewStudent
            // 
            this.dataGridViewStudent.AllowUserToAddRows = false;
            this.dataGridViewStudent.AllowUserToDeleteRows = false;
            this.dataGridViewStudent.AllowUserToResizeRows = false;
            this.dataGridViewStudent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewStudent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dataGridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSN,
            this.ColumnStudentID,
            this.ColumnStudentName,
            this.ColumnSemester,
            this.ColumnSection,
            this.ColumnSubject,
            this.ColumnPresentDays,
            this.ColumnAbsentDays});
            this.dataGridViewStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStudent.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewStudent.MultiSelect = false;
            this.dataGridViewStudent.Name = "dataGridViewStudent";
            this.dataGridViewStudent.ReadOnly = true;
            this.dataGridViewStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStudent.Size = new System.Drawing.Size(810, 268);
            this.dataGridViewStudent.TabIndex = 0;
            // 
            // ColumnSN
            // 
            this.ColumnSN.HeaderText = "S.N.";
            this.ColumnSN.Name = "ColumnSN";
            this.ColumnSN.ReadOnly = true;
            this.ColumnSN.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnSN.Width = 40;
            // 
            // ColumnStudentID
            // 
            this.ColumnStudentID.HeaderText = "Student ID";
            this.ColumnStudentID.Name = "ColumnStudentID";
            this.ColumnStudentID.ReadOnly = true;
            this.ColumnStudentID.Width = 90;
            // 
            // ColumnStudentName
            // 
            this.ColumnStudentName.HeaderText = "Name";
            this.ColumnStudentName.Name = "ColumnStudentName";
            this.ColumnStudentName.ReadOnly = true;
            this.ColumnStudentName.Width = 230;
            // 
            // ColumnSemester
            // 
            this.ColumnSemester.HeaderText = "Semester";
            this.ColumnSemester.Name = "ColumnSemester";
            this.ColumnSemester.ReadOnly = true;
            this.ColumnSemester.Width = 70;
            // 
            // ColumnSection
            // 
            this.ColumnSection.HeaderText = "Section";
            this.ColumnSection.Name = "ColumnSection";
            this.ColumnSection.ReadOnly = true;
            // 
            // ColumnSubject
            // 
            this.ColumnSubject.HeaderText = "Subject";
            this.ColumnSubject.Name = "ColumnSubject";
            this.ColumnSubject.ReadOnly = true;
            this.ColumnSubject.Width = 130;
            // 
            // ColumnPresentDays
            // 
            this.ColumnPresentDays.HeaderText = "Present Days";
            this.ColumnPresentDays.Name = "ColumnPresentDays";
            this.ColumnPresentDays.ReadOnly = true;
            this.ColumnPresentDays.Width = 55;
            // 
            // ColumnAbsentDays
            // 
            this.ColumnAbsentDays.HeaderText = "Absent Days";
            this.ColumnAbsentDays.Name = "ColumnAbsentDays";
            this.ColumnAbsentDays.ReadOnly = true;
            this.ColumnAbsentDays.Width = 50;
            // 
            // AttandenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(810, 398);
            this.Controls.Add(this.splitContainerAttandence);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AttandenceForm";
            this.Text = "Attandence";
            this.Load += new System.EventHandler(this.AttandenceForm_Load);
            this.splitContainerAttandence.Panel1.ResumeLayout(false);
            this.splitContainerAttandence.Panel1.PerformLayout();
            this.splitContainerAttandence.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAttandence)).EndInit();
            this.splitContainerAttandence.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainerAttandence;
        private System.Windows.Forms.Label labelAttandenceTitle;
        private System.Windows.Forms.Label labelStudentName;
        private System.Windows.Forms.Label labelSection;
        private System.Windows.Forms.Label labelSemester;
        private System.Windows.Forms.TextBox textBoxStudentName;
        private System.Windows.Forms.ComboBox comboBoxSection;
        private System.Windows.Forms.ComboBox comboBoxSemester;
        private System.Windows.Forms.DataGridView dataGridViewStudent;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.ComboBox comboBoxSubject;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSemester;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSection;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPresentDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAbsentDays;
    }
}