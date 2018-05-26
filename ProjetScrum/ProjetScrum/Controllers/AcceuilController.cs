using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetScrum.Controllers
{
    public class AcceuilController : Controller
    {
        // GET: Acceuil
        public ActionResult Index()
        {
            return View();
        }
    }
}