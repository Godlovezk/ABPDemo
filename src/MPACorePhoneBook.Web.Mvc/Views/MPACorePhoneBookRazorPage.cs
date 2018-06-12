using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace MPACorePhoneBook.Web.Views
{
    public abstract class MPACorePhoneBookRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected MPACorePhoneBookRazorPage()
        {
            LocalizationSourceName = MPACorePhoneBookConsts.LocalizationSourceName;
        }
    }
}
