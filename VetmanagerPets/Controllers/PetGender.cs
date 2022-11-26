using System.Collections.Generic;

namespace VetmanagerPets.Controllers
{
    public class PetGender
    {
        public string Get(string petsGender)
        {
            switch (petsGender)
            {
                case "male":
                    return "Самец";

                case "famale":
                    return "Самка";

                case "castrated":
                    return "Кастрирован";

                case "sterilized":
                    return "Стерилизована";
                default:
                    return "Неизвестно";
            }
        }

        public Dictionary<string, string> GetAllPetsGender()
        {
            return new Dictionary<string, string>()
            {
                {"male", "Самец"},
                {"famale", "Самка"},
                {"unknown", "Неизвестно"},
                {"castrated", "Кастрирован"},
                {"sterilized", "Стерилизована"},

            };
        }

        public int GetIndex(string petsGender)
        {
            switch (petsGender)
            {
                case "male":
                    return 0;

                case "famale":
                    return 1;

                case "castrated":
                    return 3;

                case "sterilized":
                    return 4;

                default:
                    return 2;
            }
        }
    }
}
