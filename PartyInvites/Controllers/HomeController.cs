using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        //public string Index()
        //{
        //    return "Hello world";
        //}

        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            //Показуэться вюшка з назвою MyView.cshtml
            return View("MyView");
        }

        public ViewResult RsvpForm()
        {
            //Якщо знайдеться вюшка з назвою RsvpForm.cshtml то вона покажеться
            return View();
        }
    }
}
