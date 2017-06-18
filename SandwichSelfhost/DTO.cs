using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandwichSelfHost
{
    public class clsChef
    {
        public string ChefName { get; set; }
        public string Specialty { get; set; }

        public List<clsAllSandwiches> SandwichList { get; set; }       

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
