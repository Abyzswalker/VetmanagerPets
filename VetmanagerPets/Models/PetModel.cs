using System;
using System.Collections.Generic;

namespace VetmanagerPets
{
    public class PetModel
    {
        public uint id { get; set; }
        public uint owner_id { get; set; }
        public uint type_id { get; set; }
        public string alias { get; set; }
        public string sex { get; set; }
        public string birthday { get; set; }
        public uint breed_id { get; set; }

        public static implicit operator List<object>(PetModel v)
        {
            throw new NotImplementedException();
        }
    }
}
