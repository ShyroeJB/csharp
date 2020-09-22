namespace ListeChainee
{
    public class Element
    {
        public object Objet { get; set; }
        public Element Suivant { get; set; }

        public Element(object objet)
        {
            Objet = objet;
        }
    }
}
