
string command = string.Empty;

List<Product> products = new List<Product>();

while ((command = Console.ReadLine()) != "buy")
{
    string[] productInfo = command.Split();

    string productName = productInfo[0];
    decimal productPrice = decimal.Parse(productInfo[1]);
    int quantity = int.Parse(productInfo[2]);

    if (!products.Any(x => x.Name == productName))
    {
        Product product = new Product(productName, productPrice, quantity);
        products.Add(product);
    }
    else
    {
        foreach (var product in products)
        {
            if (product.Name == productName)
            {
                product.Quantity += quantity;

                if (product.Price != productPrice)
                {
                    product.Price = productPrice;
                }
            }
        }
    }
}

foreach (var product in products)
{
    Console.WriteLine($"{product.Name} -> {product.Price * product.Quantity:f2}");
}



public class Product
{
    public Product(string name, decimal price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    public string Name { get; set; }

    public decimal Price { get; set; }

    public int Quantity { get; set; }
}