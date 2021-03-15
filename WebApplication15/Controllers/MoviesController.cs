using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication15.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult RandomMovi()
        {
            return View();
        }


        public ActionResult NewMovie()
        {
            return View();
        }
        public ActionResult ReleaseMoveByDate()
        {
            return View();
        }
    }
}