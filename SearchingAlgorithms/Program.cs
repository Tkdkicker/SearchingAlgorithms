using System;

namespace SearchingAlgorithms
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] linearSearch =
            {2, 3, 6, 1, 7, 9, 5 };

            int[] binarySearch =
            {1, 3, 4, 5, 6, 7, 9 };

            LinearSearch(linearSearch);
            Console.WriteLine("\n");
            BinarySearch(binarySearch);
        }

        #region LinearSearch

        public static void LinearSearch(int[] linearSearch)
        {
            Console.WriteLine("This is the linear search\nEnter a number to search out of this list:");

            foreach (int start in linearSearch)
            {
                Console.Write(start + " ");
            }
            Console.WriteLine("\n");
            int searchedElement = int.Parse(Console.ReadLine());

            for (int sort = 0; sort < linearSearch.Length; sort++)
            {
                if (linearSearch[sort] != -1 && linearSearch[sort] == searchedElement)
                {
                    Console.WriteLine("The searched element's index is: " + sort);
                    return;
                }
            }
            Console.WriteLine("The searched element wasn't found");
        }

        #endregion LinearSearch

        #region BinarySearch

        public static void BinarySearch(int[] binarySearch)
        {
            int midIndex = binarySearch.Length / 2;//3
            int minValue = 0;
            int midValue = binarySearch[binarySearch.Length / 2];//5
            int maxIndex = binarySearch.Length - 1;//6

            Console.WriteLine("This is the binary search\nEnter a number to search out of this list:");

            foreach (int start in binarySearch)
            {
                Console.Write(start + " ");
            }
            Console.WriteLine("\n");
            int searchedElement = int.Parse(Console.ReadLine());

            while (minValue <= maxIndex)//0 is less than or equal to 6
            {
                if (searchedElement < midValue)//Less than the middle number (5 and 3)
                {
                    maxIndex = midIndex - 1;
                    midIndex = (maxIndex - minValue) / 2;
                    midValue = binarySearch[midIndex];//Assign the new midIndex value to the midValue
                }
                if (searchedElement > midValue)//More than the middle number (5 and 7)
                {
                    minValue = midIndex + 1;
                    midIndex = (maxIndex + minValue) / 2;
                    midValue = binarySearch[midIndex];//Assign the new midInced value to the midValue
                }
                else if (searchedElement == midValue)//Is or narrowed it down to become the middle number
                {
                    Console.WriteLine("The searched element's index is: " + midIndex);
                    return;
                }
            }
            Console.WriteLine("The searched element wasn't found");
        }

        #endregion BinarySearch
    }
}