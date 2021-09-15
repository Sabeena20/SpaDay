using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("/user/add/")]
        public IActionResult Add()
        {
            return View();
        }

        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            // add form submission handling code here
        }
    }
}
