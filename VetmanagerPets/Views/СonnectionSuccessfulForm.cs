using System;
using System.Windows.Forms;

namespace VetmanagerPets
{
    public partial class СonnectionSuccessfulForm : Form
    {
        public СonnectionSuccessfulForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            SettingsForm settingsForm = (SettingsForm)Application.OpenForms["SettingsForm"];

            if (settingsForm != null)
            {
                settingsForm.Enabled = false;
            }

            base.OnLoad(e);
        }
        private void СonnectionSuccessfulBtn_Click(object sender, EventArgs e)
        {
            Close();

            Application.Restart();
            Environment.Exit(0);
        }
    }
}
