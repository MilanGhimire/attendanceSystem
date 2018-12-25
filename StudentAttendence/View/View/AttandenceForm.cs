using System;
using System.Windows.Forms;

namespace StudentAttendence
{
    public partial class AttandenceForm : Form
    {
        public AttandenceForm()
        {
            InitializeComponent();
        }

        private void AttandenceForm_Load(object sender, EventArgs e)
        {
            Controller.Semester semester = new Controller.Semester();
            semester.LoadAllSemester(1, comboBoxSemester);
        }

        private void comboBoxSemester_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //MessageBox.Show("SelectionChangeCommitted.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            comboBoxSection.DataSource = null;
            comboBoxSection.Items.Clear();
            comboBoxSubject.DataSource = null;
            comboBoxSubject.Items.Clear();

            //comboBoxSection.Items.Remove(1);
            //for (int i = 0; i < comboBoxSection.Items.Count; i++)
            //{
            //    comboBoxSection.Items.RemoveAt(i);
            //}
            //comboBoxSection.Items.Remove(comboBoxSection.SelectedItem);

            Controller.Section section = new Controller.Section();
            Controller.Subject subject = new Controller.Subject();
            section.LoadAllSection(1, Convert.ToInt32(comboBoxSemester.SelectedValue), comboBoxSection);
            subject.LoadAllSubject(1, Convert.ToInt32(comboBoxSemester.SelectedValue), comboBoxSubject);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (!AttandenceValidation())
            {
                return;
            }
            dataGridViewStudent.Rows.Clear();

            //If all fields are entered
            Controller.Attandence attandence = new Controller.Attandence();
            if (comboBoxSection.SelectedItem != null && comboBoxSubject.SelectedItem != null && !String.IsNullOrWhiteSpace(textBoxStudentName.Text))
            {
                String[] paramaterNames = {"@semester", "@section", "@subject", "@studentName"};
                String[] paramaterValues = {comboBoxSemester.SelectedValue.ToString(), comboBoxSection.SelectedValue.ToString(), comboBoxSubject.SelectedValue.ToString(), (textBoxStudentName.Text) + "%"};

                attandence.GetStudentAttandence("SELECT a.`student_id`, s.`student_card_id`, s.`student_name`, a.`teacher_id`, sec.`sec_name`, sub.`subject_name`, sem.`sem_name`, SUM(a.`attendance_status`) AS 'Present', COUNT(`attendance_status`) AS 'Total' FROM `tbl_attendance` AS a INNER JOIN `tbl_students` AS s ON a.`student_id` = s.`student_id` INNER JOIN `tbl_section` AS sec ON a.`section_id` = sec.`sec_id` INNER JOIN `tbl_subject` AS sub ON a.`subject_id` = sub.`subject_id` INNER JOIN `tbl_semester` as sem ON a.`attendance_semester` = sem.`sem_id` WHERE a.`attendance_semester` = @semester AND a.`section_id` = @section AND a.`subject_id` = @subject AND s.`student_name` LIKE @studentName GROUP BY a.`student_id`", paramaterNames, paramaterValues, dataGridViewStudent);
                //int i = 0;
                //foreach (String name in paramaterNames)
                //{
                //    MessageBox.Show(name + "\n" + paramaterValues[i]);
                //    i++;
                //}
            }

            //IF Subject field is empty
            if (comboBoxSection.SelectedItem != null && comboBoxSubject.SelectedItem == null && !String.IsNullOrWhiteSpace(textBoxStudentName.Text))
            {
                String[] paramaterNames = { "@semester", "@section", "@studentName" };
                String[] paramaterValues = { comboBoxSemester.SelectedValue.ToString(), comboBoxSection.SelectedValue.ToString(), (textBoxStudentName.Text) + "%" };

                //SELECT `subject_id`, `subject_department_id`, `subject_semester_id`, `subject_section_id`, `subject_teacher_id`, `subject_name` FROM `db_student_attendance`.`tbl_subject` WHERE `subject_department_id` = 1 AND `subject_semester_id` = 7 AND `subject_section_id` = 1;

                //attandence.GetStudentAttandence("", paramaterNames, paramaterValues, dataGridViewStudent);
            }

            //If Student name field is empty
            if (comboBoxSection.SelectedItem != null && comboBoxSubject.SelectedItem != null && String.IsNullOrWhiteSpace(textBoxStudentName.Text))
            {
                String[] paramaterNames = { "@semester", "@section", "@subject"};
                String[] paramaterValues = { comboBoxSemester.SelectedValue.ToString(), comboBoxSection.SelectedValue.ToString(), comboBoxSubject.SelectedValue.ToString()};

                attandence.GetStudentAttandence("SELECT a.`student_id`, s.`student_card_id`, s.`student_name`, a.`teacher_id`, sec.`sec_name`, sub.`subject_name`, sem.`sem_name`, SUM(a.`attendance_status`) AS 'Present', COUNT(`attendance_status`) AS 'Total' FROM `tbl_attendance` AS a INNER JOIN `tbl_students` AS s ON a.`student_id` = s.`student_id` INNER JOIN `tbl_section` AS sec ON a.`section_id` = sec.`sec_id` INNER JOIN `tbl_subject` AS sub ON a.`subject_id` = sub.`subject_id` INNER JOIN `tbl_semester` as sem ON a.`attendance_semester` = sem.`sem_id` WHERE a.`attendance_semester` = @semester AND a.`section_id` = @section AND a.`subject_id` = @subject GROUP BY a.`student_id`", paramaterNames, paramaterValues, dataGridViewStudent);
            }

            //IF Student name and subject is not selected
            if (comboBoxSection.SelectedItem != null && comboBoxSubject.SelectedItem == null && String.IsNullOrWhiteSpace(textBoxStudentName.Text))
            {
                String[] paramaterNames = { "@semester", "@section",};
                String[] paramaterValues = { comboBoxSemester.SelectedValue.ToString(), comboBoxSection.SelectedValue.ToString()};

                attandence.GetStudentAttandence("SELECT a.`student_id`, s.`student_card_id`, s.`student_name`, a.`teacher_id`, sec.`sec_name`, sub.`subject_name`, sem.`sem_name`, SUM(a.`attendance_status`) AS 'Present', COUNT(`attendance_status`) AS 'Total' FROM `tbl_attendance` AS a INNER JOIN `tbl_students` AS s ON a.`student_id` = s.`student_id` INNER JOIN `tbl_section` AS sec ON a.`section_id` = sec.`sec_id` INNER JOIN `tbl_subject` AS sub ON a.`subject_id` = sub.`subject_id` INNER JOIN `tbl_semester` as sem ON a.`attendance_semester` = sem.`sem_id` WHERE a.`attendance_semester` = @semester AND a.`section_id` = @section GROUP BY a.`student_id`", paramaterNames, paramaterValues, dataGridViewStudent);
            }

            //If Section and subject fields are empty
            if (comboBoxSection.SelectedItem == null && comboBoxSubject.SelectedItem == null && !String.IsNullOrWhiteSpace(textBoxStudentName.Text))
            {
                String[] paramaterNames = { "@semester", "@studentName" };
                String[] paramaterValues = { comboBoxSemester.SelectedValue.ToString(), (textBoxStudentName.Text) + "%" };

                attandence.GetStudentAttandence("SELECT a.`student_id`, s.`student_card_id`, s.`student_name`, a.`teacher_id`, sec.`sec_name`, sub.`subject_name`, sem.`sem_name`, SUM(a.`attendance_status`) AS 'Present', COUNT(`attendance_status`) AS 'Total' FROM `tbl_attendance` AS a INNER JOIN `tbl_students` AS s ON a.`student_id` = s.`student_id` INNER JOIN `tbl_section` AS sec ON a.`section_id` = sec.`sec_id` INNER JOIN `tbl_subject` AS sub ON a.`subject_id` = sub.`subject_id` INNER JOIN `tbl_semester` as sem ON a.`attendance_semester` = sem.`sem_id` WHERE a.`attendance_semester` = @semester AND s.`student_name` LIKE @studentName GROUP BY a.`student_id`", paramaterNames, paramaterValues, dataGridViewStudent);
            }
            
            //MessageBox.Show("Congrach");
        }

        private bool AttandenceValidation()
        {
            if (comboBoxSemester.SelectedItem == null)
            {
                MessageBox.Show("Please select the semester.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                comboBoxSemester.Focus();
                return false;
            }
            //if (comboBoxSection.SelectedItem == null && comboBoxSubject.SelectedItem == null)
            //{
            //    DialogResult conform = MessageBox.Show("Do you want to keep Section and Subject empty.", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //    if (DialogResult.No == conform)
            //    {
            //        comboBoxSection.Focus();
            //        return false;
            //    }
            //}
            //if (comboBoxSection.SelectedItem != null && comboBoxSubject.SelectedItem == null)
            //{
            //    DialogResult conform = MessageBox.Show("Do you want to keep Subject empty.", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //    if (DialogResult.No == conform)
            //    {
            //        comboBoxSubject.Focus();
            //        return false;
            //    }
            //}
            return true;
        }
    }
}
