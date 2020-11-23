using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _002.Class.Models;

namespace _002.Class.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string ProceedResult(User user)
        {
            return $"Name: {user.Name}. Surname: {user.Surname}. Age: {user.Age}.";
        }
    }
}
