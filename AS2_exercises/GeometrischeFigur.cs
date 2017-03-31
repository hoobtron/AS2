using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2_exercises
{
    abstract class Figur
    {
        protected double flaeche;
        protected double umfang;

        abstract protected void berechneFlaecheUndUmfang(){}
    }

    class Kreis : Figur
    {
        private double radius;
        public Kreis(double radius)
        {
            this.radius = radius;
        }
        
        public void BerechneFlaecheUndUmfang()
        {
            umfang = Math.PI * Math.Pow(radius, 2);
            flaeche = 2 * Math.PI * radius;

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
        }
        public void BerechneFlaecheUndUmfang()
        {
            umfang = 2 * seiteA + 2 * seiteB;
            flaeche = seiteA * seiteB;

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
            this.seiteA = seiteA;
            this.seiteB = seiteB;
            this.seiteB = seiteC;
        }
        public void BerechneFlaecheUndUmfang()
        {
            umfang = seiteA + seiteB + seiteC;
            flaeche = seiteA * seiteB;

            Console.WriteLine("gegebene Dreieck-Seiten: " + seiteA + " & " + seiteB + " & " + seiteC);
            Console.WriteLine("Dreieck-Umfang: " + umfang);
            Console.WriteLine("Dreieck-Fläche: " + flaeche);
        }
    }

/*
	class Dreieck : Figur
	{
		//Attribute
		private double seiteA;
		private double seiteB;
		private double seiteC;
		private double alpha;
		private double beta;
		private double gamma;
		private double hoeheA;
		private double hoeheB;
		private double hoeheC;
		
    //Eigenschaften
		public double SeiteA
		{
			get { return seiteA; }
		}
		public double SeiteB
		{
			get { return seiteB; }
		}
		public double SeiteC
		{
			get { return seiteC; }
		}
		public double Alpha
		{
			get { return this.alpha / (2 * Math.PI) * 360; }
		}
		public double Beta
		{
			get { return this.beta / (2 * Math.PI) * 360; }
		}
		public double Gamma
		{
			get { return this.gamma / (2 * Math.PI) * 360; }
		}
		public double HoeheA
		{
			get { return hoeheA; }
		}
		public double HoeheB
		{
			get { return hoeheB; }
		}
		public double HoeheC
		{
			get { return hoeheC; }
		}

    //Methoden
		public Dreieck(double seiteA, double seiteB, double seiteC)
		{
			this.seiteA = seiteA;
			this.seiteB = seiteB;
			this.seiteC = seiteC;
			
			this.alpha = Math.Acos((Math.Pow(this.seiteB, 2) + Math.Pow(this.seiteC, 2) - Math.Pow(this.seiteA, 2)) / (2 * this.seiteB * this.seiteC));
			this.beta = Math.Acos((Math.Pow(this.seiteA, 2) + Math.Pow(this.seiteC, 2) - Math.Pow(this.seiteB, 2)) / (2 * this.seiteA * this.seiteC));
			this.gamma = Math.Acos((Math.Pow(this.seiteA, 2) + Math.Pow(this.seiteB, 2) - Math.Pow(this.seiteC, 2)) / (2 * this.seiteA * this.seiteB));

			this.hoeheA = this.seiteC * Math.Sin(this.beta);
			this.hoeheB = this.seiteA * Math.Sin(this.gamma);
			this.hoeheC = this.seiteB * Math.Sin(this.alpha);

			this.flaeche = this.seiteA * this.hoeheA / 2;
      this.umfang = this.seiteA + this.seiteB + this.seiteC;
		}
	}
*/

    class GeometrischeFigur
    {
        static void Main(string[] args)
        {
            new Kreis(6).BerechneFlaecheUndUmfang();
            new Rechteck(5, 7).BerechneFlaecheUndUmfang();

            Console.ReadLine();
        }
    }
}
