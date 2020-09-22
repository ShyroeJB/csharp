namespace ConsoleApp
{
    public class Broche : Livre
    {
        public Broche() { }
        public Broche(string designation, double prix, string isBn, int nbPages) : base(designation, prix, isBn, nbPages)
        {
        }
    }
}
