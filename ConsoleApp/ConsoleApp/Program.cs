using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Disque disque = new Disque
            {
                Designation = "test",
                Prix = 20,
                Label = "monLab"

            };
            disque.Acheter();
            disque.Ecouter();

            Console.ReadKey();

        }
    }
}
