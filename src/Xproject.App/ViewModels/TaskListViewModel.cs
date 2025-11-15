using Xproject.App.ComponentModel;

namespace Xproject.App.ViewModels;

public class TaskListViewModel : ObservableObject
{
    public string Title { get; set; }

    public TaskListViewModel()
    {
        Title = "Tasks";
    }
}