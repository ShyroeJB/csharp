namespace ConsoleApp
{
    public class Poche : Livre
    {
        public string Categorie { get; set; }

        public Poche() { }
        public Poche(string designation, double prix, string isBn, int nbPages, string categorie) : base(designation, prix, isBn, nbPages)
        {
            Categorie = categorie;
        }
    }
}
