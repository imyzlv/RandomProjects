using FishinLogs.View;
using FishinLogs.ViewModel;

namespace FishinLogs;

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

		builder.Services.AddSingleton<HomePage>();
		builder.Services.AddSingleton<HomeViewModel>();

		builder.Services.AddSingleton<RecordsPage>();
		builder.Services.AddSingleton<RecordViewModel>();
		return builder.Build();
	}
}

