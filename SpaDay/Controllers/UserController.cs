using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;
using SpaDay.ViewModels;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()

        {
            
            return View();
        }

        public IActionResult Add()
        {
            AddUserViewModel addUserViewModel = new AddUserViewModel();

            return View();
        }

        [HttpPost]
        [Route("/user")]
        public IActionResult SubmitAddUserForm(User newUser, AddUserViewModel addUserViewModel)
        {

            if (ModelState.IsValid)

            {

                if (addUserViewModel.Password == addUserViewModel.VerifyPassword)
                {

                    ViewBag.user = newUser;
                }

                return View("Index");
            }
            else
            {
                ViewBag.error = "Passwords do not match! Try again!";
                //ViewBag.user = newUser;
                ViewBag.username = newUser.Username;
                ViewBag.email = newUser.Email;
                return View("Add");
            }
        }

        }
}
