//Exercise 1

using System;

namespace Module6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string accountNumber = "758938", pinNumber = "3845", askAccountNumber, askPinNumber;
            int accountAmount = 0, deposit, withdraw;

            //confirm Account Number
            Console.WriteLine("Please enter your account number:");
            askAccountNumber = Console.ReadLine();

            try
            { 

            if (askAccountNumber == accountNumber)
            {
                Console.WriteLine("Please enter pin number.");
                askPinNumber = Console.ReadLine();
                if (askPinNumber == pinNumber)
                { 

                    bool loopContinue = true;
                    while (loopContinue)
                    {

                        Console.WriteLine("Please select an option from the following menu:");
                        Console.WriteLine("1) Show Balance");
                        Console.WriteLine("2) Deposit");
                        Console.WriteLine("3) Withdraw");
                        Console.WriteLine("4) Exit");
                        Console.WriteLine("Enter 1,2,3 or 4");
                        int inputOption = int.Parse(Console.ReadLine());


                        switch (inputOption)

                        {
                            case 1:
                                Console.WriteLine("The current balance is" + " " + accountAmount);
                                loopContinue = true;
                                break;

                            case 2:
                                Console.WriteLine("Enter deposit amount:");
                                deposit = int.Parse(Console.ReadLine());
                                accountAmount = accountAmount + deposit;
                                Console.WriteLine("The current balance after deposit is" + " " + "$" + accountAmount);
                                loopContinue = true;
                                break;
                            case 3:
                                Console.WriteLine("Enter withdrawl amount:");
                                withdraw = int.Parse(Console.ReadLine());
                                if (withdraw > accountAmount)
                                {
                                    Console.WriteLine("Insufficient funds.");
                                }
                                else
                                {
                                    accountAmount = accountAmount - withdraw;
                                    Console.WriteLine("Please collect amount." + " " + withdraw);
                                    Console.WriteLine("The current balance after withdrawl is" + " " + accountAmount);
                                }
                                loopContinue = true;
                                break;

                            case 4:
                                Console.WriteLine("Thank you for using VU Bank ATM.");
                                loopContinue = false;
                                break;

                            default:
                            throw new ArgumentOutOfRangeException("Please pick an option 1-4.");

                        }

                    }

                }
                else
                    Console.WriteLine("Invalid. Please enter valid pin number.");
            }
            else
                Console.WriteLine("Please enter valid account number.");

        }
    }
}
















//Exercise 2 

//using System;
//using System.Threading.Channels;
//using Microsoft.VisualBasic.CompilerServices;
//namespace Module6
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Select an operation.\n1) AddValues\n2) 
//            SubtractValues\n3) MultiplyValues\n4) DivideValues\n5) RemainderValues\n");
//        string userChoice = Console.ReadLine();
//            Console.WriteLine("Enter a number.");
//            string valueOne = Console.ReadLine();
//            Console.WriteLine("Enter another number.");
//            string valueTwo = Console.ReadLine();
//            switch (userChoice)
//            {
//                case "1":
//                    Console.WriteLine($"Result={AddValues(valueOne,
//                    valueTwo)}");
//                    break;
//                case "2":
//                    Console.WriteLine($"Result={SubtractValues(valueOne,
//                    valueTwo)}");
//                    break;
//                case "3":
//                    Console.WriteLine($"Result={MultiplyValues(valueOne,
//                    valueTwo)}");
//                    break;
//                case "4":
//                    Console.WriteLine($"Result={DivideValues(valueOne,
//                    valueTwo)}");
//                    break;
//                case "5":
//                    Console.WriteLine($"Result={RemainderValues(valueOne,
//                    valueTwo)}");
//                    break;
//                default:
//                    break;
//            }
//        }
//        static int AddValues(string valueOne, string valueTwo)
//        {
//            int parsedValueOne = int.Parse(valueOne);
//            int parsedValueTwo = int.Parse(valueTwo);
//            return parsedValueOne + parsedValueTwo;
//        }
//        static int SubtractValues(string valueOne, string valueTwo)
//        {
//            int parsedValueOne = int.Parse(valueOne);
//            int parsedValueTwo = int.Parse(valueTwo);
//            return parsedValueOne - parsedValueTwo;
//        }
//        static int MultiplyValues(string valueOne, string valueTwo)
//        {
//            int parsedValueOne = int.Parse(valueOne);
//            int parsedValueTwo = int.Parse(valueTwo);
//            return parsedValueOne * parsedValueTwo;
//        }
//        static int DivideValues(string valueOne, string valueTwo)
//        {
//            int parsedValueOne = int.Parse(valueOne);
//            int parsedValueTwo = int.Parse(valueTwo);
//            return parsedValueOne / parsedValueTwo;
//        }
//        static int RemainderValues(string valueOne, string valueTwo)
//        {
//            int parsedValueOne = int.Parse(valueOne);
//            int parsedValueTwo = int.Parse(valueTwo);
//            return parsedValueOne % parsedValueTwo;
//        }
//    }
//}
