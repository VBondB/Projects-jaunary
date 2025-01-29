Console.OutputEncoding = System.Text.Encoding.Unicode;

Console.WriteLine("Введіть номер 1-го замовлення: ");
string order = Console.ReadLine();

Console.WriteLine("Введіть ім'я клієнта: ");
string client = Console.ReadLine();

Console.WriteLine("Введіть назву продукту: ");
string product = Console.ReadLine();

Console.WriteLine("Введіть ціну продукту в (EUR): ");
decimal price = decimal.Parse(Console.ReadLine());

Console.WriteLine("Введіть адресу магазину: ");
string address = Console.ReadLine();

Console.WriteLine($"---------------------");
Console.WriteLine($"Order: {order}");
Console.WriteLine($"Client: {client}");
Console.WriteLine($"Product: {product}, price: {price} EUR");
Console.WriteLine($"Adress: {address}");
Console.WriteLine($"---------------------");

Console.WriteLine("Введіть номер 2-го замовлення: ");
string order2 = Console.ReadLine();

Console.WriteLine("Введіть ім'я клієнта: ");
string client2 = Console.ReadLine();

Console.WriteLine("Введіть назву продукту: ");
string product2 = Console.ReadLine();

Console.WriteLine("Введіть ціну продукту в (EUR): ");
decimal price2 = decimal.Parse(Console.ReadLine());

Console.WriteLine("Введіть адресу магазину: ");
string address2 = Console.ReadLine();

Console.WriteLine($"---------------------");
Console.WriteLine($"Order: {order2}");
Console.WriteLine($"Client: {client2}");
Console.WriteLine($"Product: {product2}, Price: {price2} EUR");
Console.WriteLine($"Adress: {address2}");
Console.WriteLine($"---------------------");

Console.WriteLine("Введіть номер 3-го замовлення: ");
string order3 = Console.ReadLine();

Console.WriteLine("Введіть ім'я клієнта: ");
string client3 = Console.ReadLine();

Console.WriteLine("Введіть назву продукту: ");
string product3 = Console.ReadLine();

Console.WriteLine("Введіть ціну продукту в (EUR): ");
decimal price3 = decimal.Parse(Console.ReadLine());

Console.WriteLine("Введіть адресу магазину: ");
string address3 = Console.ReadLine();

Console.WriteLine($"---------------------");
Console.WriteLine($"Order: {order3}");
Console.WriteLine($"Client: {client3}");
Console.WriteLine($"Product: {product3}, Price: {price3} EUR");
Console.WriteLine($"Adress: {address3}");
Console.WriteLine($"---------------------");