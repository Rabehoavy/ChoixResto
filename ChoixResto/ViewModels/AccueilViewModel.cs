using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChoixResto.ViewModels
{
    public class AccueilViewModel
    {
        public string Message { get; set; }
        public DateTime Date { get; set; }
        //Un seul Resto
        public Models.Resto Resto { get; set; }
        //Tous les Restos
        public List<Models.Resto> ListeDesRestos { get; set; }
    }
}