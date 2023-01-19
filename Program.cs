// Multidimensional Arrays
/*
  Two-Dimensional Arrays
    To create a 2D array, add each array within its own set of curly braces, and insert a comma (,) inside the square brackets:
*/
using System.Linq;
int[,] numbers = { {1,4,2},{3,6,8} };
Console.WriteLine();
Console.Write("Multidimensional Array -> [");
foreach(int num in numbers){
  Console.Write($"{num} ");
}
Console.Write("]");
Console.WriteLine();
numbers[0,1] = 10;
Console.WriteLine($"{numbers[0,1]}");
Console.WriteLine();