namespace ConsoleApp5
{
    internal class Assignment_5
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Hello, World!");





            //1. Display numbers from 2 to 100 with a gap of 2
            Console.WriteLine("1. Displaying no from 2 to 100 with gap of 2");





            for (int i = 2; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }





            //2. Display table of 5 like 5 * 1 =5 5 * 2 = 10
            Console.WriteLine("2. Display table of 5 like 5 * 1 =5 5 * 2 = 10");





            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("5 * {0} = {1}", i, (i * 5));
            }





            //3. Take a charcater and check its vowel, consonant, integer or special character
            Console.WriteLine("3. Take a charcater and check its vowel, consonant, integer or special character");
            char c = Convert.ToChar(Console.Read());
            if (c >= '0' && c <= '9')
            {
                Console.WriteLine("It is an integer ");
            }
            else if (Convert.ToInt16(c) >= 65 && Convert.ToInt16(c) <= 123)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == '0' || c == 'u' || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                {
                    Console.WriteLine("Vowel");
                }
                else
                {
                    Console.WriteLine("Consonant");
                }
            }
            else
            {
                Console.WriteLine("Special character");
            }







            Console.ReadLine();





            //4. Check whether a number is prime or not
            Console.WriteLine("4. Check whether a number is prime or not");
            Console.WriteLine("Enter No");
            int a = Convert.ToInt16(Console.ReadLine());





            int j = 0;
            for (int i = 2; i <= a / 2; i++)
            {
                if (a % 2 == 0 || a == 1)
                {
                    Console.WriteLine("Not Prime");
                    j = 1;
                    break;
                }





            }
            if (j == 0)
            {
                Console.WriteLine("Prime");





            }





            //5. Diplay sum of 10 numbers
            int z = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter {0} no", (i + 1));
                int y = Convert.ToInt32(Console.ReadLine());
                z += y;
            }
            Console.WriteLine(z);





            //Display sum of max 10 positive integers
            int r = Convert.ToInt32(Console.ReadLine());





            //7. Take a name and split it into Array
            Console.WriteLine("7. Take a name and split it into Array");
            Console.WriteLine("Enter string to put into array");
            String s = Console.ReadLine();
            char[] arr = new char[s.Length];
            //char[] arr = Array.Empty<char>();
            for (int i = 0; i < s.Length; i++)
            {
                arr[i] = s[i];
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine((char)arr[i]);
            }





            //8. Take a name and count number of vowels in it
            Console.WriteLine("Enter name");
            String name = Console.ReadLine();
            //Console.ReadLine();
            int vc = 0;
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == 'a' || name[i] == 'e' || name[i] == 'i' || name[i] == '0' || name[i] == 'u' || name[i] == 'A' || name[i] == 'E' || name[i] == 'I' || name[i] == 'O' || name[i] == 'U')
                {
                    vc += 1;
                }
            }
            Console.WriteLine("no of vowel in {0} is {1}", name, vc);





        }
    }