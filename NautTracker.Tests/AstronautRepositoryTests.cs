using NUnit.Framework;

namespace NautTracker.Tests
{
	[TestFixture]
	public class InMemoryAstronautRepositoryTests
	{
		[Test]
		public void GetAstronautsInSpace()
		{
			InMemoryAstronautRepository repository = new InMemoryAstronautRepository();

			Assert.AreEqual(0, repository.GetAstronautsInSpace().Count);
		}

		[Test]
		public void AddAstronautInSpace()
		{
			InMemoryAstronautRepository repository = new InMemoryAstronautRepository();
			Astronaut astronaut = new Astronaut("Buzz Aldrin", "Apollo 11");

			repository.Add(astronaut);

			Assert.AreEqual(astronaut, repository.GetAstronautsInSpace()[0]);
		}

		[Test]
		public void RemoveAstronautInSpace()
		{
			InMemoryAstronautRepository repository = new InMemoryAstronautRepository();
			Astronaut astronaut = new Astronaut("Buzz Aldrin", "Apollo 11");
			repository.Add(astronaut);

			repository.Remove(astronaut);

			Assert.AreEqual(0, repository.GetAstronautsInSpace().Count);
		}
	}
}
