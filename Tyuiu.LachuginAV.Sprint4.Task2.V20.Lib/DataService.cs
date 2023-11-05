using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.LachuginAV.Sprint4.Task2.V20.Lib
{
    public class DataService : ISprint4Task2V20
    {
        public int Calculate(int[] array)
        {
        
            {
                int sum = 0;
                foreach (int item in array)
                {
                    sum += item % 2 == 0 ? item : 0;
                }
                return sum;
            }
        }
    }
}
    
