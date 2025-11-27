using Xproject.App.ComponentModel;

#pragma warning disable CS8618

namespace Xproject.App.ViewModels;

public class MainWindowViewModel : ObservableObject
{
    private string _title;

    public string Title
    {
        get => _title;
        set => SetProperty(ref _title, value);
	}

	public MainWindowViewModel()
    {
        Title = "Xproject Application";
    }
}