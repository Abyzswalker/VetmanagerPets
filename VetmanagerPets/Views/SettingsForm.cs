using System;
using System.Windows.Forms;
using VetmanagerPets.Controllers;

namespace VetmanagerPets
{
    public partial class SettingsForm : Form
    {
        private VMSettings vmSettings;
        private MainForm mainForm;
        private string domain;
        private string login;
        private string password;

        public SettingsForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            mainForm = (MainForm)Application.OpenForms["MainForm"];

            if (mainForm != null)
            {
                mainForm.Enabled = false;
            }

            vmSettings = new VMSettings();
                        
            if (vmSettings.Load())
            {
                domenField.Text = vmSettings.GetDomain();
                loginField.Text = vmSettings.GetLogin();
                passField.Text = vmSettings.GetPass();
            }

            FormClosing += new FormClosingEventHandler(SettingsForm_Closing);

            base.OnLoad(e);
        }

        private void SettingsForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];
            if (mainForm != null)
                mainForm.Enabled = true;
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            if (domain == null || login == null || password == null)
            {
                MessageBox.Show("Не все поля заполнены");
                return;
            }

            if (vmSettings.Save(domain, login, password))
            {
                СonnectionSuccessfulForm СonnectionSuccessfulForm = new СonnectionSuccessfulForm();
                СonnectionSuccessfulForm.Show();
            } else
                MessageBox.Show("Проверьте правильность ввода данных");
        }

        private void domenField_TextChanged(object sender, EventArgs e)
        {
            domain = domenField.Text;
        }

        private void loginField_TextChanged(object sender, EventArgs e)
        {
            login = loginField.Text;
        }

        private void passField_TextChanged(object sender, EventArgs e)
        {
            password = passField.Text;
        }

        private void CloseSettingsFormBtn_Click(object sender, EventArgs e)
        {
            mainForm.Enabled = true;
            Close();
        }
    }
}
