using Microsoft.Extensions.Logging;
using MonkeyGallery.Data;
using MonkeyGallery.ViewModels;
using MonkeyGallery.Views;

namespace MonkeyGallery;

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
			}).RegisterPages().RegisterViewModels().RegisterDataServices();

        return builder.Build();
	}

    public static MauiAppBuilder RegisterPages(this MauiAppBuilder builder)
    {
        //--------singleton Pages
        builder.Services.AddSingleton<MonkeyView>();
       

        //--------Transient pages

        

        return builder;
    }

    public static MauiAppBuilder RegisterDataServices(this MauiAppBuilder builder)
    {
        builder.Services.AddSingleton<DataSource>();
        return builder;
    }
    public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder builder)
    {
        builder.Services.AddSingleton<MonkeysPageViewModel>();
       

        //--------Transient ViewModels
        


        return builder;
    }

}
