using GoldwareSupervisorPanel2025.Pages;
using GoldwareSupervisorPanel2025.Pages.Main;
using GoldwareSupervisorPanel2025.Properties.services;
using Microsoft.Extensions.DependencyInjection;

namespace GoldwareSupervisorPanel2025
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Create service collection
            var services = new ServiceCollection();

            ConfigureServices(services);

            // Build service provider
            var serviceProvider = services.BuildServiceProvider();

            ApplicationConfiguration.Initialize();
            var Form = serviceProvider.GetRequiredService<MainForm>();
            Application.Run(Form);
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            //// Register your forms
            //services.AddTransient<MainForm>();
            services.AddTransient<LoginForm>();
            services.AddTransient<MainForm>();
            // Register your services
            services.AddScoped<ICommonService, CommonService>();
        }
    }
}