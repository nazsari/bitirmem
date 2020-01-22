using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KurumsalWeb.Controllers
{
    public class HomeController : Controller
    {
        // GET: Rota
        public ActionResult Index()
        {
            return View();
        }
    }
}