using System;

/// <summary>
/// Delegate to calculate changes to health
/// </summary>
/// <param name="amount">Amount of damage or healing</param>
public delegate void CalculateHealth(float amount);

/// <summary>
/// Represents a game player with health, damage, and healing logic
/// </summary>
public class Player
{
	private string name;
	private float maxHp;
	private float hp;

	/// <summary>
	/// Initializes a new player
	/// </summary>
	/// <param name="name">Player name</param>
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
	/// Applies damage and updates HP
	/// </summary>
	/// <param name="damage">Damage amount</param>
	public void TakeDamage(float damage)
	{
		if (damage < 0f)
			damage = 0f;

		Console.WriteLine($"{name} takes {damage} damage!");
		float newHp = hp - damage;
		ValidateHP(newHp);
	}

	/// <summary>
	/// Heals the player and updates HP
	/// </summary>
	/// <param name="heal">Healing amount</param>
	public void HealDamage(float heal)
	{
		if (heal < 0f)
			heal = 0f;

		Console.WriteLine($"{name} heals {heal} HP!");
		float newHp = hp + heal;
		ValidateHP(newHp);
	}

	/// <summary>
	/// Validates and sets the new HP value
	/// </summary>
	/// <param name="newHp">The new calculated HP</param>
	public void ValidateHP(float newHp)
	{
		if (newHp < 0f)
			hp = 0f;
		else if (newHp > maxHp)
			hp = maxHp;
		else
			hp = newHp;
	}
}
