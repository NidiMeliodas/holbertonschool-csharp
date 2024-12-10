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

        // Use a single  to remove all items up to and including search
        if (containsSearch)
        {
            List<string> tempList = new List<string>();

            //  only once and add it to the temporary list
            string poppedItem = aStack.Pop();
            tempList.Add(poppedItem);

            // Transfer the remaining stack elements to tempList using Peek()
            while (a)
