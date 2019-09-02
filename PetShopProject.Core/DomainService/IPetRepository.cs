using System;
using System.Collections.Generic;
using System.Text;
using PetShopProject.Core.Entity;

namespace PetShopProject.Core.DomainService
{
    // crud

    public interface IPetRepository
    {
        Pet CreatePet(Pet pet);
        IEnumerable<Pet> ReadPets();

        Pet ReadById(int id);


        Pet UpdatePet(Pet petUpdate);

        Pet DeletePet(int id);
      

    }
}
