using System;

/// <summary>
/// Represents a game player with health properties
/// </summary>
public class Player
{
	private string name;
	private float maxHp;
	private float hp;

	/// <summary>
	/// Constructor to initialize a new Player
	/// </summary>
	/// <param name="name">Player's name</param>
	/// <param name="maxHp">Maximum HP</param>
	public Player(string name = "Player", float maxHp = 100f)
	{
		this.name = name;

		if (maxHp <= 0f)
		{
			maxHp = 100f;
			Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
		}

		this.maxHp = maxHp;
		this.hp = maxHp;
	}

	/// <summary>
	/// Prints the current health of the player
	/// </summary>
	public void PrintHealth()
	{
		Console.WriteLine($"{name} has {hp} / {maxHp} health");
	}
}
