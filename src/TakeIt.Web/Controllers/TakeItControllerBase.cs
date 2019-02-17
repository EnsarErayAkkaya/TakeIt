using Abp.AspNetCore.Mvc.Controllers;

namespace TakeIt.Web.Controllers
{
    public abstract class TakeItControllerBase: AbpController
    {
        protected TakeItControllerBase()
        {
            LocalizationSourceName = TakeItConsts.LocalizationSourceName;
        }
    }
}