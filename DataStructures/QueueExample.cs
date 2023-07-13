using System;
using System.Collections.Generic;

class QueueExample
{
    public static void Run(int[] numbers)
    {
        Queue<int> queue = new Queue<int>(numbers);
        Console.WriteLine("Queue:");
        while (queue.Count > 0)
        {
            int element = queue.Dequeue();
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}
