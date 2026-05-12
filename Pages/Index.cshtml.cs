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
            LakeList = new List<Lake>();
        }

        public List<Fish> FishList { get; set; }
        public List<Lake> LakeList { get; set; }

        public void OnGet()
        {
            FishList = _context.Fish.ToList();
            LakeList = _context.Lake.ToList();
        }
        
    }
}
