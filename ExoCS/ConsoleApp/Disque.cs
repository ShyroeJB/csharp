using System;

namespace ConsoleApp
{
    public class Disque : Article
    {
        public string Label { get; set; }

        public Disque() { }
        public Disque(string designation, double prix, string label) : base(designation, prix)
        {
            Label = label;
        }

        public void Ecouter()
        {
            Console.WriteLine($"Label : {Label}");
        }
    }
}
