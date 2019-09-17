using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using MyApp.Models;

namespace MyApp.Pages.Books
{
    [Authorize]
    public class OwnBookModel : PageModel
    {
        private readonly MyApp.Data.ApplicationDbContext _context;

        public OwnBookModel(MyApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public List<MyBook> MyBook { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            string userName= User.Identity.Name;
            IQueryable<MyBook> BookIQ = from s in _context.MyBook select s;
            BookIQ = BookIQ.Where(s => s.UserName.ToUpper().Contains(userName.ToUpper()));

            MyBook = await BookIQ.AsNoTracking().ToListAsync();
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(MyBook).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                    throw;
            }

            return RedirectToPage("./Index");
        }

        private bool MyBookExists(int id)
        {
            return _context.MyBook.Any(e => e.ID == id);
        }
    }
}
