using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;

namespace FishDex.Pages;

    public class deleteCatchModel : PageModel
    {
        private readonly FishDBContext _context;

        public deleteCatchModel(FishDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Fish NewFish { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Fish.Remove(NewFish);
            _context.SaveChanges();

            return RedirectToPage("/Index");
        }
    }