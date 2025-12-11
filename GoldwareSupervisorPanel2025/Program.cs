using GoldwareSupervisorPanel2025.Forms;
using GoldwareSupervisorPanel2025.Forms.Login.control;
using GoldwareSupervisorPanel2025.Forms.Login.loginControl;
using GoldwareSupervisorPanel2025.Forms.Main;
using GoldwareSupervisorPanel2025.Forms.Main.programming_controls;
using GoldwareSupervisorPanel2025.Properties;
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
            if (string.IsNullOrEmpty(Settings.Default.AuthToken))
            {
                var Form = serviceProvider.GetRequiredService<LoginForm>();
                Application.Run(Form);
            }
            else
            {
                var Form = serviceProvider.GetRequiredService<LoginForm>();
                Application.Run(Form);
                //var Form = serviceProvider.GetRequiredService<MainForm>();
                //Application.Run(Form);
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            //// Register your forms
            //services.AddTransient<MainForm>();
            services.AddTransient<LoginForm>();
            services.AddTransient<MainForm>();
            services.AddTransient<SelectUnitControl>();
            services.AddTransient<LoginControl>();
            services.AddTransient<SetSettingStep1>();
            services.AddTransient<SetSettingStep2>();
            services.AddTransient<GetSettingStep1>();
            services.AddTransient<GetSettingStep2>();
            services.AddTransient<Programming>();
            services.AddTransient<UpdateFOTAStep1>();
            services.AddTransient<UpdateFOTAStep2>();
            services.AddTransient<UpdateFOTAStep3>();
            // Register your services
            services.AddScoped<ICommonService, CommonService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ISettingsService, SettingsService>();
        }
    }
}