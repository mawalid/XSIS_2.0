﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Xsis.Repo;

namespace Xsis.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Session["foo"] = 99;
            return View();
        }

        public ActionResult Tampil(int ID)
        {
            return Json(HomeRepo.GetAll(ID), JsonRequestBehavior.AllowGet);
        }
    }
}