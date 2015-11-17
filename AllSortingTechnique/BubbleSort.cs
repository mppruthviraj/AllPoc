using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllSortingTechnique
{
    public class BubbleSort
    {
        public int[] BubbleSortArray(int[] array)
        {
            int swap;
            int n = array.Length;
            int[] arraySorted = { };
            array.CopyTo(arraySorted,0);
            for (int c = 0; c < (n - 1); c++)
            {
                for (int d = 0; d < n - c - 1; d++)
                {
                    if (arraySorted[d] > arraySorted[d + 1]) /* For decreasing order use < */
                    {
                        swap = arraySorted[d];
                        arraySorted[d] = arraySorted[d + 1];
                        arraySorted[d + 1] = swap;
                    }
                }
            }
            return arraySorted;
            
        }

        class Sample { private int i; public Single j; private void DisplayData() { Console.WriteLine(i + +j); } public void ShowData() { Console.WriteLine(i + +j); } }
    }
}
