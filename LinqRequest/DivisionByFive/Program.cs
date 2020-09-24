using System;
using System.Collections.Generic;
using System.Linq;

namespace DivisionByFive
{
    class Program
    {
        static void Main(string[] args)
        {
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
                11,
                12,
                13,
                14,
                15,
                16,
                17,
                18,
                19,
                20
            };

            var divByFive = numbers.Where(num => num % 5 == 0);

            foreach (var num in divByFive)
            {
                Console.WriteLine(num);
            }
        }
    }
}
