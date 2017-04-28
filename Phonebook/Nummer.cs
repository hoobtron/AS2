using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    public struct Nummer
    {
        // Variablen
        public string vorwahl;
        public int nummer;

        // Konstruktor
        public Nummer(string vorwahl, int nummer)
        {
            this.vorwahl = vorwahl;
            this.nummer = nummer;
        }

        // Methode
        public string ausgabe()
        {
            return vorwahl + "/" + nummer;
        }
    }
}
