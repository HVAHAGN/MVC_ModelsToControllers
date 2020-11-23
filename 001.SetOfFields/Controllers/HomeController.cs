using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _001.SetOfFields.Models;

namespace _001.SetOfFields.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string ProceedResult(string name, string surname, int age)
        {
            User user = new User()
            {
                Name = name,
                Surname = surname,
                Age = age
            };

            return $"Name: {user.Name}. Surname: {user.Surname}. Age: {user.Age}.";
        }
    }
}
