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
    public class IndexModel : PageModel
    {
        private readonly PizzaShop.Data.PizzaShopContext _context;

        public IndexModel(PizzaShop.Data.PizzaShopContext context)
        {
            _context = context;
        }

        public IList<Pizza> Pizza { get;set; }

        public async Task OnGetAsync()
        {
            Pizza = await _context.Pizza.ToListAsync();
        }
    }
}
