using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllSortingTechnique
{
    public class Exchanging1And0
    {

        public void ProcessArrayStackOverFlow(bool[,] matrix, int n)
        {
            bool tempvar1, tempvar2;

            for (var i = 0; i < n; i++)
            {
                tempvar1 = matrix[i, i];
                tempvar2 = matrix[n - i - 1, n - i - 1];

                var j = 0;

                for (j = 0; j < n; j++)
                {
                    if ((i < n / 2) || (((n % 2) == 1) && (i == n / 2) && (j <= i)))
                    {
                        // store the row and col & results in corner cells of concentric squares
                        tempvar1 &= matrix[j, i];
                        matrix[i, i] &= matrix[i, j];
                        tempvar2 &= matrix[n - j - 1, n - i - 1];
                        matrix[n - i - 1, n - i - 1] &= matrix[n - i - 1, n - j - 1];
                    }
                    else
                    {
                        // skip corner cells of concentric squares
                        if ((j == i) || (j == n - i - 1)) continue;

                        // calculate the & values for rest of them
                        matrix[i, j] = matrix[i, i] & matrix[n - j - 1, j];
                        matrix[n - i - 1, j] = matrix[n - i - 1, n - i - 1] & matrix[n - j - 1, j];

                        if ((i == n / 2) && ((n % 2) == 1))
                        {
                            // if n is odd
                            matrix[i, n - j - 1] = matrix[i, i] & matrix[j, n - j - 1];
                        }
                    }
                }

                if ((i < n / 2) || (((n % 2) == 1) && (i <= n / 2)))
                {
                    // transfer the values from temp variables to appropriate corner cells of its corresponding square
                    matrix[n - i - 1, i] = tempvar1;
                    matrix[i, n - i - 1] = tempvar2;
                }
                else if (i == n - 1)
                {
                    // update the values of corner cells of each concentric square
                    for (j = n / 2; j < n; j++)
                    {
                        tempvar1 = matrix[j, j];
                        tempvar2 = matrix[n - j - 1, n - j - 1];

                        matrix[j, j] &= matrix[n - j - 1, j];
                        matrix[n - j - 1, j] &= tempvar2;

                        matrix[n - j - 1, n - j - 1] &= matrix[j, n - j - 1];
                        matrix[j, n - j - 1] &= tempvar1;
                    }
                }
            }
        }

        public void ProcessArray(int[,] array, int m, int n)
        {
            bool checkRowZero = false;
            bool checkColZero = false;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int value = array[i, j];
                    if (value == 0)
                    {
                        checkRowZero = true;
                    }
                }

                if (checkRowZero)
                {
                    for (int j = 0; j < n; j++)
                    {
                        array[i,j] = 0;
                    }

                    checkRowZero = false;
                }
            }

            for(int i=0;i<n;i++)
            {
                for(int j=0;j<m;j++)
                {
                    int value = array[j, i];
                    if (value == 0)
                    {
                        checkColZero = true;
                    }
                }
                if(checkColZero)
                {
                    for(int j=0;j<m;j++)
                    {
                        array[j,i] = 0;
                    }
                }
            }

        }

        public bool CheckRowContainsZero(int[,] array, int n, int colIndex)
        {
            for (int i = 0; i < n; i++)
            {
                if (array[colIndex, i] == 0)
                {
                    return true;
                }
            }

            return false;
        }

    }
}
