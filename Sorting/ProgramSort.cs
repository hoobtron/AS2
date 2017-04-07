using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class ProgramSort
    {
        /// <summary>
        /// Mainprogramm
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int inp;
            int[] ary = generateAry(30,100);

            //start the algorithm 
            List<ISorting> list = new List<ISorting>();
            list.Add(new DummySort());
            list.Add(new SelectionSort());
            //TODO add here your own searches


            Console.WriteLine("[ 0] Beenden");

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("[{0,2}] {1}", i + 1, list.ElementAt(i));
            }

            inp = input("Wählen Sie den Algorithmus zum Sortieren aus", 0, list.Count);
            if (inp == 0)
                Environment.Exit(0);

            Console.WriteLine("Array unsortiert:");
            printAry(ary);

            //sort the element
            Console.WriteLine("Array sortiert mit {0}:", list.ElementAt(--inp));
            printAry(list.ElementAt(inp).sort(ary));
            Console.WriteLine("--------------------------------");

            Main(null); //restart
        }

        /// <summary>
        /// Generate a new Array
        /// </summary>
        /// <param name="n">Number of elements</param>
        /// <param name="max">Biggest number</param>
        /// <returns></returns>
        private static int[] generateAry(int n, int max)
        {
            Random r = new Random();
            int[] ary = new int[n];
            for (int i = 0; i < n; i++)
            {
                ary[i] = r.Next(max);
            }
            return ary;
        }

        /// <summary>
        /// Prints the formated array on the console
        /// </summary>
        public static void printAry(int[] ary)
        {
            for (int i = 0; i < ary.Length; i++)
            {
                if (i % 16 == 15)
                    Console.WriteLine();
                Console.Write("{0,3} ", ary[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
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
            catch { }
            Console.WriteLine("Geben Sie eine Zahl zwischen {0} und {1} ein!", min, max);
            return input(title, min, max);
        }
    }
}
