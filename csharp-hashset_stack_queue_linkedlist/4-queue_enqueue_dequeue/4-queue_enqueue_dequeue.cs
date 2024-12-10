using System;
using System.Collections.Generic;

public class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        // Print the number of items in the queue
        Console.WriteLine($"Number of items: {aQueue.Count}");

        // Check if the queue is empty
        if (aQueue.Count == 0)
        {
            Console.WriteLine("Queue is empty");
        }
        else
        {
            // Print the first item in the queue without removing it
            Console.WriteLine($"First item: {aQueue.Peek()}");
        }

        // Check if the queue contains the search item
        bool containsSearch = aQueue.Contains(search);
        Console.WriteLine($"Queue contains {search}: {containsSearch}");

        // If the queue contains the search item, remove items up to and including it
        if (containsSearch)
        {
            Queue<string> tempQueue = new Queue<string>();

            // Transfer items to a temporary queue until the search item is found
            while (aQueue.Count > 0)
            {
                string currentItem = aQueue.Dequeue();
                if (currentItem == search)
                {
                    break; // Stop once the search item is found
                }
                tempQueue.Enqueue(currentItem);
            }

            // Return remaining items from the temporary queue back to the original queue
            while (tempQueue.Count > 0)
            {
                aQueue.Enqueue(tempQueue.Dequeue());
            }
        }

        // Add the new item to the queue
        aQueue.Enqueue(newItem);

        // Return the modified queue
        return aQueue;
    }
}