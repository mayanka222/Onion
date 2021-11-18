using BAL.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Onionar.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ViewModel;

namespace Onionar.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStudent _IStudent;
        public HomeController(ILogger<HomeController> logger, IStudent IStudent)
        {
            _logger = logger;
            _IStudent = IStudent;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Log Information to Debug Window!");
            _logger.LogWarning("Log Warning to Debug Window!");
            _logger.LogInformation("My error");


            return View();
        }
        public IActionResult InputForm()
        {
            var x = _IStudent.Getlist();
            return View();
        }
        public IActionResult InputFormAjex()
        {
            return View();
        }
        /// <summary>
        /// Save Student Details 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult InputFormDetails(VmStudent obj)
        {
            try
            {
                if(obj!=null)
                {
                bool x= _IStudent.AddStudents(obj);
                    if(x==true)
                    {
                        TempData["msg"] = "Data Saved ";
                    }
                    else
                    {
                        TempData["msg"] = "Something Error";
                    }
                }
            }
            catch (Exception ex )
            {

                throw ex;
            }
            return RedirectToAction("InputForm");
        }
        [HttpPost]
        public IActionResult InputFormDeatilsAjex(VmStudent model)
        {
            var x = 0;
            return new JsonResult(x);
        }
        public IActionResult InputFormDetails1(VmStudent obj)
        {
        var x=_IStudent.Getcal(obj.ID);
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
