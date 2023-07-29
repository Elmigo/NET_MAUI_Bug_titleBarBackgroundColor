namespace TitleBarBgColor;

public class SecondPageViewModel : BaseViewModel
{
    public Command GoToCDirectlyBCommand { get; private set; }

    public SecondPageViewModel()
    {
        GoToCDirectlyBCommand = new Command(GoToCDirectly);
    }

    private async void GoToCDirectly()
    {
        await Shell.Current.GoToAsync($"{nameof(ModalPage)}");
    }
}
