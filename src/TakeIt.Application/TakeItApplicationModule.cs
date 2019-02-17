using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace TakeIt
{
    [DependsOn(
        typeof(TakeItCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class TakeItApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TakeItApplicationModule).GetAssembly());
        }
    }
}