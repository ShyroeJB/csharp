using System;
using System.Collections;

namespace ListeChainee
{
    public class ListeEnumeration : IEnumerator
    {
        private readonly Liste _liste;
        private int _indiceCourant;

        public ListeEnumeration(Liste liste)
        {
            _liste = liste;
            _indiceCourant = -1;
        }

        public object Current
        {
            get
            {
                try
                {
                    return _liste[_indiceCourant];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public bool MoveNext()
        {
            _indiceCourant++;
            return (_indiceCourant <= _liste.NbElement);
        }

        public void Reset()
        {
            _indiceCourant = -1;
        }
    }
}
