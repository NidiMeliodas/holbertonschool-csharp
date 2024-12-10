using System;
using System.Collections.Generic;

public class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        // Print the number of items in the stack
        Console.WriteLine($"Number of items: {aStack.Count}");

        // Check if the stack is empty
        if (aStack.Count == 0)
        {
            Console.WriteLine("Stack is empty");
        }
        else
        {
            // Print the top item of the stack without removing it
            Console.WriteLine($"Top item: {aStack.Peek()}");
        }

        // Check if the stack contains the search item
        bool containsSearch = aStack.Contains(search);
        Console.WriteLine($"Stack contains {search}: {containsSearch}");

        if (containsSearch)
        {
            // Single Pop() operation
            string poppedItem = aStack.Pop();

            // Rebuild stack without items up to and including 'search'
            Stack<string> tempStack = new Stack<string>();

            // Push only items we want to keep onto the temp stack
            while (poppedItem != search && aStack.Count > 0)
            {
                tempStack.Push(poppedItem);
                poppedItem = aStack.Pop(); // One Pop is happening here
            }

            // Re-add elements back to the original stack
            while (tempStack.Count > 0)
            {
                aStack.Push(tempStack.Pop());
            }
        }

        // Add the new item to the stack
        aStack.Push(newItem);

        // Return the updated stack
        return aStack;
    }
}