using Xproject.App.ComponentModel;

namespace Xproject.App.ViewModels;

public class DashboardViewModel : ObservableObject
{
    public string Title { get; set; }

    public DashboardViewModel()
    {
        Title = "Dashboard";
    }
}