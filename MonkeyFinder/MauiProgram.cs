using MonkeyFinder.View;
using MonkeyFinder.Services;
namespace MonkeyFinder;

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
			});

		//Dependency Injections
        builder.Services.AddSingleton<MonkeyService>();
		builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<MonkeysViewModel>();

        builder.Services.AddSingleton<IConnectivity>(Connectivity.Current);
        builder.Services.AddSingleton<IGeolocation>(Geolocation.Default);
        builder.Services.AddSingleton<IMap>(Map.Default);

        //Everytime you call DetailsPage, or one Added like AddTransient a new instance is created.
        builder.Services.AddTransient<MonkeyDetailsViewModel>();
        builder.Services.AddTransient<DetailsPage>();

        return builder.Build();
	}
}
