using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OffPractice.Data;

namespace OffPractice.Pages.Coaches
{
    public class IndexModel : PageModel
    {
        private readonly OffPractice.Data.ApplicationDbContext _context;

        public IndexModel(OffPractice.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Coach> Coach { get;set; }

        public async Task OnGetAsync()
        {
            Coach = await _context.Coach.ToListAsync();
        }
    }
}
