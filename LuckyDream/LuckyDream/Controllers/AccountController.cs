using LuckyDream.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LuckyDream.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            var model = new LoginViewModel();
            return View(model);
        }

        public ActionResult CheckLogin(LoginViewModel loginForm)
        {
            return View("Index", "Home");
        }
    }
}