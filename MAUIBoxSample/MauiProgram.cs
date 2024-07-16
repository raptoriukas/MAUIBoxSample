using MAUIBoxSample.MVVM.ViewModels;
using MAUIBoxSample.MVVM.Views;
using Microsoft.Extensions.Logging;
using DevExpress.Maui;
using CommunityToolkit.Maui;

namespace MAUIBoxSample
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .UseDevExpress(useLocalization: false)
                .UseMauiCommunityToolkitCamera()
                .UseDevExpressCollectionView()
                .UseDevExpressControls()
                .UseDevExpressEditors()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddTransient<MainPage>();
            builder.Services.AddTransient<MainPageVM>();
            builder.Services.AddTransient<FormPage>();
            builder.Services.AddTransient<FormPageVM>();

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
