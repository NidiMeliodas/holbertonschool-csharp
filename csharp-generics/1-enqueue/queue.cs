using System;

/// <summary>
/// Generic Queue class
/// </summary>
/// <typeparam name="T">Type of values in the queue</typeparam>
public class Queue<T>
{
	/// <summary>
	/// Node class for Queue
	/// </summary>
	public class Node
	{
		/// <summary>Value of the node</summary>
		public T value = default(T);

		/// <summary>Reference to the next node</summary>
		public Node next = null;

		/// <summary>Constructor to create a new node with a value</summary>
		public Node(T val)
		{
			value = val;
		}
	}

	/// <summary>Points to the head of the queue</summary>
	public Node head = null;

	/// <summary>Points to the tail of the queue</summary>
	public Node tail = null;

	/// <summary>Number of nodes in the queue</summary>
	public int count = 0;

	/// <summary>Returns the type of the queue's generic parameter</summary>
	public Type CheckType()
	{
		return typeof(T);
	}

	/// <summary>Adds a new node to the end of the queue</summary>
	public void Enqueue(T val)
	{
		Node newNode = new Node(val);

		if (head == null)
		{
			head = newNode;
			tail = newNode;
		}
		else
		{
			tail.next = newNode;
			tail = newNode;
		}
		count++;
	}

	/// <summary>Returns the number of nodes in the queue</summary>
	public int Count()
	{
		return count;
	}
}
