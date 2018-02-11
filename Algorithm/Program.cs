using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] intArray = { 5, 9, 3, 1, 2, 8, 4, 7, 6 };
            intArray = new BubbleSort().SortAscending(intArray);
            PrintArrayValues(intArray);
            intArray = new BubbleSort().SortDescending(intArray);
            PrintArrayValues(intArray);

            Console.ReadLine();
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
