using System;
using System.Collections.Generic;

//Developed by Lisa Fowler using code originally developed by Matthias Otto

namespace SandwichSelfHost
{
    public class clsChef
    {
        public string ChefName { get; set; }
        public string Specialty { get; set; }

        public List<clsAllSandwiches> SandwichList { get; set; }

        public override string ToString()
        {
            return ChefName;
        }

    }

    public class clsAllSandwiches
    {
        public string SandwichName { get; set; }
        public string Filling { get; set; }
        public string Filling2 { get; set; }
        public string Filling3 { get; set; }
        public string Sauce { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string ChefName { get; set; }

        public override string ToString()
        {
            return SandwichName;
        }

        public static readonly string FACTORY_PROMPT = "Enter V for Vegetarian or S for Spicy";

        //public static clsAllSandwiches AddNewSandwich(char prChoice) 
        // {
        //return new clsAllSandwiches() { Type = char.ToUpper(prChoice) };
        //}
    }

    public class clsOrder
    {
        public int OrderID { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderTime { get; set; }
        public int OrderQuantity { get; set; }
        public int OrderPrice { get; set; }

        public override string ToString()
        {
            return OrderID + "\t";
        }
    }


}

