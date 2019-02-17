using Abp.AspNetCore.Mvc.Views;

namespace TakeIt.Web.Views
{
    public abstract class TakeItRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected TakeItRazorPage()
        {
            LocalizationSourceName = TakeItConsts.LocalizationSourceName;
        }
    }
}
