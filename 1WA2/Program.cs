// See https://aka.ms/new-console-template for more information
using _1WA2;

Car Car1 = new Car("Audi", 60, 10.0, 0.7);
Console.WriteLine(Car1);
Car1.CarDesc = "BWM";
Console.WriteLine(Car1.MaxRange);
Car1.Fuel = 1000;
Console.WriteLine(Car1.MaxRange);

Car1.Drive(100);

Console.WriteLine(Car1);

Car1.Drive(10000);
Console.WriteLine(Car1);

Car1.Drive(100);
Console.WriteLine(Car1);

Car1.Drive(-10000);
Console.WriteLine(Car1);