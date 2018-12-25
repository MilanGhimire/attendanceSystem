using System.Windows.Forms;

namespace StudentAttendence.Controller
{
    class Helper
    {
        public TextBox AddNewTextbox(int textBoxNumber)
        {
            TextBox newtextBox = new TextBox();
            newtextBox.Name = "textBox" + textBoxNumber;
            //newComboBox.Text = "Did It";
            newtextBox.Width = 175;
            newtextBox.Height = 25;
            return newtextBox;
        }

        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
