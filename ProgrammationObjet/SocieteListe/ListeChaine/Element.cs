using System;

namespace ListeChainee
{
    public class Element : IDisposable
    {
        public object Objet { get; set; }
        public Element Suivant { get; set; }

        public Element(object objet)
        {
            Objet = objet;
            Suivant = null;
        }

        public override string ToString() => $"{Objet}";

        public void Dispose()
        {
            Objet = null;
            Suivant = null;
        }
    }
}
