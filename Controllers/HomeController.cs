using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VisitorManagement.Business;
using VisitorManagement.Data;
using VisitorManagement.Models;

namespace VisitorManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ITextFileOperations _textFileOperations;
        


        public HomeController(ILogger<HomeController> logger, ITextFileOperations textFileOperations)
        {
            _logger = logger;
            _textFileOperations = textFileOperations;
        }

        public IActionResult Index()
        {
            ViewData["ConditionsHeader"] = "SNZ Pathfinders";

            ViewData["Conditions"] = _textFileOperations.LoadConditionsText();
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
