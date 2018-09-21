using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Prova1.Models;

namespace Prova1.Controllers
{
    public class ProvaController : Controller
    {
        

        // GET: Prova
        public ActionResult Index()
        {
            return View();
        }

        

        public ActionResult Compila()
        {
            return Index();
        }


        [Route("prova/form")]
        public ActionResult Form()
        {
            return View();
        }

        [HttpPost]

        public ActionResult AddUser(string input)
        {
            User utente1 = new User();
            User utente2 = new User();
            utente1.name = "pluto";
            utente2.name = "samuele";
            utente1.city = "Milano";
            utente2.city = "Palermo";
            
            User[] x = {utente1,utente2};
  
            //var num = Convert.ToInt32(input);
            int i= 0;
            Boolean a = true;
            do
            {
                if (x[i].name.Equals(input.ToLower()))
                {
                    a = false;
                }
                else
                {
                    i++;
                }
            } while (i < x.Length && a);

            if (i > x.Length-1)
                return Content("Non ho trovato il nome nel database");
            
            return Content("Ho trovato il nome in posizione " + (i+1) + ", ed abita a " + x[i].city);
        }
    }
}