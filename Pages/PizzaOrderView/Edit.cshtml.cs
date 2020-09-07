using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PizzaShop.Data;
using PizzaShop.ProtoTypes;

namespace PizzaShop.Pages.PizzaOrderView
{
    public class EditModel : PageModel
    {
        private readonly PizzaShop.Data.PizzaShopContext _context;

        public EditModel(PizzaShop.Data.PizzaShopContext context)
        {
            _context = context;
        }

        [BindProperty]
        public PizzaOrder PizzaOrder { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PizzaOrder = await _context.PizzaOrder
                .Include(p => p.Order)
                .Include(p => p.Pizza).FirstOrDefaultAsync(m => m.PizzaOrderId == id);

            if (PizzaOrder == null)
            {
                return NotFound();
            }
           ViewData["OrderNumber"] = new SelectList(_context.Order, "OrderNumber", "OrderNumber");
           ViewData["PizzaCode"] = new SelectList(_context.Set<Pizza>(), "PizzaCode", "PizzaCode");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(PizzaOrder).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PizzaOrderExists(PizzaOrder.PizzaOrderId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool PizzaOrderExists(int id)
        {
            return _context.PizzaOrder.Any(e => e.PizzaOrderId == id);
        }
    }
}
