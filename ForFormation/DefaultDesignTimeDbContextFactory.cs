using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ForFormation
{
    public class DefaultDesignTimeDbContextFactory : IDesignTimeDbContextFactory<DefaultContext>
    {
        public DefaultContext CreateDbContext(string[] args)
        {
            string path = Directory.GetCurrentDirectory();

            var builder = new ConfigurationBuilder()
                               .SetBasePath(path)
                               .AddJsonFile("appsettings.json");


            var config = builder.Build();

            var connectionString = config.GetConnectionString("DefaultContext");

            DbContextOptionsBuilder<DefaultContext> optionBuilder = new DbContextOptionsBuilder<DefaultContext>();
            optionBuilder.UseSqlServer(connectionString);

            return new DefaultContext(optionBuilder.Options);
        }
    }
}
