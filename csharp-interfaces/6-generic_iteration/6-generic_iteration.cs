using System;
using System.Collections;
using System.Collections.Generic;

/// <summary>Base class for all objects</summary>
public abstract class Base
{
	/// <summary>Name of the object</summary>
	public string name { get; set; }

	/// <summary>Returns a string representation of the object</summary>
	public override string ToString()
	{
		return ($"{this.name} is a {this.GetType().Name}");
	}
}

/// <summary>Interface for interactive objects</summary>
public interface IInteractive
{
	/// <summary>Interact with the object</summary>
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
	/// <summary>Check if the object has been collected</summary>
	bool isCollected { get; set; }

	/// <summary>Collect the object</summary>
	void Collect();
}

/// <summary>Represents a Door object</summary>
public class Door : Base, IInteractive
{
	/// <summary>Constructor for Door</summary>
	public Door(string name = "Door")
	{
		this.name = name;
	}

	/// <summary>Interact with the Door</summary>
	public void Interact()
	{
		Console.WriteLine("You try to open the {0}. It's locked.", this.name);
	}
}

/// <summary>Represents a Decoration object</summary>
public class Decoration : Base, IInteractive, IBreakable
{
	/// <summary>Durability of the decoration</summary>
	public int durability { get; set; }

	/// <summary>Is the decoration a quest item</summary>
	public bool isQuestItem { get; set; }

	/// <summary>Constructor for Decoration</summary>
	public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
	{
		if (durability <= 0)
			throw new ArgumentException("Durability must be greater than 0");
		this.name = name;
		this.durability = durability;
		this.isQuestItem = isQuestItem;
	}

	/// <summary>Interact with the decoration</summary>
	public void Interact()
	{
		if (this.durability <= 0)
			Console.WriteLine("The {0} has been broken.", this.name);
		else if (this.isQuestItem)
			Console.WriteLine("You look at the {0}. There's a key inside.", this.name);
		else
			Console.WriteLine("You look at the {0}. Not much to see here.", this.name);
	}

	/// <summary>Break the decoration</summary>
	public void Break()
	{
		this.durability--;
		if (this.durability > 0)
			Console.WriteLine("You hit the {0}. It cracks.", this.name);
		else if (this.durability == 0)
			Console.WriteLine("You smash the {0}. What a mess.", this.name);
	}
}

/// <summary>Represents a Key object</summary>
public class Key : Base, ICollectable
{
	/// <summary>Check if the key has been collected</summary>
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
		if (!this.isCollected)
		{
			this.isCollected = true;
			Console.WriteLine("You pick up the {0}.", this.name);
		}
		else
		{
			Console.WriteLine("You have already picked up the {0}.", this.name);
		}
	}
}

/// <summary>Generic collection class that implements IEnumerable</summary>
public class Objs<T> : IEnumerable<T>
{
	/// <summary>Internal list of objects</summary>
	private List<T> _objs = new List<T>();

	/// <summary>Adds an item to the collection</summary>
	public void Add(T item)
	{
		_objs.Add(item);
	}

	/// <summary>Returns an enumerator for the collection</summary>
	public IEnumerator<T> GetEnumerator()
	{
		return _objs.GetEnumerator();
	}

	/// <summary>Returns an enumerator for the collection (non-generic)</summary>
	IEnumerator IEnumerable.GetEnumerator()
	{
		return this.GetEnumerator();
	}
}
