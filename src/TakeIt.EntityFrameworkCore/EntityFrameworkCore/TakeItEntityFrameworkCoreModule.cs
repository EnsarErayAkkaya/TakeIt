using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace TakeIt.EntityFrameworkCore
{
    [DependsOn(
        typeof(TakeItCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class TakeItEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TakeItEntityFrameworkCoreModule).GetAssembly());
        }
    }
}