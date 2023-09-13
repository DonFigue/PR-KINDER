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
    public class DeleteModel : PageModel
    {
        /*
        private readonly Institution.Data.ApplicationDBContext _context;

        public DeleteModel(Institution.Data.ApplicationDBContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Tutors == null)
            {
                return NotFound();
            }
            var tutor = await _context.Tutors.FindAsync(id);

            if (tutor != null)
            {
                Tutor = tutor;
                _context.Tutors.Remove(Tutor);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
        */
    }
}
