using Abp.AspNetCore.Mvc.ViewComponents;

namespace CTM.Web.Views
{
    public abstract class CTMViewComponent : AbpViewComponent
    {
        protected CTMViewComponent()
        {
            LocalizationSourceName = CTMConsts.LocalizationSourceName;
        }
    }
}
