using System;
using System.Collections.Generic;

namespace SocieteTableau
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

            List<Personne> personneList = new List<Personne>()
            {
                e1,
                e2,
                e3,
                e4,
                e5,
                c1,
                c2,
                d1
            };

            for (int i = 0; i <= personneList.Count - 1; i++)
            {
                personneList[i].Afficher();
            }

            personneList[0]++;
            c1.Salaire += 500;
            c2.Service = "DEFENSE";

            foreach (var personne in personneList)
            {
                personne.Afficher();
            }


            Console.ReadKey();
        }
    }
}
