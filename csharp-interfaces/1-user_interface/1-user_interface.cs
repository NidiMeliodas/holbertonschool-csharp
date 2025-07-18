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

/// <summary>Interface for interactive objects</summary>
public interface IInteractive
{
	/// <summary>Method to interact with an object</summary>
	void Interact();
}

/// <summary>Interface for breakable objects</summary>
public interface IBreakable
{
	/// <summary>Durability of the object</summary>
	int durability { get; set; }

	/// <summary>Break the object</summary>
	void Break();
}

/// <summary>Interface for collectable objects</summary>
public interface ICollectable
{
	/// <summary>Whether the object is collected</summary>
	bool isCollected { get; set; }

	/// <summary>Collect the object</summary>
	void Collect();
}

/// <summary>Test class that implements all interfaces</summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
	/// <summary>Durability of the object</summary>
	public int durability { get; set; }

	/// <summary>Whether the object is collected</summary>
	public bool isCollected { get; set; }

	/// <summary>Interact with the object</summary>
	public void Interact() { }

	/// <summary>Break the object</summary>
	public void Break() { }

	/// <summary>Collect the object</summary>
	public void Collect() { }
}
