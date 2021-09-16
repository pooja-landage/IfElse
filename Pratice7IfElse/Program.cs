using System;

namespace Pratice7IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("===========If Else==================");
            // Simple If Else Example
            int a ,n ,ch;
            a = 34;
            if (a>55)
            {
                Console.WriteLine("This Condition Is True");
            }
            else 
            {
                Console.WriteLine("This Condition Is False");
            }

            // Even Odd Example
            Console.WriteLine("Enter The Value Of n");
            n = Convert.ToInt32(Console.ReadLine());
            if(n%2 == 0)
            {
                Console.WriteLine("The number entered is even number");
            }
            else
            {
                Console.WriteLine("The number entered is odd number");
            }

            // Vowels
            Console.WriteLine("Enter The Value Of ch ");
            ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'a' || ch == 'A' || ch == 'E' || ch == 'e' || ch == 'i' || ch == 'I' || ch == 'o' || ch == 'O' || ch == 'u' || ch == 'U' )
            {
                Console.WriteLine("The charater entered is a Vowel");
            }
            else
            {
                Console.WriteLine("The charater entered is not Vowel");
            }

            //If Nested(Days)

            int day;
            Console.WriteLine("Enter any day in number");
            day = Convert.ToInt32(Console.ReadLine());

            if (day ==1)
            {
                Console.WriteLine("This day is Monday");
            }
            else if (day == 2)
            {
                Console.WriteLine("This day is Tuesday");
            }
            else if (day == 3)
            {
                Console.WriteLine("This day is Wednesday");
            }
            else if (day == 4)
            {
                Console.WriteLine("This day is Thursday");
            }
            else 
            {
                Console.WriteLine("Incorrect Number");
            }

        }


    }
}
