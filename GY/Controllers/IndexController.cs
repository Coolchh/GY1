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
    public class IndexController : Controller
    {
        GYEntities db = new GYEntities();
        MoviesManager mv = new MoviesManager();
        ImagesManager im=new ImagesManager();
        ActiveManager am = new ActiveManager();
        // GET: Index
        public ActionResult Index()
        {
            IndexViewMode indexviewmode = new IndexViewMode();
            indexviewmode.GetNewMovies = mv.GetNewVideo().Take(3);
            indexviewmode.GetImages = im.GetImages();
            indexviewmode.GetActive = am.GetActive().Take(8);
            return View(indexviewmode);
        }
    }
}