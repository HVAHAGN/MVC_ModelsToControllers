using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _003.MultipleClasses.Models;

namespace _003.MultipleClasses.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string ProceedResult(User[] users)
        {
            string result = "";

            foreach (User user in users)
                result += $"Name: {user.Name}. Surname: {user.Surname}. Age: {user.Age}.\n";

            return result;
        }
    }
}
