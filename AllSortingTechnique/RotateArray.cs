using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllSortingTechnique
{
    public class RotateArray
    {
        public int[,] Rotate(int[,] sourceArray,int[,] destinationArray,int m,int n)
        {
            for (int i = 0; i < m;i++ )
            {
                for(int j=0;j<n;j++)
                {
                    destinationArray[n-j-1,i] = sourceArray[i,j];
                }
            }

                return destinationArray;
        }
    }
}
