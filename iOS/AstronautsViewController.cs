using UIKit;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace NautTracker.iOS
{
	public partial class AstronautsViewController : UITableViewController
	{
		AstronautsViewModel _viewModel;
		IReadOnlyList<Astronaut> _astronauts;

		public AstronautsViewController(AstronautsViewModel viewModel)
		{
			_viewModel = viewModel;
			_viewModel.SetView(this);

			TableView.RegisterClassForCellReuse(typeof(UITableViewCell), "cell");
		}

#pragma warning disable RECS0165 // Asynchronous methods should return a Task instead of void
		public async override void ViewDidLoad()
#pragma warning restore RECS0165 // Asynchronous methods should return a Task instead of void
		{
			base.ViewDidLoad();

			Title = "Astronauts";
			await _viewModel.FetchAstronauts();
		}

		public override System.nint RowsInSection(UITableView tableView, System.nint section)
		{
			return _astronauts?.Count ?? 0;
		}

		public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell("cell", indexPath);
			var astronauts = _astronauts[indexPath.Row];

			cell.TextLabel.Text = astronauts.Name;
			cell.SelectionStyle = UITableViewCellSelectionStyle.None;

			return cell;
		}
	}

	public partial class AstronautsViewController : AstronautsView
	{
		public void AstronautsUpdated(IReadOnlyList<Astronaut> astronauts)
		{
			_astronauts = astronauts;
			TableView.ReloadData();
		}
	}
}