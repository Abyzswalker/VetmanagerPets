using System;
using System.Windows.Forms;
using VetmanagerPets.Views;
using VetmanagerPets.Controllers;

namespace VetmanagerPets
{
    internal partial class MainForm : Form
    {
        public TableCreator tc;

        private VMSettings vmSettings;
        private uint clientId;
        private uint petId;

        public MainForm()
        {
            InitializeComponent();
        }
               
        protected override void OnLoad(EventArgs e)
        {
            addPetBtn.Enabled = false;
            editPetBtn.Enabled = false;
            deletePetBtn.Enabled = false;

            tc = new TableCreator();
            petsDataGridView.DataSource = tc.Create();
            petsDataGridView.Columns[0].Visible = false;

            vmSettings = new VMSettings();

            if (vmSettings.Load())
            {
                Client client = new Client();

                clientsCombo.DataSource = client.GetAll();
                clientsCombo.DisplayMember = "full_name";
                clientsCombo.ValueMember = "id";
                clientsCombo.SelectedIndex = -1;

                clientsCombo.SelectedIndexChanged += clientsCombo_SelectedIndexChanged;
            }

            base.OnLoad(e);
        }         

        private void openSettingsBtn_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = (SettingsForm)Application.OpenForms["SettingsForm"];

            if (settingsForm == null)
            {
                SettingsForm settings = new SettingsForm();
                settings.Show();
            }
            else
                settingsForm.Activate();
        }

        private void clientsCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clientsCombo.SelectedIndex != -1)
            {
                ClientModel client = (ClientModel)clientsCombo.SelectedItem;
                clientId = client.id;

                petsDataGridView.DataSource = tc.UpdateGrid(clientId);

                addPetBtn.Enabled = true;
            }
        }

        private void addPetBtn_Click(object sender, EventArgs e)
        {            
            AddPetForm addPetForm = (AddPetForm)Application.OpenForms["AddPetForm"];

            if (addPetForm == null)
            {
                AddPetForm newAddPetForm = new AddPetForm(clientId);
                newAddPetForm.Show();
            }
            else
                addPetForm.Activate();            
        }

        private void petsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            editPetBtn.Enabled = true;
            deletePetBtn.Enabled = true;

            petId = Convert.ToUInt32(petsDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void editPetBtn_Click(object sender, EventArgs e)
        {
            EditPetForm editPetForm = (EditPetForm)Application.OpenForms["EditPetForm"];

            if (editPetForm == null)
            {
                EditPetForm newEditPetForm = new EditPetForm(clientId, petId);
                newEditPetForm.Show();
            }
            else
                editPetForm.Activate();
        }

        private void deletePetBtn_Click(object sender, EventArgs e)
        {
            DeleteForm delForm = (DeleteForm)Application.OpenForms["DeleteForm"];

            if (delForm == null)
            {
                DeleteForm newDelForm = new DeleteForm(clientId, petId);
                newDelForm.Show();
            }
            else
                delForm.Activate();
        }
    }
}
