using ListeChainee;
using Societe;
using System;

namespace SocieteEnumeration
{
    class Program
    {
        static void Main(string[] args)
        {
            Employe e1 = new Employe("Kirigaya", "Kazuto", 17, 2000);
            Employe e2 = new Employe("Yuki", "Asuna", 18, 2000);
            Employe e3 = new Employe("Synthesis Thirty", "Alice", 19, 2000);
            Employe e4 = new Employe("Knight", "Eugeo", 19, 2000);
            Employe e5 = new Employe("Kirigaya", "Suguha", 17, 2000);

            Chef c1 = new Chef("Koujiro", "Rinko", 28, 5000, "RATH");
            Chef c2 = new Chef("Kikuoka", "Kikuoka", 30, 5000, "RATH");

            Directeur d1 = new Directeur("Akihiko", "Kayaba", 30, 7000, "IA", "THE SEED");

            Console.WriteLine("\nListe 1\n");
            Liste liste = new Liste();
            liste.InsererDebut(e1);
            liste.InsererDebut(e2);
            liste.InsererDebut(e3);
            liste.InsererDebut(e4);
            liste.InsererDebut(e5);
            liste.InsererDebut(c1);
            liste.InsererDebut(c2);
            liste.InsererDebut(d1);
            liste.Lister();

            Console.WriteLine("\nListe Vider\n");
            liste.Vider();
            liste.Lister();

            Console.WriteLine("\nListe 2\n");
            liste.InsererFin(e1);
            liste.InsererFin(e2);
            liste.InsererFin(e3);
            liste.InsererFin(e4);
            liste.InsererFin(e5);
            liste.InsererFin(c1);
            liste.InsererFin(c2);
            liste.InsererFin(d1);
            liste.Lister();

            Console.WriteLine("\nListe Element\n");
            Console.WriteLine(liste[0]);
            Console.WriteLine(liste[7]);

            Console.WriteLine("\nListe Foreach\n");

            foreach (var element in liste)
            {
                Console.WriteLine(element.ToString());
            }
        }
    }
}
