using System;

namespace ArticleType
{
    class Program
    {
        static void Main(string[] args)
        {
            Article a1 = new Article("test", 10, 2, TypeArticle.habillement);
            Article a2 = new Article("test2", 10, 15, TypeArticle.droguerie);

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
            Console.Write("Saisir type nouvelle article : ");
            var type = Console.ReadLine();
            var typeArt = (TypeArticle)Enum.Parse(typeof(TypeArticle), type, true);

            Article a3 = new Article(nom, Convert.ToInt32(prix), Convert.ToInt32(quantite), typeArt);
            a3.Afficher();

            Console.ReadKey();
        }
    }
}
