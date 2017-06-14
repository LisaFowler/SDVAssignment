using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandwichSelfhost
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
    }
}
