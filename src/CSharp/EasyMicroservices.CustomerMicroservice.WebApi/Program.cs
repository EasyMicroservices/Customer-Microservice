using EasyMicroservices.CustomerMicroservice.Database.Contexts;
using EasyMicroservices.Cores.AspEntityFrameworkCoreApi;
using EasyMicroservices.Cores.Relational.EntityFrameworkCore.Intrerfaces;
using EasyMicroservices.Cores.AspEntityFrameworkCoreApi.Interfaces;

namespace EasyMicroservices.CustomerMicroservice.WebApi
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var app = CreateBuilder(args);
            var build = await app.Build<CustomerContext>();
            build.MapControllers();
            build.UseCors(x => x
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials()
            .SetIsOriginAllowed(origin => true));
            build.Run();
        }

        static WebApplicationBuilder CreateBuilder(string[] args)
        {
            var app = StartUpExtensions.Create<CustomerContext>(args);
            app.Services.Builder<CustomerContext>();
            app.Services.AddScoped((serviceProvider) => new UnitOfWork(serviceProvider));
            app.Services.AddTransient(serviceProvider => new CustomerContext(serviceProvider.GetService<IEntityFrameworkCoreDatabaseBuilder>()));
            app.Services.AddScoped<IEntityFrameworkCoreDatabaseBuilder>(serviceProvider => new DatabaseBuilder(serviceProvider.GetService<IConfiguration>()));

            StartUpExtensions.AddWhiteLabel("Customer", "RootAddresses:WhiteLabel");
            return app;
        }
    }
}