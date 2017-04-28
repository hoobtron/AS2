using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{

    class Program
    {

        static void Main(string[] args)
        {
            Nummer tel1 = new Nummer();
            Nummer fax1 = new Nummer();
            tel1.vorwahl = "+49 30";
            tel1.nummer = 1234567;
            fax1.vorwahl = "+49 30";
            fax1.nummer = 0987654;

            Kontakt kon1 = new Kontakt();
            kon1.strasse = "Musterstraße";
            kon1.hausnummer = 12;
            kon1.plz = 12345;
            kon1.ort = "Berlin";
            kon1.tel = tel1;
            kon1.fax = fax1;

            Kontakt kon2 = new Kontakt();
            kon2 = kon1;

            Kontakt kon3 = new Kontakt("Hackerstraße", 1337,
                                        31337, "Berlin",
                                        new Nummer("+49 30", 4321234),
                                        new Nummer("+49 30", 0123210)
                                    );

            kon1.ausgabe();
            kon2.ausgabe();
            kon3.ausgabe();
        }
    }
}
