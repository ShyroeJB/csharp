using System;
using System.Collections.Generic;
using System.Linq;

namespace PrimeNumbers
{
    class Program
    {
        public static bool IsPrime(int number)
        {
            if (number == 1)
            {
                return false;
            }
            if (number == 2)
            {
                return true;
            }

            var limit = Math.Ceiling(Math.Sqrt(number)); //hoisting the loop limit

            for (int i = 2; i <= limit; ++i)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var numbers = new List<int>()
            {
                1,
                2,
                3,
                4,
                5,
                6,
                7,
                8,
                9,
                10,
            };

            var primeNumbers = numbers.Where(num => IsPrime(num)).ToList();
            var primeNumbers2 = from num in numbers
                                where IsPrime(num)
                                select num;

            primeNumbers2 = primeNumbers2.ToList();

            Console.WriteLine("\nLinq Lambda\n");
            foreach (var num in primeNumbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("\nLinq\n");
            foreach (var num in primeNumbers2)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("The End");
        }
    }
}
