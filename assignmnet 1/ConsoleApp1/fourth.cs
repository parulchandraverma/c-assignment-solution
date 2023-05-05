using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class fourth
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int i, c = 0;
        for (i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                c++;
            }
        }
        if (c == 2)
        {
            Console.WriteLine("n is a prime number");
        }
        else
        {
            Console.WriteLine("n is not a prime number");
        }
    }
}

