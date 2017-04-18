using System.Collections.Generic;

namespace NautTracker
{
	public interface AstronautsView
	{
		void AstronautsUpdated(IReadOnlyList<Astronaut> astronauts);
	}
}
