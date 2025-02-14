namespace Enemies
{
	public class Zombie
	{
		// Private fields
		private int health;
		private string name;

		// Public constructors
		public Zombie()
		{
			health = 0;
			name = "(No name)";
		}

		public Zombie(int value)
		{
			if (value >= 0)
			{
				health = value;
			}
			else
			{
				throw new ArgumentException("Health cannot be less than 0.");
			}
			name = "(No name)";
		}

		// Public property for Name
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		// Public method to get the health
		public int GetHealth()
		{
			return health;
		}

		// Override ToString method
		public override string ToString()
		{
			return $"Zombie Name: {name} / Total Health: {health}";
		}
	}
}
