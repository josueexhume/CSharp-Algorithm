using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.ListSearch
{
    public class LinearSearch
    {

        /// <summary>
        /// Search through elements in array an array and returns it's index once found. If no index is found then -1 is returned.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="value"></param>
        /// <returns>index of value in array, if no index found then it returns -1</returns>
        public static int Search<T>(T[] array, T value) where T : IEquatable<T>
        {
            int arrayLength = array.Length;
            for (int i = 0; i < arrayLength; i++)
            {
                if (array[i].Equals(value))
                {
                    return i;
                }
            }

            return -1;

            //a short hand could be just using array's index of
            //return Array.IndexOf(array, value);
        }
    }
}
