using System;
using System.Collections;
using System.Collections.Generic;

/// <summary>Base abstract class</summary>
public abstract class Base
{
	public string name { get; set; }

	public override string ToString() => $"{name} is a {this.GetType().Name}";
}

/// <summary>Interface for interactive behavior</summary>
public interface IInteractive
{
	void Interact();
}

/// <summary>Interface for breakable behavior</summary>
public interface IBreakable
{
	int durability { get; set; }
	void Break();
}

/// <summary>Interface for collectable behavior</summary>
public interface ICollectable
{
	bool isCollected { get; set; }
	void Collect();
}

/// <summary>Door class that is interactive</summary>
public class Door : Base, IInteractive
{
	public Door(string name = "Door") => this.name = name;

	public void Interact() => Console.WriteLine($"You try to open the {name}. It's locked.");
}

/// <summary>Decoration class implementing multiple interfaces</summary>
public class Decoration : Base, IInteractive, IBreakable
{
	public int durability { get; set; }
	public bool isQuestItem;

	public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
	{
		this.name = name;
		this.durability = durability;
		this.isQuestItem = isQuestItem;
	}

	public void Interact()
	{
		if (durability <= 0)
			Console.WriteLine($"The {name} has been broken.");
		else if (isQuestItem)
			Console.WriteLine($"You look at the {name}. There's a key inside.");
		else
			Console.WriteLine($"You look at the {name}. Not much to see here.");
	}

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
	public bool isCollected { get; set; }

	public Key(string name = "Key", bool isCollected = false)
	{
		this.name = name;
		this.isCollected = isCollected;
	}

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

	public void Add(T item) => items.Add(item);

	public IEnumerator<T> GetEnumerator() => items.GetEnumerator();

	IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
