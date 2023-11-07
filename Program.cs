using DesignPatternFactory;
using DesignPatternFactory.Models;

//Mercedes araç nesnesi üret
var mercedes = CarFactory.CreateCar(Brand.MERCEDES, new Car { Color = "beyaz", Price = 34300 });

Console.WriteLine(mercedes.GetInfo());

Console.ReadLine();