using System;

/// <summary>
/// Delegate to calculate changes to health
/// </summary>
/// <param name="amount">Amount of damage or healing</param>
public delegate void CalculateHealth(float amount);

/// <summary>
/// Modifier levels
/// </summary>
public enum Modifier
{
	/// <summary>
	/// Weak modifier (0.5x)
	/// </summary>
	Weak,

	/// <summary>
	/// Base modifier (1.0x)
	/// </summary>
	Base,

	/// <summary>
	/// Strong modifier (1.5x)
	/// </summary>
	Strong
}

/// <summary>
/// Delegate to apply a modifier to a value
/// </summary>
/// <param name="baseValue">Base value to modify</param>
/// <param name="modifier">The modifier type</param>
/// <returns>Modified float value</returns>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>
/// Event arguments for current HP value
/// </summary>
public class CurrentHPArgs : EventArgs
{
	/// <summary>
	/// Current HP (read-only)
	/// </summary>
	public float currentHp { get; }

	/// <summary>
	/// Constructor for CurrentHPArgs
	/// </summary>
	/// <param name="newHp">Current HP value</param>
	public CurrentHPArgs(float newHp)
	{
		currentHp = newHp;
	}
}

/// <summary>
/// Represents a game player with health, damage, healing, and status checking
/// </summary>
public class Player
{
	private string name;
	private float maxHp;
	private float hp;
	private string status;

	/// <summary>
	/// Event triggered to check HP status
	/// </summary>
	public event EventHandler<CurrentHPArgs> HPCheck;

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
		this.status = $"{name} is ready to go!";

		HPCheck += CheckStatus;
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
	/// <param name="newHp">New calculated HP</param>
	public void ValidateHP(float newHp)
	{
		if (newHp < 0f)
			hp = 0f;
		else if (newHp > maxHp)
			hp = maxHp;
		else
			hp = newHp;

		HPCheck?.Invoke(this, new CurrentHPArgs(hp));
	}

	/// <summary>
	/// Applies a modifier to a base value
	/// </summary>
	public float ApplyModifier(float baseValue, Modifier modifier)
	{
		if (modifier == Modifier.Weak)
			return baseValue * 0.5f;
		else if (modifier == Modifier.Strong)
			return baseValue * 1.5f;
		return baseValue;
	}

	/// <summary>
	/// Updates status based on current HP value
	/// </summary>
	private void CheckStatus(object sender, CurrentHPArgs e)
	{
		float value = e.currentHp;

		if (value == maxHp)
			status = $"{name} is in perfect health!";
		else if (value >= maxHp / 2f)
			status = $"{name} is doing well!";
		else if (value >= maxHp / 4f)
			status = $"{name} isn't doing too great...";
		else if (value > 0f)
			status = $"{name} needs help!";
		else
			status = $"{name} is knocked out!";

		Console.WriteLine(status);
	}
}
