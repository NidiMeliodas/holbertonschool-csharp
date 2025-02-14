namespace Enemies
{
	/// <summary>
	/// Represents a Zombie enemy.
	/// </summary>
	public class Zombie
	{
		/// <summary>
		/// Health of the Zombie.
		/// </summary>
		private int health;

		/// <summary>
		/// Initializes a new instance of the <see cref="Zombie"/> class with health set to 0.
		/// </summary>
		public Zombie()
		{
			health = 0;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Zombie"/> class with a specified health value.
		/// </summary>
		/// <param name="value">Initial health value.</param>
		/// <exception cref="ArgumentException">Thrown when value is less than 0.</exception>
		public Zombie(int value)
		{
			if (value < 0)
			{
				throw new ArgumentException("Health must be greater than or equal to 0");
			}
			health = value;
		}

		/// <summary>
		/// Returns the health value of the Zombie.
		/// </summary>
		/// <returns>The health of the Zombie.</returns>
		public int GetHealth()
		{
			return health;
		}
	}
}
