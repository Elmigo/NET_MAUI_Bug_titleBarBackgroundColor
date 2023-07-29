using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TitleBarBgColor;

public class BaseViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetProperty<TValue>(ref TValue backingField, TValue value, [CallerMemberName] string propertyName = null)
    {
        if (Comparer<TValue>.Default.Compare(backingField, value) == 0)
        {
            return false;
        }

        backingField = value;

        OnPropertyChanged(propertyName);

        return true;
    }
}
