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
            DataTable lcResult = clsDbConnection.GetDataTable("SELECT Name FROM Chef", null);
            List<string> lcChefNames = new List<string>();
            foreach (DataRow dr in lcResult.Rows)
                lcChefNames.Add((string)dr[0]);
            return lcChefNames;
        }

        public clsChef GetChef(string Name)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(1);
            par.Add("Name", Name);
            DataTable lcResult =
                clsDbConnection.GetDataTable("SELECT * FROM Chef WHERE Name = @Name", par);
            if (lcResult.Rows.Count > 0)
                return new clsChef()
                {
                    Name = (string)lcResult.Rows[0]["Name"],
                    Specialty = (string)lcResult.Rows[0]["Specialty"],
                    
                };
            else
                return null;
        }

    }

}
