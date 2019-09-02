using System;
using System.Collections.Generic;
using System.Text;
using PetShopProject.Core.Entity;

namespace PetShopProject.Infrastructure.Static.Data
{
    public class FakeDB
    {
        public static IEnumerable<Pet> Pets;
        public List<Pet> PetList { get; set; }

        public FakeDB()
        {
            PetList = InitData();
        }

        public static List<Pet> InitData()
        {
            List<Pet> PetData = new List<Pet>();
            var pet1 = new Pet
            {
                PetId  = 1,
                PetName  = "PetName_1",
                PetType  = Pet.Type.dog,
                Birthdate = DateTime.Today,
                SoldDate = DateTime.Now,
                Color = "Green",
                PreviousOwner = "Pre-Owner_1",
                PriceDkk  = 100.00
            };
            PetData.Add(pet1);

            var pet2 = new Pet
            {
                PetId = 2,
                PetName = "PetName_2",
                PetType = Pet.Type.dog,
                Birthdate = DateTime.Today,
                SoldDate = DateTime.Now,
                Color = "Green",
                PreviousOwner = "Pre-Owner_1",
                PriceDkk = 100.00
            };
            PetData.Add(pet2);
            

            var pet3 = new Pet
            {
                PetId = 3,
                PetName = "PetName_3",
                PetType = Pet.Type.cat,
                Birthdate = DateTime.Today,
                SoldDate = DateTime.Now,
                Color = "Green",
                PreviousOwner = "Pre-Owner_1",
                PriceDkk = 100.00
            };
    
           

            return PetData;
        }
    }
}

