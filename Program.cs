string name;
int yearBirth;

static string Greeting(string name,int yearBirth){
  Console.Clear();
  Console.WriteLine();
  return $"Hello, {name} and you're {2023 - yearBirth} years old";
}

Console.WriteLine();
Console.Write("What is your name: ");
name = Console.ReadLine();
Console.WriteLine();
Console.Write("What year were you born: ");
yearBirth = int.Parse(Console.ReadLine());
Console.WriteLine(Greeting(name,yearBirth));
Console.WriteLine();