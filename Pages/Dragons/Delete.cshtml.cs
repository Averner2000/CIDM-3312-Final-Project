using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Final_Project.Models;

namespace Final_Project.Pages.Dragons
{
    public class DeleteModel : PageModel
    {
        private readonly Final_Project.Models.DragonContext _context;

        public DeleteModel(Final_Project.Models.DragonContext context)
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

            var dragon = await _context.Dragons.FirstOrDefaultAsync(m => m.DragonId == id);

            if (dragon == null)
            {
                return NotFound();
            }
            else 
            {
                Dragon = dragon;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Dragons == null)
            {
                return NotFound();
            }
            var dragon = await _context.Dragons.FindAsync(id);

            if (dragon != null)
            {
                Dragon = dragon;
                _context.Dragons.Remove(Dragon);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
