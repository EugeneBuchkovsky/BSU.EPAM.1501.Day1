using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSU.EPAM._1501.Day1.Bychkovsky.Task2
{
    class PreparationForSort
    {
        /// <summary>
        /// finding the sum of the rows source array.
        /// </summary>
        /// <param name="sourceArray"></param>
        /// <returns>int[]</returns>
        public static int[] SumElement(int[][] sourceArray)
        {
            int[] finalArray = new int[sourceArray.Length];
            for (var i = 0; i < finalArray.Length; i++)
            {
                if (sourceArray[i] != null)
                    finalArray[i] = sourceArray[i].Sum();
            }
            return finalArray;
        }

        /// <summary>
        /// finding the minimum element of the rows source array.
        /// </summary>
        /// <param name="sourceArray"></param>
        /// <returns>int[]</returns>
        public static int[] MinElement(int[][] sourceArray)
        {
            int[] finalArray = new int[sourceArray.Length];
            for (var i = 0; i < finalArray.Length; i++)
            {
                if (sourceArray[i] != null)
                    finalArray[i] = sourceArray[i].Min();
            }
            return finalArray;
        }

        /// <summary>
        /// finding the maximum element of the rows source array.
        /// </summary>
        /// <param name="sourceArray"></param>
        /// <returns>int[]</returns>
        public static int[] MaxElement(int[][] sourceArray)
        {
            int[] finalArray = new int[sourceArray.Length];
            for (var i = 0; i < finalArray.Length; i++)
            {
                if (sourceArray[i] != null)
                    finalArray[i] = sourceArray[i].Max();
            }
            return finalArray;
        }        
    }
}
