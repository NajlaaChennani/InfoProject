using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetScrum.Models;
using System.Web.Security;
using System.Net.Mail;
using System.Net;
using System.Web.Helpers;

namespace ProjetScrum.Controllers
{
    public class LoginController : Controller
    {
        GLDatabaseEntities entity = new GLDatabaseEntities();

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegisterTrait(string nom, string prenom, string email, int age, string qst, string mdp)
        {
            Developpeur user = new Developpeur();
            user.Nom = nom;
            user.Prenom = prenom;
            user.Email = email;
            user.Age = age;
            user.Mdp = mdp;
            user.Secretquestion = qst;
            entity.Developpeurs.Add(user);
            entity.SaveChanges();
            
            return RedirectToAction("Index");
        
            }

      

        [HttpPost]
        public ActionResult LoginTrait(string email, string mdp)
        {
            entity = new GLDatabaseEntities();
            for (int i = 0; i < entity.Developpeurs.ToList().Count; i++)
            {
                if (entity.Developpeurs.ToList().ElementAt(i).Email.Equals(email) && entity.Developpeurs.ToList().ElementAt(i).Mdp.Equals(mdp))
                {
                        Session["user"] = entity.Developpeurs.ToList().ElementAt(i);
                    return Redirect(Url.Action("Index", "Acceuil"));

                }
            }
          
                return RedirectToAction("Index");
            
        }

        public ActionResult ForgotPassword()
        {
            return View();
        }


    }
}