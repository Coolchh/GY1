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
        // GET: Active
        public ActionResult Index()
        {
            GYEntities db = new GYEntities();
            ActiveManager am = new ActiveManager();
            return View();

        }
    }
}