using System;
using System.Collections.Generic;
using PetShopProject.Core.DomainService;
using PetShopProject.Core.Entity;

namespace PetShopProject.Infrastructure.Static.Data.Repositories
{
    public class PetRepository : IPetRepository
    {
        private FakeDB fakeDB;
        private int id;

        public PetRepository()
        {
            this.fakeDB = new FakeDB();
            this.id = fakeDB.PetList.Count + 1;
        }
        public IEnumerable<Pet> ReadPets()
        {
            return fakeDB.PetList;
        }

        public Pet ReadById(int id)
        {
            foreach (var pet in fakeDB.PetList)
            {
                if (pet.PetId.Equals(id))
                {
                    return pet;
                }
            }

            return null;

        }

        public Pet CreatePet(Pet pet)
        {
            pet.PetId  = id;
            fakeDB.PetList.Add(pet);
            id++;
            return pet;
        }

        public Pet UpdatePet(Pet petUpdate)
        {
            var currentPet = ReadById(petUpdate.PetId);
            if (currentPet != null)
            {
                currentPet.PetName  = petUpdate.PetName ;
                currentPet.PetType  = petUpdate.PetType ;
                currentPet.Birthdate = petUpdate.Birthdate;
                currentPet.SoldDate = petUpdate.SoldDate;
                currentPet.Color = petUpdate.Color;
                currentPet.PreviousOwner = petUpdate.PreviousOwner;
                currentPet.PriceDkk = petUpdate.PriceDkk;
                return currentPet;
            }

            return null;
        }

        public Pet DeletePet(int id)
        {
            Pet temPet = null;
            foreach (var pet in fakeDB.PetList)
            {
                if (pet.PetId == id)
                {
                    temPet = pet;
                }
            }

            fakeDB.PetList.Remove(temPet);
            return temPet;
        }

    }
}
