using System;
using System.Collections.Generic;

class LinkedListExample
{
    public static void Run(int[] numbers)
    {
        LinkedList<int> linkedList = new LinkedList<int>(numbers);
        Console.WriteLine("Linked List:");
        foreach (int element in linkedList)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}
