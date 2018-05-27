using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetScrum.Models;
namespace ProjetScrum.Controllers
{
    public class LoginController : Controller
    {
        GLDatabaseEntities entity;
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult RegisterTrait(string nom, string prenom, string email, int age, string qst, string mdp)
        {
            entity = new GLDatabaseEntities();
            User user = new User();
            user.Nom = nom;
            user.Prenom = prenom;
            user.Email = email;
            user.Age = age;
            user.Mdp = mdp;
            user.Secretquestion = qst;
            entity.Users.Add(user);
            entity.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult LoginTrait(string email, string mdp, string session)
        {
            entity = new GLDatabaseEntities();
            Boolean bool1 = false;
            for(int i=0; i<entity.Users.ToList().Count;i++)
            {
                if(entity.Users.ToList().ElementAt(i).Email.Equals(email) && entity.Users.ToList().ElementAt(i).Mdp.Equals(mdp))
                {
                    if(session.Equals("true"))
                    {
                        Session["user"] = entity.Users.ToList().ElementAt(i);
                    }
                    bool1 = true;
                    break;
                }
            }
            if(bool1)
            {
                return Redirect(Url.Action("Index", "Acceuil"));
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}