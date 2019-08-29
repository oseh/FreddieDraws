using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FreddieDraws.Controllers
{ 
    public class FreddieDrawsController : Controller
    {
        public ActionResult ComicBookPanel()
        {
            return View();
        }
    }
}