using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllSortingTechnique
{
    public class ReverseArray
    {
        public int[] ReverseArrayNow(int[] array)
        {
            int temp;
            int start = 0;
            int end = (array.Length-1);
            while (start < end)
            {
                temp = array[start];
                array[start] = array[end];
                array[end] = temp;
                start++;
                end--;
            }  

            return array;
        }
    }
}
