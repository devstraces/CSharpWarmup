
int[] arr = { 4, 7, 1, 9, 3 };
int result = FindMax(arr);
Console.WriteLine("Maximum element is: " + result);


int[] arr2 = {1, 2, 3, 4, 5};
ReverseArray(arr2);
 foreach(int num in arr2)
  {
       Console.Write(num + " ");
  }

Console.Read();
 
 //Sample Data 


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


 static void ReverseArray(int[] arr)
 {
     int left = 0;
        int right = arr.Length - 1;

        while(left < right)
        {
            // swap
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;

            left++;
            right--;
        }
 }
    