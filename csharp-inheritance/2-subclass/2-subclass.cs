using System;

/// <summary>
/// Provides utility methods for type checking.
/// </summary>
public class Obj
{
	/// <summary>
	/// Returns true if derivedType is a subclass of baseType and not the same type.
	/// </summary>
	/// <param name="derivedType">The type to check.</param>
	/// <param name="baseType">The base type to compare with.</param>
	/// <returns>true if derivedType is a subclass of baseType and not the same type; otherwise, false.</returns>
	public static bool IsOnlyASubclass(Type derivedType, Type baseType)
	{
		return derivedType.IsSubclassOf(baseType);
	}
}

