using System;

namespace Article
{
    class Program
    {
        static void Main(string[] args)
        {
            Article a1 = new Article("test", 10, 2);
            Article a2 = new Article("test2", 10, 15);

            a1.Afficher();
            a2.Afficher();

            a1.Ajouter(10);
            a1.Afficher();

            a2.Retirer(10);
            a2.Afficher();

            Console.Write("Saisir nom nouvelle article : ");
            var nom = Console.ReadLine();
            Console.Write("Saisir prix nouvelle article : ");
            var prix = Console.ReadLine();
            Console.Write("Saisir quantite nouvelle article : ");
            var quantite = Console.ReadLine();

            Article a3 = new Article(nom, Convert.ToInt32(prix), Convert.ToInt32(quantite));
            a3.Afficher();

            Console.ReadKey();
        }
    }
}
