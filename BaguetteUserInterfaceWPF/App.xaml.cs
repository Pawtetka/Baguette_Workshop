using BaguetteUserInterfaceWPF.Classes;
using BaguetteUserInterfaceWPF.Interfaces;
using BLL_new.Classes;
using BLL_new.Interfaces;
using Baguette_Workshop_DAL.Interfaces;
using Baguette_Workshop_DAL.Classes;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Baguette_Workshop_DAL.UnitOfWork;
using Baguette_Workshop_DAL.Models;
using Baguette_Workshop_DAL.Repositories;

namespace BaguetteUserInterfaceWPF
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IServiceProvider serviceProvider;
        public App()
        {
            var services = new ServiceCollection();
            ConfigureServices(services);
            serviceProvider = services.BuildServiceProvider();
        }
        private void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IShop, Shop>();
            services.AddTransient<IPriceCounter, OrderPriceCounter>();
            services.AddTransient<IChooser<Baguette>, BaguetteChooser>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            //services.AddTransient<IBaguetteRepository<BaguetteModel>, BaguetteRepository>();
            //services.AddTransient<IBaguetteMaterialRepository<BaguetteMaterialModel>, BaguetteMaterialRepository>();
            //services.AddTransient<IMaterialRepository<MaterialModel>, MaterialRepository>();
            services.AddSingleton<ApplicationContext, ApplicationContext>();
            services.AddSingleton<MainWindow, MainWindow>();
            services.AddScoped<IModel, Model>();
            services.AddScoped<ViewModel, ViewModel>();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            var mainWindowViewModel = serviceProvider.GetService<ViewModel>();
            new MainWindow { DataContext = mainWindowViewModel };
            MainWindow.Show();
        }
    }
}
