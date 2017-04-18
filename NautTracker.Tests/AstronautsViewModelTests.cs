using System.Collections.Generic;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NautTracker.Tests
{
	class DummyView : AstronautsView
	{
		public IReadOnlyList<Astronaut> Astronauts { get; set; }

		public void AstronautsUpdated(IReadOnlyList<Astronaut> astronauts)
		{
			Astronauts = astronauts;
		}
	}

	[TestFixture]
	public class AstronautsViewModelTests
	{
		[Test]
		public async Task CanFetchAstronauts()
		{
			var repository = new InMemoryAstronautRepository();
			repository.Add(new Astronaut("Buzz Aldrin", "Apollo 11"));
			var view = new DummyView();
			var viewModel = new AstronautsViewModel(repository);
			viewModel.SetView(view);

			await viewModel.FetchAstronauts();

			Assert.AreEqual(1, view.Astronauts.Count);
		}
	}
}
