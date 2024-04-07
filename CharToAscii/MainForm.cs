using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharToAscii
{
    public partial class MainForm : Form
    {
        //>>>>>>>>>>>>>>>>Constructor<<<<<<<<<<<<<<<<<
        public MainForm()
        {
            InitializeComponent();
        }
        //>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<

        // Events

        private void MainForm_Load(object sender, EventArgs e)
        {
            string theme = Properties.Settings.Default.Theme;

            if (theme.Equals("Light"))
            {
                LightRadioButton.Checked = true;
            }
            else if (theme.Equals("Dark"))
            {
                DarkRadioButton.Checked = true;
            }
        }

        private void LightRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (LightRadioButton.Checked)
            {
                themeChange(Theme.Light);
            }
        }

        private void DarkRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (DarkRadioButton.Checked)
            {
                themeChange(Theme.Dark);
            }
        }

        private void CharacterTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CharacterTextBox.Text == String.Empty) return;

            CharacterTextBox.Select(0, 1);

            AsciiCodeLabel.Text = ((int)CharacterTextBox.Text[0]).ToString();
        }

        // Methods

        private void themeChange(Theme theme)
        {
            if (theme == Theme.Dark)
            {
                this.BackColor = Color.Black;
                LightRadioButton.ForeColor = Color.Snow;
                DarkRadioButton.ForeColor = Color.Snow;
                AsciiCodeLabel.ForeColor = Color.Snow;

                CharacterTextBox.BackColor = Color.DarkSlateGray;
                CharacterTextBox.ForeColor = Color.Snow;

            }
            else if (theme == Theme.Light)
            {
                this.BackColor = Color.White;
                LightRadioButton.ForeColor = Color.Black;
                DarkRadioButton.ForeColor = Color.Black;
                AsciiCodeLabel.ForeColor = Color.Black;

                CharacterTextBox.BackColor = Color.White;
                CharacterTextBox.ForeColor = Color.Black;

            }

            Properties.Settings.Default.Theme = theme.ToString();
            Properties.Settings.Default.Save();
        }

    }
}
