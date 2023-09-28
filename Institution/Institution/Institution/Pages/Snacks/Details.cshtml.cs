using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Institution.Data;
using Institution.Model;

namespace Institution.Pages.Snacks
{
    public class DetailsModel : PageModel
    {
        private readonly Institution.Data.ApplicationDBContext _context;

        public DetailsModel(Institution.Data.ApplicationDBContext context)
        {
            _context = context;
        }

      public Snack Snack { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Snack == null)
            {
                return NotFound();
            }

            var snack = await _context.Snack.FirstOrDefaultAsync(m => m.IdSnack == id);
            if (snack == null)
            {
                return NotFound();
            }
            else 
            {
                Snack = snack;
            }
            return Page();
        }
    }
}
