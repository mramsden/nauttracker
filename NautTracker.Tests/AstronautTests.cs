using NUnit.Framework;

namespace NautTracker.Tests
{
	[TestFixture]
	public class AstronautWithNoCraftTests
	{
		const string expectedName = "Buzz Aldrin";
		const string expectedCraft = "Apollo 11";
		public Astronaut Astronaut { get; set; }

		[SetUp]
		public void SetUp()
		{
			Astronaut = new Astronaut(expectedName);
		}

		[Test]
		public void ItHasAName()
		{
			Assert.AreEqual(expectedName, Astronaut.Name);
		}

		[Test]
		public void ItHasNoCraft()
		{
			Assert.IsNull(Astronaut.Craft);
		}
	}

	[TestFixture]
	public class AstronautWithCraftTests
	{
		const string expectedName = "Buzz Aldrin";
		const string expectedCraft = "Apollo 11";
		public Astronaut Astronaut { get; set; }

		[SetUp]
		public void SetUp()
		{
			Astronaut = new Astronaut(expectedName, expectedCraft);
		}

		[Test]
		public void ItHasAName()
		{
			Assert.AreEqual(expectedName, Astronaut.Name);
		}

		[Test]
		public void ItHasACraft()
		{
			Assert.AreEqual(expectedCraft, Astronaut.Craft);
		}
	}
}
