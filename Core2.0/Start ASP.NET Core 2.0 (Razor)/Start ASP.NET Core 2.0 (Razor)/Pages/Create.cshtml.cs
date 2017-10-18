using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesContacts.Data;

//namespace Start ASP.NET Core 2.0 (Razor).Pages
//{
//    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
//    [HtmlTargetElement("tag-name")]
//    public class Create : TagHelper
//    {
//        public override void Process(TagHelperContext context, TagHelperOutput output)
//        {

//        }
//    }
//}

namespace RazorPagesContacts.Pages
{
    public class CreateModel : PageModel
    {
        private readonly AppDbContext _db;

        public CreateModel(AppDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Customer Customer { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _db.Customers.Add(Customer);
            await _db.SaveChagesAsync();
            return RedirectToPage("/Index");
        }
    }
}
