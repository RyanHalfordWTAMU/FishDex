using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;
using System.Collections.Generic;
namespace FishDex.Pages
{
    public class IndexModel : PageModel
    {
        private readonly FishDBContext _context;

        public IndexModel(FishDBContext context)
        {
            _context = context;
            FishList = new List<Fish>();
        }

        public List<Fish> FishList { get; set; }

        public void OnGet()
        {
            FishList = _context.Fish.ToList();
        }
    }
}
