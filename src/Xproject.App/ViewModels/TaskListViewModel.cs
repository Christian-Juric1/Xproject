using Xproject.App.ComponentModel;

namespace Xproject.App.ViewModels;

public class TaskListViewModel : ObservableObject
{
	private string _title;

	public string Title
	{
		get => _title;
		set => SetProperty(ref _title, value);
	}

    public TaskListViewModel()
    {
		Title = "Tasks View";
    }
}