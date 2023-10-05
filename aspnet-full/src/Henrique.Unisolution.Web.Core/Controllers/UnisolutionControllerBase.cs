using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Henrique.Unisolution.Controllers
{
    public abstract class UnisolutionControllerBase: AbpController
    {
        protected UnisolutionControllerBase()
        {
            LocalizationSourceName = UnisolutionConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
