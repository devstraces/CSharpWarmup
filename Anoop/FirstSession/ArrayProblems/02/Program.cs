using System;

namespace BinarySearch
{
    /// <summary>
    /// Binary Search Implementation
    /// This program demonstrates the Binary Search algorithm to find a target element
    /// in a sorted array with O(log n) time complexity.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sorted array of integers
            int[] arr = { 2, 5, 8, 12, 16, 23, 38 };
            int target = 16;

            // Perform binary search
            int index = BinarySearch(arr, target);

            // Display result
            if (index != -1)
                Console.WriteLine($"Element found at index: {index}");
            else
                Console.WriteLine("Element not found");

            Console.ReadLine();
        }

        /// <summary>
        /// Binary Search Algorithm
        /// Searches for a target value in a sorted array by repeatedly dividing 
        /// the search interval in half.
        /// </summary>
        /// <param name="arr">Sorted array to search in</param>
        /// <param name="target">Element to find</param>
        /// <returns>Index of target if found, -1 otherwise</returns>
        static int BinarySearch(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            // Continue searching while there are elements to check
            while (left <= right)
            {
                // Calculate middle index (prevents integer overflow)
                int mid = left + (right - left) / 2;

                // Check if target is at middle
                if (arr[mid] == target)
                    return mid;

                // If target is greater, ignore left half
                else if (arr[mid] < target)
                    left = mid + 1;

                // If target is smaller, ignore right half
                else
                    right = mid - 1;
            }

            // Target not found
            return -1;
        }
    }
}
