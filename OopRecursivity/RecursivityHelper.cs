using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopRecursivity
{
    public static class RecursivityHelper
    {
        public static int minArray(int[] array, int element)
        {
            if (element == 1) return array[0];
            else return Math.Min(array[element - 1], minArray(array, element - 1));
        }

        public static int sumArray(int[] array, int element)
        {
            if (element == 0) return 0;
            else return (array[element - 1] + sumArray(array, element - 1));
        }
    }
}
