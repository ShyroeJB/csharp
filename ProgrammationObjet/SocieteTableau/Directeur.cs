namespace SocieteTableau
{
    public class Directeur : Chef
    {
        public string Societe { get; set; }

        public Directeur(string nom, string prenom, int age, double salaire, string service, string societe) : base(nom, prenom, age, salaire, service)
        {
            Societe = societe;
        }

        public override string ToString()
        {
            return base.ToString() + $", Societe : {Societe}";
        }
    }
}
