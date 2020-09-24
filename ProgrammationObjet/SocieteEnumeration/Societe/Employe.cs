namespace Societe
{
    public class Employe : Personne
    {
        public double Salaire { get; set; }

        public Employe(string nom, string prenom, int age, double salaire) : base(nom, prenom, age)
        {
            Salaire = salaire;
        }

        public override string ToString()
        {
            return base.ToString() + $", Salaire : {Salaire}";
        }
    }
}
