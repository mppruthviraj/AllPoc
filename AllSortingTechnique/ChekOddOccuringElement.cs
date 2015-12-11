using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllSortingTechnique
{
    public class CheckOddOccuringElement
    {
        public int CheckOddOccuringElementComplexityN(int[] ar,int ar_size)
        {
           
            int i;
            int res = 0;
            for (i = 0; i < ar_size; i++)
                res = res ^ ar[i];

            return res;
        }

    }
}
