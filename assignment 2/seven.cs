using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal class seven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Table of " + num + ":");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num + " x " + i + " = " + (num * i));
            }

            Console.ReadLine();
        }
    }

