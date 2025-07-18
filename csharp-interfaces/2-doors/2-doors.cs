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

/// <summary>Door class that can be interacted with</summary>
public class Door : Base, IInteractive
{
	/// <summary>Constructor - sets name (default "Door")</summary>
	public Door(string name = "Door")
	{
		this.name = name;
	}

	/// <summary>Interact with the door</summary>
	public void Interact()
	{
		Console.WriteLine($"You try to open the {name}. It's locked.");
	}
}
