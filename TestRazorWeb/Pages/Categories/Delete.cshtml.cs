using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TestRazorWeb.Data;
using TestRazorWeb.Model;

namespace TestRazorWeb.Pages.Categories
{
    public class DeleteModel : PageModel
    {
        [BindProperty]
        public Category Category {  get; set; }
        private ApplicationDbContext _Context;

        public DeleteModel(ApplicationDbContext context)
        {
            
            _Context = context;
        }

        public void OnGet(int id)
        {
            Category = _Context.Category.Find(id);
        }
        public async Task<IActionResult> OnPost()
        {


                var category = _Context.Category.FirstOrDefault(x => x.Id == Category.Id);
                if (category != null)
                {
                    _Context.Category.Remove(category);
                    await _Context.SaveChangesAsync();
                    return RedirectToPage("Index");
                }

                return Page();
            
       
        }
    }
}
