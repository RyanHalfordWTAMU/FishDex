using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;

namespace FishDex.Pages
{

    public class addLakeModel(FishDBContext context) : PageModel
    {
        private readonly FishDBContext _context = context;

        [BindProperty]
        public Lake? NewLake { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Lake.Add(NewLake);
            _context.SaveChanges();

            return RedirectToPage("/Index");
        }
    }
}