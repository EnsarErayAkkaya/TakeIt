using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TakeIt.Configuration;
using TakeIt.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace TakeIt.Web.Startup
{
    [DependsOn(
        typeof(TakeItApplicationModule), 
        typeof(TakeItEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class TakeItWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public TakeItWebModule(IHostingEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(TakeItConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<TakeItNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(TakeItApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TakeItWebModule).GetAssembly());
        }
    }
}