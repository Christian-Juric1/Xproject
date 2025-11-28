using Xproject.App.ComponentModel;
using Xproject.App.Input;
using Xproject.App.Input.Interfaces;

namespace Xproject.App.ViewModels;

public class MainWindowViewModel : ObservableObject
{
	private object _currentView;

	public object CurrentView
	{
		get { return _currentView; }
		set { SetProperty(ref _currentView, value); }
	}

	public IRelayCommand NavigateDashboardViewCommand { get; }
	public IRelayCommand NavigateProjectListViewCommand { get; }
	public IRelayCommand NavigateTaskListViewCommand { get; }

	public MainWindowViewModel()
    {
		NavigateDashboardViewCommand = new RelayCommand(NavigateDashboardView);
		NavigateProjectListViewCommand = new RelayCommand(NavigateProjectListView);
		NavigateTaskListViewCommand = new RelayCommand(NavigateTaskListView);

		CurrentView = new DashboardViewModel();
	}

	private void NavigateDashboardView()
	{
		CurrentView = new DashboardViewModel();
	}

	private void NavigateProjectListView()
	{
		CurrentView = new ProjectListViewModel();
	}

	private void NavigateTaskListView()
	{
		CurrentView = new TaskListViewModel();
	}
}