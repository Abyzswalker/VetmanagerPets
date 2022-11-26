using System;
using System.Windows.Forms;
using VetmanagerPets.Controllers;

namespace VetmanagerPets.Views
{
    public partial class DeleteForm : Form
    {
        private uint petId;
        private uint clientId;

        public DeleteForm(uint clientId, uint petId)
        {
            InitializeComponent();

            this.petId = petId;
            this.clientId = clientId;
        }

        protected override void OnLoad(EventArgs e)
        {
            MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];
            if (mainForm != null)
                mainForm.Enabled = false;            

            FormClosing += new FormClosingEventHandler(DeleteForm_Closing);

            base.OnLoad(e);
        }

        private void DeleteForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];
            if (mainForm != null)
                mainForm.Enabled = true;
        }

        private void confirmDeleteBtn_Click(object sender, EventArgs e)
        {
            Pet pet = new Pet();

            if (pet.Delete(petId))
            {
                MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];
                mainForm.tc.UpdateGrid(clientId);

                Close();
            }
        }

        private void cancelDeleteBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
