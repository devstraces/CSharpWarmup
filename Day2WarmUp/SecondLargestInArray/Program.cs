using System;
class SecondLargestInArray
{
    static void Main()
    {
        int[] arr = { 1, 3, 6, 2, 4, 7, 8};
        for (int pass = 0; pass < arr.Length - 1; pass++)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        int temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
        }
        if (arr.Length > 1)
        {
            Console.WriteLine($"Second Highest Number: {arr[1]}");
        }
        else
        {
            Console.WriteLine("No second highest number");
        }
    }
}