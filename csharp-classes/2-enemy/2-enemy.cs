using System;

namespace Enemies
{
	public class Zombie
	{
		public int health;

		// Default constructor
		public Zombie()
		{
			health = 0;
		}

		// Parameterized constructor
		public Zombie(int value)
		{
			if (value < 0)
			{
				throw new ArgumentException("Health must be greater than or equal to 0");
			}
			health = value;
		}
	}
}
