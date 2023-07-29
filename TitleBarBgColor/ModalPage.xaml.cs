namespace TitleBarBgColor;

public partial class ModalPage : ContentPage
{
	public ModalPage(ModalPageViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
}