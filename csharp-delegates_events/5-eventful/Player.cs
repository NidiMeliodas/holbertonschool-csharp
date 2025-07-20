using System;

/// <summary>
/// Delegate to calculate a modified value.
/// </summary>
/// <param name="baseValue">The base float value.</param>
/// <param name="modifier">The Modifier enum value.</param>
/// <returns>The modified float value.</returns>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>
/// Modifier levels.
/// </summary>
public enum Modifier
{
	/// <summary>Weak modifier.</summary>
	Weak,
	/// <summary>Base modifier.</summary>
	Base,
	/// <summary>Strong modifier.</summary>
	Strong
}

/// <summary>
/// Arguments for current HP event.
/// </summary>
public class CurrentHPArgs : EventArgs
{
	/// <summary>
	/// Gets the current HP value.
	/// </summary>
	public float currentHp { get; }

	/// <summary>
	/// Initializes a new instance of the CurrentHPArgs class.
	/// </summary>
	/// <param name="newHp">The current HP value.</param>
	public CurrentHPArgs(float newHp)
	{
		currentHp = newHp;
	}
}

/// <summary>
/// Player class to handle health and damage.
/// </summary>
public class Player
{
	private string name;
	private float maxHp;
	private float hp;
	private string status;

	/// <summary>
	/// Event to check HP status.
	/// </summary>
	public event EventHandler<CurrentHPArgs> HPCheck;

	/// <summary>
	/// Initializes a new instance of the Player class.
	/// </summary>
	/// <param name="name">The name of the player.</param>
	/// <param name="maxHp">The maximum HP of the player.</param>
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
		HPCheck += HPValueWarning; // Attach warning handler here once
	}

	/// <summary>
	/// Prints the player's current health.
	/// </summary>
	public void PrintHealth()
	{
		Console.WriteLine($"{name} has {hp} / {maxHp} health");
	}

	/// <summary>
	/// Validates and sets HP according to constraints, triggers HPCheck event.
	/// </summary>
	/// <param name="newHp">The new HP value to validate.</param>
	public void ValidateHP(float newHp)
	{
		if (newHp < 0)
			hp = 0;
		else if (newHp > maxHp)
			hp = maxHp;
		else
			hp = newHp;

		CurrentHPArgs e = new CurrentHPArgs(hp);
		OnCheckStatus(e);
	}

	/// <summary>
	/// Method called on HP change to invoke event handlers.
	/// </summary>
	/// <param name="e">The CurrentHPArgs instance with HP info.</param>
	public void OnCheckStatus(CurrentHPArgs e)
	{
		HPCheck?.Invoke(this, e);
	}

	/// <summary>
	/// Method to apply modifier to base value.
	/// </summary>
	/// <param name="baseValue">Base value.</param>
	/// <param name="modifier">Modifier to apply.</param>
	/// <returns>Modified value.</returns>
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
	/// Handles damage taken by the player.
	/// </summary>
	/// <param name="damage">Amount of damage.</param>
	public void TakeDamage(float damage)
	{
		if (damage < 0)
			damage = 0;
		Console.WriteLine($"{name} takes {damage} damage!");
		float newHp = hp - damage;
		ValidateHP(newHp);
	}

	/// <summary>
	/// Handles healing done to the player.
	/// </summary>
	/// <param name="heal">Amount of healing.</param>
	public void HealDamage(float heal)
	{
		if (heal < 0)
			heal = 0;
		Console.WriteLine($"{name} heals {heal} HP!");
		float newHp = hp + heal;
		ValidateHP(newHp);
	}

	/// <summary>
	/// Checks and prints the status of the player based on current HP.
	/// </summary>
	/// <param name="sender">Sender object.</param>
	/// <param name="e">CurrentHPArgs with current HP info.</param>
	private void CheckStatus(object sender, CurrentHPArgs e)
	{
		if (e.currentHp == maxHp)
		{
			status = $"{name} is in perfect health!";
		}
		else if (e.currentHp >= maxHp / 2 && e.currentHp < maxHp)
		{
			status = $"{name} is doing well!";
		}
		else if (e.currentHp >= maxHp / 4 && e.currentHp < maxHp / 2)
		{
			status = $"{name} isn't doing too great...";
		}
		else if (e.currentHp > 0 && e.currentHp < maxHp / 4)
		{
			status = $"{name} needs help!";
		}
		else if (e.currentHp == 0)
		{
			status = $"{name} is knocked out!";
		}
		Console.WriteLine(status);
	}

	/// <summary>
	/// Prints warnings based on HP value.
	/// </summary>
	/// <param name="sender">Sender object.</param>
	/// <param name="e">CurrentHPArgs with current HP info.</param>
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
}
