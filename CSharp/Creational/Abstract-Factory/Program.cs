/*
 * Abstract Factory Design Pattern
 * Provides an interface for creating families of related objects without specifying their concrete classes.
 */

using System;
using System.Diagnostics.Metrics;

namespace AbstractFactory
{

    interface IButton
    {
        void press();
    } 
    
    class WinButton : IButton
    {
        public void press()
        {
            Console.WriteLine("Windows Button Pressed");
        }
    }

    class MacButton : IButton
    {
        public void press()
        {
            Console.WriteLine("Mac Button Pressed");
        }
    }

    interface ITextBox
    {
        void showText();
    } 
    
    class WinTextBox : ITextBox
    {
        public void showText()
        {
            Console.WriteLine("Windows Text Box Displayed");
        }
    }

    class MacTextBox : ITextBox
    {
        public void showText()
        {
            Console.WriteLine("Mac Text Box Displayed");
        }
    }

    interface IFactory // To make sure all the factories that inherit from this interface will have to create a button and a text box
    {
        // Basically, this factory creates button and a text box and returns the object of the interfaces IButton and ITextBox
        // Here we are dealing with the final products ( or interfaces - IButton and ITextBox ) and not the os types.
        public IButton CreateButton();
        public ITextBox CreateTextBox();
    }

    class WinFactory : IFactory
    {
        public IButton CreateButton()
        {
            return new WinButton();
        }

        public ITextBox CreateTextBox()
        {
            return new WinTextBox();
        }
    }

    class MacFactory : IFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ITextBox CreateTextBox()
        {
            return new MacTextBox();
        }
    }

    class GUIFactory
    {
        public static IFactory CreateFactory( string osType)
        {
            if ( osType == "Windows")
            {
                return new WinFactory();
            }
            else if ( osType == "Mac")
            {
                return new MacFactory();
            }
            else
            {
                Console.WriteLine("Invalid OS Type");
                return null;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the machine type (Windows/Mac): ");
            string osType = Console.ReadLine();

            IFactory fact = GUIFactory.CreateFactory(osType);

            IButton button = fact.CreateButton();
            button.press();

            ITextBox textBox = fact.CreateTextBox();
            textBox.showText();

            
        }
    }
}
