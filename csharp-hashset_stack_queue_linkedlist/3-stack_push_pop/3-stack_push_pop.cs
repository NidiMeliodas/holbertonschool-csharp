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
            // Use a single Pop() to get all items in reverse order
            List<string> reversedItems = new List<string>();
            string poppedItem = aStack.Pop(); // Single Pop() operation

            // Store the popped item and all remaining elements
            reversedItems.Add(poppedItem);
            while (aStack.Count > 0)
            {
                reversedItems.Add(aStack.Peek()); // Look at the next item
                aStack.Pop(); // We already popped once, just iterating now
            }

            // Rebuild the stack without items up to and including 'search'
            bool found = false;
            for (int i = reversedItems.Count - 1; i >= 0; i--)
            {
                if (reversedItems[i] == search && !found)
                {
                    found = true; // Skip the 'search' item
                    continue;
                }
                aStack.Push(reversedItems[i]);
            }
        }

        // Add the new item to the stack
        aStack.Push(newItem);

        // Return the updated stack
        return aStack;
    }
}