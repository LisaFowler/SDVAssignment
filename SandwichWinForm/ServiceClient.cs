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
                    (await lcHttpClient.GetStringAsync("http://localhost:60064/api/Sandwich/GetChef?ChefName=" + prChefName));
                throw new NotImplementedException();
        }
        
        internal async static Task<string> InsertChefAsync(clsChef _Chef)
        {
            return await InsertOrUpdateAsync(_Chef, "http://localhost:60064/api/Sandwich/PostChef", "POST");
        }

        internal async static Task<string> UpdateChefAsync(clsChef _Chef)
        {
            return await InsertOrUpdateAsync(_Chef, "http://localhost:60064/api/Sandwich/PutChef", "PUT");
        }

        private async static Task<string> InsertOrUpdateAsync<TItem>(TItem prItem, string prUrl, string prRequest)
        {
            using (HttpRequestMessage lcReqMessage = new HttpRequestMessage(new HttpMethod(prRequest), prUrl))
            using (lcReqMessage.Content =
                new StringContent(JsonConvert.SerializeObject(prItem), Encoding.Default, "application/json"))
            using (HttpClient lcHttpClient = new HttpClient())
            {
                HttpResponseMessage lcRespMessage = await lcHttpClient.SendAsync(lcReqMessage);
                return await lcRespMessage.Content.ReadAsStringAsync();
            }
        }

        internal static Task<string> DeleteSandwichAsync(clsAllSandwiches clsAllSandwiches)
        {
            throw new NotImplementedException();
        }
    }
}
