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
    public class DetailsModel : PageModel
    {
        private readonly Institution.Data.ApplicationDBContext _context;

        public DetailsModel(Institution.Data.ApplicationDBContext context)
        {
            _context = context;
        }

      public Tutor Tutor { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Tutors == null)
            {
                return NotFound();
            }

            var tutor = await _context.Tutors.FirstOrDefaultAsync(m => m.IdTutor == id);
            if (tutor == null)
            {
                return NotFound();
            }
            else 
            {
                Tutor = tutor;
            }
            return Page();
        }
    }
}
