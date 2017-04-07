
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    class ProgramSearch
    {
        /// <summary>
        /// Mainprogramm
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            AbstractSearch search;
            int inp;

            //start the algorithm 
            List<AbstractSearch> list = new List<AbstractSearch>();
            list.Add(new DummySearch());
            //TODO add here your own searches


            Console.WriteLine("[ 0] Beenden");

            for (int i = 0; i < list.Count;i++ ){
                Console.WriteLine("[{0,2}] {1}",i+1,list.ElementAt(i));
            }

            inp = input("Wählen Sie den Algorithmus zum Suchen aus", 0, list.Count);
            if (inp == 0)
                Environment.Exit(0);

            //search the element
            search = list.ElementAt(--inp);
            search.printAry();
            inp = input("Bitte die gesuchte Zahl eingeben", new List<int>(search.ary).Min(), new List<int>(search.ary).Max());
            Console.WriteLine("Der gesuchte Eintrag hat die Position {0}\n-----------------------", search.search(inp));
            Main(null); //restart
        }

        /// <summary>
        /// Helpermethod to validate the int input
        /// </summary>
        /// <param name="title">Descption for the user</param>
        /// <param name="min">smallest accepted number</param>
        /// <param name="max">biggest accepted number</param>
        /// <returns></returns>
        public static int input(String title, int min, int max)
        {
            Console.Write("{0} [{1}-{2}]: ", title, min, max);
            try
            {
                int index = Convert.ToInt32(Console.ReadLine());
                if (index >= min && index <= max)
                {
                    return index;
                }
            }
            catch {}
            Console.WriteLine("Geben Sie eine Zahl zwischen {0} und {1} ein!", min, max);
            return input(title, min, max);
        }
    }
}
