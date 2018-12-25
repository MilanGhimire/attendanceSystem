using System;
using System.Windows.Forms;

namespace StudentAttendence
{
    public partial class AddSectionForm : Form
    {
        public static AddSectionForm addSectionForm;
        private Controller.Section section;
        String sectionName;

        public AddSectionForm()
        {
            InitializeComponent();
            addSectionForm = this;
            sectionName = string.Empty;
            section = new Controller.Section();
        }

        public AddSectionForm(int secId)
        {
            InitializeComponent();
            sectionName = string.Empty;
            section = new Controller.Section
            {
                sectionID = secId
            };
        }
        //For count the number of sections added
        int sectionCount = 1;

        //For names passing in the query 
        String[] name;

        private void UpdateFormCall()
        {
            if (this.Owner != null)
            {
                if ((this.Owner is View.View.ViewSectionForm))
                {
                    labelAddSection.Text = "Update Section";
                    AddSectionLinkLabel.Visible = false;
                    section.GetSingleSection(comboBoxSemesterName, textBoxSectionName1);
                    sectionName = textBoxSectionName1.Text;
                }
            }
        }

        private void buttonSectionSubmit_Click(object sender, EventArgs e)
        {
            //ToDo Department Id is fetched automatically through login process

            if (!SectionValidation())
            {
                return;
            }

            if ((this.Owner is View.View.ViewSectionForm))
            {
                if (section.UpdateSection(1, Convert.ToInt32(comboBoxSemesterName.SelectedValue), textBoxSectionName1.Text))
                {
                    MessageBox.Show("Updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
            }
            if (this.Owner is HomeForm)
            {
                if (section.AddNewSection(1, Convert.ToInt32(comboBoxSemesterName.SelectedValue), name, sectionCount))
                {
                    MessageBox.Show("Inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
            }
        }

        private void AddSectionLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (sectionCount > 10) //To limit the credit Transactions upto 10
            {
                return;
            }
            if (sectionCount == 9)
            {
                AddSectionLinkLabel.Visible = false;
            }
            sectionCount++;
            this.panelSubmit.Location = new System.Drawing.Point(panelSubmit.Location.X, (panelSubmit.Location.Y) + 31);
            Controller.Helper hepler = new Controller.Helper();
            panelSectionTextbox.Controls.Remove(AddSectionLinkLabel); //Removes Add labelLink
            TextBox AddSectionTextbox = hepler.AddNewTextbox(sectionCount); //Calls the function for a textbox
            panelSectionTextbox.Controls.Add(AddSectionTextbox); //Adds textbox to the Section Panel
            panelSectionTextbox.Controls.Add(AddSectionLinkLabel); //Adds the previously removed Add labelLink
            //MessageBox.Show(sectionCount.ToString() + "\n" + AddSectionTextbox.Name);
        }

        private bool SectionValidation()
        {
            if (comboBoxSemesterName.SelectedItem == null)
            {
                MessageBox.Show("Please select semester.", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBoxSemesterName.Focus();
                return false;
            }

            //Name fields Validation
            int i = 0;
            Controller.Section section = new Controller.Section();
            foreach (Control control in panelSectionTextbox.Controls)
            {
                if (control is TextBox textBox)
                {
                    if (String.IsNullOrWhiteSpace(textBox.Text))
                    {
                        MessageBox.Show("Please fill the Section Name.", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox.Focus();
                        return false;
                    }

                    if (sectionName != textBox.Text || sectionName == string.Empty)
                    {
                        if (section.CheckForSectionName(Convert.ToInt32(comboBoxSemesterName.SelectedValue), textBox.Text, 1))
                        {
                            MessageBox.Show(textBox.Text + " : already exist in " + this.comboBoxSemesterName.GetItemText(this.comboBoxSemesterName.SelectedItem).ToString() + " semester.", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBox.Focus();
                            return false;
                        }
                    }
                    //MessageBox.Show("Found " + di + 1.ToString() + " Debit ComboBox.");
                    name[i] = textBox.Text;
                    i++;
                }
            }
            return true;
        }

        private void AddSectionForm_Load(object sender, EventArgs e)
        {
            name = new String[10] { String.Empty, String.Empty, String.Empty, String.Empty, String.Empty, String.Empty, String.Empty, String.Empty, String.Empty, String.Empty };

            Controller.Semester semester = new Controller.Semester();
            semester.LoadAllSemester(1, comboBoxSemesterName);
            UpdateFormCall();
        }
    }
}
