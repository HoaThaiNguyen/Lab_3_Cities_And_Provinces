using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CommunityApp_Lab3.Data;
using CommunityApp_Lab3.Models;

namespace CommunityApp_Lab3.Pages_CityPages
{
    public class CreateModel : PageModel
    {
        private readonly CommunityApp_Lab3.Data.ApplicationDbContext _context;

        public CreateModel(CommunityApp_Lab3.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["ProvinceCode"] = new SelectList(_context.Provinces, "ProvinceCode", "ProvinceCode");
            return Page();
        }

        [BindProperty]
        public City City { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Cities.Add(City);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
