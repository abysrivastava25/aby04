﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Intro_Mvc.Controllers
{
    public class ChildController : Controller
    {
        // GET: Child
        public ActionResult Index()
        {
            return View();
        }
    }
}