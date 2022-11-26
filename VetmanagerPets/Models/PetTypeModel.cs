using System.Collections.Generic;
using System.Dynamic;

namespace VetmanagerPets
{
    public class PetTypeModel : DynamicObject
    {
        public uint id { get; set; }
        public string title { get; set; }
        public string picture { get; set; }
        public string type { get; set; }
        public List<PetBreadModel> breeds { get; set; }
    }
}
