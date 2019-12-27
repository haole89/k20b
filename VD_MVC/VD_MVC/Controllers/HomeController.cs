using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VD_MVC.Models;
namespace VD_MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            int hour = 0;
            hour = DateTime.Now.Hour;
            if (hour > 12)
                ViewBag.loichao = "Chào buổi chiều!";
            else
                ViewBag.loichao = "Chào buổi sáng!";
            return View();
        }

        [HttpGet]
        public ViewResult XuLy()
        {
            return View();
        }

        [HttpPost]
        public ViewResult XuLy(KhachMoi khach)
        {
            //insert into database
            return View("HoanThanh", khach);
        }

    }
}