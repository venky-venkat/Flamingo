using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Flamingo.Controllers
{
    public class AboutController : Controller
    {
        // GET: about
        public ActionResult Index()
        {
            return View();
        }
    }
}