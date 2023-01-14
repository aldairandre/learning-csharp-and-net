double height;
string name;

Console.WriteLine("");
Console.WriteLine("======== CADAST FORM ========");
Console.WriteLine("");
Console.Write("What is your name: ");
name = Console.ReadLine();
Console.WriteLine("");
Console.Write("What is your Height: ");
height = double.Parse(Console.ReadLine());
Console.Clear();
Console.WriteLine("======== DATAS ========");
Console.WriteLine("");
Console.WriteLine($"Name: {name}");
Console.WriteLine($"Height: {height}");