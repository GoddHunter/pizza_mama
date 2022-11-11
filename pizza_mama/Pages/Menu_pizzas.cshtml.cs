using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using pizza_mama.Data;
using pizza_mama.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pizza_mama.Pages
{
    public class Menu_pizzasModel : PageModel
    {
        private readonly pizza_mama.Data.DataContext _context;

        public Menu_pizzasModel(pizza_mama.Data.DataContext context)
        {
            _context = context;
        }
        public IList<Pizza> Pizzas { get; set; }

        public async Task OnGetAsync()
        {
            Pizzas = await _context.Pizzas.ToListAsync();
            Pizzas = Pizzas.OrderBy(p => p.price).ToList();
        }
    }
}
