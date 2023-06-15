using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodAPI_Console.Models;

namespace FoodAPI_Console
{
    public class FoodAPI
    {
        HttpClient httpClient;
        string apiKey;
        public FoodAPI(string apiKey)
        {
            this.apiKey = apiKey;
            httpClient = new HttpClient();
        }
        public async Task<string> GetJsonString(string link)
        {
            var response = await httpClient.GetAsync(link + "&apiKey=" + apiKey);
            var jsonString = await response.Content.ReadAsStringAsync();
            return jsonString;
        }
    }
}