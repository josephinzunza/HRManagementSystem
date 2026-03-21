using HRManagementSystem.Persistence.Repositories;
using HRManagementSystem.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace HRManagementSystem
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly IServiceProvider _serviceProvider;
        public App()
        {
            IServiceCollection services = new ServiceCollection();

            services.AddSingleton<HRMSDbContext>();
            services.AddSingleton<IUnitOfWork, UnitOfWork>();

            services.AddSingleton<MainWindowViewModel>();

            services.AddSingleton(s => new MainWindow()
            {
                DataContext = s.GetRequiredService<MainWindowViewModel>()
            });

            _serviceProvider = services.BuildServiceProvider();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = _serviceProvider.GetRequiredService<MainWindow>();
            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
