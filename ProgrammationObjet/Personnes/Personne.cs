﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Personnes
{
    public class Personne : IDisposable
    {
        private string _nom;
        private string _prenom;
        private int _age;

        private static int nb = 0;
        private bool disposedValue;

        public Personne(string nom, string prenom, int age)
        {
            _nom = nom;
            _prenom = prenom;
            _age = age;
            nb++;
        }

        public override string ToString() => $"Nom : {_nom}, Prenom : {_prenom}, Quantite : {_age}";

        public void Afficher()
        {
            Console.WriteLine(this.ToString());
        }

        public void Combien()
        {
            Console.WriteLine($"Nb personne créer : {nb}");
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    nb--;
                }
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
