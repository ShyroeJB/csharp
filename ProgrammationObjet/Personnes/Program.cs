using System;

namespace Personnes
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne p1 = new Personne("Kirigaya", "Kazuto", 16);
            Personne p2 = new Personne("Yuki", "Asuna", 17);

            p1.Afficher();
            p2.Afficher();

            p1.Combien();

            p1.Dispose();
            p1.Combien();

            Console.ReadKey();
        }
    }
}
