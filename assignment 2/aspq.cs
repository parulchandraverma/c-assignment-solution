using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class aspq
    {
        public static void Main(string[] args)
        {
            double product = 1;
            Console.WriteLine("enter the first number");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number");
            double num2 = double.Parse(Console.ReadLine());
            double add = num1 + num2;
            double sub = num1 - num2;
            product = num1 * num2;
            double quotient = num1 / num2;
            Console.WriteLine("Addition result:" + add);
            Console.WriteLine("Subtraction result:" + sub);
            Console.WriteLine(" Product result:" + product);
            Console.WriteLine("quotient result: " + quotient);



        }
    }

