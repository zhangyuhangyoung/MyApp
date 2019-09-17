using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyApp.Data;
using MyApp.Models;
using Microsoft.AspNetCore.Authorization;

namespace MyApp.Pages.Books
{
    [Authorize]
    public class DetailsModel : PageModel
    {
        private readonly MyApp.Data.ApplicationDbContext _context;

        public DetailsModel(MyApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public MyBook MyBook { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MyBook = await _context.MyBook.FirstOrDefaultAsync(m => m.ID == id);

            if (MyBook == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
