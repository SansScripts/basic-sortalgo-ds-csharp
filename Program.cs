using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[10];

        Console.WriteLine("Enter 10 numbers:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Number {0}: ", i + 1);
            string input = Console.ReadLine();
            if (input != null)
            {
                numbers[i] = int.TryParse(input, out int number) ? number : 0;
            }
            else
            {
                // Handle the case when no input is provided
                Console.WriteLine("No input provided for Number {0}.", i + 1);
                i--; // Decrement the counter to re-prompt for the number
            }
        }

        Console.WriteLine("\nArray Example:");
        ArrayExample.Run(numbers);

        Console.WriteLine("\nLinked List Example:");
        LinkedListExample.Run(numbers);

        Console.WriteLine("\nStack Example:");
        StacksExample.Run(numbers);

        Console.WriteLine("\nQueue Example:");
        QueueExample.Run(numbers);

        Console.WriteLine("\nBinary Search Example:");
        BinarySearchExample.Run(numbers);

        Console.WriteLine("\nBubble Sort Example:");
        BubbleSortExample.Run(numbers);

        Console.WriteLine("\nInsertion Sort Example:");
        InsertionSortExample.Run(numbers);

        Console.WriteLine("\nMerge Sort Example:");
        MergeSortExample.Run(numbers);

        Console.WriteLine("\nQuick Sort Example:");
        QuickSortExample.Run(numbers);

        Console.WriteLine("\nHeap Sort Example:");
        HeapSortExample.Run(numbers);
    }
}
