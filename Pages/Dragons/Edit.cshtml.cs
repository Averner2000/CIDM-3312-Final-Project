using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Final_Project.Models;

namespace Final_Project.Pages.Dragons
{
    public class EditModel : PageModel
    {
        private readonly Final_Project.Models.DragonContext _context;

        public EditModel(Final_Project.Models.DragonContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Dragon Dragon { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Dragons == null)
            {
                return NotFound();
            }

            var dragon =  await _context.Dragons.FirstOrDefaultAsync(m => m.DragonId == id);
            if (dragon == null)
            {
                return NotFound();
            }
            Dragon = dragon;
           ViewData["AllegianceId"] = new SelectList(_context.Allegiances, "AllegianceId", "AllegianceId");
           ViewData["CountryId"] = new SelectList(_context.Countrys, "CountryId", "CountryId");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Dragon).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DragonExists(Dragon.DragonId))
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

        private bool DragonExists(int id)
        {
          return (_context.Dragons?.Any(e => e.DragonId == id)).GetValueOrDefault();
        }
    }
}
