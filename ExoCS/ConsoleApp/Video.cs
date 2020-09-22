using System;

namespace ConsoleApp
{
    public class Video : Article
    {
        protected DateTime Duree { get; set; }

        public Video() { }
        public Video(string designation, double prix, DateTime duree) : base(designation, prix)
        {
            Duree = duree;
        }

        public void Afficher()
        {
            Console.WriteLine($"Duree : {Duree}");
        }
    }
}
