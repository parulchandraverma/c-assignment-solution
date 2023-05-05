using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class third
    {
    public static void Main(string[] args)
    {
        char c = Convert.ToChar(Console.ReadLine());
        Console.WriteLine(c);
        if (Convert.ToUInt16(c) >= 65 && Convert.ToUInt16(c) <= 123)
        {
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("Consonant");
            }
        }
        if(c >= '0' && c <= '9') 
        {
            Console.WriteLine("Integer");
         }
        else
        {
            Console.WriteLine("special character");
        }
    }
    }
