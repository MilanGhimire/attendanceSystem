namespace StudentAttendence.View.View
{
    partial class ViewSemesterForm
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
            this.dataGridViewSemester = new System.Windows.Forms.DataGridView();
            this.ColumnSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSemesterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSemesterID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripSemester = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelViewSemesterTitle = new System.Windows.Forms.Label();
            this.panelDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSemester)).BeginInit();
            this.contextMenuStripSemester.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDataGridView
            // 
            this.panelDataGridView.Controls.Add(this.dataGridViewSemester);
            this.panelDataGridView.Location = new System.Drawing.Point(18, 88);
            this.panelDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelDataGridView.Name = "panelDataGridView";
            this.panelDataGridView.Size = new System.Drawing.Size(333, 237);
            this.panelDataGridView.TabIndex = 18;
            // 
            // dataGridViewSemester
            // 
            this.dataGridViewSemester.AllowUserToAddRows = false;
            this.dataGridViewSemester.AllowUserToDeleteRows = false;
            this.dataGridViewSemester.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSemester.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSN,
            this.ColumnDepartment,
            this.ColumnSemesterName,
            this.ColumnSemesterID});
            this.dataGridViewSemester.ContextMenuStrip = this.contextMenuStripSemester;
            this.dataGridViewSemester.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewSemester.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSemester.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSemester.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewSemester.MultiSelect = false;
            this.dataGridViewSemester.Name = "dataGridViewSemester";
            this.dataGridViewSemester.ReadOnly = true;
            this.dataGridViewSemester.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSemester.Size = new System.Drawing.Size(333, 237);
            this.dataGridViewSemester.TabIndex = 0;
            this.dataGridViewSemester.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewSemester_CellMouseDown);
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
            // ColumnSemesterName
            // 
            this.ColumnSemesterName.HeaderText = "Semester Name";
            this.ColumnSemesterName.Name = "ColumnSemesterName";
            this.ColumnSemesterName.ReadOnly = true;
            this.ColumnSemesterName.Width = 150;
            // 
            // ColumnSemesterID
            // 
            this.ColumnSemesterID.HeaderText = "Semester ID";
            this.ColumnSemesterID.Name = "ColumnSemesterID";
            this.ColumnSemesterID.ReadOnly = true;
            this.ColumnSemesterID.Visible = false;
            // 
            // contextMenuStripSemester
            // 
            this.contextMenuStripSemester.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.contextMenuStripSemester.Name = "contextMenuStripDepartment";
            this.contextMenuStripSemester.Size = new System.Drawing.Size(181, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // labelViewSemesterTitle
            // 
            this.labelViewSemesterTitle.AutoSize = true;
            this.labelViewSemesterTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelViewSemesterTitle.Location = new System.Drawing.Point(12, 9);
            this.labelViewSemesterTitle.Name = "labelViewSemesterTitle";
            this.labelViewSemesterTitle.Size = new System.Drawing.Size(196, 31);
            this.labelViewSemesterTitle.TabIndex = 19;
            this.labelViewSemesterTitle.Text = "View Semester";
            // 
            // ViewSemesterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(408, 392);
            this.Controls.Add(this.panelDataGridView);
            this.Controls.Add(this.labelViewSemesterTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ViewSemesterForm";
            this.Text = "ViewSemesterForm";
            this.Load += new System.EventHandler(this.ViewSemesterForm_Load);
            this.panelDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSemester)).EndInit();
            this.contextMenuStripSemester.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDataGridView;
        private System.Windows.Forms.DataGridView dataGridViewSemester;
        private System.Windows.Forms.Label labelViewSemesterTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSemesterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSemesterID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripSemester;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    }
}