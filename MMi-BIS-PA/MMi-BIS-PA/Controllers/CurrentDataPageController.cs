﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MMi_BIS_PA.App_Data;

namespace MMi_BIS_PA.Controllers
{
    public class CurrentDataPageController : Controller
    {
        [Route("CurrentDataPage/CurrentDataPage")]
        public ActionResult CurrentDataPage()
        {
            
            return View();
        }
    }
}