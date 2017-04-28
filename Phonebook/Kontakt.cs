using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    struct Kontakt
    {
        // Variablen
        public int plz, hausnummer;
        public string ort, strasse;
        public Nummer tel, fax;

        // Konstruktor
        public Kontakt(string strasse, int hausnummer, int plz, string ort, Nummer tel, Nummer fax)
        {
            this.plz = plz;
            this.hausnummer = hausnummer;
            this.ort = ort;
            this.strasse = strasse;
            this.tel = tel;
            this.fax = fax;
        }

        // Methode
        public void ausgabe()
        {
            Console.WriteLine("Adresse:\n" +
                                strasse + " " + hausnummer + "\n" +
                                plz + " " + ort + "\n");
            Console.WriteLine("Tel: " + tel.ausgabe());
            Console.WriteLine("Fax: " + fax.ausgabe());
            Console.ReadKey();
        }
    }

}
