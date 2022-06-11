using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace CTM.Controllers
{
    public abstract class CTMControllerBase: AbpController
    {
        protected CTMControllerBase()
        {
            LocalizationSourceName = CTMConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
