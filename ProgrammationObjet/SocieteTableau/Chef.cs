namespace SocieteTableau
{
    public class Chef : Employe
    {
        public string Service { get; set; }

        public Chef(string nom, string prenom, int age, double salaire, string service) : base(nom, prenom, age, salaire)
        {
            Service = service;
        }

        public override string ToString()
        {
            return base.ToString() + $", Service : {Service}";
        }
    }
}
