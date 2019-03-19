using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NagiosChecker.DataAccess;
using NagiosChecker.DataModel;
using NagiosChecker.Infrastructure;
using NagiosChecker.Infrastructure.Filters;
using NagiosChecker.Infrastructure.Repositories;
using NagiosChecker.Services;
using NagiosChecker.Services.Integration;

namespace NagiosChecker
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOptions();
            services.Configure<AppSettings>(Configuration);
            services.Configure<ConnectionStringList>(Configuration.GetSection("ConnectionStrings"));

            // Add framework services.
            services.AddMvc(options =>
            {
                options.Filters.Add(typeof(ApiExceptionFilter));
            });

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddTransient<IBikService, BikService>();
            services.AddTransient<IKntService, KntService>();
            services.AddTransient<ILogService, KrisLogger>();
            services.AddTransient<INotifyService, NotifyService>();
            services.AddTransient<ISlService, SlService>();
            services.AddTransient<IMsSqlService, MsSqlService>();

            services.AddTransient<IBikRepository>((arg)=> new BikDAL(Configuration.GetConnectionString("csMain")));
            services.AddTransient<IKntRepository>((arg) => new KntDAL(Configuration.GetConnectionString("csMain")));
            services.AddTransient<IRexsRepository>((arg) => new RexsDAL(Configuration.GetConnectionString("csMain")));
            services.AddTransient<ISlRepository>((arg) => new SlDAL(Configuration.GetConnectionString("csMain")));
            services.AddTransient<IMsSqlRepository>((arg) => new MsSqlDAL(Configuration.GetConnectionString("csMain")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseMvc();

            //app.UseDeveloperExceptionPage();
        }
    }
}
