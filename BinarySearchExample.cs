using System;

class BinarySearchExample
{
    public static void Run(int[] numbers)
    {
        Console.Write("Enter a number to search: ");
        int target = int.Parse(Console.ReadLine());

        int index = BinarySearch(numbers, target);
        Console.WriteLine("Binary Search:");
        if (index != -1)
        {
            Console.WriteLine("Target found at index: " + index);
        }
        else
        {
            Console.WriteLine("Target not found in the array.");
        }
    }

    static int BinarySearch(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (arr[mid] == target)
            {
                return mid;
            }
            else if (arr[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return -1; // Target not found
    }
}
