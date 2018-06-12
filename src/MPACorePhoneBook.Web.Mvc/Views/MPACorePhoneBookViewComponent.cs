using Abp.AspNetCore.Mvc.ViewComponents;

namespace MPACorePhoneBook.Web.Views
{
    public abstract class MPACorePhoneBookViewComponent : AbpViewComponent
    {
        protected MPACorePhoneBookViewComponent()
        {
            LocalizationSourceName = MPACorePhoneBookConsts.LocalizationSourceName;
        }
    }
}
