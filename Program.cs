Console.WriteLine("");
Console.Write("Digite um numero: ");
int numberT =  int.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("=== TABUADA ===");
for(var n = 1; n <= 12 ; n++) {
  Console.WriteLine($"{numberT} X {n} =  {numberT * n}");
}