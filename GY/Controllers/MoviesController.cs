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
    public class MoviesController : Controller
    {
        GYEntities db = new GYEntities();
        MoviesManager mv = new MoviesManager();
        MessageManager ms = new MessageManager();
        MoviesTypeManager mt = new MoviesTypeManager();
        // GET: Movies
        public ActionResult Index()
        {
            MoviesViewMode moviesviewmode = new MoviesViewMode();
            moviesviewmode.Movies1 = mv.GetVideo();
            moviesviewmode.GetNewMovies = mv.GetNewVideo().Take(3);
            moviesviewmode.GetMoviesTpye = mt.GetMoviesType();
            return View(moviesviewmode);
        }
    }
}