using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PizzaShop.Data;
using PizzaShop.ProtoTypes;

namespace PizzaShop.Pages.PizzaView
{
    public class DetailsModel : PageModel
    {
        private readonly PizzaShop.Data.PizzaShopContext _context;

        public DetailsModel(PizzaShop.Data.PizzaShopContext context)
        {
            _context = context;
        }

        public Pizza Pizza { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Pizza = await _context.Pizza.FirstOrDefaultAsync(m => m.PizzaCode == id);

            if (Pizza == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
