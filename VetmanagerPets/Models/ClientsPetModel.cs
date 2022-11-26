using System;
using System.Collections.Generic;

namespace VetmanagerPets.Models
{
    public class ClientsPetModel
    {
        public uint id { get; set; }
        public uint owner_id { get; set; }
        public string type { get; set; }
        public string alias { get; set; }
        public string sex { get; set; }
        public string birthday { get; set; }
        public string breed { get; set; }

        public static implicit operator List<object>(ClientsPetModel v)
        {
            throw new NotImplementedException();
        }
    }
}
