using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> linkedList = new LinkedList<int>();

        // Handle negative size by returning an empty LinkedList
        if (size < 0)
        {
            return linkedList;
        }

        for (int i = 0; i < size; i++)
        {
            linkedList.AddLast(i);
            Console.WriteLine(i); // Print the integer as it's added
        }

        return linkedList;
    }
}
