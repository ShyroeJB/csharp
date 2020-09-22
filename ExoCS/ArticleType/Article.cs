using System;

namespace ArticleType
{
    public struct Article
    {
        public Article(string nom, double prix, int quantite, TypeArticle type)
        {
            Nom = nom;
            Prix = prix;
            Quantite = quantite;
            Type = type;
        }

        public string Nom { get; }
        public double Prix { get; }
        public int Quantite { get; set; }
        public TypeArticle Type { get; set; }

        public override string ToString() => $"Nom : {Nom}, Prix : {Prix}, Quantite : {Quantite}, Type : {Type}";

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
