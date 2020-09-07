using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PizzaShop.Data;
using PizzaShop.ProtoTypes;

namespace PizzaShop.Pages.PizzaOrderView
{
    public class CreateModel : PageModel
    {
        private readonly PizzaShop.Data.PizzaShopContext _context;

        public CreateModel(PizzaShop.Data.PizzaShopContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["OrderNumber"] = new SelectList(_context.Order, "OrderNumber", "OrderNumber");
        ViewData["PizzaCode"] = new SelectList(_context.Set<Pizza>(), "PizzaCode", "PizzaCode");
            return Page();
        }

        [BindProperty]
        public PizzaOrder PizzaOrder { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.PizzaOrder.Add(PizzaOrder);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
