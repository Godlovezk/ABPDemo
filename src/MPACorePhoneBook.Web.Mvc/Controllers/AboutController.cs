using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using MPACorePhoneBook.Controllers;

namespace MPACorePhoneBook.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : MPACorePhoneBookControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
