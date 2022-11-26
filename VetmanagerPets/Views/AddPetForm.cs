using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VetmanagerPets.Controllers;

namespace VetmanagerPets.Views
{
    public partial class AddPetForm : Form
    {
        private VMSettings vmSettings;
        private uint clientId;
        private string petAlias;
        private uint petTypeId;
        private uint petBreadId;
        private string petSex = "";
        private string petBirthday = "";   
        
        public AddPetForm(uint clientId)
        {
            InitializeComponent();
            this.clientId = clientId;
        }

        protected override void OnLoad(EventArgs e)
        {
            MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];
            if (mainForm != null)
                mainForm.Enabled = false;

            petBreedComboBox.Enabled = false;
            savePetBtn.Enabled = false;

            vmSettings = new VMSettings();
                              
            if (vmSettings.Load())
            {
                PetType petType = new PetType();

                if (petType.GetAll() != null)
                {
                    petTypeComboBox.DataSource = petType.GetAll();
                    petTypeComboBox.DisplayMember = "title";
                    petTypeComboBox.ValueMember = "id";
                    petTypeComboBox.SelectedIndex = -1;
                    petTypeComboBox.SelectedIndexChanged += petTypeComboBox_SelectedIndexChanged;
                }

                petSexComboBox.DataSource = new BindingSource(new PetGender().GetAllPetsGender(), null);
                petSexComboBox.DisplayMember = "Value";
                petSexComboBox.ValueMember = "Key";
                petSexComboBox.SelectedIndex = -1;
                petSexComboBox.SelectedIndexChanged += petSexComboBox_SelectedIndexChanged;


                birthdayDateTimePicker.CustomFormat = " ";
                birthdayDateTimePicker.Format = DateTimePickerFormat.Custom;
                birthdayDateTimePicker.ValueChanged += birthdayDateTimePicker_ValueChanged;
            }

            FormClosing += new FormClosingEventHandler(AddPetForm_Closing);

            base.OnLoad(e);
        }

        private void AddPetForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];
            if (mainForm != null)
                mainForm.Enabled = true;
        }

        private void savePetBtn_Click(object sender, EventArgs e)
        {
            Pet pet = new Pet();

            if (petTypeComboBox.SelectedIndex < 0 || petBreedComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Не все обязательные поля заполнены");
                return;
            }
                
            if (pet.Add(clientId, petAlias, petTypeId, petBreadId, petSex, petBirthday))
            {
                MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];
                mainForm.tc.UpdateGrid(clientId);

                Close();
            }
            else
            {
                AddPetErrorForm errorForm = new AddPetErrorForm();
                errorForm.Show();
            }
        }
        private void petAliasTextBox_TextChanged(object sender, EventArgs e)
        {            
            petAlias = petAliasTextBox.Text;

            if (petAlias.Length == 0) savePetBtn.Enabled = false;
            else savePetBtn.Enabled = true;            
        }

        private void petTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (petTypeComboBox.SelectedIndex != -1)
            {
                PetTypeModel petType = (PetTypeModel)petTypeComboBox.SelectedItem;
                petTypeId = petType.id;

                PetBread petBread = new PetBread();

                if (petBread != null && petTypeId > 0)
                {
                    petBreedComboBox.DataSource = petBread.GetForType(petTypeId);
                    petBreedComboBox.DisplayMember = "title";
                    petBreedComboBox.ValueMember = "id";
                    petBreedComboBox.SelectedIndex = -1;

                    petBreedComboBox.SelectedIndexChanged += petBreedComboBox_SelectedIndexChanged;

                    petBreedComboBox.Enabled = true;
                }
            }
        }

        private void petBreedComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (petBreedComboBox.SelectedIndex != -1)
            {
                PetBreadModel petBreed = (PetBreadModel)petBreedComboBox.SelectedItem;
                petBreadId = petBreed.id;
            }
        }

        private void petSexComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (petSexComboBox.SelectedIndex != -1)
            {
                petSex = ((KeyValuePair<string, string>)petSexComboBox.SelectedItem).Value;
            }
        }

        private void birthdayDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            birthdayDateTimePicker.CustomFormat = "yyyy-MM-dd";

            petBirthday = birthdayDateTimePicker.Text;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
