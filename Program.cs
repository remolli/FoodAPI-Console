using FoodAPI_Console;

const string apiKey = "3a422ff82d024ed489e4d0b9ca4bcb59";

FoodAPI api = new FoodAPI(apiKey);

while(true)
{
    Console.Write("Escreva o nome de um produto: ");
    string query = Console.ReadLine();

    var search = await api.GetSearchGroceryProducts(query);

    foreach (var item in search.Products)
    {
        Console.WriteLine(item.Id);
        Console.WriteLine(item.Title);
        Console.WriteLine(item.ImageType);
        Console.WriteLine(new string('-', 30));
    }
    Console.WriteLine();
}