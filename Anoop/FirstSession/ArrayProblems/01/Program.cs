using System;
using System.Collections.Generic;

namespace DataStructuresPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            int[] result = TwoSum(nums, target);

            Console.WriteLine("Indices found:");
            Console.WriteLine(result[0] + ", " + result[1]);

            Console.ReadLine();
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                // Check if complement exists
                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement], i };
                }

                // Store number and index
                map[nums[i]] = i;
            }

            return new int[] { -1, -1 };
        }
    }
}
