using System;
using System.Collections.Generic;

public class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        // Check if the index is invalid
        if (n < 0 || n >= myLList.Count)
        {
            return 0; // Return 0 if the index is out of range
        }

        // Iterate through the LinkedList to find the nth node
        int currentIndex = 0;
        foreach (int value in myLList)
        {
            if (currentIndex == n)
            {
                return value; // Return the value of the nth node
            }
            currentIndex++;
        }

        return 0; // If the index is not found (shouldn't happen due to bounds check)
    }
}
