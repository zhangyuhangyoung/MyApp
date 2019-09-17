using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyApp.Data;
using MyApp.Models;
using Microsoft.AspNetCore.Authorization;

namespace MyApp.Pages.Books
{
   //[Authorize(Roles = "Admin")]
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly MyApp.Data.ApplicationDbContext _context;

        public CreateModel(MyApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public MyBook MyBook { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.MyBook.Add(MyBook);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}