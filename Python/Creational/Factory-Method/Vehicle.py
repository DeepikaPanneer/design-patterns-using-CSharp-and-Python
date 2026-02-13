from abc import ABC, abstractmethod

class Vehicle(ABC):
    @abstractmethod
    def CreateVehicle(self) -> None:
        pass