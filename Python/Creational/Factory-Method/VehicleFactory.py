from Car import Car
from Bike import Bike
from Vehicle import Vehicle


# The only purspose of this class is to get the vehicle class object (Car/Bike) based on the input string.
# So we are keeping the getVehicle method as static method so that we can call it without creating the object of the VehicleFactory class.

class VehicleFactory:
    @staticmethod
    def getVehicle(VehicleType: str) -> Vehicle:
        if VehicleType == "Car":
            vehicle = Car()
        elif VehicleType == "Bike":
            vehicle = Bike()
        else:
            print("Invalid vehicle type")
            exit(1)
        return vehicle