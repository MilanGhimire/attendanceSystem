namespace StudentAttendence.View.View
{
    partial class ViewTeacherForm
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
            this.dataGridViewTeacher = new System.Windows.Forms.DataGridView();
            this.ColumnSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTeacherID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripTeacher = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelViewTeacherTitle = new System.Windows.Forms.Label();
            this.panelDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeacher)).BeginInit();
            this.contextMenuStripTeacher.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDataGridView
            // 
            this.panelDataGridView.Controls.Add(this.dataGridViewTeacher);
            this.panelDataGridView.Location = new System.Drawing.Point(12, 115);
            this.panelDataGridView.Name = "panelDataGridView";
            this.panelDataGridView.Size = new System.Drawing.Size(665, 181);
            this.panelDataGridView.TabIndex = 16;
            // 
            // dataGridViewTeacher
            // 
            this.dataGridViewTeacher.AllowUserToAddRows = false;
            this.dataGridViewTeacher.AllowUserToDeleteRows = false;
            this.dataGridViewTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeacher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSN,
            this.ColumnName,
            this.ColumnContact,
            this.ColumnAddress,
            this.ColumnEmail,
            this.ColumnDepartment,
            this.ColumnTeacherID});
            this.dataGridViewTeacher.ContextMenuStrip = this.contextMenuStripTeacher;
            this.dataGridViewTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewTeacher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTeacher.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTeacher.MultiSelect = false;
            this.dataGridViewTeacher.Name = "dataGridViewTeacher";
            this.dataGridViewTeacher.ReadOnly = true;
            this.dataGridViewTeacher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTeacher.Size = new System.Drawing.Size(665, 181);
            this.dataGridViewTeacher.TabIndex = 0;
            this.dataGridViewTeacher.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewTeacher_CellMouseDown);
            // 
            // ColumnSN
            // 
            this.ColumnSN.HeaderText = "S.N.";
            this.ColumnSN.Name = "ColumnSN";
            this.ColumnSN.ReadOnly = true;
            this.ColumnSN.Width = 40;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            this.ColumnName.Width = 200;
            // 
            // ColumnContact
            // 
            this.ColumnContact.HeaderText = "Contact";
            this.ColumnContact.Name = "ColumnContact";
            this.ColumnContact.ReadOnly = true;
            // 
            // ColumnAddress
            // 
            this.ColumnAddress.HeaderText = "Address";
            this.ColumnAddress.Name = "ColumnAddress";
            this.ColumnAddress.ReadOnly = true;
            this.ColumnAddress.Width = 110;
            // 
            // ColumnEmail
            // 
            this.ColumnEmail.HeaderText = "Email";
            this.ColumnEmail.Name = "ColumnEmail";
            this.ColumnEmail.ReadOnly = true;
            this.ColumnEmail.Width = 120;
            // 
            // ColumnDepartment
            // 
            this.ColumnDepartment.HeaderText = "Department";
            this.ColumnDepartment.Name = "ColumnDepartment";
            this.ColumnDepartment.ReadOnly = true;
            this.ColumnDepartment.Width = 50;
            // 
            // ColumnTeacherID
            // 
            this.ColumnTeacherID.HeaderText = "Teacher ID";
            this.ColumnTeacherID.Name = "ColumnTeacherID";
            this.ColumnTeacherID.ReadOnly = true;
            this.ColumnTeacherID.Visible = false;
            // 
            // contextMenuStripTeacher
            // 
            this.contextMenuStripTeacher.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.contextMenuStripTeacher.Name = "contextMenuStripDepartment";
            this.contextMenuStripTeacher.Size = new System.Drawing.Size(181, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // labelViewTeacherTitle
            // 
            this.labelViewTeacherTitle.AutoSize = true;
            this.labelViewTeacherTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelViewTeacherTitle.Location = new System.Drawing.Point(12, 9);
            this.labelViewTeacherTitle.Name = "labelViewTeacherTitle";
            this.labelViewTeacherTitle.Size = new System.Drawing.Size(180, 31);
            this.labelViewTeacherTitle.TabIndex = 17;
            this.labelViewTeacherTitle.Text = "View Teacher";
            // 
            // ViewTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(690, 382);
            this.Controls.Add(this.panelDataGridView);
            this.Controls.Add(this.labelViewTeacherTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ViewTeacherForm";
            this.Text = "ViewTeacherForm";
            this.Load += new System.EventHandler(this.ViewTeacherForm_Load);
            this.panelDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeacher)).EndInit();
            this.contextMenuStripTeacher.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDataGridView;
        private System.Windows.Forms.DataGridView dataGridViewTeacher;
        private System.Windows.Forms.Label labelViewTeacherTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTeacherID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTeacher;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    }
}