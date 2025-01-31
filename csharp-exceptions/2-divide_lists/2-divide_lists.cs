using System;
using System.Collections.Generic;

class List
{
	public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
	{
		List<int> resultList = new List<int>();

		for (int i = 0; i < listLength; i++)
		{
			try
			{
				if (i >= list1.Count || i >= list2.Count)
				{
					Console.WriteLine("Out of range");
				}
				else if (list2[i] == 0)
				{
					Console.WriteLine("Cannot divide by zero");
					resultList.Add(0);
				}
				else
				{
					resultList.Add(list1[i] / list2[i]);
				}
			}
			catch (Exception)
			{
				resultList.Add(0);
			}
		}

		return resultList;
	}
}