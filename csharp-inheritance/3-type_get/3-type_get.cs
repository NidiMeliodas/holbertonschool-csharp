using System;
using System.Reflection;

/// <summary>
/// Provides reflection utilities.
/// </summary>
public class Obj
{
	/// <summary>
	/// Prints all properties and methods of the object's type.
	/// </summary>
	/// <param name="myObj">The object whose type members will be printed.</param>
	public static void Print(object myObj)
	{
		Type type = myObj.GetType();

		Console.WriteLine($"{type.Name} Properties:");
		foreach (PropertyInfo prop in type.GetProperties())
		{
			Console.WriteLine(prop.Name);
		}

		Console.WriteLine($"{type.Name} Methods:");
		foreach (MethodInfo method in type.GetMethods())
		{
			Console.WriteLine(method.Name);
		}
	}
}
