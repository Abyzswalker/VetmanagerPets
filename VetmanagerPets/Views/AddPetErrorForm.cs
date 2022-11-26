using System;
using System.Windows.Forms;

namespace VetmanagerPets.Views
{
    public partial class AddPetErrorForm : Form
    {
        public AddPetErrorForm()
        {
            InitializeComponent();
        }

        private void AddPetErrorBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
