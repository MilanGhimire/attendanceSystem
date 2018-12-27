using System;
using System.Windows.Forms;

namespace StudentAttendence.View.View
{
    public partial class ViewTodayAttandance : Form
    {
        Controller.Attandence attandence;
        public Controller.UserAccount userAccount;

        public ViewTodayAttandance(Controller.UserAccount ua)
        {
            attandence = new Controller.Attandence();
            InitializeComponent();
            userAccount = ua;
        }

        private void ViewTodayAttandance_Load(object sender, EventArgs e)
        {
            Controller.Semester semester = new Controller.Semester();
            semester.LoadAllSemester(userAccount.ua_department_id, comboBoxSemester);
        }

        private void comboBoxSemester_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBoxSection.DataSource = null;
            comboBoxSection.Items.Clear();
            comboBoxSubject.DataSource = null;
            comboBoxSubject.Items.Clear();

            Controller.Section section = new Controller.Section();
            Controller.Subject subject = new Controller.Subject();
            section.LoadAllSection(userAccount.ua_department_id, Convert.ToInt32(comboBoxSemester.SelectedValue), comboBoxSection);
            subject.LoadAllSubject(userAccount.ua_department_id, Convert.ToInt32(comboBoxSemester.SelectedValue), comboBoxSubject);
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
                attandence.GetTodayAttandence(userAccount.ua_department_id, Convert.ToInt32(comboBoxSemester.SelectedValue), Convert.ToInt32(comboBoxSection.SelectedValue), Convert.ToInt32(comboBoxSubject.SelectedValue), dataGridViewTodayAttandance);
            }
        }

        private void buttonViewOnlyAbsent_Click(object sender, EventArgs e)
        {
            dataGridViewTodayAttandance.Rows.Clear();
            DateTime date = Convert.ToDateTime(dateTimePickerDateAttandence.Text);
            string dateFormatofDatabase = "yyyy-MM-dd";
            string attandenceDate = date.ToString(dateFormatofDatabase);
            attandence.GetAllSpecificDateAbsentList(userAccount.ua_department_id, attandenceDate, dataGridViewTodayAttandance);
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
