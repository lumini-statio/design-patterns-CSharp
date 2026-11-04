// See https://aka.ms/new-console-template for more information
using decorator;

Console.WriteLine("Hello, World!");

NormalCoffee normalCoffee = new NormalCoffee();
Chocolate chocolate = new Chocolate(normalCoffee);
Cream cream = new Cream(normalCoffee);
Milk milk = new Milk(normalCoffee);

System.Console.WriteLine(milk.GetDescription());
System.Console.WriteLine(cream.GetDescription());
System.Console.WriteLine(chocolate.GetDescription());
