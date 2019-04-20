using ChoixResto.Models;
using ChoixResto.ViewModels;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ChoixResto.Controllers
{
    public class AccueilController : Controller
    {
        public ActionResult Index()
        {
            /*ViewData["message"] = "Bonjour depuis le contrôleur";
            ViewData["date"] = DateTime.Now;
            Resto r = new Resto { Nom = "La bonne fourchette", Telephone = "1234" };
            return View(r);*/

            //view-model
            AccueilViewModel vm = new AccueilViewModel
            {
                Message = "Bonjour depuis le <span style=\"color:red\">contrôleur</span>",
                Date = DateTime.Now,
                //Un seul Resto
                Resto = new Resto { Nom = "La bonne fourchette", Telephone = "1234" },
                //Tous les Restos
                ListeDesRestos = new List<Resto>
                {
                    new Resto { Nom = "Resto pinambour", Telephone = "1234" },
                    new Resto { Nom = "Resto tologie", Telephone = "1234" },
                    new Resto { Nom = "Resto ride", Telephone = "5678" },
                    new Resto { Nom = "Resto toro", Telephone = "555" },
                }
            };
            return View(vm);
        }
    }
}