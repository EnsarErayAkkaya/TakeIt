using Microsoft.EntityFrameworkCore;

namespace TakeIt.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<TakeItDbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for TakeItDbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
