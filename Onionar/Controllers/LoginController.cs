using BAL.Interface;
using Microsoft.AspNetCore.Http;
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
            if(x.ID>0)
            {
                HttpContext.Session.Clear();
                HttpContext.Session.SetString("ID", (x.ID).ToString());

                if (HttpContext.Session.GetString("ID") != null)
                {

                }
                return RedirectToAction("index");
            }
            else
            {
                if (HttpContext.Session.GetString("ID") != null)
                {

                }
                return RedirectToAction("index");
            }
            return RedirectToAction("index");
        }
        [HttpGet]
        public IActionResult Registration()
        {
            if (HttpContext.Session.GetString("ID") != null)
            {
                var x = HttpContext.Session.GetString("ID");
                return View();
            }
            else
            {
                return RedirectToAction("index", "Login");
            }      
        }
        [HttpPost]
        public IActionResult Registration(VMUserDetails obj)
        {
            var x = _ILogin.Registration(obj);
            return View();
        }
    }
}
