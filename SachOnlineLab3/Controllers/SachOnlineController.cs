﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SachOnlineLab3.Models;


namespace SachOnlineLab3.Controllers
{
    
    public class SachOnlineController : Controller
    {
       
        // GET: SachOnline
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ChuDePartial()
        {
            return PartialView();
        }

        public ActionResult NXBPartial()
        {
            return PartialView();
        }

        public ActionResult SliderPartial()
        {
            return PartialView();
        }

    }
}