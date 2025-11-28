namespace Xproject.App.Input.Interfaces;

public interface IRelayCommand<in T> : IRelayCommand
{
	bool CanExecute(T? parameter);
	void Execute(T? parameter);
}