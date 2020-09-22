using System;

namespace Article
{
    public struct Article
    {
        public Article(string nom, double prix, int quantite)
        {
            Nom = nom;
            Prix = prix;
            Quantite = quantite;
        }

        public string Nom { get; }
        public double Prix { get; }
        public int Quantite { get; set; }

        public override string ToString() => $"Nom : {Nom}, Prix : {Prix}, Quantite : {Quantite}";

        public void Afficher()
        {
            Console.WriteLine(this.ToString());
        }

        public void Ajouter(int add)
        {
            Quantite += add;
        }

        public void Retirer(int remove)
        {
            Quantite -= remove;
        }
    }
}
