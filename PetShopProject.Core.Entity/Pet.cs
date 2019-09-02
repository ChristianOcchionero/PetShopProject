using System;

namespace PetShopProject.Core.Entity
{
    public class Pet    
    {
        public int PetId { get; set; }
        public String PetName { get; set; }
        public Type  PetType { get; set; }
        public DateTime Birthdate { get; set; }
        public DateTime SoldDate { get; set; }
        public String Color { get; set; }
        public String PreviousOwner { get; set; }
        public Double PriceDkk { get; set; }

        public enum Type
        {
            dog,cat,goat,
        }
        public override string ToString()
        {
            return "ID: " + PetId + ", Name: " + PetName  + ", Type: " + PetType + ", Color: " + Color + ", Date of Birth: " + Birthdate + ", Sold Date: " + SoldDate + ", Previous Owner: " + PreviousOwner + ", Price: " + PriceDkk+"dkk";
        }
    }
}

    

