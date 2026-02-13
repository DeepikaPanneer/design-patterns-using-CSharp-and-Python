"""
Abstract Factory Design Pattern
Provides an interface for creating families of related objects without specifying their concrete classes.
"""

from abc import ABC, abstractmethod

class IButton(ABC):
    @abstractmethod
    def press(self) -> None:
        pass
    
class WinButton(IButton):
    def press(self):
        print("Windows Button Pressed")
    
class MacButton(IButton):
    def press(self):
        print("Mac Button Pressed")
        

class ITextBox(ABC):
    @abstractmethod
    def showText(self) -> None:
        pass
    
class WinTextBox(ITextBox):
    def showText(self):
        print("Windows Text Box Showed")

    
class MacTextBox(ITextBox):
    def showText(self):
        print("Mac Text Box Showed")
        
        
class IFactory(ABC):
    @abstractmethod
    def CreateButton(self) -> IButton:
        pass
    
    @abstractmethod
    def CreateTextBox(self) -> ITextBox:
        pass
    
class WinFactory(IFactory):
    def CreateButton(self) -> IButton:
        return WinButton()
    
    def CreateTextBox(self) -> ITextBox:
        return WinTextBox()
        
class MacFactory(IFactory):
    def CreateButton(self) -> IButton:
        return MacButton()
    
    def CreateTextBox(self) -> ITextBox:
        return MacTextBox()
    
class GUIFactory:
    @staticmethod
    def CreateFactory(osType) -> IFactory:
        if osType == "Windows":
            return WinFactory()
        elif osType == "Mac":
            return MacFactory()
        else:
            print("Invalid OS Type")
            exit(1)

if __name__ == "__main__":
    osType = input("Enter the machine type (Windows/Mac):  ")
    
    fact = GUIFactory.CreateFactory(osType)
    
    button = fact.CreateButton()
    button.press()
    
    textBox = fact.CreateTextBox()
    textBox.showText()
    
    
