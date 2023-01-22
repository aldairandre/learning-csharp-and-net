namespace Test 
{
  class Program
  {
    static void Main(string[] args)
    {
      
      Car ford = new Car("Mustang","Yellow",1969);

      Car opel = new Car("Astra","Black",2005);

      Console.WriteLine();
      Console.WriteLine("=== CARS IN DB ===");
      Console.WriteLine(ford.model);
      Console.WriteLine(opel.model);
      Console.WriteLine();
    }
  }
}