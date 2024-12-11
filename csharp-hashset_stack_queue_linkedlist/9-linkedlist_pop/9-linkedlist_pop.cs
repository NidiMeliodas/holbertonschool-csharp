using System;
using System.Collections.Generic;

public class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        // Check if the list is empty
        if (myLList.First == null)
        {
            return 0; // Return 0 if the list is empty
        }

        // Get the value of the head node
        int headValue = myLList.First.Value;

        // Remove the head node
        myLList.RemoveFirst();

        // Return the value of the removed head node
        return headValue;
    }
}
