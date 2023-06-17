using FoodAPI_Console;

const string apiKey = "3a422ff82d024ed489e4d0b9ca4bcb59";

FoodAPI api = new FoodAPI(apiKey);

while(true)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write("Escreva o nome de um produto: ");
    Console.ForegroundColor = ConsoleColor.Yellow;
    string query = Console.ReadLine();

    var search = await api.GetSearchGroceryProducts(query);

    foreach (var item in search.Products)
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Id: " + item.Id);
        Console.WriteLine("Title: " + item.Title);
        Console.WriteLine("Image Type: " + item.ImageType);
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine();
        Console.WriteLine(new string('-', 30));
    }

    Console.ResetColor();
    Console.WriteLine();
    Console.WriteLine("Total Products: " + search.TotalProducts);
    Console.WriteLine("Offset: " + search.Offset);
    Console.WriteLine("Number: " + search.Number);
    Console.WriteLine("Type: " + search.Type);

    Console.WriteLine();
}