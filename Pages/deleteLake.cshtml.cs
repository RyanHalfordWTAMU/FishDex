using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;

namespace FishDex.Pages;

    public class deleteLakeModel : PageModel
    {
        private readonly FishDBContext _context;

        public deleteLakeModel(FishDBContext context)
        {
            _context = context;
        }

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

            _context.Lake.Remove(NewLake);
            _context.SaveChanges();

            return RedirectToPage("/Index");
        }
    }