using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using MPACorePhoneBook.Controllers;

namespace MPACorePhoneBook.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : MPACorePhoneBookControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
