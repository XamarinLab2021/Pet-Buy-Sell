using PetBuySell.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetBuySell.Model
{
    internal class PetsList
    {
        public List<Pet> petsList = new List<Pet>();
        
        public void AddPet(Pet petObject)
        {
            petsList.Add(petObject);
        }

        public void RemovePet(Pet petObject)
        {
            petsList.Remove(petObject);
        }



    }
}
