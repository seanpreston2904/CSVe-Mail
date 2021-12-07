using Utils;
using Models;

namespace CSVeMail
{
    public partial class MainForm : Form
    {

        private ConfigForm configForm = new ConfigForm();
        private MessageBoxButtons buttons = MessageBoxButtons.OK;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {

            //Check user has entered a valid source file
            if (FileSelectorUtil.CheckSource(SourceInput.Text))
            {

                //Show error message
                MessageBox.Show("Please select a source .csv file.", "Error", buttons);
                return;

            }

            //Data list
            List<Person> people;

            //Populate data list
            try { people = new List<Person>(FileInOutUtil.GetPeople(SourceInput.Text)); }
            catch (Exception ex)
            {

                //Show error message
                MessageBox.Show("Please select a valid source .csv file.", "Error", buttons);
                return;

            }

            //Ask user where to store final .csv file
            string saveFileDestination = FileSelectorUtil.SelectDestination();

            //Output list of emails derived from sring
            List<string> emails = new List<string>();
            emails.AddRange(Enumerable.Range(0, people.Count)
                .Select(x => EmailUtil.PersonToEmail(people[x])).ToArray());

            string output = "";
            foreach (string email in emails) { output += email + '\n'; }

            //Write emails to file
            File.WriteAllText(saveFileDestination, output);

            //Show success message
            MessageBox.Show(emails.Count() + " entries written to " + saveFileDestination, "Success", buttons);


        }

        private void Browse_Click(object sender, EventArgs e)
        {

            SourceInput.Text = FileSelectorUtil.OpenSource();

        }

        private void ConfigButton_Click(object sender, EventArgs e)
        {

            configForm = new ConfigForm();
            configForm.Show();

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("If you liked this tool, please check out my github!\nhttps://github.com/seanpreston2904", "Before you go...", buttons);
        }
    }
}