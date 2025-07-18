using System;
using System.Collections;
using System.Collections.Generic;

/// <summary>Base abstract class</summary>
public abstract class Base
{
	/// <summary>Name of the object</summary>
	public string name { get; set; }

	/// <summary>Returns a string with the object's name and type</summary>
	public override string ToString() => $"{name} is a {this.GetType().Name}";
}

/// <summary>Interface for interactive behavior</summary>
public interface IInteractive
{
	/// <summary>Defines the interaction behavior of an object</summary>
	void Interact();
}

/// <summary>Interface for breakable behavior</summary>
public interface IBreakable
{
	/// <summary>Durability of the object</summary>
	int durability { get; set; }

	/// <summary>Defines how the object behaves when broken</summary>
	void Break();
}

/// <summary>Interface for collectable behavior</summary>
public interface ICollectable
{
	/// <summary>Indicates whether the object has been collected</summary>
	bool isCollected { get; set; }

	/// <summary>Defines how the object behaves when collected</summary>
	void Collect();
}

/// <summary>Door class that is interactive</summary>
public class Door : Base, IInteractive
{
	/// <summary>Initializes a new instance of the Door class</summary>
	public Door(string name = "Door") => this.name = name;

	/// <summary>Defines how the door reacts when interacted with</summary>
	public void Interact() => Console.WriteLine($"You try to open the {name}. It's locked.");
}

/// <summary>Decoration class implementing multiple interfaces</summary>
public class Decoration : Base, IInteractive, IBreakable
{
	/// <summary>Durability level of the decoration</summary>
	public int durability { get; set; }

	/// <summary>Indicates whether the decoration is a quest item</summary>
	public bool isQuestItem;

	/// <summary>Initializes a new instance of the Decoration class</summary>
	public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
	{
		this.name = name;
		this.durability = durability;
		this.isQuestItem = isQuestItem;
	}

	/// <summary>Defines how the decoration reacts when interacted with</summary>
	public void Interact()
	{
		if (durability <= 0)
			Console.WriteLine($"The {name} has been broken.");
		else if (isQuestItem)
			Console.WriteLine($"You look at the {name}. There's a key inside.");
		else
			Console.WriteLine($"You look at the {name}. Not much to see here.");
	}

	/// <summary>Reduces durability or reports that the decoration is broken</summary>
	public void Break()
	{
		durability--;
		if (durability > 0)
			Console.WriteLine($"You hit the {name}. It cracks.");
		else if (durability == 0)
			Console.WriteLine($"You smash the {name}. What a mess.");
		else
			Console.WriteLine($"The {name} is already broken.");
	}
}

/// <summary>Key class that is collectable</summary>
public class Key : Base, ICollectable
{
	/// <summary>Indicates whether the key has been collected</summary>
	public bool isCollected { get; set; }

	/// <summary>Initializes a new instance of the Key class</summary>
	public Key(string name = "Key", bool isCollected = false)
	{
		this.name = name;
		this.isCollected = isCollected;
	}

	/// <summary>Defines how the key behaves when collected</summary>
	public void Collect()
	{
		if (!isCollected)
		{
			isCollected = true;
			Console.WriteLine($"You pick up the {name}.");
		}
		else
			Console.WriteLine($"You have already picked up the {name}.");
	}
}

/// <summary>Generic iterable collection class</summary>
public class Objs<T> : IEnumerable<T>
{
	private List<T> items = new List<T>();
	/// <summary>Adds an item to the collection</summary>
	public void Add(T item) => items.Add(item);

	/// <summary>Returns an enumerator that iterates through the collection</summary>
	public IEnumerator<T> GetEnumerator() => items.GetEnumerator();

	IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
