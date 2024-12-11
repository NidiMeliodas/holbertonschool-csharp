using System;
using System.Collections.Generic;

public class LList
{
	public static void Delete(LinkedList<int> myLList, int index)
	{
		if (myLList == null || index < 0)
		{
			// If the list is null or the index is invalid, do nothing
			return;
		}

		int currentIndex = 0;
		LinkedListNode<int> current = myLList.First;

		// Traverse the list to find the node at the specified index
		while (current != null)
		{
			if (currentIndex == index)
			{
				// Remove the node when the index matches
				myLList.Remove(current);
				return;
			}

			current = current.Next;
			currentIndex++;
		}
	}
}
