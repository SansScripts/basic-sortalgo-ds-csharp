using System;

class ArrayExample
{
    public static void Run(int[] numbers)
    {
        Console.WriteLine("Array:");
        foreach (int element in numbers)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}
