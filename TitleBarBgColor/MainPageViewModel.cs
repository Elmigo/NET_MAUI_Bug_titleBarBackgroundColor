namespace TitleBarBgColor;

public class MainPageViewModel : BaseViewModel
{
    public Command GoToCViaBCommand { get; private set; }

    public MainPageViewModel()
    {
        GoToCViaBCommand = new Command(GoToCViaB);
    }

    private async void GoToCViaB()
    {
        await Shell.Current.GoToAsync($"//{nameof(SecondPage)}/{nameof(ModalPage)}");
    }
}
