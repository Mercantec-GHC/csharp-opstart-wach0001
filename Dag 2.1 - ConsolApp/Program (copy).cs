/* See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Random dice1 = new Random();
int roll = dice1.Next(1, 7);
Console.WriteLine(roll);

Random dice = new Random();
int roll1 = dice.Next();
int rolll2 = dice.Next(101);
int rolll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {rolll2}");
Console.WriteLine($"Third roll: {rolll3}");

int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue, secondValue);

Console.WriteLine(largerValue);

int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);
int roll4 = dice.Next(1, 7);

int total = roll2 + roll3 + roll4;

Console.WriteLine($"Dice roll: {roll2} + {roll3} + {roll4} = {total} ");


if (total > 14)
{
    Console.WriteLine("You win!");

}
if  (total < 15)
{
    Console.WriteLine("Sorry, you lose.");
}
if ((roll2 == roll3) && (roll3 == roll4)) {
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total += 6;
}
if ((roll2 == roll3) || (roll3 == roll4) || (roll2 == roll4)) {
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
}*/
