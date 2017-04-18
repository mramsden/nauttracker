namespace NautTracker
{
	public class Astronaut
	{
		readonly string _name;
		readonly string _craft;

		public Astronaut(string name)
		{
			_name = name;
		}

		public Astronaut(string name, string craft)
		{
			_name = name;
			_craft = craft;
		}

		public string Name
		{
			get { return _name; }
		}

		public string Craft
		{
			get { return _craft; }
		}
	}
}
