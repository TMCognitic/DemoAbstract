namespace DemoOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Forme> list = new List<Forme>()
            {
                new Cercle() { Couleur = "Vert", Rayon = 4 },
                new Rectangle() { Couleur = "Rouge", Longueur = 4, Largeur = 2 }
            };

            foreach (Forme forme in list)
            {
                Console.WriteLine($"Je suis un {forme.GetType().Name} {forme.Couleur}");
                Console.WriteLine($"Perimetre : {forme.Perimetre}");
                Console.WriteLine($"Surface : {forme.Surface}");

            }
        }
    }   

    abstract class Forme
    {
        public string Couleur { get; set; }

        public abstract double Perimetre
        {
            get;
        }

        public abstract double Surface
        {
            get;
        }
    }

    class Cercle : Forme
    {
        public double Rayon { get; set; }

        public override double Perimetre
        {
            get { return 2 * Math.PI * Rayon; }
        }

        public override double Surface
        {
            get { return Math.PI * Math.Pow(Rayon, 2); }
        }
    }

    class Rectangle : Forme
    {
        public double Longueur { get; set; }
        public double Largeur { get; set; }

        public override double Perimetre
        {
            get { return (Longueur + Largeur) * 2; } 
        }

        public override double Surface
        {
            get { return Longueur * Largeur; }
        }
    }
}
