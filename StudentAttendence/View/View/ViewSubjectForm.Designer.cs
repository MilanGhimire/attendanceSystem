namespace StudentAttendence.View.View
{
    partial class ViewSubjectForm
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
            this.dataGridViewSubject = new System.Windows.Forms.DataGridView();
            this.ColumnSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSemester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTeacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSubjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripSubject = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelViewSubjectTitle = new System.Windows.Forms.Label();
            this.panelDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubject)).BeginInit();
            this.contextMenuStripSubject.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDataGridView
            // 
            this.panelDataGridView.Controls.Add(this.dataGridViewSubject);
            this.panelDataGridView.Location = new System.Drawing.Point(12, 115);
            this.panelDataGridView.Name = "panelDataGridView";
            this.panelDataGridView.Size = new System.Drawing.Size(566, 181);
            this.panelDataGridView.TabIndex = 16;
            // 
            // dataGridViewSubject
            // 
            this.dataGridViewSubject.AllowUserToAddRows = false;
            this.dataGridViewSubject.AllowUserToDeleteRows = false;
            this.dataGridViewSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSN,
            this.ColumnDepartment,
            this.ColumnSemester,
            this.ColumnTeacherName,
            this.ColumnSubjectName,
            this.ColumnSubjectID});
            this.dataGridViewSubject.ContextMenuStrip = this.contextMenuStripSubject;
            this.dataGridViewSubject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSubject.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSubject.MultiSelect = false;
            this.dataGridViewSubject.Name = "dataGridViewSubject";
            this.dataGridViewSubject.ReadOnly = true;
            this.dataGridViewSubject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSubject.Size = new System.Drawing.Size(566, 181);
            this.dataGridViewSubject.TabIndex = 0;
            this.dataGridViewSubject.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewSubject_CellMouseDown);
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
            // 
            // ColumnSemester
            // 
            this.ColumnSemester.HeaderText = "Semester";
            this.ColumnSemester.Name = "ColumnSemester";
            this.ColumnSemester.ReadOnly = true;
            this.ColumnSemester.Width = 130;
            // 
            // ColumnTeacherName
            // 
            this.ColumnTeacherName.HeaderText = "Teacher Name";
            this.ColumnTeacherName.Name = "ColumnTeacherName";
            this.ColumnTeacherName.ReadOnly = true;
            // 
            // ColumnSubjectName
            // 
            this.ColumnSubjectName.HeaderText = "Subject Name";
            this.ColumnSubjectName.Name = "ColumnSubjectName";
            this.ColumnSubjectName.ReadOnly = true;
            this.ColumnSubjectName.Width = 150;
            // 
            // ColumnSubjectID
            // 
            this.ColumnSubjectID.HeaderText = "Subject ID";
            this.ColumnSubjectID.Name = "ColumnSubjectID";
            this.ColumnSubjectID.ReadOnly = true;
            this.ColumnSubjectID.Visible = false;
            // 
            // contextMenuStripSubject
            // 
            this.contextMenuStripSubject.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.contextMenuStripSubject.Name = "contextMenuStripDepartment";
            this.contextMenuStripSubject.Size = new System.Drawing.Size(181, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // labelViewSubjectTitle
            // 
            this.labelViewSubjectTitle.AutoSize = true;
            this.labelViewSubjectTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelViewSubjectTitle.Location = new System.Drawing.Point(12, 9);
            this.labelViewSubjectTitle.Name = "labelViewSubjectTitle";
            this.labelViewSubjectTitle.Size = new System.Drawing.Size(171, 31);
            this.labelViewSubjectTitle.TabIndex = 17;
            this.labelViewSubjectTitle.Text = "View Subject";
            // 
            // ViewSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(619, 383);
            this.Controls.Add(this.panelDataGridView);
            this.Controls.Add(this.labelViewSubjectTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ViewSubjectForm";
            this.Text = "ViewSubjectForm";
            this.Load += new System.EventHandler(this.ViewSubjectForm_Load);
            this.panelDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubject)).EndInit();
            this.contextMenuStripSubject.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDataGridView;
        private System.Windows.Forms.Label labelViewSubjectTitle;
        private System.Windows.Forms.DataGridView dataGridViewSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSemester;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTeacherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubjectID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripSubject;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    }
}