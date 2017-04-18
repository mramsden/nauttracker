using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NautTracker
{
	public class InMemoryAstronautRepository
	{
		readonly List<Astronaut> _astronauts = new List<Astronaut>();

		public IReadOnlyList<Astronaut> GetAstronautsInSpace()
		{
			return new ReadOnlyCollection<Astronaut>(_astronauts);
		}

		public void Add(Astronaut astronaut)
		{
			_astronauts.Add(astronaut);
		}

		public void Remove(Astronaut astronaut)
		{
			_astronauts.Remove(astronaut);
		}
	}
}
