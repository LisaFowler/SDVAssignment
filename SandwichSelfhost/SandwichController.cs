using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandwichSelfHost
{
    public class SandwichController : System.Web.Http.ApiController

    {
        public List<string> GetChefNames()
        {
            DataTable lcResult = clsDbConnection.GetDataTable("SELECT ChefName FROM Chef", null);
            List<string> lcChefNames = new List<string>();
            foreach (DataRow dr in lcResult.Rows)
                lcChefNames.Add((string)dr[0]);
            return lcChefNames;
        }

        public List<clsChef> GetChef() 
        {
            DataTable lcResult = clsDbConnection.GetDataTable("SELECT * FROM Chef", null);
            List<clsChef> lcChef = new List<clsChef>();
            foreach (DataRow dr in lcResult.Rows)
            {
                lcChef.Add(new clsChef()
                {
                    ChefName = (string)dr["ChefName"],
                    Specialty = (string)dr["specialty"]
                });
            }
            return lcChef;
        }

        public clsChef GetChef(string ChefName)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(1);
            par.Add("ChefName", ChefName);
            DataTable lcResult =
                clsDbConnection.GetDataTable("SELECT * FROM Chef WHERE ChefName = @ChefName", par);
            if (lcResult.Rows.Count > 0)
                return new clsChef()
                {
                    ChefName = (string)lcResult.Rows[0]["ChefName"],                    
                    Specialty = (string)lcResult.Rows[0]["Specialty"],
                    SandwichList = getChefSandwiches(ChefName)        
                    
                };
            else
                return null;
        }

        private List<clsAllSandwiches> getChefSandwiches(string SandwichName)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(1);
            par.Add("SandwichName", SandwichName);
            DataTable lcResult = clsDbConnection.GetDataTable("SELECT * FROM Sandwich WHERE SandwichName = @SandwichName", par);
            List<clsAllSandwiches> lcSandwich = new List<clsAllSandwiches>();
            foreach (DataRow dr in lcResult.Rows)
                lcSandwich.Add(dataRow2AllSandwiches(dr));
            return lcSandwich; 
        }

        private clsAllSandwiches dataRow2AllSandwiches(DataRow dr)
        {
            return new clsAllSandwiches()
            {
                SandwichName = Convert.ToString(dr["SandwichName"]),
                Filling = Convert.ToString(dr["Filling"]),
                Filling2 = Convert.ToString(dr["Filling2"]),
                Filling3 = Convert.ToString(dr["Filling3"]),
                Sauce = Convert.ToString(dr["Sauce"]),
                Type = Convert.ToString(dr["Type"]),
                Price = Convert.ToDecimal(dr["Price"]),
                Quantity = Convert.ToInt16(dr["Quantity"]),
                ChefName = Convert.ToString(dr["ChefName"]),
            };
        }

        public string PutChef(clsChef prChef)
        {   
            try
            {
                int lcRecCount = clsDbConnection.Execute(
                        "UPDATE Chef SET Specialty = @Specialty WHERE ChefName = @ChefName",
                        prepareChefParameters(prChef));
                if (lcRecCount == 1)
                    return "Chef updated";
                else
                    return "Unexpected Chef update count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }


        public string PostChef(clsChef prChef)
        {
            try
            {
                int lcRecCount = clsDbConnection.Execute(
                    "INSERT INTO Chef (ChefName, Specialty) VALUES (@ChefName, @Specialty)",
                    prepareChefParameters(prChef));
                if (lcRecCount == 1)
                    return "Chef Added";
                else
                    return "Unexpected Chef insert count";
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }

        private static Dictionary<string, object> prepareChefParameters(clsChef prChef)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(2);            
            par.Add("ChefName", prChef.ChefName);
            par.Add("Specialty", prChef.Specialty);
            return par;
        }

    }

}
