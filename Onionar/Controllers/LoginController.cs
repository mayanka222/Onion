using BAL.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModel;

namespace Onionar.Controllers
{
    public class LoginController : Controller
    {
        public readonly ILogin _ILogin;
        public LoginController(ILogin ILogin)
        {
            _ILogin = ILogin;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(VMUserDetails obj)
        {
            var x = _ILogin.LoginDetails(obj);
            return RedirectToAction("index");
        }
        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registration(VMUserDetails obj)
        {
            var x = _ILogin.Registration(obj);
            return View();
        }
    }
}
