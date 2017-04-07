using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    /// <summary>
    /// Selection Sort
    /// </summary>
    class SelectionSort : ISorting
    {
        int i, j, min;
        /*
        private void TauscheInArray<T>(ref T a, ref T b, ref T[] ary)
        {
            T temp = ary[a];
            ary[a] = ary[b]; // geht nicht, weil index immer int sein muss
            ary[b] = temp;
        }*/

        public int[] sort(int[] ary)
        {
            i = 0;
            while (i < ary.Length - 1) 
            {
                int temp;
                min = i;
                j = i + 1;

                while (j < ary.Length)
                {
                    if (ary[j] < ary[min])
                    {
                        min = j;
                    }
                    j = j + 1;
                }
                
                temp = ary[i];
                ary[i] = ary[min];
                ary[min] = temp;
                //TauscheInArray(ref i, ref min, ref ary);

                i = i + 1;
            }            
            
            return ary;
        }
    }
}
