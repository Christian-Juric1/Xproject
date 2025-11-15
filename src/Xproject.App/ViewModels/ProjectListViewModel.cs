using Xproject.App.ComponentModel;

namespace Xproject.App.ViewModels;

public class ProjectListViewModel : ObservableObject
{
    public string Title { get; set; }

    public ProjectListViewModel()
    {
        Title = "Projects";
    }
}