
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.Configuration;

namespace DAL
{
    public class AppContextFactory: IDesignTimeDbContextFactory<AppDbContext>
    {
        private readonly static string connectionString = ConfigurationManager.ConnectionStrings["DBSql"].ConnectionString;

        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new AppDbContext(optionsBuilder.Options);
        }

    }
}