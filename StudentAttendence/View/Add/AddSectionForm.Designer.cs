namespace StudentAttendence
{
    partial class AddSectionForm
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
            this.buttonSectionSubmit = new System.Windows.Forms.Button();
            this.labelAddSection = new System.Windows.Forms.Label();
            this.labelSectionName = new System.Windows.Forms.Label();
            this.panelSectionTextbox = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxSectionName1 = new System.Windows.Forms.TextBox();
            this.AddSectionLinkLabel = new System.Windows.Forms.LinkLabel();
            this.panelSectionContainer = new System.Windows.Forms.Panel();
            this.panelSubmit = new System.Windows.Forms.Panel();
            this.labelSemester = new System.Windows.Forms.Label();
            this.comboBoxSemesterName = new System.Windows.Forms.ComboBox();
            this.panelSectionTextbox.SuspendLayout();
            this.panelSectionContainer.SuspendLayout();
            this.panelSubmit.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSectionSubmit
            // 
            this.buttonSectionSubmit.Location = new System.Drawing.Point(191, 6);
            this.buttonSectionSubmit.Name = "buttonSectionSubmit";
            this.buttonSectionSubmit.Size = new System.Drawing.Size(83, 31);
            this.buttonSectionSubmit.TabIndex = 25;
            this.buttonSectionSubmit.Text = "Submit";
            this.buttonSectionSubmit.UseVisualStyleBackColor = true;
            this.buttonSectionSubmit.Click += new System.EventHandler(this.buttonSectionSubmit_Click);
            // 
            // labelAddSection
            // 
            this.labelAddSection.AutoSize = true;
            this.labelAddSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddSection.Location = new System.Drawing.Point(12, 9);
            this.labelAddSection.Name = "labelAddSection";
            this.labelAddSection.Size = new System.Drawing.Size(160, 31);
            this.labelAddSection.TabIndex = 22;
            this.labelAddSection.Text = "Add Section";
            // 
            // labelSectionName
            // 
            this.labelSectionName.AutoSize = true;
            this.labelSectionName.Location = new System.Drawing.Point(87, 3);
            this.labelSectionName.Name = "labelSectionName";
            this.labelSectionName.Size = new System.Drawing.Size(96, 17);
            this.labelSectionName.TabIndex = 18;
            this.labelSectionName.Text = "Section Name :";
            // 
            // panelSectionTextbox
            // 
            this.panelSectionTextbox.AutoSize = true;
            this.panelSectionTextbox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelSectionTextbox.Controls.Add(this.textBoxSectionName1);
            this.panelSectionTextbox.Controls.Add(this.AddSectionLinkLabel);
            this.panelSectionTextbox.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelSectionTextbox.Location = new System.Drawing.Point(188, 3);
            this.panelSectionTextbox.Name = "panelSectionTextbox";
            this.panelSectionTextbox.Size = new System.Drawing.Size(181, 48);
            this.panelSectionTextbox.TabIndex = 27;
            // 
            // textBoxSectionName1
            // 
            this.textBoxSectionName1.Location = new System.Drawing.Point(3, 3);
            this.textBoxSectionName1.Name = "textBoxSectionName1";
            this.textBoxSectionName1.Size = new System.Drawing.Size(175, 25);
            this.textBoxSectionName1.TabIndex = 29;
            // 
            // AddSectionLinkLabel
            // 
            this.AddSectionLinkLabel.AutoSize = true;
            this.AddSectionLinkLabel.Location = new System.Drawing.Point(3, 31);
            this.AddSectionLinkLabel.Name = "AddSectionLinkLabel";
            this.AddSectionLinkLabel.Size = new System.Drawing.Size(32, 17);
            this.AddSectionLinkLabel.TabIndex = 30;
            this.AddSectionLinkLabel.TabStop = true;
            this.AddSectionLinkLabel.Text = "Add";
            this.AddSectionLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddSectionLinkLabel_LinkClicked);
            // 
            // panelSectionContainer
            // 
            this.panelSectionContainer.AutoSize = true;
            this.panelSectionContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelSectionContainer.Controls.Add(this.panelSectionTextbox);
            this.panelSectionContainer.Controls.Add(this.labelSectionName);
            this.panelSectionContainer.Location = new System.Drawing.Point(12, 84);
            this.panelSectionContainer.Name = "panelSectionContainer";
            this.panelSectionContainer.Size = new System.Drawing.Size(372, 54);
            this.panelSectionContainer.TabIndex = 28;
            // 
            // panelSubmit
            // 
            this.panelSubmit.Controls.Add(this.buttonSectionSubmit);
            this.panelSubmit.Location = new System.Drawing.Point(12, 138);
            this.panelSubmit.Name = "panelSubmit";
            this.panelSubmit.Size = new System.Drawing.Size(373, 46);
            this.panelSubmit.TabIndex = 29;
            // 
            // labelSemester
            // 
            this.labelSemester.AutoSize = true;
            this.labelSemester.Location = new System.Drawing.Point(99, 56);
            this.labelSemester.Name = "labelSemester";
            this.labelSemester.Size = new System.Drawing.Size(73, 17);
            this.labelSemester.TabIndex = 30;
            this.labelSemester.Text = "Semester  :";
            // 
            // comboBoxSemesterName
            // 
            this.comboBoxSemesterName.FormattingEnabled = true;
            this.comboBoxSemesterName.Location = new System.Drawing.Point(203, 53);
            this.comboBoxSemesterName.Name = "comboBoxSemesterName";
            this.comboBoxSemesterName.Size = new System.Drawing.Size(175, 25);
            this.comboBoxSemesterName.TabIndex = 31;
            // 
            // AddSectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(517, 340);
            this.Controls.Add(this.comboBoxSemesterName);
            this.Controls.Add(this.labelSemester);
            this.Controls.Add(this.panelSubmit);
            this.Controls.Add(this.panelSectionContainer);
            this.Controls.Add(this.labelAddSection);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddSectionForm";
            this.Text = "AddSectionForm";
            this.Load += new System.EventHandler(this.AddSectionForm_Load);
            this.panelSectionTextbox.ResumeLayout(false);
            this.panelSectionTextbox.PerformLayout();
            this.panelSectionContainer.ResumeLayout(false);
            this.panelSectionContainer.PerformLayout();
            this.panelSubmit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSectionSubmit;
        private System.Windows.Forms.Label labelAddSection;
        private System.Windows.Forms.Label labelSectionName;
        public System.Windows.Forms.FlowLayoutPanel panelSectionTextbox;
        private System.Windows.Forms.TextBox textBoxSectionName1;
        private System.Windows.Forms.LinkLabel AddSectionLinkLabel;
        private System.Windows.Forms.Panel panelSectionContainer;
        private System.Windows.Forms.Panel panelSubmit;
        private System.Windows.Forms.Label labelSemester;
        private System.Windows.Forms.ComboBox comboBoxSemesterName;
    }
}