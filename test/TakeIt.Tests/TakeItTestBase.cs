using System;
using System.Threading.Tasks;
using Abp.TestBase;
using TakeIt.EntityFrameworkCore;
using TakeIt.Tests.TestDatas;

namespace TakeIt.Tests
{
    public class TakeItTestBase : AbpIntegratedTestBase<TakeItTestModule>
    {
        public TakeItTestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<TakeItDbContext> action)
        {
            using (var context = LocalIocManager.Resolve<TakeItDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<TakeItDbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<TakeItDbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<TakeItDbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<TakeItDbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<TakeItDbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<TakeItDbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
