using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.LachuginAV.Sprint4.Task7.V16.Lib
{
    public class DataService : ISprint4Task7V16
    {
        public int Calculate(int n, int m, string value)
        {
            //long number = long.Parse(value);
            //int sum = 0;
            //while (number > 0)
            //{
            //    if ((number % 10) % 2 != 0)
            //    {
            //        sum +=(int) (number % 10);
            //    }
            //    number /= 10;
            //}
            //return sum;

            int[,] mtrx = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mtrx[i, j] = int.Parse(value.Substring(i * m + j, 1));
                }
            }

            int sum = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (mtrx[i, j] % 2 == 0)
                    {
                        sum *= mtrx[i, j];
                    }
                }
            }
            return sum;
        }
    }
}