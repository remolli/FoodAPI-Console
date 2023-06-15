using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodAPI_Console.Models;
using Newtonsoft.Json;

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
        public async Task<Models.Products.SearchGroceryProductsModel> GetSearchGroceryProducts(string query)
        {
            var jsonString = await GetJsonString($"https://api.spoonacular.com/food/products/search?query={query}");
            Models.Products.SearchGroceryProductsModel searchResponse = JsonConvert.DeserializeObject<Models.Products.SearchGroceryProductsModel>(jsonString);
            return searchResponse;
        }
    }
}