using System;
using System.Windows.Input;

using Xproject.App.Input.Interfaces;

namespace Xproject.App.Input;

public sealed class RelayCommand<T> : IRelayCommand<T>
{
    private readonly Action<T?> _execute;
    private readonly Func<T?, bool>? _canExecute;

    public event EventHandler? CanExecuteChanged;

    public RelayCommand(Action<T?> execute)
    {
        _execute = execute ?? throw new ArgumentNullException(nameof(execute));
	}

	public RelayCommand(Action<T?> execute, Func<T?, bool> canExecute)
	{
		_execute = execute ?? throw new ArgumentNullException(nameof(execute));
        _canExecute = canExecute ?? throw new ArgumentNullException(nameof(canExecute));
	}

	public bool CanExecute(T? parameter)
    {
        return _canExecute?.Invoke(parameter) ?? true;
	}

    public bool CanExecute(object? parameter)
    {
        throw new NotImplementedException();
    }

    public void Execute(T? parameter)
    {
        _execute(parameter);
    }

    public void Execute(object? parameter)
    {
        throw new NotImplementedException();
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