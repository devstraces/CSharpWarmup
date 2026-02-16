
int[] arr = { 4, 7, 1, 9, 3 };
int result = FindMax(arr);
Console.WriteLine("Maximum element is: " + result);




// Function to find the maximum element in an array
static int FindMax(int[] arr)
{
    int max = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }

    return max;
}