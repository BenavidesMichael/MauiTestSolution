using CommunityToolkit.Maui;
using MauiTest.Extentions;

namespace MauiTest
{
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
                    fonts.AddFont("Roboto-Regular.ttf", "RobotoRegular");
                })
                .AddConfiguration();

            builder.UseMauiApp<App>().UseMauiCommunityToolkit();
            
            return builder.Build();
        }
    }
}