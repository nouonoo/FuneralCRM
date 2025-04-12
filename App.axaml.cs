using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Data.Core.Plugins;
using System.Linq;
using Avalonia.Markup.Xaml;
using FuneralCRM.ViewModels;
using FuneralCRM.Views;
using Splat;
using FuneralCRM.DataBase;
using FuneralCRM.Services;
using FuneralCRM.Models;
using Avalonia.Controls;


namespace FuneralCRM;

public partial class App : Application
{
    public override void Initialize()

    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        SplatRegistrations.RegisterLazySingleton<FuneralCRMContext>();
        SplatRegistrations.Register<IAccountatntRepository,AccountatntSqlServerRepository>();
        SplatRegistrations.Register<MainWindowViewModel>();
        SplatRegistrations.SetupIOC();

        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            
            DisableAvaloniaDataAnnotationValidation();
            desktop.MainWindow = new MainWindow
            {
                DataContext = Locator.Current.GetService<MainWindowViewModel>(),
            };
        }

        base.OnFrameworkInitializationCompleted();
    }

    private void DisableAvaloniaDataAnnotationValidation()
    {
        // Get an array of plugins to remove
        var dataValidationPluginsToRemove =
            BindingPlugins.DataValidators.OfType<DataAnnotationsValidationPlugin>().ToArray();

        // remove each entry found
        foreach (var plugin in dataValidationPluginsToRemove)
        {
            BindingPlugins.DataValidators.Remove(plugin);
        }
    }
}