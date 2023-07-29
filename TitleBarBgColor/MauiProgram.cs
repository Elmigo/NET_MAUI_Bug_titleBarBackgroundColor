using Microsoft.Extensions.Logging;

namespace TitleBarBgColor;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        builder.Services.AddTransient<AppShell>();
        builder.Services.AddTransient<AppShellViewModel>();

        AddPage<MainPage, MainPageViewModel>(builder.Services, nameof(MainPage));
        AddPage<SecondPage, SecondPageViewModel>(builder.Services, nameof(SecondPage));
        AddPage<ModalPage, ModalPageViewModel>(builder.Services, nameof(ModalPage));

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
    }

    private static IServiceCollection AddPage<TPage, TViewModel>(
        IServiceCollection services,
        string route)
        where TPage : Page
        where TViewModel : BaseViewModel
    {
        services
            .AddTransient(typeof(TPage))
            .AddTransient(typeof(TViewModel));

        Routing.RegisterRoute(route, typeof(TPage));

        return services;
    }
}
