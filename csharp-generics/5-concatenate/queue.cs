using System;

/// <summary>
/// Generic Queue class
/// </summary>
/// <typeparam name="T">Type of values in the queue</typeparam>
public class Queue<T>
{
	/// <summary>Node class for Queue</summary>
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
			head = tail = newNode;
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

	/// <summary>Removes the first node and returns its value</summary>
	public T Dequeue()
	{
		if (head == null)
		{
			Console.WriteLine("Queue is empty");
			return default(T);
		}

		T value = head.value;
		head = head.next;
		count--;

		if (head == null)
			tail = null;

		return value;
	}

	/// <summary>Returns the value of the first node without removing it</summary>
	public T Peek()
	{
		if (head == null)
		{
			Console.WriteLine("Queue is empty");
			return default(T);
		}

		return head.value;
	}

	/// <summary>Prints all values in the queue from head to tail</summary>
	public void Print()
	{
		if (head == null)
		{
			Console.WriteLine("Queue is empty");
			return;
		}

		Node current = head;
		while (current != null)
		{
			Console.WriteLine(current.value);
			current = current.next;
		}
	}

	/// <summary>Concatenates all values if type is string or char</summary>
	public string Concatenate()
	{
		if (head == null)
		{
			Console.WriteLine("Queue is empty");
			return null;
		}

		Type type = typeof(T);
		if (type != typeof(string) && type != typeof(char))
		{
			Console.WriteLine("Concatenate is for a queue of Strings or Chars only.");
			return null;
		}

		Node current = head;
		string result = "";

		while (current != null)
		{
			result += current.value;
			if (type == typeof(string) && current.next != null)
				result += " ";
			current = current.next;
		}

		return result;
	}
}
