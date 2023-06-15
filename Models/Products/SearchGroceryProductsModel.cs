using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodAPI_Console.Models.Products
{
    public class SearchGroceryProductsModel
    {
        [JsonProperty("products")]
        public Product[] Products { get; set; }
        [JsonProperty("totalProducts")]
        public long TotalProducts { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("offset")]
        public long Offset { get; set; }
        [JsonProperty("number")]
        public long Number { get; set; }

        public class Product
        {
            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("imageType")]
            public string ImageType { get; set; }
        }
    }
}
