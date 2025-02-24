using System;

class Car
{
    public string Name { get; set; }
    public virtual void ShowTransmission()
    {
        Console.WriteLine($"{Name} : Vites bilgisi belirtilmemiş.");
    }
}

class BMW : Car
{
    public BMW() { Name = "BMW"; }
    public override void ShowTransmission()
    {
        Console.WriteLine($"{Name} : Düz viteslidir.");
    }
}

class Porsche : Car
{
    public Porsche() { Name = "Porsche"; }
    public override void ShowTransmission()
    {
        Console.WriteLine($"{Name} : Otomatik viteslidir.");
    }
}

// Diğer araçlar:
class Mercedes : Car
{
    public Mercedes() { Name = "Mercedes"; }
    public override void ShowTransmission()
    {
        Console.WriteLine($"{Name} : Otomatik viteslidir.");
    }
}

class Togg : Car
{
    public Togg() { Name = "Togg"; }
    public override void ShowTransmission()
    {
        Console.WriteLine($"{Name} : Elektriklidir, tek viteslidir.");
    }
}

class Audi : Car
{
    public Audi() { Name = "Audi"; }
    public override void ShowTransmission()
    {
        Console.WriteLine($"{Name} : Otomatik viteslidir.");
    }
}

class Toyota : Car
{
    public Toyota() { Name = "Toyota"; }
    public override void ShowTransmission()
    {
        Console.WriteLine($"{Name} : Hem otomatik hem manuel vites seçenekleri vardır.");
    }
}

class Program
{
    static void Main()
    {
        Car[] cars = { new BMW(), new Porsche(), new Mercedes(), new Togg(), new Audi(), new Toyota() };

        foreach (var car in cars)
        {
            car.ShowTransmission();
        }
    }
}
