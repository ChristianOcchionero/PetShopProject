using System;
using System.Collections.Generic;
using System.Text;
using PetShopProject.Core.Entity;

namespace PetShopProject.Core.ApplicationService
{
    public interface IPetService
    {
        //Gets and returns a list of all pets
        List<Pet> GetPets();

        //Gets and returns a list of pets of the given type
        List<Pet> GetPetsByType(Pet.Type type);

        //Creates a new pet
        Pet CreatePet(string name,
            Pet.Type type,
            DateTime birthday,
            DateTime solddate,
            string color,
            string previousowner,
            double price);

        //Gets the pet with the given id
        Pet ReadPetById(int id);

        //Deletes the pet with the given id
        Pet DeletePet(int id);

        //Updates a pet with the given id
        Pet UpdatePet(int id,
            string newName,
            Pet.Type newType,
            DateTime newBirthday,
            DateTime newSoldDate,
            string newColor,
            string newPreviousOwner,
            double newPrice);

        //returns a list of pets sorted by price(descending)
        List<Pet> SortPetsByPrice();

        //returns a list of the 5 cheapest pets available
        List<Pet> GetFiveCheapestPets();

        //Verifies the id, returns true if the ID exits and false otherwise.
        bool IdVerifier(int id);
    }
}