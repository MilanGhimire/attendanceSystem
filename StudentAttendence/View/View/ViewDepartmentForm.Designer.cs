namespace StudentAttendence
{
    partial class ViewDepartmentForm
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
            this.dataGridViewDepartment = new System.Windows.Forms.DataGridView();
            this.labelViewDepartmentTitle = new System.Windows.Forms.Label();
            this.contextMenuStripDepartment = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColumnSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGraduationType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDepartmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartment)).BeginInit();
            this.contextMenuStripDepartment.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDataGridView
            // 
            this.panelDataGridView.Controls.Add(this.dataGridViewDepartment);
            this.panelDataGridView.Location = new System.Drawing.Point(35, 73);
            this.panelDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelDataGridView.Name = "panelDataGridView";
            this.panelDataGridView.Size = new System.Drawing.Size(333, 237);
            this.panelDataGridView.TabIndex = 20;
            // 
            // dataGridViewDepartment
            // 
            this.dataGridViewDepartment.AllowUserToAddRows = false;
            this.dataGridViewDepartment.AllowUserToDeleteRows = false;
            this.dataGridViewDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSN,
            this.ColumnDepartment,
            this.ColumnGraduationType,
            this.ColumnDuration,
            this.ColumnDepartmentID});
            this.dataGridViewDepartment.ContextMenuStrip = this.contextMenuStripDepartment;
            this.dataGridViewDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDepartment.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDepartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewDepartment.MultiSelect = false;
            this.dataGridViewDepartment.Name = "dataGridViewDepartment";
            this.dataGridViewDepartment.ReadOnly = true;
            this.dataGridViewDepartment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDepartment.Size = new System.Drawing.Size(333, 237);
            this.dataGridViewDepartment.TabIndex = 0;
            this.dataGridViewDepartment.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewDepartment_CellMouseDown);
            // 
            // labelViewDepartmentTitle
            // 
            this.labelViewDepartmentTitle.AutoSize = true;
            this.labelViewDepartmentTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelViewDepartmentTitle.Location = new System.Drawing.Point(12, 9);
            this.labelViewDepartmentTitle.Name = "labelViewDepartmentTitle";
            this.labelViewDepartmentTitle.Size = new System.Drawing.Size(222, 31);
            this.labelViewDepartmentTitle.TabIndex = 21;
            this.labelViewDepartmentTitle.Text = "View Department";
            // 
            // contextMenuStripDepartment
            // 
            this.contextMenuStripDepartment.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.contextMenuStripDepartment.Name = "contextMenuStripDepartment";
            this.contextMenuStripDepartment.Size = new System.Drawing.Size(95, 26);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
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
            // ColumnGraduationType
            // 
            this.ColumnGraduationType.HeaderText = "Graduation";
            this.ColumnGraduationType.Name = "ColumnGraduationType";
            this.ColumnGraduationType.ReadOnly = true;
            this.ColumnGraduationType.Width = 80;
            // 
            // ColumnDuration
            // 
            this.ColumnDuration.HeaderText = "Duration";
            this.ColumnDuration.Name = "ColumnDuration";
            this.ColumnDuration.ReadOnly = true;
            this.ColumnDuration.Width = 70;
            // 
            // ColumnDepartmentID
            // 
            this.ColumnDepartmentID.HeaderText = "DeptID";
            this.ColumnDepartmentID.Name = "ColumnDepartmentID";
            this.ColumnDepartmentID.ReadOnly = true;
            this.ColumnDepartmentID.Visible = false;
            // 
            // ViewDepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(409, 361);
            this.Controls.Add(this.panelDataGridView);
            this.Controls.Add(this.labelViewDepartmentTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ViewDepartmentForm";
            this.Text = "ViewDepartmentForm";
            this.Load += new System.EventHandler(this.ViewDepartmentForm_Load);
            this.panelDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartment)).EndInit();
            this.contextMenuStripDepartment.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDataGridView;
        private System.Windows.Forms.DataGridView dataGridViewDepartment;
        private System.Windows.Forms.Label labelViewDepartmentTitle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDepartment;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGraduationType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDepartmentID;
    }
}