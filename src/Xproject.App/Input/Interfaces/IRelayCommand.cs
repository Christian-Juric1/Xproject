using System.Windows.Input;

namespace Xproject.App.Input.Interfaces;

public interface IRelayCommand : ICommand
{
	void NotifyCanExecuteChanged();
	void RaiseCanExecuteChanged();
}