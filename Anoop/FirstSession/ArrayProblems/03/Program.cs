         int[] arr = { 10, 5, 20, 8 };

            int result = FindSecondLargest(arr);

            Console.WriteLine("Second largest element is: " + result);

            Console.ReadLine();

        static int FindSecondLargest(int[] arr)
        {
            int largest = int.MinValue;
            int secondLargest = int.MinValue;

            foreach (int num in arr)
            {
                if (num > largest)
                {
                    secondLargest = largest;
                    largest = num;
                }
                else if (num > secondLargest && num != largest)
                {
                    secondLargest = num;
                }
            }

            return secondLargest;
        }