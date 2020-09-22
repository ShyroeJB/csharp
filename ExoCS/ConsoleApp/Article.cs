using System;

namespace ConsoleApp
{
    public class Article
    {
        public string Designation { get; set; }
        public double Prix { get; set; }

        public Article() { }
        public Article(string designation, double prix)
        {
            Designation = designation;
            Prix = prix;
        }

        public void Acheter()
        {
            Console.WriteLine($"Designation : {Designation}, Prix : {Prix}");
        }
    }
}
