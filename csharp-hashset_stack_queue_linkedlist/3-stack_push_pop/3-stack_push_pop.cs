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

        // If the stack contains the search item, remove items up to and including search
        if (containsSearch)
        {
            Stack<string> tempStack = new Stack<string>();
            string poppedItem = null;

            // Use only one Pop() call
            do
            {
                poppedItem = aStack.Pop(); // Single Pop() call
                tempStack.Push(poppedItem);
            } while (poppedItem != search && aStack.Count > 0);

            // Restore the remaining items back into the original stack
            while (tempStack.Count > 0 && tempStack.Peek() != search)
            {
                tempStack.Pop(); // Discard items up to the search element
            }
            tempStack.Pop(); // Discard the search element itself

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
