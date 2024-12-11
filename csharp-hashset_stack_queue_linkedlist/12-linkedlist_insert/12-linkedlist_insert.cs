using System;
using System.Collections.Generic;

public class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> newNode = new LinkedListNode<int>(n);

        if (myLList.First == null || n <= myLList.First.Value)
        {
            // Insert at the beginning if the list is empty or if the value is smaller than the first node
            myLList.AddFirst(newNode);
        }
        else
        {
            LinkedListNode<int> current = myLList.First;

            // Traverse the list to find the correct position
            while (current.Next != null && current.Next.Value < n)
            {
                current = current.Next;
            }

            // Insert after the current node
            myLList.AddAfter(current, newNode);
        }

        return newNode;
    }
}
