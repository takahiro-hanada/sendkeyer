using System;
using System.Linq;
using System.Windows.Forms;
using Sendkeyer.Properties;

namespace Sendkeyer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            ClientSize = Settings.Default.MainForm_ClientSize;

            _appsCombo.Items.AddRange(Settings.Default.Apps);

            _linesList.Items.AddRange(Settings.Default.Lines);

            _appsCombo.Text = Settings.Default.Apps.FirstOrDefault();

            _lineBox.Text = Settings.Default.Lines.FirstOrDefault();
        }

        void _linesList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var selectedLine = (string)_linesList.SelectedItem;

            if (selectedLine != null)
            {
                _lineBox.Text = selectedLine;

                _sendButton.PerformClick();
            }
        }

        void _sendButton_Click(object sender, EventArgs e)
        {
            var app = _appsCombo.Text;
            var line = _lineBox.Text;

            try
            {
                Microsoft.VisualBasic.Interaction.AppActivate(app);
            }
            catch(ArgumentException)
            {
                _errorProvider.SetError(_appsCombo, "Activation Failed.");

                return;
            }

            _errorProvider.SetError(_appsCombo, null);

            SendKeys.Send(line +( _appendNewLineCheck.Checked ? "~" :""));

            var apps = _appsCombo.Items.Cast<string>().ToList();
            apps.Remove(app);
            apps.Insert(0, app);

            _appsCombo.Items.Clear();
            _appsCombo.Items.AddRange(apps.ToArray());

            var lines = _linesList.Items.Cast<string>().ToList();
            lines.Remove(line);
            lines.Insert(0, line);

            _linesList.Items.Clear();
            _linesList.Items.AddRange(lines.ToArray());
        }

        void _LocationChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                Settings.Default.MainForm_Location = Location;
            }
        }

        void _ClientSizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                Settings.Default.MainForm_ClientSize = ClientSize;
            }

            if (IsHandleCreated && WindowState != FormWindowState.Minimized)
            {
                Settings.Default.MainForm_WindowState = WindowState;
            }
        }

        void _FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Apps = _appsCombo.Items.Cast<string>().ToArray();
            Settings.Default.Lines = _linesList.Items.Cast<string>().ToArray();
            Settings.Default.Save();
        }

        void _resetLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _appsCombo.Items.Clear();

            _linesList.Items.Clear();
        }
    }
}
