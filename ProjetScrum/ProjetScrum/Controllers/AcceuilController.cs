using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetScrum.Models;

namespace ProjetScrum.Controllers
{
    public class AcceuilController : Controller
    {
        // GET: Acceuil
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            
             
            return View();
           
        }
    }
}