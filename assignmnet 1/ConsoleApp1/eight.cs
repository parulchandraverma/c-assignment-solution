using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class eight
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a name: ");
        string name = Console.ReadLine();

        int vowelCount = 0;
        foreach (char c in name.ToLower())
        {
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                vowelCount++;
            }
        }

        Console.WriteLine("Number of vowels in the name: " + vowelCount);
    }
}
