namespace TitleBarBgColor;

public partial class SecondPage : ContentPage
{
	public SecondPage(SecondPageViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
}