using System;

namespace FactoryMethod;

public class Bike : Vehicle
{
    public override void CreateVehicle()
    {
        Console.WriteLine("Bike Created");
    }
}
