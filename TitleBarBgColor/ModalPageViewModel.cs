namespace TitleBarBgColor;

public class ModalPageViewModel : BaseViewModel
{
    public Command GoBackToBCommand { get; private set; }
    public Command GoBackToPreviousCommand { get; private set; }

    public ModalPageViewModel()
    {
        GoBackToBCommand = new Command(GoBackToB);
        GoBackToPreviousCommand = new Command(GoBackToPrevious);
    }

    private async void GoBackToPrevious()
    {
        await Shell.Current.GoToAsync($"..");
    }

    private async void GoBackToB()
    {
        await Shell.Current.GoToAsync($"//{nameof(SecondPage)}");
    }
}
