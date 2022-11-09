using BankApp.WebUI.Data.Context;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankApp.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly BankContext _bankContext;

        public AccountController(BankContext bankContext)
        {
            _bankContext = bankContext;
        }

        public IActionResult Create(int id)
        {
            var userInfo = _bankContext.ApplicationUsers.SingleOrDefault(x => x.Id == id);
            return View(userInfo);
        }
    }
}
