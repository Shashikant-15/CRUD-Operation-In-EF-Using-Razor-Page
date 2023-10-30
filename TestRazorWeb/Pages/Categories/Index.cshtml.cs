using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TestRazorWeb.Data;
using TestRazorWeb.Model;

namespace TestRazorWeb.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public IEnumerable<Category> Categories { get; set; }

        public IndexModel(ApplicationDbContext context) 
        { 
            _context = context; 
        }
        public void OnGet()
        {
            Categories = _context.Category;
        }
    }
}
