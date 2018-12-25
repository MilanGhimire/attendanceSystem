namespace StudentAttendence
{
    partial class AddDepartmentForm
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
            this.labelCourseType = new System.Windows.Forms.Label();
            this.labelDepartmentName = new System.Windows.Forms.Label();
            this.textBoxDepartmentName = new System.Windows.Forms.TextBox();
            this.comboBoxCourseType = new System.Windows.Forms.ComboBox();
            this.labelAddDepartmentTitle = new System.Windows.Forms.Label();
            this.numericUpDownCourseDuration = new System.Windows.Forms.NumericUpDown();
            this.labelNumberOf = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCourseDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCourseType
            // 
            this.labelCourseType.AutoSize = true;
            this.labelCourseType.Location = new System.Drawing.Point(47, 113);
            this.labelCourseType.Name = "labelCourseType";
            this.labelCourseType.Size = new System.Drawing.Size(88, 17);
            this.labelCourseType.TabIndex = 8;
            this.labelCourseType.Text = "Course Type :";
            // 
            // labelDepartmentName
            // 
            this.labelDepartmentName.AutoSize = true;
            this.labelDepartmentName.Location = new System.Drawing.Point(47, 79);
            this.labelDepartmentName.Name = "labelDepartmentName";
            this.labelDepartmentName.Size = new System.Drawing.Size(123, 17);
            this.labelDepartmentName.TabIndex = 5;
            this.labelDepartmentName.Text = "Department Name :";
            // 
            // textBoxDepartmentName
            // 
            this.textBoxDepartmentName.Location = new System.Drawing.Point(190, 76);
            this.textBoxDepartmentName.Name = "textBoxDepartmentName";
            this.textBoxDepartmentName.Size = new System.Drawing.Size(176, 25);
            this.textBoxDepartmentName.TabIndex = 10;
            // 
            // comboBoxCourseType
            // 
            this.comboBoxCourseType.FormattingEnabled = true;
            this.comboBoxCourseType.Items.AddRange(new object[] {
            "Year",
            "Semester"});
            this.comboBoxCourseType.Location = new System.Drawing.Point(190, 110);
            this.comboBoxCourseType.Name = "comboBoxCourseType";
            this.comboBoxCourseType.Size = new System.Drawing.Size(176, 25);
            this.comboBoxCourseType.TabIndex = 11;
            this.comboBoxCourseType.SelectedValueChanged += new System.EventHandler(this.comboBoxCourseType_SelectedValueChanged);
            // 
            // labelAddDepartmentTitle
            // 
            this.labelAddDepartmentTitle.AutoSize = true;
            this.labelAddDepartmentTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddDepartmentTitle.Location = new System.Drawing.Point(12, 9);
            this.labelAddDepartmentTitle.Name = "labelAddDepartmentTitle";
            this.labelAddDepartmentTitle.Size = new System.Drawing.Size(211, 31);
            this.labelAddDepartmentTitle.TabIndex = 14;
            this.labelAddDepartmentTitle.Text = "Add Department";
            // 
            // numericUpDownCourseDuration
            // 
            this.numericUpDownCourseDuration.Location = new System.Drawing.Point(190, 143);
            this.numericUpDownCourseDuration.Name = "numericUpDownCourseDuration";
            this.numericUpDownCourseDuration.ReadOnly = true;
            this.numericUpDownCourseDuration.Size = new System.Drawing.Size(176, 25);
            this.numericUpDownCourseDuration.TabIndex = 15;
            this.numericUpDownCourseDuration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDownCourseDuration_KeyPress);
            // 
            // labelNumberOf
            // 
            this.labelNumberOf.AutoSize = true;
            this.labelNumberOf.Location = new System.Drawing.Point(47, 145);
            this.labelNumberOf.Name = "labelNumberOf";
            this.labelNumberOf.Size = new System.Drawing.Size(76, 17);
            this.labelNumberOf.TabIndex = 16;
            this.labelNumberOf.Text = "Number of ";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(190, 174);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(83, 31);
            this.buttonSubmit.TabIndex = 17;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // AddDepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(534, 333);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelNumberOf);
            this.Controls.Add(this.numericUpDownCourseDuration);
            this.Controls.Add(this.labelAddDepartmentTitle);
            this.Controls.Add(this.comboBoxCourseType);
            this.Controls.Add(this.textBoxDepartmentName);
            this.Controls.Add(this.labelCourseType);
            this.Controls.Add(this.labelDepartmentName);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddDepartmentForm";
            this.Text = "AddDepartmentForm";
            this.Load += new System.EventHandler(this.AddDepartmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCourseDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCourseType;
        private System.Windows.Forms.Label labelDepartmentName;
        private System.Windows.Forms.TextBox textBoxDepartmentName;
        private System.Windows.Forms.ComboBox comboBoxCourseType;
        private System.Windows.Forms.Label labelAddDepartmentTitle;
        private System.Windows.Forms.NumericUpDown numericUpDownCourseDuration;
        private System.Windows.Forms.Label labelNumberOf;
        private System.Windows.Forms.Button buttonSubmit;
    }
}