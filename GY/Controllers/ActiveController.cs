using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Model;
using GY.Models;

namespace GY.Controllers
{
    public class ActiveController : Controller
    {
        GYEntities db = new GYEntities();
        ActiveManager am = new ActiveManager();
        // GET: Active
        public ActionResult Index()
        {
            ActiveViewMode activeviewmode = new ActiveViewMode();
            activeviewmode.GetTypeActive1 = am.GetTypeActive(1);
            activeviewmode.GetTypeActive2 = am.GetTypeActive(2);
            activeviewmode.GetTypeActive3 = am.GetTypeActive(3);

            return View(activeviewmode);

        }
    }
}