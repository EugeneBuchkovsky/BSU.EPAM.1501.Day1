using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSU.EPAM._1501.Day1.Bychkovsky.Task2
{
    class SortingClass
    {
        /// <summary>
        /// Sort by maximum element ascending.
        /// </summary>
        /// <param name="sourceArray"></param>
        public static void ByMaxElementAscending(int[][] sourceArray)
        {
            SortArray.Sort(sourceArray, PreparationForSort.MaxElement(sourceArray), true);
        }

        /// <summary>
        /// Sort by maximum element decending.
        /// </summary>
        /// <param name="sourceArray"></param>
        public static void ByMaxElementDescending(int[][] sourceArray)
        {
            SortArray.Sort(sourceArray, PreparationForSort.MaxElement(sourceArray), false);
        }

        /// <summary>
        /// Sort by minimum element ascending.
        /// </summary>
        /// <param name="sourceArray"></param>
        public static void ByMinElementAscending(int[][] sourceArray)
        {
            SortArray.Sort(sourceArray, PreparationForSort.MinElement(sourceArray), true);
        }

        /// <summary>
        /// Sort by minimum element descending.
        /// </summary>
        /// <param name="sourceArray"></param>
        public static void ByMinElementDescending(int[][] sourceArray)
        {
            SortArray.Sort(sourceArray, PreparationForSort.MinElement(sourceArray), false);
        }

        /// <summary>
        /// Sort by sum element of the row ascending.
        /// </summary>
        /// <param name="sourceArray"></param>
        public static void BySumElementAscending(int[][] sourceArray)
        {
            SortArray.Sort(sourceArray, PreparationForSort.SumElement(sourceArray), true);
        }

        /// <summary>
        /// Sort by sum element of the row descending.
        /// </summary>
        /// <param name="sourceArray"></param>
        public static void BySumElementDescending(int[][] sourceArray)
        {
            SortArray.Sort(sourceArray, PreparationForSort.SumElement(sourceArray), false);
        }
    }
}
