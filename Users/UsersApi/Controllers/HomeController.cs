﻿using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UsersApi.Controllers
{
    public class HomeController : Controller
    {
        readonly IUsersDomain _usersDomain;

        public HomeController()
        {
            bool isRegitered = false;
        }

        public HomeController(IUsersDomain usersDomain)
        {
            _usersDomain = usersDomain;
        }

        public ActionResult Index()
        {
            ViewBag.Title = _usersDomain.SayHi("Home Page");

            return View();
        }
    }
}
