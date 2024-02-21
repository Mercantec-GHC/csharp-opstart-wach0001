Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration}");
}
if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day! Renew now and save 20%");
}
else if (daysUntilExpiration == 0)
{ Console.WriteLine("Your subscription has expired"); }
else { Console.WriteLine("NOTHING"); }


/*string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
fraudulentOrderIDs[3] = "D000";
*/
string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");


int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;
foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");


}
Console.WriteLine($"We have {sum} items in iventory.");


string[] orderID = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string order in orderID)
{
    if (order.StartsWith("B"))
    {
        Console.WriteLine(order);
    }
}