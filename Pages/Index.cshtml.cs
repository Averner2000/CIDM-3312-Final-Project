using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Final_Project.Models;

namespace Final_Project.Pages;

public class IndexModel : PageModel
{
    private readonly DragonContext  _context;
    private readonly ILogger<IndexModel> _logger;
    public List<Dragon> Dragons {get;set;} = default!;

    public IndexModel(DragonContext context,ILogger<IndexModel> logger)
    {
        _context = context;
        _logger = logger;
    }

    public void OnGet()
    {
        Dragons = _context.Dragons.ToList();
    }
}
