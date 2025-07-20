using System;

/// <summary>
/// Delegate to calculate changes to health
/// </summary>
/// <param name="amount">Amount of damage or healing</param>
public delegate void CalculateHealth(float amount);

/// <summary>
/// Represents a game player with health and damage capabilities
/// </summary>
public class Player
{
	private string name;
	private float maxHp;
	private float hp;

	/// <summary>
	/// Initializes a new player
	/// </summary>
	/// <param name="name">Name of the player</param>
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

	/// <summary>
	/// Applies damage to the player
	/// </summary>
	/// <param name="damage">Amount of damage</param>
	public void TakeDamage(float damage)
	{
		if (damage < 0f)
			damage = 0f;

		Console.WriteLine($"{name} takes {damage} damage!");
	}

	/// <summary>
	/// Heals the player
	/// </summary>
	/// <param name="heal">Amount to heal</param>
	public void HealDamage(float heal)
	{
		if (heal < 0f)
			heal = 0f;

		Console.WriteLine($"{name} heals {heal} HP!");
	}
}
