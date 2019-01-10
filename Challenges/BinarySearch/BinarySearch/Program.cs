using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            Console.WriteLine("Enter a number who's index you would like to find that is between 1 and 15.");
            int searchIndex = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The index of the number you searched for is  " + BinarySearch(numbers, searchIndex));
            Console.ReadKey(); 
        }

        public static int BinarySearch(int[] numbers, int findIndex)
        {
            int middleIndex;
            int leftIndex = 0;
            int rightIndex = numbers.Length - 1;

            while (leftIndex <= rightIndex)
            {
                middleIndex = (rightIndex +leftIndex) / 2;

                
                if (numbers [middleIndex] == findIndex)
                {
                    return middleIndex;
                }
                else
                {
                    if (numbers[middleIndex] > findIndex)
                    {
                        rightIndex = middleIndex - 1;
                    }
                    else
                    {
                        leftIndex = middleIndex + 1;
                    }
                }
            }

            return -1;
        }
    }
}
