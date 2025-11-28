using System;
using System.Windows.Input;

using Xproject.App.Input.Interfaces;

namespace Xproject.App.Input;

public sealed class RelayCommand : IRelayCommand
{
    private readonly Action _execute;
    private readonly Func<bool>? _canExecute;

    public event EventHandler? CanExecuteChanged;

    public RelayCommand(Action execute)
    {
        _execute = execute ?? throw new ArgumentNullException(nameof(execute));
	}

	public RelayCommand(Action execute, Func<bool> canExecute)
	{
		_execute = execute ?? throw new ArgumentNullException(nameof(execute));
	    _canExecute = canExecute ?? throw new ArgumentNullException(nameof(canExecute));
	}

	public bool CanExecute(object? parameter)
    {
        return _canExecute?.Invoke() != false;
	}

    public void Execute(object? parameter)
    {
        _execute();
	}

    public void NotifyCanExecuteChanged()
    {
        CanExecuteChanged?.Invoke(this, EventArgs.Empty);
	}

    public void RaiseCanExecuteChanged()
    {
        CommandManager.InvalidateRequerySuggested();
    }
}