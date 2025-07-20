using System;

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
/// Delegate to calculate health modifier.
/// </summary>
/// <param name="baseValue">Base float value</param>
/// <param name="modifier">Modifier enum value</param>
/// <returns>Modified float value</returns>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>
/// Event args containing current HP value.
/// </summary>
public class CurrentHPArgs : EventArgs
{
	/// <summary>
	/// Gets the current HP.
	/// </summary>
	public float currentHp { get; }

	/// <summary>
	/// Constructor for CurrentHPArgs.
	/// </summary>
	/// <param name="newHp">Current HP value</param>
	public CurrentHPArgs(float newHp)
	{
		currentHp = newHp;
	}
}

/// <summary>
/// Player class that handles health and events.
/// </summary>
public class Player
{
	private string name;
	private float maxHp;
	private float hp;
	private string status;

	/// <summary>
	/// Event handler for HP checks.
	/// </summary>
	public event EventHandler<CurrentHPArgs> HPCheck;

	/// <summary>
	/// Player constructor.
	/// </summary>
	/// <param name="name">Player name</param>
	/// <param name="maxHp">Maximum HP</param>
	public Player(string name = "Player", float maxHp = 100f)
	{
		this.name = name;
		if (maxHp <= 0)
		{
			this.maxHp = 100f;
			Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
		}
		else
		{
			this.maxHp = maxHp;
		}
		hp = this.maxHp;
		status = $"{name} is ready to go!";
		HPCheck += CheckStatus;
	}

	/// <summary>
	/// Prints the current health status.
	/// </summary>
	public void PrintHealth()
	{
		Console.WriteLine($"{name} has {hp} / {maxHp} health");
	}

	/// <summary>
	/// Applies a modifier to a base value.
	/// </summary>
	/// <param name="baseValue">Base float value</param>
	/// <param name="modifier">Modifier enum</param>
	/// <returns>Modified float value</returns>
	public float ApplyModifier(float baseValue, Modifier modifier)
	{
		return modifier switch
		{
			Modifier.Weak => baseValue * 0.5f,
			Modifier.Base => baseValue,
			Modifier.Strong => baseValue * 1.5f,
			_ => baseValue
		};
	}


	/// <summary>
	/// Handles damage taken.
	/// </summary>
	/// <param name="damage">Amount of damage</param>
	public void TakeDamage(float damage)
	{
		if (damage < 0)
		{
			Console.WriteLine($"{name} takes 0 damage!");
			damage = 0;
		}
		else
		{
			Console.WriteLine($"{name} takes {damage} damage!");
		}
		float newHp = hp - damage;
		ValidateHP(newHp);
	}

	/// <summary>
	/// Handles healing.
	/// </summary>
	/// <param name="heal">Amount to heal</param>
	public void HealDamage(float heal)
	{
		if (heal < 0)
		{
			Console.WriteLine($"{name} heals 0 HP!");
			heal = 0;
		}
		else
		{
			Console.WriteLine($"{name} heals {heal} HP!");
		}
		float newHp = hp + heal;
		ValidateHP(newHp);
	}

	/// <summary>
	/// Validates and sets HP.
	/// </summary>
	/// <param name="newHp">New HP value</param>
	public void ValidateHP(float newHp)
	{
		if (newHp < 0)
			hp = 0;
		else if (newHp > maxHp)
			hp = maxHp;
		else
			hp = newHp;

		OnCheckStatus(new CurrentHPArgs(hp));
	}

	/// <summary>
	/// Checks the current status and prints status message.
	/// </summary>
	private void CheckStatus(object sender, CurrentHPArgs e)
	{
		float currentHp = e.currentHp;
		if (currentHp == maxHp)
		{
			status = $"{name} is in perfect health!";
		}
		else if (currentHp >= maxHp / 2f)
		{
			status = $"{name} is doing well!";
		}
		else if (currentHp >= maxHp / 4f)
		{
			status = $"{name} isn't doing too great...";
		}
		else if (currentHp > 0)
		{
			status = $"{name} needs help!";
		}
		else
		{
			status = $"{name} is knocked out!";
		}
		Console.WriteLine(status);
	}

	/// <summary>
	/// Warns about low HP or zero HP.
	/// </summary>
	private void HPValueWarning(object sender, CurrentHPArgs e)
	{
		if (e.currentHp == 0)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("Health has reached zero!");
			Console.ResetColor();
		}
		else
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("Health is low!");
			Console.ResetColor();
		}
	}

	/// <summary>
	/// Raises HPCheck event and attaches HPValueWarning if HP is low.
	/// </summary>
	/// <param name="e">Current HP event args</param>
	public void OnCheckStatus(CurrentHPArgs e)
	{
		if (e.currentHp < maxHp / 4f)
		{
			HPCheck -= HPValueWarning; // Remove previous in case
			HPCheck += HPValueWarning;
		}
		else
		{
			HPCheck -= HPValueWarning;
		}
		HPCheck?.Invoke(this, e);
	}
}
