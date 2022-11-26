using System;
using System.Collections.Generic;
using System.Data;
using VetmanagerPets.Controllers;
using VetmanagerPets.Models;

namespace VetmanagerPets
{
    internal class TableCreator
    {
        private DataTable dt;

        public TableCreator()
        {
            dt = new DataTable();
        }

        public DataTable Create()
        {
            dt.Columns.Add("id", typeof(uint));
            dt.Columns.Add("#", typeof(uint));
            dt.Columns.Add("Кличка", typeof(string));
            dt.Columns.Add("Порода", typeof(string));
            dt.Columns.Add("Вид", typeof(string));
            dt.Columns.Add("Пол", typeof(string));
            dt.Columns.Add("День рождения", typeof(string));

            return dt;
        }

        private void Update(List<ClientsPetModel> petsList)
        {
            dt.Rows.Clear();

            for (int i = 0; i < petsList.Count; i++)
            {
                dt.Rows.Add(petsList[i].id, i + 1, petsList[i].alias, petsList[i].breed, petsList[i].type, petsList[i].sex, petsList[i].birthday);
            }
        }

        public DataTable UpdateGrid(uint clientId)
        {
            Pet pet = new Pet();
            List<ClientsPetModel> petsList = pet.GetPetsForClient(clientId);

            Update(petsList);

            return dt;
        }
    }
}
