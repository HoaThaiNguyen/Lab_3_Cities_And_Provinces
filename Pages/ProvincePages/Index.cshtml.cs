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
    public class IndexModel : PageModel
    {
        private readonly CommunityApp_Lab3.Data.ApplicationDbContext _context;

        public IndexModel(CommunityApp_Lab3.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Province> Province { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Province = await _context.Provinces.ToListAsync();
        }
    }
}
