using System;

namespace Algorithm
{
    /// <summary>
    /// Selection Sort uses O(n^2)
    /// </summary>
    public class SelectionsSort
    {

        /// <summary>
        /// Sorts an array of integer values using the selection sort algorithm
        /// </summary>
        /// <param name="intArray"></param>
        /// <returns>An array of sorted integers in ascending order</returns>
        public int[] SortAscending(int[] intArray)
        {

            for (int i = 0; i < intArray.Length; i++)
            {
                int lowestNumber = int.MaxValue; //.......we assume lowest number is max value
                int lowestNumberIndex = 0;

                for (int j = i; j < intArray.Length; j++)
                {
                    if (intArray[j] < lowestNumber)
                    {
                        lowestNumber = intArray[j];
                        lowestNumberIndex = j;
                    }
                }

                if (lowestNumber != i) //......if the lowest numbers index does not equal the current iteration of swaping we're on then swap
                {
                    intArray[lowestNumberIndex] = intArray[i];
                    intArray[i] = lowestNumber;
                }
            }

            return intArray;
        }


        /// <summary>
        /// Sorts an array of integer values using the selection sort algorithm
        /// </summary>
        /// <param name="intArray"></param>
        /// <returns>An array of sorted integers in descending order</returns>
        public int[] SortDescending(int[] intArray)
        {

            for (int i = 0; i < intArray.Length; i++)
            {
                int highestNumber = int.MinValue; //.......we assume lowest number is min value
                int highestNumberIndex = 0;

                for (int j = i; j < intArray.Length; j++)
                {
                    if (intArray[j] > highestNumber)
                    {
                        highestNumber = intArray[j];
                        highestNumberIndex = j;
                    }
                }

                if (highestNumber != i) //......if the highest numbers index does not equal the current iteration of swaping we're on then swap
                {
                    intArray[highestNumberIndex] = intArray[i];
                    intArray[i] = highestNumber;
                }
            }

            return intArray;
        }


    }
}
