using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TakeIt.Web.Startup;
namespace TakeIt.Web.Tests
{
    [DependsOn(
        typeof(TakeItWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class TakeItWebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TakeItWebTestModule).GetAssembly());
        }
    }
}