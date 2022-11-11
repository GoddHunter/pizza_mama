using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using System.ComponentModel.DataAnnotations;

namespace pizza_mama.Models
{
    public class Pizza
    {
        public int PizzaID { get; set; }

        [Display(Name = "Nom")]
        public string name { get; set; }
        [Display(Name = "Prix (€)")]
        public float price { get; set; }
        [Display(Name = "Végétarienne")]
        public bool vegetarian { get; set; }
        [Display(Name = "Ingrédients")]
        public string ingredients { get; set; }
    }
}
