using System;
using System.Windows.Forms;

namespace StudentAttendence.View.View
{
    public partial class ViewSectionForm : Form
    {
        Controller.Section section;

        public ViewSectionForm()
        {
            InitializeComponent();
            section = new Controller.Section();
        }

        private void ViewSectionForm_Load(object sender, EventArgs e)
        {
            section.GetAllSectionList(dataGridViewSection);
        }

        private void dataGridViewSection_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1 && e.Button == MouseButtons.Right)
            {
                dataGridViewSection.Rows[e.RowIndex].Selected = true;
                section.sectionID = Convert.ToInt32(dataGridViewSection.Rows[e.RowIndex].Cells["ColumnSectionID"].Value);
                contextMenuStripSection.Show();
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (section.sectionID == 0)
            {
                MessageBox.Show("Section Not Selected.");
                return;
            }

            AddSectionForm addSectionForm = new AddSectionForm(section.sectionID);
            addSectionForm.ShowDialog(this);
            dataGridViewSection.Rows.Clear();
            section.GetAllSectionList(dataGridViewSection);
        }
    }
}
