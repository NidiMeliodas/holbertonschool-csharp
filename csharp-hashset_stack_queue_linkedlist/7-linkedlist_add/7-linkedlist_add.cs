using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Add(LinkedList<int> myLList, int n)
    {
        // Add the new node at the beginning of the LinkedList
        myLList.AddFirst(n);

        // Return the newly added node
        return myLList.First;
    }
}