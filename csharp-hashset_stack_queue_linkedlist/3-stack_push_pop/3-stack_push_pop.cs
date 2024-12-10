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
            // Print the item at the top of the stack without removing it
            Console.WriteLine($"Top item: {aStack.Peek()}");
        }

        // Check if the stack contains the search item
        bool containsSearch = aStack.Contains(search);
        Console.WriteLine($"Stack contains {search}: {containsSearch}");

        // If the stack contains the search item, remove all items up to and including it
        if (containsSearch)
        {
            Stack<string> tempStack = new Stack<string>();

            // Transfer items to a temporary stack until the search item is found
            while (aStack.Count > 0)
            {
                string currentItem = aStack.Pop();
                if (currentItem == search)
                {
                    break; // Stop once the search item is found
                }
                tempStack.Push(currentItem);
            }

            // Return items from the temporary stack to the original stack
            while (tempStack.Count > 0)
            {
                aStack.Push(tempStack.Pop());
            }
        }

        // Add the new item to the stack
        aStack.Push(newItem);

        // Return the modified stack
        return aStack;
    }

}