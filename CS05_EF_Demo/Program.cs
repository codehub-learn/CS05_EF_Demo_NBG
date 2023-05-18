// See https://aka.ms/new-console-template for more information

using CS05_EF_Demo;
using System.Collections.Generic;
// ReSharper disable ReplaceWithSingleCallToSingle

IEnumerable<string> products = Product.Products
    .Select(p => p.ToString().ToLower());

IEnumerable<string> productsQ = from p in Product.Products
                                select p.ToString().ToLower();

IEnumerable<decimal?> products2 = Product.Products
    .Select(p => p.Price);

IEnumerable<Product> products3 = Product.Products
    .Select(p => p);

IEnumerable<Product> products6 = Product.Products;

IEnumerable<Product> products7 = from p in Product.Products
                                 select p;

IEnumerable<string> productsEn = Product.Products
    .Select(p => p.ToString().ToLower());

List<string> productsEn2 = Product.Products
    .Select(p => p.ToString().ToLower())
    .ToList();

string[] productsEn3 = Product.Products
    .Select(p => p.ToString().ToLower())
    .ToArray();

List<string> newlist = products.ToList();

List<Product> products_NamePrice = 
    (Product.Products
    .Select(p => new Product() {Id = p.Id, Name = p.Name, Price = p.Price}))
    .ToList();

var Anonymous_NamePrice = Product.Products
    .Select(p=> new {Id = p.Id, Name = p.Name, Price = p.Price})
    .OrderBy(p => p.Name)
    .ToList();

var Anonymous_NamePrice2 = Product.Products
    .Select(p => new  {p.Id, p.Name, p.Price})
    .OrderByDescending(p => p.Price)
    .ThenByDescending(p => p.Name)
    .ThenBy(p => p.Id)
    .ToList();

var BlackProducts = Product.Products
    .Where(p => p.Color == "Black" && p.Price > 1000);

var BlackProductgsList = BlackProducts.ToList();

var uphonexblack = Product.Products
    .Where(p => p.Id == 1)
    .First();

try
{
    var black = Product.Products
        .Where(p => p.Color == "Black")
        .First();
}
catch (InvalidOperationException ex)
{
}

var black2 = Product.Products
    .Where(p => p.Color == "Black")
    .FirstOrDefault();

if (black2 is null)
{
}

var black3 = Product.Products
    .OrderBy(p => p.Price)
    .FirstOrDefault(p => p.Color == "Black");

//var black4 = Product.Products
//    .OrderBy(p => p.Price)
//    .SingleOrDefault(p => p.Color == "Black");

var black5= Product.Products
    .OrderBy(p => p.Price)
    .LastOrDefault(p => p.Color == "Black");

var take = Product.Products
    .Where(p => p.Color == "Blue")
    .OrderBy(p => p.Id)
    .Take(2)
    .ToList();

var skip = Product.Products
    .Where(p => p.Name == "uPhone X")
    .OrderBy(p => p.Id)
    .Skip(2)
    .ToList();

var colors = Product.Products.Select(p => p.Color).Distinct().ToList();

bool allStartWithU = Product.Products.All(p => p.Name.StartsWith("u"));
bool anyBlue = Product.Products.Any(p => p.Color == "Blue");

var GroupbyColor = Product.Products.GroupBy(p => p.Color);

foreach (var group in GroupbyColor)
{
    Console.WriteLine(group.Key); //Color
    foreach (var product in group)
    {
        Console.WriteLine(product.ToString());
    }
    Console.WriteLine($"End of color {group.Key}");
}

int ProductsCount = Product.Products.Count();

decimal? max = Product.Products.Max(p => p.Price);
decimal? min = Product.Products.Min(p => p.Price);
decimal? sum = Product.Products.Sum(p => p.Price);
decimal? avergage = Product.Products.Average(p => p.Price);

var maxpriceProduct = Product.Products
    .Where(p => 
        p.Price == Product.Products.Max(p2 => p2.Price));

Console.WriteLine("End of application");

List<char> chars = new() {'a', 'b', 'c'};
var charsQuery = chars.Select(c => c.ToString().ToUpper()).ToList();
chars.Remove('b');

foreach (string c in charsQuery)
{
    Console.WriteLine(c);
}

charsQuery.Add("e");
charsQuery.Add("f");

foreach (string c in charsQuery)
{
    Console.WriteLine(c);
}