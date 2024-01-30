using EasyMicroservices.Cores.AspEntityFrameworkCoreApi;
using EasyMicroservices.Cores.Relational.EntityFrameworkCore.Intrerfaces;
using EasyMicroservices.CustomerMicroservice.Database.Contexts;

namespace EasyMicroservices.CustomerMicroservice.WebApi
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var app = CreateBuilder(args);
            var build = await app.BuildWithUseCors<CustomerContext>(null, true);
            build.MapControllers();
            build.Run();
        }

        static WebApplicationBuilder CreateBuilder(string[] args)
        {
            var app = StartUpExtensions.Create<CustomerContext>(args);
            app.Services.Builder<CustomerContext>("Places")
                .UseDefaultSwaggerOptions();
            app.Services.AddTransient<IEntityFrameworkCoreDatabaseBuilder, DatabaseBuilder>();
            app.Services.AddTransient(serviceProvider => new CustomerContext(serviceProvider.GetService<IEntityFrameworkCoreDatabaseBuilder>()));
            return app;
        }
    }
}