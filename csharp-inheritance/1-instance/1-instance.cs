using System;

/// <summary>
/// Provides utility methods for instance checking.
/// </summary>
public class Obj
{
	/// <summary>
	/// Returns true if obj is an instance of Array or a class that inherits from Array.
	/// </summary>
	/// <param name="obj">The object to check.</param>
	/// <returns>true if obj is an instance of Array or derived class; otherwise, false.</returns>
	public static bool IsInstanceOfArray(object obj)
	{
		return obj is Array;
	}
}