using System;
using System.Collections.Generic;
using System.Text;

namespace PetBuySell.DataModels
{
    internal class Pet
    {
        public string Name { get; }
        public string Description { get; }
        public string Price { get; }
        public string Locality { get; }
        public string Image { get; }

        public Pet(string petName, string petDescription, string petPrice, string petLocality, string petImage)
        {
            Name = petName;
            Price = petPrice;
            Description = petDescription;
            Locality = petLocality;
            Image = petImage;
        }
    
    }
}
