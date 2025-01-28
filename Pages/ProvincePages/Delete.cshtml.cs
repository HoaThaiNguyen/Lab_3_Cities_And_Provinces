using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CommunityApp_Lab3.Data;
using CommunityApp_Lab3.Models;

namespace CommunityApp_Lab3.Pages_ProvincePages
{
    public class DeleteModel : PageModel
    {
        private readonly CommunityApp_Lab3.Data.ApplicationDbContext _context;

        public DeleteModel(CommunityApp_Lab3.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Province Province { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var province = await _context.Provinces.FirstOrDefaultAsync(m => m.ProvinceCode == id);

            if (province is not null)
            {
                Province = province;

                return Page();
            }

            return NotFound();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var province = await _context.Provinces.FindAsync(id);
            if (province != null)
            {
                Province = province;
                _context.Provinces.Remove(Province);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
