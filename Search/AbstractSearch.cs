using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    /// <summary>
    /// Baseclass to implement the search algorithms
    /// </summary>
    abstract class AbstractSearch
    {
        public int[] ary;
        protected int max = 100; //max number

        /// <summary>
        /// Default Constructor
        /// </summary>
        public AbstractSearch() :this(30)
        {
        }

        /// <summary>
        /// Generate a new number array
        /// </summary>
        /// <param name="n">Count of the elements</param>
        public AbstractSearch(int n)
        {
            Random r = new Random();
            int bas = 0, step = max/n;
            ary = new int[n];
            for (int i = 0; i < n; i++)
            {
                ary[i] = bas+r.Next(step);
                if (i > 0 && ary[i] == ary[i - 1])
                {
                    ary[i]++;
                }
                bas = ary[i];
            }
        }

        /// <summary>
        /// Search the array
        /// </summary>
        /// <param name="element">element to search</param>
        /// <returns>position of the element</returns>
        public abstract int search(int element);

        /// <summary>
        /// Prints the formated array on the console
        /// </summary>
        public void printAry()
        {
            for (int i=0;i<ary.Length;i++)
            {
                if (i % 10 == 0)
                    Console.WriteLine();
                Console.Write("{0,2}]" + (max >= 100 ? "{1,-3} " : "{1,-2} "), i, ary[i]);
            }
            Console.WriteLine();
        }
    }
}
