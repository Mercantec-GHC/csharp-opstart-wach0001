// See https://aka.ms/new-console-template for more information
Console.Write("Congratulations!");
Console.Write(" ");
Console.Write("You wrote your first lines of code.");
Console.WriteLine(" ");
Console.WriteLine("This is the first line.");
Console.WriteLine("This is the second line");

Console.WriteLine('b');
//Console.Write('Hello World!');
Console.WriteLine(123);
Console.WriteLine(0.25F);
Console.WriteLine(2.625);
Console.WriteLine(12.39816m);
Console.WriteLine(true);
Console.WriteLine(false);
Console.WriteLine("123");
Console.WriteLine(123);

Console.WriteLine("true");
Console.WriteLine(true);

string firstName1 = "Bob";
Console.WriteLine(firstName1);
firstName1 = "Yasmin";
Console.WriteLine(firstName1);


string firstName = "Bob";
int messNumber = 3;
double dobDeci = 34.4;

Console.Write($"Hello {firstName} you have {messNumber} messages in your inbox. The temperature is {dobDeci}");

Console.WriteLine("Generating invoices for costumer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.Write(@"c:\invoices");

// To generate Japanese invoices: 
//Nihon no seikyu-sho o seisei suru ni wa: 
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306f\uff1a\n\t");
// User command to run an application 
Console.WriteLine(@"c:\invoices\app.exe -j");


string firstName2 = "Bob";
string greeting = "Hello";
 Console.Write(greeting + " " + firstName2 + "!");


string firstName3 = "Bob";
string message = $"Hello {firstName3}!";
Console.WriteLine(message);


int version = 11;
string updateText = "Update to Windows";
Console.WriteLine($"{updateText} {version}!");



string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");

string projectName1 = "ACME";
string englishLocation = $@"c:\Exercise\{projectName1}\data.txt";
Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
string russianLocation = $@"c:\Exercise\{projectName1}\ru-RU\data.txt";
Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");





string firstName5 = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName5 + " sold " + (widgetsSold + 7) + " widgets.");

int sum = 7 + 5; 
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5; 

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference); 
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);

decimal decimalQuotient = 7.0m / 5; 
Console.WriteLine($"Decimal quotient: {decimalQuotient}");

decimal decimalQuotient1 = 7 / 5.0m;
decimal decimalQuotient2 = 7.0m / 5.0m;


int first = 7;
int second = 5; 
decimal quotient1 = (decimal)first / (decimal)second;
Console.WriteLine(quotient1);


Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5; 
Console.WriteLine(value1);
Console.WriteLine(value2);


int value3 = 1; 
value3 = value3 + 1;
Console.WriteLine("First increment: " + value3);

value3 += 1;
Console.WriteLine("Second icrement: " + value3);

value3++;
Console.WriteLine("Third increment: " + value3);

value3 = value3 - 1;
Console.WriteLine("First decrement: " + value3);

value3--; 
Console.WriteLine("Third decrement: " + value3);

int value4 = 1; 
value4++;
Console.WriteLine("First: " + value4);
Console.WriteLine($"Second: {value4++}");
Console.WriteLine("Third: " + value4);
Console.WriteLine("Fourth: " + (++value4));


int fahrenheit = 94;

decimal convert1 = (fahrenheit - 32m) * (5m / 9m);
Console.WriteLine(convert1);










