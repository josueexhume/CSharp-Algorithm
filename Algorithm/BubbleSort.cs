using System;

namespace Algorithm
{
    /// <summary>
    /// Bubble Sort uses O(n^2)
    /// </summary>
    public class BubbleSort
    {

        /// <summary>
        /// Sorts an array of arbitrary type <typeparamref name="T"/> in ascending order, that implements the interface IComparable.
        /// </summary>
        /// <param name="array"></param>
        /// <returns>An array of generic types in ascending order</returns>
        public T[] SortAscending<T>(T[] array) where T : IComparable<T>
        {
            for (int j = 0; j < array.Length; j++)
            {
                for (int i = array.Length - 1; i > j; i--)
                {
                    if (array[i - 1].CompareTo(array[i]) > 0)
                    {
                        T temp = array[i - 1];
                        array[i - 1] = array[i];
                        array[i] = temp;
                    }
                }
            }
            return array;
        }

        /// <summary>
        /// Sorts an array of arbitrary type <typeparamref name="T"/> in descending order, that implements the interface IComparable.
        /// </summary>
        /// <param name="intArray"></param>
        /// <returns>An array of generic types in descending order</returns>
        public T[] SortDescending<T>(T[] intArray) where T : IComparable<T>
        {
            for (int j = 0; j < intArray.Length; j++)
            {
                for (int i = intArray.Length - 1; i > j; i--)
                {
                    if (intArray[i - 1].CompareTo(intArray[i]) < 0)
                    {
                        T temp = intArray[i - 1];
                        intArray[i - 1] = intArray[i];
                        intArray[i] = temp;
                    }
                }
            }
            return intArray;
        }

    }
}
