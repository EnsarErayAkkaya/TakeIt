using TakeIt.Configuration;
using TakeIt.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace TakeIt.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class TakeItDbContextFactory : IDesignTimeDbContextFactory<TakeItDbContext>
    {
        public TakeItDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<TakeItDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(TakeItConsts.ConnectionStringName)
            );

            return new TakeItDbContext(builder.Options);
        }
    }
}