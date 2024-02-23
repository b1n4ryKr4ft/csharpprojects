using System.Globalization;

CultureInfo.CurrentCulture = new CultureInfo("en-ZA");

/*decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");

decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N2} units");

decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");


decimal price = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price).Replace(",",".");

yourDiscount += $"A discount of {((price - salePrice)/price):P2}!".Replace(",","."); //inserted
Console.WriteLine(yourDiscount);
*/

int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"   Shares: {productShares:N3} Product".Replace(",", "."));
Console.WriteLine($"     Sub Total: {subtotal:C}".Replace(",", "."));
Console.WriteLine($"           Tax: {taxPercentage:P2}".Replace(",", "."));
Console.WriteLine($"     Total Billed: {total:C}".Replace(",", "."));