using System;
using System.Collections.Generic;

class List
{
    // Method to find common elements in two lists and return them in sorted order
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        // Create a HashSet to store common elements
        HashSet<int> commonSet = new HashSet<int>();

        // Iterate through the first list and add the elements to the HashSet
        foreach (int num in list1)
        {
            // If the second list contains the number, add it to the commonSet
            if (list2.Contains(num))
            {
                commonSet.Add(num);
            }
        }

        // Convert the HashSet to a List for sorting
        List<int> commonList = new List<int>(commonSet);

        // Sort the list
        commonList.Sort();

        // Return the sorted list of common elements
        return commonList;
    }
}