using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TestRazorWeb.Data;
using TestRazorWeb.Model;

namespace TestRazorWeb.Pages.Categories
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Category Category {  get; set; }
        private ApplicationDbContext _Context;

        public EditModel(ApplicationDbContext context)
        {
            
            _Context = context;
        }

        public void OnGet(int id)
        {
            Category = _Context.Category.Find(id);
        }
        public async Task<IActionResult> OnPost()
        {

            if (ModelState.IsValid)
            {
                _Context.Category.Update(Category);
                await _Context.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            return Page();
       
        }
    }
}
