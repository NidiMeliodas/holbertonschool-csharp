using System;

/// <summary>Abstract base class Base</summary>
public abstract class Base
{
	/// <summary>Name of the object</summary>
	public string name { get; set; }

	/// <summary>Returns string representation of the object</summary>
	public override string ToString()
	{
		return $"{name} is a {this.GetType().Name}";
	}
}

/// <summary>Interface for collectable objects</summary>
public interface ICollectable
{
	/// <summary>Whether the object is collected</summary>
	bool isCollected { get; set; }

	/// <summary>Collect the object</summary>
	void Collect();
}

/// <summary>Key class that can be collected</summary>
public class Key : Base, ICollectable
{
	/// <summary>Whether the key has been collected</summary>
	public bool isCollected { get; set; }

	/// <summary>Constructor for Key</summary>
	public Key(string name = "Key", bool isCollected = false)
	{
		this.name = name;
		this.isCollected = isCollected;
	}

	/// <summary>Collect the key</summary>
	public void Collect()
	{
		if (!isCollected)
		{
			isCollected = true;
			Console.WriteLine($"You pick up the {name}.");
		}
		else
		{
			Console.WriteLine($"You have already picked up the {name}.");
		}
	}
}
