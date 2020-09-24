using System;

namespace Societe
{
    public class Personne
    {
        public string Nom { get; }
        public string Prenom { get; }
        public int Age { get; set; }

        public Personne(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
        }
        public Personne(string nom, string prenom, int age)
        {
            Nom = nom;
            Prenom = prenom;
            Age = age;
        }

        public override string ToString() => $"Nom : {Nom}, Prenom : {Prenom}, Age : {Age}";

        public void Afficher()
        {
            Console.WriteLine(this.ToString());
        }

        public static Personne operator ++(Personne p)
        {
            p.Age += 1;
            return p;
        }
    }
}
