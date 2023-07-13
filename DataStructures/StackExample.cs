using System;
using System.Collections.Generic;


    class StacksExample
    {
        public static void Run(int[] numbers)
        {
            Stack<int> stack = new Stack<int>(numbers);
            Console.WriteLine("Stack:");
            while (stack.Count > 0)
            {
                int element = stack.Pop();
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
