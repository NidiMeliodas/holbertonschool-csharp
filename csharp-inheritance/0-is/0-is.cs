using System;

/// <summary>
/// Contains method to check if an object is of type int.
/// </summary>
public class Obj
{
    /// <summary>
    /// Determines whether the specified object is of type int.
    /// </summary>
    /// <param name="obj">The object to check.</param>
    /// <returns>true if obj is an int; otherwise, false.</returns>
    public static bool IsOfTypeInt(object obj)
    {
        return obj is int;
    }
}
