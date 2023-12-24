using EasyMicroservices.Cores.Relational.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EasyMicroservices.CustomerMicroservice
{
    public class DatabaseBuilder : EntityFrameworkCoreDatabaseBuilder
    {
        public DatabaseBuilder(IConfiguration configuration) : base(configuration)
        {
        }

        public override void OnConfiguring(DbContextOptionsBuilder optionsBuilder, string name)
        {
            if (name == "SqlServer")
                optionsBuilder.UseSqlServer(Configuration.GetConnectionString("local"));
            else
                optionsBuilder.UseInMemoryDatabase("Customers");
        }
    }
}
