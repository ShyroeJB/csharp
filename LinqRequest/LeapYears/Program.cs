using System;
using System.Collections.Generic;
using System.Linq;

namespace LeapYears
{
    class Program
    {
        public static bool IsLeapYear(int year)
        {
            if (year % 4 != 0)
            {
                return false;
            }
            else if (year % 100 == 0 && year % 400 != 0)
            {
                return false;
            }
            return true;
        }
        public static int NextLeapYear(int year)
        {
            for (int i = 0; i <= 3; i++)
            {
                var nextYear = year + i;
                if (IsLeapYear(nextYear))
                {
                    return nextYear;
                }
            }
            return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Liste avec année bissextile");
            var years = new List<int>()
            {
                2016,
                2017,
                2018,
                2019,
                2020,
                2021,
                2022,
                2023,
                2024,
            };

            var leapYears1 = from year in years
                            where IsLeapYear(year)
                            select year;

            if (leapYears1.Count() == 0)
            {
                Console.WriteLine("Aucune année bissextile dans la liste");
                var lastElement = years.LastOrDefault();
                Console.WriteLine($"Année bissextile suivante : {NextLeapYear(lastElement)}");
            }
            else
            {
                foreach (var year in leapYears1.ToList())
                {
                    Console.WriteLine(year);
                }
            }

            Console.WriteLine("Liste sans année bissextile");
            var years2 = new List<int>()
            {
                2017,
                2018,
            };

            var leapYears2 = from year in years2
                             where IsLeapYear(year)
                             select year;

            if (leapYears2.Count() == 0)
            {
                Console.WriteLine("Aucune année bissextile dans la liste");
                var lastElement = years2.LastOrDefault();
                Console.WriteLine($"Année bissextile suivante : {NextLeapYear(lastElement)}");
            }
            else
            {
                foreach (var year in leapYears2.ToList())
                {
                    Console.WriteLine(year);
                }
            }
        }
    }
}
