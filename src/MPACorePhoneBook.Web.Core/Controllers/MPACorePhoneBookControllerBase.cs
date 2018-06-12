using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace MPACorePhoneBook.Controllers
{
    public abstract class MPACorePhoneBookControllerBase: AbpController
    {
        protected MPACorePhoneBookControllerBase()
        {
            LocalizationSourceName = MPACorePhoneBookConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
