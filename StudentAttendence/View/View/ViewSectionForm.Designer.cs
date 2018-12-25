namespace StudentAttendence.View.View
{
    partial class ViewSectionForm
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
            this.dataGridViewSection = new System.Windows.Forms.DataGridView();
            this.ColumnSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSemester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSectionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripSection = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelViewSectionTitle = new System.Windows.Forms.Label();
            this.panelDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSection)).BeginInit();
            this.contextMenuStripSection.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDataGridView
            // 
            this.panelDataGridView.Controls.Add(this.dataGridViewSection);
            this.panelDataGridView.Location = new System.Drawing.Point(18, 112);
            this.panelDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelDataGridView.Name = "panelDataGridView";
            this.panelDataGridView.Size = new System.Drawing.Size(544, 237);
            this.panelDataGridView.TabIndex = 18;
            // 
            // dataGridViewSection
            // 
            this.dataGridViewSection.AllowUserToAddRows = false;
            this.dataGridViewSection.AllowUserToDeleteRows = false;
            this.dataGridViewSection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSection.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSN,
            this.ColumnDepartment,
            this.ColumnSection,
            this.ColumnTeacher,
            this.ColumnSemester,
            this.ColumnSectionID});
            this.dataGridViewSection.ContextMenuStrip = this.contextMenuStripSection;
            this.dataGridViewSection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSection.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewSection.MultiSelect = false;
            this.dataGridViewSection.Name = "dataGridViewSection";
            this.dataGridViewSection.ReadOnly = true;
            this.dataGridViewSection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSection.Size = new System.Drawing.Size(544, 237);
            this.dataGridViewSection.TabIndex = 0;
            this.dataGridViewSection.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewSection_CellMouseDown);
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
            // ColumnSection
            // 
            this.ColumnSection.HeaderText = "Section";
            this.ColumnSection.Name = "ColumnSection";
            this.ColumnSection.ReadOnly = true;
            // 
            // ColumnTeacher
            // 
            this.ColumnTeacher.HeaderText = "Teacher";
            this.ColumnTeacher.Name = "ColumnTeacher";
            this.ColumnTeacher.ReadOnly = true;
            this.ColumnTeacher.Width = 160;
            // 
            // ColumnSemester
            // 
            this.ColumnSemester.HeaderText = "Semester";
            this.ColumnSemester.Name = "ColumnSemester";
            this.ColumnSemester.ReadOnly = true;
            // 
            // ColumnSectionID
            // 
            this.ColumnSectionID.HeaderText = "Section ID";
            this.ColumnSectionID.Name = "ColumnSectionID";
            this.ColumnSectionID.ReadOnly = true;
            this.ColumnSectionID.Visible = false;
            // 
            // contextMenuStripSection
            // 
            this.contextMenuStripSection.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.contextMenuStripSection.Name = "contextMenuStripDepartment";
            this.contextMenuStripSection.Size = new System.Drawing.Size(181, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // labelViewSectionTitle
            // 
            this.labelViewSectionTitle.AutoSize = true;
            this.labelViewSectionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelViewSectionTitle.Location = new System.Drawing.Point(12, 9);
            this.labelViewSectionTitle.Name = "labelViewSectionTitle";
            this.labelViewSectionTitle.Size = new System.Drawing.Size(171, 31);
            this.labelViewSectionTitle.TabIndex = 19;
            this.labelViewSectionTitle.Text = "View Section";
            // 
            // ViewSectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(641, 417);
            this.Controls.Add(this.panelDataGridView);
            this.Controls.Add(this.labelViewSectionTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ViewSectionForm";
            this.Text = "ViewSectionForm";
            this.Load += new System.EventHandler(this.ViewSectionForm_Load);
            this.panelDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSection)).EndInit();
            this.contextMenuStripSection.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDataGridView;
        private System.Windows.Forms.DataGridView dataGridViewSection;
        private System.Windows.Forms.Label labelViewSectionTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSection;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSemester;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSectionID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripSection;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    }
}