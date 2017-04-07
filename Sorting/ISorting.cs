using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    interface ISorting
    {

        /// <summary>
        /// Sort the ary
        /// </summary>
        /// <param name="ary">Unsorted Ary</param>
        /// <returns>Return the sorted ary</returns>
        int[] sort(int[] ary);
    }
}
