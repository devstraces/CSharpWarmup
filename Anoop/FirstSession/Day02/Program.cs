using System;
using System.Collections.Generic;

namespace Day02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 10, 20, 20, 30, 40, 40, 50, 10 };

            int[] result = RemoveDuplicates(input);

            Console.WriteLine("Array after removing duplicates:");

            foreach (int num in result)
            {
                Console.Write(num + " ");
            }

            Console.ReadLine();
        }

        static int[] RemoveDuplicates(int[] arr)
        {
            
            HashSet<int> uniqueValues = new HashSet<int>();

            foreach (int num in arr)
            {
                uniqueValues.Add(num);
            }            
            int[] result = new int[uniqueValues.Count];
            uniqueValues.CopyTo(result);

            return result;
        }
    }
}
