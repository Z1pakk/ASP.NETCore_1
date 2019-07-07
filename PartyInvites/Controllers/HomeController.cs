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

        [HttpGet]
        public ViewResult RsvpForm()
        {
            //Якщо знайдеться вюшка з назвою RsvpForm.cshtml то вона покажеться
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {

            Repository.AddResponse(guestResponse);
            //Цей метод каже що потрібно визвати 
            //представлення 'Thanks' і передаємо туда нашу модель
            return View("Thanks",guestResponse);
        }
        //Секрет кроется в привязке модели -удобной функциональной возможности МVС, посредством которой производится разбор входящих данных и применение пар "ключ/значение" в НТГР-запросе для заполнения свойств в типах моделей предметной области.
        //Привязка модели - мощное и настраиваемое средство, которое избавляет от кропотливого и тяжелого труда по взаимодействию с НТTР-запросами напрямую и позволяет
        //работать с объектами С#, а не иметь дело с индивидуальными значениями данных, отправляемыми браузером. Объект GuestResponse, который передается методу действия
        //RsvpForm() в качестве параметра, автоматически заполняется данными из полей формы.
    }
}
