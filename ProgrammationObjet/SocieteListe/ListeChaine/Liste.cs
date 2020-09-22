namespace ListeChainee
{
    public class Liste
    {
        private Element _debut;
        private int _nbElement;

        public int NbElement
        {
            get => _nbElement;
        }

        public Liste()
        {
            _nbElement = 0;
            _debut = null;
        }

        public void InsererDebut(Element objet)
        {
            _debut = objet;
        }

        public void InsererFin(Element objet)
        {
            while (_debut.Suivant != null)
            {
                _debut = _debut.Suivant;
            }
            _debut.Suivant = objet;
            _nbElement++;
        }

        public void Vider()
        {
            while (_debut.Suivant != null)
            {
                _debut = _debut.Suivant;
                
            }

        }
    }
}
