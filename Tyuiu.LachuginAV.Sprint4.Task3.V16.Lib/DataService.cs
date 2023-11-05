using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.LachuginAV.Sprint4.Task3.V16.Lib
{
    public class DataService : ISprint4Task3V16
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            int min = array[0, 0];
            for (int i = 0; i < rows; i++)
            {
                if (array[i, 4] < min)
                {
                    min = array[i, 4];
                }
            }
            return min;
        }
    }
}