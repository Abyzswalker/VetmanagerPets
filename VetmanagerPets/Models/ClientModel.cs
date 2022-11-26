using System;
using System.Collections.Generic;

namespace VetmanagerPets
{
    public class ClientModel
    {
        public uint id { get; set; }
        public string last_name { get; set; }
        public string first_name { get; set; }
        public string full_name { get; set; }

        public static implicit operator List<object>(ClientModel v)
        {
            throw new NotImplementedException();
        }
    }
}
