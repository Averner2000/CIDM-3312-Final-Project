using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Final_Project.Models;

namespace Final_Project.Pages.Dragons
{
    public class CreateModel : PageModel
    {
        private readonly Final_Project.Models.DragonContext _context;

        public CreateModel(Final_Project.Models.DragonContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["AllegianceId"] = new SelectList(_context.Allegiances, "AllegianceId", "AllegianceId");
        ViewData["CountryId"] = new SelectList(_context.Countrys, "CountryId", "CountryId");
            return Page();
        }

        [BindProperty]
        public Dragon Dragon { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Dragons == null || Dragon == null)
            {
                return Page();
            }

            _context.Dragons.Add(Dragon);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
