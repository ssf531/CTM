using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace CTM.Web.Views
{
    public abstract class CTMRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected CTMRazorPage()
        {
            LocalizationSourceName = CTMConsts.LocalizationSourceName;
        }
    }
}
