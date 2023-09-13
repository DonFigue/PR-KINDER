using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Institution.Data;
using Institution.Model;

namespace Institution.Pages.Professors
{
    public class IndexModel : PageModel
    {
        /*
        private readonly Institution.Data.ApplicationDBContext _context;

        public IndexModel(Institution.Data.ApplicationDBContext context)
        {
            _context = context;
        }

        public IList<Professor> Professor { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Professors != null)
            {
                Professor = await _context.Professors.ToListAsync();
            }
        }
        */
    }
}
