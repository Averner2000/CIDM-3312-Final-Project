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
    public class IndexModel : PageModel
    {
        private readonly Final_Project.Models.DragonContext _context;

        public IndexModel(Final_Project.Models.DragonContext context)
        {
            _context = context;
        }

        public IList<Dragon> Dragon { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Dragons != null)
            {
                Dragon = await _context.Dragons
                .Include(d => d.Allegiance)
                .Include(d => d.Country).ToListAsync();
            }
        }
    }
}
