namespace Test 
{
  class Program
  {
    static void Main(string[] args)
    {
      
      Car myObj = new Car();
      myObj.color = "red";
      myObj.ChangeColor();
      Console.WriteLine(myObj.color);
    }
  }
}