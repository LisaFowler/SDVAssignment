using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SandwichWinForm
{
    public static class ServiceClient
    {
        internal async static Task<List<string>> GetChefNamesAsync()
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<List<string>>
                    (await lcHttpClient.GetStringAsync("http://localhost:60064/api/Sandwich/GetChefNames/"));
        }

        internal async static Task<clsChef> GetChefNamesAsync(string prChefName)
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<clsChef>
                    (await lcHttpClient.GetStringAsync("http://localhost:60064/api/Sandwich/GetChef?Name=" + prChefName));
                throw new NotImplementedException();
        }
    }
}
