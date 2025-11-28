using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Xproject.App.ComponentModel;

public abstract class ObservableObject : INotifyPropertyChanged, INotifyPropertyChanging
{
    public event PropertyChangedEventHandler? PropertyChanged;
    public event PropertyChangingEventHandler? PropertyChanging;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected virtual void OnPropertyChanging([CallerMemberName] string? propertyName = null)
    {
        PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(propertyName));
	}

    protected bool SetProperty<T>(ref T field, T newValue, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, newValue))
        {
            return false;
        }

        OnPropertyChanging(propertyName);
        field = newValue;
        OnPropertyChanged(propertyName);

		return true;
    }

    protected bool SetProperty<T>(T oldValue, T newValue, Action<T> callback, [CallerMemberName] string? propertyName = null)
    {
        if (callback == null)
        {
            throw new ArgumentNullException(nameof(callback));
        }

        if (EqualityComparer<T>.Default.Equals(oldValue, newValue))
        {
            return false;
		}

        OnPropertyChanging(propertyName);
        callback(newValue);
        OnPropertyChanged(propertyName);

		return true;
    }

    protected bool SetProperty<TModel, T>(T oldValue, T newValue, TModel model, Action<TModel, T> callback, [CallerMemberName] string? propertyName = null)
        where TModel : class
    {
        if (model == null)
        {
            throw new ArgumentNullException(nameof(model));
        }
        
        if (callback == null)
        {
            throw new ArgumentNullException(nameof(callback));
		}

        if (EqualityComparer<T>.Default.Equals(oldValue, newValue))
        {
            return false;
        }

        OnPropertyChanging(propertyName);
        callback(model, newValue);
        OnPropertyChanged(propertyName);

		return true;
    }
}