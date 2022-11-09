using BankApp.WebUI.Data.Context;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankApp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly BankContext _bankContext;

        public HomeController(BankContext bankContext)
        {
            _bankContext = bankContext;
        }

        public IActionResult Index()
        {
            return View(_bankContext.ApplicationUsers.ToList());
        }
    }
}
