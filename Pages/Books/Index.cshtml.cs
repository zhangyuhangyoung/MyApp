using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyApp;
using MyApp.Models;
using Microsoft.AspNetCore.Authorization;
namespace MyApp.Pages.Books
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly MyApp.Data.ApplicationDbContext _context;

        public IndexModel(MyApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }
        public string NameSort { get; set; }
        public string TitleSort { get; set; }
        public string DateSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

       // public IList<MyBook> MyBook { get;set; }
        public PaginatedList<MyBook> MyBook { get; set; }
        public async Task OnGetAsync(string sortOrder, string currentFilter, string searchString, int? pageIndex)
        {
            CurrentSort = sortOrder;
            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "name";
            TitleSort = String.IsNullOrEmpty(sortOrder) ? "title_desc" : "title";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";
            if (searchString != null)
            {
                pageIndex = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            CurrentFilter = searchString;

            IQueryable<MyBook> BookIQ = from s in _context.MyBook select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                BookIQ = BookIQ.Where(s => s.Title.ToUpper().Contains(searchString.ToUpper()));
                                  //     || s.Title.ToUpper().Contains(searchString.ToUpper()));
            }

            switch (sortOrder)
            {
                case "title":
                    BookIQ = BookIQ.OrderBy(s => s.Title);
                    break;
                case "title_desc":
                    BookIQ = BookIQ.OrderByDescending(s => s.Title);
                    break;
                case "name":
                    BookIQ = BookIQ.OrderBy(s => s.Author);
                    break;
                case "name_desc":
                    BookIQ = BookIQ.OrderByDescending(s => s.Author);
                    break;
                case "Date":
                    BookIQ = BookIQ.OrderBy(s => s.PublishedDate);
                    break;
                case "date_desc":
                    BookIQ = BookIQ.OrderByDescending(s => s.PublishedDate);
                    break;
                default:
                    BookIQ = BookIQ.OrderBy(s => s.Title);
                    break;
            }
            int pageSize = 5;
            MyBook = await PaginatedList<MyBook>.CreateAsync(
                BookIQ.AsNoTracking(), pageIndex ?? 1, pageSize);

            // Student = await studentIQ.AsNoTracking().ToListAsync();
            //MyBook = await _context.MyBook.ToListAsync();
            MyBook = await PaginatedList<MyBook>.CreateAsync(BookIQ.AsNoTracking(), pageIndex ?? 1, pageSize);
         }
    }
}
