using System;
using Algorithm.ListSearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithm.Test.ListSearch
{
    [TestClass]
    public class LinearSearchTest
    {
        int[] intArray = { 5, 9, 3, 1, 2, 8, 4, 7, 6 };


        [TestMethod]
        public void SearchByLinear()
        {
            int index = 1;
            int indexOfNine = LinearSearch.Search(intArray, 9);

            Assert.IsTrue(index.Equals(indexOfNine));
        }

    }
}
