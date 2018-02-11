using System;

namespace Algorithm
{
    /// <summary>
    /// Bubble Sort uses O(n^2)
    /// </summary>
    public class BubbleSort
    {

        /// <summary>
        /// Sorts an array of integer values using the bubble sort algorithm
        /// </summary>
        /// <param name="intArray"></param>
        /// <returns>An array of sorted integers in ascending order</returns>
        public int[] SortAscending(int[] intArray)
        {
            for (int j = 0; j < intArray.Length; j++)
            {
                for (int i = intArray.Length - 1; i > j; i--)
                {
                    if (intArray[i - 1] > intArray[i])
                    {
                        int temp = intArray[i - 1];
                        intArray[i - 1] = intArray[i];
                        intArray[i] = temp;
                    }
                }
            }
            return intArray;
        }

        /// <summary>
        /// Sorts an array of integer values using the bubble sort algorithm
        /// </summary>
        /// <param name="intArray"></param>
        /// <returns>An array of sorted integers in descending order</returns>
        public int[] SortDescending(int[] intArray)
        {
            for (int j = 0; j < intArray.Length; j++)
            {
                for (int i = intArray.Length - 1; i > j; i--)
                {
                    if (intArray[i - 1] < intArray[i])
                    {
                        int temp = intArray[i - 1];
                        intArray[i - 1] = intArray[i];
                        intArray[i] = temp;
                    }
                }
            }
            return intArray;
        }

    }
}
