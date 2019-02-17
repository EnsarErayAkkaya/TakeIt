using Abp.Application.Services;

namespace TakeIt
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class TakeItAppServiceBase : ApplicationService
    {
        protected TakeItAppServiceBase()
        {
            LocalizationSourceName = TakeItConsts.LocalizationSourceName;
        }
    }
}