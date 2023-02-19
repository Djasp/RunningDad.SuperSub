namespace RunningDad.SuperSub;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
                fonts.AddFont("Lobster-Regular.ttf", "LobsterRegular");
                fonts.AddFont("Raleway-Bold.ttf", "RalewayBold");
                fonts.AddFont("Raleway-Regular.ttf", "RalewayRegular");
                fonts.AddFont("Raleway-Light.ttf", "RalewayLight");
                fonts.AddFont("Raleway-Italic.ttf", "RalewayItalic");
            });

		return builder.Build();
	}
}

