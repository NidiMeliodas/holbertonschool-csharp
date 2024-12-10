using System;
using System.Collections.Generic;

class List
{
    // Method to sum unique integers in a given list
    public static int Sum(List<int> myList)
    {
        // Create a HashSet to store unique integers
        HashSet<int> uniqueIntegers = new HashSet<int>();

        // Add each integer from myList to the HashSet (duplicates will be ignored)
        foreach (int num in myList)
        {
            uniqueIntegers.Add(num);
        }

        // Return the sum of unique integers in the HashSet
        int sum = 0;
        foreach (int num in uniqueIntegers)
        {
            sum += num;
        }

        return sum;
    }
}