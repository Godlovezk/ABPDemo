using Microsoft.AspNetCore.Antiforgery;
using MPACorePhoneBook.Controllers;

namespace MPACorePhoneBook.Web.Host.Controllers
{
    public class AntiForgeryController : MPACorePhoneBookControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
