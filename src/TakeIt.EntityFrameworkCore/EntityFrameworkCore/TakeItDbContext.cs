using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TakeIt.EntityFrameworkCore
{
    public class TakeItDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...

        public TakeItDbContext(DbContextOptions<TakeItDbContext> options) 
            : base(options)
        {

        }
    }
}
