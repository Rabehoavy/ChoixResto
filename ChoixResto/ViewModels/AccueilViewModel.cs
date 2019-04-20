using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ChoixResto.ViewModels
{
    public class AccueilViewModel
    {
        [Display(Name = "Le message")]
        public string Message { get; set; }
        public DateTime Date { get; set; }
        //Un seul Resto
        public Models.Resto Resto { get; set; }
        //Tous les Restos
        public List<Models.Resto> ListeDesRestos { get; set; }
        public string Login { get; set; }
    }
}