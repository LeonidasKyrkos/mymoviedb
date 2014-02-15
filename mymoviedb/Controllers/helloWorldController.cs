using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mymoviedb.Controllers
{
    public class helloWorldController : Controller
    {
        //
        // GET: /helloWorld/

        public ActionResult Index()
        {
            return View();
        }

        //GET: /helloWorld/Welcome/
        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.numTimes = numTimes;

            return View();
        }
    }
}
