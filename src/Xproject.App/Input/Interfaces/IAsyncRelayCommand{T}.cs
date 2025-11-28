namespace Xproject.App.Input.Interfaces;

public interface IAsyncRelayCommand<in T> : IAsyncRelayCommand, IRelayCommand<T>
{
}