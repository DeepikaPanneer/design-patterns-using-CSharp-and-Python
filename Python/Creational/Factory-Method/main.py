"""
Factory Method Design Pattern
Provides an interface for creating objects without specifying their exact classes.
"""

# Normal Idea (or) Brute Force Approach (or) Wihtout Factory Method
# from Car import Car
# from Bike import Bike

# if __name__ == "__main__":
#     VehicleType = input("Enter the type of vehicle you want to create (Car/Bike): ")
#     if VehicleType == "Car":
#         vehicle = Car()
#     elif VehicleType == "Bike":
#         vehicle = Bike()
#     else:
#         print("Invalid vehicle type")
#         exit(1)
        
#     vehicle.CreateVehicle()

# In the above method, if Cleint wants to add more vehicle type to this vehicle library he has to 
# import all those vehicle types in the main.py and also handle those in the if else block. 
# This is not a good approach as it violates the Open/Closed Principle which states that software entities (classes, modules, functions, etc.) should be open for extension but closed for modification.
# So, to overcome this problem we can use Factory Method Design Pattern which allows us to create


# In factory method, we create a separate class called Factory which will be responsible for creating the objects of the vehicle types.

from VehicleFactory import VehicleFactory

if __name__ == "__main__":
    VehicleType = input("Enter the type of vehicle you want to create (Car/Bike): ")
    vehicle = VehicleFactory.getVehicle(VehicleType)
    vehicle.CreateVehicle()
    
# Here this main method is completely decoupled from object creation logic. 
# So, if client wants to add more vehicle type to this vehicle library he just has to add that new vehicle type class and handle that in the getVehicle method of the VehicleFactory class. 
# This way we can add new vehicle types without modifying the main method which is a good approach as it follows the Open/Closed Principle.