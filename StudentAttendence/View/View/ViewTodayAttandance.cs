using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAttendence.View.View
{
    public partial class ViewTodayAttandance : Form
    {
        Controller.Attandence attandence;

        public ViewTodayAttandance()
        {
            attandence = new Controller.Attandence();
            InitializeComponent();
        }

        private void ViewTodayAttandance_Load(object sender, EventArgs e)
        {
            Controller.Semester semester = new Controller.Semester();
            semester.LoadAllSemester(1, comboBoxSemester);
        }

        private void comboBoxSemester_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBoxSection.DataSource = null;
            comboBoxSection.Items.Clear();
            comboBoxSubject.DataSource = null;
            comboBoxSubject.Items.Clear();

            Controller.Section section = new Controller.Section();
            Controller.Subject subject = new Controller.Subject();
            section.LoadAllSection(1, Convert.ToInt32(comboBoxSemester.SelectedValue), comboBoxSection);
            subject.LoadAllSubject(1, Convert.ToInt32(comboBoxSemester.SelectedValue), comboBoxSubject);
        }

        private bool AttandenceValidation()
        {
            if (comboBoxSemester.SelectedItem == null)
            {
                MessageBox.Show("Please select the semester.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                comboBoxSemester.Focus();
                return false;
            }
            return true;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (!AttandenceValidation())
            {
                return;
            }

            //All filed been selected
            if (comboBoxSection.SelectedItem != null && comboBoxSubject.SelectedItem != null)
            {
                attandence.GetTodayAttandence(1, Convert.ToInt32(comboBoxSemester.SelectedValue), Convert.ToInt32(comboBoxSection.SelectedValue), Convert.ToInt32(comboBoxSubject.SelectedValue), dataGridViewTodayAttandance);
            }
        }

        private void buttonViewOnlyAbsent_Click(object sender, EventArgs e)
        {
            dataGridViewTodayAttandance.Rows.Clear();
            DateTime date = Convert.ToDateTime(dateTimePickerDateAttandence.Text);
            string dateFormatofDatabase = "yyyy-MM-dd";
            string attandenceDate = date.ToString(dateFormatofDatabase);
            attandence.GetAllSpecificDateAbsentList(1, attandenceDate, dataGridViewTodayAttandance);
        }

        private void buttonHideShow_Click(object sender, EventArgs e)
        {
            if (splitContainerViewTodayAttandance.Panel1Collapsed == false)
            {
                splitContainerViewTodayAttandance.Panel1Collapsed = true;
                buttonHideShow.Text = "Show";
            }
            else
            {
                splitContainerViewTodayAttandance.Panel1Collapsed = false;
                buttonHideShow.Text = "Hide";
            }
        }
    }
}
