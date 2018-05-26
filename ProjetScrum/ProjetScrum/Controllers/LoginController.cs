using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetScrum.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LoginTrait(string nom, string prenom, string email, int age, string qst, string mdp)
        {
            return RedirectToAction("Index");
        }
    }
}