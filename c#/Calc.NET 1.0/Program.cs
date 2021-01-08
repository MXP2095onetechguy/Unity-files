using System;
using CalcLIib;
using System.Runtime;
using System.Windows;
using System.Threading;
namespace Calc.NET
{
    class Program
    {

        static void Main(string[] args)
        {

            bool endApp = false;
            // Display title as the C# console calculator app.
            Console.Title = "Calc.NET";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.WriteLine("Calc.NET                  \r");
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");
            Thread.Sleep(2000);
            Console.Beep(525, 500);


            while (!endApp)
            {
                // Declare variables and set to empty.
                string numInput1 = "";
                string numInput2 = "";
                double result = 0;

                // Ask the user to type the first number.
                Console.Write("Type a number, and then press Enter: ");
                numInput1 = Console.ReadLine();
                    double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.Beep(500, 1000);
                    Console.Write("This is not valid input. Please enter an double float value: ");
                    numInput1 = Console.ReadLine();
                }
                Console.Beep(525, 500);
                // Ask the user to type the second number.
                Console.Write("Type another number, and then press Enter: ");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Beep(500, 1000);
                    Console.Write("This is not valid input. Please enter an double float value: ");
                    numInput2 = Console.ReadLine();
                }
                Console.Beep(525, 500);
                // Ask the user to choose an operator.
                Console.WriteLine("Choose an operator from the following list:");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
                Console.WriteLine("\tp - To the power of {not ready}");
                Console.WriteLine("\tsi - Sine value {not ready}");
                Console.WriteLine("\tc - cosine value {not ready}");
                Console.Write("Your option? ");

                string op = Console.ReadLine();
                string resop = Console.ReadLine();
                try
                {
                    CalcLIib.CalcLIib calculator = new CalcLIib.CalcLIib();
                    if (double.IsNaN(result))
                    {
                        Console.Beep(500, 1000);
                        Console.WriteLine("This operation will result in a mathematical error.\n");
                    }
                    
                    else
                    {
                        Console.Beep(525, 500);
                        Console.WriteLine("Your result: {0:0.##}\n", result);
                        Console.WriteLine("Operation: \n", resop);
                    }
                }
                catch (Exception e)
                {
                    Console.Beep(500, 1000);
                    Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
                    Console.WriteLine("To exit please type n.");
                    Console.ReadLine();
                    if (Console.ReadLine() == "n")
                    {
                        Console.Beep(525, 500);
                        Environment.Exit(0);
                    }
                }

                Console.WriteLine("------------------------\n");

                // Wait for the user to respond before closing.
                Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "n")
                {
                    Console.Beep(525, 500);
                    Environment.Exit(0);
                }

                Console.Beep(525, 500);
                Console.WriteLine("\n"); // Friendly linespacing.
            }
            return;
        }
    }
}
