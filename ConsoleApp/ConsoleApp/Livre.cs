namespace ConsoleApp
{
    public class Livre : Article
    {
        public string IsBn { get; set; }
        public int NbPages { get; set; }

        public Livre() { }
        public Livre(string designation, double prix, string isBn, int nbPages) : base(designation, prix)
        {
            IsBn = isBn;
            NbPages = nbPages;
        }
    }
}
