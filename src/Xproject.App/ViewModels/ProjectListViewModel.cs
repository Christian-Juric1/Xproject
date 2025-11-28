using Xproject.App.ComponentModel;

namespace Xproject.App.ViewModels;

public class ProjectListViewModel : ObservableObject
{
	private string _title;

	public string Title
	{
		get => _title;
		set => SetProperty(ref _title, value);
	}

	public ProjectListViewModel()
	{
		Title = "Projects View";
	}
}