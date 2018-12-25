namespace StudentAttendence
{
    partial class ViewStudentForm
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
            this.panelDataGridView = new System.Windows.Forms.Panel();
            this.dataGridViewStudent = new System.Windows.Forms.DataGridView();
            this.ColumnSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSemester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIDCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStudentContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnParentContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripStudent = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelViewStudentTitle = new System.Windows.Forms.Label();
            this.panelDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).BeginInit();
            this.contextMenuStripStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDataGridView
            // 
            this.panelDataGridView.Controls.Add(this.dataGridViewStudent);
            this.panelDataGridView.Location = new System.Drawing.Point(12, 115);
            this.panelDataGridView.Name = "panelDataGridView";
            this.panelDataGridView.Size = new System.Drawing.Size(975, 181);
            this.panelDataGridView.TabIndex = 16;
            // 
            // dataGridViewStudent
            // 
            this.dataGridViewStudent.AllowUserToAddRows = false;
            this.dataGridViewStudent.AllowUserToDeleteRows = false;
            this.dataGridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSN,
            this.ColumnDepartment,
            this.ColumnSemester,
            this.ColumnSection,
            this.ColumnName,
            this.ColumnIDCard,
            this.ColumnStudentContact,
            this.ColumnParentContact,
            this.ColumnAddress,
            this.ColumnEmail,
            this.ColumnStudentID});
            this.dataGridViewStudent.ContextMenuStrip = this.contextMenuStripStudent;
            this.dataGridViewStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStudent.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewStudent.MultiSelect = false;
            this.dataGridViewStudent.Name = "dataGridViewStudent";
            this.dataGridViewStudent.ReadOnly = true;
            this.dataGridViewStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStudent.Size = new System.Drawing.Size(975, 181);
            this.dataGridViewStudent.TabIndex = 1;
            this.dataGridViewStudent.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewStudent_CellMouseDown);
            // 
            // ColumnSN
            // 
            this.ColumnSN.HeaderText = "S.N.";
            this.ColumnSN.Name = "ColumnSN";
            this.ColumnSN.ReadOnly = true;
            this.ColumnSN.Width = 40;
            // 
            // ColumnDepartment
            // 
            this.ColumnDepartment.HeaderText = "Department";
            this.ColumnDepartment.Name = "ColumnDepartment";
            this.ColumnDepartment.ReadOnly = true;
            this.ColumnDepartment.Width = 80;
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
            this.ColumnSection.Width = 60;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            this.ColumnName.Width = 195;
            // 
            // ColumnIDCard
            // 
            this.ColumnIDCard.HeaderText = "ID Card No.";
            this.ColumnIDCard.Name = "ColumnIDCard";
            this.ColumnIDCard.ReadOnly = true;
            this.ColumnIDCard.Width = 70;
            // 
            // ColumnStudentContact
            // 
            this.ColumnStudentContact.HeaderText = "Student Contact";
            this.ColumnStudentContact.Name = "ColumnStudentContact";
            this.ColumnStudentContact.ReadOnly = true;
            // 
            // ColumnParentContact
            // 
            this.ColumnParentContact.HeaderText = "Parent Contact";
            this.ColumnParentContact.Name = "ColumnParentContact";
            this.ColumnParentContact.ReadOnly = true;
            // 
            // ColumnAddress
            // 
            this.ColumnAddress.HeaderText = "Address";
            this.ColumnAddress.Name = "ColumnAddress";
            this.ColumnAddress.ReadOnly = true;
            // 
            // ColumnEmail
            // 
            this.ColumnEmail.HeaderText = "Email";
            this.ColumnEmail.Name = "ColumnEmail";
            this.ColumnEmail.ReadOnly = true;
            // 
            // ColumnStudentID
            // 
            this.ColumnStudentID.HeaderText = "Student ID";
            this.ColumnStudentID.Name = "ColumnStudentID";
            this.ColumnStudentID.ReadOnly = true;
            this.ColumnStudentID.Visible = false;
            // 
            // contextMenuStripStudent
            // 
            this.contextMenuStripStudent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.contextMenuStripStudent.Name = "contextMenuStripDepartment";
            this.contextMenuStripStudent.Size = new System.Drawing.Size(181, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // labelViewStudentTitle
            // 
            this.labelViewStudentTitle.AutoSize = true;
            this.labelViewStudentTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelViewStudentTitle.Location = new System.Drawing.Point(12, 9);
            this.labelViewStudentTitle.Name = "labelViewStudentTitle";
            this.labelViewStudentTitle.Size = new System.Drawing.Size(174, 31);
            this.labelViewStudentTitle.TabIndex = 17;
            this.labelViewStudentTitle.Text = "View Student";
            // 
            // ViewStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1019, 456);
            this.Controls.Add(this.panelDataGridView);
            this.Controls.Add(this.labelViewStudentTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ViewStudentForm";
            this.Text = "ViewStudentForm";
            this.Load += new System.EventHandler(this.ViewStudentForm_Load);
            this.panelDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).EndInit();
            this.contextMenuStripStudent.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDataGridView;
        private System.Windows.Forms.Label labelViewStudentTitle;
        private System.Windows.Forms.DataGridView dataGridViewStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSemester;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSection;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIDCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStudentContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnParentContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStudentID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripStudent;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    }
}