namespace StudentAttendence.View.View
{
    partial class ViewTodayAttandance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewTodayAttandance));
            this.splitContainerViewTodayAttandance = new System.Windows.Forms.SplitContainer();
            this.dataGridViewTodayAttandance = new System.Windows.Forms.DataGridView();
            this.ColumnSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSemester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnParentContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelSubject = new System.Windows.Forms.Label();
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            this.labelSection = new System.Windows.Forms.Label();
            this.labelSemester = new System.Windows.Forms.Label();
            this.comboBoxSection = new System.Windows.Forms.ComboBox();
            this.comboBoxSemester = new System.Windows.Forms.ComboBox();
            this.buttonViewOnlyAbsent = new System.Windows.Forms.Button();
            this.panelTodayAttandence = new System.Windows.Forms.Panel();
            this.HomeButton = new System.Windows.Forms.Button();
            this.buttonPastDay = new System.Windows.Forms.Button();
            this.buttonHideShow = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelDate = new System.Windows.Forms.Label();
            this.dateTimePickerDateAttandence = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerViewTodayAttandance)).BeginInit();
            this.splitContainerViewTodayAttandance.Panel1.SuspendLayout();
            this.splitContainerViewTodayAttandance.Panel2.SuspendLayout();
            this.splitContainerViewTodayAttandance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTodayAttandance)).BeginInit();
            this.panelTodayAttandence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerViewTodayAttandance
            // 
            this.splitContainerViewTodayAttandance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerViewTodayAttandance.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerViewTodayAttandance.Location = new System.Drawing.Point(0, 0);
            this.splitContainerViewTodayAttandance.Name = "splitContainerViewTodayAttandance";
            // 
            // splitContainerViewTodayAttandance.Panel1
            // 
            this.splitContainerViewTodayAttandance.Panel1.Controls.Add(this.buttonPastDay);
            this.splitContainerViewTodayAttandance.Panel1.Controls.Add(this.HomeButton);
            // 
            // splitContainerViewTodayAttandance.Panel2
            // 
            this.splitContainerViewTodayAttandance.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainerViewTodayAttandance.Size = new System.Drawing.Size(1061, 377);
            this.splitContainerViewTodayAttandance.SplitterDistance = 146;
            this.splitContainerViewTodayAttandance.TabIndex = 0;
            // 
            // dataGridViewTodayAttandance
            // 
            this.dataGridViewTodayAttandance.AllowUserToAddRows = false;
            this.dataGridViewTodayAttandance.AllowUserToDeleteRows = false;
            this.dataGridViewTodayAttandance.AllowUserToResizeRows = false;
            this.dataGridViewTodayAttandance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewTodayAttandance.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dataGridViewTodayAttandance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTodayAttandance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSN,
            this.ColumnStudentID,
            this.ColumnStudentName,
            this.ColumnSemester,
            this.ColumnSection,
            this.ColumnSubject,
            this.ColumnContact,
            this.ColumnParentContact});
            this.dataGridViewTodayAttandance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTodayAttandance.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTodayAttandance.MultiSelect = false;
            this.dataGridViewTodayAttandance.Name = "dataGridViewTodayAttandance";
            this.dataGridViewTodayAttandance.ReadOnly = true;
            this.dataGridViewTodayAttandance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTodayAttandance.Size = new System.Drawing.Size(911, 241);
            this.dataGridViewTodayAttandance.TabIndex = 20;
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
            // ColumnContact
            // 
            this.ColumnContact.HeaderText = "Contact";
            this.ColumnContact.Name = "ColumnContact";
            this.ColumnContact.ReadOnly = true;
            this.ColumnContact.Width = 55;
            // 
            // ColumnParentContact
            // 
            this.ColumnParentContact.HeaderText = "Parent Contact";
            this.ColumnParentContact.Name = "ColumnParentContact";
            this.ColumnParentContact.ReadOnly = true;
            this.ColumnParentContact.Width = 80;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(593, 46);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(88, 26);
            this.buttonSearch.TabIndex = 19;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Location = new System.Drawing.Point(314, 51);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(57, 17);
            this.labelSubject.TabIndex = 18;
            this.labelSubject.Text = "Subject :";
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Location = new System.Drawing.Point(382, 48);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(156, 25);
            this.comboBoxSubject.TabIndex = 17;
            // 
            // labelSection
            // 
            this.labelSection.AutoSize = true;
            this.labelSection.Location = new System.Drawing.Point(314, 19);
            this.labelSection.Name = "labelSection";
            this.labelSection.Size = new System.Drawing.Size(57, 17);
            this.labelSection.TabIndex = 15;
            this.labelSection.Text = "Section :";
            // 
            // labelSemester
            // 
            this.labelSemester.AutoSize = true;
            this.labelSemester.Location = new System.Drawing.Point(33, 51);
            this.labelSemester.Name = "labelSemester";
            this.labelSemester.Size = new System.Drawing.Size(69, 17);
            this.labelSemester.TabIndex = 14;
            this.labelSemester.Text = "Semester :";
            // 
            // comboBoxSection
            // 
            this.comboBoxSection.FormattingEnabled = true;
            this.comboBoxSection.Location = new System.Drawing.Point(382, 16);
            this.comboBoxSection.Name = "comboBoxSection";
            this.comboBoxSection.Size = new System.Drawing.Size(156, 25);
            this.comboBoxSection.TabIndex = 13;
            // 
            // comboBoxSemester
            // 
            this.comboBoxSemester.FormattingEnabled = true;
            this.comboBoxSemester.Location = new System.Drawing.Point(113, 48);
            this.comboBoxSemester.Name = "comboBoxSemester";
            this.comboBoxSemester.Size = new System.Drawing.Size(156, 25);
            this.comboBoxSemester.TabIndex = 12;
            this.comboBoxSemester.SelectionChangeCommitted += new System.EventHandler(this.comboBoxSemester_SelectionChangeCommitted);
            // 
            // buttonViewOnlyAbsent
            // 
            this.buttonViewOnlyAbsent.Location = new System.Drawing.Point(711, 46);
            this.buttonViewOnlyAbsent.Name = "buttonViewOnlyAbsent";
            this.buttonViewOnlyAbsent.Size = new System.Drawing.Size(131, 26);
            this.buttonViewOnlyAbsent.TabIndex = 21;
            this.buttonViewOnlyAbsent.Text = "View All Absents";
            this.buttonViewOnlyAbsent.UseVisualStyleBackColor = true;
            this.buttonViewOnlyAbsent.Click += new System.EventHandler(this.buttonViewOnlyAbsent_Click);
            // 
            // panelTodayAttandence
            // 
            this.panelTodayAttandence.Controls.Add(this.labelDate);
            this.panelTodayAttandence.Controls.Add(this.dateTimePickerDateAttandence);
            this.panelTodayAttandence.Controls.Add(this.comboBoxSection);
            this.panelTodayAttandence.Controls.Add(this.buttonViewOnlyAbsent);
            this.panelTodayAttandence.Controls.Add(this.comboBoxSemester);
            this.panelTodayAttandence.Controls.Add(this.labelSemester);
            this.panelTodayAttandence.Controls.Add(this.buttonSearch);
            this.panelTodayAttandence.Controls.Add(this.labelSection);
            this.panelTodayAttandence.Controls.Add(this.labelSubject);
            this.panelTodayAttandence.Controls.Add(this.comboBoxSubject);
            this.panelTodayAttandence.Location = new System.Drawing.Point(39, 10);
            this.panelTodayAttandence.Name = "panelTodayAttandence";
            this.panelTodayAttandence.Size = new System.Drawing.Size(869, 115);
            this.panelTodayAttandence.TabIndex = 22;
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.ForeColor = System.Drawing.SystemColors.Menu;
            this.HomeButton.Image = ((System.Drawing.Image)(resources.GetObject("HomeButton.Image")));
            this.HomeButton.Location = new System.Drawing.Point(3, 71);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(140, 72);
            this.HomeButton.TabIndex = 9;
            this.HomeButton.Text = "Dashboard";
            this.HomeButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.HomeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.HomeButton.UseVisualStyleBackColor = false;
            // 
            // buttonPastDay
            // 
            this.buttonPastDay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonPastDay.FlatAppearance.BorderSize = 0;
            this.buttonPastDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPastDay.ForeColor = System.Drawing.SystemColors.Menu;
            this.buttonPastDay.Image = ((System.Drawing.Image)(resources.GetObject("buttonPastDay.Image")));
            this.buttonPastDay.Location = new System.Drawing.Point(3, 144);
            this.buttonPastDay.Name = "buttonPastDay";
            this.buttonPastDay.Size = new System.Drawing.Size(140, 72);
            this.buttonPastDay.TabIndex = 10;
            this.buttonPastDay.Text = "Dashboard";
            this.buttonPastDay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonPastDay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonPastDay.UseVisualStyleBackColor = false;
            // 
            // buttonHideShow
            // 
            this.buttonHideShow.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHideShow.Location = new System.Drawing.Point(0, 10);
            this.buttonHideShow.Name = "buttonHideShow";
            this.buttonHideShow.Size = new System.Drawing.Size(39, 37);
            this.buttonHideShow.TabIndex = 23;
            this.buttonHideShow.Text = "Hide";
            this.buttonHideShow.UseVisualStyleBackColor = true;
            this.buttonHideShow.Click += new System.EventHandler(this.buttonHideShow_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelTodayAttandence);
            this.splitContainer1.Panel1.Controls.Add(this.buttonHideShow);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewTodayAttandance);
            this.splitContainer1.Size = new System.Drawing.Size(911, 377);
            this.splitContainer1.SplitterDistance = 132;
            this.splitContainer1.TabIndex = 24;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(33, 19);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(42, 17);
            this.labelDate.TabIndex = 25;
            this.labelDate.Text = "Date :";
            // 
            // dateTimePickerDateAttandence
            // 
            this.dateTimePickerDateAttandence.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDateAttandence.Location = new System.Drawing.Point(113, 16);
            this.dateTimePickerDateAttandence.Name = "dateTimePickerDateAttandence";
            this.dateTimePickerDateAttandence.Size = new System.Drawing.Size(156, 25);
            this.dateTimePickerDateAttandence.TabIndex = 24;
            // 
            // ViewTodayAttandance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1061, 377);
            this.Controls.Add(this.splitContainerViewTodayAttandance);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ViewTodayAttandance";
            this.Text = "ViewTodayAttandance";
            this.Load += new System.EventHandler(this.ViewTodayAttandance_Load);
            this.splitContainerViewTodayAttandance.Panel1.ResumeLayout(false);
            this.splitContainerViewTodayAttandance.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerViewTodayAttandance)).EndInit();
            this.splitContainerViewTodayAttandance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTodayAttandance)).EndInit();
            this.panelTodayAttandence.ResumeLayout(false);
            this.panelTodayAttandence.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerViewTodayAttandance;
        private System.Windows.Forms.Label labelSection;
        private System.Windows.Forms.Label labelSemester;
        private System.Windows.Forms.ComboBox comboBoxSection;
        private System.Windows.Forms.ComboBox comboBoxSemester;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.ComboBox comboBoxSubject;
        private System.Windows.Forms.DataGridView dataGridViewTodayAttandance;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSemester;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSection;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnParentContact;
        private System.Windows.Forms.Button buttonViewOnlyAbsent;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Panel panelTodayAttandence;
        private System.Windows.Forms.Button buttonPastDay;
        private System.Windows.Forms.Button buttonHideShow;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateAttandence;
    }
}