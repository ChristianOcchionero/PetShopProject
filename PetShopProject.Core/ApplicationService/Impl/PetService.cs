using System;
using System.Collections.Generic;
using System.Linq;
using PetShopProject.Core.DomainService;
using PetShopProject.Core.Entity;

namespace PetShopProject.Core.ApplicationService.Impl
{

    public class PetService : IPetService
    {
        private readonly IPetRepository _petRepo;

        public PetService(IPetRepository petRepository)
        {
            _petRepo = petRepository;
        }
        public List<Pet> GetPets()
        {
            List<Pet> listOfPets = _petRepo.ReadPets().ToList();

            return listOfPets;
        }

      
        public List<Pet> GetPetsByType(Pet.Type type)
        {
            List<Pet> temp = new List<Pet>();
            foreach (var pet in _petRepo.ReadPets().ToList())
            {
                if (pet.PetType.Equals(type))
                {
                    temp.Add(pet);
                }
            }

            return temp;
        }

        public Pet CreatePet(string name, Pet.Type type, DateTime birthday, DateTime solddate, string color, string previousowner,
            double price)
        {
            var NewPet = new Pet
            {
                PetName  = name,
                PetType  = type,
                Birthdate = birthday,
                SoldDate = solddate,
                Color = color,
                PreviousOwner = previousowner,
                PriceDkk  = price
            };

            return _petRepo.CreatePet(NewPet);
        }

        public Pet ReadPetById(int id)
        {
            return _petRepo.ReadById(id);
        }

        public Pet DeletePet(int id)
        {
            return _petRepo.DeletePet(id);
        }

        public Pet UpdatePet(int id, string newName, Pet.Type newType, DateTime newBirthday, DateTime newSoldDate, string newColor,
            string newPreviousOwner, double newPrice)
        {
            var NewPet = new Pet
            {
                PetId  = id,
                PetName  = newName,
                PetType  = newType,
                Birthdate = newBirthday,
                SoldDate = newSoldDate,
                Color = newColor,
                PreviousOwner = newPreviousOwner,
                PriceDkk  = newPrice
            };

            _petRepo.UpdatePet(NewPet);

            return NewPet;
        }

        public List<Pet> SortPetsByPrice()
        {
            List<Pet> SortedByPrice = _petRepo.ReadPets().ToList();
            SortedByPrice.Sort();
            return SortedByPrice;
        }

        public List<Pet> GetFiveCheapestPets()
        {
            List<Pet> tempPetList = new List<Pet>();
            int count = 0;
            foreach (var pet in SortPetsByPrice())
            {
                if (count < 5)
                {
                    tempPetList.Add(pet);
                    count++;
                }
            }

            return tempPetList;

        }

        public bool IdVerifier(int id)
        {
            if (id <= _petRepo.ReadPets().Count() && id >= 1)
            {
                return true;
            }

            return false;
        }
    }
}