using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyApp.Models;
using Microsoft.AspNetCore.Authorization;


namespace MyApp.Pages.Books
{
    [Authorize]
    public class EditModel : PageModel
    {
        private readonly MyApp.Data.ApplicationDbContext _context;

        public EditModel(MyApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public MyBook MyBook { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MyBook = await _context.MyBook.FirstOrDefaultAsync(m => m.ID == id);
            if (String.IsNullOrEmpty(MyBook.CheckedDate.ToString()))
            {
              MyBook.UserName = User.Identity.Name;
            }
            else
            {
                if (string.Compare(MyBook.UserName, User.Identity.Name) != 0)
                {

                    return RedirectToPage("./bookerror");
                }
            }
            if (MyBook == null)
            {
                return NotFound();
            }
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
                if (!MyBookExists(MyBook.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MyBookExists(int id)
        {
            return _context.MyBook.Any(e => e.ID == id);
        }
    }
}
