// System.Linq
using System.Linq;


int [] myNum = {20,10,30 ,60, 40};
Console.WriteLine();
Console.Write("Array -> [ ");
Array.Sort(myNum);
foreach(int num in myNum){
  Console.Write($"{num} ");
}
Console.Write("]");
Console.WriteLine();
Console.WriteLine($"Max value in array : {myNum.Max()}"); // returns the largest value
Console.WriteLine($"Min value in array : {myNum.Min()}"); // returns the smallest value
Console.WriteLine($"Sum : {myNum.Sum()}");               // returns the sum of elements
Console.WriteLine();