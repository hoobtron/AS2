using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoExceptionA
{
    class Program
    {
        private int stringToInt(string eingabe)
        {
            try
            {
                // Convert benötigt um Exception auszulösen, wenn keine Ganzzahl
                return Convert.ToInt32(eingabe);
            }
            catch (Exception e)
            {
                Console.WriteLine("Ausnahme! Fehlerhafte Eingabe.");
                Console.WriteLine("Exception Message: " + e.Message);
                Console.WriteLine("Exception Type: " + e.GetType());
            }
            return -1;
        }
        private decimal? division(int zahl1, int zahl2)
        {
            try
            {
                // wenn Division durch 0 Sprung nach catch ausgelöst
                return Convert.ToDecimal(zahl1 / zahl2);
            }
            catch (Exception e)
            {
                Console.WriteLine("Ausnahme! Division durch 0 nicht möglich!");
                Console.WriteLine("Exception Message: " + e.Message);
                Console.WriteLine("Exception Type: " + e.GetType());
            }
            return null;
        }

        static void Main(string[] args)
        {

            string eingabe;
            int zahl1, zahl2;
            decimal? ergebnis;

            var p = new Program();

            Console.Write("Geben Sie eine ganze Zahl ein (x zum beenden): ");
            eingabe = Console.ReadLine();
            // Abbruch bei Eingabe von x
            if (eingabe == "x") return;
            zahl1 = p.stringToInt(eingabe);

            Console.Write("Geben Sie eine weitere ganze Zahl ein: ");
            eingabe = Console.ReadLine();
            if (eingabe == "x") return;
            zahl2 = p.stringToInt(eingabe);

            Console.WriteLine("{0} + {1} = {2}", zahl1, zahl2, zahl1 + zahl2);
            Console.WriteLine("{0} - {1} = {2}", zahl1, zahl2, zahl1 - zahl2);
            Console.WriteLine("{0} * {1} = {2}", zahl1, zahl2, zahl1 * zahl2);
            
            ergebnis = p.division(zahl1, zahl2);
            if(ergebnis != null)
            {
                Console.WriteLine("{0} / {1} = {2}", zahl1, zahl2, ergebnis);
            }
            
            Console.ReadLine();
        }
    }
}