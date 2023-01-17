// C# Type Casting
/*
  Type casting is when you assign a value of one data type to another type.

    In C#, there are two types of casting:

    Implicit Casting (automatically) - converting a smaller type to a larger type size
    char -> int -> long -> float -> double

    Explicit Casting (manually) - converting a larger type to a smaller size type
    double -> float -> long -> int -> char

*/

// Implicit casting is done automatically when passing a smaller size type to a larger size type:

int myInt = 9;
double myDouble = (double) myInt;
string myString =  Convert.ToString(myInt);

char firstLettarName = 'A';
int firstLettarNameC = firstLettarName; 
firstLettarName = (char) firstLettarNameC;

Console.WriteLine();
Console.WriteLine("========= CHAR TO INT ===========");
Console.WriteLine($"{firstLettarName}\n{firstLettarNameC}");
Console.WriteLine("========= INT TO DOUBLE ===========");
Console.Write($"{myInt}\n{myDouble}");
Console.WriteLine();
Console.WriteLine("========= INT TO STRING ===========");
Console.Write($"{myInt+2}\n{myString+2}");
Console.WriteLine();