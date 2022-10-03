
using System;
using System.Threading.Channels;
using Microsoft.VisualBasic.CompilerServices;
namespace Module6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select an operation.\n1) AddValues\n2) SubtractValues\n3) MultiplyValues\n4) DivideValues\n5) RemainderValues\n");
            string userChoice = Console.ReadLine();
            Console.WriteLine("Enter a number.");
            string valueOne = Console.ReadLine();
            Console.WriteLine("Enter another number.");
            string valueTwo = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    Console.WriteLine($"Result={AddValues(valueOne, valueTwo)}");
                    break;
                case "2":
                    Console.WriteLine($"Result={SubtractValues(valueOne, valueTwo)}");
                    break;
                case "3":
                    Console.WriteLine($"Result={MultiplyValues(valueOne, valueTwo)}");
                    break;
                case "4":
                    Console.WriteLine($"Result={DivideValues(valueOne, valueTwo)}");
                    break;
                case "5":
                    Console.WriteLine($"Result={RemainderValues(valueOne, valueTwo)}");
                    break;
                default:
                    Console.WriteLine("Invalid operation selection. Please select an operation 1-5."); //we would not do a try/catch here because this is an expected "error"
                    break;

            }
        }

        static int AddValues(string valueOne, string valueTwo)
        {
            try
            {
                int parsedValueOne = int.Parse(valueOne);
                int parsedValueTwo = int.Parse(valueTwo);
                return parsedValueOne + parsedValueTwo;
            }
            catch (FormatException)
            {
                Console.WriteLine("The input was invalid. Please enter a numeric input.");
                return 0;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Unable to perform the selected calculation on those numbers. Please select a different menu option 1-5.");
                return 0;
            }
        }
        static int SubtractValues(string valueOne, string valueTwo)
        {   
            try
            { 
            int parsedValueOne = int.Parse(valueOne);
            int parsedValueTwo = int.Parse(valueTwo);
            return parsedValueOne - parsedValueTwo;
            }
            catch (FormatException)
            {
                Console.WriteLine("The input was invalid. Please enter a numeric input.");
                return 0;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Unable to perform the selected calculation on those numbers. Please select a different menu option 1-5.");
                return 0;
            }
        }
        static int MultiplyValues(string valueOne, string valueTwo)
        {
            try
            { 
            int parsedValueOne = int.Parse(valueOne);
            int parsedValueTwo = int.Parse(valueTwo);
            return parsedValueOne * parsedValueTwo;
            }
            catch (FormatException)
            {
                Console.WriteLine("The input was invalid. Please enter a numeric input.");
                return 0;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Unable to perform the selected calculation on those numbers. Please select a different menu option 1-5.");
                return 0;
            }
        }
        static int DivideValues(string valueOne, string valueTwo)
        {
            try
            {
                int parsedValueOne = int.Parse(valueOne);
                int parsedValueTwo = int.Parse(valueTwo);
                return parsedValueOne / parsedValueTwo;
            }
            catch(FormatException)
            {
                Console.WriteLine("The input was invalid. Please enter a numeric input.");
                return 0;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Unable to divide by zero.");
                return 0;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Unable to perform the selected calculation on those numbers. Please select a different menu option 1-5.");
                return 0;
            }
        }
        static int RemainderValues(string valueOne, string valueTwo)
        {
            try
            {
                int parsedValueOne = int.Parse(valueOne);
                int parsedValueTwo = int.Parse(valueTwo);
                return parsedValueOne % parsedValueTwo;
            }
            catch (FormatException)
            {
                Console.WriteLine("The input was invalid. Please enter a numeric input.");
                return 0;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Unable to divide by zero.");
                return 0;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Unable to perform the selected calculation on those numbers. Please select a different menu option 1-5.");
                return 0;
            }
        }
      
    }
}
