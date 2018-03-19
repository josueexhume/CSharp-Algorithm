using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Algorithm.Test
{
    [TestClass]
    public class InsertionSortTest
    {
        int[] intArray = { 5, 9, 3, 1, 2, 8, 4, 7, 6 };


        [TestMethod]
        public void InsertionSortAscending()
        {
            int[] sortedInteger = new InsertionSort().SortAscending(intArray);
            int[] assumedOrder = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            PrintArrayValues(sortedInteger);

            Assert.IsTrue(sortedInteger.SequenceEqual(assumedOrder));
        }

        public static void PrintArrayValues(int[] unsortedArray)
        {
            foreach (var item in unsortedArray)
            {
                Console.Write(item + ",");
            }
        }
    }
}
