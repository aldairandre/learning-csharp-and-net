namespace Test 
{
  class Program
  {
    static void Main(string[] args)
    {
      
      Car ford = new Car();
      ford.model = "Mustabg";
      ford.color = "Yellow";
      ford.year = 1969;

      Car opel = new Car();
      opel.model = "Astra";
      opel.color = "Black";
      opel.year = 2005;

      Console.WriteLine();
      Console.WriteLine("=== CARS IN DB ===");
      Console.WriteLine(ford.color);
      Console.WriteLine(opel.color);
      Console.WriteLine();
    }
  }
}