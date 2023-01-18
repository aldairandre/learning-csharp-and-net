Console.WriteLine();
Console.Write("Enter username: ");
string name = Console.ReadLine().Trim();
Console.Write("What Year you born: ");
int myYear = Convert.ToInt32(Console.ReadLine());
int age = 2023 - myYear;  
Console.WriteLine();
Console.WriteLine($"Hello, {name}, you're {age} year old ");
Console.WriteLine();