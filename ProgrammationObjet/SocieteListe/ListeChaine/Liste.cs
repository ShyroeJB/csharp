using System;

namespace ListeChainee
{
    public class Liste
    {
        private Element _debut;

        public int NbElement { get; private set; }

        public Element this[int index]
        {
            get
            {
                if (index > NbElement)
                {
                    throw new Exception("Out the limits.");
                }
                Element actual = _debut;
                for (int i = 0; i < index; i++)
                {
                    actual = actual.Suivant;
                }
                return actual;
            }
        }

        public Liste()
        {
            NbElement = 0;
            _debut = null;
        }

        public void InsererDebut(object objet)
        {
            Element element = new Element(objet);

            if (_debut == null)
            {
                _debut = element;
                return;
            }

            Element temp = _debut;
            _debut = element;
            _debut.Suivant = temp;
            NbElement++;
        }

        public void InsererFin(object objet)
        {
            Element element = new Element(objet);
            if (_debut == null)
            {
                _debut = element;
                return;
            }

            Element actual = _debut;
            while (actual.Suivant != null)
            {
                actual = actual.Suivant;
            }

            actual.Suivant = element;
            NbElement++;
        }

        public void Lister()
        {
            Element actual = _debut;
            if (_debut != null)
            {
                while (actual.Suivant != null)
                {
                    Console.WriteLine(actual.ToString());
                    actual = actual.Suivant;
                }
                Console.WriteLine(actual.ToString());
            }
        }

        public void Vider()
        {
            _debut = null;
            NbElement = 0;
        }
    }
}
