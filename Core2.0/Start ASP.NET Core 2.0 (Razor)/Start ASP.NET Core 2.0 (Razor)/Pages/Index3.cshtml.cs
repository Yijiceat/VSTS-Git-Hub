using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesContacts.Data;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

//namespace Start ASP.NET Core 2.0 (Razor).Pages
//{
//    public class Index3Model : PageModel
//    {
//        public void OnGet()
//        {
//        }
//    }
//}

namespace RazorPagesContacts.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _db;

        public IndexModel(AppDbContext db)
        {
            _db = db;
        }

        public IList<Customer> Customers { get; set; }

        public async Task OnGetAsync()
        {
            Customers = await _db.Customers.AsNoTracking().ToListAsync();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var contact = await _db.Customer.FindAsync(id);

            if(contact != null)
            {
                _db.Customers.Remove(contact);
                await _db.SaceChangesAsync();
            }

            return RedirectToPage();
        }
    }
}