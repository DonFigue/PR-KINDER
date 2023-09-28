using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Institution.Data;
using Institution.Model;

namespace Institution.Pages.Tutors
{
    public class IndexModel : PageModel
    {
        /*
        private readonly Institution.Data.ApplicationDBContext _context;

        public IndexModel(Institution.Data.ApplicationDBContext context)
        {
            _context = context;
        }

        public IList<Tutor> Tutor { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Tutors != null)
            {
                Tutor = await _context.Tutors.ToListAsync();
            }
        }
        */
    }
}
