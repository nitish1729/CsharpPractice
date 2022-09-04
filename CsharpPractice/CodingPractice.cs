using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPractice
{
    public class CodingPractice
    {
        public void prime()
        {
            Console.WriteLine("Check given number is prime or not");
            int number; int count = 0;
            Console.WriteLine("Enter the Number");
            number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {

                if (number % i == 0)
                {
                    count++;

                }
            }

            if (count == 2)
            {
                Console.WriteLine("Entered number is prime");

            }
            else
            {
                Console.WriteLine("Entered number is not a prime");
            }
            Console.WriteLine("Print All the Prime number b/w 1 to 100");
        }
        public void prime1()
        {
            Console.WriteLine("Print all the prime number betwwn 1 to 100");

            for (int number = 1; number <= 100; number++)
            {
                int sum = 0;
                int count = 0;

                for (int i = 1; i <= number; i++)
                {

                    if (number % i == 0)
                    {
                        count++;

                    }
                }
                if (count == 2)
                {
                    Console.WriteLine(number);
                }
            }
        }
        public void Armstrong()
        {
            Console.WriteLine("Check given number is Armstrong or not");
            int number = 153;
            int result = 0;
            int cube;
            int rem;
            int temp = number;

            while (number != 0)
            {
                rem = number % 10;
                cube = rem * rem * rem;
                result = result + cube;
                number = number / 10;
            }
            number = temp;
            if (number == result)
            {
                Console.WriteLine(number + " is a Armstrong number");
            }
            else
            {
                Console.WriteLine("not Armstrong");
            }
        }
        //A palindrome number is a number that is same after reverse.
        public void Palindrone()
        {
            Console.WriteLine("Check given number is Armstrong or not");
            int rem, sum = 0;
            Console.WriteLine("Enter the number");
            int number = int.Parse(Console.ReadLine());
            while (number != 0)
            {
                rem = number % 10;
                sum = (sum * 10) + rem;
                number = number / 10;
            }
            Console.WriteLine("Palindrone number is : " + sum);
        }
        public void Fibonocci()
        {
            Console.WriteLine("Find the Fibonacci serices of given number");
            Console.WriteLine("Enter the number");
            int number = int.Parse(Console.ReadLine());
            int a = 0, b = 1, c;
            Console.WriteLine(a);
            Console.WriteLine(b);
            for (int i = 2; i <= number; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c);
            }

        }
        public void Anagram()
        {
            Console.WriteLine("Check given number is Anagram or not");
            Console.WriteLine("Enter the first word");
            string anagram1 = Console.ReadLine();
            Console.WriteLine("Enter the second word");
            string anagram2 = Console.ReadLine();
            char[] ch1 = anagram1.ToLower().ToCharArray();
            char[] ch2 = anagram2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string val1 = new string(ch1);
            string val2 = new string(ch2);
            if (val1 == val2)
            {
                Console.WriteLine("Given world is anagram word");
            }
            else
            {
                Console.WriteLine("Given world is not anagram word");
            }
        }
        public void Factorial()
        {
            Console.WriteLine("Find the Factorial of given number");
            Console.WriteLine("Enter the number");
            int number = int.Parse(Console.ReadLine());
            int fact = 1;
            for (int i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
        }
    }
}
