using System;
using System.Collections.Generic;

public class List
{
    // Method to find elements present in one list or the other but not both
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        // HashSet to track elements that are different
        HashSet<int> differenceSet = new HashSet<int>();

        // HashSet to track elements already seen in both lists
        HashSet<int> seenSet = new HashSet<int>();

        // Add elements from the first list
        foreach (int num in list1)
        {
            if (!seenSet.Add(num))
            {
                // If it's already in seenSet, remove from differenceSet
                differenceSet.Remove(num);
            }
            else
            {
                differenceSet.Add(num);
            }
        }

        // Add elements from the second list
        foreach (int num in list2)
        {
            if (!seenSet.Add(num))
            {
                // If it's already in seenSet, remove from differenceSet
                differenceSet.Remove(num);
            }
            else
            {
                differenceSet.Add(num);
            }
        }

        // Convert the differenceSet to a List and sort it
        List<int> result = new List<int>(differenceSet);
        result.Sort();

        return result;
    }
}