using Newtonsoft.Json;
using System;

class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
}

class Program
{
    static void Main()
    {
        Car car = new Car
        {
            Brand = "Toyota",
            Model = "Corolla",
            Year = 2022
        };

        string jsonString = JsonConvert.SerializeObject(car, Formatting.Indented);
        Console.WriteLine(jsonString);
    }
}
