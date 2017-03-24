using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2_exercises
{
    class Figur
    {
        protected double flaeche;
        protected double umfang;
    }

    class Kreis : Figur
    {
        private double radius;
        public Kreis(double radius)
        {
            this.radius = radius;
            umfang = Math.PI * Math.Pow(radius, 2);
            flaeche = 2 * Math.PI * radius;
        }
        
        public void Ausgabe()
        {
            Console.WriteLine("gegebener Kreis-Radius: " + radius);
            Console.WriteLine("Kreis-Umfang: " + umfang);
            Console.WriteLine("Kreis-Fläche: " + flaeche);
        }
    }

    class Rechteck : Figur
    {
        protected double seiteA;
        protected double seiteB;
        public Rechteck(double seiteA, double seiteB)
        {
            this.seiteA = seiteA;
            this.seiteB = seiteB;
            umfang = 2 * seiteA + 2 * seiteB;
            flaeche = seiteA * seiteB;
        }
        public void Ausgabe()
        {
            Console.WriteLine("gegebene Rechteck-Seiten: " + seiteA + " & " + seiteB);
            Console.WriteLine("Rechteck-Umfang: " + umfang);
            Console.WriteLine("Rechteck-Fläche: " + flaeche);
        }
    }

    class Dreieck : Figur
    {
        protected double seiteA;
        protected double seiteB;
        protected double seiteC;
        protected double alpha;
        protected double beta;
        protected double gamma;
        protected double hoeheA;
        protected double hoeheB;
        protected double hoeheC;
        public Dreieck(double seiteA, double seiteB, double seiteC)
        {
            umfang = 2 * seiteA + 2 * seiteB;
            flaeche = seiteA * seiteB;
        }
    }

    class GeometrischeFigur
    {
        static void Main(string[] args)
        {
            new Kreis(6).Ausgabe();
            new Rechteck(5, 7).Ausgabe();

            Console.ReadLine();
        }
    }
}
