using System;

/// <summary>
/// Generic Queue class
/// </summary>
/// <typeparam name="T">The type of elements stored in the queue</typeparam>
public class Queue<T>
{
	/// <summary>
	/// Returns the type of the queue's generic parameter
	/// </summary>
	/// <returns>The type of the queue elements</returns>
	public Type CheckType()
	{
		return typeof(T);
	}
}
