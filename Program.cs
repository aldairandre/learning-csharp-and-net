﻿string sayHello = "Hello World";
Console.WriteLine($"{sayHello}");

sayHello = sayHello.Replace("Hello","Greeting");
Console.WriteLine(sayHello);
Console.WriteLine("");
Console.WriteLine("=== Upper and Lower ===");
Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower());