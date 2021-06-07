namespace ColiseumGamestore
{
    using System;
    using Data;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using System.Windows.Forms;

    // Repositories
    using Repositories.GameRepository;
    using Repositories.StudioRepository;
    using Repositories.DetailRepository;
    using Repositories.GameDetailsRepository;

    static class StartUp
    {
        public static IServiceProvider ServiceProvider { get; set; }

        static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer("Server=localhost;Database=coliseum-gamestore;Trusted_Connection=True;");
            });

            services.AddScoped<IGameRepository, GameRepository>();
            services.AddScoped<IStudioRepository, StudioRepository>();
            services.AddScoped<IDetailRepository, DetailRepository>();
            services.AddScoped<IGameDetailsRepository, GameDetailsRepository>();

            ServiceProvider = services.BuildServiceProvider();
        }
        [STAThread]
        static void Main()
        {
            ConfigureServices();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());
        }
    }
}
