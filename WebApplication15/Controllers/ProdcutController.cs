using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication15.Controllers
{
    // control action method return type 
    public class ProdcutController : Controller
    {
     
        public ActionResult RandomMovi()
        {

            return RedirectToAction("User");
        }

        public ActionResult User()
        {

            return View();
        }
    }
}