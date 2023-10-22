using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHelper
{

    public static class ArrayHelper
    {
        public static int FindMinRecursive(int[] array, int index, int minim)
        {
            if (index == array.Length)
            {
                return minim;
            }

            if (array[index] < minim)
            {
                minim = array[index];
            }

            return FindMinRecursive(array, index+1, minim);
        }

        public static int FindMaxRecursive(int[] array, int index, int minim)
        {
            if (index == array.Length)
            {
                return minim;
            }

            if (array[index] > minim)
            {
                minim = array[index];
            }

            return FindMaxRecursive(array, index + 1, minim);
        }
    }
}

