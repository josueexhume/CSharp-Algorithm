using System;

namespace Algorithm
{
    /// <summary>
    /// Insertion Sort uses O(n^2)
    /// </summary>
    public class InsertionSort
    {

        /// <summary>
        /// Sorts an array of integer values using the selection sort algorithm in ascending order
        /// </summary>
        /// <param name="intArray"></param>
        /// <returns>An array of sorted integers in ascending order</returns>
        public int[] SortAscending(int[] intArray)
        {

            for (int i = 0; i < intArray.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (intArray[j] < intArray[j - 1])
                    {
                        int temp = intArray[j - 1];
                        intArray[j - 1] = intArray[j];
                        intArray[j] = temp;
                    }
                }
            }

            return intArray;
        }


    }
}
