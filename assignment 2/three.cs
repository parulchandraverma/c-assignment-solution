using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal class three
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Product");
            Console.WriteLine("4 - Quotient");

            int choice = int.Parse(Console.ReadLine());

            double result = 0;

            switch (choice)
            {
                case 1:
                    result = num1 + num2;
                    break;
                case 2:
                    result = num1 - num2;
                    break;
                case 3:
                    result = num1 * num2;
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    return;
            }

            Console.WriteLine("Result: " + result);
            Console.ReadLine();
        }
    }

