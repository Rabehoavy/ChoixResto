using ChoixResto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChoixResto.Controllers
{
    public class AccueilController : Controller
    {
        public ActionResult Index()
        {
            ViewData["message"] = "Bonjour depuis le contrôleur";
            ViewData["date"] = DateTime.Now;
            Resto r = new Resto { Nom = "La bonne fourchette", Telephone = "1234" };
            return View(r);
        }
    }
}