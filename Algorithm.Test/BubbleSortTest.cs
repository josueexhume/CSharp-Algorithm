using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Algorithm.Test
{
    [TestClass]
    public class BubbleSortTest
    {
        int[] intArray = { 5, 9, 3, 1, 2, 8, 4, 7, 6 };


        [TestMethod]
        public void SortAscending()
        {
            int[] sortedInteger = new BubbleSort().SortAscending(intArray);
            int[] assumedOrder = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };


            Assert.IsTrue(sortedInteger.SequenceEqual(assumedOrder));
        }

        [TestMethod]
        public void SortDescending()
        {
            int[] sortedInteger = new BubbleSort().SortDescending(intArray);
            int[] assumedOrder = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            Assert.IsTrue(sortedInteger.SequenceEqual(assumedOrder));
        }
    }
}
