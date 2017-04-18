using System;
using System.Threading.Tasks;

namespace NautTracker
{
	public class AstronautsViewModel
	{
		InMemoryAstronautRepository _repository;
		WeakReference<AstronautsView> _view;

		public AstronautsViewModel(InMemoryAstronautRepository repository)
		{
			_repository = repository;
		}

		public void SetView(AstronautsView view)
		{
			if (view == null)
			{
				_view = null;
				return;
			}

			_view = new WeakReference<AstronautsView>(view);
		}

		public async Task FetchAstronauts() 
		{
			var astronauts = await Task.Run(() => _repository.GetAstronautsInSpace());
			AstronautsView view;
			if (_view != null && _view.TryGetTarget(out view))
			{
				view.AstronautsUpdated(astronauts);
			}
		}
	}
}
