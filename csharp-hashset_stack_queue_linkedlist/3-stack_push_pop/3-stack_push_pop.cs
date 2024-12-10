using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine($"Number of items: {aStack.Count}");

        if (aStack.Count != 0)
        {
            Console.WriteLine($"Top item: {aStack.Peek()}");
        }
        else
        {
            Console.WriteLine("Stack is empty");
        }

        // Check if the stack contains the search item
        if (aStack.Contains(search))
        {
            Console.WriteLine($"Stack contains \"{search}\": {aStack.Contains(search)}");

            // P0p elements until the search item is removed
            while (aStack.Contains(search))
            {
                aStack.Pop();
            }
        }

        // If search item is not in the stack anymore, push new item
        if (!aStack.Contains(search))
        {
            Console.WriteLine($"Pushing \"{newItem}\" onto the stack.");
            aStack.Push(newItem);
        }

        return aStack;
    }
}
