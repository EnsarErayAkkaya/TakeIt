using Abp.Modules;
using Abp.Reflection.Extensions;
using TakeIt.Localization;

namespace TakeIt
{
    public class TakeItCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            TakeItLocalizationConfigurer.Configure(Configuration.Localization);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TakeItCoreModule).GetAssembly());
        }
    }
}