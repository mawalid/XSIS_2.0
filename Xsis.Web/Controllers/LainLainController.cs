﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Xsis.Repo;

namespace Xsis.Web.Controllers
{
    public class LainLainController : Controller
    {
        // GET: LainLain
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Tampil(int idBiodata)
        {
            return Json(LainLainRepo.GetAll(idBiodata), JsonRequestBehavior.AllowGet);
        }
    }
}