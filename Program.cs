Console.WriteLine("");
Console.WriteLine("======== What is your age? ========");
Console.WriteLine("");
Console.Write("What is your name: ");
string name = Console.ReadLine();
Console.WriteLine("");
Console.Write("What's year were you born: ");
int year = int.Parse(Console.ReadLine());
int age = 2023 - year;
Console.Clear();
Console.WriteLine("");
Console.WriteLine($"Hellow {name}, your are {age}");
Console.WriteLine("");