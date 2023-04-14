using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;
using testFlight.Services.DialogServices.Implementations;
using testFlight.Services.DialogServices.Interfaces;
using testFlight.Services.SerializerService.Implementations;
using testFlight.Services.SerializerService.Interfaces;
using testFlight.ViewModels;

namespace testFlight
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App(): base()
        {
            Services = ConfigureServices(); 
        }

        public new static App Current => (App)Application.Current;

        public IServiceProvider Services { get; }

        private static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddTransient<ISerializerService, XmlSerializerService>();
            services.AddTransient<IFileDialogService, FileDialogService>();
            services.AddTransient<IMessageService, MessageBoxService>();

            services.AddSingleton<MainWindowViewModel>();

            return services.BuildServiceProvider();
        }
    }
}
