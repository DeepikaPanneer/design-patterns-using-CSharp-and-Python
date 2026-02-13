using System;

namespace FactoryMethod;

public class Car : Vehicle
{
    public override void CreateVehicle()
    {
        Console.WriteLine("Car Created");
    }
}
