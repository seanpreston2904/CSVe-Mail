using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSVeMail
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
        }

        private void ConfigForm_Load(object sender, EventArgs e) 
        {

            //Apply all user settings
            EmailDomainInput.Text = UserSettings.Default.emailDomain;
            RandomNumbersToggle.Checked = UserSettings.Default.randomNumbers;
            RandomNumbersCountInput.Value = (uint)UserSettings.Default.randomNumbersCount;
            RandomNumbersStart.Checked = UserSettings.Default.randomNumbersPosition;
            RandomNumbersEnd.Checked = !UserSettings.Default.randomNumbersPosition;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void GenerationSettingsTab_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ConfigForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            //Apply all user settings
            UserSettings.Default.emailDomain = EmailDomainInput.Text;
            UserSettings.Default.randomNumbers = RandomNumbersToggle.Checked;
            UserSettings.Default.randomNumbersCount = (uint)RandomNumbersCountInput.Value;
            UserSettings.Default.randomNumbersPosition = RandomNumbersStart.Checked;

            UserSettings.Default.Save();

        }
    }
}
