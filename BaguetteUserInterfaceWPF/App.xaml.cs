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
using AutoMapper;
using BLL_new.Services;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

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
            var connection = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            var services = new ServiceCollection().AddDbContext<ApplicationContext>(/*options => options.UseSqlServer(connection)*/);
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
            services.AddSingleton(new MapperConfiguration(c=>c.AddProfile(new AutoMapperProfile())).CreateMapper());
            services.AddTransient<BaguetteService, BaguetteService>();
            services.AddTransient<BaguetteMaterialService, BaguetteMaterialService>();
            services.AddTransient<MaterialService, MaterialService>();
            services.AddTransient<LoadData, LoadData>();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            var mainWindowViewModel = serviceProvider.GetService<ViewModel>();
            new MainWindow { DataContext = mainWindowViewModel };
            MainWindow.Show();
        }
    }
}
