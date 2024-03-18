using System;

class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public decimal Price { get; set; }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Model: {Model}, Year: {Year}, Price: {Price:C}");
    }
}

class BMW : Car
{
    public bool IsLuxury { get; set; }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Is Luxury: {IsLuxury}");
    }
}

class Ford : Car
{
    public string Color { get; set; }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Color: {Color}");
    }
}

class Program
{
    static void Main()
    {
        BMW bmwCar = new BMW
        {
            Brand = "BMW",
            Model = "X5",
            Year = 2022,
            Price = 80000,
            IsLuxury = true
        };

        Ford fordCar = new Ford
        {
            Brand = "Ford",
            Model = "Mustang",
            Year = 2020,
            Price = 50000,
            Color = "Red"
        };

        bmwCar.DisplayInfo();
        fordCar.DisplayInfo();
    }
}