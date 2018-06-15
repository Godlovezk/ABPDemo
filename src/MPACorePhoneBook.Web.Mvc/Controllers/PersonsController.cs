using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MPACorePhoneBook.Controllers;
using MPACorePhoneBook.PhoneBooks;
using MPACorePhoneBook.PhoneBooks.Dto;

namespace MPACorePhoneBook.Web.Mvc.Controllers
{
    public class PersonsController : MPACorePhoneBookControllerBase
    {
        private readonly IPersonAppService _personAppService;
        public PersonsController(IPersonAppService personAppService)
        {
            _personAppService = personAppService;
        }
        public async Task<IActionResult> Index(GetPersonInput input)
        {
           var dtos= await  _personAppService.GetPagedPersonAsync(input);
            return View(dtos);
        }
    }
}