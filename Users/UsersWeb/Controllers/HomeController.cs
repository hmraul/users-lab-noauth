using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UsersWeb.Controllers
{
    public class HomeController : Controller
    {
        readonly IUsersDomain _usersDomain;

        public HomeController(IUsersDomain usersDomain)
        {
            _usersDomain = usersDomain;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = _usersDomain.SayHi("Your application description page.");

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}