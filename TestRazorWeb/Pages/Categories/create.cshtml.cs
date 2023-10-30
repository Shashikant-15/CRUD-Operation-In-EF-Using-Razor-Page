using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TestRazorWeb.Data;
using TestRazorWeb.Model;

namespace TestRazorWeb.Pages.Categories
{
    public class createModel : PageModel
    {
        [BindProperty]
        public Category Category {  get; set; }
        private ApplicationDbContext _Context;

        public createModel(ApplicationDbContext context)
        {
            
            _Context = context;
        }

        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                await _Context.Category.AddAsync(Category);
                await _Context.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            return Page();
       
        }
    }
}
