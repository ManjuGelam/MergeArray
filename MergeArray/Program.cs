using System;
using System.Linq;

namespace MergeArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;

            int[] arr1 = new int[5] { 1, 2, 3, 4, 5 };
            int[] arr2 = new int[5] { 6, 7, 8, 9, 10 };
            int[] merged = new int[10];


            for (i = 0, j = 0; i < 5; i++)
            {
                merged[j++] = arr1[i];
            }
            for (i = 0; i < 5; i++)
            {
                merged[j++] = arr2[i];
            }
            Console.WriteLine("after merging Array elements :");
            for (i = 0; i < 10; i++)
            {
                Console.Write(merged[i] + " ");
            }

            Console.ReadLine();

        }
    }
}
