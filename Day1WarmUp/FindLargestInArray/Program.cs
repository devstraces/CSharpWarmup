using System;
class FindLargestInArray
{
    static void Main()
    {
        int[] num = { 1, 5, 2, 6, 7, 3, 9, 4 };
        int largestNum = 0;

        for (int pass = 0; pass < num.Length - 1; pass++)
        {
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] > largestNum)
                {
                    largestNum = num[i];
                }
            }
        }
        Console.WriteLine($"Largest Number is : {largestNum}");
    }
}