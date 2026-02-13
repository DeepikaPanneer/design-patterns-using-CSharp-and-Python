using System;

namespace FactoryMethod;

// The only purspose of this class is to get the vehicle class object (Car/Bike) based on the input string.
// So we are keeping the getVehicle method as static method so that we can call it without creating the object of the VehicleFactory class.

public class VehicleFactory
{
    public static Vehicle getVehicle(string VehicleType)
    {
        Vehicle vehicle;
        if (VehicleType == "Car")
        {
            vehicle = new Car();
        }
        else if (VehicleType == "Bike")
        {
            vehicle = new Bike();
        }
        else
        {
            Console.WriteLine("Invalid Vehicle Type");
            return null;
        }
        return vehicle;
    }
}
