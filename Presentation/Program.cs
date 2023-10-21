using Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Repositiories;

namespace Presentation
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;
            Application.Run(ServiceProvider.GetRequiredService<Form1>());
        }
        public static IServiceProvider ServiceProvider { get; set; }
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder().ConfigureServices((context, services) =>
            {
                services.AddDbContext<EmployeeAccountingDbContext>(opt=>opt.UseSqlServer(GlobalVars.ConnectionString));
                services.AddTransient<Form1>();
                services.AddSingleton<IRepositoryManager, RepositoryManager>();
            });
        }
    }
}