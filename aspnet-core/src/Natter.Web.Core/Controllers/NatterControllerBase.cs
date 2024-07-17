using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Natter.Controllers
{
    public abstract class NatterControllerBase: AbpController
    {
        protected NatterControllerBase()
        {
            LocalizationSourceName = NatterConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
