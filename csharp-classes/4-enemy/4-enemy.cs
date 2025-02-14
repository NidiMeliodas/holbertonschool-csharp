using System;

namespace Enemies
{
	public class Zombie
	{
		private int health;
		private string name = "(No name)";

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

		// Property for name
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		// Method to get health value
		public int GetHealth()
		{
			return health;
		}
	}
}