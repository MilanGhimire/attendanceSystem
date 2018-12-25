namespace StudentAttendence.View.View
{
    partial class ViewUserAccount
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
            this.dataGridViewUserAccount = new System.Windows.Forms.DataGridView();
            this.ColumnSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUserAccountID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripAccount = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelViewUserAccountTitle = new System.Windows.Forms.Label();
            this.panelDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserAccount)).BeginInit();
            this.contextMenuStripAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDataGridView
            // 
            this.panelDataGridView.Controls.Add(this.dataGridViewUserAccount);
            this.panelDataGridView.Location = new System.Drawing.Point(12, 115);
            this.panelDataGridView.Name = "panelDataGridView";
            this.panelDataGridView.Size = new System.Drawing.Size(623, 181);
            this.panelDataGridView.TabIndex = 0;
            // 
            // dataGridViewUserAccount
            // 
            this.dataGridViewUserAccount.AllowUserToAddRows = false;
            this.dataGridViewUserAccount.AllowUserToDeleteRows = false;
            this.dataGridViewUserAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSN,
            this.ColumnName,
            this.ColumnUserName,
            this.ColumnRole,
            this.ColumnDepartment,
            this.ColumnUserAccountID});
            this.dataGridViewUserAccount.ContextMenuStrip = this.contextMenuStripAccount;
            this.dataGridViewUserAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewUserAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUserAccount.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewUserAccount.MultiSelect = false;
            this.dataGridViewUserAccount.Name = "dataGridViewUserAccount";
            this.dataGridViewUserAccount.ReadOnly = true;
            this.dataGridViewUserAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUserAccount.Size = new System.Drawing.Size(623, 181);
            this.dataGridViewUserAccount.TabIndex = 0;
            this.dataGridViewUserAccount.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewUserAccount_CellMouseDown);
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
            // ColumnUserName
            // 
            this.ColumnUserName.HeaderText = "Username";
            this.ColumnUserName.Name = "ColumnUserName";
            this.ColumnUserName.ReadOnly = true;
            this.ColumnUserName.Width = 140;
            // 
            // ColumnRole
            // 
            this.ColumnRole.HeaderText = "Role";
            this.ColumnRole.Name = "ColumnRole";
            this.ColumnRole.ReadOnly = true;
            // 
            // ColumnDepartment
            // 
            this.ColumnDepartment.HeaderText = "Department";
            this.ColumnDepartment.Name = "ColumnDepartment";
            this.ColumnDepartment.ReadOnly = true;
            // 
            // ColumnUserAccountID
            // 
            this.ColumnUserAccountID.HeaderText = "User Account ID";
            this.ColumnUserAccountID.Name = "ColumnUserAccountID";
            this.ColumnUserAccountID.ReadOnly = true;
            this.ColumnUserAccountID.Visible = false;
            // 
            // contextMenuStripAccount
            // 
            this.contextMenuStripAccount.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.contextMenuStripAccount.Name = "contextMenuStripDepartment";
            this.contextMenuStripAccount.Size = new System.Drawing.Size(181, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // labelViewUserAccountTitle
            // 
            this.labelViewUserAccountTitle.AutoSize = true;
            this.labelViewUserAccountTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelViewUserAccountTitle.Location = new System.Drawing.Point(12, 9);
            this.labelViewUserAccountTitle.Name = "labelViewUserAccountTitle";
            this.labelViewUserAccountTitle.Size = new System.Drawing.Size(244, 31);
            this.labelViewUserAccountTitle.TabIndex = 15;
            this.labelViewUserAccountTitle.Text = "View User Account";
            // 
            // ViewUserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(647, 352);
            this.Controls.Add(this.labelViewUserAccountTitle);
            this.Controls.Add(this.panelDataGridView);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ViewUserAccount";
            this.Text = "ViewUserAccount";
            this.Load += new System.EventHandler(this.ViewUserAccount_Load);
            this.panelDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserAccount)).EndInit();
            this.contextMenuStripAccount.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDataGridView;
        private System.Windows.Forms.DataGridView dataGridViewUserAccount;
        private System.Windows.Forms.Label labelViewUserAccountTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUserAccountID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripAccount;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    }
}